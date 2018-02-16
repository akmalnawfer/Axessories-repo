using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Axessories.Models
{
    public class LoginViewModel
    {
        [Display(Name = "Username")]
        [Required(ErrorMessage = "Please Enter your email address")]
        [EmailAddress(ErrorMessage = "Invalid email address")]
        public string EmailAddress { get; set; }

        [Display(Name = "Password")]
        [Required(ErrorMessage = "Pleaser enter your password")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        public bool KeepMeLoggedIn { get; set; }
    }
}