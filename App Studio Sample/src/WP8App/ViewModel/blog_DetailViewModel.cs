// ------------------------------------------------------------------------
// ========================================================================
// THIS CODE AND INFORMATION ARE GENERATED BY AUTOMATIC CODE GENERATOR
// ========================================================================
// Template:   ViewModel.tt
using System;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Windows.Input;
using WPAppStudio;
using WPAppStudio.Controls;
using WPAppStudio.Entities;
using WPAppStudio.Entities.Base;
using WPAppStudio.Localization;
using WPAppStudio.Repositories;
using WPAppStudio.Services;
using WPAppStudio.Services.Interfaces;
using WPAppStudio.Shared;
using WPAppStudio.ViewModel.Base;
using WPAppStudio.ViewModel.Interfaces;

namespace WPAppStudio.ViewModel
{
    /// <summary>
    /// Implementation of blog_Detail ViewModel.
    /// </summary>
    [System.Runtime.CompilerServices.CompilerGenerated]
    [System.CodeDom.Compiler.GeneratedCode("Radarc", "4.0")]
    public partial class blog_DetailViewModel : BindableBase, Iblog_DetailViewModel, INavigable
    {       

		private readonly IDialogService _dialogService;
		private readonly INavigationService _navigationService;
		private readonly ISpeechService _speechService;
		private readonly IShareService _shareService;
		private readonly ILiveTileService _liveTileService;
		
        /// <summary>
        /// Initializes a new instance of the <see cref="blog_DetailViewModel" /> class.
        /// </summary>
        /// <param name="dialogService">The Dialog Service.</param>
        /// <param name="navigationService">The Navigation Service.</param>
        /// <param name="speechService">The Speech Service.</param>
        /// <param name="shareService">The Share Service.</param>
        /// <param name="liveTileService">The Live Tile Service.</param>
        public blog_DetailViewModel(IDialogService dialogService, INavigationService navigationService, ISpeechService speechService, IShareService shareService, ILiveTileService liveTileService)
        {
			_dialogService = dialogService;
			_navigationService = navigationService;
			_speechService = speechService;
			_shareService = shareService;
			_liveTileService = liveTileService;
        }
		

		private RssSearchResult _currentRssSearchResult;

        /// <summary>
        /// CurrentRssSearchResult property.
        /// </summary>		
        public RssSearchResult CurrentRssSearchResult
        {
            get
            {
				return _currentRssSearchResult;
            }
            set
            {
                SetProperty(ref _currentRssSearchResult, value);
            }
        }

        /// <summary>
        /// Delegate method for the TextToSpeechblog_DetailStaticControlCommand command.
        /// </summary>
        public  void TextToSpeechblog_DetailStaticControlCommandDelegate() 
        {
	
				_speechService.TextToSpeech(CurrentRssSearchResult.Title + " " + CurrentRssSearchResult.Content);
        }
		

        private ICommand _textToSpeechblog_DetailStaticControlCommand;

        /// <summary>
        /// Gets the TextToSpeechblog_DetailStaticControlCommand command.
        /// </summary>
        public ICommand TextToSpeechblog_DetailStaticControlCommand
        {
            get { return _textToSpeechblog_DetailStaticControlCommand = _textToSpeechblog_DetailStaticControlCommand ?? new DelegateCommand(TextToSpeechblog_DetailStaticControlCommandDelegate); }
        }

        /// <summary>
        /// Delegate method for the Shareblog_DetailStaticControlCommand command.
        /// </summary>
        public  void Shareblog_DetailStaticControlCommandDelegate() 
        {
	
				_shareService.Share(CurrentRssSearchResult.Title, CurrentRssSearchResult.Content, CurrentRssSearchResult.FeedUrl);
        }
		

        private ICommand _shareblog_DetailStaticControlCommand;

        /// <summary>
        /// Gets the Shareblog_DetailStaticControlCommand command.
        /// </summary>
        public ICommand Shareblog_DetailStaticControlCommand
        {
            get { return _shareblog_DetailStaticControlCommand = _shareblog_DetailStaticControlCommand ?? new DelegateCommand(Shareblog_DetailStaticControlCommandDelegate); }
        }

        /// <summary>
        /// Delegate method for the PinToStartblog_DetailStaticControlCommand command.
        /// </summary>
        public  void PinToStartblog_DetailStaticControlCommandDelegate() 
        {
	
				_liveTileService.PinToStart(typeof(Iblog_DetailViewModel), CreateTileInfoblog_DetailStaticControl());
        }
		

        private ICommand _pinToStartblog_DetailStaticControlCommand;

        /// <summary>
        /// Gets the PinToStartblog_DetailStaticControlCommand command.
        /// </summary>
        public ICommand PinToStartblog_DetailStaticControlCommand
        {
            get { return _pinToStartblog_DetailStaticControlCommand = _pinToStartblog_DetailStaticControlCommand ?? new DelegateCommand(PinToStartblog_DetailStaticControlCommandDelegate); }
        }

        /// <summary>
        /// Delegate method for the GoToSourceblog_DetailStaticControlCommand command.
        /// </summary>
        public  void GoToSourceblog_DetailStaticControlCommandDelegate() 
        {
	
				_navigationService.NavigateTo(new Uri(CurrentRssSearchResult.FeedUrl));
        }
		

        private ICommand _goToSourceblog_DetailStaticControlCommand;

        /// <summary>
        /// Gets the GoToSourceblog_DetailStaticControlCommand command.
        /// </summary>
        public ICommand GoToSourceblog_DetailStaticControlCommand
        {
            get { return _goToSourceblog_DetailStaticControlCommand = _goToSourceblog_DetailStaticControlCommand ?? new DelegateCommand(GoToSourceblog_DetailStaticControlCommandDelegate); }
        }
		public object NavigationContext
        {
            set
            {              
                if (!(value is RssSearchResult)) { return; }
                
                CurrentRssSearchResult = value as RssSearchResult;
            }
        }
        /// <summary>
        /// Initializes a <see cref="TileInfo" /> object for the blog_DetailStaticControl control.
        /// </summary>
		/// <returns>A <see cref="TileInfo" /> object.</returns>
        public TileInfo CreateTileInfoblog_DetailStaticControl()
        {
            var tileInfo = new TileInfo
            {
                CurrentId = CurrentRssSearchResult.Title,
                Title = CurrentRssSearchResult.Title,
                BackTitle = CurrentRssSearchResult.Title,
                BackContent = CurrentRssSearchResult.Content,
                Count = 0,
                BackgroundImagePath = CurrentRssSearchResult.ImageUrl,
                BackBackgroundImagePath = CurrentRssSearchResult.ImageUrl,
                LogoPath = "Logo-3ed85fce-a84f-465c-836d-47785f43766a.png"
            };
            return tileInfo;
        }
    }
}
