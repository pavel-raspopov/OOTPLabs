using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OOTP.EngineClass;
using OOTP.EngineForm;

namespace OOTP.VehiclesForms
{
    public partial class FLandVehicle : FVehicle
    {
        protected FEngine FEngine;
        public FLandVehicle()
        {
            InitializeComponent();
            FEngine = new FEngine();
        }
        public void SetWheels(int wheels)
        {
            if (wheels != 0)
                TextBWheels.Text = Convert.ToString(wheels);
            else
                TextBWheels.Text = "";
        }
        public int GetWheels()
        {
            if (TextBWheels.Text.Length != 0)
                return Convert.ToInt32(TextBWheels.Text);
            else
                return 0;
        }
        public void SetExp(int Exp)
        {
            FEngine.SetExp(Exp);
        }
        public int GetExp()
        {
            return FEngine.GetExp();
        }
        public void SetPower(int power)
        {
            FEngine.SetPower(power);
        }
        public int GetPower()
        {
            return FEngine.GetPower();
        }
        public void SetEffic(double effic)
        {
            FEngine.SetEffic(effic);
        }
        public double GetEffic()
        {
            return FEngine.GetEffic();
        }
        public void SetEngineType(EngineType engineType)
        {
            FEngine.SetEngineType(engineType);
        }
        public EngineType GetEngineType()
        {
            return FEngine.GetEngineType();
        }

        private void FLandVehicle_Load(object sender, EventArgs e)
        {

        }

        private void TextBWheels_KeyPress(object sender, KeyPressEventArgs e)
        {
            CheckEnterData(sender, e);
        }

        private void ButViewEngine_Click(object sender, EventArgs e)
        {
            FEngine.ShowDialog();
        }
    }
}
