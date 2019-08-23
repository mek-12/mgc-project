using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace TestLayaredCookieAuthentication.ENTITIES.CategoryM
{
    public class MiddleCategory
    {
        [Key]
        public int Id { get; set; }
        [ForeignKey("MainCategory")]
        public int MainCategoryId { get; set; }
        public string Description { get; set; }

        public MainCategory MainCategory { get; set; }
    }
}
