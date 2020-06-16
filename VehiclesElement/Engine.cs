using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOTP.VehiclesElement
{
    public enum TypeFuel
    {
        none,
        petrol,
        diesel,
        gas
    }
    [Serializable]
    public class Engine
    {
        public int Power { get; set; }
        public double Volume { get; set; }
        public TypeFuel TypeFuel { get; set; }
        public Engine(int power, double volume, TypeFuel typeFuel)
        {
            this.Power = power;
            this.Volume = volume;
            this.TypeFuel = typeFuel;
        }
        public Engine()
        {
        }
    }
}
