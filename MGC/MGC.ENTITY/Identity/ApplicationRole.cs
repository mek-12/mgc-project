using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace MGC.ENTITY.Identity
{
    public class ApplicationRole
    {
        [Key]
        public Guid Id { get; set; }
        [Required]
        public string Name { get; set; }
        public string Description { get; set; }

        public ApplicationRole()
        {
            Id = Guid.NewGuid();
        }
    }
}
