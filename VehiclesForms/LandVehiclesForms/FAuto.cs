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
    public partial class FAuto : FLandVehicle
    {
        private Auto receivedAuto = null;
        public FAuto()
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
        public FAuto(object transport)
        {
            InitializeForm();
            SetAuto((Auto)transport);
        }
        public FAuto(object transport, string readOnly)
        {
            InitializeForm();
            SetAuto((Auto)transport);
            if (readOnly == "readonly")
            {
                SetReadOnly();
            }
        }

        private void InitializeForm()
        {
            InitializeComponent();
            ComboBBody.SelectedIndex = 0;
        }
        public void SetNumSeats(int numSeats)
        {
            if (numSeats != 0)
                TextBSeats.Text = Convert.ToString(numSeats);
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
        public Body GetBody()
        {
            switch (ComboBBody.SelectedIndex)
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
                case Body.none: ComboBBody.SelectedIndex = 0; break;
                case Body.sedan: ComboBBody.SelectedIndex = 1; break;
                case Body.hatchback: ComboBBody.SelectedIndex = 2; break;
                case Body.truck: ComboBBody.SelectedIndex = 3; break;
                case Body.coupe: ComboBBody.SelectedIndex = 4; break;
                case Body.supercar: ComboBBody.SelectedIndex = 5; break;
                case Body.suv: ComboBBody.SelectedIndex = 6; break;
                case Body.cuv: ComboBBody.SelectedIndex = 7; break;
                case Body.cabriolet: ComboBBody.SelectedIndex = 8; break;
                case Body.roadster: ComboBBody.SelectedIndex = 9; break;
                case Body.pickup: ComboBBody.SelectedIndex = 10; break;
                case Body.van: ComboBBody.SelectedIndex = 11; break;
            }
        }
        private void EditAuto(Auto auto)
        {
            auto.Name = GetName();
            auto.Purpose = GetPorp();
            auto.PassengerSeats = GetNumSeats();
            auto.Weight = GetWeight();
            auto.Wheels = GetWheels();
            auto.Body = GetBody();
            Engine engine = new Engine(GetExp(), GetPower(), GetEffic(), GetEngineType());
            auto.EngineData = engine;
        }

        public void SetAuto(Auto auto)
        {
            receivedAuto = auto;
            SetName(auto.Name);
            SetPorp(auto.Purpose);
            SetNumSeats(auto.PassengerSeats);
            SetWeight(auto.Weight);
            SetWheels(auto.Wheels);
            SetBody(auto.Body);
            SetExp(auto.EngineData.Expenditure);
            SetPower(auto.EngineData.Power);
            SetEffic(auto.EngineData.Efficiency);
            SetEngineType(auto.EngineData.Type);
        }

        private void FAuto_Load(object sender, EventArgs e)
        {

        }

        private void TextBSeats_KeyPress(object sender, KeyPressEventArgs e)
        {
            CheckEnterData(sender, e);
        }

        private void ButSave_Click(object sender, EventArgs e)
        {

            if (receivedAuto == null)
            {
                Auto auto = new Auto();
                auto.TypeName = TypeNames.auto;
                EditAuto(auto);
                FMain.AddVehicle(auto);
            }
            else
                EditAuto(receivedAuto);
            Close();
        }
    }
}
