using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOTP.Vehicles
{
    [Serializable]
    public abstract class Vehicle
    {
        public string Name { get; set; } = "";
        public int Year { get; set; }
        public int Weight { get; set; }
        public int MaxSpeed { get; set; }
    }
}
