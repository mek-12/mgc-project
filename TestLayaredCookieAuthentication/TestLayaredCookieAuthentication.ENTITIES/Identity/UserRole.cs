using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace TestLayaredCookieAuthentication.ENTITIES.Identity
{
    public class UserRole
    {
        public string UserId { get; set; }
        public string RoleId { get; set; }
        [ForeignKey("UserId")]
        public ApplicationUser ApplicationUser { get; set; }
        [ForeignKey("RoleId")]
        public ApplicationRole ApplicationRole { get; set; }


        public UserRole()
        {

        }

        public UserRole(string UserId, string RoleId)
        {
            this.UserId = UserId;
            this.RoleId = RoleId;
        }
    }
}
