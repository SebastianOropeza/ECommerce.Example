using ECommerce.Domain.Entities.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace ECommerce.Domain.Entities
{
    public class CartItem : Entity
    {
        public long ProductId { get; private set; }
        public Product Product { get; private set; }
        public int Quantity { get; private set; }
        public decimal TotalPrice { get; private set; }

        private CartItem() { }
        public CartItem(Product product, int quantity = 1)
        {
            Product = product;
            Quantity = quantity;
            CalculateTotalPrice();
        }

        public void AddItem()
        {
            Quantity++;
            CalculateTotalPrice();
        }
        public void AddItems(int quantity)
        {
            Quantity += quantity;
            CalculateTotalPrice();
        }
        public void RemoveItem()
        {
            Quantity--;
            CalculateTotalPrice();
        }

        private void CalculateTotalPrice()
        {
            TotalPrice = Quantity * Product.UnitPrice;
        }
    }
}
