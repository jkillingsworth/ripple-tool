using System;

namespace RippleTool.UI
{
    public partial class AccountLinesForm : DockForm
    {
        public AccountLinesForm()
        {
            InitializeComponent();
        }

        private void buttonSubmit_Click(object sender, EventArgs e)
        {
            var accountId = textAccountId.Text;
            var commandItem = new CommandTypes.AccountLines(accountId);
            var command = CommandTypes.Command.NewAccountLines(commandItem);
            Integration.agentCommandExecution.Post(command);
        }
    }
}
