﻿using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IProductService
    {
        List<Product> GetAll(); // tümünü getir
        List<Product> GetAllByCategoryId(int id); // id ile getir
        List<Product> GetByUnitPrice(decimal min, decimal max);
        

    }
}
