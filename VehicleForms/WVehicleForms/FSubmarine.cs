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
    [WorkingTypes((new Type[] { typeof(Submarine) }))]
    public partial class FSubmarine : FWaterVehicle
    {
        private readonly Submarine receivedSubmarine = null;
        public FSubmarine()
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
        public FSubmarine(object transport, bool readMode)
        {
            InitializeComponent();
            if (readMode == true)
                SetReadOnly();
            receivedSubmarine = (Submarine)transport;
            SetSubmarine();
        }
        public void SetMaxDepth(int tmpFirst)
        {
            if (tmpFirst != 0)
                TextBMaxDepth.Text = Convert.ToString(tmpFirst);
            else
                TextBMaxDepth.Text = "";
        }
        public int GetMaxDepth()
        {
            if (TextBMaxDepth.Text.Length != 0)
                return Convert.ToInt32(TextBMaxDepth.Text);
            else
                return 0;
        }
        public void SetNumTurbines(int tmpSecond)
        {
            if (tmpSecond != 0)
                TextBNumTurbines.Text = Convert.ToString(tmpSecond);
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
        private void SetSubmarine()
        {
            SetName(receivedSubmarine.Name);
            SetMaxSpeed(receivedSubmarine.MaxSpeed);
            SetWeight(receivedSubmarine.Weight);
            SetYear(receivedSubmarine.Year);
            SetCrew(receivedSubmarine.Crew);
            SetNumOfDecks(receivedSubmarine.NumOfDecks);
            SetDisplacement(receivedSubmarine.Displacement);
            SetMaxDepth(receivedSubmarine.MaxImmersionDepth);
            SetNumTurbines(receivedSubmarine.NumTurbines);
        }
        private void EditSubmarine(Submarine submarine)
        {
            submarine.Name = GetName();
            submarine.MaxSpeed = GetMaxSpeed();
            submarine.Weight = GetWeight();
            submarine.Year = GetYear();
            submarine.Crew = GetCrew();
            submarine.NumOfDecks = GetNumOfDecks();
            submarine.Displacement = GetDisplacement();
            submarine.MaxImmersionDepth = GetMaxDepth();
            submarine.NumTurbines = GetNumTurbines();
        }

        private void FSubmarine_Load(object sender, EventArgs e)
        {

        }

        private void ButSave_Click(object sender, EventArgs e)
        {
            if (receivedSubmarine == null)
            {
                Submarine submarine = new Submarine();
                EditSubmarine(submarine);
                FMain.AddVehicle(submarine);
            }
            else
                EditSubmarine(receivedSubmarine);
            Close();
        }

        private void TextBMaxDepth_KeyPress(object sender, KeyPressEventArgs e)
        {
            CheckEnterData(sender, e);
        }

        private void TextBNumTurbines_KeyPress(object sender, KeyPressEventArgs e)
        {
            CheckEnterData(sender, e);
        }
    }
}
