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
            var account = textAccount.Text;
            var commandItem = new CommandTypes.AccountTx(account);
            var command = CommandTypes.Command.NewAccountTx(commandItem);
            Integration.executeCommand(command);
        }
    }
}
