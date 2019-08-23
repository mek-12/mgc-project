using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using TestLayaredCookieAuthentication.ENTITIES.Identity;
using TestLayaredCookieAuthentication.ENTITIES.TradeM;
using TestLayaredCookieAuthentication.ENTITIES.WareHouseM;

namespace TestLayaredCookieAuthentication.ENTITIES.ProductM
{
    public class StockInput
    {
        [Key]
        public string Id { get; set; }
        [Required]
        public string StcokInputCode { get; set; }
        public string StatusId { get; set; }
        [ForeignKey("Warehouse")]
        public string WarehouseId { get; set; }
        [ForeignKey("Product")]
        public string ProductId { get; set; }
        public DateTime EntryDate { get; set; }
        public DateTime UpdateDate { get; set; }
        [ForeignKey("TradeCompany")]
        public string TradeCompanyId { get; set; }
        [ForeignKey("CreateUser")]
        public string CreateUserId { get; set; }
        [ForeignKey("UpdateUser")]
        public string UpdateUserId { get; set; }
        public int ProductCount { get; set; }

        public TradeCompany TradeCompany { get; set; }
        public ApplicationUser CreateUser { get; set; }
        public ApplicationUser UpdateUser { get; set; }
        public Product Product { get; set; }
        public Warehouse Warehouse { get; set; }
    }
}
