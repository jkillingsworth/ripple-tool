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
            var takerGetsCurrency = textTakerGetsCurrency.Text;
            var takerGetsIssuer = textTakerGetsIssuer.Text;
            var takerPaysCurrency = textTakerPaysCurrency.Text;
            var takerPaysIssuer = textTakerPaysIssuer.Text;

            var commandItem = new CommandTypes.BookOffers(
                takerGetsCurrency,
                takerGetsIssuer,
                takerPaysCurrency,
                takerPaysIssuer
                );

            var command = CommandTypes.Command.NewBookOffers(commandItem);
            Integration.agentCommandExecution.Post(command);
        }
    }
}
