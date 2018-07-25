namespace FibonacciNumbers
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
            this.tableTimeTextBox = new System.Windows.Forms.TextBox();
            this.tableTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.nonRecursiveTimeTextBox = new System.Windows.Forms.TextBox();
            this.recursiveTimeTextBox = new System.Windows.Forms.TextBox();
            this.nonRecursiveTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.recursiveTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.goButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cacheTimeTextBox = new System.Windows.Forms.TextBox();
            this.cacheTextBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.numberTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // tableTimeTextBox
            // 
            this.tableTimeTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tableTimeTextBox.Location = new System.Drawing.Point(295, 156);
            this.tableTimeTextBox.Name = "tableTimeTextBox";
            this.tableTimeTextBox.ReadOnly = true;
            this.tableTimeTextBox.Size = new System.Drawing.Size(75, 22);
            this.tableTimeTextBox.TabIndex = 7;
            this.tableTimeTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tableTextBox
            // 
            this.tableTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableTextBox.Location = new System.Drawing.Point(117, 156);
            this.tableTextBox.Name = "tableTextBox";
            this.tableTextBox.ReadOnly = true;
            this.tableTextBox.Size = new System.Drawing.Size(172, 22);
            this.tableTextBox.TabIndex = 6;
            this.tableTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(10, 159);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 17);
            this.label6.TabIndex = 40;
            this.label6.Text = "Table:";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(292, 80);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 17);
            this.label5.TabIndex = 39;
            this.label5.Text = "Time (sec)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(114, 80);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 17);
            this.label4.TabIndex = 38;
            this.label4.Text = "Result:";
            // 
            // nonRecursiveTimeTextBox
            // 
            this.nonRecursiveTimeTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.nonRecursiveTimeTextBox.Location = new System.Drawing.Point(295, 128);
            this.nonRecursiveTimeTextBox.Name = "nonRecursiveTimeTextBox";
            this.nonRecursiveTimeTextBox.ReadOnly = true;
            this.nonRecursiveTimeTextBox.Size = new System.Drawing.Size(75, 22);
            this.nonRecursiveTimeTextBox.TabIndex = 5;
            this.nonRecursiveTimeTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // recursiveTimeTextBox
            // 
            this.recursiveTimeTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.recursiveTimeTextBox.Location = new System.Drawing.Point(295, 100);
            this.recursiveTimeTextBox.Name = "recursiveTimeTextBox";
            this.recursiveTimeTextBox.ReadOnly = true;
            this.recursiveTimeTextBox.Size = new System.Drawing.Size(75, 22);
            this.recursiveTimeTextBox.TabIndex = 3;
            this.recursiveTimeTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // nonRecursiveTextBox
            // 
            this.nonRecursiveTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.nonRecursiveTextBox.Location = new System.Drawing.Point(117, 128);
            this.nonRecursiveTextBox.Name = "nonRecursiveTextBox";
            this.nonRecursiveTextBox.ReadOnly = true;
            this.nonRecursiveTextBox.Size = new System.Drawing.Size(172, 22);
            this.nonRecursiveTextBox.TabIndex = 4;
            this.nonRecursiveTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 17);
            this.label3.TabIndex = 37;
            this.label3.Text = "Non-Recursive:";
            // 
            // recursiveTextBox
            // 
            this.recursiveTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.recursiveTextBox.Location = new System.Drawing.Point(117, 100);
            this.recursiveTextBox.Name = "recursiveTextBox";
            this.recursiveTextBox.ReadOnly = true;
            this.recursiveTextBox.Size = new System.Drawing.Size(172, 22);
            this.recursiveTextBox.TabIndex = 2;
            this.recursiveTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 17);
            this.label2.TabIndex = 36;
            this.label2.Text = "Recursive:";
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 17);
            this.label1.TabIndex = 35;
            this.label1.Text = "Number:";
            // 
            // cacheTimeTextBox
            // 
            this.cacheTimeTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cacheTimeTextBox.Location = new System.Drawing.Point(295, 184);
            this.cacheTimeTextBox.Name = "cacheTimeTextBox";
            this.cacheTimeTextBox.ReadOnly = true;
            this.cacheTimeTextBox.Size = new System.Drawing.Size(75, 22);
            this.cacheTimeTextBox.TabIndex = 9;
            this.cacheTimeTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // cacheTextBox
            // 
            this.cacheTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cacheTextBox.Location = new System.Drawing.Point(117, 184);
            this.cacheTextBox.Name = "cacheTextBox";
            this.cacheTextBox.ReadOnly = true;
            this.cacheTextBox.Size = new System.Drawing.Size(172, 22);
            this.cacheTextBox.TabIndex = 8;
            this.cacheTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(10, 187);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 17);
            this.label7.TabIndex = 43;
            this.label7.Text = "Cached:";
            // 
            // numberTextBox
            // 
            this.numberTextBox.Location = new System.Drawing.Point(117, 12);
            this.numberTextBox.Name = "numberTextBox";
            this.numberTextBox.Size = new System.Drawing.Size(36, 22);
            this.numberTextBox.TabIndex = 0;
            this.numberTextBox.Text = "35";
            this.numberTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Form1
            // 
            this.AcceptButton = this.goButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(382, 218);
            this.Controls.Add(this.numberTextBox);
            this.Controls.Add(this.cacheTimeTextBox);
            this.Controls.Add(this.cacheTextBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tableTimeTextBox);
            this.Controls.Add(this.tableTextBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.nonRecursiveTimeTextBox);
            this.Controls.Add(this.recursiveTimeTextBox);
            this.Controls.Add(this.nonRecursiveTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.recursiveTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.goButton);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "FibonacciNumbers";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tableTimeTextBox;
        private System.Windows.Forms.TextBox tableTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox nonRecursiveTimeTextBox;
        private System.Windows.Forms.TextBox recursiveTimeTextBox;
        private System.Windows.Forms.TextBox nonRecursiveTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox recursiveTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button goButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox cacheTimeTextBox;
        private System.Windows.Forms.TextBox cacheTextBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox numberTextBox;
    }
}

