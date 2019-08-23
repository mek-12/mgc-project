using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using TestLayaredCookieAuthentication.ENTITIES.CustomerM;
using TestLayaredCookieAuthentication.ENTITIES.OrderM;
using TestLayaredCookieAuthentication.ENTITIES.TradeM;

namespace TestLayaredCookieAuthentication.ENTITIES.InvoiceWaybillM
{
    public class Waybill
    {
        [Key]
        public string Id { get; set; }
        [ForeignKey("TradeCompany")]
        public string TradeCompanyId { get; set; }
        public string InvoiceCode { get; set; }
        public string WaybillCode { get; set; }
        public string WaybillNo { get; set; }
        public string VoucherNo { get; set; }
        public string SerialNo { get; set; }
        public string CustomerTaxDepartmentNo { get; set; }
        [ForeignKey("Customer")]
        public string CustomerId { get; set; }
        [ForeignKey("Order")]
        public string OrderId { get; set; }
        public DateTime WaybillDate { get; set; }
        public DateTime DateofShipment { get; set; }


        public TradeCompany TradeCompany { get; set; }
        public Customer Customer { get; set; }
        public Order Order { get; set; }
    }
}
