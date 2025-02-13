using System;
using System.Collections.Generic;

namespace ImageProcessingAPI
{
    public class ImageProcessor
    {
        private readonly List<Image> _images = new List<Image>();

        public void AddImage(Image image)
        {
            _images.Add(image);
        }

        public void ProcessImages()
        {
            foreach (var image in _images)
            {
                image.ApplyEffects();
            }
        }
    }
}
