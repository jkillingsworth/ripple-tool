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
            var account = textAccount.Text;
            var commandItem = new CommandTypes.GatewayBalances(account);
            var command = CommandTypes.Command.NewGatewayBalances(commandItem);
            Integration.agentCommandExecution.Post(command);
        }
    }
}
