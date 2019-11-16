using MGC.ENTITY.Identity;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MGC.ENTITY.MProducts.MPhone
{
    public class PhoneComment
    {
        [Key]
        public Guid Id { get; set; }
        public Guid PhoneId { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]
        public string Content { get; set; }
        public int Rating { get; set; }
        [Required]
        public Guid UserId { get; set; }

        [ForeignKey("PhoneId")]
        public Phone Phone { get; set; }
    }
}
