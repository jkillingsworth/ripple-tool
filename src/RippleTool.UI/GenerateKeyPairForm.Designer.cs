namespace RippleTool.UI
{
    partial class GenerateKeyPairForm
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
            this.buttonClose = new System.Windows.Forms.Button();
            this.groupEntropySource = new System.Windows.Forms.GroupBox();
            this.radioRandomNumberGenerator = new System.Windows.Forms.RadioButton();
            this.radioPassphrase = new System.Windows.Forms.RadioButton();
            this.textPassphrase = new System.Windows.Forms.TextBox();
            this.buttonGenerate = new System.Windows.Forms.Button();
            this.buttonReset = new System.Windows.Forms.Button();
            this.groupKeyPair = new System.Windows.Forms.GroupBox();
            this.labelAccountId = new System.Windows.Forms.Label();
            this.textAccountId = new System.Windows.Forms.TextBox();
            this.labelSecretKey = new System.Windows.Forms.Label();
            this.textSecretKey = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource)).BeginInit();
            this.groupEntropySource.SuspendLayout();
            this.groupKeyPair.SuspendLayout();
            this.SuspendLayout();
            // 
            // bindingSource
            // 
            this.bindingSource.DataSource = typeof(RippleTool.UI.Models.GenerateKeyPairModel);
            // 
            // buttonClose
            // 
            this.buttonClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonClose.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonClose.Location = new System.Drawing.Point(292, 275);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(100, 25);
            this.buttonClose.TabIndex = 4;
            this.buttonClose.Text = "&Close";
            this.buttonClose.UseVisualStyleBackColor = true;
            // 
            // groupEntropySource
            // 
            this.groupEntropySource.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupEntropySource.Controls.Add(this.radioRandomNumberGenerator);
            this.groupEntropySource.Controls.Add(this.radioPassphrase);
            this.groupEntropySource.Controls.Add(this.textPassphrase);
            this.groupEntropySource.Location = new System.Drawing.Point(12, 12);
            this.groupEntropySource.Name = "groupEntropySource";
            this.groupEntropySource.Padding = new System.Windows.Forms.Padding(6, 3, 6, 6);
            this.groupEntropySource.Size = new System.Drawing.Size(380, 104);
            this.groupEntropySource.TabIndex = 0;
            this.groupEntropySource.TabStop = false;
            this.groupEntropySource.Text = "Entropy source";
            // 
            // radioRandomNumberGenerator
            // 
            this.radioRandomNumberGenerator.AutoSize = true;
            this.radioRandomNumberGenerator.Checked = true;
            this.radioRandomNumberGenerator.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.bindingSource, "EntropyFromRandNumber", true));
            this.radioRandomNumberGenerator.Location = new System.Drawing.Point(9, 22);
            this.radioRandomNumberGenerator.Name = "radioRandomNumberGenerator";
            this.radioRandomNumberGenerator.Size = new System.Drawing.Size(169, 19);
            this.radioRandomNumberGenerator.TabIndex = 0;
            this.radioRandomNumberGenerator.TabStop = true;
            this.radioRandomNumberGenerator.Text = "Random number generator";
            this.radioRandomNumberGenerator.UseVisualStyleBackColor = true;
            // 
            // radioPassphrase
            // 
            this.radioPassphrase.AutoSize = true;
            this.radioPassphrase.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.bindingSource, "EntropyFromPassphrase", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.radioPassphrase.Location = new System.Drawing.Point(9, 47);
            this.radioPassphrase.Name = "radioPassphrase";
            this.radioPassphrase.Size = new System.Drawing.Size(83, 19);
            this.radioPassphrase.TabIndex = 1;
            this.radioPassphrase.Text = "Passphrase";
            this.radioPassphrase.UseVisualStyleBackColor = true;
            // 
            // textPassphrase
            // 
            this.textPassphrase.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textPassphrase.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSource, "Passphrase", true));
            this.textPassphrase.DataBindings.Add(new System.Windows.Forms.Binding("Enabled", this.bindingSource, "EntropyFromPassphrase", true));
            this.textPassphrase.Location = new System.Drawing.Point(9, 72);
            this.textPassphrase.Name = "textPassphrase";
            this.textPassphrase.Size = new System.Drawing.Size(362, 23);
            this.textPassphrase.TabIndex = 2;
            this.textPassphrase.Text = "masterpassphrase";
            // 
            // buttonGenerate
            // 
            this.buttonGenerate.Location = new System.Drawing.Point(12, 122);
            this.buttonGenerate.Name = "buttonGenerate";
            this.buttonGenerate.Size = new System.Drawing.Size(100, 25);
            this.buttonGenerate.TabIndex = 1;
            this.buttonGenerate.Text = "&Generate";
            this.buttonGenerate.UseVisualStyleBackColor = true;
            this.buttonGenerate.Click += new System.EventHandler(this.buttonGenerate_Click);
            // 
            // buttonReset
            // 
            this.buttonReset.Location = new System.Drawing.Point(118, 122);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(100, 25);
            this.buttonReset.TabIndex = 2;
            this.buttonReset.Text = "&Reset";
            this.buttonReset.UseVisualStyleBackColor = true;
            this.buttonReset.Click += new System.EventHandler(this.buttonReset_Click);
            // 
            // groupKeyPair
            // 
            this.groupKeyPair.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupKeyPair.Controls.Add(this.labelAccountId);
            this.groupKeyPair.Controls.Add(this.textAccountId);
            this.groupKeyPair.Controls.Add(this.labelSecretKey);
            this.groupKeyPair.Controls.Add(this.textSecretKey);
            this.groupKeyPair.Location = new System.Drawing.Point(12, 153);
            this.groupKeyPair.Name = "groupKeyPair";
            this.groupKeyPair.Padding = new System.Windows.Forms.Padding(6, 3, 6, 6);
            this.groupKeyPair.Size = new System.Drawing.Size(380, 86);
            this.groupKeyPair.TabIndex = 3;
            this.groupKeyPair.TabStop = false;
            this.groupKeyPair.Text = "Key pair";
            // 
            // labelAccountId
            // 
            this.labelAccountId.Location = new System.Drawing.Point(9, 25);
            this.labelAccountId.Name = "labelAccountId";
            this.labelAccountId.Size = new System.Drawing.Size(70, 15);
            this.labelAccountId.TabIndex = 0;
            this.labelAccountId.Text = "Account ID:";
            // 
            // textAccountId
            // 
            this.textAccountId.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textAccountId.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSource, "AccountId", true));
            this.textAccountId.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textAccountId.Location = new System.Drawing.Point(85, 22);
            this.textAccountId.Name = "textAccountId";
            this.textAccountId.ReadOnly = true;
            this.textAccountId.Size = new System.Drawing.Size(286, 22);
            this.textAccountId.TabIndex = 1;
            this.textAccountId.Text = "rHb9CJAWyB4rj91VRWn96DkukG4bwdtyTh";
            // 
            // labelSecretKey
            // 
            this.labelSecretKey.Location = new System.Drawing.Point(9, 54);
            this.labelSecretKey.Name = "labelSecretKey";
            this.labelSecretKey.Size = new System.Drawing.Size(70, 15);
            this.labelSecretKey.TabIndex = 2;
            this.labelSecretKey.Text = "Secret key:";
            // 
            // textSecretKey
            // 
            this.textSecretKey.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textSecretKey.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSource, "SecreyKey", true));
            this.textSecretKey.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textSecretKey.Location = new System.Drawing.Point(85, 54);
            this.textSecretKey.Name = "textSecretKey";
            this.textSecretKey.ReadOnly = true;
            this.textSecretKey.Size = new System.Drawing.Size(286, 22);
            this.textSecretKey.TabIndex = 3;
            this.textSecretKey.Text = "snoPBrXtMeMyMHUVTgbuqAfg1SUTb";
            // 
            // GenerateKeyPairForm
            // 
            this.AcceptButton = this.buttonGenerate;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.buttonClose;
            this.ClientSize = new System.Drawing.Size(404, 312);
            this.Controls.Add(this.groupKeyPair);
            this.Controls.Add(this.buttonReset);
            this.Controls.Add(this.buttonGenerate);
            this.Controls.Add(this.groupEntropySource);
            this.Controls.Add(this.buttonClose);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "GenerateKeyPairForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Generate Key Pair";
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource)).EndInit();
            this.groupEntropySource.ResumeLayout(false);
            this.groupEntropySource.PerformLayout();
            this.groupKeyPair.ResumeLayout(false);
            this.groupKeyPair.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource bindingSource;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.GroupBox groupEntropySource;
        private System.Windows.Forms.RadioButton radioRandomNumberGenerator;
        private System.Windows.Forms.RadioButton radioPassphrase;
        private System.Windows.Forms.TextBox textPassphrase;
        private System.Windows.Forms.Button buttonGenerate;
        private System.Windows.Forms.Button buttonReset;
        private System.Windows.Forms.GroupBox groupKeyPair;
        private System.Windows.Forms.Label labelAccountId;
        private System.Windows.Forms.TextBox textAccountId;
        private System.Windows.Forms.Label labelSecretKey;
        private System.Windows.Forms.TextBox textSecretKey;
    }
}