using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WAD_T2104E_BuiManhTuan.Models
{
    public class Category
    {
        public int CategoryId { get; set; }

        [Required(ErrorMessage = "Please enter your Category Name.")]
        public string CategoryName { get; set; }

        public ICollection<Product> Products { get; set; } 
    }
}