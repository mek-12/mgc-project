using System;
using System.Collections.Generic;
using MGC.BLL.Abstract.MIdentity;
using MGC.BLL.Concrete.MIdentity;
using MGC.ENTITY.Identity;
using MGC.WEBAPI.Models;
using MGC.WEBAPI.Services.Abstract;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace MGC.WEBAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class AuthController : ControllerBase
    {
        private readonly IUserService userService;

        public AuthController(IUserService userService)
        {
            this.userService = userService;
        }

        [HttpGet]
        [Authorize(Roles = "ADMIN")]
        public ActionResult<IEnumerable<string>> Get()
        {
            return new string[] { "value1", "value2" };
        }

        [AllowAnonymous]
        [HttpPost("login")]
        public IActionResult Login([FromBody]UserCredentials userCredentials)
        {
            try
            {

                var result = userService.Authenticate(userCredentials);

                if(result.IsSucceeded == false)
                {
                    return Unauthorized(result.Message);
                }

                return Ok(result.Data);
            }
            catch (Exception)
            {
                return BadRequest();
            }
        }
    }
}