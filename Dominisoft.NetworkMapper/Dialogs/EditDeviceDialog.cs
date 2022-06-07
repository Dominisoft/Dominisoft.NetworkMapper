using System.Windows.Forms;
using Dominisoft.NetworkMapper.Models;

namespace Dominisoft.NetworkMapper.Dialogs
{
    public partial class EditDeviceDialog : Form
    {
        private readonly Device _device;

        public EditDeviceDialog(Device device)
        {
            _device = device;
            InitializeComponent();
        }
    }
}
