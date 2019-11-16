using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MGC.ENTITY.MProducts.MPhone
{
    public class PhoneColor
    {
        //PK set with Fluent Api => PhoneId,ColorCode
        public Guid PhoneId { get; set; }
        public string ColorCode { get; set; }
        [NotMapped]
        public int Quantity { get; set; }

        [ForeignKey("PhoneId")]
        public Phone Phone { get; set; }
    }
}
