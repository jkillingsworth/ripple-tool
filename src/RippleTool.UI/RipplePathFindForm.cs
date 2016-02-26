using System;

namespace RippleTool.UI
{
    public partial class RipplePathFindForm : DockForm
    {
        public RipplePathFindForm()
        {
            InitializeComponent();
        }

        private void buttonSubmit_Click(object sender, EventArgs e)
        {
            var sourceAccount = textSourceAccount.Text;
            var destinationAccount = textDestinationAccount.Text;

            var destinationAmountItem = new Types.IssuedAmount(
                decimal.Parse(textDestinationAmount.Text),
                textDestinationCurrency.Text,
                textDestinationIssuer.Text
                );

            var destinationAmount = Types.Amount.NewIssuedAmount(destinationAmountItem);

            var commandItem = new CommandTypes.RipplePathFind(
                sourceAccount,
                destinationAccount,
                destinationAmount
                );

            var command = CommandTypes.Command.NewRipplePathFind(commandItem);
            Integration.executeCommand(command);
        }
    }
}
