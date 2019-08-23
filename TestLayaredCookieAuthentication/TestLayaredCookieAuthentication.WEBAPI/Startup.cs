using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using TestLayaredCookieAuthentication.WEBAPI.Extensions;
using TestLayaredCookieAuthentication.ENTITIES.Identity;
using TestLayaredCookieAuthentication.WEBAPI.Helpers;
using System;

namespace TestLayaredCookieAuthentication.WEBAPI
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        readonly string MyAllowSpecificOrigins = "_myAllowSpecificOrigins";

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {

            services.AddIdentity<ApplicationUser, ApplicationRole>();

            var tokenOptions = new TokenOptions(
                Configuration["Token:Issuer"],
                Configuration["Token:Audience"],
                Configuration["Token:SigningSecret"],
                Convert.ToInt32(Configuration["Token:ExpiryDuration"]));

            services.JwtAuthenticationForAPI(
                tokenOptions);
            services.AddAuthorization(options =>
            {
                options.AddPolicy("RequiresAdmin", policy => policy.RequireClaim("HasAdminRights"));
            });

            services.AddCors(options => {
                options.AddPolicy(MyAllowSpecificOrigins,
                    builder => {
                        builder.WithOrigins("http://localhost:61591")
                        .AllowAnyHeader()
                        .AllowAnyMethod();
                    });
            });
            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_1);

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }


            
            app.UseCookiePolicy();
            app.UseAuthentication();

            app.UseCors(MyAllowSpecificOrigins);
            app.UseMvc();
        }
    }
}
