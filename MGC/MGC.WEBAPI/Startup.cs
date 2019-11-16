using System;
using MGC.WEBAPI.Extensions;
using MGC.WEBAPI.Helpers;
using MGC.WEBAPI.Services;
using MGC.WEBAPI.Services.Abstract;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace MGC.WEBAPI
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
            services.AddControllers();

            var tokenOptions = new TokenOptions(
                Configuration["Token:Issuer"],
                Configuration["Token:Audience"],
                Configuration["Token:SigningSecret"],
                Convert.ToInt32(Configuration["Token:ExpiryDuration"]));

            services.JwtAuthenticationForAPI(
                tokenOptions);

            services.AddScoped<IUserService, UserService>();
            services.AddAuthorization(options =>
            {
                options.AddPolicy("RequiresAdmin", policy => policy.RequireClaim("HasAdminRights"));
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseRouting();
            app.UseCookiePolicy();
            app.UseAuthentication();
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
