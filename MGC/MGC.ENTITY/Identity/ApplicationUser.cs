using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace MGC.ENTITY.Identity
{
    public class ApplicationUser
    {
        public Guid Id { get; set; }
        [Required]
        public string UserName { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Password { get; set; }
        [Required]
        public string Email { get; set; }
        public bool EmailConfirmed { get; set; }

        public ApplicationUser()
        {
            Id = Guid.NewGuid();
        }

    }
}
