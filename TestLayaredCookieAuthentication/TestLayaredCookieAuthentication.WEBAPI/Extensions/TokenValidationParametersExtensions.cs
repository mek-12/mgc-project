﻿using Microsoft.IdentityModel.Tokens;
using System;
using TestLayaredCookieAuthentication.WEBAPI.Helpers;

namespace TestLayaredCookieAuthentication.WEBAPI.Extensions
{
    public static class TokenValidationParametersExtensions
    {
        internal static TokenValidationParameters ToTokenValidationParams(
            this TokenOptions tokenOptions) =>
            new TokenValidationParameters
            {
                ClockSkew = TimeSpan.Zero,

                ValidateAudience = true,
                ValidAudience = tokenOptions.Audience,

                ValidateIssuer = true,
                ValidIssuer = tokenOptions.Issuer,

                IssuerSigningKey = tokenOptions.SigningKey,
                ValidateIssuerSigningKey = true,

                RequireExpirationTime = true,
                ValidateLifetime = true
            };
    }
}
