using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CsLibrary.CoreBusiness
{
    public class Product
    {
        public Guid ProductId { get; set; }
        [Required]
        public Guid? CategoryId { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public int? Quantity { get; set; }
        [Required]
        public double? Price { get; set; }
        public Category Category { get; set; }
    }
}