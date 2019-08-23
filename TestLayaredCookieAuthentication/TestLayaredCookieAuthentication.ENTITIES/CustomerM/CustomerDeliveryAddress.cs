using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TestLayaredCookieAuthentication.ENTITIES.CustomerM
{
    public class CustomerDeliveryAddress
    {   
        [Key]
        public string Id { get; set; }
        [ForeignKey("Customer")]
        public string CustomerId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string AddressTitle { get; set; }
        public string ShipCountry { get; set; }
        public string ShipProvince { get; set; }
        public string ShipDistrict { get; set; }
        public string PostalCode { get; set; }
        public string PhoneNumber { get; set; }

        public Customer Customer { get; set; }
    }
}
