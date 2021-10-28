using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace StaticData.ViewModels
{
    public class LoginViewModel
    {
        //
        // Summary:
        //     Gets or sets the email address for this user.
     

        [Required]
     //   [EmailAddress]
        public string UserName { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Display(Name = "Remember My")]
        public bool RememberMy { get; set; }
       
    }
}
