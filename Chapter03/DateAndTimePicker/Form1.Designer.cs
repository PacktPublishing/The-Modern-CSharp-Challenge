namespace DateAndTimePicker
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
            this.dateAndTimePicker = new System.Windows.Forms.DateTimePicker();
            this.dateAndTimeLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // dateAndTimePicker
            // 
            this.dateAndTimePicker.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dateAndTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateAndTimePicker.Location = new System.Drawing.Point(12, 12);
            this.dateAndTimePicker.Name = "dateAndTimePicker";
            this.dateAndTimePicker.Size = new System.Drawing.Size(290, 20);
            this.dateAndTimePicker.TabIndex = 0;
            this.dateAndTimePicker.ValueChanged += new System.EventHandler(this.dateAndTimePicker_ValueChanged);
            // 
            // dateAndTimeLabel
            // 
            this.dateAndTimeLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.dateAndTimeLabel.AutoSize = true;
            this.dateAndTimeLabel.Location = new System.Drawing.Point(12, 69);
            this.dateAndTimeLabel.Name = "dateAndTimeLabel";
            this.dateAndTimeLabel.Size = new System.Drawing.Size(35, 13);
            this.dateAndTimeLabel.TabIndex = 1;
            this.dateAndTimeLabel.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(314, 91);
            this.Controls.Add(this.dateAndTimeLabel);
            this.Controls.Add(this.dateAndTimePicker);
            this.Name = "Form1";
            this.Text = "DateAndTimePicker";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateAndTimePicker;
        private System.Windows.Forms.Label dateAndTimeLabel;
    }
}

