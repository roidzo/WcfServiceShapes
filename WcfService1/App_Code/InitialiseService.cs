using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WcfService1.Infrastructure;
using Autofac;
using Autofac.Integration.Wcf;

namespace WcfService1.App_Code
{
    public class InitialiseService
    {
        /// <summary>
        /// Application initialisation method where we register our IOC container.
        /// </summary>
        public static void AppInitialize()
        {
            var container =  IoC.CreateContainer();
            AutofacHostFactory.Container = container;
        }
    }
}
