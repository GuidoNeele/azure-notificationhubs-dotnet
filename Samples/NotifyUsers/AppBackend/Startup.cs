﻿using Microsoft.Owin;
using Owin;

[assembly: OwinStartup(typeof(AppBackend.Startup))]

namespace AppBackend
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
