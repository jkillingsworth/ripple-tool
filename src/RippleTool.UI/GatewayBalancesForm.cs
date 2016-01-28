using System;

namespace RippleTool.UI
{
    public partial class GatewayBalancesForm : DockForm
    {
        public GatewayBalancesForm()
        {
            InitializeComponent();
        }

        private void buttonSubmit_Click(object sender, EventArgs e)
        {
            var accountId = textAccountId.Text;
            var commandItem = new CommandTypes.GatewayBalances(accountId);
            var command = CommandTypes.Command.NewGatewayBalances(commandItem);
            Integration.agentCommandExecution.Post(command);
        }
    }
}
