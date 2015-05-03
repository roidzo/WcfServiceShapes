using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Autofac;
using WcfService1.Modules;

namespace WcfService1.Infrastructure
{
    public static class IoC
    {
        public static IContainer CreateContainer()
        {
            var builder = new ContainerBuilder();
            //builder.RegisterAssemblyModules(typeof(Program).Assembly);
            builder.RegisterModule<MainModule>();
            builder.RegisterModule<ServiceModule>();
            //builder.RegisterModule<LoggingModule>();
            //builder.RegisterModule<BusinessLogicModule>();
            //builder.RegisterAssemblyTypes(typeof(ContactModelFactory).Assembly)
            //    .InstancePerLifetimeScope();
            //builder.RegisterAssemblyTypes(typeof(ContactModelFactory).Assembly)
            //    .AsClosedTypesOf(typeof(ModelFactory<>))
            //    .InstancePerLifetimeScope();
            var container = builder.Build();
            return container;
        }
    }
}
