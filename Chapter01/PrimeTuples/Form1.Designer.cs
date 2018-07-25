namespace PrimeTuples
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
            this.numGroupsLabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.resultListBox = new System.Windows.Forms.ListBox();
            this.spacingTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.goButton = new System.Windows.Forms.Button();
            this.maxTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.numberTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // numGroupsLabel
            // 
            this.numGroupsLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.numGroupsLabel.AutoSize = true;
            this.numGroupsLabel.Location = new System.Drawing.Point(88, 227);
            this.numGroupsLabel.Name = "numGroupsLabel";
            this.numGroupsLabel.Size = new System.Drawing.Size(0, 17);
            this.numGroupsLabel.TabIndex = 22;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 227);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 17);
            this.label4.TabIndex = 21;
            this.label4.Text = "# Groups:";
            // 
            // resultListBox
            // 
            this.resultListBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.resultListBox.FormattingEnabled = true;
            this.resultListBox.IntegralHeight = false;
            this.resultListBox.ItemHeight = 16;
            this.resultListBox.Location = new System.Drawing.Point(12, 96);
            this.resultListBox.Name = "resultListBox";
            this.resultListBox.Size = new System.Drawing.Size(318, 128);
            this.resultListBox.TabIndex = 4;
            // 
            // spacingTextBox
            // 
            this.spacingTextBox.Location = new System.Drawing.Point(80, 40);
            this.spacingTextBox.Name = "spacingTextBox";
            this.spacingTextBox.Size = new System.Drawing.Size(100, 22);
            this.spacingTextBox.TabIndex = 1;
            this.spacingTextBox.Text = "2";
            this.spacingTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 17);
            this.label2.TabIndex = 16;
            this.label2.Text = "Spacing:";
            // 
            // goButton
            // 
            this.goButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.goButton.Location = new System.Drawing.Point(255, 12);
            this.goButton.Name = "goButton";
            this.goButton.Size = new System.Drawing.Size(75, 23);
            this.goButton.TabIndex = 3;
            this.goButton.Text = "Go";
            this.goButton.UseVisualStyleBackColor = true;
            this.goButton.Click += new System.EventHandler(this.goButton_Click);
            // 
            // maxTextBox
            // 
            this.maxTextBox.Location = new System.Drawing.Point(80, 12);
            this.maxTextBox.Name = "maxTextBox";
            this.maxTextBox.Size = new System.Drawing.Size(100, 22);
            this.maxTextBox.TabIndex = 0;
            this.maxTextBox.Text = "10000";
            this.maxTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 17);
            this.label1.TabIndex = 13;
            this.label1.Text = "Max:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 17);
            this.label3.TabIndex = 19;
            this.label3.Text = "Number:";
            // 
            // numberTextBox
            // 
            this.numberTextBox.Location = new System.Drawing.Point(80, 68);
            this.numberTextBox.Name = "numberTextBox";
            this.numberTextBox.Size = new System.Drawing.Size(100, 22);
            this.numberTextBox.TabIndex = 2;
            this.numberTextBox.Text = "2";
            this.numberTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Form1
            // 
            this.AcceptButton = this.goButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(342, 253);
            this.Controls.Add(this.numGroupsLabel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.numberTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.resultListBox);
            this.Controls.Add(this.spacingTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.goButton);
            this.Controls.Add(this.maxTextBox);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "PrimeTuples";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label numGroupsLabel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox resultListBox;
        private System.Windows.Forms.TextBox spacingTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button goButton;
        private System.Windows.Forms.TextBox maxTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox numberTextBox;
    }
}

