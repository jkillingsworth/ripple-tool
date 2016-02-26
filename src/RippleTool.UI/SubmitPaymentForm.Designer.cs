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
            this.buttonSubmit = new System.Windows.Forms.Button();
            this.labelAccount = new System.Windows.Forms.Label();
            this.textAccount = new System.Windows.Forms.TextBox();
            this.labelFee = new System.Windows.Forms.Label();
            this.textFee = new System.Windows.Forms.TextBox();
            this.labelSequence = new System.Windows.Forms.Label();
            this.textSequence = new System.Windows.Forms.TextBox();
            this.groupFlags = new System.Windows.Forms.GroupBox();
            this.checkFullyCanonicalSig = new System.Windows.Forms.CheckBox();
            this.labelDestination = new System.Windows.Forms.Label();
            this.textDestination = new System.Windows.Forms.TextBox();
            this.groupAmount = new System.Windows.Forms.GroupBox();
            this.radioNative = new System.Windows.Forms.RadioButton();
            this.radioIssued = new System.Windows.Forms.RadioButton();
            this.labelAmountValue = new System.Windows.Forms.Label();
            this.textAmountValue = new System.Windows.Forms.TextBox();
            this.labelAmountCurrency = new System.Windows.Forms.Label();
            this.textAmountCurrency = new System.Windows.Forms.TextBox();
            this.labelAmountIssuer = new System.Windows.Forms.Label();
            this.textAmountIssuer = new System.Windows.Forms.TextBox();
            this.groupFlags.SuspendLayout();
            this.groupAmount.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonSubmit
            // 
            this.buttonSubmit.Location = new System.Drawing.Point(12, 432);
            this.buttonSubmit.Name = "buttonSubmit";
            this.buttonSubmit.Size = new System.Drawing.Size(100, 25);
            this.buttonSubmit.TabIndex = 16;
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
            this.textSequence.Location = new System.Drawing.Point(12, 115);
            this.textSequence.Name = "textSequence";
            this.textSequence.Size = new System.Drawing.Size(260, 23);
            this.textSequence.TabIndex = 5;
            // 
            // groupFlags
            // 
            this.groupFlags.Controls.Add(this.checkFullyCanonicalSig);
            this.groupFlags.Location = new System.Drawing.Point(12, 144);
            this.groupFlags.Name = "groupFlags";
            this.groupFlags.Padding = new System.Windows.Forms.Padding(6, 3, 6, 6);
            this.groupFlags.Size = new System.Drawing.Size(260, 50);
            this.groupFlags.TabIndex = 6;
            this.groupFlags.TabStop = false;
            this.groupFlags.Text = "Flags";
            // 
            // checkFullyCanonicalSig
            // 
            this.checkFullyCanonicalSig.AutoSize = true;
            this.checkFullyCanonicalSig.Checked = true;
            this.checkFullyCanonicalSig.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkFullyCanonicalSig.Location = new System.Drawing.Point(9, 22);
            this.checkFullyCanonicalSig.Name = "checkFullyCanonicalSig";
            this.checkFullyCanonicalSig.Size = new System.Drawing.Size(157, 19);
            this.checkFullyCanonicalSig.TabIndex = 0;
            this.checkFullyCanonicalSig.Text = "Fully canonical signature";
            this.checkFullyCanonicalSig.UseVisualStyleBackColor = true;
            // 
            // labelDestination
            // 
            this.labelDestination.AutoSize = true;
            this.labelDestination.Location = new System.Drawing.Point(12, 197);
            this.labelDestination.Name = "labelDestination";
            this.labelDestination.Size = new System.Drawing.Size(70, 15);
            this.labelDestination.TabIndex = 7;
            this.labelDestination.Text = "Destination:";
            // 
            // textDestination
            // 
            this.textDestination.Location = new System.Drawing.Point(12, 215);
            this.textDestination.Name = "textDestination";
            this.textDestination.Size = new System.Drawing.Size(260, 23);
            this.textDestination.TabIndex = 8;
            // 
            // groupAmount
            // 
            this.groupAmount.Controls.Add(this.radioNative);
            this.groupAmount.Controls.Add(this.radioIssued);
            this.groupAmount.Location = new System.Drawing.Point(12, 244);
            this.groupAmount.Name = "groupAmount";
            this.groupAmount.Padding = new System.Windows.Forms.Padding(6, 3, 6, 6);
            this.groupAmount.Size = new System.Drawing.Size(257, 50);
            this.groupAmount.TabIndex = 9;
            this.groupAmount.TabStop = false;
            this.groupAmount.Text = "Amount";
            // 
            // radioNative
            // 
            this.radioNative.AutoSize = true;
            this.radioNative.Location = new System.Drawing.Point(73, 22);
            this.radioNative.Name = "radioNative";
            this.radioNative.Size = new System.Drawing.Size(59, 19);
            this.radioNative.TabIndex = 1;
            this.radioNative.Text = "Native";
            this.radioNative.UseVisualStyleBackColor = true;
            this.radioNative.CheckedChanged += new System.EventHandler(this.radioNative_CheckedChanged);
            // 
            // radioIssued
            // 
            this.radioIssued.AutoSize = true;
            this.radioIssued.Checked = true;
            this.radioIssued.Location = new System.Drawing.Point(9, 22);
            this.radioIssued.Name = "radioIssued";
            this.radioIssued.Size = new System.Drawing.Size(58, 19);
            this.radioIssued.TabIndex = 0;
            this.radioIssued.TabStop = true;
            this.radioIssued.Text = "Issued";
            this.radioIssued.UseVisualStyleBackColor = true;
            this.radioIssued.CheckedChanged += new System.EventHandler(this.radioIssued_CheckedChanged);
            // 
            // labelAmountValue
            // 
            this.labelAmountValue.AutoSize = true;
            this.labelAmountValue.Location = new System.Drawing.Point(12, 297);
            this.labelAmountValue.Name = "labelAmountValue";
            this.labelAmountValue.Size = new System.Drawing.Size(85, 15);
            this.labelAmountValue.TabIndex = 10;
            this.labelAmountValue.Text = "Amount value:";
            // 
            // textAmountValue
            // 
            this.textAmountValue.Location = new System.Drawing.Point(12, 315);
            this.textAmountValue.Name = "textAmountValue";
            this.textAmountValue.Size = new System.Drawing.Size(260, 23);
            this.textAmountValue.TabIndex = 11;
            // 
            // labelAmountCurrency
            // 
            this.labelAmountCurrency.AutoSize = true;
            this.labelAmountCurrency.Location = new System.Drawing.Point(12, 341);
            this.labelAmountCurrency.Name = "labelAmountCurrency";
            this.labelAmountCurrency.Size = new System.Drawing.Size(103, 15);
            this.labelAmountCurrency.TabIndex = 12;
            this.labelAmountCurrency.Text = "Amount currency:";
            // 
            // textAmountCurrency
            // 
            this.textAmountCurrency.Location = new System.Drawing.Point(12, 359);
            this.textAmountCurrency.Name = "textAmountCurrency";
            this.textAmountCurrency.Size = new System.Drawing.Size(260, 23);
            this.textAmountCurrency.TabIndex = 13;
            // 
            // labelAmountIssuer
            // 
            this.labelAmountIssuer.AutoSize = true;
            this.labelAmountIssuer.Location = new System.Drawing.Point(12, 385);
            this.labelAmountIssuer.Name = "labelAmountIssuer";
            this.labelAmountIssuer.Size = new System.Drawing.Size(87, 15);
            this.labelAmountIssuer.TabIndex = 14;
            this.labelAmountIssuer.Text = "Amount issuer:";
            // 
            // textAmountIssuer
            // 
            this.textAmountIssuer.Location = new System.Drawing.Point(12, 403);
            this.textAmountIssuer.Name = "textAmountIssuer";
            this.textAmountIssuer.Size = new System.Drawing.Size(260, 23);
            this.textAmountIssuer.TabIndex = 15;
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
            this.Controls.Add(this.groupFlags);
            this.Controls.Add(this.textSequence);
            this.Controls.Add(this.labelSequence);
            this.Controls.Add(this.textFee);
            this.Controls.Add(this.labelFee);
            this.Controls.Add(this.textAccount);
            this.Controls.Add(this.labelAccount);
            this.Controls.Add(this.buttonSubmit);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "SubmitPaymentForm";
            this.Text = "Payment";
            this.groupFlags.ResumeLayout(false);
            this.groupFlags.PerformLayout();
            this.groupAmount.ResumeLayout(false);
            this.groupAmount.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonSubmit;
        private System.Windows.Forms.Label labelAccount;
        private System.Windows.Forms.TextBox textAccount;
        private System.Windows.Forms.Label labelFee;
        private System.Windows.Forms.TextBox textFee;
        private System.Windows.Forms.Label labelSequence;
        private System.Windows.Forms.TextBox textSequence;
        private System.Windows.Forms.GroupBox groupFlags;
        private System.Windows.Forms.CheckBox checkFullyCanonicalSig;
        private System.Windows.Forms.Label labelDestination;
        private System.Windows.Forms.TextBox textDestination;
        private System.Windows.Forms.GroupBox groupAmount;
        private System.Windows.Forms.RadioButton radioIssued;
        private System.Windows.Forms.RadioButton radioNative;
        private System.Windows.Forms.Label labelAmountValue;
        private System.Windows.Forms.TextBox textAmountValue;
        private System.Windows.Forms.Label labelAmountCurrency;
        private System.Windows.Forms.TextBox textAmountCurrency;
        private System.Windows.Forms.Label labelAmountIssuer;
        private System.Windows.Forms.TextBox textAmountIssuer;
    }
}