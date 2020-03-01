using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace E_Commerce.MvcWebUI.Models
{
    public class Login
    {
        [Required]
        [DisplayName("User Name")]
        public string UserName { get; set; }
        
        [Required]
        [DisplayName("Password")]
        public string Password { get; set; }
        
        [DisplayName("Remember me")]
        public bool RememberMe { get; set; }
    }
}