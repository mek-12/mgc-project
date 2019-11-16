using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace MGC.ENTITY.Identity
{
    public class UserRole
    {
        public Guid UserId { get; set; }
        public Guid RoleId { get; set; }
        [ForeignKey("UserId")]
        public ApplicationUser ApplicationUser { get; set; }
        [ForeignKey("RoleId")]
        public ApplicationRole ApplicationRole { get; set; }


        public UserRole()
        {

        }

        public UserRole(Guid UserId, Guid RoleId)
        {
            this.UserId = UserId;
            this.RoleId = RoleId;
        }
    }
}
