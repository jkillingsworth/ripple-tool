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
            var transaction = textTransaction.Text;
            var commandItem = new CommandTypes.Tx(transaction);
            var command = CommandTypes.Command.NewTx(commandItem);
            Integration.executeCommand(command);
        }
    }
}
