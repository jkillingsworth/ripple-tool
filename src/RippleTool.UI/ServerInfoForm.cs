using System;

namespace RippleTool.UI
{
    public partial class ServerInfoForm : DockForm
    {
        public ServerInfoForm()
        {
            InitializeComponent();
        }

        private void buttonSubmit_Click(object sender, EventArgs e)
        {
            var command = CommandTypes.Command.NewServerInfo(null);
            Integration.executeCommand(command);
        }
    }
}
