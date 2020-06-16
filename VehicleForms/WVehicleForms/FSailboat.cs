using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OOTP.Vehicles.WVehicle;
using OOTP.Attributes;

namespace OOTP.VehicleForms.WVehicleForms
{
    [WorkingTypes((new Type[] { typeof(Sailboat) }))]
    public partial class FSailboat : FWaterVehicle
    {
        private readonly Sailboat receivedSailboat = null;
        public FSailboat()
        {
            InitializeComponent();
        }
        public void SetReadOnly()
        {
            foreach (var TextBox in Controls.OfType<TextBox>())
            {
                TextBox.ReadOnly = true;
            }
            ButSave.Hide();
        }
        public FSailboat(object transport, bool readMode)
        {
            InitializeComponent();
            if (readMode == true)
                SetReadOnly();
            receivedSailboat = (Sailboat)transport;
            SetSailboat();
        }
        public void SetNumSails(int tmpFirst)
        {
            if (tmpFirst != 0)
                TextBNumSails.Text = Convert.ToString(tmpFirst);
            else
                TextBNumSails.Text = "";
        }
        public int GetNumSails()
        {
            if (TextBNumSails.Text.Length != 0)
                return Convert.ToInt32(TextBNumSails.Text);
            else
                return 0;
        }
        public void SetNumMasts(int tmpSecond)
        {
            if (tmpSecond != 0)
                TextBNumMasts.Text = Convert.ToString(tmpSecond);
            else
                TextBNumMasts.Text = "";
        }
        public int GetNumMasts()
        {
            if (TextBNumMasts.Text.Length != 0)
                return Convert.ToInt32(TextBNumMasts.Text);
            else
                return 0;
        }
        private void SetSailboat()
        {
            SetName(receivedSailboat.Name);
            SetMaxSpeed(receivedSailboat.MaxSpeed);
            SetWeight(receivedSailboat.Weight);
            SetYear(receivedSailboat.Year);
            SetCrew(receivedSailboat.Crew);
            SetNumOfDecks(receivedSailboat.NumOfDecks);
            SetDisplacement(receivedSailboat.Displacement);
            SetNumSails(receivedSailboat.NumSails);
            SetNumMasts(receivedSailboat.NumMasts);
        }

        private void EditSailboat(Sailboat sailboat)
        {
            sailboat.Name = GetName();
            sailboat.MaxSpeed = GetMaxSpeed();
            sailboat.Weight = GetWeight();
            sailboat.Year = GetYear();
            sailboat.Crew = GetCrew();
            sailboat.NumOfDecks = GetNumOfDecks();
            sailboat.Displacement = GetDisplacement();
            sailboat.NumSails = GetNumSails();
            sailboat.NumMasts = GetNumMasts();
        }

        private void FSailboat_Load(object sender, EventArgs e)
        {

        }

        private void ButSave_Click(object sender, EventArgs e)
        {
            if (receivedSailboat == null)
            {
                Sailboat sailboat = new Sailboat();
                EditSailboat(sailboat);
                FMenu.AddTransport(sailboat);
            }
            else
                EditSailboat((Sailboat)receivedSailboat);

            Close();
        }

        private void TextBNumSails_KeyPress(object sender, KeyPressEventArgs e)
        {
            CheckEnterData(sender, e);
        }

        private void TextBNumMasts_KeyPress(object sender, KeyPressEventArgs e)
        {
            CheckEnterData(sender, e);
        }
    }
}
