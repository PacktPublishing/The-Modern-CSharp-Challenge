namespace BisectionRootFinding
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
            this.functionComboBox = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.graphPictureBox = new System.Windows.Forms.PictureBox();
            this.maxErrorTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.xMaxTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.xMinTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.rootsListBox = new System.Windows.Forms.ListBox();
            this.goButton = new System.Windows.Forms.Button();
            this.numTestsTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.graphPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // functionComboBox
            // 
            this.functionComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.functionComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.functionComboBox.FormattingEnabled = true;
            this.functionComboBox.Items.AddRange(new object[] {
            "x^2 - 4",
            "x^3 - x^2 + 3",
            "(x^4 + 2 * x^3 - 12 * x^2 - 2 * x + 6) / 10"});
            this.functionComboBox.Location = new System.Drawing.Point(70, 9);
            this.functionComboBox.Margin = new System.Windows.Forms.Padding(2);
            this.functionComboBox.Name = "functionComboBox";
            this.functionComboBox.Size = new System.Drawing.Size(245, 21);
            this.functionComboBox.TabIndex = 24;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 11);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 13);
            this.label6.TabIndex = 37;
            this.label6.Text = "Function:";
            // 
            // graphPictureBox
            // 
            this.graphPictureBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.graphPictureBox.BackColor = System.Drawing.Color.White;
            this.graphPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.graphPictureBox.Location = new System.Drawing.Point(143, 112);
            this.graphPictureBox.Margin = new System.Windows.Forms.Padding(2);
            this.graphPictureBox.Name = "graphPictureBox";
            this.graphPictureBox.Size = new System.Drawing.Size(233, 239);
            this.graphPictureBox.TabIndex = 36;
            this.graphPictureBox.TabStop = false;
            // 
            // maxErrorTextBox
            // 
            this.maxErrorTextBox.Location = new System.Drawing.Point(200, 57);
            this.maxErrorTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.maxErrorTextBox.Name = "maxErrorTextBox";
            this.maxErrorTextBox.Size = new System.Drawing.Size(57, 20);
            this.maxErrorTextBox.TabIndex = 28;
            this.maxErrorTextBox.Text = "0.0001";
            this.maxErrorTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(141, 62);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 13);
            this.label5.TabIndex = 35;
            this.label5.Text = "Max Error:";
            // 
            // xMaxTextBox
            // 
            this.xMaxTextBox.Location = new System.Drawing.Point(70, 57);
            this.xMaxTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.xMaxTextBox.Name = "xMaxTextBox";
            this.xMaxTextBox.Size = new System.Drawing.Size(57, 20);
            this.xMaxTextBox.TabIndex = 27;
            this.xMaxTextBox.Text = "10";
            this.xMaxTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 62);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 34;
            this.label4.Text = "Max X:";
            // 
            // xMinTextBox
            // 
            this.xMinTextBox.Location = new System.Drawing.Point(70, 36);
            this.xMinTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.xMinTextBox.Name = "xMinTextBox";
            this.xMinTextBox.Size = new System.Drawing.Size(57, 20);
            this.xMinTextBox.TabIndex = 25;
            this.xMinTextBox.Text = "-10";
            this.xMinTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 40);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 33;
            this.label3.Text = "Min X:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 96);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 32;
            this.label2.Text = "Roots:";
            // 
            // rootsListBox
            // 
            this.rootsListBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.rootsListBox.FormattingEnabled = true;
            this.rootsListBox.IntegralHeight = false;
            this.rootsListBox.Location = new System.Drawing.Point(11, 112);
            this.rootsListBox.Margin = new System.Windows.Forms.Padding(2);
            this.rootsListBox.Name = "rootsListBox";
            this.rootsListBox.Size = new System.Drawing.Size(128, 239);
            this.rootsListBox.TabIndex = 30;
            // 
            // goButton
            // 
            this.goButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.goButton.Location = new System.Drawing.Point(319, 9);
            this.goButton.Margin = new System.Windows.Forms.Padding(2);
            this.goButton.Name = "goButton";
            this.goButton.Size = new System.Drawing.Size(56, 19);
            this.goButton.TabIndex = 29;
            this.goButton.Text = "Go";
            this.goButton.UseVisualStyleBackColor = true;
            this.goButton.Click += new System.EventHandler(this.goButton_Click);
            // 
            // numTestsTextBox
            // 
            this.numTestsTextBox.Location = new System.Drawing.Point(200, 36);
            this.numTestsTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.numTestsTextBox.Name = "numTestsTextBox";
            this.numTestsTextBox.Size = new System.Drawing.Size(57, 20);
            this.numTestsTextBox.TabIndex = 26;
            this.numTestsTextBox.Text = "10";
            this.numTestsTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(141, 39);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 31;
            this.label1.Text = "# Tests:";
            // 
            // Form1
            // 
            this.AcceptButton = this.goButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 361);
            this.Controls.Add(this.functionComboBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.graphPictureBox);
            this.Controls.Add(this.maxErrorTextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.xMaxTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.xMinTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.rootsListBox);
            this.Controls.Add(this.goButton);
            this.Controls.Add(this.numTestsTextBox);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "BisectionRootFinding";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.graphPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox functionComboBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox graphPictureBox;
        private System.Windows.Forms.TextBox maxErrorTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox xMaxTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox xMinTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox rootsListBox;
        private System.Windows.Forms.Button goButton;
        private System.Windows.Forms.TextBox numTestsTextBox;
        private System.Windows.Forms.Label label1;
    }
}

