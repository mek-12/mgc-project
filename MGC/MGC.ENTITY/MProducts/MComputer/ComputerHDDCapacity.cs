using System.ComponentModel.DataAnnotations;

namespace MGC.ENTITY.MProducts.MComputer
{
    public class ComputerHDDCapacity
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public int Content { get; set; }
    }
}