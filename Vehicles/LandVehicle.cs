using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OOTP.EngineClass;

namespace OOTP.Vehicles
{
    [Serializable]
    public abstract class LandVehicle : Vehicle
    {
        public int Wheels { get; set; }
        public Engine EngineData{ get; set; }
    }
}
