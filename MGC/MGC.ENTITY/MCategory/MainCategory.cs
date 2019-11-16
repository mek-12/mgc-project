using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace MGC.ENTITY.MCategory
{
    public class MainCategory
    {
        [Key]
        public Guid Id { get; set; }
        public string CategoryCode { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public bool IsActive { get; set; }
        public bool IsVisible { get; set; }

        public MainCategory()
        {
            Id = Guid.NewGuid();
        }

        public ICollection<MiddleCategory> MiddleCatgories { get; set; }
    }
}
