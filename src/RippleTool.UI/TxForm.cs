using System;

namespace RippleTool.UI
{
    public partial class TxForm : DockForm
    {
        public TxForm()
        {
            InitializeComponent();
        }

        private void buttonSubmit_Click(object sender, EventArgs e)
        {
            var transactionId = textTransactionId.Text;
            var commandItem = new CommandTypes.Tx(transactionId);
            var command = CommandTypes.Command.NewTx(commandItem);
            Integration.agentCommandExecution.Post(command);
        }
    }
}
