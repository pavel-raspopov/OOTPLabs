using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOTP.Vehicles.WaterVehicles
{
    public enum YachtType
    {
        none,
        cruise,
        sport
    }
    public enum DriveUnit
    {
        none,
        sail,
        sailmotor,
        motor
    }
    [Serializable]
    public class Yacht : WaterVehicle
    {
        public YachtType Type { get; set; }
        public DriveUnit Drive { get; set; }
    }
}
