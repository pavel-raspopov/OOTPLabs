using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OOTP.VehiclesElement;
using OOTP.Attributes;

namespace OOTP.Vehicles.LVehicle
{
    public enum DriveUnit
    {
        none,
        front,
        rear,
        full
    }
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
    [VehicleType("Автомобиль")]
    public class Auto : LandVehicle
    {
        public int NumDoors { get; set; }
        public Body Body { get; set; }
        public DriveUnit DriveUnit { get; set; }
        public Auto()
        {
            EngineParams = new Engine();
        }
    }
}
