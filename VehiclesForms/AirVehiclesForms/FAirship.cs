using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OOTP.Vehicles;
using OOTP.Vehicles.AirVehicles;

namespace OOTP.VehiclesForms.AirVehiclesForms
{
    public partial class FAirship : FAirVehicle
    {
        private Airship receivedAirship = null;
        public FAirship()
        {
            InitializeComponent();
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
        private void InitializeForm()
        {
            InitializeComponent();
            ComboBShell.SelectedIndex = 0;
        }
        public FAirship(object transport, bool readMode)
        {
            InitializeForm();
            SetAirship((Airship)transport);
            if (readMode == true)
            {
                SetReadOnly();
            }
        }
        public void SetShell(Shell shell)
        {
            switch (shell)
            {
                case Shell.none: ComboBShell.SelectedIndex = 0; break;
                case Shell.soft: ComboBShell.SelectedIndex = 1; break;
                case Shell.semirigid: ComboBShell.SelectedIndex = 2; break;
                case Shell.hard: ComboBShell.SelectedIndex = 3; break;
            }

        }
        public Shell GetShell()
        {
            switch (ComboBShell.SelectedIndex)
            {
                case 0: return Shell.none;
                case 1: return Shell.soft;
                case 2: return Shell.semirigid;
                case 3: return Shell.hard;
            }
            return Shell.soft;
        }
        public void SetNumScrews(int numScrews)
        {
            if (numScrews != 0)
                TextBScrews.Text = Convert.ToString(numScrews);
            else
                TextBScrews.Text = "";
        }
        public int GetNumScrews()
        {
            if (TextBScrews.Text.Length != 0)
                return Convert.ToInt32(TextBScrews.Text);
            else
                return 0;
        }
        private void EditAirship(Airship airship)
        {
            airship.Name = GetName();
            airship.Purpose = GetPorp();
            airship.NumScrews = GetNumScrews();
            airship.Weight = GetWeight();
            airship.MaxHeight = GetMaxHeight();
            airship.TakeoffWeight = GetTakeoffWeight();
            airship.Shell = GetShell();
        }
        public void SetAirship(Airship airship)
        {
            receivedAirship = airship;
            SetName(airship.Name);
            SetPorp(airship.Purpose);
            SetNumScrews(airship.NumScrews);
            SetWeight(airship.Weight);
            SetMaxHeight(airship.MaxHeight);
            SetTakeoffWeight(airship.TakeoffWeight);
            SetShell(airship.Shell);
        }

        private void FAirship_Load(object sender, EventArgs e)
        {

        }

        private void TextBScrews_KeyPress(object sender, KeyPressEventArgs e)
        {
            CheckEnterData(sender, e);
        }

        private void ButSave_Click(object sender, EventArgs e)
        {
            if (receivedAirship == null)
            {
                Airship airship = new Airship();
                airship.TypeName = TypeNames.airship;
                EditAirship(airship);
                FMain.AddVehicle(airship);
            }
            else
                EditAirship(receivedAirship);
            Close();
        }
    }
}
