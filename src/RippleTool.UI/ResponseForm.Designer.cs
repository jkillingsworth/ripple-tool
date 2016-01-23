namespace RippleTool.UI
{
    partial class ResponseForm
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
            this.textDisplay = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // textDisplay
            // 
            this.textDisplay.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textDisplay.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textDisplay.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textDisplay.Location = new System.Drawing.Point(0, 0);
            this.textDisplay.Multiline = true;
            this.textDisplay.Name = "textDisplay";
            this.textDisplay.ReadOnly = true;
            this.textDisplay.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textDisplay.Size = new System.Drawing.Size(284, 262);
            this.textDisplay.TabIndex = 0;
            this.textDisplay.WordWrap = false;
            // 
            // ResponseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.textDisplay);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "ResponseForm";
            this.Text = "Response";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textDisplay;
    }
}