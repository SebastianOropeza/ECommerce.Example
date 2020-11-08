using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ECommerce.API.Dtos;
using ECommerce.Application.Services;
using ECommerce.Domain.Entities;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ECommerce.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CartController : ControllerBase
    {
        private readonly ICartService cartService;
        public CartController(ICartService cartService)
        {
            this.cartService = cartService;
        }

        [HttpGet]
        public IEnumerable<Cart> Get()
        {
            return cartService.GetCarts();
        }

        [HttpGet("{id}")]
        public Cart Get(long id)
        {
            return cartService.GetById(id);
        }

        [HttpPost("AddProduct")]
        public ActionResult AddProduct(CartProductRequestDto requestDto)
        {
            cartService.AddToCart(requestDto.CartId, requestDto.ProductId);
            return Ok();
        }

        [HttpPost("RemoveProduct")]
        public ActionResult RemoveProduct(CartProductRequestDto requestDto)
        {
            cartService.AddToCart(requestDto.CartId, requestDto.ProductId);
            return Ok();
        }
    }
}
