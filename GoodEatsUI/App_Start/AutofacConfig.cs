using Autofac;
using Autofac.Integration.Mvc;
using GoodEatsUI;
using GoodEatsUI.Controllers;
using GoodEatsUI.Models;
using System.Reflection;
using System.Web.Mvc;
using WebApplicationLibrary.Api;
using WebApplicationLibrary.Models;

namespace UserAccAPI.App_Start
{
    public class AutofacConfig
    {
        public static void ConfigureContainer()
        {
            var builder = new ContainerBuilder();


            builder.RegisterControllers(typeof(MvcApplication).Assembly);


            //builder.RegisterControllers(Assembly.GetExecutingAssembly());

            //builder.RegisterControllers(typeof(MvcApplication).Assembly);

            builder.RegisterType<AuthenticatedUser>().As<IAuthenticatedUser>();
            builder.RegisterType<APIHelper>().As<IAPIHelper>();
            builder.RegisterType<LoginAction>().As<ILoginAction>();

            var container = builder.Build();


            DependencyResolver.SetResolver(new AutofacDependencyResolver(container));

        }
    }
}