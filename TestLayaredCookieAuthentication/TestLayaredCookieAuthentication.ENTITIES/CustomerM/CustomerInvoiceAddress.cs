using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using TestLayaredCookieAuthentication.ENTITIES.Tax;

namespace TestLayaredCookieAuthentication.ENTITIES.CustomerM
{
    public class CustomerInvoiceAddress
    {
        [Key]
        public string Id { get; set; }
        [ForeignKey("Customer")]
        public string CustomerId { get; set; }
        public string CompanyName { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string AddressTitle { get; set; }
        public string ShipCountry { get; set; }
        public string ShipProvince { get; set; }
        public string ShipDistrict { get; set; }
        public string PostalCode { get; set; }
        public string PhoneNumber { get; set; }
        public bool isInstitutional { get; set; }
        public string TaxNo { get; set; }
        [ForeignKey("TaxDepartment")]
        public string TaxDepartmentId { get; set; }


        public Customer Customer { get; set; }
        public TaxDepartment TaxDepartment { get; set; }
    }
}
