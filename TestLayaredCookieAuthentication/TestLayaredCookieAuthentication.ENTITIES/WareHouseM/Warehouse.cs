using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using TestLayaredCookieAuthentication.ENTITIES.TradeM;

namespace TestLayaredCookieAuthentication.ENTITIES.WareHouseM
{
    public class Warehouse
    {
        [Key]
        public string Id { get; set; }
        [ForeignKey("TradeCompany")]
        public string TradeCompanyId { get; set; }
        public string Code { get; set; }
        public string WarehouseName { get; set; }
        public string Description { get; set; }
        public string StatusId { get; set; }

        
        public TradeCompany TradeCompany { get; set; }
    }
}
