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
            ComboBFuel.SelectedIndex = 0;
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

            ButSave.Hide();
        }
        public void SetPower(int Power)
        {
            if (Power != 0)
                TextBPower.Text = Convert.ToString(Power);
            else
                TextBPower.Text = "";
        }
        public int GetPower()
        {
            if (TextBPower.Text.Length != 0)
                return Convert.ToInt32(TextBPower.Text);
            else
                return 0;
        }
        public void SetVolume(double Volume)
        {
            if (Volume != 0)
                TextBVolume.Text = Convert.ToString(Volume);
            else
                TextBVolume.Text = "";
        }
        public double GetVolume()
        {
            if (TextBVolume.Text.Length != 0)
                return Convert.ToDouble(TextBVolume.Text);
            else
                return 0;
        }
        public void SetTypeFuel(TypeFuel typeFuel)
        {
            switch (typeFuel)
            {
                case TypeFuel.none: ComboBFuel.SelectedIndex = 0; break;
                case TypeFuel.petrol: ComboBFuel.SelectedIndex = 1; break;
                case TypeFuel.diesel: ComboBFuel.SelectedIndex = 2; break;
                case TypeFuel.gas: ComboBFuel.SelectedIndex = 3; break;
            }
        }
        public TypeFuel GetTypeFuel()
        {
            switch (ComboBFuel.SelectedIndex)
            {
                case 0: return TypeFuel.none;
                case 1: return TypeFuel.petrol;
                case 2: return TypeFuel.diesel;
                case 3: return TypeFuel.gas;
            }
            return TypeFuel.petrol;
        }

        private void ButSave_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FEngine_Shown(object sender, EventArgs e)
        {
            if (ReadOnly == true)
                SetReadOnly();
        }

        private void TextBPower_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void TextBVolume_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void FEngine_Load(object sender, EventArgs e)
        {

        }
    }
}
