namespace RippleTool.UI
{
    partial class BookOffersForm
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
            this.labelTakerGetsCurrency = new System.Windows.Forms.Label();
            this.textTakerGetsCurrency = new System.Windows.Forms.TextBox();
            this.labelTakerGetsIssuer = new System.Windows.Forms.Label();
            this.textTakerGetsIssuer = new System.Windows.Forms.TextBox();
            this.labelTakerPaysCurrency = new System.Windows.Forms.Label();
            this.textTakerPaysCurrency = new System.Windows.Forms.TextBox();
            this.labelTakerPaysIssuer = new System.Windows.Forms.Label();
            this.textTakerPaysIssuer = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // buttonSubmit
            // 
            this.buttonSubmit.Location = new System.Drawing.Point(12, 188);
            this.buttonSubmit.Name = "buttonSubmit";
            this.buttonSubmit.Size = new System.Drawing.Size(100, 25);
            this.buttonSubmit.TabIndex = 0;
            this.buttonSubmit.Text = "Submit";
            this.buttonSubmit.UseVisualStyleBackColor = true;
            this.buttonSubmit.Click += new System.EventHandler(this.buttonSubmit_Click);
            // 
            // labelTakerGetsCurrency
            // 
            this.labelTakerGetsCurrency.AutoSize = true;
            this.labelTakerGetsCurrency.Location = new System.Drawing.Point(12, 9);
            this.labelTakerGetsCurrency.Name = "labelTakerGetsCurrency";
            this.labelTakerGetsCurrency.Size = new System.Drawing.Size(113, 15);
            this.labelTakerGetsCurrency.TabIndex = 1;
            this.labelTakerGetsCurrency.Text = "Taker gets currency:";
            // 
            // textTakerGetsCurrency
            // 
            this.textTakerGetsCurrency.Location = new System.Drawing.Point(12, 27);
            this.textTakerGetsCurrency.Name = "textTakerGetsCurrency";
            this.textTakerGetsCurrency.Size = new System.Drawing.Size(260, 23);
            this.textTakerGetsCurrency.TabIndex = 2;
            // 
            // labelTakerGetsIssuer
            // 
            this.labelTakerGetsIssuer.AutoSize = true;
            this.labelTakerGetsIssuer.Location = new System.Drawing.Point(12, 53);
            this.labelTakerGetsIssuer.Name = "labelTakerGetsIssuer";
            this.labelTakerGetsIssuer.Size = new System.Drawing.Size(97, 15);
            this.labelTakerGetsIssuer.TabIndex = 3;
            this.labelTakerGetsIssuer.Text = "Taker gets issuer:";
            // 
            // textTakerGetsIssuer
            // 
            this.textTakerGetsIssuer.Location = new System.Drawing.Point(12, 71);
            this.textTakerGetsIssuer.Name = "textTakerGetsIssuer";
            this.textTakerGetsIssuer.Size = new System.Drawing.Size(260, 23);
            this.textTakerGetsIssuer.TabIndex = 4;
            // 
            // labelTakerPaysCurrency
            // 
            this.labelTakerPaysCurrency.AutoSize = true;
            this.labelTakerPaysCurrency.Location = new System.Drawing.Point(12, 97);
            this.labelTakerPaysCurrency.Name = "labelTakerPaysCurrency";
            this.labelTakerPaysCurrency.Size = new System.Drawing.Size(115, 15);
            this.labelTakerPaysCurrency.TabIndex = 5;
            this.labelTakerPaysCurrency.Text = "Taker pays currency:";
            // 
            // textTakerPaysCurrency
            // 
            this.textTakerPaysCurrency.Location = new System.Drawing.Point(12, 115);
            this.textTakerPaysCurrency.Name = "textTakerPaysCurrency";
            this.textTakerPaysCurrency.Size = new System.Drawing.Size(260, 23);
            this.textTakerPaysCurrency.TabIndex = 6;
            // 
            // labelTakerPaysIssuer
            // 
            this.labelTakerPaysIssuer.AutoSize = true;
            this.labelTakerPaysIssuer.Location = new System.Drawing.Point(12, 141);
            this.labelTakerPaysIssuer.Name = "labelTakerPaysIssuer";
            this.labelTakerPaysIssuer.Size = new System.Drawing.Size(99, 15);
            this.labelTakerPaysIssuer.TabIndex = 7;
            this.labelTakerPaysIssuer.Text = "Taker pays issuer:";
            // 
            // textTakerPaysIssuer
            // 
            this.textTakerPaysIssuer.Location = new System.Drawing.Point(12, 159);
            this.textTakerPaysIssuer.Name = "textTakerPaysIssuer";
            this.textTakerPaysIssuer.Size = new System.Drawing.Size(260, 23);
            this.textTakerPaysIssuer.TabIndex = 8;
            // 
            // BookOffersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 362);
            this.Controls.Add(this.textTakerPaysIssuer);
            this.Controls.Add(this.labelTakerPaysIssuer);
            this.Controls.Add(this.textTakerPaysCurrency);
            this.Controls.Add(this.labelTakerPaysCurrency);
            this.Controls.Add(this.textTakerGetsIssuer);
            this.Controls.Add(this.labelTakerGetsIssuer);
            this.Controls.Add(this.textTakerGetsCurrency);
            this.Controls.Add(this.labelTakerGetsCurrency);
            this.Controls.Add(this.buttonSubmit);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "BookOffersForm";
            this.Text = "Book Offers";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonSubmit;
        private System.Windows.Forms.Label labelTakerGetsCurrency;
        private System.Windows.Forms.TextBox textTakerGetsCurrency;
        private System.Windows.Forms.Label labelTakerGetsIssuer;
        private System.Windows.Forms.TextBox textTakerGetsIssuer;
        private System.Windows.Forms.Label labelTakerPaysCurrency;
        private System.Windows.Forms.TextBox textTakerPaysCurrency;
        private System.Windows.Forms.Label labelTakerPaysIssuer;
        private System.Windows.Forms.TextBox textTakerPaysIssuer;
    }
}