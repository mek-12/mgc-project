using MGC.ENTITY.Identity;
using MGC.ENTITY.MPlace;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace MGC.ENTITY.MSeller
{
    public class Seller
    {
        [Key]
        public Guid Id { get; set; }
        [Required]
        public string SellerCode { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Address { get; set; }
        [Required]
        public int DistrictId { get; set; }
        [Required]
        public Guid OwnerId { get; set; }

        public int AvarageRating { get; set; }

        [ForeignKey("DistrictId")]
        public District District { get; set; }
        [ForeignKey("OwnerId")]
        public ApplicationUser ApplicationUser { get; set; }

        public Seller()
        {
            Id = Guid.NewGuid();
        }
    }
}
