using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace API
{
    internal class WeatherResponser
    {
        public string Name { get; set; }
        public MainInfo Main { get; set; }
    }

    class MainInfo
    {
        public string Temp { get; set; }
    }
}
