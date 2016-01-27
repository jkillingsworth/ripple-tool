using System;

namespace RippleTool.UI
{
    public partial class AccountObjectsForm : DockForm
    {
        public AccountObjectsForm()
        {
            InitializeComponent();
        }

        private void buttonSubmit_Click(object sender, EventArgs e)
        {
            var accountId = textAccountId.Text;
            var commandItem = new CommandTypes.AccountObjects(accountId);
            var command = CommandTypes.Command.NewAccountObjects(commandItem);
            Integration.agentCommandExecution.Post(command);
        }
    }
}
