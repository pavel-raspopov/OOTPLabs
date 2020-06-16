using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OOTP.VehiclesElement;
using OOTP.Attributes;

namespace OOTP.Vehicles.AVehicle
{
    public enum Shell
    {
        none,
        soft,
        semirigid,
        hard
    }

    [Serializable]
    [VehicleType("Дирижабль")]
    public class Airship : AirVehicle
    {
        public int NumScrews { get; set; }
        public Shell Shell { get; set; }
    }
}
