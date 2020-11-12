using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Autofac;
using ForexAppApi.Services;

namespace ForexAppApi
{
    public class AutofacModule: Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<ForexDataService>().As<IForexDataService>();
        }
    }
}
