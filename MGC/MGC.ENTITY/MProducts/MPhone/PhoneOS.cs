using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MGC.ENTITY.MProducts.MPhone
{
    public class PhoneOS
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [NotMapped]
        public int Quantity { get; set; }
    }
}
