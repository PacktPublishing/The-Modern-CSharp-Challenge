namespace DawkinsWeasel
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
            this.mutationProbTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.generationSizeTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.numStepsLabel = new System.Windows.Forms.Label();
            this.stepsListBox = new System.Windows.Forms.ListBox();
            this.goButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // mutationProbTextBox
            // 
            this.mutationProbTextBox.Location = new System.Drawing.Point(103, 36);
            this.mutationProbTextBox.Name = "mutationProbTextBox";
            this.mutationProbTextBox.Size = new System.Drawing.Size(46, 20);
            this.mutationProbTextBox.TabIndex = 15;
            this.mutationProbTextBox.Text = "0.05";
            this.mutationProbTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Mutation Prob:";
            // 
            // generationSizeTextBox
            // 
            this.generationSizeTextBox.Location = new System.Drawing.Point(103, 10);
            this.generationSizeTextBox.Name = "generationSizeTextBox";
            this.generationSizeTextBox.Size = new System.Drawing.Size(46, 20);
            this.generationSizeTextBox.TabIndex = 13;
            this.generationSizeTextBox.Text = "100";
            this.generationSizeTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Generation Size:";
            // 
            // numStepsLabel
            // 
            this.numStepsLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.numStepsLabel.AutoSize = true;
            this.numStepsLabel.Location = new System.Drawing.Point(12, 237);
            this.numStepsLabel.Name = "numStepsLabel";
            this.numStepsLabel.Size = new System.Drawing.Size(47, 13);
            this.numStepsLabel.TabIndex = 10;
            this.numStepsLabel.Text = "# Steps:";
            // 
            // stepsListBox
            // 
            this.stepsListBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.stepsListBox.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stepsListBox.FormattingEnabled = true;
            this.stepsListBox.IntegralHeight = false;
            this.stepsListBox.ItemHeight = 14;
            this.stepsListBox.Location = new System.Drawing.Point(12, 91);
            this.stepsListBox.Name = "stepsListBox";
            this.stepsListBox.Size = new System.Drawing.Size(280, 143);
            this.stepsListBox.TabIndex = 9;
            // 
            // goButton
            // 
            this.goButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.goButton.Location = new System.Drawing.Point(115, 62);
            this.goButton.Name = "goButton";
            this.goButton.Size = new System.Drawing.Size(75, 23);
            this.goButton.TabIndex = 8;
            this.goButton.Text = "Go";
            this.goButton.UseVisualStyleBackColor = true;
            this.goButton.Click += new System.EventHandler(this.goButton_Click);
            // 
            // Form1
            // 
            this.AcceptButton = this.goButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(304, 261);
            this.Controls.Add(this.mutationProbTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.generationSizeTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.numStepsLabel);
            this.Controls.Add(this.stepsListBox);
            this.Controls.Add(this.goButton);
            this.Name = "Form1";
            this.Text = "Dawkins\' Weasel";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox mutationProbTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox generationSizeTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label numStepsLabel;
        private System.Windows.Forms.ListBox stepsListBox;
        private System.Windows.Forms.Button goButton;
    }
}

