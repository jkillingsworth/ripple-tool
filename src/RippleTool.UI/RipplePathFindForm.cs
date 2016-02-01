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
            var destinationAmount = double.Parse(textDestinationAmount.Text);
            var destinationCurrency = textDestinationCurrency.Text;
            var destinationIssuer = textDestinationIssuer.Text;

            var commandItem = new CommandTypes.RipplePathFind(
                sourceAccount,
                destinationAccount,
                destinationAmount,
                destinationCurrency,
                destinationIssuer
                );

            var command = CommandTypes.Command.NewRipplePathFind(commandItem);
            Integration.executeCommand(command);
        }
    }
}
