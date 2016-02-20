using System;
using System.Windows.Forms;

namespace RippleTool.UI
{
    public partial class AccountTxForm : DockForm
    {
        public AccountTxForm()
        {
            InitializeComponent();

            comboLedger.Items.Add(0);
            comboLedger.SelectedItem = 0;
            comboLedger.Format += comboLedger_Format;
        }

        private void comboLedger_Format(object sender, ListControlConvertEventArgs e)
        {
            e.Value = "All";
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
