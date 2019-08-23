using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using TestLayaredCookieAuthentication.ENTITIES.Place;

namespace TestLayaredCookieAuthentication.ENTITIES.CustomerM
{
    public class Customer
    {
        [Key]
        public string Id { get; set; }
        [Required]
        public string CompanyTitle { get; set; }
        public string CompanyTitleNext { get; set; }
        public string TaxDepartmentId { get; set; }
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        public string PhoneNumber { get; set; }
        [Required]
        public string WorkPhoneNumber { get; set; }
        [Required]
        public string Email { get; set; }
        public int CurrencyType { get; set; }
        [ForeignKey("Province")]
        public int? ProvinceId { get; set; }
        [ForeignKey("District")]
        public int? DistrictId { get; set; }

        public Province Province { get; set; }
        public District District { get; set; }

        public ICollection<CustomerInvoiceAddress> CustomerInvoiceAddresses { get; set; }
        public ICollection<CustomerDeliveryAddress> CustomerDeliveryAddresses { get; set; }
    }
}
