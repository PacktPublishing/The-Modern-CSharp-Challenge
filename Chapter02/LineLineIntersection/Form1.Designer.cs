namespace LineLineIntersection
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
            this.linesPictureBox.Size = new System.Drawing.Size(260, 237);
            this.linesPictureBox.TabIndex = 0;
            this.linesPictureBox.TabStop = false;
            this.linesPictureBox.Paint += new System.Windows.Forms.PaintEventHandler(this.linesPictureBox_Paint);
            this.linesPictureBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.linesPictureBox_MouseClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.linesPictureBox);
            this.Name = "Form1";
            this.Text = "LineLineIntersection";
            ((System.ComponentModel.ISupportInitialize)(this.linesPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox linesPictureBox;
    }
}

