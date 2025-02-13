using System;

namespace ImageProcessingAPI
{
    public class ResizeEffect : IImageEffect
    {
        public string Name => "Resize";
        public int Size { get; }

        public ResizeEffect(int size)
        {
            Size = size;
        }

        public void Apply(Image image)
        {
            Console.WriteLine($"Resize Effect to {image.Name}, size: {Size}");
        }
    }
}
