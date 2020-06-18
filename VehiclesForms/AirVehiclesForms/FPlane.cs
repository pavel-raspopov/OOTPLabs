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
    public partial class FPlane : FAirVehicle
    {
        private Plane receivedPlane = null;
        public FPlane()
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
            ComboBAircraftType.SelectedIndex = 0;
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
                case AircraftType.none: ComboBAircraftType.SelectedIndex = 0; break;
                case AircraftType.passenger: ComboBAircraftType.SelectedIndex = 1; break;
                case AircraftType.transport: ComboBAircraftType.SelectedIndex = 2; break;
                case AircraftType.military: ComboBAircraftType.SelectedIndex = 3; break;
            }

        }
        public AircraftType GetAircraftType()
        {
            switch (ComboBAircraftType.SelectedIndex)
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
                TextBTurbines.Text = Convert.ToString(numTurbines);
            else
                TextBTurbines.Text = "";
        }
        public int GetNumTurbines()
        {
            if (TextBTurbines.Text.Length != 0)
                return Convert.ToInt32(TextBTurbines.Text);
            else
                return 0;
        }
        private void EditPlane(Plane plane)
        {
            plane.Name = GetName();
            plane.Purpose = GetPorp();
            plane.NumTurbines = GetNumTurbines();
            plane.Weight = GetWeight();
            plane.MaxHeight = GetMaxHeight();
            plane.TakeoffWeight = GetTakeoffWeight();
            plane.Type = GetAircraftType();
        }
        public void SetPlane(Plane plane)
        {
            receivedPlane = plane;
            SetName(plane.Name);
            SetPorp(plane.Purpose);
            SetNumTurbines(plane.NumTurbines);
            SetWeight(plane.Weight);
            SetMaxHeight(plane.MaxHeight);
            SetTakeoffWeight(plane.TakeoffWeight);
            SetType(plane.Type);
        }

        private void FPlane_Load(object sender, EventArgs e)
        {

        }

        private void ButSave_Click(object sender, EventArgs e)
        {

            if (receivedPlane == null)
            {
                Plane plane = new Plane();
                plane.TypeName = TypeNames.plane;
                EditPlane(plane);
                FMain.AddVehicle(plane);
            }
            else
                EditPlane(receivedPlane);
            Close();
        }
    }
}
