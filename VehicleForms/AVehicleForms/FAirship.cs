using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OOTP.Vehicles.AVehicle;
using OOTP.Attributes;

namespace OOTP.VehicleForms.AVehicleForms
{
    [WorkingTypes((new Type[] { typeof(Airship) }))]
    public partial class FAirship : FAirVehicle
    {
        private Airship receivedAirship = null;
        public FAirship()
        {
            InitializeForm();
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
                TextBNumScrews.Text = Convert.ToString(numScrews);
            else
                TextBNumScrews.Text = "";
        }
        public int GetNumScrews()
        {
            if (TextBNumScrews.Text.Length != 0)
                return Convert.ToInt32(TextBNumScrews.Text);
            else
                return 0;
        }
        private void EditAirship(Airship airship)
        {
            airship.Name = GetName();
            airship.MaxSpeed = GetMaxSpeed();
            airship.NumScrews = GetNumScrews();
            airship.Weight = GetWeight();
            airship.Year = GetYear();
            airship.MaxHeight = GetMaxHeight();
            airship.TakeoffWeight = GetTakeoffWeight();
            airship.Shell = GetShell();
        }
        public void SetAirship(Airship airship)
        {
            receivedAirship = airship;
            SetName(airship.Name);
            SetMaxSpeed(airship.MaxSpeed);
            SetNumScrews(airship.NumScrews);
            SetWeight(airship.Weight);
            SetYear(airship.Year);
            SetMaxHeight(airship.MaxHeight);
            SetTakeoffWeight(airship.TakeoffWeight);
            SetShell(airship.Shell);
        }

        private void FAirship_Load(object sender, EventArgs e)
        {

        }

        private void TextBNumScrews_KeyPress(object sender, KeyPressEventArgs e)
        {
            CheckEnterData(sender, e);
        }

        private void ButSave_Click(object sender, EventArgs e)
        {
            if (receivedAirship == null)
            {
                Airship airship = new Airship();
                EditAirship(airship);
                FMenu.AddTransport(airship);
            }
            else
                EditAirship(receivedAirship);
            Close();
        }
    }
}
