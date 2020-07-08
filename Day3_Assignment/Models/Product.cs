using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
namespace Day3_Assignment.Models
{
    public class Product
    {
        [Required(ErrorMessage = "Product id required")]
        public string pid { get; set; }
        [Required(ErrorMessage = "Product name required")]
        public string pname { get; set; }
        [Required(ErrorMessage = "Product price required")]
        public int price { get; set; }
        [Required(ErrorMessage = "Stock required")]
        public int stock { get; set; }
    }
}
