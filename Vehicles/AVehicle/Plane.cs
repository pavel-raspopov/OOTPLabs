using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OOTP.Attributes;

namespace OOTP.Vehicles.AVehicle
{
    public enum AircraftType
    {
        none,
        passenger,
        transport,
        military
    }

    [Serializable]
    [VehicleType("Самолет")]
    public class Plane : AirVehicle
    {
        public int NumTurbines { get; set; }
        public AircraftType Type { get; set; }
    }
}
