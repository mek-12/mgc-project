using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MGC.ENTITY.MProducts.MComputer
{
    public class ComputerScreenCardRam
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public int Size { get; set; }
    }
}