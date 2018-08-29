namespace RandomWalk
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
            this.walkPictureBox = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.numStepsTextBox = new System.Windows.Forms.TextBox();
            this.stepSizeTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.walkButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.walkPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // walkPictureBox
            // 
            this.walkPictureBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.walkPictureBox.BackColor = System.Drawing.Color.White;
            this.walkPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.walkPictureBox.Location = new System.Drawing.Point(12, 67);
            this.walkPictureBox.Name = "walkPictureBox";
            this.walkPictureBox.Size = new System.Drawing.Size(300, 300);
            this.walkPictureBox.TabIndex = 0;
            this.walkPictureBox.TabStop = false;
            this.walkPictureBox.Paint += new System.Windows.Forms.PaintEventHandler(this.walkPictureBox_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "# Steps:";
            // 
            // numStepsTextBox
            // 
            this.numStepsTextBox.Location = new System.Drawing.Point(65, 12);
            this.numStepsTextBox.Name = "numStepsTextBox";
            this.numStepsTextBox.Size = new System.Drawing.Size(61, 20);
            this.numStepsTextBox.TabIndex = 2;
            this.numStepsTextBox.Text = "1000";
            this.numStepsTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // stepSizeTextBox
            // 
            this.stepSizeTextBox.Location = new System.Drawing.Point(211, 12);
            this.stepSizeTextBox.Name = "stepSizeTextBox";
            this.stepSizeTextBox.Size = new System.Drawing.Size(61, 20);
            this.stepSizeTextBox.TabIndex = 4;
            this.stepSizeTextBox.Text = "5";
            this.stepSizeTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(150, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Step Size:";
            // 
            // walkButton
            // 
            this.walkButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.walkButton.Location = new System.Drawing.Point(125, 38);
            this.walkButton.Name = "walkButton";
            this.walkButton.Size = new System.Drawing.Size(75, 23);
            this.walkButton.TabIndex = 5;
            this.walkButton.Text = "Walk";
            this.walkButton.UseVisualStyleBackColor = true;
            this.walkButton.Click += new System.EventHandler(this.walkButton_Click);
            // 
            // Form1
            // 
            this.AcceptButton = this.walkButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(324, 379);
            this.Controls.Add(this.walkButton);
            this.Controls.Add(this.stepSizeTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.numStepsTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.walkPictureBox);
            this.Name = "Form1";
            this.Text = "RandomWalk";
            ((System.ComponentModel.ISupportInitialize)(this.walkPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox walkPictureBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox numStepsTextBox;
        private System.Windows.Forms.TextBox stepSizeTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button walkButton;
    }
}

