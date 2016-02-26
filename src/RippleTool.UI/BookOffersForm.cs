using System;

namespace RippleTool.UI
{
    public partial class BookOffersForm : DockForm
    {
        public BookOffersForm()
        {
            InitializeComponent();
        }

        private void buttonSubmit_Click(object sender, EventArgs e)
        {
            var takerGetsItem = new CommandTypes.IssuedCurrency(
                textTakerGetsCurrency.Text,
                textTakerGetsIssuer.Text
                );

            var takerPaysItem = new CommandTypes.IssuedCurrency(
                textTakerPaysCurrency.Text,
                textTakerPaysIssuer.Text
                );

            var takerGets = CommandTypes.Currency.NewIssuedCurrency(takerGetsItem);
            var takerPays = CommandTypes.Currency.NewIssuedCurrency(takerPaysItem);

            var commandItem = new CommandTypes.BookOffers(takerGets, takerPays);
            var command = CommandTypes.Command.NewBookOffers(commandItem);
            Integration.executeCommand(command);
        }
    }
}
