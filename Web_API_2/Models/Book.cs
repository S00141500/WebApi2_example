using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Web_API_2.Models
{
    public class Book
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public int Year { get; set; }
        public decimal Price { get; set; }
        public string Genre { get; set; }

        // foreign key
        public int AuthorID { get; set; }

        // navagation property
        public Author Author { get; set; }
    }
}