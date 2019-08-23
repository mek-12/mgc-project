using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace TestLayaredCookieAuthentication.WEBAPI.Controllers
{
    [Route("api/user")]
    [ApiController]
    public class UserController : ControllerBase
    {
        public IActionResult GetUserInfo(string userName, string Password)
        {
            throw new Exception();
        }
    }
}