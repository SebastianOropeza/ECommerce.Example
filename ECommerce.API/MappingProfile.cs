using AutoMapper;
using ECommerce.API.Dtos;
using ECommerce.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ECommerce.API
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Product, ProductDto>();
            CreateMap<Cart, CartDto>();
            CreateMap<CartItem, CartItemDto>();
        }
    }
}
