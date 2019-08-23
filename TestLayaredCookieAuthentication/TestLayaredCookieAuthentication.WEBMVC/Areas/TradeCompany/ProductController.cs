using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using TestLayaredCookieAuthentication.WEBMVC.Areas.TradeCompany.Models;

namespace TestLayaredCookieAuthentication.WEBMVC.Areas.TradeCompany
{
    [Authorize(Roles = "TRADER")]
    public class ProductController : Controller
    {
        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Add(ProductViewModel model)
        {
            throw new Exception();
        }
    }
}