using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using TestLayaredCookieAuthentication.ENTITIES.CategoryM;
using TestLayaredCookieAuthentication.ENTITIES.Identity;
using TestLayaredCookieAuthentication.ENTITIES.TradeM;

namespace TestLayaredCookieAuthentication.ENTITIES.ProductM
{
    public class Product
    {
        public string Id { get; set; }
        [ForeignKey("Category")]
        public int CategoryId { get; set; }
        [ForeignKey("TradeCompany")]
        public string TradeCompanyId { get; set; }
        public string ProductName { get; set; }
        public string ImageBase64 { get; set; }
        public string StCode { get; set; }
        public int StatusId { get; set; }
        public double WholesalePrice { get; set; }
        public double UnitPrice { get; set; }
        public int ProductCount { get; set; }
        public int KDVRate { get; set; }
        public string Explain { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime UpdateDate { get; set; }
        [ForeignKey("UpdateUser")]
        public string UpdateUserId { get; set; }
        [ForeignKey("CreateUser")]
        public string CreateUserId { get; set; }



        public ApplicationUser CreateUser { get; set; }
        public ApplicationUser UpdateUser { get; set; }
        public Category Category { get; set; }
        public TradeCompany TradeCompany { get; set; }
    }
}
