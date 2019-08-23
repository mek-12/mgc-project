using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using TestLayaredCookieAuthentication.WEBMVC.Helper;
using TestLayaredCookieAuthentication.WEBMVC.Models;
using TestLayaredCookieAuthentication.WEBMVC.Models.Account;

namespace TestLayaredCookieAuthentication.WEBMVC.Controllers
{
    [Route("auth")]
    public class AccountController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet("login")]
        public IActionResult Login()
        {

            return View();
        }

        [HttpPost("login")]
        public async Task<IActionResult> Login(LoginViewModel model)
        {
            try
            {
                if(model != null)
                {
                    using (var apiHelper = new ApiRequestHelper())
                    using (var cookieHelper = new CookieAuthenticateHelper())
                    using (var redirectHelper = new RedirectHelper())
                    {
                        var user = await apiHelper.GetUserWithToken(model);
                        if(user != null)
                        {
                            var principal = cookieHelper.GetPrincipal(user);

                            await HttpContext.SignInAsync(principal);

                            var redirect = redirectHelper.RedirectAreaResult(user.Role);

                            return RedirectToAction(redirect.Action, redirect.Controller, new { area = redirect.Area });
                        }
                        return Unauthorized();
                    }
                }
                return BadRequest();
            }
            catch (Exception)
            {

                return NoContent();
            }
        }


        [HttpPost("page")]
        public IActionResult TestPage(string token)
        {
            return RedirectToAction("Index", "Test");
        }


        private async Task LoginAsync(UserInfo model)
        {
            var claims = new List<Claim>
            {
                new Claim(ClaimTypes.Email, model.Email),
                new Claim(ClaimTypes.Name, model.UserName),
                new Claim(ClaimTypes.GivenName, model.FirstName),
                new Claim(ClaimTypes.Surname, model.LastName),
                new Claim(ClaimTypes.Role, model.Role)
            };
            var identity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);
            var principal = new ClaimsPrincipal(identity);
            await HttpContext.SignInAsync(principal);
        }
    }
}