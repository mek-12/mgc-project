
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestLayaredCookieAuthentication.WEBMVC.Models
{
    public class RedirectRouteResult
    {
        public string Area { get; set; }
        public string Controller { get; set; }
        public string Action { get; set; }
        public string Route { get; set; }
        public int ID { get; set; }
    }
}
