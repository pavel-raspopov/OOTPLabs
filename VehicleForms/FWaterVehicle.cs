using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOTP.VehicleForms
{
    public partial class FWaterVehicle : FVehicle
    {
        public FWaterVehicle()
        {
            InitializeComponent();
        }
        public void SetNumOfDecks(int numOfDecks)
        {
            if (numOfDecks != 0)
                TextBNumDecks.Text = Convert.ToString(numOfDecks);
            else
                TextBNumDecks.Text = "";
        }
        public int GetNumOfDecks()
        {
            if (TextBNumDecks.Text.Length != 0)
                return Convert.ToInt32(TextBNumDecks.Text);
            else
                return 0;
        }
        public void SetDisplacement(int displacement)
        {
            if (displacement != 0)
                TextBDisplacement.Text = Convert.ToString(displacement);
            else
                TextBDisplacement.Text = "";
        }
        public int GetDisplacement()
        {
            if (TextBDisplacement.Text.Length != 0)
                return Convert.ToInt32(TextBDisplacement.Text);
            else
                return 0;
        }
        public void SetCrew(int crew)
        {
            if (crew != 0)
                TextBCrew.Text = Convert.ToString(crew);
            else
                TextBCrew.Text = "";
        }
        public int GetCrew()
        {
            if (TextBCrew.Text.Length != 0)
                return Convert.ToInt32(TextBCrew.Text);
            else
                return 0;
        }

        private void FWaterVehicle_Load(object sender, EventArgs e)
        {

        }

        private void TextBNumDecks_KeyPress(object sender, KeyPressEventArgs e)
        {
            CheckEnterData(sender, e);
        }

        private void TextBDisplacement_KeyPress(object sender, KeyPressEventArgs e)
        {
            CheckEnterData(sender, e);
        }

        private void TextBCrew_KeyPress(object sender, KeyPressEventArgs e)
        {
            CheckEnterData(sender, e);
        }
    }
}
