﻿using System.Data.Entity;
using Blog.Models;
using Microsoft.Owin;
using Newtonsoft.Json.Converters;
using Owin;
using Blog.Migrations;
using Blog.Models;

[assembly: OwinStartupAttribute(typeof(Blog.Startup))]
namespace Blog
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {

            Database.SetInitializer(
                new MigrateDatabaseToLatestVersion<BlogDbContext, Configuration>());

            ConfigureAuth(app);
        }
    }
}
