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
    [WorkingTypesForm((new Type[] { typeof(Auto) }))]
    public partial class FAuto : FLandVehicle
    {
        private Auto receivedAuto = null;
        public FAuto()
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

        public FAuto(object transport, bool readMode)
        {
            InitializeForm();
            SetAuto((Auto)transport);
            if (readMode == true)
            {
                SetReadOnly();
                FEngine.ReadOnly = true;
            }
        }

        private void InitializeForm()
        {
            InitializeComponent();
            ComboBTypeBody.SelectedIndex = 0;
            ComboBDriveUnit.SelectedIndex = 0;
        }
        public Body GetBody()
        {
            switch (ComboBTypeBody.SelectedIndex)
            {
                case 0: return Body.none;
                case 1: return Body.sedan;
                case 2: return Body.hatchback;
                case 3: return Body.truck;
                case 4: return Body.coupe;
                case 5: return Body.supercar;
                case 6: return Body.suv;
                case 7: return Body.cuv;
                case 8: return Body.cabriolet;
                case 9: return Body.roadster;
                case 10: return Body.pickup;
                case 11: return Body.van;
            }
            return Body.sedan;
        }

        public void SetBody(Body body)
        {
            switch (body)
            {
                case Body.none: ComboBTypeBody.SelectedIndex = 0; break;
                case Body.sedan: ComboBTypeBody.SelectedIndex = 1; break;
                case Body.hatchback: ComboBTypeBody.SelectedIndex = 2; break;
                case Body.truck: ComboBTypeBody.SelectedIndex = 3; break;
                case Body.coupe: ComboBTypeBody.SelectedIndex = 4; break;
                case Body.supercar: ComboBTypeBody.SelectedIndex = 5; break;
                case Body.suv: ComboBTypeBody.SelectedIndex = 6; break;
                case Body.cuv: ComboBTypeBody.SelectedIndex = 7; break;
                case Body.cabriolet: ComboBTypeBody.SelectedIndex = 8; break;
                case Body.roadster: ComboBTypeBody.SelectedIndex = 9; break;
                case Body.pickup: ComboBTypeBody.SelectedIndex = 10; break;
                case Body.van: ComboBTypeBody.SelectedIndex = 11; break;
            }
        }
        public void SetDriveUnit(DriveUnit driveUnit)
        {
            switch (driveUnit)
            {
                case DriveUnit.none: ComboBDriveUnit.SelectedIndex = 0; break;
                case DriveUnit.front: ComboBDriveUnit.SelectedIndex = 1; break;
                case DriveUnit.rear: ComboBDriveUnit.SelectedIndex = 2; break;
                case DriveUnit.full: ComboBDriveUnit.SelectedIndex = 3; break;
            }

        }
        public DriveUnit GetDriveUnit()
        {
            switch (ComboBDriveUnit.SelectedIndex)
            {
                case 0: return DriveUnit.none;
                case 1: return DriveUnit.front;
                case 2: return DriveUnit.rear;
                case 3: return DriveUnit.full;
            }
            return DriveUnit.front;
        }
        public void SetNumDoors(int numDoors)
        {
            if (numDoors != 0)
                TextBNumDoors.Text = Convert.ToString(numDoors);
            else
                TextBNumDoors.Text = "";
        }
        public int GetNumDoors()
        {
            if (TextBNumDoors.Text.Length != 0)
                return Convert.ToInt32(TextBNumDoors.Text);
            else
                return 0;
        }
        private void EditAuto(Auto auto)
        {
            auto.Name = GetName();
            auto.MaxSpeed = GetMaxSpeed();
            auto.NumDoors = GetNumDoors();
            auto.Weight = GetWeight();
            auto.Year = GetYear();
            auto.NumOfWheels = GetNumOfWheels();
            auto.Body = GetBody();
            auto.DriveUnit = GetDriveUnit();
            Engine engine = new Engine(GetPower(), GetVolume(), GetTypeFuel());
            auto.EngineParams = engine;
        }

        public void SetAuto(Auto auto)
        {
            receivedAuto = auto;
            SetName(auto.Name);
            SetMaxSpeed(auto.MaxSpeed);
            SetNumDoors(auto.NumDoors);
            SetWeight(auto.Weight);
            SetYear(auto.Year);
            SetNumOfWheels(auto.NumOfWheels);
            SetBody(auto.Body);
            SetDriveUnit(auto.DriveUnit);
            SetPower(auto.EngineParams.Power);
            SetVolume(auto.EngineParams.Volume);
            SetTypeFuel(auto.EngineParams.TypeFuel);
        }

        private void FAuto_Load(object sender, EventArgs e)
        {

        }

        private void TextBNumDoors_KeyPress(object sender, KeyPressEventArgs e)
        {
            CheckEnterData(sender, e);
        }

        private void ButSave_Click(object sender, EventArgs e)
        {
            if (receivedAuto == null)
            {
                Auto auto = new Auto();
                EditAuto(auto);
                FMenu.AddTransport(auto);
            }
            else
                EditAuto(receivedAuto);
            Close();
        }
    }
}
