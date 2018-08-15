namespace EditDistance
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
            this.word1TextBox = new System.Windows.Forms.TextBox();
            this.word2TextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.goButton = new System.Windows.Forms.Button();
            this.distanceTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.changesListBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Word 1:";
            // 
            // word1TextBox
            // 
            this.word1TextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.word1TextBox.Location = new System.Drawing.Point(70, 12);
            this.word1TextBox.Name = "word1TextBox";
            this.word1TextBox.Size = new System.Drawing.Size(202, 20);
            this.word1TextBox.TabIndex = 1;
            this.word1TextBox.Text = "Dungeon";
            // 
            // word2TextBox
            // 
            this.word2TextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.word2TextBox.Location = new System.Drawing.Point(70, 38);
            this.word2TextBox.Name = "word2TextBox";
            this.word2TextBox.Size = new System.Drawing.Size(202, 20);
            this.word2TextBox.TabIndex = 3;
            this.word2TextBox.Text = "Dragon";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Word 2:";
            // 
            // goButton
            // 
            this.goButton.Location = new System.Drawing.Point(105, 64);
            this.goButton.Name = "goButton";
            this.goButton.Size = new System.Drawing.Size(75, 23);
            this.goButton.TabIndex = 4;
            this.goButton.Text = "Go";
            this.goButton.UseVisualStyleBackColor = true;
            this.goButton.Click += new System.EventHandler(this.goButton_Click);
            // 
            // distanceTextBox
            // 
            this.distanceTextBox.Location = new System.Drawing.Point(70, 120);
            this.distanceTextBox.Name = "distanceTextBox";
            this.distanceTextBox.ReadOnly = true;
            this.distanceTextBox.Size = new System.Drawing.Size(56, 20);
            this.distanceTextBox.TabIndex = 6;
            this.distanceTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Distance:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 148);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Changes:";
            // 
            // changesListBox
            // 
            this.changesListBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.changesListBox.FormattingEnabled = true;
            this.changesListBox.IntegralHeight = false;
            this.changesListBox.Location = new System.Drawing.Point(12, 164);
            this.changesListBox.Name = "changesListBox";
            this.changesListBox.Size = new System.Drawing.Size(260, 115);
            this.changesListBox.TabIndex = 8;
            // 
            // Form1
            // 
            this.AcceptButton = this.goButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 291);
            this.Controls.Add(this.changesListBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.distanceTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.goButton);
            this.Controls.Add(this.word2TextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.word1TextBox);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "EditDistance";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox word1TextBox;
        private System.Windows.Forms.TextBox word2TextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button goButton;
        private System.Windows.Forms.TextBox distanceTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox changesListBox;
    }
}

