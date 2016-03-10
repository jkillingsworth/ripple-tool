namespace RippleTool.UI
{
    partial class SubmitPaymentForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.bindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.buttonSubmit = new System.Windows.Forms.Button();
            this.labelAccount = new System.Windows.Forms.Label();
            this.textAccount = new System.Windows.Forms.TextBox();
            this.labelFee = new System.Windows.Forms.Label();
            this.textFee = new System.Windows.Forms.TextBox();
            this.labelSequence = new System.Windows.Forms.Label();
            this.textSequence = new System.Windows.Forms.TextBox();
            this.labelLastLedgerSequence = new System.Windows.Forms.Label();
            this.textLastLedgerSequence = new System.Windows.Forms.TextBox();
            this.groupFlags = new System.Windows.Forms.GroupBox();
            this.checkFullyCanonicalSig = new System.Windows.Forms.CheckBox();
            this.checkNoRippleDirect = new System.Windows.Forms.CheckBox();
            this.checkPartialPayment = new System.Windows.Forms.CheckBox();
            this.checkLimitQuality = new System.Windows.Forms.CheckBox();
            this.labelSourceTag = new System.Windows.Forms.Label();
            this.textSourceTag = new System.Windows.Forms.TextBox();
            this.labelDestinationTag = new System.Windows.Forms.Label();
            this.textDestinationTag = new System.Windows.Forms.TextBox();
            this.labelDestination = new System.Windows.Forms.Label();
            this.textDestination = new System.Windows.Forms.TextBox();
            this.groupAmount = new System.Windows.Forms.GroupBox();
            this.radioAmountIsIssued = new System.Windows.Forms.RadioButton();
            this.radioAmountIsNative = new System.Windows.Forms.RadioButton();
            this.labelAmountValue = new System.Windows.Forms.Label();
            this.textAmountValue = new System.Windows.Forms.TextBox();
            this.labelAmountCurrency = new System.Windows.Forms.Label();
            this.textAmountCurrency = new System.Windows.Forms.TextBox();
            this.labelAmountIssuer = new System.Windows.Forms.Label();
            this.textAmountIssuer = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource)).BeginInit();
            this.groupFlags.SuspendLayout();
            this.groupAmount.SuspendLayout();
            this.SuspendLayout();
            // 
            // bindingSource
            // 
            this.bindingSource.DataSource = typeof(RippleTool.UI.Models.SubmitPaymentModel);
            // 
            // buttonSubmit
            // 
            this.buttonSubmit.Location = new System.Drawing.Point(12, 639);
            this.buttonSubmit.Name = "buttonSubmit";
            this.buttonSubmit.Size = new System.Drawing.Size(100, 25);
            this.buttonSubmit.TabIndex = 22;
            this.buttonSubmit.Text = "Submit";
            this.buttonSubmit.UseVisualStyleBackColor = true;
            this.buttonSubmit.Click += new System.EventHandler(this.buttonSubmit_Click);
            // 
            // labelAccount
            // 
            this.labelAccount.AutoSize = true;
            this.labelAccount.Location = new System.Drawing.Point(12, 9);
            this.labelAccount.Name = "labelAccount";
            this.labelAccount.Size = new System.Drawing.Size(55, 15);
            this.labelAccount.TabIndex = 0;
            this.labelAccount.Text = "Account:";
            // 
            // textAccount
            // 
            this.textAccount.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSource, "Account", true));
            this.textAccount.Location = new System.Drawing.Point(12, 27);
            this.textAccount.Name = "textAccount";
            this.textAccount.Size = new System.Drawing.Size(260, 23);
            this.textAccount.TabIndex = 1;
            // 
            // labelFee
            // 
            this.labelFee.AutoSize = true;
            this.labelFee.Location = new System.Drawing.Point(12, 53);
            this.labelFee.Name = "labelFee";
            this.labelFee.Size = new System.Drawing.Size(28, 15);
            this.labelFee.TabIndex = 2;
            this.labelFee.Text = "Fee:";
            // 
            // textFee
            // 
            this.textFee.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSource, "Fee", true));
            this.textFee.Location = new System.Drawing.Point(12, 71);
            this.textFee.Name = "textFee";
            this.textFee.Size = new System.Drawing.Size(260, 23);
            this.textFee.TabIndex = 3;
            // 
            // labelSequence
            // 
            this.labelSequence.AutoSize = true;
            this.labelSequence.Location = new System.Drawing.Point(12, 97);
            this.labelSequence.Name = "labelSequence";
            this.labelSequence.Size = new System.Drawing.Size(61, 15);
            this.labelSequence.TabIndex = 4;
            this.labelSequence.Text = "Sequence:";
            // 
            // textSequence
            // 
            this.textSequence.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSource, "Sequence", true));
            this.textSequence.Location = new System.Drawing.Point(12, 115);
            this.textSequence.Name = "textSequence";
            this.textSequence.Size = new System.Drawing.Size(260, 23);
            this.textSequence.TabIndex = 5;
            // 
            // labelLastLedgerSequence
            // 
            this.labelLastLedgerSequence.AutoSize = true;
            this.labelLastLedgerSequence.Location = new System.Drawing.Point(12, 141);
            this.labelLastLedgerSequence.Name = "labelLastLedgerSequence";
            this.labelLastLedgerSequence.Size = new System.Drawing.Size(175, 15);
            this.labelLastLedgerSequence.TabIndex = 6;
            this.labelLastLedgerSequence.Text = "Last ledger sequence (optional):";
            // 
            // textLastLedgerSequence
            // 
            this.textLastLedgerSequence.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSource, "LastLedgerSequence", true));
            this.textLastLedgerSequence.Location = new System.Drawing.Point(12, 159);
            this.textLastLedgerSequence.Name = "textLastLedgerSequence";
            this.textLastLedgerSequence.Size = new System.Drawing.Size(260, 23);
            this.textLastLedgerSequence.TabIndex = 7;
            // 
            // groupFlags
            // 
            this.groupFlags.Controls.Add(this.checkFullyCanonicalSig);
            this.groupFlags.Controls.Add(this.checkNoRippleDirect);
            this.groupFlags.Controls.Add(this.checkPartialPayment);
            this.groupFlags.Controls.Add(this.checkLimitQuality);
            this.groupFlags.Location = new System.Drawing.Point(12, 188);
            this.groupFlags.Name = "groupFlags";
            this.groupFlags.Padding = new System.Windows.Forms.Padding(6, 3, 6, 6);
            this.groupFlags.Size = new System.Drawing.Size(260, 125);
            this.groupFlags.TabIndex = 8;
            this.groupFlags.TabStop = false;
            this.groupFlags.Text = "Flags";
            // 
            // checkFullyCanonicalSig
            // 
            this.checkFullyCanonicalSig.AutoSize = true;
            this.checkFullyCanonicalSig.Checked = true;
            this.checkFullyCanonicalSig.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkFullyCanonicalSig.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.bindingSource, "FlagFullyCanonicalSig", true));
            this.checkFullyCanonicalSig.Location = new System.Drawing.Point(9, 22);
            this.checkFullyCanonicalSig.Name = "checkFullyCanonicalSig";
            this.checkFullyCanonicalSig.Size = new System.Drawing.Size(157, 19);
            this.checkFullyCanonicalSig.TabIndex = 0;
            this.checkFullyCanonicalSig.Text = "Fully canonical signature";
            this.checkFullyCanonicalSig.UseVisualStyleBackColor = true;
            // 
            // checkNoRippleDirect
            // 
            this.checkNoRippleDirect.AutoSize = true;
            this.checkNoRippleDirect.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.bindingSource, "FlagNoRippleDirect", true));
            this.checkNoRippleDirect.Location = new System.Drawing.Point(9, 47);
            this.checkNoRippleDirect.Name = "checkNoRippleDirect";
            this.checkNoRippleDirect.Size = new System.Drawing.Size(108, 19);
            this.checkNoRippleDirect.TabIndex = 1;
            this.checkNoRippleDirect.Text = "No ripple direct";
            this.checkNoRippleDirect.UseVisualStyleBackColor = true;
            // 
            // checkPartialPayment
            // 
            this.checkPartialPayment.AutoSize = true;
            this.checkPartialPayment.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.bindingSource, "FlagPartialPayment", true));
            this.checkPartialPayment.Location = new System.Drawing.Point(9, 72);
            this.checkPartialPayment.Name = "checkPartialPayment";
            this.checkPartialPayment.Size = new System.Drawing.Size(109, 19);
            this.checkPartialPayment.TabIndex = 2;
            this.checkPartialPayment.Text = "Partial payment";
            this.checkPartialPayment.UseVisualStyleBackColor = true;
            // 
            // checkLimitQuality
            // 
            this.checkLimitQuality.AutoSize = true;
            this.checkLimitQuality.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.bindingSource, "FlagLimitQuality", true));
            this.checkLimitQuality.Location = new System.Drawing.Point(9, 97);
            this.checkLimitQuality.Name = "checkLimitQuality";
            this.checkLimitQuality.Size = new System.Drawing.Size(92, 19);
            this.checkLimitQuality.TabIndex = 3;
            this.checkLimitQuality.Text = "Limit quality";
            this.checkLimitQuality.UseVisualStyleBackColor = true;
            // 
            // labelSourceTag
            // 
            this.labelSourceTag.AutoSize = true;
            this.labelSourceTag.Location = new System.Drawing.Point(12, 316);
            this.labelSourceTag.Name = "labelSourceTag";
            this.labelSourceTag.Size = new System.Drawing.Size(121, 15);
            this.labelSourceTag.TabIndex = 9;
            this.labelSourceTag.Text = "Source tag (optional):";
            // 
            // textSourceTag
            // 
            this.textSourceTag.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSource, "SourceTag", true));
            this.textSourceTag.Location = new System.Drawing.Point(12, 334);
            this.textSourceTag.Name = "textSourceTag";
            this.textSourceTag.Size = new System.Drawing.Size(260, 23);
            this.textSourceTag.TabIndex = 10;
            // 
            // labelDestinationTag
            // 
            this.labelDestinationTag.AutoSize = true;
            this.labelDestinationTag.Location = new System.Drawing.Point(12, 360);
            this.labelDestinationTag.Name = "labelDestinationTag";
            this.labelDestinationTag.Size = new System.Drawing.Size(145, 15);
            this.labelDestinationTag.TabIndex = 11;
            this.labelDestinationTag.Text = "Destination tag (optional):";
            // 
            // textDestinationTag
            // 
            this.textDestinationTag.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSource, "DestinationTag", true));
            this.textDestinationTag.Location = new System.Drawing.Point(12, 378);
            this.textDestinationTag.Name = "textDestinationTag";
            this.textDestinationTag.Size = new System.Drawing.Size(260, 23);
            this.textDestinationTag.TabIndex = 12;
            // 
            // labelDestination
            // 
            this.labelDestination.AutoSize = true;
            this.labelDestination.Location = new System.Drawing.Point(12, 404);
            this.labelDestination.Name = "labelDestination";
            this.labelDestination.Size = new System.Drawing.Size(70, 15);
            this.labelDestination.TabIndex = 13;
            this.labelDestination.Text = "Destination:";
            // 
            // textDestination
            // 
            this.textDestination.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSource, "Destination", true));
            this.textDestination.Location = new System.Drawing.Point(12, 422);
            this.textDestination.Name = "textDestination";
            this.textDestination.Size = new System.Drawing.Size(260, 23);
            this.textDestination.TabIndex = 14;
            // 
            // groupAmount
            // 
            this.groupAmount.Controls.Add(this.radioAmountIsIssued);
            this.groupAmount.Controls.Add(this.radioAmountIsNative);
            this.groupAmount.Location = new System.Drawing.Point(12, 451);
            this.groupAmount.Name = "groupAmount";
            this.groupAmount.Padding = new System.Windows.Forms.Padding(6, 3, 6, 6);
            this.groupAmount.Size = new System.Drawing.Size(260, 50);
            this.groupAmount.TabIndex = 15;
            this.groupAmount.TabStop = false;
            this.groupAmount.Text = "Amount";
            // 
            // radioAmountIsIssued
            // 
            this.radioAmountIsIssued.AutoSize = true;
            this.radioAmountIsIssued.Checked = true;
            this.radioAmountIsIssued.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.bindingSource, "AmountIsIssued", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.radioAmountIsIssued.Location = new System.Drawing.Point(9, 22);
            this.radioAmountIsIssued.Name = "radioAmountIsIssued";
            this.radioAmountIsIssued.Size = new System.Drawing.Size(58, 19);
            this.radioAmountIsIssued.TabIndex = 0;
            this.radioAmountIsIssued.TabStop = true;
            this.radioAmountIsIssued.Text = "Issued";
            this.radioAmountIsIssued.UseVisualStyleBackColor = true;
            // 
            // radioAmountIsNative
            // 
            this.radioAmountIsNative.AutoSize = true;
            this.radioAmountIsNative.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.bindingSource, "AmountIsNative", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.radioAmountIsNative.Location = new System.Drawing.Point(73, 22);
            this.radioAmountIsNative.Name = "radioAmountIsNative";
            this.radioAmountIsNative.Size = new System.Drawing.Size(59, 19);
            this.radioAmountIsNative.TabIndex = 1;
            this.radioAmountIsNative.Text = "Native";
            this.radioAmountIsNative.UseVisualStyleBackColor = true;
            // 
            // labelAmountValue
            // 
            this.labelAmountValue.AutoSize = true;
            this.labelAmountValue.Location = new System.Drawing.Point(12, 504);
            this.labelAmountValue.Name = "labelAmountValue";
            this.labelAmountValue.Size = new System.Drawing.Size(85, 15);
            this.labelAmountValue.TabIndex = 16;
            this.labelAmountValue.Text = "Amount value:";
            // 
            // textAmountValue
            // 
            this.textAmountValue.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSource, "AmountValue", true));
            this.textAmountValue.Location = new System.Drawing.Point(12, 522);
            this.textAmountValue.Name = "textAmountValue";
            this.textAmountValue.Size = new System.Drawing.Size(260, 23);
            this.textAmountValue.TabIndex = 17;
            // 
            // labelAmountCurrency
            // 
            this.labelAmountCurrency.AutoSize = true;
            this.labelAmountCurrency.DataBindings.Add(new System.Windows.Forms.Binding("Enabled", this.bindingSource, "AmountIsIssued", true));
            this.labelAmountCurrency.Location = new System.Drawing.Point(12, 548);
            this.labelAmountCurrency.Name = "labelAmountCurrency";
            this.labelAmountCurrency.Size = new System.Drawing.Size(103, 15);
            this.labelAmountCurrency.TabIndex = 18;
            this.labelAmountCurrency.Text = "Amount currency:";
            // 
            // textAmountCurrency
            // 
            this.textAmountCurrency.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSource, "AmountCurrency", true));
            this.textAmountCurrency.DataBindings.Add(new System.Windows.Forms.Binding("Enabled", this.bindingSource, "AmountIsIssued", true));
            this.textAmountCurrency.Location = new System.Drawing.Point(12, 566);
            this.textAmountCurrency.Name = "textAmountCurrency";
            this.textAmountCurrency.Size = new System.Drawing.Size(260, 23);
            this.textAmountCurrency.TabIndex = 19;
            // 
            // labelAmountIssuer
            // 
            this.labelAmountIssuer.AutoSize = true;
            this.labelAmountIssuer.DataBindings.Add(new System.Windows.Forms.Binding("Enabled", this.bindingSource, "AmountIsIssued", true));
            this.labelAmountIssuer.Location = new System.Drawing.Point(12, 592);
            this.labelAmountIssuer.Name = "labelAmountIssuer";
            this.labelAmountIssuer.Size = new System.Drawing.Size(87, 15);
            this.labelAmountIssuer.TabIndex = 20;
            this.labelAmountIssuer.Text = "Amount issuer:";
            // 
            // textAmountIssuer
            // 
            this.textAmountIssuer.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSource, "AmountIssuer", true));
            this.textAmountIssuer.DataBindings.Add(new System.Windows.Forms.Binding("Enabled", this.bindingSource, "AmountIsIssued", true));
            this.textAmountIssuer.Location = new System.Drawing.Point(12, 610);
            this.textAmountIssuer.Name = "textAmountIssuer";
            this.textAmountIssuer.Size = new System.Drawing.Size(260, 23);
            this.textAmountIssuer.TabIndex = 21;
            // 
            // SubmitPaymentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 862);
            this.Controls.Add(this.textAmountIssuer);
            this.Controls.Add(this.labelAmountIssuer);
            this.Controls.Add(this.textAmountCurrency);
            this.Controls.Add(this.labelAmountCurrency);
            this.Controls.Add(this.textAmountValue);
            this.Controls.Add(this.labelAmountValue);
            this.Controls.Add(this.groupAmount);
            this.Controls.Add(this.textDestination);
            this.Controls.Add(this.labelDestination);
            this.Controls.Add(this.textDestinationTag);
            this.Controls.Add(this.labelDestinationTag);
            this.Controls.Add(this.textSourceTag);
            this.Controls.Add(this.labelSourceTag);
            this.Controls.Add(this.groupFlags);
            this.Controls.Add(this.textLastLedgerSequence);
            this.Controls.Add(this.labelLastLedgerSequence);
            this.Controls.Add(this.textSequence);
            this.Controls.Add(this.labelSequence);
            this.Controls.Add(this.textFee);
            this.Controls.Add(this.labelFee);
            this.Controls.Add(this.textAccount);
            this.Controls.Add(this.labelAccount);
            this.Controls.Add(this.buttonSubmit);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "SubmitPaymentForm";
            this.Text = "Submit Payment";
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource)).EndInit();
            this.groupFlags.ResumeLayout(false);
            this.groupFlags.PerformLayout();
            this.groupAmount.ResumeLayout(false);
            this.groupAmount.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource bindingSource;
        private System.Windows.Forms.Button buttonSubmit;
        private System.Windows.Forms.Label labelAccount;
        private System.Windows.Forms.TextBox textAccount;
        private System.Windows.Forms.Label labelFee;
        private System.Windows.Forms.TextBox textFee;
        private System.Windows.Forms.Label labelSequence;
        private System.Windows.Forms.TextBox textSequence;
        private System.Windows.Forms.Label labelLastLedgerSequence;
        private System.Windows.Forms.TextBox textLastLedgerSequence;
        private System.Windows.Forms.GroupBox groupFlags;
        private System.Windows.Forms.CheckBox checkFullyCanonicalSig;
        private System.Windows.Forms.CheckBox checkNoRippleDirect;
        private System.Windows.Forms.CheckBox checkPartialPayment;
        private System.Windows.Forms.CheckBox checkLimitQuality;
        private System.Windows.Forms.Label labelSourceTag;
        private System.Windows.Forms.TextBox textSourceTag;
        private System.Windows.Forms.Label labelDestinationTag;
        private System.Windows.Forms.TextBox textDestinationTag;
        private System.Windows.Forms.Label labelDestination;
        private System.Windows.Forms.TextBox textDestination;
        private System.Windows.Forms.GroupBox groupAmount;
        private System.Windows.Forms.RadioButton radioAmountIsIssued;
        private System.Windows.Forms.RadioButton radioAmountIsNative;
        private System.Windows.Forms.Label labelAmountValue;
        private System.Windows.Forms.TextBox textAmountValue;
        private System.Windows.Forms.Label labelAmountCurrency;
        private System.Windows.Forms.TextBox textAmountCurrency;
        private System.Windows.Forms.Label labelAmountIssuer;
        private System.Windows.Forms.TextBox textAmountIssuer;
    }
}