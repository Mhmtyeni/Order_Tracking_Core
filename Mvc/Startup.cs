using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Diagnostics;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Mvc.Hubs;
using Mvc.Models.Concrete;
using Mvc.Models.Context;
using System;
using System.IO;
using System.Net;
using System.Text.Json.Serialization;

namespace Mvc
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
            services.AddDbContext<Context>();
            services.AddIdentity<AppUser, AppRole>(options =>
            {
                options.Password.RequiredLength = 3;
                options.Password.RequireLowercase = false;
                options.Password.RequireUppercase = false;
                options.Password.RequireNonAlphanumeric = false;
                options.Password.RequireDigit = false;
                options.User.RequireUniqueEmail = true;
            }).AddEntityFrameworkStores<Context>();
            services.AddControllersWithViews().AddRazorRuntimeCompilation();
            services.AddHttpContextAccessor();
            services.AddMvc();
            services.AddSession();
            services.AddSignalR().AddNewtonsoftJsonProtocol();
            services.ConfigureApplicationCookie(options =>
            {
                options.LoginPath = new PathString("/Login/Index");
                options.LogoutPath = new PathString("/Login/Logout");
                options.AccessDeniedPath = new PathString("/Home/AccessDenied");
                options.Cookie = new CookieBuilder
                {
                    Name = "OrderTracking",
                    HttpOnly = true,
                    SameSite = SameSiteMode.Strict,
                    SecurePolicy = CookieSecurePolicy.SameAsRequest // Always
                };
                options.SlidingExpiration = true;
                options.ExpireTimeSpan = TimeSpan.FromDays(365);
            });
        }
        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                app.UseStatusCodePagesWithRedirects("/Home/PageNotFound");
            }
            app.UseSession();
            app.UseStaticFiles();
            app.UseRouting();
            app.UseAuthentication();
            app.UseAuthorization();
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapHub<OrderHub>("/orderhub");
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Login}/{action=Index}/{id?}",null,null,null);
            });
        }
    }
}
