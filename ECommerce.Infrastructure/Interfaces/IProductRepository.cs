using ECommerce.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ECommerce.Infrastructure.Interfaces
{
    public interface IProductRepository : IRepository<Product>
    {
        public Product GetByName(string name);
    }
}
