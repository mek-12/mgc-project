using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace MGC.ENTITY.MProducts.MPhone
{
    public class PhoneImage
    {
        //Fluent Api set PK PhoneId, QueueNumber
        [Required]
        public Guid PhoneId { get; set; }
        [Required]
        public int QueueNumber { get; set; }

        [Required]
        public byte[] Image { get; set; }

        [ForeignKey("PhoneId")]
        public Phone Phone { get; set; }

        public PhoneImage()
        {

        }

        public PhoneImage(byte[] Image, Guid PhoneId, int QueueNumber)
        {
            this.Image = Image;
            this.QueueNumber = QueueNumber;
            this.PhoneId = PhoneId;
        }
    }
}
