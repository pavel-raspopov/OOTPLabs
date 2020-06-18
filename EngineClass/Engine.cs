using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOTP.EngineClass
{
    public enum EngineType
    {
        none,
        petrol,
        diesel,
        gas,
        electrical
    }
    [Serializable]
    public class Engine
    {
        public int Expenditure { get; set; }
        public int Power { get; set; }
        public double Efficiency { get; set; }
        public EngineType Type { get; set; }
        public Engine(int expenditure, int power, double efficiency, EngineType type)
        {
            this.Expenditure = expenditure;
            this.Power = power;
            this.Efficiency = efficiency;
            this.Type = type;
        }
        public Engine()
        {
        }
    }
}
