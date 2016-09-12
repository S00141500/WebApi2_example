using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Web_API_2.Models
{
    public class Author
    {
        public int ID { get; set; }
        
        [Required]
        public string Name { get; set; }
    }
}