namespace YieldingFibonacciNumbers
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
            this.fiboListBox = new System.Windows.Forms.ListBox();
            this.goButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // fiboListBox
            // 
            this.fiboListBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fiboListBox.FormattingEnabled = true;
            this.fiboListBox.IntegralHeight = false;
            this.fiboListBox.Location = new System.Drawing.Point(12, 41);
            this.fiboListBox.Name = "fiboListBox";
            this.fiboListBox.Size = new System.Drawing.Size(260, 208);
            this.fiboListBox.TabIndex = 7;
            // 
            // goButton
            // 
            this.goButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.goButton.Location = new System.Drawing.Point(105, 12);
            this.goButton.Name = "goButton";
            this.goButton.Size = new System.Drawing.Size(75, 23);
            this.goButton.TabIndex = 6;
            this.goButton.Text = "Go";
            this.goButton.UseVisualStyleBackColor = true;
            this.goButton.Click += new System.EventHandler(this.goButton_Click);
            // 
            // Form1
            // 
            this.AcceptButton = this.goButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.fiboListBox);
            this.Controls.Add(this.goButton);
            this.Name = "Form1";
            this.Text = "YieldingFibonacciNumbers";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox fiboListBox;
        private System.Windows.Forms.Button goButton;
    }
}

