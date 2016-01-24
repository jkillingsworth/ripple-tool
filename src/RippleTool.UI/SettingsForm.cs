using System.Windows.Forms;

namespace RippleTool.UI
{
    public partial class SettingsForm : Form
    {
        public SettingsForm()
        {
            InitializeComponent();

            textServerUri.Text = Integration.configServerUri;
            textSecretKey.Text = Integration.configSecretKey;
            textAccountId.Text = Integration.configAccountId;
        }
    }
}
