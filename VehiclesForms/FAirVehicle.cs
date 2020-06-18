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
    public partial class FAirVehicle : FVehicle
    {
        public FAirVehicle()
        {
            InitializeComponent();
        }
        public void SetMaxHeight(int maxHeight)
        {
            if (maxHeight != 0)
                TextBMaxHeight.Text = Convert.ToString(maxHeight);
            else
                TextBMaxHeight.Text = "";
        }

        public int GetMaxHeight()
        {
            if (TextBMaxHeight.Text.Length != 0)
                return Convert.ToInt32(TextBMaxHeight.Text);
            else
                return 0;
        }
        public void SetTakeoffWeight(int takeoffWeight)
        {
            if (takeoffWeight != 0)
                TextBTakeoffWeight.Text = Convert.ToString(takeoffWeight);
            else
                TextBTakeoffWeight.Text = "";
        }
        public int GetTakeoffWeight()
        {
            if (TextBTakeoffWeight.Text.Length != 0)
                return Convert.ToInt32(TextBTakeoffWeight.Text);
            else
                return 0;
        }

        private void FAirVehicle_Load(object sender, EventArgs e)
        {

        }

        private void TextBMaxHeight_KeyPress(object sender, KeyPressEventArgs e)
        {
            CheckEnterData(sender, e);
        }

        private void TextBTakeoffWeight_KeyPress(object sender, KeyPressEventArgs e)
        {
            CheckEnterData(sender, e);
        }
    }
}
