namespace RippleTool.UI
{
    partial class NoRippleCheckForm
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
            this.groupRole = new System.Windows.Forms.GroupBox();
            this.radioUser = new System.Windows.Forms.RadioButton();
            this.radioGateway = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceLedgerOptions)).BeginInit();
            this.groupRole.SuspendLayout();
            this.SuspendLayout();
            // 
            // bindingSource
            // 
            this.bindingSource.DataSource = typeof(RippleTool.UI.Models.NoRippleCheckModel);
            // 
            // bindingSourceLedgerOptions
            // 
            this.bindingSourceLedgerOptions.DataSource = typeof(RippleTool.UI.Models.LedgerOptions);
            // 
            // buttonSubmit
            // 
            this.buttonSubmit.Location = new System.Drawing.Point(12, 156);
            this.buttonSubmit.Name = "buttonSubmit";
            this.buttonSubmit.Size = new System.Drawing.Size(100, 25);
            this.buttonSubmit.TabIndex = 5;
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
            // groupRole
            // 
            this.groupRole.Controls.Add(this.radioUser);
            this.groupRole.Controls.Add(this.radioGateway);
            this.groupRole.Location = new System.Drawing.Point(12, 100);
            this.groupRole.Name = "groupRole";
            this.groupRole.Padding = new System.Windows.Forms.Padding(6, 3, 6, 6);
            this.groupRole.Size = new System.Drawing.Size(260, 50);
            this.groupRole.TabIndex = 4;
            this.groupRole.TabStop = false;
            this.groupRole.Text = "Role";
            // 
            // radioUser
            // 
            this.radioUser.AutoSize = true;
            this.radioUser.Checked = true;
            this.radioUser.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.bindingSource, "RoleIsUser", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.radioUser.Location = new System.Drawing.Point(9, 22);
            this.radioUser.Name = "radioUser";
            this.radioUser.Size = new System.Drawing.Size(48, 19);
            this.radioUser.TabIndex = 0;
            this.radioUser.TabStop = true;
            this.radioUser.Text = "User";
            this.radioUser.UseVisualStyleBackColor = true;
            // 
            // radioGateway
            // 
            this.radioGateway.AutoSize = true;
            this.radioGateway.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.bindingSource, "RoleIsGateway", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.radioGateway.Location = new System.Drawing.Point(63, 22);
            this.radioGateway.Name = "radioGateway";
            this.radioGateway.Size = new System.Drawing.Size(70, 19);
            this.radioGateway.TabIndex = 1;
            this.radioGateway.Text = "Gateway";
            this.radioGateway.UseVisualStyleBackColor = true;
            // 
            // NoRippleCheckForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 862);
            this.Controls.Add(this.groupRole);
            this.Controls.Add(this.textAccount);
            this.Controls.Add(this.labelAccount);
            this.Controls.Add(this.comboLedger);
            this.Controls.Add(this.labelLedger);
            this.Controls.Add(this.buttonSubmit);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "NoRippleCheckForm";
            this.Text = "No Ripple Check";
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceLedgerOptions)).EndInit();
            this.groupRole.ResumeLayout(false);
            this.groupRole.PerformLayout();
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
        private System.Windows.Forms.GroupBox groupRole;
        private System.Windows.Forms.RadioButton radioUser;
        private System.Windows.Forms.RadioButton radioGateway;
    }
}