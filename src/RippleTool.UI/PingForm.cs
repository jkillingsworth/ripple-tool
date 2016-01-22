using System;
using System.Windows.Forms;

namespace RippleTool.UI
{
    public partial class PingForm : Form
    {
        public PingForm()
        {
            InitializeComponent();
        }

        private void buttonSubmit_Click(object sender, EventArgs e)
        {
            var command = CommandTypes.Command.NewPing(null);
            Integration.agentCommandExecution.Post(command);
        }
    }
}
