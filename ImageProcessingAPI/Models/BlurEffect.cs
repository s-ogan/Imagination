using System;

namespace ImageProcessingAPI
{
    public class BlurEffect : IImageEffect
    {
        public string Name => "Blur";
        public int Radius { get; }

        public BlurEffect(int radius)
        {
            Radius = radius;
        }

        public void Apply(Image image)
        {
            Console.WriteLine($" Blur Effect to {image.Name}, Radius: {Radius}");
        }
    }
}
