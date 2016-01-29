namespace RippleTool.UI
{
    partial class RipplePathFindForm
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
            this.labelSourceAccount = new System.Windows.Forms.Label();
            this.textSourceAccount = new System.Windows.Forms.TextBox();
            this.labelDestinationAccount = new System.Windows.Forms.Label();
            this.textDestinationAccount = new System.Windows.Forms.TextBox();
            this.labelDestinationAmount = new System.Windows.Forms.Label();
            this.textDestinationAmount = new System.Windows.Forms.TextBox();
            this.labelDestinationCurrency = new System.Windows.Forms.Label();
            this.textDestinationCurrency = new System.Windows.Forms.TextBox();
            this.labelDestinationIssuer = new System.Windows.Forms.Label();
            this.textDestinationIssuer = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // buttonSubmit
            // 
            this.buttonSubmit.Location = new System.Drawing.Point(12, 232);
            this.buttonSubmit.Name = "buttonSubmit";
            this.buttonSubmit.Size = new System.Drawing.Size(100, 25);
            this.buttonSubmit.TabIndex = 10;
            this.buttonSubmit.Text = "Submit";
            this.buttonSubmit.UseVisualStyleBackColor = true;
            this.buttonSubmit.Click += new System.EventHandler(this.buttonSubmit_Click);
            // 
            // labelSourceAccount
            // 
            this.labelSourceAccount.AutoSize = true;
            this.labelSourceAccount.Location = new System.Drawing.Point(12, 9);
            this.labelSourceAccount.Name = "labelSourceAccount";
            this.labelSourceAccount.Size = new System.Drawing.Size(92, 15);
            this.labelSourceAccount.TabIndex = 0;
            this.labelSourceAccount.Text = "Source account:";
            // 
            // textSourceAccount
            // 
            this.textSourceAccount.Location = new System.Drawing.Point(12, 27);
            this.textSourceAccount.Name = "textSourceAccount";
            this.textSourceAccount.Size = new System.Drawing.Size(260, 23);
            this.textSourceAccount.TabIndex = 1;
            // 
            // labelDestinationAccount
            // 
            this.labelDestinationAccount.AutoSize = true;
            this.labelDestinationAccount.Location = new System.Drawing.Point(12, 53);
            this.labelDestinationAccount.Name = "labelDestinationAccount";
            this.labelDestinationAccount.Size = new System.Drawing.Size(116, 15);
            this.labelDestinationAccount.TabIndex = 2;
            this.labelDestinationAccount.Text = "Destination account:";
            // 
            // textDestinationAccount
            // 
            this.textDestinationAccount.Location = new System.Drawing.Point(12, 71);
            this.textDestinationAccount.Name = "textDestinationAccount";
            this.textDestinationAccount.Size = new System.Drawing.Size(260, 23);
            this.textDestinationAccount.TabIndex = 3;
            // 
            // labelDestinationAmount
            // 
            this.labelDestinationAmount.AutoSize = true;
            this.labelDestinationAmount.Location = new System.Drawing.Point(12, 97);
            this.labelDestinationAmount.Name = "labelDestinationAmount";
            this.labelDestinationAmount.Size = new System.Drawing.Size(115, 15);
            this.labelDestinationAmount.TabIndex = 4;
            this.labelDestinationAmount.Text = "Destination amount:";
            // 
            // textDestinationAmount
            // 
            this.textDestinationAmount.Location = new System.Drawing.Point(12, 115);
            this.textDestinationAmount.Name = "textDestinationAmount";
            this.textDestinationAmount.Size = new System.Drawing.Size(260, 23);
            this.textDestinationAmount.TabIndex = 5;
            // 
            // labelDestinationCurrency
            // 
            this.labelDestinationCurrency.AutoSize = true;
            this.labelDestinationCurrency.Location = new System.Drawing.Point(12, 141);
            this.labelDestinationCurrency.Name = "labelDestinationCurrency";
            this.labelDestinationCurrency.Size = new System.Drawing.Size(119, 15);
            this.labelDestinationCurrency.TabIndex = 6;
            this.labelDestinationCurrency.Text = "Destination currency:";
            // 
            // textDestinationCurrency
            // 
            this.textDestinationCurrency.Location = new System.Drawing.Point(12, 159);
            this.textDestinationCurrency.Name = "textDestinationCurrency";
            this.textDestinationCurrency.Size = new System.Drawing.Size(260, 23);
            this.textDestinationCurrency.TabIndex = 7;
            // 
            // labelDestinationIssuer
            // 
            this.labelDestinationIssuer.AutoSize = true;
            this.labelDestinationIssuer.Location = new System.Drawing.Point(12, 185);
            this.labelDestinationIssuer.Name = "labelDestinationIssuer";
            this.labelDestinationIssuer.Size = new System.Drawing.Size(103, 15);
            this.labelDestinationIssuer.TabIndex = 8;
            this.labelDestinationIssuer.Text = "Destination issuer:";
            // 
            // textDestinationIssuer
            // 
            this.textDestinationIssuer.Location = new System.Drawing.Point(12, 203);
            this.textDestinationIssuer.Name = "textDestinationIssuer";
            this.textDestinationIssuer.Size = new System.Drawing.Size(260, 23);
            this.textDestinationIssuer.TabIndex = 9;
            // 
            // RipplePathFindForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 362);
            this.Controls.Add(this.textDestinationIssuer);
            this.Controls.Add(this.labelDestinationIssuer);
            this.Controls.Add(this.textDestinationCurrency);
            this.Controls.Add(this.labelDestinationCurrency);
            this.Controls.Add(this.textDestinationAmount);
            this.Controls.Add(this.labelDestinationAmount);
            this.Controls.Add(this.textDestinationAccount);
            this.Controls.Add(this.labelDestinationAccount);
            this.Controls.Add(this.textSourceAccount);
            this.Controls.Add(this.labelSourceAccount);
            this.Controls.Add(this.buttonSubmit);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "RipplePathFindForm";
            this.Text = "Ripple Path Find";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonSubmit;
        private System.Windows.Forms.Label labelSourceAccount;
        private System.Windows.Forms.TextBox textSourceAccount;
        private System.Windows.Forms.Label labelDestinationAccount;
        private System.Windows.Forms.TextBox textDestinationAccount;
        private System.Windows.Forms.Label labelDestinationAmount;
        private System.Windows.Forms.TextBox textDestinationAmount;
        private System.Windows.Forms.Label labelDestinationCurrency;
        private System.Windows.Forms.TextBox textDestinationCurrency;
        private System.Windows.Forms.Label labelDestinationIssuer;
        private System.Windows.Forms.TextBox textDestinationIssuer;
    }
}