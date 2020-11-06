﻿using ECommerce.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ECommerce.Domain.Services
{
    public interface IProductService
    {
        public IEnumerable<Product> GetProducts();
    }
}
