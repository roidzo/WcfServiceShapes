using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Autofac;
using Serilog;
using System.Configuration;
using WcfService1.Infrastructure;

namespace WcfService1.Modules
{
    public class MainModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            base.Load(builder);

            var logFilePath = ConfigurationManager.AppSettings["LogFilePath"];

            builder.Register(o => new ConfigurationSettingProvider()).As<IConfigurationSettingProvider>();

            builder.Register(c => new LoggerConfiguration()
                .WriteTo.File(logFilePath)
                .CreateLogger()).
                As<ILogger>().SingleInstance();
        }
    }
}
