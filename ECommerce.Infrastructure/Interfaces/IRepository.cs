using System;
using System.Collections.Generic;
using System.Text;

namespace ECommerce.Infrastructure.Interfaces
{
    public interface IRepository<T> where T : class
    {
        public IEnumerable<T> GetAll();
        public T GetById(long id);
        public void Update(T entity);
        public long Add(T entity);
        public void Delete(long id);
        public void Commit();
    }
}
