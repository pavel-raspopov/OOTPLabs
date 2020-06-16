using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OOTP.Attributes;

namespace OOTP.Vehicles.WVehicle
{
    [Serializable]
    [VehicleType("Паурсник")]
    public class Sailboat : WaterVehicle
    {
        public int NumSails { get; set; }
        public int NumMasts { get; set; }
    }
}
