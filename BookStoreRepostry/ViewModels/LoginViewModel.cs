using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BookStoreRepostry.ViewModels
{
    public class LoginViewModel
    {
        //
        // Summary:
        //     Gets or sets the email address for this user.
     

        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }
       
    }
}
