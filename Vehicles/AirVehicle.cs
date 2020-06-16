using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOTP.Vehicles
{
    [Serializable]
    public abstract class AirVehicle : Vehicle
    {
        public int MaxHeight { get; set; }
        public int TakeoffWeight { get; set; }
    }
}
