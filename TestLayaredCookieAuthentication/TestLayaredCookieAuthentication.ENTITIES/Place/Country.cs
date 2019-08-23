using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace TestLayaredCookieAuthentication.ENTITIES.Place
{
    public class Country
    {
        [Key]
        public int CountryId { get; set; }
        public string CountryName { get; set; }
        
        public ICollection<Province> Provinces { get; set; }
    }
}
