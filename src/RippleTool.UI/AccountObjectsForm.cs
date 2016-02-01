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
            var account = textAccount.Text;
            var commandItem = new CommandTypes.AccountObjects(account);
            var command = CommandTypes.Command.NewAccountObjects(commandItem);
            Integration.executeCommand(command);
        }
    }
}
