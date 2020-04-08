using Autofac;
using Autofac.Integration.Mvc;
using Autofac.Integration.WebApi;
using GoodEatsUI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using WebApplicationLibrary.Api;

namespace UserAccAPI.App_Start
{
    public class AutofacApiConfig
    {
        public static void ConfigureContainer()
        {
            var builder = new ContainerBuilder();

            builder.RegisterControllers(Assembly.GetExecutingAssembly());

            builder.RegisterType<APIHelper>().As<IAPIHelper>();

            var container = builder.Build();

            var resolver = new AutofacWebApiDependencyResolver(container);

            GlobalConfiguration.Configuration.DependencyResolver = resolver;
        }
    }
}