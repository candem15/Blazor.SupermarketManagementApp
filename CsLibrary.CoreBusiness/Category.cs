using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CsLibrary.CoreBusiness
{
    public class Category
    {
        public Guid CategoryId { get; set; }
        [Required]
        public string Name { get; set; }
        public string Description { get; set; }
        public List<Product> Products { get; set; }
    }
}
