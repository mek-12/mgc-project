using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using TestLayaredCookieAuthentication.ENTITIES.Place;

namespace TestLayaredCookieAuthentication.ENTITIES.Tax
{
    public class TaxDepartment
    {
        [Key]
        public string Id { get; set; }
        public string DepartmentName { get; set; }
        [ForeignKey("District")]
        public int DistrictId { get; set; }

        public District District { get; set; }
    }
}
