using System.Windows.Forms;
using Dominisoft.NetworkMapper.Static;

namespace Dominisoft.NetworkMapper
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }
        private void Main_Load(object sender, System.EventArgs e)
        {
            GlobalConfig.Clear();
            Network.Initialize();
            RefreshDiagram();
        }

        private void RefreshDiagram()
        {

        }

        private void LoadFromFile()
        {

        }

        private void SaveToFile()
        {

        }


        #region MenuCommands

        private void newToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            //File -> New
            GlobalConfig.Clear();
            Network.Initialize();
            RefreshDiagram();
        }

        private void openToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            //File -> Open
        }

        private void saveToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            //File -> save

        }

        private void saveAsToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            //File -> SaveAs
        }

        private void settingsToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            //File -> Settings
        }

        private void closeToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            //File -> Close
            this.Close();
        }

        private void allToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            //Network -> Detect -> All

        }

        private void dHCPAddressesToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            //Network -> Detect -> DHCP Addresses
        }

        private void devicesByMacToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            //Network -> Detect -> New Devices
        }

        private void connectionsToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            //Network -> Detect -> Connections
        }

        private void iPRangesToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            //Network -> IP Ranges

        }

        private void locationsToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            //Network -> Locations
        }

        private void addToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            //Device -> Add New
        }

        private void createNewToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            //Connection -> Create New

        }

        private void viewConnectionsToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            //Connection -> View Connections
        }

        private void staticIPAddressesToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            //Reports -> Static Ip Addresses

        }

        private void dHCPDevicesToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            //Reports -> DHCP Devices

        }

        private void portMappingToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            //Reports -> Port Mapping
        }

        private void savedCredentialsToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            //Reports -> Saved Credentials
        }
        #endregion

    }
}
