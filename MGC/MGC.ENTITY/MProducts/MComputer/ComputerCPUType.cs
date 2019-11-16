using System.ComponentModel.DataAnnotations;

namespace MGC.ENTITY.MProducts.MComputer
{
    public class ComputerCPUType
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public int Name { get; set; }
    }
}