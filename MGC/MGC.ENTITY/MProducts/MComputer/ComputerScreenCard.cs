using System.ComponentModel.DataAnnotations;

namespace MGC.ENTITY.MProducts.MComputer
{
    public class ComputerScreenCard
    {
        [Key]
        public int Id { get; set; }
        //IsUniq
        [Required]
        public string Name { get; set; }
    }
}