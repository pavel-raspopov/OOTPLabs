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
using System.Reflection;

namespace OOTP
{
    public partial class FMain : Form
    {
        private string[] Plugins;
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
            InitPlugins();
            ComboBSers.SelectedIndex = 0;
            ComboBVehicleType.SelectedIndex = 0;
            lvVehicles.ContextMenuStrip = ContextMStrip;
            if (ComboBArchiving.Items.Count != 0)
                ComboBArchiving.SelectedIndex = 0;
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
        private void InitPlugins()
        {
            Plugins = Directory.GetFiles(Application.StartupPath + "\\Plugins\\");
            foreach (String file in Plugins)
                ComboBArchiving.Items.Add(Path.GetFileNameWithoutExtension(file));
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
        private bool DecompressFile(ref string filePath)
        {
            string extension = Path.GetExtension(filePath);
            foreach (string plugin in Plugins)
            {
                Assembly assembly = Assembly.LoadFile(plugin);
                object obj = assembly.CreateInstance("Compressions");
                var attrs = Attribute.GetCustomAttributes(obj.GetType());
                foreach (var attr in attrs)
                {
                    if (attr.GetType().Name == typeof(ExtensionAttribute).Name)
                        if (Convert.ToString(attr.GetType().GetProperty("Extension").GetValue(attr)) == extension)
                        {
                            MethodInfo method = obj.GetType().GetMethod("Decompress");
                            method.Invoke(obj, new object[] { filePath });
                            filePath = filePath.Substring(0, filePath.Length - extension.Length);
                            return true;
                        }
                }
            }
            return false;
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

            DialogResult choice = MessageBox.Show("Заархивировать файл?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (choice == DialogResult.Yes)
            {
                if (ComboBArchiving.SelectedIndex == -1)
                {
                    MessageBox.Show("Не загружены файлы для архивации.");
                    return;
                }
                Assembly assembly = Assembly.LoadFile(Plugins[ComboBArchiving.SelectedIndex]);
                object obj = assembly.CreateInstance("Compressions");
                Type type = obj.GetType();
                MethodInfo method = type.GetMethod("Compress");
                method.Invoke(obj, new object[] { filePath });
                File.Delete(filePath);
            }
        }

        private void ButLoad_Click(object sender, EventArgs e)
        {
            object[] loadVehicle;
            bool IsDecompressed = false;
            if (OpenFD.ShowDialog() == DialogResult.Cancel)
                return;
            string filePath = OpenFD.FileName;

            try
            {
                if (GetSer(filePath) == null)
                    if (DecompressFile(ref filePath) == false)
                    {
                        MessageBox.Show("Не загружен файл для разархивации.");
                        return;
                    }
                    else
                        IsDecompressed = true;

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

                if (IsDecompressed)
                {
                    File.Delete(filePath);
                    IsDecompressed = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
