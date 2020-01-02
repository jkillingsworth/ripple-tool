using System.Diagnostics;
using System.Windows.Forms;

namespace RippleTool.UI
{
    public partial class AboutForm : Form
    {
        public AboutForm()
        {
            InitializeComponent();
        }

        private void linkViewSourceCode_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://github.com/jkillingsworth/ripple-tool");
        }
    }
}
