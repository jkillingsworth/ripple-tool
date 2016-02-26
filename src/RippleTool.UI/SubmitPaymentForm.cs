﻿using System;

namespace RippleTool.UI
{
    public partial class SubmitPaymentForm : DockForm
    {
        public SubmitPaymentForm()
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

            var destination = textDestination.Text;
            var amount = decimal.Parse(textAmount.Text);

            var transactionItem = new TransactionTypes.Payment(
                account,
                Types.Amount.NewNativeAmount(fee),
                sequence,
                (uint)flags,
                destination,
                Types.Amount.NewNativeAmount(amount)
                );

            var transaction = TransactionTypes.Transaction.NewPayment(transactionItem);
            Integration.executeSubmitTransaction(transaction);
        }
    }
}
