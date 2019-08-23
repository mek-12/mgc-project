using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using TestLayaredCookieAuthentication.BLL.Abstract;
using TestLayaredCookieAuthentication.BLL.Concrete;
using TestLayaredCookieAuthentication.WEBAPI.Helpers.Abstract;
using TestLayaredCookieAuthentication.WEBAPI.Models;

namespace TestLayaredCookieAuthentication.WEBAPI.Controllers
{
    [Produces("application/json")]
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly IJwtTokenGenerator jwtTokenGenerator;

        public AuthController(IJwtTokenGenerator jwtTokenGenerator)
        {
            this.jwtTokenGenerator = jwtTokenGenerator;
        }
        [HttpPost("login")]
        public IActionResult Login([FromBody]UserCredentials userCredentials)
        {
            using (var _userManager = new UserManager())
            using (var _roleManager = new RoleManager())
            using (var _userRoleManager = new UserRoleManager())
            {
                var user = _userManager.GetWithCondition(
                c => c.UserName == userCredentials.UserName &&
                c.Password == userCredentials.Password);


                if (user != null)
                {
                    var userRole = _userRoleManager.GetWithCondition(c => c.UserId == user.Id);

                    if (userRole == null) return Unauthorized();

                    var role = _roleManager.GetWithCondition(c => c.Id == userRole.RoleId);


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

                    return Ok(accessTokenResult.AccessToken);
                }
                else
                {
                    return NotFound();
                }
            }
        }

        [Authorize]
        [HttpPost("getuser")]
        public ActionResult GetUser([FromBody] UserInfo model)
        {
            try
            {
                if(model != null)
                {
                    using (var _userManager = new UserManager())
                    using (var _roleManager = new RoleManager())
                    using (var _userRoleManager = new UserRoleManager())
                    {
                        var user = _userManager.GetWithCondition(c => c.UserName == model.UserName && c.Password == c.Password);
                        if(user != null)
                        {
                            var userRole = _userRoleManager.GetWithCondition(c=> c.UserId == user.Id);
                            var role = _roleManager.GetWithCondition(c => c.Id == userRole.RoleId);
                            model.FirstName = user.FirstName;
                            model.LastName = user.LastName;
                            model.Role = role.Name;
                            model.Email = user.Email;
                            model.Password = "";
                            return Ok(model);
                        }
                        return NotFound();
                    }
                }
                return BadRequest();
            }
            catch (Exception ex)
            {
                return Conflict (ex.Message);
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