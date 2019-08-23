using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace TestLayaredCookieAuthentication.WEBMVC.Areas.TransportCompany.Controllers
{
    [Area("TransportCompany")]
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}