namespace RippleTool.UI
{
    partial class AboutForm
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
            this.labelRippleTool = new System.Windows.Forms.Label();
            this.labelDescription = new System.Windows.Forms.Label();
            this.linkViewSourceCode = new System.Windows.Forms.LinkLabel();
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
            // labelRippleTool
            // 
            this.labelRippleTool.AutoSize = true;
            this.labelRippleTool.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRippleTool.Location = new System.Drawing.Point(12, 9);
            this.labelRippleTool.Name = "labelRippleTool";
            this.labelRippleTool.Size = new System.Drawing.Size(184, 45);
            this.labelRippleTool.TabIndex = 1;
            this.labelRippleTool.Text = "RippleTool";
            // 
            // labelDescription
            // 
            this.labelDescription.AutoSize = true;
            this.labelDescription.Location = new System.Drawing.Point(17, 63);
            this.labelDescription.Margin = new System.Windows.Forms.Padding(3, 9, 3, 9);
            this.labelDescription.Name = "labelDescription";
            this.labelDescription.Size = new System.Drawing.Size(286, 15);
            this.labelDescription.TabIndex = 2;
            this.labelDescription.Text = "A tool for connecting to the Ripple payment network";
            // 
            // linkViewSourceCode
            // 
            this.linkViewSourceCode.AutoSize = true;
            this.linkViewSourceCode.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.linkViewSourceCode.Location = new System.Drawing.Point(17, 130);
            this.linkViewSourceCode.Name = "linkViewSourceCode";
            this.linkViewSourceCode.Size = new System.Drawing.Size(99, 15);
            this.linkViewSourceCode.TabIndex = 3;
            this.linkViewSourceCode.TabStop = true;
            this.linkViewSourceCode.Text = "View source code";
            this.linkViewSourceCode.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkViewSourceCode_LinkClicked);
            // 
            // AboutForm
            // 
            this.AcceptButton = this.buttonOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 162);
            this.Controls.Add(this.labelDescription);
            this.Controls.Add(this.linkViewSourceCode);
            this.Controls.Add(this.labelRippleTool);
            this.Controls.Add(this.buttonOK);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AboutForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "About RippleTool";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.Label labelRippleTool;
        private System.Windows.Forms.Label labelDescription;
        private System.Windows.Forms.LinkLabel linkViewSourceCode;
    }
}