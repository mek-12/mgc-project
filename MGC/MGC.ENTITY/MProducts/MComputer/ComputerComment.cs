using MGC.ENTITY.Identity;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MGC.ENTITY.MProducts.MComputer
{
    public class ComputerComment
    {
        [Key]
        public Guid Id { get; set; }
        [Required]
        public Guid ComputerId { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]
        public string Content { get; set; }
        public int Rating { get; set; }
        [Required]
        public Guid UserId { get; set; }

        [ForeignKey("UserId")]
        public ApplicationUser ApplicationUser { get; set; }
        [ForeignKey("ComputerId")]
        public Computer Computer { get; set; }
    }
}