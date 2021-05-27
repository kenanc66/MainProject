﻿using DataAccess.Abstract;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq.Expressions;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using Core.DataAccess.EntityFramework;
using Entities.DTOs;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfProductDal
        : EfEntityRepositoryBase<Product, NorthwindContext>, IProductDal
    {
        public List<ProductDetailDto> GetProductDetails()
        {
            using (NorthwindContext context=new NorthwindContext())
            {
                var result = from p in context.Products
                       join c in context.Categories
                         on p.CategoryId equals c.Id
            select new ProductDetailDto
            {
            ProductId = p.ProductId, ProductName = p.ProductName,
            CategoryName = c.Name, UnitsInStock = p.UnitsInStock 
            };
                return result.ToList();
            }
          
        }
    }
}
