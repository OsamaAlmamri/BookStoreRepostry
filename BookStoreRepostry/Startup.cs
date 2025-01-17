using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using StaticData.Models;
using StaticData.Models.Repositores;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc.Authorization;

namespace StaticData
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
            services.AddControllersWithViews();


            services.AddMvc(config=>
            {
                //to add auth to all project
                var poilcy = new AuthorizationPolicyBuilder().RequireAuthenticatedUser().Build();
                config.Filters.Add(new AuthorizeFilter(poilcy));
            });



            /* services.AddSingleton<IBookrepository<Author>, AuthorRepostry>();
             services.AddSingleton<IBookrepository<Book>, BookRepostry>();*/
         //    services.use
            services.AddScoped<IBookrepository<Author>, AuthorDBRepostry>();
            services.AddScoped<IBookrepository<Book>, BookDBRepostry>();
            services.AddDbContext<BookStoreDBContext>(options =>
            {
                options.UseSqlServer(Configuration.GetConnectionString("SqlCon2019"));
            });


            services.AddIdentity<IdentityUser, IdentityRole>(options =>
            {
                options.Password.RequiredLength = 6;
                options.Password.RequireLowercase = false;
                options.Password.RequireDigit = false;
                options.Password.RequireNonAlphanumeric = false;

            }).AddEntityFrameworkStores<BookStoreDBContext>();

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseBrowserLink();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }
            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();


            app.UseAuthorization();
        
            app.UseAuthentication();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
