namespace Combinations
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
            this.label4 = new System.Windows.Forms.Label();
            this.numPerGroupTextBox = new System.Windows.Forms.TextBox();
            this.numCombinationsLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.resultsListBox = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.goButton = new System.Windows.Forms.Button();
            this.valuesTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 39);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 17);
            this.label4.TabIndex = 33;
            this.label4.Text = "# Per Selection:";
            // 
            // numPerGroupTextBox
            // 
            this.numPerGroupTextBox.Location = new System.Drawing.Point(126, 36);
            this.numPerGroupTextBox.Name = "numPerGroupTextBox";
            this.numPerGroupTextBox.Size = new System.Drawing.Size(32, 22);
            this.numPerGroupTextBox.TabIndex = 26;
            this.numPerGroupTextBox.Text = "3";
            this.numPerGroupTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // numCombinationsLabel
            // 
            this.numCombinationsLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.numCombinationsLabel.AutoSize = true;
            this.numCombinationsLabel.Location = new System.Drawing.Point(126, 277);
            this.numCombinationsLabel.Name = "numCombinationsLabel";
            this.numCombinationsLabel.Size = new System.Drawing.Size(0, 17);
            this.numCombinationsLabel.TabIndex = 32;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 277);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 17);
            this.label3.TabIndex = 31;
            this.label3.Text = "# Combinations:";
            // 
            // resultsListBox
            // 
            this.resultsListBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.resultsListBox.FormattingEnabled = true;
            this.resultsListBox.IntegralHeight = false;
            this.resultsListBox.ItemHeight = 16;
            this.resultsListBox.Location = new System.Drawing.Point(14, 132);
            this.resultsListBox.Name = "resultsListBox";
            this.resultsListBox.Size = new System.Drawing.Size(327, 142);
            this.resultsListBox.TabIndex = 28;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 17);
            this.label2.TabIndex = 30;
            this.label2.Text = "Combinations:";
            // 
            // goButton
            // 
            this.goButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.goButton.Location = new System.Drawing.Point(139, 77);
            this.goButton.Name = "goButton";
            this.goButton.Size = new System.Drawing.Size(75, 23);
            this.goButton.TabIndex = 27;
            this.goButton.Text = "Go";
            this.goButton.UseVisualStyleBackColor = true;
            this.goButton.Click += new System.EventHandler(this.goButton_Click);
            // 
            // valuesTextBox
            // 
            this.valuesTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.valuesTextBox.Location = new System.Drawing.Point(125, 8);
            this.valuesTextBox.Name = "valuesTextBox";
            this.valuesTextBox.Size = new System.Drawing.Size(215, 22);
            this.valuesTextBox.TabIndex = 25;
            this.valuesTextBox.Text = "Apple Banana Cherry Date Frog";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 17);
            this.label1.TabIndex = 29;
            this.label1.Text = "Items:";
            // 
            // Form1
            // 
            this.AcceptButton = this.goButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(352, 303);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.numPerGroupTextBox);
            this.Controls.Add(this.numCombinationsLabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.resultsListBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.goButton);
            this.Controls.Add(this.valuesTextBox);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Combinations";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox numPerGroupTextBox;
        private System.Windows.Forms.Label numCombinationsLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox resultsListBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button goButton;
        private System.Windows.Forms.TextBox valuesTextBox;
        private System.Windows.Forms.Label label1;
    }
}

