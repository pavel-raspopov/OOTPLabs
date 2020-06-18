using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OOTP.EngineClass;

namespace OOTP.Vehicles.LandVehicles
{
    public enum HeavyLoad
    {
        yes,
        no
    }
    public enum OversizedLoad
    {
        yes,
        no
    }
    [Serializable]
    public class Truck : LandVehicle
    {
        public HeavyLoad HeavyLoad { get; set; }
        public OversizedLoad OversizedLoad { get; set; }

        public Truck()
        {
            EngineData = new Engine();
        }
    }
}
