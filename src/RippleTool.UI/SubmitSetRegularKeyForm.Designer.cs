namespace RippleTool.UI
{
    partial class SubmitSetRegularKeyForm
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
            this.labelRegularKey = new System.Windows.Forms.Label();
            this.textRegularKey = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource)).BeginInit();
            this.groupFlags.SuspendLayout();
            this.SuspendLayout();
            // 
            // bindingSource
            // 
            this.bindingSource.DataSource = typeof(RippleTool.UI.Models.SubmitSetRegularKeyModel);
            // 
            // buttonSubmit
            // 
            this.buttonSubmit.Location = new System.Drawing.Point(12, 288);
            this.buttonSubmit.Name = "buttonSubmit";
            this.buttonSubmit.Size = new System.Drawing.Size(100, 25);
            this.buttonSubmit.TabIndex = 11;
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
            this.groupFlags.Location = new System.Drawing.Point(12, 188);
            this.groupFlags.Name = "groupFlags";
            this.groupFlags.Padding = new System.Windows.Forms.Padding(6, 3, 6, 6);
            this.groupFlags.Size = new System.Drawing.Size(260, 50);
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
            // labelRegularKey
            // 
            this.labelRegularKey.AutoSize = true;
            this.labelRegularKey.Location = new System.Drawing.Point(12, 241);
            this.labelRegularKey.Name = "labelRegularKey";
            this.labelRegularKey.Size = new System.Drawing.Size(126, 15);
            this.labelRegularKey.TabIndex = 9;
            this.labelRegularKey.Text = "Regular key (optional):";
            // 
            // textRegularKey
            // 
            this.textRegularKey.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSource, "RegularKey", true));
            this.textRegularKey.Location = new System.Drawing.Point(12, 259);
            this.textRegularKey.Name = "textRegularKey";
            this.textRegularKey.Size = new System.Drawing.Size(260, 23);
            this.textRegularKey.TabIndex = 10;
            // 
            // SubmitSetRegularKeyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 862);
            this.Controls.Add(this.textRegularKey);
            this.Controls.Add(this.labelRegularKey);
            this.Controls.Add(this.buttonSubmit);
            this.Controls.Add(this.groupFlags);
            this.Controls.Add(this.textLastLedgerSequence);
            this.Controls.Add(this.labelLastLedgerSequence);
            this.Controls.Add(this.textSequence);
            this.Controls.Add(this.labelSequence);
            this.Controls.Add(this.textFee);
            this.Controls.Add(this.labelFee);
            this.Controls.Add(this.textAccount);
            this.Controls.Add(this.labelAccount);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "SubmitSetRegularKeyForm";
            this.Text = "Submit Set Regular Key";
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
        private System.Windows.Forms.Label labelRegularKey;
        private System.Windows.Forms.TextBox textRegularKey;
    }
}