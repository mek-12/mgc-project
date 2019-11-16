using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace MGC.ENTITY.MTableRecord
{
    public class TablelessFilterProperty
    {
        [Key]
        public Guid Id { get; set; }
        [Required]
        public string TableType { get; set; }
        [Required]
        public string PropertyName { get; set; }
        [Required]
        public string DisplayName { get; set; }
    }
}
