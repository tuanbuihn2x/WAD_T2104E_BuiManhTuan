using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WAD_T2104E_BuiManhTuan.Models
{
    public class Product
    {
        public int ProductId { get; set; }

        [Required(ErrorMessage = "Please enter Name.")]
        [StringLength(32, MinimumLength = 3)]
        public string Name { get; set; }

        [Required(ErrorMessage = "Please enter Price.")]
        public int Price { get; set; }

        [Required(ErrorMessage = "Please enter Quantity.")]
        [Range(1, 100, ErrorMessage = "Value must be between 1 to 100")]
        public int Quantity {get; set; }

        [Required(ErrorMessage = "Please enter Release Date.")]
        public DateTime ReleaseDate { get; set; }

        public int CategoryId { get; set; }

        public virtual Category Category { get; set; }
    }
}