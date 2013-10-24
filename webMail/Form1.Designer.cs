namespace webMail
{
    partial class Form1
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
            this.urlLbl = new System.Windows.Forms.Label();
            this.goBtn = new System.Windows.Forms.Button();
            this.urlBox = new System.Windows.Forms.TextBox();
            this.depthBox = new System.Windows.Forms.TextBox();
            this.depthLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // urlLbl
            // 
            this.urlLbl.AutoSize = true;
            this.urlLbl.Location = new System.Drawing.Point(12, 28);
            this.urlLbl.Name = "urlLbl";
            this.urlLbl.Size = new System.Drawing.Size(29, 13);
            this.urlLbl.TabIndex = 0;
            this.urlLbl.Text = "URL";
            // 
            // goBtn
            // 
            this.goBtn.Location = new System.Drawing.Point(207, 94);
            this.goBtn.Name = "goBtn";
            this.goBtn.Size = new System.Drawing.Size(75, 23);
            this.goBtn.TabIndex = 1;
            this.goBtn.Text = "GO";
            this.goBtn.UseVisualStyleBackColor = true;
            this.goBtn.Click += new System.EventHandler(this.goBtn_Click);
            // 
            // urlBox
            // 
            this.urlBox.Location = new System.Drawing.Point(53, 28);
            this.urlBox.Name = "urlBox";
            this.urlBox.Size = new System.Drawing.Size(418, 20);
            this.urlBox.TabIndex = 2;
            // 
            // depthBox
            // 
            this.depthBox.Location = new System.Drawing.Point(53, 54);
            this.depthBox.Name = "depthBox";
            this.depthBox.Size = new System.Drawing.Size(28, 20);
            this.depthBox.TabIndex = 4;
            this.depthBox.Text = "0";
            // 
            // depthLbl
            // 
            this.depthLbl.AutoSize = true;
            this.depthLbl.Location = new System.Drawing.Point(12, 54);
            this.depthLbl.Name = "depthLbl";
            this.depthLbl.Size = new System.Drawing.Size(36, 13);
            this.depthLbl.TabIndex = 3;
            this.depthLbl.Text = "Depth";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(507, 129);
            this.Controls.Add(this.depthBox);
            this.Controls.Add(this.depthLbl);
            this.Controls.Add(this.urlBox);
            this.Controls.Add(this.goBtn);
            this.Controls.Add(this.urlLbl);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label urlLbl;
        private System.Windows.Forms.Button goBtn;
        private System.Windows.Forms.TextBox urlBox;
        private System.Windows.Forms.TextBox depthBox;
        private System.Windows.Forms.Label depthLbl;
    }
}

