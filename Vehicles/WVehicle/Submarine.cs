using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OOTP.Attributes;

namespace OOTP.Vehicles.WVehicle
{
    [Serializable]
    [VehicleType("Подлодка")]
    public class Submarine : WaterVehicle
    {
        public int MaxImmersionDepth { get; set; }
        public int NumTurbines { get; set; }
    }
}
