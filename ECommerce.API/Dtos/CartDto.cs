using System;
using System.Collections.Generic;
using System.Text;

namespace ECommerce.API.Dtos
{
    public class CartDto
    {
        public List<CartItemDto> Items { get; set; }
    }
}
