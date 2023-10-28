namespace ImageManager.Plugins
{
    public class BasePlugin : IPlugin
    {
        public string Name { get; set; }
        public double Percent { get; set; }

        protected byte[] _pluginData;
        public BasePlugin(string name, byte[] pluginData)
        {
            Name = name;
            _pluginData = pluginData;
        }
    }
}
