namespace ProperDivisors
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
            this.method2TextBox = new System.Windows.Forms.TextBox();
            this.method2TimeTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.method1TextBox = new System.Windows.Forms.TextBox();
            this.method1TimeTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.goButton = new System.Windows.Forms.Button();
            this.numberTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.numFactorsLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // method2TextBox
            // 
            this.method2TextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.method2TextBox.Location = new System.Drawing.Point(95, 89);
            this.method2TextBox.Name = "method2TextBox";
            this.method2TextBox.ReadOnly = true;
            this.method2TextBox.Size = new System.Drawing.Size(194, 22);
            this.method2TextBox.TabIndex = 4;
            // 
            // method2TimeTextBox
            // 
            this.method2TimeTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.method2TimeTextBox.Location = new System.Drawing.Point(295, 89);
            this.method2TimeTextBox.Name = "method2TimeTextBox";
            this.method2TimeTextBox.ReadOnly = true;
            this.method2TimeTextBox.Size = new System.Drawing.Size(75, 22);
            this.method2TimeTextBox.TabIndex = 5;
            this.method2TimeTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 17);
            this.label3.TabIndex = 35;
            this.label3.Text = "Method 2:";
            // 
            // method1TextBox
            // 
            this.method1TextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.method1TextBox.Location = new System.Drawing.Point(95, 61);
            this.method1TextBox.Name = "method1TextBox";
            this.method1TextBox.ReadOnly = true;
            this.method1TextBox.Size = new System.Drawing.Size(194, 22);
            this.method1TextBox.TabIndex = 2;
            // 
            // method1TimeTextBox
            // 
            this.method1TimeTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.method1TimeTextBox.Location = new System.Drawing.Point(295, 61);
            this.method1TimeTextBox.Name = "method1TimeTextBox";
            this.method1TimeTextBox.ReadOnly = true;
            this.method1TimeTextBox.Size = new System.Drawing.Size(75, 22);
            this.method1TimeTextBox.TabIndex = 3;
            this.method1TimeTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 17);
            this.label2.TabIndex = 32;
            this.label2.Text = "Method 1:";
            // 
            // goButton
            // 
            this.goButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.goButton.Location = new System.Drawing.Point(295, 12);
            this.goButton.Name = "goButton";
            this.goButton.Size = new System.Drawing.Size(75, 23);
            this.goButton.TabIndex = 1;
            this.goButton.Text = "Go";
            this.goButton.UseVisualStyleBackColor = true;
            this.goButton.Click += new System.EventHandler(this.goButton_Click);
            // 
            // numberTextBox
            // 
            this.numberTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.numberTextBox.Location = new System.Drawing.Point(95, 13);
            this.numberTextBox.Name = "numberTextBox";
            this.numberTextBox.Size = new System.Drawing.Size(194, 22);
            this.numberTextBox.TabIndex = 0;
            this.numberTextBox.Text = "123456780";
            this.numberTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 17);
            this.label1.TabIndex = 29;
            this.label1.Text = "Number:";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 127);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 17);
            this.label5.TabIndex = 41;
            this.label5.Text = "# Factors:";
            // 
            // numFactorsLabel
            // 
            this.numFactorsLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.numFactorsLabel.AutoSize = true;
            this.numFactorsLabel.Location = new System.Drawing.Point(89, 127);
            this.numFactorsLabel.Name = "numFactorsLabel";
            this.numFactorsLabel.Size = new System.Drawing.Size(0, 17);
            this.numFactorsLabel.TabIndex = 42;
            // 
            // Form1
            // 
            this.AcceptButton = this.goButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(382, 153);
            this.Controls.Add(this.numFactorsLabel);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.method2TextBox);
            this.Controls.Add(this.method2TimeTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.method1TextBox);
            this.Controls.Add(this.method1TimeTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.goButton);
            this.Controls.Add(this.numberTextBox);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "ProperDivisors";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox method2TextBox;
        private System.Windows.Forms.TextBox method2TimeTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox method1TextBox;
        private System.Windows.Forms.TextBox method1TimeTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button goButton;
        private System.Windows.Forms.TextBox numberTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label numFactorsLabel;
    }
}

