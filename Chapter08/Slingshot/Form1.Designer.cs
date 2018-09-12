namespace Slingshot
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
            this.components = new System.ComponentModel.Container();
            this.scenePictureBox = new System.Windows.Forms.PictureBox();
            this.moveTimer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.scenePictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // scenePictureBox
            // 
            this.scenePictureBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.scenePictureBox.BackColor = System.Drawing.Color.White;
            this.scenePictureBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.scenePictureBox.Cursor = System.Windows.Forms.Cursors.Cross;
            this.scenePictureBox.Location = new System.Drawing.Point(12, 12);
            this.scenePictureBox.Name = "scenePictureBox";
            this.scenePictureBox.Size = new System.Drawing.Size(410, 287);
            this.scenePictureBox.TabIndex = 0;
            this.scenePictureBox.TabStop = false;
            this.scenePictureBox.Paint += new System.Windows.Forms.PaintEventHandler(this.scenePictureBox_Paint);
            this.scenePictureBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.scenePictureBox_MouseDown);
            this.scenePictureBox.MouseMove += new System.Windows.Forms.MouseEventHandler(this.scenePictureBox_MouseMove);
            this.scenePictureBox.MouseUp += new System.Windows.Forms.MouseEventHandler(this.scenePictureBox_MouseUp);
            // 
            // moveTimer
            // 
            this.moveTimer.Interval = 50;
            this.moveTimer.Tick += new System.EventHandler(this.moveTimer_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 311);
            this.Controls.Add(this.scenePictureBox);
            this.Name = "Form1";
            this.Text = "Slingshot";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.scenePictureBox_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.scenePictureBox_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.scenePictureBox_MouseUp);
            ((System.ComponentModel.ISupportInitialize)(this.scenePictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox scenePictureBox;
        private System.Windows.Forms.Timer moveTimer;
    }
}

