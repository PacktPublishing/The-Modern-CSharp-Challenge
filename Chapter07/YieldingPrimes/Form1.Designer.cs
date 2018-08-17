namespace YieldingPrimes
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
            this.label1 = new System.Windows.Forms.Label();
            this.numPrimesTextBox = new System.Windows.Forms.TextBox();
            this.goButton = new System.Windows.Forms.Button();
            this.primesListBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "# Primes:";
            // 
            // numPrimesTextBox
            // 
            this.numPrimesTextBox.Location = new System.Drawing.Point(69, 14);
            this.numPrimesTextBox.Name = "numPrimesTextBox";
            this.numPrimesTextBox.Size = new System.Drawing.Size(100, 20);
            this.numPrimesTextBox.TabIndex = 1;
            this.numPrimesTextBox.Text = "1000";
            this.numPrimesTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // goButton
            // 
            this.goButton.Location = new System.Drawing.Point(197, 12);
            this.goButton.Name = "goButton";
            this.goButton.Size = new System.Drawing.Size(75, 23);
            this.goButton.TabIndex = 2;
            this.goButton.Text = "Go";
            this.goButton.UseVisualStyleBackColor = true;
            this.goButton.Click += new System.EventHandler(this.goButton_Click);
            // 
            // primesListBox
            // 
            this.primesListBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.primesListBox.FormattingEnabled = true;
            this.primesListBox.IntegralHeight = false;
            this.primesListBox.Location = new System.Drawing.Point(12, 41);
            this.primesListBox.Name = "primesListBox";
            this.primesListBox.Size = new System.Drawing.Size(260, 208);
            this.primesListBox.TabIndex = 3;
            // 
            // Form1
            // 
            this.AcceptButton = this.goButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.primesListBox);
            this.Controls.Add(this.goButton);
            this.Controls.Add(this.numPrimesTextBox);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "YieldingPrimes";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox numPrimesTextBox;
        private System.Windows.Forms.Button goButton;
        private System.Windows.Forms.ListBox primesListBox;
    }
}

