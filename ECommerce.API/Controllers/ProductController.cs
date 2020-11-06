using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using ECommerce.Application.Dtos;
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
        private readonly ICartService cartService;
        private readonly IMapper mapper;

        public ProductController(IProductService productService, ICartService cartService, IMapper mapper)
        {
            this.productService = productService;
            this.cartService = cartService;
            this.mapper = mapper;
        }
        // GET: api/<ProductController>
        [HttpGet]
        public IEnumerable<ProductDto> GetProducts()
        {
            var products = productService.GetProducts();
            var productDtos = mapper.Map<ProductDto[]>(products);
            return productDtos;
        }

        // GET api/<ProductController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<ProductController>
        [HttpPost]
        public ActionResult AddToCart(AddToCartRequestDto requestDto)
        {
            cartService.AddToCart(requestDto.CartId, requestDto.ProductId);
            return Ok();
        }

        // PUT api/<ProductController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<ProductController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
