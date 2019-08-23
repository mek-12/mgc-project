using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TestLayaredCookieAuthentication.ENTITIES.Identity;
using TestLayaredCookieAuthentication.WEBAPI.Services.Abstract;

namespace TestLayaredCookieAuthentication.WEBAPI.Services
{
    public class UserService : IUserService
    {
        public IEnumerable<ApplicationUser> GetAllUser()
        {
            throw new NotImplementedException();
        }

        public ApplicationUser GetUserFromUserName(string userName, string password)
        {
            throw new NotImplementedException();
        }
    }
}
