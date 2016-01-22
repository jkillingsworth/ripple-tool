using System;
using System.Windows.Forms;

namespace RippleTool.UI
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void menuItemFileExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void menuItemViewResponse_Click(object sender, EventArgs e)
        {
            var form = new ResponseForm();
            form.MdiParent = this;
            form.Show();
        }

        private void menuItemViewPing_Click(object sender, EventArgs e)
        {
            var form = new PingForm();
            form.MdiParent = this;
            form.Show();
        }
    }
}
