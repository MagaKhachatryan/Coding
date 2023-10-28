using ImageManager.Plugins;

namespace ImageManager
{
    public class ImageFile
    {
        public double Width { get; set; }
        public double Height { get; set; }
        public double Radius { get; set; }
        public string Extension { get; set; }
        public Dictionary<string,IEffectPlugin> Effects { get; set; }
        public Dictionary<string,IFilterPlugin> Filters { get; set; }
        private byte[] _imageData;
        public ImageFile(byte[] imageData)
        {
            _imageData = imageData;
        }
    }
}