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
using OOTP.Vehicles.WaterVehicles;

namespace OOTP.VehiclesForms.WaterVehiclesForms
{
    public partial class FJetski : FWaterVehicle
    {
        private Jetski receivedJetski = null;
        public FJetski()
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
            ComboBJetskiType.SelectedIndex = 0;
        }
        public FJetski(object transport)
        {
            InitializeForm();
            SetJetski((Jetski)transport);
        }
        public FJetski(object transport, string readOnly)
        {
            InitializeForm();
            SetJetski((Jetski)transport);
            if (readOnly == "readonly")
            {
                SetReadOnly();
            }
        }
        public void SetJetskiType(JetskiType type)
        {
            switch (type)
            {
                case JetskiType.none: ComboBJetskiType.SelectedIndex = 0; break;
                case JetskiType.tourist: ComboBJetskiType.SelectedIndex = 1; break;
                case JetskiType.sport: ComboBJetskiType.SelectedIndex = 2; break;
            }
        }
        public JetskiType GetJetskiType()
        {
            switch (ComboBJetskiType.SelectedIndex)
            {
                case 0: return JetskiType.none;
                case 1: return JetskiType.tourist;
                case 2: return JetskiType.sport;
            }
            return JetskiType.tourist;
        }
        public void SetNumSeats(int seats)
        {
            if (seats != 0)
                TextBSeats.Text = Convert.ToString(seats);
            else
                TextBSeats.Text = "";
        }
        public int GetNumSeats()
        {
            if (TextBSeats.Text.Length != 0)
                return Convert.ToInt32(TextBSeats.Text);
            else
                return 0;
        }
        private void EditJetski(Jetski jetski)
        {
            jetski.Name = GetName();
            jetski.Purpose = GetPorp();
            jetski.Seats = GetNumSeats();
            jetski.Weight = GetWeight();
            jetski.Waterline = GetWLine();
            jetski.Сonsumption = GetCons();
            jetski.Type = GetJetskiType();
        }
        public void SetJetski(Jetski jetski)
        {
            receivedJetski = jetski;
            SetName(jetski.Name);
            SetPorp(jetski.Purpose);
            SetNumSeats(jetski.Seats);
            SetWeight(jetski.Weight);
            SetWLine(jetski.Waterline);
            SetCons(jetski.Сonsumption);
            SetJetskiType(jetski.Type);
        }

        private void FJetski_Load(object sender, EventArgs e)
        {

        }

        private void TextBSeats_KeyPress(object sender, KeyPressEventArgs e)
        {
            CheckEnterData(sender, e);
        }

        private void ButSave_Click(object sender, EventArgs e)
        {
            if (receivedJetski == null)
            {
                Jetski jetski = new Jetski();
                jetski.TypeName = TypeNames.jetski;
                EditJetski(jetski);
                FMain.AddVehicle(jetski);
            } 
            else
                EditJetski(receivedJetski);
            Close();
        }
    }
}
