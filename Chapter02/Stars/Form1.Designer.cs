namespace Stars
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
            this.numSidesTextBox = new System.Windows.Forms.TextBox();
            this.skipTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.goButton = new System.Windows.Forms.Button();
            this.starPictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.starPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "# Sides:";
            // 
            // numSidesTextBox
            // 
            this.numSidesTextBox.Location = new System.Drawing.Point(64, 14);
            this.numSidesTextBox.Name = "numSidesTextBox";
            this.numSidesTextBox.Size = new System.Drawing.Size(40, 20);
            this.numSidesTextBox.TabIndex = 1;
            this.numSidesTextBox.Text = "5";
            this.numSidesTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // skipTextBox
            // 
            this.skipTextBox.Location = new System.Drawing.Point(169, 14);
            this.skipTextBox.Name = "skipTextBox";
            this.skipTextBox.Size = new System.Drawing.Size(40, 20);
            this.skipTextBox.TabIndex = 3;
            this.skipTextBox.Text = "2";
            this.skipTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(132, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Skip:";
            // 
            // goButton
            // 
            this.goButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.goButton.Location = new System.Drawing.Point(240, 12);
            this.goButton.Name = "goButton";
            this.goButton.Size = new System.Drawing.Size(75, 23);
            this.goButton.TabIndex = 4;
            this.goButton.Text = "Go";
            this.goButton.UseVisualStyleBackColor = true;
            this.goButton.Click += new System.EventHandler(this.goButton_Click);
            // 
            // starPictureBox
            // 
            this.starPictureBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.starPictureBox.BackColor = System.Drawing.Color.White;
            this.starPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.starPictureBox.Location = new System.Drawing.Point(12, 40);
            this.starPictureBox.Name = "starPictureBox";
            this.starPictureBox.Size = new System.Drawing.Size(303, 209);
            this.starPictureBox.TabIndex = 5;
            this.starPictureBox.TabStop = false;
            this.starPictureBox.Paint += new System.Windows.Forms.PaintEventHandler(this.starPictureBox_Paint);
            // 
            // Form1
            // 
            this.AcceptButton = this.goButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(327, 261);
            this.Controls.Add(this.starPictureBox);
            this.Controls.Add(this.goButton);
            this.Controls.Add(this.skipTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.numSidesTextBox);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Stars";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.starPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox numSidesTextBox;
        private System.Windows.Forms.TextBox skipTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button goButton;
        private System.Windows.Forms.PictureBox starPictureBox;
    }
}

