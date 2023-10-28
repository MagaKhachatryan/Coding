using ImageManager.Plugins;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImageManager
{
    public class ImageModifier : IImageModifier
    {
        public ImageFile Image { get; set; }
        public ImageModifier(ImageFile image)
        {
            Image = image;
        }

        public bool ApplyConfigs(string configs)
        {
            //here must be the code that recieves json file, deserializes it and applies the images settings to the image
            throw new NotImplementedException();
        }


        public bool ApplyRadius(double radius = -1)
        {
            try
            {
                if (Image == null)
                {
                    return false;
                }

                Image.Radius = radius == -1 ? Image.Radius : radius;
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool ApplySize(double width = -1, double height = -1)
        {
            try
            {
                if (Image == null)
                {
                    return false;
                }

                Image.Width = width == -1 ? Image.Width : width;
                Image.Height = height == -1 ? Image.Height : height;
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool AddEffect(IEffectPlugin plugin)
        {
            try
            {
                if (plugin == null || plugin.Name == null || Image == null)
                {
                    return false;
                }
                if (Image.Effects == null)
                {
                    Image.Effects = new Dictionary<string, IEffectPlugin>();
                }
                //Here must be the code which applies effect to the image 
                //also we can do some specific operations before appling the effect
                Image.Effects.Add(plugin.Name, plugin);
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool AddFilter(IFilterPlugin plugin)
        {
            try
            {
                if (plugin == null || plugin.Name == null || Image == null)
                {
                    return false;
                }

                if (Image.Filters == null)
                {
                    Image.Filters = new Dictionary<string, IFilterPlugin>();
                }

                //Here must be the code which applies filter to the image 
                //also we can do some specific operations before appling the filter
                Image.Filters.Add(plugin.Name, plugin);
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool RemoveEffect(string name)
        {
            try
            {
                if (name == null || Image == null || Image.Effects == null || Image.Effects.Count == 0)
                {
                    return false;
                }

                return Image.Effects.Remove(name);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool RemoveFilter(string name)
        {
            try
            {
                if (name == null || Image == null || Image.Filters == null || Image.Filters.Count == 0)
                {
                    return false;
                }

                return Image.Filters.Remove(name);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

    }
}
