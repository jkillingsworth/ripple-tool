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
            this.groupTakerGets = new System.Windows.Forms.GroupBox();
            this.radioTakerGetsNative = new System.Windows.Forms.RadioButton();
            this.radioTakerGetsIssued = new System.Windows.Forms.RadioButton();
            this.labelTakerGetsCurrency = new System.Windows.Forms.Label();
            this.textTakerGetsCurrency = new System.Windows.Forms.TextBox();
            this.labelTakerGetsIssuer = new System.Windows.Forms.Label();
            this.textTakerGetsIssuer = new System.Windows.Forms.TextBox();
            this.groupTakerPays = new System.Windows.Forms.GroupBox();
            this.radioTakerPaysNative = new System.Windows.Forms.RadioButton();
            this.radioTakerPaysIssued = new System.Windows.Forms.RadioButton();
            this.labelTakerPaysCurrency = new System.Windows.Forms.Label();
            this.textTakerPaysCurrency = new System.Windows.Forms.TextBox();
            this.labelTakerPaysIssuer = new System.Windows.Forms.Label();
            this.textTakerPaysIssuer = new System.Windows.Forms.TextBox();
            this.labelTaker = new System.Windows.Forms.Label();
            this.textTaker = new System.Windows.Forms.TextBox();
            this.labelLimit = new System.Windows.Forms.Label();
            this.textLimit = new System.Windows.Forms.TextBox();
            this.groupTakerGets.SuspendLayout();
            this.groupTakerPays.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonSubmit
            // 
            this.buttonSubmit.Location = new System.Drawing.Point(12, 388);
            this.buttonSubmit.Name = "buttonSubmit";
            this.buttonSubmit.Size = new System.Drawing.Size(100, 25);
            this.buttonSubmit.TabIndex = 14;
            this.buttonSubmit.Text = "Submit";
            this.buttonSubmit.UseVisualStyleBackColor = true;
            this.buttonSubmit.Click += new System.EventHandler(this.buttonSubmit_Click);
            // 
            // groupTakerGets
            // 
            this.groupTakerGets.Controls.Add(this.radioTakerGetsNative);
            this.groupTakerGets.Controls.Add(this.radioTakerGetsIssued);
            this.groupTakerGets.Location = new System.Drawing.Point(12, 100);
            this.groupTakerGets.Name = "groupTakerGets";
            this.groupTakerGets.Padding = new System.Windows.Forms.Padding(6, 3, 6, 6);
            this.groupTakerGets.Size = new System.Drawing.Size(260, 50);
            this.groupTakerGets.TabIndex = 4;
            this.groupTakerGets.TabStop = false;
            this.groupTakerGets.Text = "Taker gets";
            // 
            // radioTakerGetsNative
            // 
            this.radioTakerGetsNative.AutoSize = true;
            this.radioTakerGetsNative.Location = new System.Drawing.Point(73, 22);
            this.radioTakerGetsNative.Name = "radioTakerGetsNative";
            this.radioTakerGetsNative.Size = new System.Drawing.Size(59, 19);
            this.radioTakerGetsNative.TabIndex = 1;
            this.radioTakerGetsNative.Text = "Native";
            this.radioTakerGetsNative.UseVisualStyleBackColor = true;
            this.radioTakerGetsNative.CheckedChanged += new System.EventHandler(this.radioTakerGetsNative_CheckedChanged);
            // 
            // radioTakerGetsIssued
            // 
            this.radioTakerGetsIssued.AutoSize = true;
            this.radioTakerGetsIssued.Checked = true;
            this.radioTakerGetsIssued.Location = new System.Drawing.Point(9, 22);
            this.radioTakerGetsIssued.Name = "radioTakerGetsIssued";
            this.radioTakerGetsIssued.Size = new System.Drawing.Size(58, 19);
            this.radioTakerGetsIssued.TabIndex = 0;
            this.radioTakerGetsIssued.TabStop = true;
            this.radioTakerGetsIssued.Text = "Issued";
            this.radioTakerGetsIssued.UseVisualStyleBackColor = true;
            this.radioTakerGetsIssued.CheckedChanged += new System.EventHandler(this.radioTakerGetsIssued_CheckedChanged);
            // 
            // labelTakerGetsCurrency
            // 
            this.labelTakerGetsCurrency.AutoSize = true;
            this.labelTakerGetsCurrency.Location = new System.Drawing.Point(12, 153);
            this.labelTakerGetsCurrency.Name = "labelTakerGetsCurrency";
            this.labelTakerGetsCurrency.Size = new System.Drawing.Size(113, 15);
            this.labelTakerGetsCurrency.TabIndex = 5;
            this.labelTakerGetsCurrency.Text = "Taker gets currency:";
            // 
            // textTakerGetsCurrency
            // 
            this.textTakerGetsCurrency.Location = new System.Drawing.Point(12, 171);
            this.textTakerGetsCurrency.Name = "textTakerGetsCurrency";
            this.textTakerGetsCurrency.Size = new System.Drawing.Size(260, 23);
            this.textTakerGetsCurrency.TabIndex = 6;
            // 
            // labelTakerGetsIssuer
            // 
            this.labelTakerGetsIssuer.AutoSize = true;
            this.labelTakerGetsIssuer.Location = new System.Drawing.Point(12, 197);
            this.labelTakerGetsIssuer.Name = "labelTakerGetsIssuer";
            this.labelTakerGetsIssuer.Size = new System.Drawing.Size(97, 15);
            this.labelTakerGetsIssuer.TabIndex = 7;
            this.labelTakerGetsIssuer.Text = "Taker gets issuer:";
            // 
            // textTakerGetsIssuer
            // 
            this.textTakerGetsIssuer.Location = new System.Drawing.Point(12, 215);
            this.textTakerGetsIssuer.Name = "textTakerGetsIssuer";
            this.textTakerGetsIssuer.Size = new System.Drawing.Size(260, 23);
            this.textTakerGetsIssuer.TabIndex = 8;
            // 
            // groupTakerPays
            // 
            this.groupTakerPays.Controls.Add(this.radioTakerPaysNative);
            this.groupTakerPays.Controls.Add(this.radioTakerPaysIssued);
            this.groupTakerPays.Location = new System.Drawing.Point(12, 244);
            this.groupTakerPays.Name = "groupTakerPays";
            this.groupTakerPays.Padding = new System.Windows.Forms.Padding(6, 3, 6, 6);
            this.groupTakerPays.Size = new System.Drawing.Size(260, 50);
            this.groupTakerPays.TabIndex = 9;
            this.groupTakerPays.TabStop = false;
            this.groupTakerPays.Text = "Taker pays";
            // 
            // radioTakerPaysNative
            // 
            this.radioTakerPaysNative.AutoSize = true;
            this.radioTakerPaysNative.Location = new System.Drawing.Point(73, 22);
            this.radioTakerPaysNative.Name = "radioTakerPaysNative";
            this.radioTakerPaysNative.Size = new System.Drawing.Size(59, 19);
            this.radioTakerPaysNative.TabIndex = 1;
            this.radioTakerPaysNative.Text = "Native";
            this.radioTakerPaysNative.UseVisualStyleBackColor = true;
            this.radioTakerPaysNative.CheckedChanged += new System.EventHandler(this.radioTakerPaysNative_CheckedChanged);
            // 
            // radioTakerPaysIssued
            // 
            this.radioTakerPaysIssued.AutoSize = true;
            this.radioTakerPaysIssued.Checked = true;
            this.radioTakerPaysIssued.Location = new System.Drawing.Point(9, 22);
            this.radioTakerPaysIssued.Name = "radioTakerPaysIssued";
            this.radioTakerPaysIssued.Size = new System.Drawing.Size(58, 19);
            this.radioTakerPaysIssued.TabIndex = 0;
            this.radioTakerPaysIssued.TabStop = true;
            this.radioTakerPaysIssued.Text = "Issued";
            this.radioTakerPaysIssued.UseVisualStyleBackColor = true;
            this.radioTakerPaysIssued.CheckedChanged += new System.EventHandler(this.radioTakerPaysIssued_CheckedChanged);
            // 
            // labelTakerPaysCurrency
            // 
            this.labelTakerPaysCurrency.AutoSize = true;
            this.labelTakerPaysCurrency.Location = new System.Drawing.Point(12, 297);
            this.labelTakerPaysCurrency.Name = "labelTakerPaysCurrency";
            this.labelTakerPaysCurrency.Size = new System.Drawing.Size(115, 15);
            this.labelTakerPaysCurrency.TabIndex = 10;
            this.labelTakerPaysCurrency.Text = "Taker pays currency:";
            // 
            // textTakerPaysCurrency
            // 
            this.textTakerPaysCurrency.Location = new System.Drawing.Point(12, 315);
            this.textTakerPaysCurrency.Name = "textTakerPaysCurrency";
            this.textTakerPaysCurrency.Size = new System.Drawing.Size(260, 23);
            this.textTakerPaysCurrency.TabIndex = 11;
            // 
            // labelTakerPaysIssuer
            // 
            this.labelTakerPaysIssuer.AutoSize = true;
            this.labelTakerPaysIssuer.Location = new System.Drawing.Point(12, 341);
            this.labelTakerPaysIssuer.Name = "labelTakerPaysIssuer";
            this.labelTakerPaysIssuer.Size = new System.Drawing.Size(99, 15);
            this.labelTakerPaysIssuer.TabIndex = 12;
            this.labelTakerPaysIssuer.Text = "Taker pays issuer:";
            // 
            // textTakerPaysIssuer
            // 
            this.textTakerPaysIssuer.Location = new System.Drawing.Point(12, 359);
            this.textTakerPaysIssuer.Name = "textTakerPaysIssuer";
            this.textTakerPaysIssuer.Size = new System.Drawing.Size(260, 23);
            this.textTakerPaysIssuer.TabIndex = 13;
            // 
            // labelTaker
            // 
            this.labelTaker.AutoSize = true;
            this.labelTaker.Location = new System.Drawing.Point(12, 9);
            this.labelTaker.Name = "labelTaker";
            this.labelTaker.Size = new System.Drawing.Size(94, 15);
            this.labelTaker.TabIndex = 0;
            this.labelTaker.Text = "Taker (optional):";
            // 
            // textTaker
            // 
            this.textTaker.Location = new System.Drawing.Point(12, 27);
            this.textTaker.Name = "textTaker";
            this.textTaker.Size = new System.Drawing.Size(260, 23);
            this.textTaker.TabIndex = 1;
            // 
            // labelLimit
            // 
            this.labelLimit.AutoSize = true;
            this.labelLimit.Location = new System.Drawing.Point(12, 53);
            this.labelLimit.Name = "labelLimit";
            this.labelLimit.Size = new System.Drawing.Size(92, 15);
            this.labelLimit.TabIndex = 2;
            this.labelLimit.Text = "Limit (optional):";
            // 
            // textLimit
            // 
            this.textLimit.Location = new System.Drawing.Point(12, 71);
            this.textLimit.Name = "textLimit";
            this.textLimit.Size = new System.Drawing.Size(260, 23);
            this.textLimit.TabIndex = 3;
            // 
            // BookOffersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 862);
            this.Controls.Add(this.textLimit);
            this.Controls.Add(this.labelLimit);
            this.Controls.Add(this.textTaker);
            this.Controls.Add(this.labelTaker);
            this.Controls.Add(this.textTakerPaysIssuer);
            this.Controls.Add(this.labelTakerPaysIssuer);
            this.Controls.Add(this.textTakerPaysCurrency);
            this.Controls.Add(this.labelTakerPaysCurrency);
            this.Controls.Add(this.groupTakerPays);
            this.Controls.Add(this.textTakerGetsIssuer);
            this.Controls.Add(this.labelTakerGetsIssuer);
            this.Controls.Add(this.textTakerGetsCurrency);
            this.Controls.Add(this.labelTakerGetsCurrency);
            this.Controls.Add(this.groupTakerGets);
            this.Controls.Add(this.buttonSubmit);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "BookOffersForm";
            this.Text = "Book Offers";
            this.groupTakerGets.ResumeLayout(false);
            this.groupTakerGets.PerformLayout();
            this.groupTakerPays.ResumeLayout(false);
            this.groupTakerPays.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonSubmit;
        private System.Windows.Forms.GroupBox groupTakerGets;
        private System.Windows.Forms.RadioButton radioTakerGetsIssued;
        private System.Windows.Forms.RadioButton radioTakerGetsNative;
        private System.Windows.Forms.Label labelTakerGetsCurrency;
        private System.Windows.Forms.TextBox textTakerGetsCurrency;
        private System.Windows.Forms.Label labelTakerGetsIssuer;
        private System.Windows.Forms.TextBox textTakerGetsIssuer;
        private System.Windows.Forms.GroupBox groupTakerPays;
        private System.Windows.Forms.RadioButton radioTakerPaysIssued;
        private System.Windows.Forms.RadioButton radioTakerPaysNative;
        private System.Windows.Forms.Label labelTakerPaysCurrency;
        private System.Windows.Forms.TextBox textTakerPaysCurrency;
        private System.Windows.Forms.Label labelTakerPaysIssuer;
        private System.Windows.Forms.TextBox textTakerPaysIssuer;
        private System.Windows.Forms.Label labelTaker;
        private System.Windows.Forms.TextBox textTaker;
        private System.Windows.Forms.Label labelLimit;
        private System.Windows.Forms.TextBox textLimit;
    }
}