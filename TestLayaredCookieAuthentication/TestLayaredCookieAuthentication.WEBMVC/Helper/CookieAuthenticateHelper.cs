using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using TestLayaredCookieAuthentication.WEBMVC.Models;

namespace TestLayaredCookieAuthentication.WEBMVC.Helper
{
    public class CookieAuthenticateHelper : IDisposable
    {
        internal ClaimsPrincipal GetPrincipal(UserInfo user)
        {
            try
            {
                var claims = new List<Claim>
                {
                    new Claim(ClaimTypes.GivenName, user.FirstName),
                    new Claim(ClaimTypes.Surname, user.LastName),
                    new Claim(ClaimTypes.Email, user.Email),
                    new Claim(ClaimTypes.Role, user.Role)
                };

                var userIdentity = new ClaimsIdentity(claims, "login");

                ClaimsPrincipal principal = new ClaimsPrincipal(userIdentity);
                return principal;
            }
            catch (Exception)
            {
                return null;
            }
        }
        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }
    }
}
