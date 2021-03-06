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
using System.Threading;

namespace WebAPI.Controllers
    //this is a base controller we will use.
{
    [Route("api/[controller]")]
    [ApiController]//Attribute,annotation(java)
    public class ProductsController : ControllerBase
    {
        //IProductService _productService;
        //IRecipeService _recipeService;
        ////loosely coupled ,gevşek bağlılık Use Interfaces Instead of Concrete classes
        //public ProductsController(IProductService productService, IRecipeService recipeService)
        //{
        //    _productService = productService;
        //    _recipeService = recipeService;
        //}

        //[HttpGet("getall")]
        //public IActionResult GetAll()
        //{
        //    Thread.Sleep(1000);
        //    var result = _productService.GetAll();
        //    if (result.Success)
        //    {
        //        return Ok(result);
        //    }
        //    return BadRequest(result);
        //}
        //[HttpGet("getbyid")]
        //public IActionResult GetById(int id)
        //{
        //    var result = _productService.GetById(id);

        //    if (result.Success)
        //    {
        //        return Ok(result);
        //    }
        //    return BadRequest(result);
        //}
        //[HttpGet("getbycategory")]
        //public IActionResult GetByCategory(int categoryId)
        //{
        //    var result = _recipeService.GetProductDetails();
           
        //    if (result.Success)
        //    {
        //        return Ok(result.Data.Where(n => n.CategoryId == categoryId).ToList());
        //    }

        //    return BadRequest(result);

        //}
        //[HttpGet("getproductdetails")]
        //public IActionResult GetProductDetails(int categoryId)
        //{
        //    var result = _productService.GetProductDetails();
        //    if (result.Success)
        //    {
        //        return Ok(result);
        //    }

        //    return BadRequest(result);
        //}
        //[HttpPost("add")]
        ////delete and update can use httppost
        //public IActionResult Add(Product product)
        //{
        //    var result = _productService.Add(product);
        //    if (result.Success)
        //    {
        //        return Ok(result);
        //    }
        //    return BadRequest(result);
        //}
    }
}
