using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace StaticData.ViewModels
{
    public class RegisterViewModel
    {
        //
        // Summary:
        //     Gets or sets the email address for this user.
     
            [Required]
            
        public string UserName { get; set; }
        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        [Required]
        [DataType(DataType.Password)]
        [Compare("Password",ErrorMessage ="password must be aqual")]
        [Display(Name ="Confirm Password")]
        public string ConfirmPassword { get; set; }
    }
}
