using DataAccess.Concrete.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.IO;

namespace WebAPI.Controllers
{
    namespace WebAPI.Controllers { 
        [Route("api/[controller]")]
        [ApiController]
        public class FileServerController : ControllerBase
        {
            private readonly NorthwindContext db;

            public FileServerController(
                    NorthwindContext db
                )
            {
                this.db = db;
            }

          
            [HttpGet("get/{fileName}")]
            
            public IActionResult GetFileAsync(string fileName)
            {
                //var fileFromDb = db.Recipes.FirstOrDefault(n => n.DataPath == fileName);

                // dosyaya erişim için gerekli ilişkisel sorgulamalar yapılacak
                // erişim izni yoksa ilgili http response dönülecek
                //if (fileFromDb == null)
                //    return NoContent();


                string filePath = Path.Combine("Uploads", fileName);
                string mimeType = MimeKit.MimeTypes.GetMimeType(fileName);

                var fileStream = new FileStream(filePath, FileMode.Open);

                return new FileStreamResult(fileStream, mimeType);

            }
        }
    }
}
