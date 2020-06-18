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
using OOTP.Vehicles.LandVehicles;
using OOTP.EngineClass;

namespace OOTP.VehiclesForms.LandVehiclesForms
{
    public partial class FTruck : FLandVehicle
    {
        private Truck receivedTruck = null;
        public FTruck()
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
            foreach (var RadioButton in Controls.OfType<Panel>())
            {
                RadioButton.Enabled = false;
            }

            ButSave.Hide();
        }
        public FTruck(object transport)
        {
            InitializeForm();
            SetTruck((Truck)transport);
        }
        public FTruck(object transport, string readOnly)
        {
            InitializeForm();
            SetTruck((Truck)transport);
            if (readOnly == "readonly")
            {
                SetReadOnly();
            }
        }
        private void InitializeForm()
        {
            InitializeComponent();
            RBHeavy_No.Checked = true;
            RBOver_No.Checked = true;
        }
        public void SetHeavyLoad(HeavyLoad load)
        {
            switch (load)
            {
                case HeavyLoad.yes: RBHeavy_Yes.Checked = true; break;
                case HeavyLoad.no: RBHeavy_No.Checked = true; break;
            }
        }

        public HeavyLoad GetHeavyLoad()
        {
            if (RBHeavy_Yes.Checked == true)
                return HeavyLoad.yes;
            else
                return HeavyLoad.no;
        }
        public void SetOversizedLoad(OversizedLoad load)
        {
            switch (load)
            {
                case OversizedLoad.yes: RBOver_Yes.Checked = true; break;
                case OversizedLoad.no: RBOver_No.Checked = true; break;
            }
        }
        public OversizedLoad GetOversizedLoad()
        {
            if (RBOver_Yes.Checked == true)
                return OversizedLoad.yes;
            else
                return OversizedLoad.no;
        }
        private void EditTruck(Truck truck)
        {
            truck.Name = GetName();
            truck.Purpose = GetPorp();
            truck.Weight = GetWeight();
            truck.Wheels = GetWheels();
            truck.HeavyLoad = GetHeavyLoad();
            truck.OversizedLoad = GetOversizedLoad();
            Engine engine = new Engine(GetExp(), GetPower(), GetEffic(), GetEngineType());
            truck.EngineData = engine;
        }
        public void SetTruck(Truck truck)
        {
            receivedTruck = truck;
            SetName(truck.Name);
            SetPorp(truck.Purpose);
            SetWeight(truck.Weight);
            SetWheels(truck.Wheels);
            SetHeavyLoad(truck.HeavyLoad);
            SetOversizedLoad(truck.OversizedLoad);
            SetExp(truck.EngineData.Expenditure);
            SetPower(truck.EngineData.Power);
            SetEffic(truck.EngineData.Efficiency);
            SetEngineType(truck.EngineData.Type);
        }

        private void FTruck_Load(object sender, EventArgs e)
        {

        }

        private void ButSave_Click(object sender, EventArgs e)
        {
            if (receivedTruck == null)
            {
                Truck truck = new Truck();
                truck.TypeName = TypeNames.truck;
                EditTruck(truck);
                FMain.AddVehicle(truck);
            }
            else
                EditTruck(receivedTruck);
            Close();
        }
    }
}
