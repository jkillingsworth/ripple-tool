namespace RippleTool.UI
{
    partial class SubmitAccountSetForm
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
            this.bindingSourceSetFlagOptions = new System.Windows.Forms.BindingSource(this.components);
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
            this.labelSetFlag = new System.Windows.Forms.Label();
            this.comboSetFlag = new System.Windows.Forms.ComboBox();
            this.labelClearFlag = new System.Windows.Forms.Label();
            this.comboClearFlag = new System.Windows.Forms.ComboBox();
            this.labelTransferRate = new System.Windows.Forms.Label();
            this.textTransferRate = new System.Windows.Forms.TextBox();
            this.bindingSourceClearFlagOptions = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceSetFlagOptions)).BeginInit();
            this.groupFlags.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceClearFlagOptions)).BeginInit();
            this.SuspendLayout();
            // 
            // bindingSource
            // 
            this.bindingSource.DataSource = typeof(RippleTool.UI.Models.SubmitAccountSetModel);
            // 
            // bindingSourceSetFlagOptions
            // 
            this.bindingSourceSetFlagOptions.DataSource = typeof(RippleTool.UI.Models.AccountSetFlagOptions);
            // 
            // buttonSubmit
            // 
            this.buttonSubmit.Location = new System.Drawing.Point(12, 376);
            this.buttonSubmit.Name = "buttonSubmit";
            this.buttonSubmit.Size = new System.Drawing.Size(100, 25);
            this.buttonSubmit.TabIndex = 15;
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
            // labelSetFlag
            // 
            this.labelSetFlag.AutoSize = true;
            this.labelSetFlag.Location = new System.Drawing.Point(12, 241);
            this.labelSetFlag.Name = "labelSetFlag";
            this.labelSetFlag.Size = new System.Drawing.Size(104, 15);
            this.labelSetFlag.TabIndex = 9;
            this.labelSetFlag.Text = "Set flag (optional):";
            // 
            // comboSetFlag
            // 
            this.comboSetFlag.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.bindingSource, "SetFlag", true));
            this.comboSetFlag.DataSource = this.bindingSourceSetFlagOptions;
            this.comboSetFlag.DisplayMember = "Display";
            this.comboSetFlag.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboSetFlag.FormattingEnabled = true;
            this.comboSetFlag.Location = new System.Drawing.Point(12, 259);
            this.comboSetFlag.Name = "comboSetFlag";
            this.comboSetFlag.Size = new System.Drawing.Size(260, 23);
            this.comboSetFlag.TabIndex = 10;
            this.comboSetFlag.ValueMember = "Value";
            // 
            // labelClearFlag
            // 
            this.labelClearFlag.AutoSize = true;
            this.labelClearFlag.Location = new System.Drawing.Point(12, 285);
            this.labelClearFlag.Name = "labelClearFlag";
            this.labelClearFlag.Size = new System.Drawing.Size(115, 15);
            this.labelClearFlag.TabIndex = 11;
            this.labelClearFlag.Text = "Clear flag (optional):";
            // 
            // comboClearFlag
            // 
            this.comboClearFlag.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.bindingSource, "ClearFlag", true));
            this.comboClearFlag.DataSource = this.bindingSourceClearFlagOptions;
            this.comboClearFlag.DisplayMember = "Display";
            this.comboClearFlag.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboClearFlag.FormattingEnabled = true;
            this.comboClearFlag.Location = new System.Drawing.Point(12, 303);
            this.comboClearFlag.Name = "comboClearFlag";
            this.comboClearFlag.Size = new System.Drawing.Size(260, 23);
            this.comboClearFlag.TabIndex = 12;
            this.comboClearFlag.ValueMember = "Value";
            // 
            // labelTransferRate
            // 
            this.labelTransferRate.AutoSize = true;
            this.labelTransferRate.Location = new System.Drawing.Point(12, 329);
            this.labelTransferRate.Name = "labelTransferRate";
            this.labelTransferRate.Size = new System.Drawing.Size(131, 15);
            this.labelTransferRate.TabIndex = 13;
            this.labelTransferRate.Text = "Transfer rate (optional):";
            // 
            // textTransferRate
            // 
            this.textTransferRate.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSource, "TransferRate", true));
            this.textTransferRate.Location = new System.Drawing.Point(12, 347);
            this.textTransferRate.Name = "textTransferRate";
            this.textTransferRate.Size = new System.Drawing.Size(260, 23);
            this.textTransferRate.TabIndex = 14;
            // 
            // bindingSourceClearFlagOptions
            // 
            this.bindingSourceClearFlagOptions.DataSource = typeof(RippleTool.UI.Models.AccountSetFlagOptions);
            // 
            // SubmitAccountSetForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 862);
            this.Controls.Add(this.textTransferRate);
            this.Controls.Add(this.labelTransferRate);
            this.Controls.Add(this.comboClearFlag);
            this.Controls.Add(this.labelClearFlag);
            this.Controls.Add(this.comboSetFlag);
            this.Controls.Add(this.labelSetFlag);
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
            this.Name = "SubmitAccountSetForm";
            this.Text = "Submit Account Set";
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceSetFlagOptions)).EndInit();
            this.groupFlags.ResumeLayout(false);
            this.groupFlags.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceClearFlagOptions)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource bindingSource;
        private System.Windows.Forms.BindingSource bindingSourceSetFlagOptions;
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
        private System.Windows.Forms.Label labelSetFlag;
        private System.Windows.Forms.ComboBox comboSetFlag;
        private System.Windows.Forms.Label labelClearFlag;
        private System.Windows.Forms.ComboBox comboClearFlag;
        private System.Windows.Forms.Label labelTransferRate;
        private System.Windows.Forms.TextBox textTransferRate;
        private System.Windows.Forms.BindingSource bindingSourceClearFlagOptions;
    }
}