using ECommerce.Domain.Entities;
using ECommerce.Infrastructure.Interfaces;
using ECommerce.Infrastructure.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ECommerce.Application.Services
{
    public class CartService : ICartService
    {
        private readonly ICartRepository cartRepository;
        private readonly IProductRepository productRepository;

        public CartService(ICartRepository cartRepository, IProductRepository productRepository)
        {
            this.cartRepository = cartRepository;
            this.productRepository = productRepository;
        }

        public void AddToCart(long cartId, long productId)
        {
            var cart = cartRepository.GetById(cartId);
            if (cart == null)
            {
                cart = new Cart(new List<CartItem>());
                cartRepository.Add(cart);
            }
            var product = productRepository.GetById(productId);
            cart.AddCartItem(product);
            cartRepository.Update(cart);
            cartRepository.Commit();
        }

        public Cart GetById(long id)
        {
            return cartRepository.GetById(id);
        }

        public IEnumerable<Cart> GetCarts()
        {
            var carts = cartRepository.GetAll();
            return carts.ToList();
        }

        public void RemoveFromCart(long cartId, long productId)
        {
            var cart = GetById(cartId);
            cart.RemoveCartItem(productId);
            cartRepository.Update(cart);
            cartRepository.Commit();
        }
    }
}
