using ECommerce.Domain.Entities;
using ECommerce.Infrastructure.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ECommerce.Infrastructure.Repositories
{
    public class CartRepository : ICartRepository
    {
        private readonly ECommerceContext context;
        public CartRepository(ECommerceContext context)
        {
            this.context = context;
        }

        public long Add(Cart entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(long id)
        {
            throw new NotImplementedException();
        }

        public Cart GetById(long id)
        {
            return context.Carts
                .Include(e => e.Items)
                    .ThenInclude(i => i.Product)
                .FirstOrDefault(e => e.Id == id);
        }

        public IEnumerable<Cart> GetAll()
        {
            return context.Carts
                .Include(e => e.Items)
                    .ThenInclude(i => i.Product);
        }

        public void Update(Cart entity)
        {
            context.Update(entity);
        }

        public void Commit()
        {
            context.SaveChanges();
        }
    }
}
