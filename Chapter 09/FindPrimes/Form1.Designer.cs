namespace FindPrimes
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
            this.startTextBox = new System.Windows.Forms.TextBox();
            this.desiredProbTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.findButton = new System.Windows.Forms.Button();
            this.primeTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.probPrimeTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.numTestsTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Starting #:";
            // 
            // startTextBox
            // 
            this.startTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.startTextBox.Location = new System.Drawing.Point(115, 12);
            this.startTextBox.Name = "startTextBox";
            this.startTextBox.Size = new System.Drawing.Size(209, 20);
            this.startTextBox.TabIndex = 0;
            this.startTextBox.Text = "1000000000000";
            this.startTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // desiredProbTextBox
            // 
            this.desiredProbTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.desiredProbTextBox.Location = new System.Drawing.Point(115, 38);
            this.desiredProbTextBox.Name = "desiredProbTextBox";
            this.desiredProbTextBox.Size = new System.Drawing.Size(209, 20);
            this.desiredProbTextBox.TabIndex = 1;
            this.desiredProbTextBox.Text = "0.999999";
            this.desiredProbTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Desired Probability:";
            // 
            // findButton
            // 
            this.findButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.findButton.Location = new System.Drawing.Point(131, 75);
            this.findButton.Name = "findButton";
            this.findButton.Size = new System.Drawing.Size(75, 23);
            this.findButton.TabIndex = 2;
            this.findButton.Text = "Find";
            this.findButton.UseVisualStyleBackColor = true;
            this.findButton.Click += new System.EventHandler(this.findButton_Click);
            // 
            // primeTextBox
            // 
            this.primeTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.primeTextBox.Location = new System.Drawing.Point(115, 119);
            this.primeTextBox.Name = "primeTextBox";
            this.primeTextBox.ReadOnly = true;
            this.primeTextBox.Size = new System.Drawing.Size(209, 20);
            this.primeTextBox.TabIndex = 3;
            this.primeTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Prime:";
            // 
            // probPrimeTextBox
            // 
            this.probPrimeTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.probPrimeTextBox.Location = new System.Drawing.Point(115, 171);
            this.probPrimeTextBox.Name = "probPrimeTextBox";
            this.probPrimeTextBox.ReadOnly = true;
            this.probPrimeTextBox.Size = new System.Drawing.Size(209, 20);
            this.probPrimeTextBox.TabIndex = 5;
            this.probPrimeTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 174);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Probability Prime:";
            // 
            // numTestsTextBox
            // 
            this.numTestsTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.numTestsTextBox.Location = new System.Drawing.Point(115, 145);
            this.numTestsTextBox.Name = "numTestsTextBox";
            this.numTestsTextBox.ReadOnly = true;
            this.numTestsTextBox.Size = new System.Drawing.Size(209, 20);
            this.numTestsTextBox.TabIndex = 4;
            this.numTestsTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 148);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "# Tests:";
            // 
            // Form1
            // 
            this.AcceptButton = this.findButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(336, 204);
            this.Controls.Add(this.numTestsTextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.probPrimeTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.primeTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.findButton);
            this.Controls.Add(this.desiredProbTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.startTextBox);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "FindPrimes";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox startTextBox;
        private System.Windows.Forms.TextBox desiredProbTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button findButton;
        private System.Windows.Forms.TextBox primeTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox probPrimeTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox numTestsTextBox;
        private System.Windows.Forms.Label label5;
    }
}

