namespace PascalsTriangle
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
            this.triangleTextBox = new System.Windows.Forms.TextBox();
            this.goButton = new System.Windows.Forms.Button();
            this.numRowsTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // triangleTextBox
            // 
            this.triangleTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.triangleTextBox.Location = new System.Drawing.Point(12, 41);
            this.triangleTextBox.Multiline = true;
            this.triangleTextBox.Name = "triangleTextBox";
            this.triangleTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.triangleTextBox.Size = new System.Drawing.Size(358, 200);
            this.triangleTextBox.TabIndex = 7;
            this.triangleTextBox.WordWrap = false;
            // 
            // goButton
            // 
            this.goButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.goButton.Location = new System.Drawing.Point(295, 12);
            this.goButton.Name = "goButton";
            this.goButton.Size = new System.Drawing.Size(75, 23);
            this.goButton.TabIndex = 6;
            this.goButton.Text = "Go";
            this.goButton.UseVisualStyleBackColor = true;
            this.goButton.Click += new System.EventHandler(this.goButton_Click);
            // 
            // numRowsTextBox
            // 
            this.numRowsTextBox.Location = new System.Drawing.Point(64, 12);
            this.numRowsTextBox.Name = "numRowsTextBox";
            this.numRowsTextBox.Size = new System.Drawing.Size(37, 22);
            this.numRowsTextBox.TabIndex = 5;
            this.numRowsTextBox.Text = "5";
            this.numRowsTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Rows:";
            // 
            // Form1
            // 
            this.AcceptButton = this.goButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(382, 253);
            this.Controls.Add(this.triangleTextBox);
            this.Controls.Add(this.goButton);
            this.Controls.Add(this.numRowsTextBox);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "PascalsTriangle";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox triangleTextBox;
        private System.Windows.Forms.Button goButton;
        private System.Windows.Forms.TextBox numRowsTextBox;
        private System.Windows.Forms.Label label1;
    }
}

