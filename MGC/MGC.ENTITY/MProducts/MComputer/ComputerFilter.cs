using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace MGC.ENTITY.MProducts.MComputer
{
    public class ComputerFilter
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string TableType { get; set; }
        public bool IsActive { get; set; }
    }
}
