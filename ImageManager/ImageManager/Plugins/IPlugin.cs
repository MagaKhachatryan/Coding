namespace ImageManager.Plugins
{
    public interface IPlugin
    {
        string Name { get; }
        public double Percent { get; set; }

    }
}
