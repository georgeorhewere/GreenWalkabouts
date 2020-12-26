using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Walkabouts.Data.Domain;
using Walkabouts.Repository.Context;
using Walkabouts.Services.Implementations;
using Walkabouts.Services.Interfaces;

namespace Walkabouts.API
{
    public class Startup
    {
        readonly string DevOrigins = "DevOrigins";

        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            //services.Configure<AppSettings>(Configuration);
            //var appSettings = Configuration.Get<AppSettings>();
            

            var dbConnStr = Configuration["WalkaboutDb"];
            services.AddDbContext<WalkaboutsDbContext>(options => options.UseSqlServer(dbConnStr));

            services.AddIdentity<AppUser, AppRole>(options => {
                options.SignIn.RequireConfirmedAccount = true;
                options.Password.RequireDigit = true;
                options.Password.RequiredLength = 6;
                options.Password.RequireNonAlphanumeric = false;
                options.Password.RequireUppercase = false;
                options.Password.RequireLowercase = false;
            })
                    .AddEntityFrameworkStores<WalkaboutsDbContext>()
                    .AddDefaultTokenProviders();

            services.AddWalkaboutServices();
            services.AddCors(options =>
            {
                options.AddPolicy(name: DevOrigins,
                                  builder =>
                                  {
                                      builder.WithOrigins("http://localhost:73")
                                      .AllowAnyHeader()
                                      .AllowAnyMethod()
                                      .AllowCredentials();
                                      
                                  }
                                  );
            });

            services.AddControllers()
             .AddNewtonsoftJson(options =>
                            options.SerializerSettings.ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore
                );
            services.AddSwaggerGen();
            services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());






        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseHttpsRedirection();

            app.UseRouting();
            InitializeDb(app);
            app.UseAuthentication();
            // app.UseAuthorization();
            app.UseCors(DevOrigins);
            
            app.UseSwagger();
            
            // Enable middleware to serve swagger-ui (HTML, JS, CSS, etc.),
            // specifying the Swagger JSON endpoint.
            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "My API V1");
            });

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });

       
        }



        private async void InitializeDb(IApplicationBuilder app)
        {
            try
            {
                using (var scope = app.ApplicationServices.GetService<IServiceScopeFactory>().CreateScope())
                {
                    var db = scope.ServiceProvider.GetRequiredService<WalkaboutsDbContext>();

                    await db.Database.MigrateAsync();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
    }
}
