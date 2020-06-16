using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOTP.VehicleForms
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
                textBName.Text = name;
            else
                textBName.Text = "";
        }
        public String GetName()
        {
            return textBName.Text;
        }
        public int GetYear()
        {
            if (textBYear.Text.Length != 0)
                return Convert.ToInt32(textBYear.Text);
            else
                return 0;
        }
        public void SetYear(int year)
        {
            if (year != 0)
                textBYear.Text = Convert.ToString(year);
            else
                textBYear.Text = "";
        }
        public int GetWeight()
        {
            if (textBWeight.Text.Length != 0)
                return Convert.ToInt32(textBWeight.Text);
            else
                return 0;
        }
        public void SetWeight(int weight)
        {
            if (weight != 0)
                textBWeight.Text = Convert.ToString(weight);
            else
                textBWeight.Text = "";
        }
        public void SetMaxSpeed(int maxSpeed)
        {
            if (maxSpeed != 0)
                textBMaxSpeed.Text = Convert.ToString(maxSpeed);
            else
                textBMaxSpeed.Text = "";
        }
        public int GetMaxSpeed()
        {
            if (textBMaxSpeed.Text.Length != 0)
                return Convert.ToInt32(textBMaxSpeed.Text);
            else
                return 0;
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

        private void textBYear_KeyPress(object sender, KeyPressEventArgs e)
        {
            CheckEnterData(sender, e);
        }

        private void textBWeight_KeyPress(object sender, KeyPressEventArgs e)
        {
            CheckEnterData(sender, e);
        }

        private void textBMaxSpeed_KeyPress(object sender, KeyPressEventArgs e)
        {
            CheckEnterData(sender, e);
        }
    }
}
