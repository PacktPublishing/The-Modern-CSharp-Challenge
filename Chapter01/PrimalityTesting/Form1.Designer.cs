namespace PrimalityTesting
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
            this.isPrimeLabel = new System.Windows.Forms.Label();
            this.goButton = new System.Windows.Forms.Button();
            this.numberTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // isPrimeLabel
            // 
            this.isPrimeLabel.AutoSize = true;
            this.isPrimeLabel.Location = new System.Drawing.Point(11, 69);
            this.isPrimeLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.isPrimeLabel.Name = "isPrimeLabel";
            this.isPrimeLabel.Size = new System.Drawing.Size(0, 13);
            this.isPrimeLabel.TabIndex = 7;
            // 
            // goButton
            // 
            this.goButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.goButton.Location = new System.Drawing.Point(219, 12);
            this.goButton.Margin = new System.Windows.Forms.Padding(2);
            this.goButton.Name = "goButton";
            this.goButton.Size = new System.Drawing.Size(56, 19);
            this.goButton.TabIndex = 6;
            this.goButton.Text = "Go";
            this.goButton.UseVisualStyleBackColor = true;
            this.goButton.Click += new System.EventHandler(this.goButton_Click);
            // 
            // numberTextBox
            // 
            this.numberTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.numberTextBox.Location = new System.Drawing.Point(62, 12);
            this.numberTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.numberTextBox.Name = "numberTextBox";
            this.numberTextBox.Size = new System.Drawing.Size(147, 20);
            this.numberTextBox.TabIndex = 5;
            this.numberTextBox.Text = "1234567891";
            this.numberTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 15);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Number:";
            // 
            // Form1
            // 
            this.AcceptButton = this.goButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 91);
            this.Controls.Add(this.isPrimeLabel);
            this.Controls.Add(this.goButton);
            this.Controls.Add(this.numberTextBox);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "PrimalityTesting";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label isPrimeLabel;
        private System.Windows.Forms.Button goButton;
        private System.Windows.Forms.TextBox numberTextBox;
        private System.Windows.Forms.Label label1;
    }
}

