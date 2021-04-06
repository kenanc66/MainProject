using Business.Abstract;
using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Controllers

{
    [Route("api/[controller]")]
    [ApiController]//Attribute,annotation(java)
    public class ProductsController : ControllerBase
    {
        IProductService _productService;
        //loosely coupled ,gevşek bağlılık Use Interfaces Instead of Concrete classes
        public ProductsController(IProductService productService)
        {
            _productService = productService;
        }

        [HttpGet]
        public List<Product> Get()
        {
            //dependency chain
           
          var result = _productService.GetAll();
            return result.Data;
        }
    }
}
