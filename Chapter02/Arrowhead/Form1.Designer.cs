namespace Arrowhead
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
            this.arrowPictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.arrowPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // arrowPictureBox
            // 
            this.arrowPictureBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.arrowPictureBox.BackColor = System.Drawing.Color.White;
            this.arrowPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.arrowPictureBox.Location = new System.Drawing.Point(12, 12);
            this.arrowPictureBox.Name = "arrowPictureBox";
            this.arrowPictureBox.Size = new System.Drawing.Size(260, 237);
            this.arrowPictureBox.TabIndex = 0;
            this.arrowPictureBox.TabStop = false;
            this.arrowPictureBox.Paint += new System.Windows.Forms.PaintEventHandler(this.arrowPictureBox_Paint);
            this.arrowPictureBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.arrowPictureBox_MouseDown);
            this.arrowPictureBox.MouseMove += new System.Windows.Forms.MouseEventHandler(this.arrowPictureBox_MouseMove);
            this.arrowPictureBox.MouseUp += new System.Windows.Forms.MouseEventHandler(this.arrowPictureBox_MouseUp);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.arrowPictureBox);
            this.Name = "Form1";
            this.Text = "Arrowhead";
            ((System.ComponentModel.ISupportInitialize)(this.arrowPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox arrowPictureBox;
    }
}

