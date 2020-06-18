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
using OOTP.Vehicles.AirVehicles;
using OOTP.Vehicles.LandVehicles;
using OOTP.Vehicles.WaterVehicles;
using OOTP.VehiclesForms.AirVehiclesForms;
using OOTP.VehiclesForms.LandVehiclesForms;
using OOTP.VehiclesForms.WaterVehiclesForms;
using OOTP.Serializers;
using System.Reflection;

namespace OOTP
{
    public partial class FMain : Form
    {
        private string[] Plugins;
        private readonly List<Type> Sers = new List<Type>();
        private static readonly List<object> Vehicles = new List<object>();
        private readonly Dictionary<int, Type> DictForms = new Dictionary<int, Type>();
        private readonly Dictionary<Type, Type> DictVehicleTypes = new Dictionary<Type, Type>();
        public FMain()
        {
            InitializeComponent();
            InitSers();
            InitPlugins();
            InitDictForms();
            InitDictVehicleTypes();
            ComboBSers.SelectedIndex = 0;
            ComboBVehicleType.SelectedIndex = 0;
            lvVehicles.ContextMenuStrip = ContextMStrip;
            if (ComboBArchiving.Items.Count != 0)
                ComboBArchiving.SelectedIndex = 0;
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
        private void InitDictForms()
        {
            DictForms.Add(0, typeof(FAirship));
            DictForms.Add(1, typeof(FPlane));
            DictForms.Add(2, typeof(FAuto));
            DictForms.Add(3, typeof(FTruck));
            DictForms.Add(4, typeof(FJetski));
            DictForms.Add(5, typeof(FYacht));
        }
        private void InitDictVehicleTypes()
        {
            DictVehicleTypes.Add(typeof(Airship), typeof(FAirship));
            DictVehicleTypes.Add(typeof(Plane), typeof(FPlane));
            DictVehicleTypes.Add(typeof(Auto), typeof(FAuto));
            DictVehicleTypes.Add(typeof(Truck), typeof(FTruck));
            DictVehicleTypes.Add(typeof(Jetski), typeof(FJetski));
            DictVehicleTypes.Add(typeof(Yacht), typeof(FYacht));
        }
        public static void AddVehicle(object vehicle)
        {
            Vehicles.Add(vehicle);
        }
        private void RefreshVehicleList()
        {
            lvVehicles.Items.Clear();
            foreach (Vehicle vehicle in Vehicles)
            {
                int value = (int)vehicle.TypeName;
                lvVehicles.Items.Add(ComboBVehicleType.Items[value].ToString());
                lvVehicles.Items[lvVehicles.Items.Count - 1].SubItems.Add(vehicle.Name);
            }
        }
        private void CreateVehicleObject(int vehicleType)
        {
            Type type;
            if (DictForms.TryGetValue(vehicleType, out type))
            {
                Form form = (Form)Activator.CreateInstance(type);
                if (form != null)
                    form.ShowDialog();
            }
            RefreshVehicleList();
        }
        private void ReadVehicleObject(Object vehicle)
        {
            Type type;
            if (DictVehicleTypes.TryGetValue(vehicle.GetType(), out type))
            {
                Form form = (Form)Activator.CreateInstance(type, vehicle, "readonly");
                if (form != null)
                    form.ShowDialog();
            }
        }
        private void UpdateVehicleObject(Object vehicle)
        {
            Type type;
            if (DictVehicleTypes.TryGetValue(vehicle.GetType(), out type))
            {
                Form form = (Form)Activator.CreateInstance(type, vehicle);
                if (form != null)
                    form.ShowDialog();
            }
            RefreshVehicleList();
        }
        private void DeleteVehicleObject(int i)
        {
            Vehicles.RemoveAt(i);
            RefreshVehicleList();
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
        private void ButAdd_Click(object sender, EventArgs e)
        {
            CreateVehicleObject(ComboBVehicleType.SelectedIndex);
        }
        private void ReadToolStripMI_Click(object sender, EventArgs e)
        {
            if (lvVehicles.SelectedItems.Count == 1)
            {
                ListView.SelectedIndexCollection indexs = lvVehicles.SelectedIndices;
                ReadVehicleObject(Vehicles[indexs[0]]);
            }
        }
        private void UpdateToolStripMI_Click(object sender, EventArgs e)
        {
            if (lvVehicles.SelectedItems.Count == 1)
            {
                ListView.SelectedIndexCollection indexs = lvVehicles.SelectedIndices;
                UpdateVehicleObject(Vehicles[indexs[0]]);
            }
        }
        private void DeleteToolStripMI_Click(object sender, EventArgs e)
        {
            if (lvVehicles.SelectedItems.Count == 1)
            {
                ListView.SelectedIndexCollection indexs = lvVehicles.SelectedIndices;
                DeleteVehicleObject(indexs[0]);
            }
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
                RefreshVehicleList();

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
