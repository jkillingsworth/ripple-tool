﻿namespace RippleTool.UI
{
    partial class GatewayBalancesForm
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
            this.bindingSourceLedgerOptions = new System.Windows.Forms.BindingSource(this.components);
            this.buttonSubmit = new System.Windows.Forms.Button();
            this.labelLedger = new System.Windows.Forms.Label();
            this.comboLedger = new System.Windows.Forms.ComboBox();
            this.labelAccount = new System.Windows.Forms.Label();
            this.textAccount = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceLedgerOptions)).BeginInit();
            this.SuspendLayout();
            // 
            // bindingSource
            // 
            this.bindingSource.DataSource = typeof(RippleTool.UI.Models.GatewayBalancesModel);
            // 
            // bindingSourceLedgerOptions
            // 
            this.bindingSourceLedgerOptions.DataSource = typeof(RippleTool.UI.Models.LedgerOptions);
            // 
            // buttonSubmit
            // 
            this.buttonSubmit.Location = new System.Drawing.Point(12, 100);
            this.buttonSubmit.Name = "buttonSubmit";
            this.buttonSubmit.Size = new System.Drawing.Size(100, 25);
            this.buttonSubmit.TabIndex = 4;
            this.buttonSubmit.Text = "Submit";
            this.buttonSubmit.UseVisualStyleBackColor = true;
            this.buttonSubmit.Click += new System.EventHandler(this.buttonSubmit_Click);
            // 
            // labelLedger
            // 
            this.labelLedger.AutoSize = true;
            this.labelLedger.Location = new System.Drawing.Point(12, 9);
            this.labelLedger.Name = "labelLedger";
            this.labelLedger.Size = new System.Drawing.Size(46, 15);
            this.labelLedger.TabIndex = 0;
            this.labelLedger.Text = "Ledger:";
            // 
            // comboLedger
            // 
            this.comboLedger.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.bindingSource, "Ledger", true));
            this.comboLedger.DataSource = this.bindingSourceLedgerOptions;
            this.comboLedger.DisplayMember = "Display";
            this.comboLedger.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboLedger.FormattingEnabled = true;
            this.comboLedger.Location = new System.Drawing.Point(12, 27);
            this.comboLedger.Name = "comboLedger";
            this.comboLedger.Size = new System.Drawing.Size(260, 23);
            this.comboLedger.TabIndex = 1;
            this.comboLedger.ValueMember = "Value";
            // 
            // labelAccount
            // 
            this.labelAccount.AutoSize = true;
            this.labelAccount.Location = new System.Drawing.Point(12, 53);
            this.labelAccount.Name = "labelAccount";
            this.labelAccount.Size = new System.Drawing.Size(55, 15);
            this.labelAccount.TabIndex = 2;
            this.labelAccount.Text = "Account:";
            // 
            // textAccount
            // 
            this.textAccount.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSource, "Account", true));
            this.textAccount.Location = new System.Drawing.Point(12, 71);
            this.textAccount.Name = "textAccount";
            this.textAccount.Size = new System.Drawing.Size(260, 23);
            this.textAccount.TabIndex = 3;
            // 
            // GatewayBalancesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 862);
            this.Controls.Add(this.textAccount);
            this.Controls.Add(this.labelAccount);
            this.Controls.Add(this.comboLedger);
            this.Controls.Add(this.labelLedger);
            this.Controls.Add(this.buttonSubmit);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "GatewayBalancesForm";
            this.Text = "Gateway Balances";
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceLedgerOptions)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource bindingSource;
        private System.Windows.Forms.BindingSource bindingSourceLedgerOptions;
        private System.Windows.Forms.Button buttonSubmit;
        private System.Windows.Forms.Label labelLedger;
        private System.Windows.Forms.ComboBox comboLedger;
        private System.Windows.Forms.Label labelAccount;
        private System.Windows.Forms.TextBox textAccount;
    }
}