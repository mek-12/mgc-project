using MGC.ENTITY.MSeller;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MGC.ENTITY.MProducts
{
    public class Product
    {
        [Key]
        public Guid Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public int ProductCode { get; set; }
        [Required]
        public int Price { get; set; }
        [Required]
        public int PurchacePrice { get; set; }
        public int DiscountRate { get; set; }
        public string CampaignCode { get; set; }
        public bool InCampaign { get; set; }

        [Required]
        public Guid SellerId { get; set; }

        [ForeignKey("SellerId")]
        public Seller Seller { get; set; }

        public Product()
        {
            Id = Guid.NewGuid();
        }
    }
}
