using System;

namespace RippleTool.UI
{
    public partial class AccountInfoForm : DockForm
    {
        public AccountInfoForm()
        {
            InitializeComponent();
        }

        private void buttonSubmit_Click(object sender, EventArgs e)
        {
            var accountId = textAccountId.Text;
            var commandItem = new CommandTypes.AccountInfo(accountId);
            var command = CommandTypes.Command.NewAccountInfo(commandItem);
            Integration.agentCommandExecution.Post(command);
        }
    }
}
