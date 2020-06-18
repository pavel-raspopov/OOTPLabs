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

namespace OOTP.EngineForm
{
    public partial class FEngine : Form
    {
        public bool ReadOnly = false;
        public FEngine()
        {
            InitializeComponent();
            ComboBEngineType.SelectedIndex = 0;
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
        public void SetExp(int Exp)
        {
            if (Exp != 0)
                TextBExpend.Text = Convert.ToString(Exp);
            else
                TextBExpend.Text = "";
        }
        public int GetExp()
        {
            if (TextBExpend.Text.Length != 0)
                return Convert.ToInt32(TextBExpend.Text);
            else
                return 0;
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
        public void SetEffic(double Effic)
        {
            if (Effic != 0)
                TextBEffic.Text = Convert.ToString(Effic);
            else
                TextBEffic.Text = "";
        }
        public double GetEffic()
        {
            if (TextBEffic.Text.Length != 0)
                return Convert.ToDouble(TextBEffic.Text);
            else
                return 0;
        }
        public void SetEngineType(EngineType engineType)
        {
            switch (engineType)
            {
                case EngineType.none: ComboBEngineType.SelectedIndex = 0; break;
                case EngineType.petrol: ComboBEngineType.SelectedIndex = 1; break;
                case EngineType.diesel: ComboBEngineType.SelectedIndex = 2; break;
                case EngineType.gas: ComboBEngineType.SelectedIndex = 3; break;
                case EngineType.electrical: ComboBEngineType.SelectedIndex = 4; break;
            }
        }
        public EngineType GetEngineType()
        {
            switch (ComboBEngineType.SelectedIndex)
            {
                case 0: return EngineType.none;
                case 1: return EngineType.petrol;
                case 2: return EngineType.diesel;
                case 3: return EngineType.gas;
                case 4: return EngineType.electrical;
            }
            return EngineType.petrol;
        }
        private void FEngine_Load(object sender, EventArgs e)
        {

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

        private void TextBExpend_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void TextBPower_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void TextBEffic_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
