using System;
using System.Collections.Generic;
using System.Text;

namespace ECommerce.Application.Dtos
{
    public class CartDto
    {
        public List<CartItemDto> Items { get; set; }
    }
}
