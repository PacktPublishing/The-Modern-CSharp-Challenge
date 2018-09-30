namespace LongestCommonSubstring
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
            this.numTrialsTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.time2TextBox = new System.Windows.Forms.TextBox();
            this.time1TextBox = new System.Windows.Forms.TextBox();
            this.result2TextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.result1TextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.searchButton = new System.Windows.Forms.Button();
            this.string2TextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.string1TextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.time3TextBox = new System.Windows.Forms.TextBox();
            this.result3TextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // numTrialsTextBox
            // 
            this.numTrialsTextBox.Location = new System.Drawing.Point(64, 65);
            this.numTrialsTextBox.Name = "numTrialsTextBox";
            this.numTrialsTextBox.Size = new System.Drawing.Size(68, 20);
            this.numTrialsTextBox.TabIndex = 15;
            this.numTrialsTextBox.Text = "100";
            this.numTrialsTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 68);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 13);
            this.label5.TabIndex = 24;
            this.label5.Text = "# Trials:";
            // 
            // time2TextBox
            // 
            this.time2TextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.time2TextBox.Location = new System.Drawing.Point(186, 185);
            this.time2TextBox.Name = "time2TextBox";
            this.time2TextBox.ReadOnly = true;
            this.time2TextBox.Size = new System.Drawing.Size(86, 20);
            this.time2TextBox.TabIndex = 22;
            // 
            // time1TextBox
            // 
            this.time1TextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.time1TextBox.Location = new System.Drawing.Point(186, 159);
            this.time1TextBox.Name = "time1TextBox";
            this.time1TextBox.ReadOnly = true;
            this.time1TextBox.Size = new System.Drawing.Size(86, 20);
            this.time1TextBox.TabIndex = 19;
            // 
            // result2TextBox
            // 
            this.result2TextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.result2TextBox.Location = new System.Drawing.Point(64, 185);
            this.result2TextBox.Name = "result2TextBox";
            this.result2TextBox.ReadOnly = true;
            this.result2TextBox.Size = new System.Drawing.Size(116, 20);
            this.result2TextBox.TabIndex = 21;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 188);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 23;
            this.label4.Text = "Result 2:";
            // 
            // result1TextBox
            // 
            this.result1TextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.result1TextBox.Location = new System.Drawing.Point(64, 159);
            this.result1TextBox.Name = "result1TextBox";
            this.result1TextBox.ReadOnly = true;
            this.result1TextBox.Size = new System.Drawing.Size(116, 20);
            this.result1TextBox.TabIndex = 18;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 162);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 20;
            this.label3.Text = "Result 1:";
            // 
            // searchButton
            // 
            this.searchButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.searchButton.Location = new System.Drawing.Point(105, 96);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(75, 23);
            this.searchButton.TabIndex = 17;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // string2TextBox
            // 
            this.string2TextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.string2TextBox.Location = new System.Drawing.Point(64, 39);
            this.string2TextBox.Name = "string2TextBox";
            this.string2TextBox.Size = new System.Drawing.Size(208, 20);
            this.string2TextBox.TabIndex = 14;
            this.string2TextBox.Text = "There are people who think that honesty is always the best policy. This is a supe" +
    "rstition. There are times when the appearance of it is worth six of it.\r\n -- Mar" +
    "k Twain";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "String 2:";
            // 
            // string1TextBox
            // 
            this.string1TextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.string1TextBox.Location = new System.Drawing.Point(64, 13);
            this.string1TextBox.Name = "string1TextBox";
            this.string1TextBox.Size = new System.Drawing.Size(208, 20);
            this.string1TextBox.TabIndex = 12;
            this.string1TextBox.Text = "The secret of life is honesty and fair dealing. If you can fake that, you\'ve got " +
    "it made. -- Groucho Marx";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "String 1:";
            // 
            // time3TextBox
            // 
            this.time3TextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.time3TextBox.Location = new System.Drawing.Point(186, 211);
            this.time3TextBox.Name = "time3TextBox";
            this.time3TextBox.ReadOnly = true;
            this.time3TextBox.Size = new System.Drawing.Size(86, 20);
            this.time3TextBox.TabIndex = 26;
            // 
            // result3TextBox
            // 
            this.result3TextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.result3TextBox.Location = new System.Drawing.Point(64, 211);
            this.result3TextBox.Name = "result3TextBox";
            this.result3TextBox.ReadOnly = true;
            this.result3TextBox.Size = new System.Drawing.Size(116, 20);
            this.result3TextBox.TabIndex = 25;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 214);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 13);
            this.label6.TabIndex = 27;
            this.label6.Text = "Result 3:";
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(64, 132);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(116, 24);
            this.label7.TabIndex = 28;
            this.label7.Text = "Method";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(186, 132);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(86, 24);
            this.label8.TabIndex = 29;
            this.label8.Text = "Time (sec)";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AcceptButton = this.searchButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 243);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.time3TextBox);
            this.Controls.Add(this.result3TextBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.numTrialsTextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.time2TextBox);
            this.Controls.Add(this.time1TextBox);
            this.Controls.Add(this.result2TextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.result1TextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.string2TextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.string1TextBox);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "LongestCommonSubstring";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox numTrialsTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox time2TextBox;
        private System.Windows.Forms.TextBox time1TextBox;
        private System.Windows.Forms.TextBox result2TextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox result1TextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.TextBox string2TextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox string1TextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox time3TextBox;
        private System.Windows.Forms.TextBox result3TextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
    }
}

