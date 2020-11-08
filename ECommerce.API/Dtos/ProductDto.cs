using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ECommerce.API.Dtos
{
    public class ProductDto
    {
        [Required]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public int UnitsInStock { get; set; }
        [Required]
        public string Category { get; set; }
        public decimal UnitPrice { get; set; }
    }
}
