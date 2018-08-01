namespace PointLineDistance
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
            this.linesPictureBox = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.distanceLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.linesPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // linesPictureBox
            // 
            this.linesPictureBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.linesPictureBox.BackColor = System.Drawing.Color.White;
            this.linesPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.linesPictureBox.Location = new System.Drawing.Point(12, 12);
            this.linesPictureBox.Name = "linesPictureBox";
            this.linesPictureBox.Size = new System.Drawing.Size(260, 224);
            this.linesPictureBox.TabIndex = 1;
            this.linesPictureBox.TabStop = false;
            this.linesPictureBox.Paint += new System.Windows.Forms.PaintEventHandler(this.linesPictureBox_Paint);
            this.linesPictureBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.linesPictureBox_MouseClick);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 239);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Distance:";
            // 
            // distanceLabel
            // 
            this.distanceLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.distanceLabel.AutoSize = true;
            this.distanceLabel.Location = new System.Drawing.Point(70, 239);
            this.distanceLabel.Name = "distanceLabel";
            this.distanceLabel.Size = new System.Drawing.Size(0, 13);
            this.distanceLabel.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.distanceLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.linesPictureBox);
            this.Name = "Form1";
            this.Text = "PointLineDistance";
            ((System.ComponentModel.ISupportInitialize)(this.linesPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox linesPictureBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label distanceLabel;
    }
}

