using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestLayaredCookieAuthentication.ENTITIES.CustomerM;
using TestLayaredCookieAuthentication.ENTITIES.TradeM;

namespace TestLayaredCookieAuthentication.ENTITIES.OrderM
{
    public class Order
    {
        [Key]
        public string Id { get; set; }
        [ForeignKey("Customer")]
        public string CustomerId { get; set; }
        [ForeignKey("TradeCompany")]
        public string TradeCompanyId { get; set; }
        public string OrderCode { get; set; }
        public DateTime OrderDate { get; set; }
        public DateTime ShippedDate { get; set; }
        public DateTime RequiredDate { get; set; }
        public string ShipName { get; set; }
        public string ShipAddress { get; set; }
        public string ShipCountry { get; set; }
        public string ShipProvince { get; set; }
        public string ShipDistrict { get; set; }
        public string ShipPostalCode { get; set; }


        public Customer Customer { get; set; }
        public TradeCompany TradeCompany { get; set; }
    }
}
