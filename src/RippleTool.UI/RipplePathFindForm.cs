using System;

namespace RippleTool.UI
{
    public partial class RipplePathFindForm : DockForm
    {
        public RipplePathFindForm()
        {
            InitializeComponent();
        }

        private void RefreshCurrencyType()
        {
            var enabled = radioIssued.Checked;
            labelDestinationAmountCurrency.Enabled = enabled;
            textDestinationAmountCurrency.Enabled = enabled;
            labelDestinationAmountIssuer.Enabled = enabled;
            textDestinationAmountIssuer.Enabled = enabled;
        }

        private Types.Amount GetIssuedAmount()
        {
            var item = new Types.IssuedAmount(
                decimal.Parse(textDestinationAmountValue.Text),
                textDestinationAmountCurrency.Text,
                textDestinationAmountIssuer.Text
                );

            return Types.Amount.NewIssuedAmount(item);
        }

        private Types.Amount GetNativeAmount()
        {
            var item = decimal.Parse(textDestinationAmountValue.Text);

            return Types.Amount.NewNativeAmount(item);
        }

        private void buttonSubmit_Click(object sender, EventArgs e)
        {
            var sourceAccount = textSourceAccount.Text;
            var destinationAccount = textDestinationAccount.Text;

            var destinationAmount = radioIssued.Checked
                ? GetIssuedAmount()
                : GetNativeAmount();

            var commandItem = new CommandTypes.RipplePathFind(
                sourceAccount,
                destinationAccount,
                destinationAmount
                );

            var command = CommandTypes.Command.NewRipplePathFind(commandItem);
            Integration.executeCommand(command);
        }

        private void radioIssued_CheckedChanged(object sender, EventArgs e)
        {
            RefreshCurrencyType();
        }

        private void radioNative_CheckedChanged(object sender, EventArgs e)
        {
            RefreshCurrencyType();
        }
    }
}
