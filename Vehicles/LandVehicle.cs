using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OOTP.VehiclesElement;

namespace OOTP.Vehicles
{
    [Serializable]
    public abstract class LandVehicle : Vehicle
    {
        public int NumOfWheels { get; set; }
        public Engine EngineParams { get; set; }
    }
}
