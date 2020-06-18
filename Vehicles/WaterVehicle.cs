using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOTP.Vehicles
{
    [Serializable]
    public abstract class WaterVehicle : Vehicle
    {
        public int Waterline { set; get; }
        public int Сonsumption { set; get; }
    }
}
