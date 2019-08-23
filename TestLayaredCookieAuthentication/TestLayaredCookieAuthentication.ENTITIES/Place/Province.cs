using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace TestLayaredCookieAuthentication.ENTITIES.Place
{
    public class Province
    {
        [Key]
        public int ProvinceId { get; set; }
        public string ProvinceName { get; set; }
    }
}
