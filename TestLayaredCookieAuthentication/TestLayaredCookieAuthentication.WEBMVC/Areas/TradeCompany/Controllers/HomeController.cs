using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace TestLayaredCookieAuthentication.WEBMVC.Areas.TradeCompany.Controllers
{
    [Area("TradeCompany")]
    [Authorize(Roles = "TRADER")]
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}