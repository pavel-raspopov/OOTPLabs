using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OOTP.VehiclesElement;
using OOTP.Attributes;

namespace OOTP.Vehicles.LVehicle
{
    public enum SideCar
    {
        yes,
        no
    }
    [Serializable]
    [VehicleType("Мотоцикл")]
    public class Motobike : LandVehicle
    {
        public SideCar SideCar { get; set; }

        public Motobike()
        {
            EngineParams = new Engine();
        }
    }
}
