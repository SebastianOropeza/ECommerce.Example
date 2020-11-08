using ECommerce.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ECommerce.Application.Services
{
    public interface ICartService
    {
        public IEnumerable<Cart> GetCarts();
        public Cart GetById(long id);
        public void AddToCart(long cartId, long productId);
        public void RemoveFromCart(long cartId, long productId);
    }
}
