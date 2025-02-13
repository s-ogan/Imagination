using System.Collections.Generic;

namespace ImageProcessingAPI
{
    public class Image
    {
        public string Name { get; }
        public List<IImageEffect> Effects { get; } = new List<IImageEffect>();

        public Image(string name)
        {
            Name = name;
        }

        public void ApplyEffects()
        {
            foreach (var effect in Effects)
            {
                effect.Apply(this);
            }
        }
    }
}
