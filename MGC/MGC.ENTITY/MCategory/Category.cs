using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace MGC.ENTITY.MCategory
{
    public class Category
    {
        [Key]
        public Guid Id { get; set; }
        public string CategoryCode { get; set; }
        public string Name { get; set; }
        [ForeignKey("MiddleCategory")]
        public Guid MiddleCategoryId { get; set; }
        public bool IsActive { get; set; }
        public bool IsVisible { get; set; }

        public MiddleCategory MiddleCategory { get; set; }
    
        public Category()
        {
            Id = Guid.NewGuid();
        }
    }
}
