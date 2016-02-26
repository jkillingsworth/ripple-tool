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
            var takerGetsItem = new Types.IssuedCurrency(
                textTakerGetsCurrency.Text,
                textTakerGetsIssuer.Text
                );

            var takerPaysItem = new Types.IssuedCurrency(
                textTakerPaysCurrency.Text,
                textTakerPaysIssuer.Text
                );

            var takerGets = Types.Currency.NewIssuedCurrency(takerGetsItem);
            var takerPays = Types.Currency.NewIssuedCurrency(takerPaysItem);

            var commandItem = new CommandTypes.BookOffers(takerGets, takerPays);
            var command = CommandTypes.Command.NewBookOffers(commandItem);
            Integration.executeCommand(command);
        }
    }
}
