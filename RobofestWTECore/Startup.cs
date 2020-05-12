using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RobofestWTECore.Data;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using RobofestWTE;
using RobofestWTECore.Models;
using RobofestWTECore.Controllers;
using OdeToCode.AddFeatureFolders;
using Microsoft.AspNet.Mvc.Razor;
using Serilog.Extensions.Logging;
using Serilog;
using Microsoft.Extensions.Logging;
using Serilog.Formatting.Json;
using System.Net;
using System;

namespace RobofestWTECore
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.Configure<CookiePolicyOptions>(options =>
            {
                // This lambda determines whether user consent for non-essential cookies is needed for a given request.
                options.CheckConsentNeeded = context => true;
                options.MinimumSameSitePolicy = SameSiteMode.None;
            });
            
            services.AddDbContext<ApplicationDbContext>(options =>
                options.UseNpgsql(
                    Configuration.GetConnectionString("DefaultConnection")));
            services.AddDbContext<GameContext>(options =>
                options.UseNpgsql(
                    Configuration.GetConnectionString("RobofestWTE")));
            services.AddIdentity<ApplicationUser, IdentityRole>()
                    .AddDefaultUI()
                    .AddDefaultTokenProviders()
                    .AddEntityFrameworkStores<ApplicationDbContext>();
            
            services.AddSignalR(hubOptions => {
                hubOptions.EnableDetailedErrors = true;
                hubOptions.KeepAliveInterval = TimeSpan.FromSeconds(10);
                hubOptions.HandshakeTimeout = TimeSpan.FromSeconds(30);
            });
            services.AddSingleton<Controller, TeamController>();
            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_1);
            services.Configure<RazorViewEngineOptions>(options => {
                options.ViewLocationExpanders.Add(new ViewLocationExpander());
            });
            services.AddLogging(config =>
            {
                config.ClearProviders();
                config.AddConfiguration(Configuration.GetSection("Loggin"));
                config.AddDebug();
                config.AddEventSourceLogger();
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env, ILoggerFactory loggerFactory)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseDatabaseErrorPage();
                app.UseSignalR(routes =>
                {
                    routes.MapHub<ScoreHub>("/scoreHub");
                });
            }
            else
            {
                app.UseExceptionHandler("/Error");
                app.UseHsts();
                app.UseSignalR(routes =>
                {
                    routes.MapHub<ScoreHub>("/scoreHub");
                });
            }
            app.UseHttpsRedirection();
            app.UseForwardedHeaders(new ForwardedHeadersOptions
            {
                ForwardedHeaders = Microsoft.AspNetCore.HttpOverrides.ForwardedHeaders.All
            });
            app.UseStaticFiles();
            app.UseCookiePolicy();
            
            app.UseAuthentication();
            app.UseMvc(routes =>
            {
                routes.MapRoute("default", "{controller=Home}/{action=Index}/{id?}");
            });
            //var log = new LoggerConfiguration().MinimumLevel.Debug().WriteTo.File(new JsonFormatter(),@"C:\inetpub\serilog\{Date}.txt", shared: true).CreateLogger();
            //loggerFactory.AddSerilog(log);
            ServicePointManager.DefaultConnectionLimit = int.MaxValue;
        }
    }
}
