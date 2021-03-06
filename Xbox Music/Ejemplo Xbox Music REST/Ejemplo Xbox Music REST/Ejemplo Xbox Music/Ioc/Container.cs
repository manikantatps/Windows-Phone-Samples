﻿using Ejemplo_Xbox_Music.Services;
using Ejemplo_Xbox_Music.ViewModel;
using Microsoft.Practices.Unity;

namespace Ejemplo_Xbox_Music.Ioc
{
    public class Container : IContainer
    {  
        private readonly IUnityContainer _currentContainer;

        public Container()
        {
            _currentContainer = new UnityContainer();

            _currentContainer.RegisterType<MainViewModel>(new ContainerControlledLifetimeManager());

            _currentContainer.RegisterType<IXboxMusic, XboxMusic>();
        }

        public T Resolve<T>()
        {
            return _currentContainer.Resolve<T>();
        }
    }
}
