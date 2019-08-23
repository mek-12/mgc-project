using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using TestLayaredCookieAuthentication.ENTITIES.Identity;
using TestLayaredCookieAuthentication.ENTITIES.TradeM;
using TestLayaredCookieAuthentication.ENTITIES.WareHouseM;

namespace TestLayaredCookieAuthentication.ENTITIES.ProductM
{
    public class StockOut
    {
        [Key]
        public string Id { get; set; }
        [Required]
        public string StockOutCode { get; set; }
        public string StatusId { get; set; }
        [ForeignKey("Warehouse")]
        public string WarehouseId { get; set; }
        [ForeignKey("Product")]
        public string ProductId { get; set; }
        public DateTime OutDate { get; set; }
        public DateTime UpdateTime { get; set; }
        [ForeignKey("TradeCompany")]
        public string TradeCompanyId { get; set; }
        [ForeignKey("OutUser")]
        public string OutUserId { get; set; }
        [ForeignKey("UpdateUser")]
        public string UpdateUserId { get; set; }
        public int ProductCount { get; set; }

        public TradeCompany TradeCompany { get; set; }
        public Warehouse Warehouse { get; set; }
        public Product Product { get; set; }
        public ApplicationUser OutUser { get; set; }
        public ApplicationUser UpdateUser { get; set; }
    }
}
