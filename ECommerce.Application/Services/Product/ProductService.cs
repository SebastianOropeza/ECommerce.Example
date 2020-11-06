using ECommerce.Domain.Entities;
using ECommerce.Infrastructure.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace ECommerce.Domain.Services
{
    public class ProductService : IProductService
    {
        private readonly IProductRepository productRepository;
        public ProductService(IProductRepository productRepository)
        {
            this.productRepository = productRepository;
        }
        public IEnumerable<Product> GetProducts()
        {
            var products = productRepository.GetAll();
            return products;
        }
    }
}
