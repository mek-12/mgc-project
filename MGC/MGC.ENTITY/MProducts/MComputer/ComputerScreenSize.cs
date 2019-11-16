using System.ComponentModel.DataAnnotations;

namespace MGC.ENTITY.MProducts.MComputer
{
    public class ComputerScreenSize
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public float Size { get; set; }
    }
}