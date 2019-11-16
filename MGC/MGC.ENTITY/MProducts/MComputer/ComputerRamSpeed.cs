using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MGC.ENTITY.MProducts.MComputer
{
    public class ComputerRamSpeed
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public int Content { get; set; }
        [NotMapped]
        public int Quantity { get; set; }
        
    }
}