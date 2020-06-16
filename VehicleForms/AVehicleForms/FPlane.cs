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
    [WorkingTypes((new Type[] { typeof(Plane) }))]
    public partial class FPlane : FAirVehicle
    {
        private Plane receivedPlane = null;
        public FPlane()
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
            ComboBType.SelectedIndex = 0;
        }
        public FPlane(object transport, bool readMode)
        {
            InitializeForm();
            SetPlane((Plane)transport);
            if (readMode == true)
            {
                SetReadOnly();
            }
        }
        public void SetType(AircraftType type)
        {
            switch (type)
            {
                case AircraftType.none: ComboBType.SelectedIndex = 0; break;
                case AircraftType.passenger: ComboBType.SelectedIndex = 1; break;
                case AircraftType.transport: ComboBType.SelectedIndex = 2; break;
                case AircraftType.military: ComboBType.SelectedIndex = 3; break;
            }

        }
        public AircraftType GetAircraftType()
        {
            switch (ComboBType.SelectedIndex)
            {
                case 0: return AircraftType.none;
                case 1: return AircraftType.passenger;
                case 2: return AircraftType.transport;
                case 3: return AircraftType.military;
            }
            return AircraftType.passenger;
        }
        public void SetNumTurbines(int numTurbines)
        {
            if (numTurbines != 0)
                TextBNumTurbines.Text = Convert.ToString(numTurbines);
            else
                TextBNumTurbines.Text = "";
        }
        public int GetNumTurbines()
        {
            if (TextBNumTurbines.Text.Length != 0)
                return Convert.ToInt32(TextBNumTurbines.Text);
            else
                return 0;
        }
        private void EditPlane(Plane plane)
        {
            plane.Name = GetName();
            plane.MaxSpeed = GetMaxSpeed();
            plane.NumTurbines = GetNumTurbines();
            plane.Weight = GetWeight();
            plane.Year = GetYear();
            plane.MaxHeight = GetMaxHeight();
            plane.TakeoffWeight = GetTakeoffWeight();
            plane.Type = GetAircraftType();
        }
        public void SetPlane(Plane plane)
        {
            receivedPlane = plane;
            SetName(plane.Name);
            SetMaxSpeed(plane.MaxSpeed);
            SetNumTurbines(plane.NumTurbines);
            SetWeight(plane.Weight);
            SetYear(plane.Year);
            SetMaxHeight(plane.MaxHeight);
            SetTakeoffWeight(plane.TakeoffWeight);
            SetType(plane.Type);
        }

        private void FPlane_Load(object sender, EventArgs e)
        {

        }

        private void TextBNumTurbines_KeyPress(object sender, KeyPressEventArgs e)
        {
            CheckEnterData(sender, e);
        }

        private void ButSave_Click(object sender, EventArgs e)
        {
            if (receivedPlane == null)
            {
                Plane plane = new Plane();
                EditPlane(plane);
                FMain.AddVehicle(plane);
            }
            else
                EditPlane(receivedPlane);
            Close();
        }
    }
}
