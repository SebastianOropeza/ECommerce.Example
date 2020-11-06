using ECommerce.Domain.Entities;
using ECommerce.Infrastructure.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace ECommerce.Infrastructure.Repositories
{
    public class ProductRepository : IProductRepository
    {
        private readonly ECommerceContext context;
        public ProductRepository(ECommerceContext context)
        {
            this.context = context;
        }

        public long Add(Product entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(long id)
        {
            throw new NotImplementedException();
        }

        public Product GetById(long id)
        {
            return context.Products.Find(id);
        }

        public IEnumerable<Product> GetAll()
        {
            return context.Products;
        }

        public void Update(Product entity)
        {
            throw new NotImplementedException();
        }

        public void Commit()
        {
            context.SaveChanges();
        }
    }
}
