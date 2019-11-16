using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MGC.ENTITY.MProducts.MComputer
{
    public class ComputerImage
    {
        //Fluent Api set PK PhoneId, QueueNumber
        [Required]
        public Guid ComputerId { get; set; }
        [Required]
        public int QueueNumber { get; set; }

        [Required]
        public byte[] Image { get; set; }

        [ForeignKey("ComputerId")]
        public Computer Computer { get; set; }

        public ComputerImage()
        {

        }

        public ComputerImage(byte[] Image, Guid ComputerId, int QueueNumber)
        {
            this.Image = Image;
            this.QueueNumber = QueueNumber;
            this.ComputerId = ComputerId;
        }
    }
}