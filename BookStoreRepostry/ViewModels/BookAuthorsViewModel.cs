using BookStoreRepostry.Models;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BookStoreRepostry.ViewModels
{
    public class BookAuthorsViewModel
    {
        public int BookId { get; set; }

        //[Required]
     //   [MaxLength(20)]
       // [MinLength(5)]
        public string title { get; set; }


     //   [Required]
    //    [MaxLength(20)]
      //  [MinLength(5)]
        public string description { get; set; }
        public List<Author> Authors { get; set; }
        public string image { get; set; }

        public IFormFile File { get; set; }


        public int AuthorId { get; set; }


    }
}
