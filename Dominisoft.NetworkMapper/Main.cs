using System;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using Dominisoft.NetworkMapper.Dialogs;
using Dominisoft.NetworkMapper.Extensions;
using Dominisoft.NetworkMapper.Models;
using Dominisoft.NetworkMapper.Static;

namespace Dominisoft.NetworkMapper
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            GlobalConfig.Clear();
            Network.Initialize();
            RefreshDiagram();
        }

        private void BindAndShowDialog(Form dialogForm)
        {
            dialogForm.Closed += DialogForm_Closed;
            dialogForm.ShowDialog();
        }

        private void DialogForm_Closed(object sender, EventArgs e)
        {
            RefreshDiagram();
        }

        private void RefreshDiagram()
        {

        }

        private void LoadFromFile()
        {
            Network.Connections = Network.Connections.LoadFromFile(nameof(Network.Connections));
            Network.Devices = Network.Devices.LoadFromFile(nameof(Network.Devices));
            Network.Locations = Network.Locations.LoadFromFile(nameof(Network.Locations));
            Network.DeviceIcons = Network.DeviceIcons.LoadFromFile(nameof(Network.DeviceIcons));
            
            
        }

        private void CreateIconControls()
        {
            var existingIconControls = Controls.GetIconControls();
            var newDevices = Network.Devices.Where(device =>
                existingIconControls.Any(icon => icon.Tag?.ToString() == device.Id.ToString())).ToList();

            foreach (var device in newDevices)
            {
                
            }
        }

        private void SaveToFile()
        {
            Network.Connections.SaveToFile(nameof(Network.Connections));
            Network.Devices.SaveToFile(nameof(Network.Devices));
            Network.Locations.SaveToFile(nameof(Network.Locations));
            Network.DeviceIcons.SaveToFile(nameof(Network.DeviceIcons));
        }


        #region MenuCommands

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //File -> New
            GlobalConfig.Clear();
            Network.Initialize();
            RefreshDiagram();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //File -> Open

            var dialog = new OpenFileDialog();
            if (dialog.ShowDialog() != DialogResult.OK) return;
            GlobalConfig.SaveDirectory = Path.GetDirectoryName(dialog.FileName);
            LoadFromFile();
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //File -> save
            if (string.IsNullOrWhiteSpace(GlobalConfig.SaveDirectory))

            {
                saveAsToolStripMenuItem_Click(sender,e);
                return;
            }

            SaveToFile();

        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //File -> SaveAs

            var dummyFileName = "Save Here";

            var dialog = new SaveFileDialog();
            dialog.FileName = dummyFileName;
            if (dialog.ShowDialog() != DialogResult.OK) return;
            GlobalConfig.SaveDirectory = Path.GetDirectoryName(dialog.FileName);
            SaveToFile();


        }

        private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //File -> Settings

            var dialog = new ApplicationSettingsDialog();
            BindAndShowDialog(dialog);

        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //File -> Close
            Close();
        }

        private void allToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Network -> Detect -> All
            dHCPAddressesToolStripMenuItem_Click(sender, e);
            devicesByMacToolStripMenuItem_Click(sender, e);
            connectionsToolStripMenuItem_Click(sender, e);
        }

        private void dHCPAddressesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Network -> Detect -> DHCP Addresses
        }

        private void devicesByMacToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Network -> Detect -> New Devices
        }

        private void connectionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Network -> Detect -> Connections
        }

        private void iPRangesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Network -> IP Ranges

        }

        private void locationsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Network -> Locations
        }

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Device -> Add New
            var device = new Device();
            Network.Devices.Add(device);
            var dialog = new EditDeviceDialog(device);
            BindAndShowDialog(dialog);
        }

        private void createNewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Connection -> Create New

        }

        private void viewConnectionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Connection -> View Connections
        }

        private void staticIPAddressesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Reports -> Static Ip Addresses

        }

        private void dHCPDevicesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Reports -> DHCP Devices

        }

        private void portMappingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Reports -> Port Mapping
        }

        private void savedCredentialsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Reports -> Saved Credentials
        }
        #endregion

    }
}
