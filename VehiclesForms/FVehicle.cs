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
    public partial class FVehicle : Form
    {
        public FVehicle()
        {
            InitializeComponent();
        }
        public void SetName(String name)
        {
            if (name != "")
                TextBName.Text = name;
            else
                TextBName.Text = "";
        }
        public String GetName()
        {
            return TextBName.Text;
        }
        public void SetPorp(String porp)
        {
            if (porp != "")
                TextBPorp.Text = porp;
            else
                TextBPorp.Text = "";
        }
        public String GetPorp()
        {
            return TextBPorp.Text;
        }
        public int GetWeight()
        {
            if (TextBWeight.Text.Length != 0)
                return Convert.ToInt32(TextBWeight.Text);
            else
                return 0;
        }
        public void SetWeight(int weight)
        {
            if (weight != 0)
                TextBWeight.Text = Convert.ToString(weight);
            else
                TextBWeight.Text = "";
        }
        public void CheckEnterData(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void FVehicle_Load(object sender, EventArgs e)
        {

        }

        private void TextBWeight_KeyPress(object sender, KeyPressEventArgs e)
        {
            CheckEnterData(sender, e);
        }
    }
}
