using ECommerce.Domain.Entities.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ECommerce.Domain.Entities
{
    public class Cart : Entity
    {
        public List<CartItem> Items { get; private set; } = new List<CartItem>();

        private Cart() { }
        public Cart(List<CartItem> items)
        {
            Items.AddRange(items);
        }
        public void AddCartItem(Product product)
        {
            var existingItem = Items.FirstOrDefault(e => e.Product.Id == product.Id);
            if (existingItem != null)
                existingItem.AddItem();
            else
            {
                var cartItem = new CartItem(product);
                Items.Add(cartItem);
            }
        }
        public void AddCartItem(Product product, int quantity)
        {
            var existingItem = Items.FirstOrDefault(e => e.Product.Id == product.Id);
            if (existingItem != null)
                existingItem.AddItems(quantity);
            else
            {
                var cartItem = new CartItem(product, quantity);
                Items.Add(cartItem);
            }
        }
        public void RemoveCartItem(long productId)
        {
            var existingItem = Items.FirstOrDefault(e => e.Product.Id == productId);
            if (existingItem != null)
                existingItem.RemoveItem();
            else
                throw new Exception("CartItem not found");

            if (existingItem.Quantity <= 0)
                Items.Remove(existingItem);
        }
    }
}
