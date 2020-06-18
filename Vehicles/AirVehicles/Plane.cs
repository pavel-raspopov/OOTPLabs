using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOTP.Vehicles.AirVehicles
{
    public enum AircraftType
    {
        none,
        passenger,
        transport,
        military
    }
    [Serializable]
    public class Plane : AirVehicle
    {
        public int NumTurbines { get; set; }
        public AircraftType Type { get; set; }
    }
}
