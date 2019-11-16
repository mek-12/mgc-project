using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace MGC.ENTITY.MProducts.MPhone
{
    public class PhoneOSType
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [NotMapped]
        public int Quantity { get; set; }
    }
}
