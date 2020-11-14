using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ECommerce.Application.Dtos
{
    public class CartProductRequestDto
    {
        [Required]
        public long CartId { get; set; }
        [Required]
        public long ProductId { get; set; }
    }
}
