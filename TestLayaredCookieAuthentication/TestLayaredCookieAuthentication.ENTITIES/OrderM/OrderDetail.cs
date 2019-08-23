using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using TestLayaredCookieAuthentication.ENTITIES.ProductM;

namespace TestLayaredCookieAuthentication.ENTITIES.OrderM
{
    public class OrderDetail
    {
        [ForeignKey("Order")]
        public string OrderId { get; set; }
        [ForeignKey("Product")]
        public string ProductId { get; set; }
        public double UnitPrice { get; set; }
        public int Quantity { get; set; }
        public int Discount { get; set; }


        public Order Order { get; set; }
        public Product Product { get; set; }
    }
}
