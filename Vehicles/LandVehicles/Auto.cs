using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OOTP.EngineClass;

namespace OOTP.Vehicles.LandVehicles
{
    public enum Body
    {
        none,
        sedan,
        hatchback,
        truck,
        coupe,
        supercar,
        suv,
        cuv,
        cabriolet,
        roadster,
        pickup,
        van
    }
    [Serializable]
    public class Auto : LandVehicle
    {
        public int PassengerSeats { get; set; }
        public Body Body { get; set; }
        public Auto()
        {
            EngineData = new Engine();
        }
    }
}
