using System;

namespace RippleTool.UI
{
    public partial class BookOffersForm : DockForm
    {
        public BookOffersForm()
        {
            InitializeComponent();
        }

        private void RefreshTakerGetsCurrencyType()
        {
            var enabled = radioTakerGetsIssued.Checked;
            labelTakerGetsCurrency.Enabled = enabled;
            textTakerGetsCurrency.Enabled = enabled;
            labelTakerGetsIssuer.Enabled = enabled;
            textTakerGetsIssuer.Enabled = enabled;
        }

        private void RefreshTakerPaysCurrencyType()
        {
            var enabled = radioTakerPaysIssued.Checked;
            labelTakerPaysCurrency.Enabled = enabled;
            textTakerPaysCurrency.Enabled = enabled;
            labelTakerPaysIssuer.Enabled = enabled;
            textTakerPaysIssuer.Enabled = enabled;
        }

        private Types.Currency GetTakerGetsIssuedCurrency()
        {
            var item = new Types.IssuedCurrency(
                textTakerGetsCurrency.Text,
                textTakerGetsIssuer.Text
                );

            return Types.Currency.NewIssuedCurrency(item);
        }

        private Types.Currency GetTakerPaysIssuedCurrency()
        {
            var item = new Types.IssuedCurrency(
                textTakerPaysCurrency.Text,
                textTakerPaysIssuer.Text
                );

            return Types.Currency.NewIssuedCurrency(item);
        }

        private void buttonSubmit_Click(object sender, EventArgs e)
        {
            var takerGets = radioTakerGetsIssued.Checked
                ? GetTakerGetsIssuedCurrency()
                : Types.Currency.NewNativeCurrency(null);

            var takerPays = radioTakerPaysIssued.Checked
                ? GetTakerPaysIssuedCurrency()
                : Types.Currency.NewNativeCurrency(null);

            var commandItem = new CommandTypes.BookOffers(takerGets, takerPays);
            var command = CommandTypes.Command.NewBookOffers(commandItem);
            Integration.executeCommand(command);
        }

        private void radioTakerGetsIssued_CheckedChanged(object sender, EventArgs e)
        {
            RefreshTakerGetsCurrencyType();
        }

        private void radioTakerGetsNative_CheckedChanged(object sender, EventArgs e)
        {
            RefreshTakerGetsCurrencyType();
        }

        private void radioTakerPaysIssued_CheckedChanged(object sender, EventArgs e)
        {
            RefreshTakerPaysCurrencyType();
        }

        private void radioTakerPaysNative_CheckedChanged(object sender, EventArgs e)
        {
            RefreshTakerPaysCurrencyType();
        }
    }
}
