using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using TestLayaredCookieAuthentication.ENTITIES.ProductM;

namespace TestLayaredCookieAuthentication.ENTITIES.CategoryM
{
    public class Category
    {
        [Key]
        public int Id { get; set; }
        [ForeignKey("MiddleCategory")]
        public int MiddleCategoryId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }


        public MiddleCategory MiddleCategory { get; set; }
        public ICollection<Product> Products { get; set; }
    }
}
