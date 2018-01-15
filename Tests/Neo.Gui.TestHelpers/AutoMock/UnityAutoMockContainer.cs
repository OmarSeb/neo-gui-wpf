﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using Moq;
using Unity;
using Unity.Lifetime;

namespace Neo.Gui.TestHelpers.AutoMock
{
    public class UnityAutoMockContainer : UnityContainer, IAutoMockContainer
    {
        private readonly Dictionary<Type, AsExpression> asExpressions;

        public UnityAutoMockContainer(MockRepository mockRepository)
        {
            this.AddExtension(new UnityAutoMoqExtension(mockRepository, this));

            this.asExpressions = new Dictionary<Type, AsExpression>();
        }

        [DebuggerStepThrough]
        public T Create<T>()
        {
            return (T)Resolve(typeof(T), null);
        }

        [DebuggerStepThrough]
        public Mock<T> GetMock<T>() where T : class
        {
            return Mock.Get(this.Create<T>());
        }

        [DebuggerStepThrough]
        public void Register<TService, TImplementation>() where TImplementation : TService
        {
            this.RegisterType<TService, TImplementation>(new ContainerControlledLifetimeManager());
        }

        [DebuggerStepThrough]
        public void Register<TService>(TService instance)
        {
            this.RegisterInstance(instance);
        }

        [DebuggerStepThrough]
        public void Register<TService>(TService instance, string name)
        {
            this.RegisterInstance(name, instance);
        }

        [DebuggerStepThrough]
        internal AsExpression GetInterfaceImplementations(Type t)
        {
            return this.asExpressions.ContainsKey(t) ? this.asExpressions[t] : null;
        }
    }
}
