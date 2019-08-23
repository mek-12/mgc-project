using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace TestLayaredCookieAuthentication.ENTITIES.CategoryM
{
    public class MainCategory
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

    }
}
