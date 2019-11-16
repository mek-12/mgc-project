using MGC.ENTITY.MCategory;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace MGC.ENTITY.MTableRecord
{
    public class ProductRecord
    {
        [Key]
        public Guid Id { get; set; }
        [Required]
        public string TableCode { get; set; }
        [Required]
        public string TableType { get; set; }

        public Guid CategoryId { get; set; }

        [ForeignKey("CategoryId")]
        public Category Category { get; set; }

        public virtual ICollection<FilterRecord> FilterRecords { get; set; }
    }
}
