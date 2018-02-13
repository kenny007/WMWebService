using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WaremanWS.Models
{
    public class Book
    {
         [ScaffoldColumn(false)]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public string  Author { get; set; }
        public decimal Price { get; set; }

         
    }
}