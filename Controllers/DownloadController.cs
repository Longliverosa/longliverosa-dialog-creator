using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace DialogCreator.Controllers
{
    public partial class DownloadController(IWebHostEnvironment webHostEnvironment) : Controller
    {
        private readonly IWebHostEnvironment _webHostEnvironment = webHostEnvironment;


        [HttpGet("downloadcsv/{documentname}")]
        public IActionResult DownloadCsv(string documentname)
        {
            var filePath = Path.Combine(_webHostEnvironment.WebRootPath, documentname);
            if (!System.IO.File.Exists(filePath))
            {
                return NotFound();
            }
            var fileBytes = System.IO.File.ReadAllBytes(filePath);
            var contentType = "text/csv";
            System.IO.File.Delete(filePath);
            return File(fileBytes, contentType, "dialog.csv");
        }


        [HttpGet("downloadjson/{documentname}")]
        public IActionResult DownloadJson(string documentname)
        {
            var filePath = Path.Combine(_webHostEnvironment.WebRootPath, documentname);
            if (!System.IO.File.Exists(filePath))
            {
                return NotFound();
            }
            var fileBytes = System.IO.File.ReadAllBytes(filePath);
            var contentType = "application/json";
            System.IO.File.Delete(filePath);
            return File(fileBytes, contentType, "dialog.json");
        }

        [HttpPost]
        [Route("uploadjson")]
        public ActionResult PostJson(IFormFile file)
        {
            try
            {
                if (file.ContentType != "application/json" || !file.FileName.EndsWith(".json"))
                {
                    return StatusCode(415);
                }

                var guid = Guid.NewGuid().ToString();
                var filePath = Path.Combine(_webHostEnvironment.WebRootPath, $"{guid}.json");
                using var fileStream = System.IO.File.Create(filePath);
                file.CopyTo(fileStream);
                fileStream.Close();

                return Ok(new { Guid = guid });
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }
    }
}
