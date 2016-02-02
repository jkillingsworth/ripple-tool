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
            this.buttonSubmit = new System.Windows.Forms.Button();
            this.labelAccount = new System.Windows.Forms.Label();
            this.textAccount = new System.Windows.Forms.TextBox();
            this.labelFee = new System.Windows.Forms.Label();
            this.textFee = new System.Windows.Forms.TextBox();
            this.labelSequence = new System.Windows.Forms.Label();
            this.textSequence = new System.Windows.Forms.TextBox();
            this.groupFlags = new System.Windows.Forms.GroupBox();
            this.checkFullyCanonicalSig = new System.Windows.Forms.CheckBox();
            this.checkSetNoRipple = new System.Windows.Forms.CheckBox();
            this.checkClearNoRipple = new System.Windows.Forms.CheckBox();
            this.labelLimitAmountValue = new System.Windows.Forms.Label();
            this.textLimitAmountValue = new System.Windows.Forms.TextBox();
            this.labelLimitAmountCurrency = new System.Windows.Forms.Label();
            this.textLimitAmountCurrency = new System.Windows.Forms.TextBox();
            this.labelLimitAmountIssuer = new System.Windows.Forms.Label();
            this.textLimitAmountIssuer = new System.Windows.Forms.TextBox();
            this.groupFlags.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonSubmit
            // 
            this.buttonSubmit.Location = new System.Drawing.Point(12, 379);
            this.buttonSubmit.Name = "buttonSubmit";
            this.buttonSubmit.Size = new System.Drawing.Size(100, 25);
            this.buttonSubmit.TabIndex = 13;
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
            this.groupFlags.Controls.Add(this.checkSetNoRipple);
            this.groupFlags.Controls.Add(this.checkClearNoRipple);
            this.groupFlags.Location = new System.Drawing.Point(12, 144);
            this.groupFlags.Name = "groupFlags";
            this.groupFlags.Size = new System.Drawing.Size(260, 97);
            this.groupFlags.TabIndex = 6;
            this.groupFlags.TabStop = false;
            this.groupFlags.Text = "Flags";
            // 
            // checkFullyCanonicalSig
            // 
            this.checkFullyCanonicalSig.AutoSize = true;
            this.checkFullyCanonicalSig.Checked = true;
            this.checkFullyCanonicalSig.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkFullyCanonicalSig.Location = new System.Drawing.Point(6, 22);
            this.checkFullyCanonicalSig.Name = "checkFullyCanonicalSig";
            this.checkFullyCanonicalSig.Size = new System.Drawing.Size(157, 19);
            this.checkFullyCanonicalSig.TabIndex = 0;
            this.checkFullyCanonicalSig.Text = "Fully canonical signature";
            this.checkFullyCanonicalSig.UseVisualStyleBackColor = true;
            // 
            // checkSetNoRipple
            // 
            this.checkSetNoRipple.AutoSize = true;
            this.checkSetNoRipple.Location = new System.Drawing.Point(6, 47);
            this.checkSetNoRipple.Name = "checkSetNoRipple";
            this.checkSetNoRipple.Size = new System.Drawing.Size(92, 19);
            this.checkSetNoRipple.TabIndex = 1;
            this.checkSetNoRipple.Text = "Set no ripple";
            this.checkSetNoRipple.UseVisualStyleBackColor = true;
            // 
            // checkClearNoRipple
            // 
            this.checkClearNoRipple.AutoSize = true;
            this.checkClearNoRipple.Location = new System.Drawing.Point(6, 72);
            this.checkClearNoRipple.Name = "checkClearNoRipple";
            this.checkClearNoRipple.Size = new System.Drawing.Size(103, 19);
            this.checkClearNoRipple.TabIndex = 2;
            this.checkClearNoRipple.Text = "Clear no ripple";
            this.checkClearNoRipple.UseVisualStyleBackColor = true;
            // 
            // labelLimitAmountValue
            // 
            this.labelLimitAmountValue.AutoSize = true;
            this.labelLimitAmountValue.Location = new System.Drawing.Point(12, 244);
            this.labelLimitAmountValue.Name = "labelLimitAmountValue";
            this.labelLimitAmountValue.Size = new System.Drawing.Size(113, 15);
            this.labelLimitAmountValue.TabIndex = 7;
            this.labelLimitAmountValue.Text = "Limit amount value:";
            // 
            // textLimitAmountValue
            // 
            this.textLimitAmountValue.Location = new System.Drawing.Point(12, 262);
            this.textLimitAmountValue.Name = "textLimitAmountValue";
            this.textLimitAmountValue.Size = new System.Drawing.Size(260, 23);
            this.textLimitAmountValue.TabIndex = 8;
            // 
            // labelLimitAmountCurrency
            // 
            this.labelLimitAmountCurrency.AutoSize = true;
            this.labelLimitAmountCurrency.Location = new System.Drawing.Point(12, 288);
            this.labelLimitAmountCurrency.Name = "labelLimitAmountCurrency";
            this.labelLimitAmountCurrency.Size = new System.Drawing.Size(131, 15);
            this.labelLimitAmountCurrency.TabIndex = 9;
            this.labelLimitAmountCurrency.Text = "Limit amount currency:";
            // 
            // textLimitAmountCurrency
            // 
            this.textLimitAmountCurrency.Location = new System.Drawing.Point(12, 306);
            this.textLimitAmountCurrency.Name = "textLimitAmountCurrency";
            this.textLimitAmountCurrency.Size = new System.Drawing.Size(260, 23);
            this.textLimitAmountCurrency.TabIndex = 10;
            // 
            // labelLimitAmountIssuer
            // 
            this.labelLimitAmountIssuer.AutoSize = true;
            this.labelLimitAmountIssuer.Location = new System.Drawing.Point(12, 332);
            this.labelLimitAmountIssuer.Name = "labelLimitAmountIssuer";
            this.labelLimitAmountIssuer.Size = new System.Drawing.Size(115, 15);
            this.labelLimitAmountIssuer.TabIndex = 11;
            this.labelLimitAmountIssuer.Text = "Limit amount issuer:";
            // 
            // textLimitAmountIssuer
            // 
            this.textLimitAmountIssuer.Location = new System.Drawing.Point(12, 350);
            this.textLimitAmountIssuer.Name = "textLimitAmountIssuer";
            this.textLimitAmountIssuer.Size = new System.Drawing.Size(260, 23);
            this.textLimitAmountIssuer.TabIndex = 12;
            // 
            // SubmitTrustSetForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 462);
            this.Controls.Add(this.textLimitAmountIssuer);
            this.Controls.Add(this.labelLimitAmountIssuer);
            this.Controls.Add(this.labelLimitAmountCurrency);
            this.Controls.Add(this.textLimitAmountCurrency);
            this.Controls.Add(this.groupFlags);
            this.Controls.Add(this.textSequence);
            this.Controls.Add(this.labelSequence);
            this.Controls.Add(this.textLimitAmountValue);
            this.Controls.Add(this.textFee);
            this.Controls.Add(this.labelLimitAmountValue);
            this.Controls.Add(this.labelFee);
            this.Controls.Add(this.textAccount);
            this.Controls.Add(this.labelAccount);
            this.Controls.Add(this.buttonSubmit);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "SubmitTrustSetForm";
            this.Text = "Trust Set";
            this.groupFlags.ResumeLayout(false);
            this.groupFlags.PerformLayout();
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
        private System.Windows.Forms.CheckBox checkSetNoRipple;
        private System.Windows.Forms.CheckBox checkClearNoRipple;
        private System.Windows.Forms.Label labelLimitAmountValue;
        private System.Windows.Forms.TextBox textLimitAmountValue;
        private System.Windows.Forms.Label labelLimitAmountCurrency;
        private System.Windows.Forms.TextBox textLimitAmountCurrency;
        private System.Windows.Forms.Label labelLimitAmountIssuer;
        private System.Windows.Forms.TextBox textLimitAmountIssuer;
    }
}