using System.ComponentModel.DataAnnotations;

namespace MGC.ENTITY.MCommon
{
    public class Color
    {
        [Key]
        public string ColorCode { get; set; }
        [Required]
        public string Name { get; set; }
    }
}
