using ImageManager.Plugins;
using System.Drawing;
namespace ImageManager
{
    public interface IImageModifier
    {
        bool AddEffect(IEffectPlugin plugin);
        bool AddFilter(IFilterPlugin plugin);
        bool RemoveEffect(string name);
        bool RemoveFilter(string name);
        bool ApplySize(double width = -1, double height = -1);
        bool ApplyRadius(double radius = -1);
        bool ApplyConfigs(string configs);
    }
}
