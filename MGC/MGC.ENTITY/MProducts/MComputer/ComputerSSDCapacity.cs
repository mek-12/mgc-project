using System.ComponentModel.DataAnnotations;

namespace MGC.ENTITY.MProducts.MComputer
{
    public class ComputerSSDCapacity
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Content { get; set; }
    }
}