﻿using Moq;

namespace Neo.Gui.ViewModels.Tests.AutoMock
{
    public interface IAutoMockContainer
    {
        T Create<T>();

        Mock<T> GetMock<T>() where T : class;

        void Register<TService, TImplementation>() where TImplementation : TService;

        void Register<TService>(TService instance);

        void Register<TService>(TService instance, string name);
    }
}
