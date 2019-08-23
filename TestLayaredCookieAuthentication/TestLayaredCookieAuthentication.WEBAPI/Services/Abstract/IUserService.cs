using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TestLayaredCookieAuthentication.ENTITIES.Identity;

namespace TestLayaredCookieAuthentication.WEBAPI.Services.Abstract
{
    public interface IUserService
    {
        ApplicationUser GetUserFromUserName(string userName, string password);
        IEnumerable<ApplicationUser> GetAllUser();
    }
}
