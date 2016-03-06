namespace RippleTool.UI
{
    partial class SubmitTrustSetForm
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
            this.checkSetAuth = new System.Windows.Forms.CheckBox();
            this.checkSetNoRipple = new System.Windows.Forms.CheckBox();
            this.checkClearNoRipple = new System.Windows.Forms.CheckBox();
            this.checkSetFreeze = new System.Windows.Forms.CheckBox();
            this.checkClearFreeze = new System.Windows.Forms.CheckBox();
            this.labelLimitAmountValue = new System.Windows.Forms.Label();
            this.textLimitAmountValue = new System.Windows.Forms.TextBox();
            this.labelLimitAmountCurrency = new System.Windows.Forms.Label();
            this.textLimitAmountCurrency = new System.Windows.Forms.TextBox();
            this.labelLimitAmountIssuer = new System.Windows.Forms.Label();
            this.textLimitAmountIssuer = new System.Windows.Forms.TextBox();
            this.labelQualityIn = new System.Windows.Forms.Label();
            this.textQualityIn = new System.Windows.Forms.TextBox();
            this.labelQualityOut = new System.Windows.Forms.Label();
            this.textQualityOut = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource)).BeginInit();
            this.groupFlags.SuspendLayout();
            this.SuspendLayout();
            // 
            // bindingSource
            // 
            this.bindingSource.DataSource = typeof(RippleTool.UI.Models.SubmitTrustSetModel);
            // 
            // buttonSubmit
            // 
            this.buttonSubmit.Location = new System.Drawing.Point(12, 589);
            this.buttonSubmit.Name = "buttonSubmit";
            this.buttonSubmit.Size = new System.Drawing.Size(100, 25);
            this.buttonSubmit.TabIndex = 19;
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
            this.groupFlags.Controls.Add(this.checkSetAuth);
            this.groupFlags.Controls.Add(this.checkSetNoRipple);
            this.groupFlags.Controls.Add(this.checkClearNoRipple);
            this.groupFlags.Controls.Add(this.checkSetFreeze);
            this.groupFlags.Controls.Add(this.checkClearFreeze);
            this.groupFlags.Location = new System.Drawing.Point(12, 188);
            this.groupFlags.Name = "groupFlags";
            this.groupFlags.Padding = new System.Windows.Forms.Padding(6, 3, 6, 6);
            this.groupFlags.Size = new System.Drawing.Size(260, 175);
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
            // checkSetAuth
            // 
            this.checkSetAuth.AutoSize = true;
            this.checkSetAuth.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.bindingSource, "FlagSetAuth", true));
            this.checkSetAuth.Location = new System.Drawing.Point(9, 47);
            this.checkSetAuth.Name = "checkSetAuth";
            this.checkSetAuth.Size = new System.Drawing.Size(69, 19);
            this.checkSetAuth.TabIndex = 1;
            this.checkSetAuth.Text = "Set auth";
            this.checkSetAuth.UseVisualStyleBackColor = true;
            // 
            // checkSetNoRipple
            // 
            this.checkSetNoRipple.AutoSize = true;
            this.checkSetNoRipple.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.bindingSource, "FlagSetNoRipple", true));
            this.checkSetNoRipple.Location = new System.Drawing.Point(9, 72);
            this.checkSetNoRipple.Name = "checkSetNoRipple";
            this.checkSetNoRipple.Size = new System.Drawing.Size(92, 19);
            this.checkSetNoRipple.TabIndex = 2;
            this.checkSetNoRipple.Text = "Set no ripple";
            this.checkSetNoRipple.UseVisualStyleBackColor = true;
            // 
            // checkClearNoRipple
            // 
            this.checkClearNoRipple.AutoSize = true;
            this.checkClearNoRipple.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.bindingSource, "FlagClearNoRipple", true));
            this.checkClearNoRipple.Location = new System.Drawing.Point(9, 97);
            this.checkClearNoRipple.Name = "checkClearNoRipple";
            this.checkClearNoRipple.Size = new System.Drawing.Size(103, 19);
            this.checkClearNoRipple.TabIndex = 3;
            this.checkClearNoRipple.Text = "Clear no ripple";
            this.checkClearNoRipple.UseVisualStyleBackColor = true;
            // 
            // checkSetFreeze
            // 
            this.checkSetFreeze.AutoSize = true;
            this.checkSetFreeze.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.bindingSource, "FlagSetFreeze", true));
            this.checkSetFreeze.Location = new System.Drawing.Point(9, 122);
            this.checkSetFreeze.Name = "checkSetFreeze";
            this.checkSetFreeze.Size = new System.Drawing.Size(76, 19);
            this.checkSetFreeze.TabIndex = 4;
            this.checkSetFreeze.Text = "Set freeze";
            this.checkSetFreeze.UseVisualStyleBackColor = true;
            // 
            // checkClearFreeze
            // 
            this.checkClearFreeze.AutoSize = true;
            this.checkClearFreeze.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.bindingSource, "FlagClearFreeze", true));
            this.checkClearFreeze.Location = new System.Drawing.Point(9, 147);
            this.checkClearFreeze.Name = "checkClearFreeze";
            this.checkClearFreeze.Size = new System.Drawing.Size(87, 19);
            this.checkClearFreeze.TabIndex = 5;
            this.checkClearFreeze.Text = "Clear freeze";
            this.checkClearFreeze.UseVisualStyleBackColor = true;
            // 
            // labelLimitAmountValue
            // 
            this.labelLimitAmountValue.AutoSize = true;
            this.labelLimitAmountValue.Location = new System.Drawing.Point(12, 366);
            this.labelLimitAmountValue.Name = "labelLimitAmountValue";
            this.labelLimitAmountValue.Size = new System.Drawing.Size(113, 15);
            this.labelLimitAmountValue.TabIndex = 9;
            this.labelLimitAmountValue.Text = "Limit amount value:";
            // 
            // textLimitAmountValue
            // 
            this.textLimitAmountValue.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSource, "LimitAmountValue", true));
            this.textLimitAmountValue.Location = new System.Drawing.Point(12, 384);
            this.textLimitAmountValue.Name = "textLimitAmountValue";
            this.textLimitAmountValue.Size = new System.Drawing.Size(260, 23);
            this.textLimitAmountValue.TabIndex = 10;
            // 
            // labelLimitAmountCurrency
            // 
            this.labelLimitAmountCurrency.AutoSize = true;
            this.labelLimitAmountCurrency.Location = new System.Drawing.Point(12, 410);
            this.labelLimitAmountCurrency.Name = "labelLimitAmountCurrency";
            this.labelLimitAmountCurrency.Size = new System.Drawing.Size(131, 15);
            this.labelLimitAmountCurrency.TabIndex = 11;
            this.labelLimitAmountCurrency.Text = "Limit amount currency:";
            // 
            // textLimitAmountCurrency
            // 
            this.textLimitAmountCurrency.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSource, "LimitAmountCurrency", true));
            this.textLimitAmountCurrency.Location = new System.Drawing.Point(12, 428);
            this.textLimitAmountCurrency.Name = "textLimitAmountCurrency";
            this.textLimitAmountCurrency.Size = new System.Drawing.Size(260, 23);
            this.textLimitAmountCurrency.TabIndex = 12;
            // 
            // labelLimitAmountIssuer
            // 
            this.labelLimitAmountIssuer.AutoSize = true;
            this.labelLimitAmountIssuer.Location = new System.Drawing.Point(12, 454);
            this.labelLimitAmountIssuer.Name = "labelLimitAmountIssuer";
            this.labelLimitAmountIssuer.Size = new System.Drawing.Size(115, 15);
            this.labelLimitAmountIssuer.TabIndex = 13;
            this.labelLimitAmountIssuer.Text = "Limit amount issuer:";
            // 
            // textLimitAmountIssuer
            // 
            this.textLimitAmountIssuer.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSource, "LimitAmountIssuer", true));
            this.textLimitAmountIssuer.Location = new System.Drawing.Point(12, 472);
            this.textLimitAmountIssuer.Name = "textLimitAmountIssuer";
            this.textLimitAmountIssuer.Size = new System.Drawing.Size(260, 23);
            this.textLimitAmountIssuer.TabIndex = 14;
            // 
            // labelQualityIn
            // 
            this.labelQualityIn.AutoSize = true;
            this.labelQualityIn.Location = new System.Drawing.Point(12, 498);
            this.labelQualityIn.Name = "labelQualityIn";
            this.labelQualityIn.Size = new System.Drawing.Size(116, 15);
            this.labelQualityIn.TabIndex = 15;
            this.labelQualityIn.Text = "Quality in (optional):";
            // 
            // textQualityIn
            // 
            this.textQualityIn.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSource, "QualityIn", true));
            this.textQualityIn.Location = new System.Drawing.Point(12, 516);
            this.textQualityIn.Name = "textQualityIn";
            this.textQualityIn.Size = new System.Drawing.Size(260, 23);
            this.textQualityIn.TabIndex = 16;
            // 
            // labelQualityOut
            // 
            this.labelQualityOut.AutoSize = true;
            this.labelQualityOut.Location = new System.Drawing.Point(12, 542);
            this.labelQualityOut.Name = "labelQualityOut";
            this.labelQualityOut.Size = new System.Drawing.Size(124, 15);
            this.labelQualityOut.TabIndex = 17;
            this.labelQualityOut.Text = "Quality out (optional):";
            // 
            // textQualityOut
            // 
            this.textQualityOut.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSource, "QualityOut", true));
            this.textQualityOut.Location = new System.Drawing.Point(12, 560);
            this.textQualityOut.Name = "textQualityOut";
            this.textQualityOut.Size = new System.Drawing.Size(260, 23);
            this.textQualityOut.TabIndex = 18;
            // 
            // SubmitTrustSetForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 862);
            this.Controls.Add(this.textQualityOut);
            this.Controls.Add(this.labelQualityOut);
            this.Controls.Add(this.textQualityIn);
            this.Controls.Add(this.labelQualityIn);
            this.Controls.Add(this.textLimitAmountIssuer);
            this.Controls.Add(this.labelLimitAmountIssuer);
            this.Controls.Add(this.textLimitAmountCurrency);
            this.Controls.Add(this.labelLimitAmountCurrency);
            this.Controls.Add(this.textLimitAmountValue);
            this.Controls.Add(this.labelLimitAmountValue);
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
            this.Name = "SubmitTrustSetForm";
            this.Text = "Trust Set";
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource)).EndInit();
            this.groupFlags.ResumeLayout(false);
            this.groupFlags.PerformLayout();
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
        private System.Windows.Forms.CheckBox checkSetAuth;
        private System.Windows.Forms.CheckBox checkSetNoRipple;
        private System.Windows.Forms.CheckBox checkClearNoRipple;
        private System.Windows.Forms.CheckBox checkClearFreeze;
        private System.Windows.Forms.CheckBox checkSetFreeze;
        private System.Windows.Forms.Label labelLimitAmountValue;
        private System.Windows.Forms.TextBox textLimitAmountValue;
        private System.Windows.Forms.Label labelLimitAmountCurrency;
        private System.Windows.Forms.TextBox textLimitAmountCurrency;
        private System.Windows.Forms.Label labelLimitAmountIssuer;
        private System.Windows.Forms.TextBox textLimitAmountIssuer;
        private System.Windows.Forms.Label labelQualityIn;
        private System.Windows.Forms.TextBox textQualityIn;
        private System.Windows.Forms.Label labelQualityOut;
        private System.Windows.Forms.TextBox textQualityOut;
    }
}