﻿using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Web_NCKH.Startup))]
namespace Web_NCKH
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
