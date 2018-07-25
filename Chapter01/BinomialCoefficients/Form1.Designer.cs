namespace BinomialCoefficients
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
            this.recursiveTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.calculatedTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.goButton = new System.Windows.Forms.Button();
            this.nTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.kTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cancelingTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // recursiveTextBox
            // 
            this.recursiveTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.recursiveTextBox.Location = new System.Drawing.Point(96, 154);
            this.recursiveTextBox.Name = "recursiveTextBox";
            this.recursiveTextBox.Size = new System.Drawing.Size(294, 22);
            this.recursiveTextBox.TabIndex = 4;
            this.recursiveTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 157);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 17);
            this.label3.TabIndex = 12;
            this.label3.Text = "Recursive:";
            // 
            // calculatedTextBox
            // 
            this.calculatedTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.calculatedTextBox.Location = new System.Drawing.Point(96, 126);
            this.calculatedTextBox.Name = "calculatedTextBox";
            this.calculatedTextBox.Size = new System.Drawing.Size(294, 22);
            this.calculatedTextBox.TabIndex = 3;
            this.calculatedTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 17);
            this.label2.TabIndex = 10;
            this.label2.Text = "Calculated:";
            // 
            // goButton
            // 
            this.goButton.Location = new System.Drawing.Point(96, 26);
            this.goButton.Name = "goButton";
            this.goButton.Size = new System.Drawing.Size(75, 23);
            this.goButton.TabIndex = 2;
            this.goButton.Text = "Go";
            this.goButton.UseVisualStyleBackColor = true;
            this.goButton.Click += new System.EventHandler(this.goButton_Click);
            // 
            // nTextBox
            // 
            this.nTextBox.Location = new System.Drawing.Point(40, 12);
            this.nTextBox.Name = "nTextBox";
            this.nTextBox.Size = new System.Drawing.Size(34, 22);
            this.nTextBox.TabIndex = 0;
            this.nTextBox.Text = "28";
            this.nTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(22, 17);
            this.label1.TabIndex = 7;
            this.label1.Text = "N:";
            // 
            // kTextBox
            // 
            this.kTextBox.Location = new System.Drawing.Point(40, 40);
            this.kTextBox.Name = "kTextBox";
            this.kTextBox.Size = new System.Drawing.Size(34, 22);
            this.kTextBox.TabIndex = 1;
            this.kTextBox.Text = "3";
            this.kTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 43);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(21, 17);
            this.label4.TabIndex = 14;
            this.label4.Text = "K:";
            // 
            // cancelingTextBox
            // 
            this.cancelingTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cancelingTextBox.Location = new System.Drawing.Point(96, 182);
            this.cancelingTextBox.Name = "cancelingTextBox";
            this.cancelingTextBox.Size = new System.Drawing.Size(294, 22);
            this.cancelingTextBox.TabIndex = 5;
            this.cancelingTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 185);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 17);
            this.label5.TabIndex = 16;
            this.label5.Text = "Canceling:";
            // 
            // Form1
            // 
            this.AcceptButton = this.goButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(402, 216);
            this.Controls.Add(this.cancelingTextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.kTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.recursiveTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.calculatedTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.goButton);
            this.Controls.Add(this.nTextBox);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "BinomialCoefficients";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox recursiveTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox calculatedTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button goButton;
        private System.Windows.Forms.TextBox nTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox kTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox cancelingTextBox;
        private System.Windows.Forms.Label label5;
    }
}

