﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MGC.ENTITY.MProducts.MPhone
{
    public class PhoneRamCapacity
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Content { get; set; }
        [NotMapped]
        public int Quantity { get; set; }
    }
}