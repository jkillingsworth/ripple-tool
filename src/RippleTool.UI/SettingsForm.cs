using System.Windows.Forms;

namespace RippleTool.UI
{
    public partial class SettingsForm : Form
    {
        public SettingsForm()
        {
            InitializeComponent();

            textServerUri.Text = Integration.Config.serverUri;
            textSecretKey.Text = Integration.Config.secretKey;
            textAccountId.Text = Integration.Config.accountId;
        }
    }
}
