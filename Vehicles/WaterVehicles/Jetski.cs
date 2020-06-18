using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOTP.Vehicles.WaterVehicles
{
    public enum JetskiType
    {
        none,
        tourist,
        sport
    }
    [Serializable]
    public class Jetski : WaterVehicle
    {
        public int Seats { get; set; }
        public JetskiType Type { get; set; }
    }
}
