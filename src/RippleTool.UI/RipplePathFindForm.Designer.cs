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
            this.components = new System.ComponentModel.Container();
            this.bindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.buttonSubmit = new System.Windows.Forms.Button();
            this.labelSourceAccount = new System.Windows.Forms.Label();
            this.textSourceAccount = new System.Windows.Forms.TextBox();
            this.labelDestinationAccount = new System.Windows.Forms.Label();
            this.textDestinationAccount = new System.Windows.Forms.TextBox();
            this.groupDestinationAmount = new System.Windows.Forms.GroupBox();
            this.radioIssued = new System.Windows.Forms.RadioButton();
            this.radioNative = new System.Windows.Forms.RadioButton();
            this.labelDestinationAmountValue = new System.Windows.Forms.Label();
            this.textDestinationAmountValue = new System.Windows.Forms.TextBox();
            this.labelDestinationAmountCurrency = new System.Windows.Forms.Label();
            this.textDestinationAmountCurrency = new System.Windows.Forms.TextBox();
            this.labelDestinationAmountIssuer = new System.Windows.Forms.Label();
            this.textDestinationAmountIssuer = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource)).BeginInit();
            this.groupDestinationAmount.SuspendLayout();
            this.SuspendLayout();
            // 
            // bindingSource
            // 
            this.bindingSource.DataSource = typeof(RippleTool.UI.Models.RipplePathFindModel);
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
            this.textSourceAccount.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSource, "SourceAccount", true));
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
            this.textDestinationAccount.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSource, "DestinationAccount", true));
            this.textDestinationAccount.Location = new System.Drawing.Point(12, 71);
            this.textDestinationAccount.Name = "textDestinationAccount";
            this.textDestinationAccount.Size = new System.Drawing.Size(260, 23);
            this.textDestinationAccount.TabIndex = 3;
            // 
            // groupDestinationAmount
            // 
            this.groupDestinationAmount.Controls.Add(this.radioIssued);
            this.groupDestinationAmount.Controls.Add(this.radioNative);
            this.groupDestinationAmount.Location = new System.Drawing.Point(12, 100);
            this.groupDestinationAmount.Name = "groupDestinationAmount";
            this.groupDestinationAmount.Padding = new System.Windows.Forms.Padding(6, 3, 6, 6);
            this.groupDestinationAmount.Size = new System.Drawing.Size(260, 50);
            this.groupDestinationAmount.TabIndex = 4;
            this.groupDestinationAmount.TabStop = false;
            this.groupDestinationAmount.Text = "Destination amount";
            // 
            // radioIssued
            // 
            this.radioIssued.AutoSize = true;
            this.radioIssued.Checked = true;
            this.radioIssued.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.bindingSource, "DestinationAmountIssued", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.radioIssued.Location = new System.Drawing.Point(9, 22);
            this.radioIssued.Name = "radioIssued";
            this.radioIssued.Size = new System.Drawing.Size(58, 19);
            this.radioIssued.TabIndex = 0;
            this.radioIssued.TabStop = true;
            this.radioIssued.Text = "Issued";
            this.radioIssued.UseVisualStyleBackColor = true;
            // 
            // radioNative
            // 
            this.radioNative.AutoSize = true;
            this.radioNative.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.bindingSource, "DestinationAmountNative", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.radioNative.Location = new System.Drawing.Point(73, 22);
            this.radioNative.Name = "radioNative";
            this.radioNative.Size = new System.Drawing.Size(59, 19);
            this.radioNative.TabIndex = 1;
            this.radioNative.Text = "Native";
            this.radioNative.UseVisualStyleBackColor = true;
            // 
            // labelDestinationAmountValue
            // 
            this.labelDestinationAmountValue.AutoSize = true;
            this.labelDestinationAmountValue.Location = new System.Drawing.Point(12, 153);
            this.labelDestinationAmountValue.Name = "labelDestinationAmountValue";
            this.labelDestinationAmountValue.Size = new System.Drawing.Size(146, 15);
            this.labelDestinationAmountValue.TabIndex = 5;
            this.labelDestinationAmountValue.Text = "Destination amount value:";
            // 
            // textDestinationAmountValue
            // 
            this.textDestinationAmountValue.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSource, "DestinationAmountValue", true));
            this.textDestinationAmountValue.Location = new System.Drawing.Point(12, 171);
            this.textDestinationAmountValue.Name = "textDestinationAmountValue";
            this.textDestinationAmountValue.Size = new System.Drawing.Size(260, 23);
            this.textDestinationAmountValue.TabIndex = 6;
            // 
            // labelDestinationAmountCurrency
            // 
            this.labelDestinationAmountCurrency.AutoSize = true;
            this.labelDestinationAmountCurrency.DataBindings.Add(new System.Windows.Forms.Binding("Enabled", this.bindingSource, "DestinationAmountIssued", true));
            this.labelDestinationAmountCurrency.Location = new System.Drawing.Point(12, 197);
            this.labelDestinationAmountCurrency.Name = "labelDestinationAmountCurrency";
            this.labelDestinationAmountCurrency.Size = new System.Drawing.Size(164, 15);
            this.labelDestinationAmountCurrency.TabIndex = 7;
            this.labelDestinationAmountCurrency.Text = "Destination amount currency:";
            // 
            // textDestinationAmountCurrency
            // 
            this.textDestinationAmountCurrency.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSource, "DestinationAmountCurrency", true));
            this.textDestinationAmountCurrency.DataBindings.Add(new System.Windows.Forms.Binding("Enabled", this.bindingSource, "DestinationAmountIssued", true));
            this.textDestinationAmountCurrency.Location = new System.Drawing.Point(12, 215);
            this.textDestinationAmountCurrency.Name = "textDestinationAmountCurrency";
            this.textDestinationAmountCurrency.Size = new System.Drawing.Size(260, 23);
            this.textDestinationAmountCurrency.TabIndex = 8;
            // 
            // labelDestinationAmountIssuer
            // 
            this.labelDestinationAmountIssuer.AutoSize = true;
            this.labelDestinationAmountIssuer.DataBindings.Add(new System.Windows.Forms.Binding("Enabled", this.bindingSource, "DestinationAmountIssued", true));
            this.labelDestinationAmountIssuer.Location = new System.Drawing.Point(12, 241);
            this.labelDestinationAmountIssuer.Name = "labelDestinationAmountIssuer";
            this.labelDestinationAmountIssuer.Size = new System.Drawing.Size(148, 15);
            this.labelDestinationAmountIssuer.TabIndex = 9;
            this.labelDestinationAmountIssuer.Text = "Destination amount issuer:";
            // 
            // textDestinationAmountIssuer
            // 
            this.textDestinationAmountIssuer.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSource, "DestinationAmountIssuer", true));
            this.textDestinationAmountIssuer.DataBindings.Add(new System.Windows.Forms.Binding("Enabled", this.bindingSource, "DestinationAmountIssued", true));
            this.textDestinationAmountIssuer.Location = new System.Drawing.Point(12, 259);
            this.textDestinationAmountIssuer.Name = "textDestinationAmountIssuer";
            this.textDestinationAmountIssuer.Size = new System.Drawing.Size(260, 23);
            this.textDestinationAmountIssuer.TabIndex = 10;
            // 
            // RipplePathFindForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 862);
            this.Controls.Add(this.textDestinationAmountIssuer);
            this.Controls.Add(this.labelDestinationAmountIssuer);
            this.Controls.Add(this.textDestinationAmountCurrency);
            this.Controls.Add(this.labelDestinationAmountCurrency);
            this.Controls.Add(this.textDestinationAmountValue);
            this.Controls.Add(this.labelDestinationAmountValue);
            this.Controls.Add(this.groupDestinationAmount);
            this.Controls.Add(this.textDestinationAccount);
            this.Controls.Add(this.labelDestinationAccount);
            this.Controls.Add(this.textSourceAccount);
            this.Controls.Add(this.labelSourceAccount);
            this.Controls.Add(this.buttonSubmit);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "RipplePathFindForm";
            this.Text = "Ripple Path Find";
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource)).EndInit();
            this.groupDestinationAmount.ResumeLayout(false);
            this.groupDestinationAmount.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource bindingSource;
        private System.Windows.Forms.Button buttonSubmit;
        private System.Windows.Forms.Label labelSourceAccount;
        private System.Windows.Forms.TextBox textSourceAccount;
        private System.Windows.Forms.Label labelDestinationAccount;
        private System.Windows.Forms.TextBox textDestinationAccount;
        private System.Windows.Forms.GroupBox groupDestinationAmount;
        private System.Windows.Forms.RadioButton radioIssued;
        private System.Windows.Forms.RadioButton radioNative;
        private System.Windows.Forms.Label labelDestinationAmountValue;
        private System.Windows.Forms.TextBox textDestinationAmountValue;
        private System.Windows.Forms.Label labelDestinationAmountCurrency;
        private System.Windows.Forms.TextBox textDestinationAmountCurrency;
        private System.Windows.Forms.Label labelDestinationAmountIssuer;
        private System.Windows.Forms.TextBox textDestinationAmountIssuer;
    }
}