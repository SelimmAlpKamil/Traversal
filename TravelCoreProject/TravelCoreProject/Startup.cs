
using BusinessLayer.Abstract.Abstractuow;
using BusinessLayer.Concreate;
using BusinessLayer.Concreate.Concreateuow;
using BusinessLayer.Validation;
using DataAccessLayer.Abstract.Abstractuow;
using DataAccessLayer.Concreate;
using DataAccessLayer.EntityFramework;
using DataAccessLayer.EntityFramework.EntityFrameworkuow;
using DataAccessLayer.UnitOfWork;
using DTOLayer.AnnouncementDTOs;
using EntityLayer.Concreate;
using FluentValidation;
using FluentValidation.AspNetCore;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc.Authorization;
using Microsoft.CodeAnalysis.Diagnostics;
using Microsoft.EntityFrameworkCore.Migrations.Operations;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using TravelCoreProject.CQRS.Handlers.DestinationHandlers;
using TravelCoreProject.Models;

namespace TravelCoreProject
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

            services.AddIdentity<AppUser,AppRole>().AddEntityFrameworkStores<Context>().AddErrorDescriber<CostemIdentityValidationcs>().AddTokenProvider<DataProtectorTokenProvider<AppUser>>(TokenOptions.DefaultProvider).AddEntityFrameworkStores<Context>();

            services.AddLogging(options =>
            {
                options.ClearProviders();

                options.SetMinimumLevel(LogLevel.Debug);

                options.AddDebug();
            });


            services.AddScoped<GetAllDestinatonQueriesHandlers>();
            services.AddScoped<GetByIdDestinatonHandlers>();
            services.AddScoped<CreateDestinationHandlers>();
            services.AddScoped<DeleteDestinatonHandler>();
            services.AddScoped<UpdateDestinationHandlers>();
        

            services.AddScoped<UserManager<AppUser>>();
            services.AddScoped<SignInManager<AppUser>>();


            services.AddScoped<EFUserDAL>();
            services.AddScoped<RoleManager<AppRole>>();



            services.AddScoped<IAccondService,AccondManager>();
            services.AddScoped<IAccoundDAL, EFAccoundDAL>();

            services.AddScoped<IuofDAL, uowDAL>();



            services.AddMediatR(typeof(Startup));

            services.AddAutoMapper(typeof(Startup));
            services.AddTransient<IValidator<AnnouncementAddDTOs>,AnnouncementValidation>();

            services.AddTransient<IValidator<AnnouncementUppdateDTOs>, AnnouncementValidationUppdate>();

            services.AddControllersWithViews().AddFluentValidation();

            services.AddMvc(config =>
            {
                var policy = new AuthorizationPolicyBuilder().RequireAuthenticatedUser().Build();

                config.Filters.Add(new AuthorizeFilter(policy));

            });

            services.AddHttpClient();
            

            services.AddMvc();


            services.ConfigureApplicationCookie(options =>
            {
                options.Cookie.HttpOnly = true;
                options.ExpireTimeSpan = TimeSpan.FromMinutes(60);
                options.LoginPath = "/Login/SingIn";
                options.AccessDeniedPath = "/Account/AccessDenied";
                options.SlidingExpiration = true;
            });

            services.AddLogging(options =>
            {
                options.ClearProviders();
                options.SetMinimumLevel(LogLevel.Debug);
                options.AddDebug();
            });


        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env,ILoggerFactory loggerFactory)
        {
            var path = Directory.GetCurrentDirectory();
            loggerFactory.AddFile($"{path}\\Logs\\\\Logs1.txt");


            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }
            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseAuthentication();

            app.UseStatusCodePagesWithReExecute("/Error/Page404","?code={0}");

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });

			app.UseEndpoints(endpoints =>
			{
				endpoints.MapControllerRoute(
				  name: "areas",
				  pattern: "{area:exists}/{controller=Home}/{action=Index}/{id?}"
				);
			});

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                  name: "areas",
                  pattern: "{area:exists}/{controller=Home}/{action=Index}/{id?}"
                );
            });
        }
    }
}
