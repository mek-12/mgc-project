using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace TestLayaredCookieAuthentication.WEBAPI.Helpers.Abstract
{
    public interface IJwtTokenGenerator
    {
        TokenWithClaimsPrincipal GenerateAccessTokenWithClaimsPrincipal(string userName, string role,
            IEnumerable<Claim> userClaims);

        string GenerateAccessToken(string userName, string role, IEnumerable<Claim> userClaims);
    }
}
