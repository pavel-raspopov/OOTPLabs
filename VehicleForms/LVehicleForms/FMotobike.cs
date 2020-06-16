using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OOTP.Vehicles.LVehicle;
using OOTP.VehiclesElement;
using OOTP.Attributes;

namespace OOTP.VehicleForms.LVehicleForms
{
    [WorkingTypes((new Type[] { typeof(Motobike) }))]
    public partial class FMotobike : FLandVehicle
    {
        private Motobike receivedMotobike = null;
        public FMotobike()
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
            foreach (var RadioButton in Controls.OfType<RadioButton>())
            {
                RadioButton.Enabled = false;
            }

            ButSave.Hide();
        }
        public FMotobike(object transport, bool readMode)
        {
            InitializeForm();
            SetMotobike((Motobike)transport);
            if (readMode == true)
            {
                SetReadOnly();
                FEngine.ReadOnly = true;
            }
        }
        private void InitializeForm()
        {
            InitializeComponent();
            RButSideCarNo.Checked = true;
        }
        public void SetSideCar(SideCar sideCar)
        {
            switch (sideCar)
            {
                case SideCar.yes: RButSideCarYes.Checked = true; break;
                case SideCar.no: RButSideCarNo.Checked = true; break;
            }
        }

        public SideCar GetSideCar()
        {
            if (RButSideCarYes.Checked == true)
                return SideCar.yes;
            else
                return SideCar.no;
        }
        private void EditMotobike(Motobike motobike)
        {
            motobike.Name = GetName();
            motobike.MaxSpeed = GetMaxSpeed();
            motobike.Weight = GetWeight();
            motobike.Year = GetYear();
            motobike.NumOfWheels = GetNumOfWheels();
            motobike.SideCar = GetSideCar();
            Engine engine = new Engine(GetPower(), GetVolume(), GetTypeFuel());
            motobike.EngineParams = engine;
        }

        public void SetMotobike(Motobike motobike)
        {
            receivedMotobike = motobike;
            SetName(motobike.Name);
            SetMaxSpeed(motobike.MaxSpeed);
            SetWeight(motobike.Weight);
            SetYear(motobike.Year);
            SetNumOfWheels(motobike.NumOfWheels);
            SetSideCar(motobike.SideCar);
            SetPower(motobike.EngineParams.Power);
            SetVolume(motobike.EngineParams.Volume);
            SetTypeFuel(motobike.EngineParams.TypeFuel);
        }

        private void FMotobike_Load(object sender, EventArgs e)
        {

        }

        private void ButSave_Click(object sender, EventArgs e)
        {
            if (receivedMotobike == null)
            {
                Motobike motobike = new Motobike();
                EditMotobike(motobike);
                FMain.AddVehicle(motobike);
            }
            else
                EditMotobike(receivedMotobike);
            Close();
        }
    }
}
