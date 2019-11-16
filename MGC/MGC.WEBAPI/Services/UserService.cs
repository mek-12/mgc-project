using MGC.BLL.Concrete.MIdentity;
using MGC.CCC;
using MGC.WEBAPI.Helpers;
using MGC.WEBAPI.Models;
using MGC.WEBAPI.Services.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace MGC.WEBAPI.Services
{
    public class UserService : IUserService
    {

        private readonly IJwtTokenGenerator jwtTokenGenerator;
        public UserService(IJwtTokenGenerator jwtTokenGenerator)
        {
            this.jwtTokenGenerator = jwtTokenGenerator;
        }

        public CResult<string> Authenticate(UserCredentials userCredentials)
        {
            try
            {
                using (var _userManager = new UserManager())
                using (var _roleManager = new RoleManager())
                using (var _userRoleManager = new UserRoleManager())
                {
                    var user = _userManager.GetWithCondition(
                                c => c.UserName == userCredentials.UserName &&
                                c.Password == userCredentials.Password).Model;

                    var userRole = _userRoleManager.GetWithCondition(c => c.UserId == user.Id).Model;

                    if (userRole == null) return new CResult<string>() { Data = string.Empty, IsSucceeded = false, Message = "Role undefined" };

                    var role = _roleManager.GetWithCondition(c => c.Id == userRole.RoleId).Model;
                    var userInfo = new UserInfo()
                    {
                        FirstName = user.FirstName,
                        LastName = user.LastName,
                        HasAdminRights = false
                    };

                    var accessTokenResult = jwtTokenGenerator.GenerateAccessTokenWithClaimsPrincipal(
                        userCredentials.UserName,
                        role.Name,
                        AddClaims(userInfo));

                    return new CResult<string>() { Data = accessTokenResult.AccessToken ,Message ="Token Created", IsSucceeded = true};
                }
            }
            catch (Exception ex)
            {
                return new CResult<string>() { Data = string.Empty, IsSucceeded = false, Message = ex.Message };
            }
        }
        private static IEnumerable<Claim> AddClaims(UserInfo authenticatedUser)
        {
            var myClaims = new List<Claim>
            {
                new Claim(ClaimTypes.GivenName, authenticatedUser.FirstName),
                new Claim(ClaimTypes.Surname, authenticatedUser.LastName),
                new Claim("HasAdminRights", authenticatedUser.HasAdminRights ? "Y" : "N")
            };

            return myClaims;
        }
    }
}
