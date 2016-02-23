using System;

namespace RippleTool.UI
{
    public partial class ServerStateForm : DockForm
    {
        public ServerStateForm()
        {
            InitializeComponent();
        }

        private void buttonSubmit_Click(object sender, EventArgs e)
        {
            var command = CommandTypes.Command.NewServerState(null);
            Integration.executeCommand(command);
        }
    }
}
