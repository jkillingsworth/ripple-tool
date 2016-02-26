using System;

namespace RippleTool.UI
{
    public partial class SubmitPaymentForm : DockForm
    {
        public SubmitPaymentForm()
        {
            InitializeComponent();
        }

        private void RefreshCurrencyType()
        {
            var enabled = radioIssued.Checked;
            labelAmountCurrency.Enabled = enabled;
            textAmountCurrency.Enabled = enabled;
            labelAmountIssuer.Enabled = enabled;
            textAmountIssuer.Enabled = enabled;
        }

        private Types.Amount GetIssuedAmount()
        {
            var item = new Types.IssuedAmount(
                decimal.Parse(textAmountValue.Text),
                textAmountCurrency.Text,
                textAmountIssuer.Text
                );

            return Types.Amount.NewIssuedAmount(item);
        }

        private Types.Amount GetNativeAmount()
        {
            var item = decimal.Parse(textAmountValue.Text);

            return Types.Amount.NewNativeAmount(item);
        }

        private void buttonSubmit_Click(object sender, EventArgs e)
        {
            var account = textAccount.Text;
            var fee = decimal.Parse(textFee.Text);
            var sequence = uint.Parse(textSequence.Text);

            var flags = TransactionTypes.TrustSetFlags.None;
            if (checkFullyCanonicalSig.Checked)
                flags |= TransactionTypes.TrustSetFlags.FullyCanonicalSig;

            var destination = textDestination.Text;

            var amount = radioIssued.Checked
                ? GetIssuedAmount()
                : GetNativeAmount();

            var transactionItem = new TransactionTypes.Payment(
                account,
                Types.Amount.NewNativeAmount(fee),
                sequence,
                (uint)flags,
                destination,
                amount
                );

            var transaction = TransactionTypes.Transaction.NewPayment(transactionItem);
            Integration.executeSubmitTransaction(transaction);
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
