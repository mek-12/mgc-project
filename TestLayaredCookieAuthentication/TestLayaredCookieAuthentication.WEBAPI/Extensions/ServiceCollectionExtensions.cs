using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.Extensions.DependencyInjection;
using System;
using TestLayaredCookieAuthentication.WEBAPI.Helpers;
using TestLayaredCookieAuthentication.WEBAPI.Helpers.Abstract;

namespace TestLayaredCookieAuthentication.WEBAPI.Extensions
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection JwtAuthenticationForAPI(
            this IServiceCollection services, TokenOptions tokenOptions)
        {
            if(tokenOptions == null)
            {
                throw new ArgumentNullException($"{nameof(tokenOptions)} is a required parameter. " +
                    $"Please make sure you've provided a valid instance with the appropriate values configured.");
            }
            services.AddScoped<IJwtTokenGenerator, JwtTokenGenerator>(
                serviveProvider => new JwtTokenGenerator(tokenOptions));
            services.AddAuthentication(options => {
                options.DefaultAuthenticateScheme =
                    JwtBearerDefaults.AuthenticationScheme;
                options.DefaultSignInScheme =
                    JwtBearerDefaults.AuthenticationScheme;
                options.DefaultChallengeScheme =
                    JwtBearerDefaults.AuthenticationScheme;
            }).
            AddJwtBearer(JwtBearerDefaults.AuthenticationScheme, options =>
            {
                options.SaveToken = true;
                options.TokenValidationParameters =
                tokenOptions.ToTokenValidationParams();
            });
            return services;
        }
    }
}
