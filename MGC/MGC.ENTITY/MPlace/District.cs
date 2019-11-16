using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MGC.ENTITY.MPlace
{
    public class District
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }

        [Required]
        public int ProvinceId { get; set; }

        [ForeignKey("ProvinceId")]
        public Province Province { get; set; }
    }
}