using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace MGC.ENTITY.MCategory
{
    public class MiddleCategory
    {
        [Key]
        public Guid Id { get; set; }
        public string CategoryCode { get; set; }
        public string Name { get; set; }
        [ForeignKey("_MiddleCategory")]
        public Guid? MiddleCategoryId { get; set; }
        [ForeignKey("MainCategory")]
        public Guid? MainCategoryId { get; set; }
        public bool IsActive { get; set; } = true;
        public bool IsVisible { get; set; } = true;

        public MiddleCategory _MiddleCategory { get; set; }
        public MainCategory MainCategory { get; set; }

        public MiddleCategory()
        {
            Id = Guid.NewGuid();
        }

        public ICollection<Category> Categories { get; set; }
    }
}
