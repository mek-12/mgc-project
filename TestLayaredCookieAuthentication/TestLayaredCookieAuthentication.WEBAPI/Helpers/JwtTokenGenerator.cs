﻿using Microsoft.AspNetCore.Authentication;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using TestLayaredCookieAuthentication.WEBAPI.Helpers.Abstract;

namespace TestLayaredCookieAuthentication.WEBAPI.Helpers
{
    public sealed class JwtTokenGenerator : IJwtTokenGenerator
    {
        private readonly TokenOptions tokenOptions;

        public JwtTokenGenerator(TokenOptions tokenOptions)
        {
            this.tokenOptions = tokenOptions ??
                throw new ArgumentNullException(
                    $"An instance of valid {nameof(TokenOptions)} must be passed in order to generate a JWT!");
        }

        public string GenerateAccessToken(string userName, string role,IEnumerable<Claim> userClaims)
        {
            var expiration = TimeSpan.FromMinutes(this.tokenOptions.TokenExpiryInMinutes);

            var jwt = new JwtSecurityToken(issuer: this.tokenOptions.Issuer,
                                           audience: this.tokenOptions.Audience,
                                           claims: MergeUserClaimsWithDefaultClaims(userName, role, userClaims),
                                           notBefore: DateTime.UtcNow,
                                           expires: DateTime.UtcNow.Add(expiration),
                                           signingCredentials: new SigningCredentials(
                                               this.tokenOptions.SigningKey,
                                               SecurityAlgorithms.HmacSha256));

            var accessToken = new JwtSecurityTokenHandler().WriteToken(jwt);

            return accessToken;
        }

        public TokenWithClaimsPrincipal GenerateAccessTokenWithClaimsPrincipal(string userName, string role ,IEnumerable<Claim> userClaims)
        {
            var userClaimList = userClaims.ToList();
            var accessToken = this.GenerateAccessToken(userName, role, userClaimList);

            return new TokenWithClaimsPrincipal()
            {
                AccessToken = accessToken,
                ClaimsPrincipal = ClaimsPrincipalFactory.CreatePrincipal(
                    MergeUserClaimsWithDefaultClaims(userName, role, userClaimList)),
                AuthProperties = CreateAuthProperties(accessToken)
            };

        }

        private static AuthenticationProperties CreateAuthProperties(string accessToken)
        {
            var authProps = new AuthenticationProperties();
            authProps.StoreTokens(
                new[]
                {
                    new AuthenticationToken()
                    {
                        Name = TokenConstants.TokenName,
                        Value = accessToken
                    }
                });

            return authProps;
        }

        private static IEnumerable<Claim> MergeUserClaimsWithDefaultClaims(
            string userName, 
            string role,
            IEnumerable<Claim> userClaims)
        {
            var claims = new List<Claim>(userClaims)
            {
                new Claim(ClaimTypes.Name, userName),
                new Claim(JwtRegisteredClaimNames.Sub, userName),
                new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString()),
                new Claim(JwtRegisteredClaimNames.Iat, DateTime.UtcNow.TimeOfDay.Ticks.ToString(),
                    ClaimValueTypes.Integer64),
                new Claim(ClaimTypes.Role, role)
            };

            return claims;
        }
    }
}
