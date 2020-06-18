using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOTP.Vehicles.AirVehicles
{
    public enum Shell
    {
        none,
        soft,
        semirigid,
        hard
    }
    [Serializable]
    public class Airship : AirVehicle
    {
        public int NumScrews { get; set; }
        public Shell Shell { get; set; }
    }
}
