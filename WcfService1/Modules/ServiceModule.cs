using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Autofac;
using WcfService1.Services;


namespace WcfService1.Modules
{
    public class ServiceModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            base.Load(builder);

            builder.RegisterType<WcfService1.QuadrilateralTypeService>();

            builder.RegisterType(typeof(QuadrilateralTypeService))
                .As(typeof(IQuadrilateralTypeService))
                .SingleInstance()
                ;

            builder.RegisterType(typeof(QuadrilateralService))
               .As(typeof(IQuadrilateralService))
               ;

        }
    }
}
