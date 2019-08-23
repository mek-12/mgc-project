using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using TestLayaredCookieAuthentication.BLL.Abstract;
using TestLayaredCookieAuthentication.BLL.Concrete;
using TestLayaredCookieAuthentication.CrossCuttingConcerns;
using TestLayaredCookieAuthentication.ENTITIES.Identity;

namespace TestLayaredCookieAuthentication.WEBAPI.Controllers
{
    public class TestUser
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Description { get; set; }
    }

    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        private IUserManager _userManager;
        
        public ValuesController()
        {
            _userManager = new UserManager();
        }

        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
             return new string[] { "value1", "value2"};
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return "value";
        }

        [HttpGet("num/{id}/{desc}")]
        public ActionResult Test(int id,string desc)
        {
            return Ok(new List<TestUser>() {
                new TestUser() { Name = "Muhammed", Age = id, Description = desc},
                new TestUser() {Name = "Aliş", Age = id, Description = desc}
            });
        }

        // POST api/values
        [HttpPost("test/model")]
        public string Post([FromBody] TestModel model)
        {
            if (model == null)
            {
                return "BAD";
            }
            return "OK";
        }

        /*// PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }*/
        [HttpPost("user/model")]
        public ActionResult CreateUser([FromBody] ApplicationUser model)
        {
            if (model == null)
            {
                return Forbid();
            }
            CResult<ApplicationUser> cResult = _userManager.Add(model);

            if (cResult.IsSucceeded)
            {
                return Ok(cResult.Description);
            }
            return BadRequest(cResult.Description);
        }
    }
    public class TestModel
    {
        public string prone { get; set; }
        public string prsecond { get; set; }
    }
}
