using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using ECommerce.API.Dtos;
using ECommerce.Application.Services;
using ECommerce.Domain.Entities;
using ECommerce.Domain.Services;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ECommerce.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductService productService;
        private readonly IMapper mapper;

        public ProductController(IProductService productService, IMapper mapper)
        {
            this.productService = productService;
            this.mapper = mapper;
        }

        [HttpGet]
        public IEnumerable<ProductDto> GetProducts()
        {
            var products = productService.GetProducts();
            var productDtos = mapper.Map<ProductDto[]>(products);
            return productDtos;
        }

        [HttpGet("{id}")]
        public ProductDto Get(long id)
        {
            var product = productService.GetById(id);
            var productDto = mapper.Map<ProductDto>(product);
            return productDto;
        }
    }
}
