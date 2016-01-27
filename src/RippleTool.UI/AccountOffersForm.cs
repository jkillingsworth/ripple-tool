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
            var accountId = textAccountId.Text;
            var commandItem = new CommandTypes.AccountOffers(accountId);
            var command = CommandTypes.Command.NewAccountOffers(commandItem);
            Integration.agentCommandExecution.Post(command);
        }
    }
}
