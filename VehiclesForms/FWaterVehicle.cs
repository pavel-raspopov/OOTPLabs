using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOTP.VehiclesForms
{
    public partial class FWaterVehicle : FVehicle
    {
        public FWaterVehicle()
        {
            InitializeComponent();
        }
        public void SetWLine(int waterline)
        {
            if (waterline != 0)
                TextBWLine.Text = Convert.ToString(waterline);
            else
                TextBWLine.Text = "";
        }
        public int GetWLine()
        {
            if (TextBWLine.Text.Length != 0)
                return Convert.ToInt32(TextBWLine.Text);
            else
                return 0;
        }
        public void SetCons(int consumption)
        {
            if (consumption != 0)
                TextBCons.Text = Convert.ToString(consumption);
            else
                TextBCons.Text = "";
        }
        public int GetCons()
        {
            if (TextBCons.Text.Length != 0)
                return Convert.ToInt32(TextBCons.Text);
            else
                return 0;
        }

        private void FWaterVehicle_Load(object sender, EventArgs e)
        {

        }

        private void TextBWLine_KeyPress(object sender, KeyPressEventArgs e)
        {
            CheckEnterData(sender, e);
        }

        private void TextBCons_KeyPress(object sender, KeyPressEventArgs e)
        {
            CheckEnterData(sender, e);
        }
    }
}
