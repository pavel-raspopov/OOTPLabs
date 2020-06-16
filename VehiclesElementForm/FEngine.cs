using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OOTP.VehiclesElement;

namespace OOTP.VehiclesElementForm
{
    public partial class FEngine : Form
    {
        public bool ReadOnly = false;
        public FEngine()
        {
            InitializeComponent();
            comboBFuel.SelectedIndex = 0;
        }
        public void SetReadOnly()
        {
            foreach (var TextBox in Controls.OfType<TextBox>())
            {
                TextBox.ReadOnly = true;
            }
            foreach (var ComboBox in Controls.OfType<ComboBox>())
            {
                ComboBox.Enabled = false;
            }

            butSave.Hide();
        }
        public void SetPower(int Power)
        {
            if (Power != 0)
                textBPower.Text = Convert.ToString(Power);
            else
                textBPower.Text = "";
        }
        public int GetPower()
        {
            if (textBPower.Text.Length != 0)
                return Convert.ToInt32(textBPower.Text);
            else
                return 0;
        }
        public void SetVolume(double Volume)
        {
            if (Volume != 0)
                textBVolume.Text = Convert.ToString(Volume);
            else
                textBVolume.Text = "";
        }
        public double GetVolume()
        {
            if (textBVolume.Text.Length != 0)
                return Convert.ToDouble(textBVolume.Text);
            else
                return 0;
        }
        public void SetTypeFuel(TypeFuel typeFuel)
        {
            switch (typeFuel)
            {
                case TypeFuel.none: comboBFuel.SelectedIndex = 0; break;
                case TypeFuel.petrol: comboBFuel.SelectedIndex = 1; break;
                case TypeFuel.diesel: comboBFuel.SelectedIndex = 2; break;
                case TypeFuel.gas: comboBFuel.SelectedIndex = 3; break;
            }
        }
        public TypeFuel GetTypeFuel()
        {
            switch (comboBFuel.SelectedIndex)
            {
                case 0: return TypeFuel.none;
                case 1: return TypeFuel.petrol;
                case 2: return TypeFuel.diesel;
                case 3: return TypeFuel.gas;
            }
            return TypeFuel.petrol;
        }

        private void butSave_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FEngine_Shown(object sender, EventArgs e)
        {
            if (ReadOnly == true)
                SetReadOnly();
        }

        private void textBPower_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBVolume_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
