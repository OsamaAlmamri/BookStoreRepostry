using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BookStoreRepostry.Models
{
    public class Book
    {

        public int id { get; set; }

     
        public string title { get; set; }


        public string description { get; set; }
        public string image { get; set; }
        public Author author { get; set; }
    }
}
