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
            var account = textAccount.Text;
            var commandItem = new CommandTypes.AccountCurrencies(account);
            var command = CommandTypes.Command.NewAccountCurrencies(commandItem);
            Integration.executeCommand(command);
        }
    }
}
