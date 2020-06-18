using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOTP.Vehicles
{
    [Serializable]
    public abstract class Vehicle
    {
        public TypeNames TypeName { get; set; }
        public string Name { get; set; } = "";
        public string Purpose { get; set; } = "";
        public int Weight { get; set; }

    }
}
