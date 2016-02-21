using System;

namespace RippleTool.UI
{
    public partial class SubmitTrustSetForm : DockForm
    {
        public SubmitTrustSetForm()
        {
            InitializeComponent();
        }

        private void buttonSubmit_Click(object sender, EventArgs e)
        {
            var account = textAccount.Text;
            var fee = decimal.Parse(textFee.Text);
            var sequence = uint.Parse(textSequence.Text);

            var flags = TransactionTypes.TrustSetFlags.None;
            if (checkFullyCanonicalSig.Checked)
                flags |= TransactionTypes.TrustSetFlags.FullyCanonicalSig;
            if (checkSetNoRipple.Checked)
                flags |= TransactionTypes.TrustSetFlags.SetNoRipple;
            if (checkClearNoRipple.Checked)
                flags |= TransactionTypes.TrustSetFlags.ClearNoRipple;

            var limitAmount = new TransactionTypes.IssuedAmount(
                decimal.Parse(textLimitAmountValue.Text),
                textLimitAmountCurrency.Text,
                textLimitAmountIssuer.Text
                );

            var transactionItem = new TransactionTypes.TrustSet(
                account,
                TransactionTypes.Amount.NewNativeAmount(fee),
                sequence,
                (uint)flags,
                TransactionTypes.Amount.NewIssuedAmount(limitAmount)
                );

            var transaction = TransactionTypes.Transaction.NewTrustSet(transactionItem);
            Integration.executeSubmitTransaction(transaction);
        }
    }
}
