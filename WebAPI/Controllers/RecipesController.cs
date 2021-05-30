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
using System.IO;

namespace WebAPI.Controllers

{
    [Route("api/[controller]")]
    [ApiController]//Attribute,annotation(java)
    public class RecipesController : ControllerBase
    {
        IRecipeService _recipeService;
        //loosely coupled ,gevşek bağlılık Use Interfaces Instead of Concrete classes
        public RecipesController(IRecipeService recipeService)
        {
            _recipeService = recipeService;
        }

        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            Thread.Sleep(1000);
            var result = _recipeService.GetAll();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpGet("getbyid")]
        public IActionResult GetById(int id)
        {
            var result = _recipeService.GetById(id);

            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpGet("getbycategory")]
        public IActionResult GetByCategory(int categoryId)
        {
            var result = _recipeService.GetAllByCategoryId(categoryId);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpGet("getproductdetails")]
        public IActionResult GetProductDetails(int categoryId)
        {
            var result = _recipeService.GetProductDetails();
            if (result.Success)
            {
                return Ok(result);
            }

            return BadRequest(result);
        }
        [HttpGet("get/{fileName}")]

        public IActionResult GetFileAsync(string fileName)
        {
          string filePath = Path.Combine("Uploads", fileName);
            string mimeType = MimeKit.MimeTypes.GetMimeType(fileName);
                        var fileStream = new FileStream(filePath, FileMode.Open);

            return new FileStreamResult(fileStream, mimeType);

        }
        [HttpPost("add")]
        //delete and update can use httppost
        public IActionResult Add(Recipe recipe)
        {
            var result = _recipeService.Add(recipe);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
    }
}
