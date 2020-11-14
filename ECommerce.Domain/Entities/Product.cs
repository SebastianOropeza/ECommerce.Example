using ECommerce.Domain.Entities.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace ECommerce.Domain.Entities
{
    public class Product : Entity
    {
        public string Name { get; private set; }
        public string Category { get; private set; }
        public decimal UnitPrice { get; private set; }
        public int UnitsInStock { get; private set; }

        private Product() { }

        public Product(string name, string category, int unitsInStock, decimal unitPrice = 0)
        {
            Name = string.IsNullOrWhiteSpace(name) ? throw new Exception(nameof(Name) + " cannot be null or empty") : name;
            Category = string.IsNullOrWhiteSpace(category) ? throw new Exception(nameof(Category) + " cannot be null or empty") : category;
            UnitsInStock = unitsInStock;
            UnitPrice = unitPrice;
        }
    }
}
