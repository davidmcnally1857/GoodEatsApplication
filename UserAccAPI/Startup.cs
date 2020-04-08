using System;
using System.Collections.Generic;
using System.Linq;
using Autofac;
using Microsoft.Owin;
using Owin;
using WebApplicationLibrary.Api;

[assembly: OwinStartup(typeof(UserAccAPI.Startup))]

namespace UserAccAPI
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }

    }
}
