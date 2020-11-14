using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using ECommerce.Application.Dtos;
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
        private readonly IMapper mapper;

        public CartController(ICartService cartService, IMapper mapper)
        {
            this.cartService = cartService;
            this.mapper = mapper;
        }

        [HttpGet]
        public IEnumerable<CartDto> Get()
        {
            var carts = cartService.GetCarts();
            var cartDtos = mapper.Map<CartDto[]>(carts);
            return cartDtos;
        }

        [HttpGet("{id}")]
        public CartDto Get(long id)
        {
            var cart = cartService.GetById(id);
            var cartDto = mapper.Map<CartDto>(cart);
            return cartDto;
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
            cartService.RemoveFromCart(requestDto.CartId, requestDto.ProductId);
            return Ok();
        }
    }
}
