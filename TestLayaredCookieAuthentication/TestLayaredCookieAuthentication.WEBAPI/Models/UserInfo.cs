using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestLayaredCookieAuthentication.WEBAPI.Models
{
    public class UserInfo
    {
        public string UserName { get; set; }
        public string Password { get; set; }
        public string FirstName { get; set; }
        public string Email { get; set; }
        public string LastName { get; set; }
        public string Token { get; set; }
        public string Role { get; set; }
        public bool HasAdminRights { get; set; }
    }
}
