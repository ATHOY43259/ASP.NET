using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace LayoutIntroandForm.Models
{
    public class Login
    {
        [Required(ErrorMessage ="*Insert your username ")]
        public string Username { get; set; }
        [Required(ErrorMessage ="*Insert your password")]
        public string Password { get; set; }
    }
}