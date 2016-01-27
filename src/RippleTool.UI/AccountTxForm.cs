using System;

namespace RippleTool.UI
{
    public partial class AccountTxForm : DockForm
    {
        public AccountTxForm()
        {
            InitializeComponent();
        }

        private void buttonSubmit_Click(object sender, EventArgs e)
        {
            var accountId = textAccountId.Text;
            var commandItem = new CommandTypes.AccountTx(accountId);
            var command = CommandTypes.Command.NewAccountTx(commandItem);
            Integration.agentCommandExecution.Post(command);
        }
    }
}
