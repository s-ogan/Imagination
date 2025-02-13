using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace ImageProcessingAPI.Controllers
{
    [ApiController]
    [Route("api/images")]
    public class ImageProcessingController : ControllerBase
    {
        private readonly ImageProcessor _imageProcessor;

        public ImageProcessingController()
        {
            _imageProcessor = new ImageProcessor();
        }

        [HttpPost("apply")]
        public IActionResult ApplyEffects([FromBody] List<ImageRequest> request)
        {
           foreach (var req in request)
            {
                var image = new Image(req.Name);
                foreach (var effect in req.Effects)
                {
                    if (effect.Type == "Resize")
                    {
                        image.Effects.Add(new ResizeEffect(effect.Size));
                    }
                    else if (effect.Type == "Blur")
                    {
                        image.Effects.Add(new BlurEffect(effect.Radius));
                    }
                }
                _imageProcessor.AddImage(image);
            }

            _imageProcessor.ProcessImages();
            return Ok(new { message = "Images added successfully." });
        }


    public class ImageRequest
    {
        public string Name { get; set; }
        public List<ImageEffectRequest> Effects { get; set; } = new List<ImageEffectRequest>();
    }

    public class ImageEffectRequest
    {
        public string Type { get; set; }
        public int Size { get; set; }
        public int Radius { get; set; }
    }
}}
