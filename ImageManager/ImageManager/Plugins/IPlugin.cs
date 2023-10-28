using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImageManager.Plugins
{
    public interface IPlugin
    {
        string Name { get; }
        public double Percent { get; set; }

    }
}
