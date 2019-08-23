using System.ComponentModel.DataAnnotations.Schema;
using TestLayaredCookieAuthentication.ENTITIES.Identity;

namespace TestLayaredCookieAuthentication.ENTITIES.TradeM
{
    public class TCompanyPartners
    {
        [ForeignKey("TradeCompany")]
        public string TradeCompanyId { get; set; }
        [ForeignKey("ApplicationUser")]
        public string ApplicationUserId { get; set; }
        public string Position { get; set; }

        public ApplicationUser ApplicationUser { get; set; }
        public TradeCompany TradeCompany { get; set; }
    }
}
