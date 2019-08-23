using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestLayaredCookieAuthentication.WEBMVC.Areas.TradeCompany.Models
{
    public class ProductViewModel
    {
        public string ProductName { get; set; }
        public string Description { get; set; }
        public string CategoryId { get; set; }
        public string ImageBase64 { get; set; }
        public double WholesalePrice { get; set; }
        public double UnitPrice { get; set; }
        public int ProductCount { get; set; }
        public int KDVRate { get; set; }
    }
}
