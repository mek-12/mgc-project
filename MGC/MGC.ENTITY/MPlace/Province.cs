using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MGC.ENTITY.MPlace
{
    public class Province
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }

        public int CountryId { get; set; }

        [ForeignKey("CountryId")]
        public Country Country { get; set; }
        public virtual ICollection<District> Districts { get; set; }
    }
}