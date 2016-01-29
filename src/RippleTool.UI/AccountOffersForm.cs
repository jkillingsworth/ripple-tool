using System;

namespace RippleTool.UI
{
    public partial class AccountOffersForm : DockForm
    {
        public AccountOffersForm()
        {
            InitializeComponent();
        }

        private void buttonSubmit_Click(object sender, EventArgs e)
        {
            var account = textAccount.Text;
            var commandItem = new CommandTypes.AccountOffers(account);
            var command = CommandTypes.Command.NewAccountOffers(commandItem);
            Integration.agentCommandExecution.Post(command);
        }
    }
}
