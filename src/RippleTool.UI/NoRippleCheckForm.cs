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
            var account = textAccount.Text;
            var commandItem = new CommandTypes.NoRippleCheck(account);
            var command = CommandTypes.Command.NewNoRippleCheck(commandItem);
            Integration.agentCommandExecution.Post(command);
        }
    }
}
