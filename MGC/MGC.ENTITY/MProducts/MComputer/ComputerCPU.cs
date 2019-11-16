using System.ComponentModel.DataAnnotations;

namespace MGC.ENTITY.MProducts.MComputer
{
    public class ComputerCPU
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
    }
}