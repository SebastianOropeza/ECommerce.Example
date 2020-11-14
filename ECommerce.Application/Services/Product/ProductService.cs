using ECommerce.Application.Dtos;
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

        public long Create(ProductDto productDto)
        {
            var alreadyExists = productRepository.GetByName(productDto.Name);
            if (alreadyExists != null)
                throw new Exception("The product already exists");

            var product = new Product(productDto.Name, productDto.Category, productDto.UnitsInStock, productDto.UnitPrice);
            var id = productRepository.Add(product);

            productRepository.Commit();

            return id;
        }

        public Product GetById(long id)
        {
            return productRepository.GetById(id);
        }

        public IEnumerable<Product> GetProducts()
        {
            var products = productRepository.GetAll();
            return products;
        }
    }
}
