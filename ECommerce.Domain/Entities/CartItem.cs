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
        public int TotalPrice { get; private set; }

        private CartItem() { }
        public CartItem(Product product, int quantity = 1)
        {
            Product = product;
            Quantity = quantity;
            TotalPrice = (int)(Quantity * Product.UnitPrice);
        }

        public void AddItem()
        {
            Quantity++;
            RecalculateTotalPrice();
        }
        public void AddItems(int quantity)
        {
            Quantity += quantity;
            RecalculateTotalPrice();
        }
        public void RemoveItem()
        {
            Quantity--;
            RecalculateTotalPrice();
        }

        private void RecalculateTotalPrice()
        {
            TotalPrice = (int)(Quantity * Product.UnitPrice);
        }
    }
}
