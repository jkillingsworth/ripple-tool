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
            var account = textAccount.Text;
            var commandItem = new CommandTypes.AccountLines(account);
            var command = CommandTypes.Command.NewAccountLines(commandItem);
            Integration.executeCommand(command);
        }
    }
}
