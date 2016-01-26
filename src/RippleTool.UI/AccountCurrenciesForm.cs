using System;

namespace RippleTool.UI
{
    public partial class AccountCurrenciesForm : DockForm
    {
        public AccountCurrenciesForm()
        {
            InitializeComponent();
        }

        private void buttonSubmit_Click(object sender, EventArgs e)
        {
            var accountId = textAccountId.Text;
            var commandItem = new CommandTypes.AccountCurrencies(accountId);
            var command = CommandTypes.Command.NewAccountCurrencies(commandItem);
            Integration.agentCommandExecution.Post(command);
        }
    }
}
