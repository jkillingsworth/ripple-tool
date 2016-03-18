using System;
using System.Windows.Forms;

namespace RippleTool.UI
{
    public partial class SettingsForm : Form
    {
        public SettingsForm()
        {
            InitializeComponent();

            textServerUri.Text = Config.serverUri;
            textAccountId.Text = Config.accountId;
            textSecretKey.Text = Config.secretKey;
        }

        private void checkHideSecretKey_CheckedChanged(object sender, EventArgs e)
        {
            if (checkShowSecretKey.Checked)
            {
                textSecretKey.PasswordChar = '\0';
            }
            else
            {
                textSecretKey.PasswordChar = '*';
            }
        }
    }
}
