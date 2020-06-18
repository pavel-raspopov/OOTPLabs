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
    public partial class FYacht : FWaterVehicle
    {
        private Yacht receivedYacht = null;
        public FYacht()
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
            ComboBYachtType.SelectedIndex = 0;
            ComboBDrive.SelectedIndex = 0;
        }
        public FYacht(object transport, bool readMode)
        {
            InitializeForm();
            SetYacht((Yacht)transport);
            if (readMode == true)
            {
                SetReadOnly();
            }
        }
        public void SetYachtType(YachtType type)
        {
            switch (type)
            {
                case YachtType.none: ComboBYachtType.SelectedIndex = 0; break;
                case YachtType.cruise: ComboBYachtType.SelectedIndex = 1; break;
                case YachtType.sport: ComboBYachtType.SelectedIndex = 2; break;
            }
        }
        public YachtType GetYachtType()
        {
            switch (ComboBYachtType.SelectedIndex)
            {
                case 0: return YachtType.none;
                case 1: return YachtType.cruise;
                case 2: return YachtType.sport;
            }
            return YachtType.cruise;
        }
        public void SetDrive(DriveUnit type)
        {
            switch (type)
            {
                case DriveUnit.none: ComboBYachtType.SelectedIndex = 0; break;
                case DriveUnit.sail: ComboBYachtType.SelectedIndex = 1; break;
                case DriveUnit.sailmotor: ComboBYachtType.SelectedIndex = 2; break;
                case DriveUnit.motor: ComboBYachtType.SelectedIndex = 3; break;
            }
        }
        public DriveUnit GetDrive()
        {
            switch (ComboBYachtType.SelectedIndex)
            {
                case 0: return DriveUnit.none;
                case 1: return DriveUnit.sail;
                case 2: return DriveUnit.sailmotor;
                case 3: return DriveUnit.motor;
            }
            return DriveUnit.sailmotor;
        }
        private void EditYacht(Yacht yacht)
        {
            yacht.Name = GetName();
            yacht.Purpose = GetPorp();
            yacht.Type = GetYachtType();
            yacht.Weight = GetWeight();
            yacht.Waterline = GetWLine();
            yacht.Сonsumption = GetCons();
            yacht.Drive = GetDrive();
        }
        public void SetYacht(Yacht yacht)
        {
            receivedYacht = yacht;
            SetName(yacht.Name);
            SetPorp(yacht.Purpose);
            SetYachtType(yacht.Type);
            SetWeight(yacht.Weight);
            SetWLine(yacht.Waterline);
            SetCons(yacht.Сonsumption);
            SetDrive(yacht.Drive);
        }

        private void FYacht_Load(object sender, EventArgs e)
        {

        }

        private void ButSave_Click(object sender, EventArgs e)
        {
            if (receivedYacht == null)
            {
                Yacht yacht = new Yacht();
                yacht.TypeName = TypeNames.yacht;
                EditYacht(yacht);
                FMain.AddVehicle(yacht);
            }
            else
                EditYacht(receivedYacht);
            Close();
        }
    }
}
