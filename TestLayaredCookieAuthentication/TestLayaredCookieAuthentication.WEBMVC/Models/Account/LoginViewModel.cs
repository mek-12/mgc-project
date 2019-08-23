using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TestLayaredCookieAuthentication.WEBMVC.Models.Account
{
    public class LoginViewModel
    {
        [Display(Name ="Kullanıcı Adı")]
        public string UserName { get; set; }
        [Display(Name ="Email")]
        public string Email { get; set; }
        [Display(Name = "Parola")]
        public string Password { get; set; }
        public string TOKEN { get; set; }
    }
}
