namespace ImageProcessingAPI
{
    public interface IImageEffect
    {
        string Name { get; }
        void Apply(Image image);
    }
}
