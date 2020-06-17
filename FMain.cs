using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OOTP.Attributes;
using OOTP.Vehicles;
using OOTP.Vehicles.LVehicle;
using OOTP.Vehicles.WVehicle;
using OOTP.Vehicles.AVehicle;
using OOTP.VehicleForms.LVehicleForms;
using OOTP.VehicleForms.WVehicleForms;
using OOTP.VehicleForms.AVehicleForms;
using OOTP.Serializers;

namespace OOTP
{
    public partial class FMain : Form
    {
        private readonly List<Form> Forms = new List<Form>();
        private readonly List<Type> VehicleTypes = new List<Type>();
        private readonly List<Type> Sers = new List<Type>();
        private static readonly List<object> Vehicles = new List<object>();
        public FMain()
        {
            InitializeComponent();
            InitForms();
            InitVehicleTypes();
            InitSers();
            ComboBSers.SelectedIndex = 0;
            ComboBVehicleType.SelectedIndex = 0;
            lvVehicles.ContextMenuStrip = ContextMStrip;
        }
        private void InitForms()
        {
            Forms.Add(new FAirship());
            Forms.Add(new FPlane());
            Forms.Add(new FAuto());
            Forms.Add(new FMotobike());
            Forms.Add(new FSubmarine());
            Forms.Add(new FSailboat());
        }
        private void InitVehicleTypes()
        {
            VehicleTypes.Add(typeof(Airship));
            VehicleTypes.Add(typeof(Plane));
            VehicleTypes.Add(typeof(Auto));
            VehicleTypes.Add(typeof(Motobike));
            VehicleTypes.Add(typeof(Submarine));
            VehicleTypes.Add(typeof(Sailboat));
        }
        private void InitSers()
        {
            Sers.Add(typeof(BinarySer));
            Sers.Add(typeof(JSONSer));
            Sers.Add(typeof(TextSer));
        }
        public static void AddVehicle(object vehicle)
        {
            Vehicles.Add(vehicle);
        }
        private void CreateAddingForm(Type vehicleType)
        {
            Form form = null;
            foreach (Form tempForm in Forms)
            {
                Type type = tempForm.GetType();
                if (Attribute.IsDefined(type, typeof(WorkingTypesAttribute)))
                {
                    var attr = Attribute.GetCustomAttribute(type, typeof(WorkingTypesAttribute)) as WorkingTypesAttribute;
                    if (attr.CheckWorkersTypes(vehicleType))
                        form = (Form)Activator.CreateInstance(type);
                }
            }
            if (form != null)
                form.ShowDialog();
        }
        private void CreateUpdatingOrReadingForm(Object vehicle, bool readOnly)
        {
            Form form = null;
            foreach (Form tempForm in Forms)
            {
                Type type = tempForm.GetType();
                if (Attribute.IsDefined(type, typeof(WorkingTypesAttribute)))
                {
                    var attr = Attribute.GetCustomAttribute(type, typeof(WorkingTypesAttribute)) as WorkingTypesAttribute;
                    if (attr.CheckWorkersTypes(vehicle.GetType()))
                        form = (Form)Activator.CreateInstance(type, vehicle, readOnly);
                }
            }
            if (form != null)
                form.ShowDialog();
        }
        private void UpdateVehicles()
        {
            lvVehicles.Items.Clear();
            foreach (Vehicle vehicle in Vehicles)
            {
                Type type = vehicle.GetType();
                if (Attribute.IsDefined(type, typeof(VehicleTypeAttribute)))
                {
                    var attrVal = Attribute.GetCustomAttribute(type, typeof(VehicleTypeAttribute)) as VehicleTypeAttribute;
                    lvVehicles.Items.Add(attrVal.TypeName);
                }
                else
                    lvVehicles.Items.Add("");
                lvVehicles.Items[lvVehicles.Items.Count - 1].SubItems.Add(vehicle.Name);
            }
        }
        private ISer GetSer(string filepath)
        {
            ISer ser = null;
            bool flag = false;
            foreach (Type serType in Sers)
            {
                ser = (ISer)Activator.CreateInstance(serType);
                if ((ser.FileExtension).IndexOf(Path.GetExtension(filepath)) != -1)
                {
                    flag = true;
                    break;
                }
            }
            if (flag)
                return ser;
            else
                return null;
        }
        private void FMain_Load(object sender, EventArgs e)
        {

        }
        private void ReadToolStripMI_Click(object sender, EventArgs e)
        {
            if (lvVehicles.SelectedItems.Count == 1)
            {
                ListView.SelectedIndexCollection indexs = lvVehicles.SelectedIndices;
                CreateUpdatingOrReadingForm(Vehicles[indexs[0]], true);
            }
        }
        private void UpdateToolStripMI_Click(object sender, EventArgs e)
        {
            if (lvVehicles.SelectedItems.Count == 1)
            {
                ListView.SelectedIndexCollection indexs = lvVehicles.SelectedIndices;
                CreateUpdatingOrReadingForm(Vehicles[indexs[0]], false);
                UpdateVehicles();
            }
        }
        private void DeleteToolStripMI_Click(object sender, EventArgs e)
        {
            if (lvVehicles.SelectedItems.Count == 1)
            {
                ListView.SelectedIndexCollection indexs = lvVehicles.SelectedIndices;
                Vehicles.RemoveAt(indexs[0]);
                UpdateVehicles();
            }
        }
        private void ButAdd_Click(object sender, EventArgs e)
        {
            CreateAddingForm(VehicleTypes[ComboBVehicleType.SelectedIndex]);
            UpdateVehicles();
        }

        private void ButSave_Click(object sender, EventArgs e)
        {
            if (lvVehicles.SelectedItems.Count == 0)
                return;
            object[] vehicle = new object[lvVehicles.SelectedItems.Count];
            ListView.SelectedIndexCollection indexs = lvVehicles.SelectedIndices;
            int i = 0;
            foreach (int index in indexs)
            {
                vehicle[i] = Vehicles[index];
                i++;
            }
            ISer ser = (ISer)Activator.CreateInstance(Sers[ComboBSers.SelectedIndex]);
            SaveFD.Filter = ser.FileExtension;
            if (SaveFD.ShowDialog() == DialogResult.Cancel)
                return;
            string filePath = SaveFD.FileName;
            ser.Serialize(vehicle, filePath);
        }

        private void ButLoad_Click(object sender, EventArgs e)
        {
            object[] loadVehicle;
            if (OpenFD.ShowDialog() == DialogResult.Cancel)
                return;
            string filePath = OpenFD.FileName;

            try
            {
                ISer ser = GetSer(filePath);
                if (ser == null)
                {
                    MessageBox.Show("Десериализация не удалась!");
                    return;
                }

                loadVehicle = ser.Deserialize(filePath);
                foreach (Vehicle vehicle in loadVehicle)
                    Vehicles.Add(vehicle);
                UpdateVehicles();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
