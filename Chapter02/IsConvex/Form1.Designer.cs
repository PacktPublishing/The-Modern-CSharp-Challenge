namespace IsConvex
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
            this.isConvexLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.polygonPictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.polygonPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // isConvexLabel
            // 
            this.isConvexLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.isConvexLabel.AutoSize = true;
            this.isConvexLabel.Location = new System.Drawing.Point(78, 237);
            this.isConvexLabel.Name = "isConvexLabel";
            this.isConvexLabel.Size = new System.Drawing.Size(0, 13);
            this.isConvexLabel.TabIndex = 8;
            this.isConvexLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 237);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Is Convex?";
            // 
            // polygonPictureBox
            // 
            this.polygonPictureBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.polygonPictureBox.BackColor = System.Drawing.Color.White;
            this.polygonPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.polygonPictureBox.Location = new System.Drawing.Point(12, 10);
            this.polygonPictureBox.Name = "polygonPictureBox";
            this.polygonPictureBox.Size = new System.Drawing.Size(260, 224);
            this.polygonPictureBox.TabIndex = 6;
            this.polygonPictureBox.TabStop = false;
            this.polygonPictureBox.Paint += new System.Windows.Forms.PaintEventHandler(this.polygonPictureBox_Paint);
            this.polygonPictureBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.polygonPictureBox_MouseClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.isConvexLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.polygonPictureBox);
            this.Name = "Form1";
            this.Text = "IsConvex";
            ((System.ComponentModel.ISupportInitialize)(this.polygonPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label isConvexLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox polygonPictureBox;
    }
}

