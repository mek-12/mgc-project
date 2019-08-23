using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using TestLayaredCookieAuthentication.ENTITIES.Identity;
using TestLayaredCookieAuthentication.ENTITIES.Place;

namespace TestLayaredCookieAuthentication.ENTITIES.ProducerM
{
    public class Producer
    {
        [Key]
        public string Id { get; set; }
        public string CompanyName { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public float Debt { get; set; }
        public string Description { get; set; }
        [Required]
        public string Phone { get; set; }
        public string WorkPhone { get; set; }
        public int StatusId { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime UpdateTime { get; set; }
        [ForeignKey("CreateUser")]
        public string CreateUserId { get; set; }
        [ForeignKey("UpdateUser")]
        public string UpdateUserId { get; set; }
        [ForeignKey("District")]
        public int DistrictId { get; set; }


        public ApplicationUser CreateUser { get; set; }
        public ApplicationUser UpdateUser { get; set; }
        public District District { get; set; }
    }
}
