using Microsoft.AspNetCore.Mvc;

namespace GentleExpress.API.Controllers;

[Route("api/[controller]")]
[ApiController]
public class ImagesController : ControllerBase
{
    private readonly IWebHostEnvironment _env;

    public ImagesController(IWebHostEnvironment env)
    {
        this._env = env;
    }

    [HttpGet("{imageName}")]
    public IActionResult GetImage(string imageName)
    {
        if (!string.IsNullOrEmpty(imageName))
        {
            // Get the path to the "Images" directory
            var imagesPath = Path.Combine(_env.ContentRootPath, "Images");

            // Combine the path with the requested image name
            var imagePath = Path.Combine(imagesPath, imageName);

            // Check if the image file exists
            if (System.IO.File.Exists(imagePath))
            {
                // Read the image file
                var imageBytes = System.IO.File.ReadAllBytes(imagePath);

                // Determine the content type (e.g., image/jpeg, image/png) based on file extension
                var contentType = GetContentType(imageName);

                // Return the image as a FileResult
                return File(imageBytes, contentType);
            }
        }

        // If the image doesn't exist, return a placeholder image or an error message.
        return NotFound();
    }

    private string GetContentType(string fileName)
    {
        // Map file extensions to content types as needed
        if (fileName.EndsWith(".jpg", StringComparison.OrdinalIgnoreCase) ||
            fileName.EndsWith(".jpeg", StringComparison.OrdinalIgnoreCase))
        {
            return "image/jpeg";
        }
        else if (fileName.EndsWith(".png", StringComparison.OrdinalIgnoreCase))
        {
            return "image/png";
        }
        // Add more content type mappings as required

        // If the extension is not recognized, you can return a default content type or handle it differently.
        return "application/octet-stream"; // Default to binary data
    }
}
