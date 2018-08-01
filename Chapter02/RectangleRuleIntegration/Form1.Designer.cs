namespace RectangleRuleIntegration
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
            this.errorLabel = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.calculatedLabel = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.yMaxTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.yMinTextBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.estimatedLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.functionComboBox = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.graphPictureBox = new System.Windows.Forms.PictureBox();
            this.xMaxTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.xMinTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.goButton = new System.Windows.Forms.Button();
            this.numPointsTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.graphPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // errorLabel
            // 
            this.errorLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.errorLabel.AutoSize = true;
            this.errorLabel.Location = new System.Drawing.Point(288, 339);
            this.errorLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.errorLabel.Name = "errorLabel";
            this.errorLabel.Size = new System.Drawing.Size(0, 13);
            this.errorLabel.TabIndex = 81;
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(252, 339);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(32, 13);
            this.label10.TabIndex = 80;
            this.label10.Text = "Error:";
            // 
            // calculatedLabel
            // 
            this.calculatedLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.calculatedLabel.AutoSize = true;
            this.calculatedLabel.Location = new System.Drawing.Point(187, 339);
            this.calculatedLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.calculatedLabel.Name = "calculatedLabel";
            this.calculatedLabel.Size = new System.Drawing.Size(0, 13);
            this.calculatedLabel.TabIndex = 79;
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(127, 339);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(60, 13);
            this.label9.TabIndex = 78;
            this.label9.Text = "Calculated:";
            // 
            // yMaxTextBox
            // 
            this.yMaxTextBox.Location = new System.Drawing.Point(192, 57);
            this.yMaxTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.yMaxTextBox.Name = "yMaxTextBox";
            this.yMaxTextBox.Size = new System.Drawing.Size(57, 20);
            this.yMaxTextBox.TabIndex = 5;
            this.yMaxTextBox.Text = "5";
            this.yMaxTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(150, 62);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 77;
            this.label5.Text = "Max Y:";
            // 
            // yMinTextBox
            // 
            this.yMinTextBox.Location = new System.Drawing.Point(192, 36);
            this.yMinTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.yMinTextBox.Name = "yMinTextBox";
            this.yMinTextBox.Size = new System.Drawing.Size(57, 20);
            this.yMinTextBox.TabIndex = 2;
            this.yMinTextBox.Text = "-5";
            this.yMinTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(150, 40);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(37, 13);
            this.label7.TabIndex = 76;
            this.label7.Text = "Min Y:";
            // 
            // estimatedLabel
            // 
            this.estimatedLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.estimatedLabel.AutoSize = true;
            this.estimatedLabel.Location = new System.Drawing.Point(65, 339);
            this.estimatedLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.estimatedLabel.Name = "estimatedLabel";
            this.estimatedLabel.Size = new System.Drawing.Size(0, 13);
            this.estimatedLabel.TabIndex = 75;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 339);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 74;
            this.label2.Text = "Estimate:";
            // 
            // functionComboBox
            // 
            this.functionComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.functionComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.functionComboBox.FormattingEnabled = true;
            this.functionComboBox.Items.AddRange(new object[] {
            "x^2 + 1",
            "x^3 - 2 * x^2 + 3",
            "Sin(x) + Cos(2 * x) + 2.5"});
            this.functionComboBox.Location = new System.Drawing.Point(70, 9);
            this.functionComboBox.Margin = new System.Windows.Forms.Padding(2);
            this.functionComboBox.Name = "functionComboBox";
            this.functionComboBox.Size = new System.Drawing.Size(245, 21);
            this.functionComboBox.TabIndex = 0;
            this.functionComboBox.SelectedIndexChanged += new System.EventHandler(this.functionComboBox_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 11);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 13);
            this.label6.TabIndex = 73;
            this.label6.Text = "Function:";
            // 
            // graphPictureBox
            // 
            this.graphPictureBox.BackColor = System.Drawing.Color.White;
            this.graphPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.graphPictureBox.Location = new System.Drawing.Point(11, 81);
            this.graphPictureBox.Margin = new System.Windows.Forms.Padding(2);
            this.graphPictureBox.Name = "graphPictureBox";
            this.graphPictureBox.Size = new System.Drawing.Size(256, 256);
            this.graphPictureBox.TabIndex = 72;
            this.graphPictureBox.TabStop = false;
            // 
            // xMaxTextBox
            // 
            this.xMaxTextBox.Location = new System.Drawing.Point(70, 57);
            this.xMaxTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.xMaxTextBox.Name = "xMaxTextBox";
            this.xMaxTextBox.Size = new System.Drawing.Size(57, 20);
            this.xMaxTextBox.TabIndex = 4;
            this.xMaxTextBox.Text = "5";
            this.xMaxTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 62);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 71;
            this.label4.Text = "Max X:";
            // 
            // xMinTextBox
            // 
            this.xMinTextBox.Location = new System.Drawing.Point(70, 36);
            this.xMinTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.xMinTextBox.Name = "xMinTextBox";
            this.xMinTextBox.Size = new System.Drawing.Size(57, 20);
            this.xMinTextBox.TabIndex = 1;
            this.xMinTextBox.Text = "-5";
            this.xMinTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 40);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 70;
            this.label3.Text = "Min X:";
            // 
            // goButton
            // 
            this.goButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.goButton.Location = new System.Drawing.Point(319, 9);
            this.goButton.Margin = new System.Windows.Forms.Padding(2);
            this.goButton.Name = "goButton";
            this.goButton.Size = new System.Drawing.Size(56, 19);
            this.goButton.TabIndex = 6;
            this.goButton.Text = "Go";
            this.goButton.UseVisualStyleBackColor = true;
            this.goButton.Click += new System.EventHandler(this.goButton_Click);
            // 
            // numPointsTextBox
            // 
            this.numPointsTextBox.Location = new System.Drawing.Point(316, 37);
            this.numPointsTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.numPointsTextBox.Name = "numPointsTextBox";
            this.numPointsTextBox.Size = new System.Drawing.Size(57, 20);
            this.numPointsTextBox.TabIndex = 3;
            this.numPointsTextBox.Text = "10";
            this.numPointsTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(264, 40);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 69;
            this.label1.Text = "# Slices:";
            // 
            // Form1
            // 
            this.AcceptButton = this.goButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 361);
            this.Controls.Add(this.errorLabel);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.calculatedLabel);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.yMaxTextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.yMinTextBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.estimatedLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.functionComboBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.graphPictureBox);
            this.Controls.Add(this.xMaxTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.xMinTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.goButton);
            this.Controls.Add(this.numPointsTextBox);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "RectangleRuleIntegration";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.graphPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label errorLabel;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label calculatedLabel;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox yMaxTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox yMinTextBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label estimatedLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox functionComboBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox graphPictureBox;
        private System.Windows.Forms.TextBox xMaxTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox xMinTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button goButton;
        private System.Windows.Forms.TextBox numPointsTextBox;
        private System.Windows.Forms.Label label1;
    }
}

