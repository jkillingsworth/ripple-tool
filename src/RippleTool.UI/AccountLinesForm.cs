using System;
using System.Windows.Forms;

namespace RippleTool.UI
{
    public partial class AccountLinesForm : DockForm
    {
        public AccountLinesForm()
        {
            InitializeComponent();

            comboLedger.Items.Add(CommandTypes.Ledger.Validated);
            comboLedger.Items.Add(CommandTypes.Ledger.Closed);
            comboLedger.Items.Add(CommandTypes.Ledger.Current);
            comboLedger.SelectedItem = CommandTypes.Ledger.Validated;
            comboLedger.Format += comboLedger_Format;
        }

        private void comboLedger_Format(object sender, ListControlConvertEventArgs e)
        {
            var ledger = (CommandTypes.Ledger)e.Value;

            if (ledger.IsValidated)
            {
                e.Value = "Validated";
            }

            if (ledger.IsCurrent)
            {
                e.Value = "Current";
            }

            if (ledger.IsClosed)
            {
                e.Value = "Closed";
            }
        }

        private void buttonSubmit_Click(object sender, EventArgs e)
        {
            var ledger = (CommandTypes.Ledger)comboLedger.SelectedItem;
            var account = textAccount.Text;
            var commandItem = new CommandTypes.AccountLines(account, ledger);
            var command = CommandTypes.Command.NewAccountLines(commandItem);
            Integration.executeCommand(command);
        }
    }
}
