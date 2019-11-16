using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MGC.BLL.Abstract.MCategory;
using MGC.BLL.Concrete.MCategory;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MGC.WEBAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        
        public CategoryController()
        {

        }
        [HttpGet("maincategories")]
        public ActionResult GetMainCategories()
        {

            try
            {
                IMainCategoryManager mainCategoryManager = new MainCategoryManager();
                var result = mainCategoryManager.GetAll();

                if (result.IsSucceeded == false)
                    return NoContent();

                return Ok(result.Model);

            }
            catch
            {
                return BadRequest("Something wrong!!!");
            }

        }


        [HttpPost("getcategories")]
        public ActionResult GetCategories(string categoryCode)
        {
            throw new Exception();
        }
    }
}