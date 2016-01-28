using System;

namespace RippleTool.UI
{
    public partial class NoRippleCheckForm : DockForm
    {
        public NoRippleCheckForm()
        {
            InitializeComponent();
        }

        private void buttonSubmit_Click(object sender, EventArgs e)
        {
            var accountId = textAccountId.Text;
            var commandItem = new CommandTypes.NoRippleCheck(accountId);
            var command = CommandTypes.Command.NewNoRippleCheck(commandItem);
            Integration.agentCommandExecution.Post(command);
        }
    }
}
