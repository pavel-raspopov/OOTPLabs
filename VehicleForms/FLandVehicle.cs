using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OOTP.VehiclesElementForm;
using OOTP.VehiclesElement;

namespace OOTP.VehicleForms
{
    public partial class FLandVehicle : FVehicle
    {
        protected FEngine FEngine;
        public FLandVehicle()
        {
            InitializeComponent();
            FEngine = new FEngine();
        }
        public void SetNumOfWheels(int numWheels)
        {
            if (numWheels != 0)
                TextBNumWheels.Text = Convert.ToString(numWheels);
            else
                TextBNumWheels.Text = "";
        }
        public int GetNumOfWheels()
        {
            if (TextBNumWheels.Text.Length != 0)
                return Convert.ToInt32(TextBNumWheels.Text);
            else
                return 0;
        }
        public void SetVolume(double volume)
        {
            FEngine.SetVolume(volume);
        }
        public double GetVolume()
        {
            return FEngine.GetVolume();
        }
        public void SetPower(int power)
        {
            FEngine.SetPower(power);
        }
        public int GetPower()
        {
            return FEngine.GetPower();
        }
        public void SetTypeFuel(TypeFuel typeFuel)
        {
            FEngine.SetTypeFuel(typeFuel);
        }
        public TypeFuel GetTypeFuel()
        {
            return FEngine.GetTypeFuel();
        }

        private void FLandVehicle_Load(object sender, EventArgs e)
        {

        }

        private void TextBNumWheels_KeyPress(object sender, KeyPressEventArgs e)
        {
            CheckEnterData(sender, e);
        }

        private void ButViewEngine_Click(object sender, EventArgs e)
        {
            FEngine.ShowDialog();
        }
    }
}
