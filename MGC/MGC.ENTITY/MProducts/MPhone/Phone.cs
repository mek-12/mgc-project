using MGC.ENTITY.MSeller;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace MGC.ENTITY.MProducts.MPhone
{
    public class Phone : Product
    {
        [Required]
        public int PhoneBrandId { get; set; }

        [ForeignKey("PhoneBrandId")]
        public PhoneBrand PhoneBrand { get; set; }

        public virtual ICollection<PhoneComment> Comments { get; set; }
        public virtual ICollection<PhoneImage> Images { get; set; }
        public virtual ICollection<PhoneColor> Colors { get; set; }
    }
}
