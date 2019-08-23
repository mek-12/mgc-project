using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace TestLayaredCookieAuthentication.ENTITIES.Place
{
    public class District
    {
        [Key]
        public int DistrictId { get; set; }
        public string DistrictName { get; set; }

        public ICollection<Province> Provinces { get; set; }
    }
}
