namespace RippleTool.UI
{
    partial class SettingsForm
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
            this.buttonOK = new System.Windows.Forms.Button();
            this.labelServerUri = new System.Windows.Forms.Label();
            this.textServerUri = new System.Windows.Forms.TextBox();
            this.labelSecretKey = new System.Windows.Forms.Label();
            this.textSecretKey = new System.Windows.Forms.TextBox();
            this.labelAccountId = new System.Windows.Forms.Label();
            this.textAccountId = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // buttonOK
            // 
            this.buttonOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonOK.Location = new System.Drawing.Point(272, 125);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(100, 25);
            this.buttonOK.TabIndex = 0;
            this.buttonOK.Text = "OK";
            this.buttonOK.UseVisualStyleBackColor = true;
            // 
            // labelServerUri
            // 
            this.labelServerUri.Location = new System.Drawing.Point(12, 14);
            this.labelServerUri.Name = "labelServerUri";
            this.labelServerUri.Size = new System.Drawing.Size(70, 15);
            this.labelServerUri.TabIndex = 1;
            this.labelServerUri.Text = "Server URI:";
            // 
            // textServerUri
            // 
            this.textServerUri.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textServerUri.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textServerUri.Location = new System.Drawing.Point(88, 12);
            this.textServerUri.Name = "textServerUri";
            this.textServerUri.ReadOnly = true;
            this.textServerUri.Size = new System.Drawing.Size(284, 22);
            this.textServerUri.TabIndex = 2;
            this.textServerUri.Text = "wss://s1.ripple.com";
            // 
            // labelSecretKey
            // 
            this.labelSecretKey.Location = new System.Drawing.Point(12, 43);
            this.labelSecretKey.Name = "labelSecretKey";
            this.labelSecretKey.Size = new System.Drawing.Size(70, 15);
            this.labelSecretKey.TabIndex = 3;
            this.labelSecretKey.Text = "Secret Key:";
            // 
            // textSecretKey
            // 
            this.textSecretKey.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textSecretKey.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textSecretKey.Location = new System.Drawing.Point(88, 41);
            this.textSecretKey.Name = "textSecretKey";
            this.textSecretKey.ReadOnly = true;
            this.textSecretKey.Size = new System.Drawing.Size(284, 22);
            this.textSecretKey.TabIndex = 4;
            this.textSecretKey.Text = "snoPBrXtMeMyMHUVTgbuqAfg1SUTb";
            // 
            // labelAccountId
            // 
            this.labelAccountId.Location = new System.Drawing.Point(12, 72);
            this.labelAccountId.Name = "labelAccountId";
            this.labelAccountId.Size = new System.Drawing.Size(70, 15);
            this.labelAccountId.TabIndex = 5;
            this.labelAccountId.Text = "Account ID:";
            // 
            // textAccountId
            // 
            this.textAccountId.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textAccountId.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textAccountId.Location = new System.Drawing.Point(88, 70);
            this.textAccountId.Name = "textAccountId";
            this.textAccountId.ReadOnly = true;
            this.textAccountId.Size = new System.Drawing.Size(284, 22);
            this.textAccountId.TabIndex = 6;
            this.textAccountId.Text = "rHb9CJAWyB4rj91VRWn96DkukG4bwdtyTh";
            // 
            // SettingsForm
            // 
            this.AcceptButton = this.buttonOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 162);
            this.Controls.Add(this.textAccountId);
            this.Controls.Add(this.labelAccountId);
            this.Controls.Add(this.textSecretKey);
            this.Controls.Add(this.labelSecretKey);
            this.Controls.Add(this.textServerUri);
            this.Controls.Add(this.labelServerUri);
            this.Controls.Add(this.buttonOK);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SettingsForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Settings";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.Label labelServerUri;
        private System.Windows.Forms.TextBox textServerUri;
        private System.Windows.Forms.Label labelSecretKey;
        private System.Windows.Forms.TextBox textSecretKey;
        private System.Windows.Forms.Label labelAccountId;
        private System.Windows.Forms.TextBox textAccountId;
    }
}