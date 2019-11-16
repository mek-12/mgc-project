using Microsoft.IdentityModel.Tokens;
using System;
using System.Text;

namespace MGC.WEBAPI.Helpers
{
    public class TokenOptions
    {
        
        public TokenOptions(string issuer,
                            string audience,
                            string signingKey,
                            int tokenExpiryInMinutes = 15)
        {
            if (string.IsNullOrWhiteSpace(audience))
            {
                throw new ArgumentNullException(
                    $"{nameof(Audience)} is mandatory in order to generate a JWT!");
            }

            if (string.IsNullOrWhiteSpace(issuer))
            {
                throw new ArgumentNullException(
                    $"{nameof(Issuer)} is mandatory in order to generate a JWT!");
            }

            Audience = audience;
            Issuer = issuer;
            SigningKey = new SymmetricSecurityKey(
                    Encoding.ASCII.GetBytes(signingKey)) ??
                throw new ArgumentNullException(
                    $"{nameof(SigningKey)} is mandatory in order to generate a JWT!");
            TokenExpiryInMinutes = tokenExpiryInMinutes;
        }
        public SecurityKey SigningKey { get; }

        public string Issuer { get; }

        public string Audience { get; }

        public int TokenExpiryInMinutes { get; }
    }
    public struct TokenConstants
    {
        public const string TokenName = "jwt";
    }
}
