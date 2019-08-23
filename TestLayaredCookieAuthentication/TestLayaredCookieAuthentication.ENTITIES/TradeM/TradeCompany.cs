using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace TestLayaredCookieAuthentication.ENTITIES.TradeM
{
    public class TradeCompany
    {
        [Key]
        public string Id { get; set; }
        public string CompanyName { get; set; }
        public string FullAddress { get; set; }
        public string Phone { get; set; }
        public string Fax { get; set; }
        public string Country { get; set; }
        public string Province { get; set; }
        public string District { get; set; }
        public string Email { get; set; }
        public string TradeRegistrationNo { get; set; }
    }
}
