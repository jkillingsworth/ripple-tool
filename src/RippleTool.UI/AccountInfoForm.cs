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
            var account = textAccount.Text;
            var commandItem = new CommandTypes.AccountInfo(account);
            var command = CommandTypes.Command.NewAccountInfo(commandItem);
            Integration.agentCommandExecution.Post(command);
        }
    }
}
