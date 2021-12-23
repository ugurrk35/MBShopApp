﻿using MBShopApp.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace MBShopApp.DataAccess.Abstract
{
    public interface IProductDal:IRepository<Product>
    {
       
        IEnumerable<Product> GetPopularProducts();

    }
}