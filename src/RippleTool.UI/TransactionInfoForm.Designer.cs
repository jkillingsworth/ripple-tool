namespace RippleTool.UI
{
    partial class TransactionInfoForm
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
            this.labelTransactionHash = new System.Windows.Forms.Label();
            this.textTransactionHash = new System.Windows.Forms.TextBox();
            this.checkBinary = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // bindingSource
            // 
            this.bindingSource.DataSource = typeof(RippleTool.UI.Models.TransactionInfoModel);
            // 
            // buttonSubmit
            // 
            this.buttonSubmit.Location = new System.Drawing.Point(12, 81);
            this.buttonSubmit.Name = "buttonSubmit";
            this.buttonSubmit.Size = new System.Drawing.Size(100, 25);
            this.buttonSubmit.TabIndex = 3;
            this.buttonSubmit.Text = "Submit";
            this.buttonSubmit.UseVisualStyleBackColor = true;
            this.buttonSubmit.Click += new System.EventHandler(this.buttonSubmit_Click);
            // 
            // labelTransactionHash
            // 
            this.labelTransactionHash.AutoSize = true;
            this.labelTransactionHash.Location = new System.Drawing.Point(12, 9);
            this.labelTransactionHash.Name = "labelTransactionHash";
            this.labelTransactionHash.Size = new System.Drawing.Size(100, 15);
            this.labelTransactionHash.TabIndex = 0;
            this.labelTransactionHash.Text = "Transaction hash:";
            // 
            // textTransactionHash
            // 
            this.textTransactionHash.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSource, "TransactionHash", true));
            this.textTransactionHash.Location = new System.Drawing.Point(12, 27);
            this.textTransactionHash.Name = "textTransactionHash";
            this.textTransactionHash.Size = new System.Drawing.Size(520, 23);
            this.textTransactionHash.TabIndex = 1;
            // 
            // checkBinary
            // 
            this.checkBinary.AutoSize = true;
            this.checkBinary.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.bindingSource, "Binary", true));
            this.checkBinary.Location = new System.Drawing.Point(12, 56);
            this.checkBinary.Name = "checkBinary";
            this.checkBinary.Size = new System.Drawing.Size(59, 19);
            this.checkBinary.TabIndex = 2;
            this.checkBinary.Text = "Binary";
            this.checkBinary.UseVisualStyleBackColor = true;
            // 
            // TransactionInfoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(544, 862);
            this.Controls.Add(this.checkBinary);
            this.Controls.Add(this.textTransactionHash);
            this.Controls.Add(this.labelTransactionHash);
            this.Controls.Add(this.buttonSubmit);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "TransactionInfoForm";
            this.Text = "Transaction Info";
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource bindingSource;
        private System.Windows.Forms.Button buttonSubmit;
        private System.Windows.Forms.Label labelTransactionHash;
        private System.Windows.Forms.TextBox textTransactionHash;
        private System.Windows.Forms.CheckBox checkBinary;
    }
}