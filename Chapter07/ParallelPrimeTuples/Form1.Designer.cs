namespace ParallelPrimeTuples
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
            this.parallelTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.iterativeTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.numGroupsLabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.numPerGroupTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.resultListBox = new System.Windows.Forms.ListBox();
            this.spacingTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.goButton = new System.Windows.Forms.Button();
            this.maxTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // parallelTextBox
            // 
            this.parallelTextBox.Location = new System.Drawing.Point(221, 56);
            this.parallelTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.parallelTextBox.Name = "parallelTextBox";
            this.parallelTextBox.Size = new System.Drawing.Size(76, 20);
            this.parallelTextBox.TabIndex = 52;
            this.parallelTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(169, 59);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 13);
            this.label5.TabIndex = 54;
            this.label5.Text = "Parallel:";
            // 
            // iterativeTextBox
            // 
            this.iterativeTextBox.Location = new System.Drawing.Point(221, 33);
            this.iterativeTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.iterativeTextBox.Name = "iterativeTextBox";
            this.iterativeTextBox.Size = new System.Drawing.Size(76, 20);
            this.iterativeTextBox.TabIndex = 51;
            this.iterativeTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(169, 36);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 13);
            this.label6.TabIndex = 53;
            this.label6.Text = "Iterative:";
            // 
            // numGroupsLabel
            // 
            this.numGroupsLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.numGroupsLabel.AutoSize = true;
            this.numGroupsLabel.Location = new System.Drawing.Point(67, 183);
            this.numGroupsLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.numGroupsLabel.Name = "numGroupsLabel";
            this.numGroupsLabel.Size = new System.Drawing.Size(0, 13);
            this.numGroupsLabel.TabIndex = 50;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 183);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 13);
            this.label4.TabIndex = 49;
            this.label4.Text = "# Groups:";
            // 
            // numPerGroupTextBox
            // 
            this.numPerGroupTextBox.Location = new System.Drawing.Point(82, 56);
            this.numPerGroupTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.numPerGroupTextBox.Name = "numPerGroupTextBox";
            this.numPerGroupTextBox.Size = new System.Drawing.Size(76, 20);
            this.numPerGroupTextBox.TabIndex = 43;
            this.numPerGroupTextBox.Text = "2";
            this.numPerGroupTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 59);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 13);
            this.label3.TabIndex = 48;
            this.label3.Text = "# Per Group:";
            // 
            // resultListBox
            // 
            this.resultListBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.resultListBox.FormattingEnabled = true;
            this.resultListBox.IntegralHeight = false;
            this.resultListBox.Location = new System.Drawing.Point(10, 80);
            this.resultListBox.Margin = new System.Windows.Forms.Padding(2);
            this.resultListBox.Name = "resultListBox";
            this.resultListBox.Size = new System.Drawing.Size(287, 102);
            this.resultListBox.TabIndex = 45;
            // 
            // spacingTextBox
            // 
            this.spacingTextBox.Location = new System.Drawing.Point(82, 33);
            this.spacingTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.spacingTextBox.Name = "spacingTextBox";
            this.spacingTextBox.Size = new System.Drawing.Size(76, 20);
            this.spacingTextBox.TabIndex = 42;
            this.spacingTextBox.Text = "2";
            this.spacingTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 36);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 47;
            this.label2.Text = "Spacing:";
            // 
            // goButton
            // 
            this.goButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.goButton.Location = new System.Drawing.Point(241, 10);
            this.goButton.Margin = new System.Windows.Forms.Padding(2);
            this.goButton.Name = "goButton";
            this.goButton.Size = new System.Drawing.Size(56, 19);
            this.goButton.TabIndex = 44;
            this.goButton.Text = "Go";
            this.goButton.UseVisualStyleBackColor = true;
            this.goButton.Click += new System.EventHandler(this.goButton_Click);
            // 
            // maxTextBox
            // 
            this.maxTextBox.Location = new System.Drawing.Point(82, 11);
            this.maxTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.maxTextBox.Name = "maxTextBox";
            this.maxTextBox.Size = new System.Drawing.Size(76, 20);
            this.maxTextBox.TabIndex = 41;
            this.maxTextBox.Text = "1000000";
            this.maxTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 13);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 46;
            this.label1.Text = "Max:";
            // 
            // Form1
            // 
            this.AcceptButton = this.goButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(307, 206);
            this.Controls.Add(this.parallelTextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.iterativeTextBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.numGroupsLabel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.numPerGroupTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.resultListBox);
            this.Controls.Add(this.spacingTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.goButton);
            this.Controls.Add(this.maxTextBox);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "ParallelPrimeTuples";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox parallelTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox iterativeTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label numGroupsLabel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox numPerGroupTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox resultListBox;
        private System.Windows.Forms.TextBox spacingTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button goButton;
        private System.Windows.Forms.TextBox maxTextBox;
        private System.Windows.Forms.Label label1;
    }
}

