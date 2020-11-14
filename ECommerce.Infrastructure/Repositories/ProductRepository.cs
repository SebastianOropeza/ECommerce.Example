using ECommerce.Domain.Entities;
using ECommerce.Infrastructure.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
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
            context.Add(entity);
            return entity.Id;
        }

        public void Delete(long id)
        {
            context.Remove(id);
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
            context.Update(entity);
        }

        public void Commit()
        {
            context.SaveChanges();
        }

        public Product GetByName(string name)
        {
            return context.Products.FirstOrDefault(p => p.Name == name);
        }
    }
}
