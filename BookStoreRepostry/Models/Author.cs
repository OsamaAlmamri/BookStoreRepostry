using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BookStoreRepostry.Models
{
    public class Author
    {

        public int Id { get; set; }
        [Required(AllowEmptyStrings = false,ErrorMessage ="this files us requored")]
        [MaxLength(20,ErrorMessage="max length 20" )]
        [MinLength(5)]
        [Display(Name ="name of author")]
        public string name { get; set; }
    }
}
