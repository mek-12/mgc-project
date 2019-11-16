using MGC.ENTITY.MSeller;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MGC.ENTITY.MProducts.MComputer
{
    public class Computer : Product
    {
        [Required]
        public int ComputerBrandId { get; set; }

        [ForeignKey("ComputerBrandId")]
        public ComputerBrand ComputerBrand { get; set; }

        public ICollection<ComputerImage> Images { get; set; }
    }
}
