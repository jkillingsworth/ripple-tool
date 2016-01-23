using System;
using System.Windows.Forms;

namespace RippleTool.UI
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            statusItemServerUri.Text = Integration.configServerUri;
        }

        private void menuItemFileExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void menuItemViewResponse_Click(object sender, EventArgs e)
        {
            var form = new ResponseForm();
            form.Show(dockPanel);
        }

        private void menuItemViewPing_Click(object sender, EventArgs e)
        {
            var form = new PingForm();
            form.Show(dockPanel);
        }
    }
}
