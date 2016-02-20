﻿using System;
using System.Windows.Forms;

namespace RippleTool.UI
{
    public partial class NoRippleCheckForm : DockForm
    {
        public NoRippleCheckForm()
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
            var role = radioUser.Checked ? CommandTypes.Role.User : CommandTypes.Role.Gateway;
            var commandItem = new CommandTypes.NoRippleCheck(account, ledger, role);
            var command = CommandTypes.Command.NewNoRippleCheck(commandItem);
            Integration.executeCommand(command);
        }
    }
}
