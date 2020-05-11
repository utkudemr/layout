using Autofac;
using Autofac.Extras.DynamicProxy;
using Castle.DynamicProxy;
using Core.Utilities.Interceptors;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace Business.DependencyResolvers.Autofac
{
    public class InstanceFactory
    {
        private static ContainerBuilder _container;
        private static IContainer container;

        public static void Initialize()
        {
            _container = new ContainerBuilder();
            _container.RegisterModule(new AutofacBusinessModule());
            container = _container.Build();

        }

        public static T GetInstance<T>()
        {
            Initialize();
            return container.Resolve<T>();
        }
    }
}
