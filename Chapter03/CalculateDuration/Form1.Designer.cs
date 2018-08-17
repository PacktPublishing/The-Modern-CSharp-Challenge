namespace CalculateDuration
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
            this.startDatePicker = new System.Windows.Forms.DateTimePicker();
            this.stopDatePicker = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.findDurationButton = new System.Windows.Forms.Button();
            this.localIntervalLabel = new System.Windows.Forms.Label();
            this.utcIntervalLabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Start:";
            // 
            // startDatePicker
            // 
            this.startDatePicker.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.startDatePicker.Location = new System.Drawing.Point(50, 12);
            this.startDatePicker.Name = "startDatePicker";
            this.startDatePicker.Size = new System.Drawing.Size(308, 20);
            this.startDatePicker.TabIndex = 1;
            // 
            // stopDatePicker
            // 
            this.stopDatePicker.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.stopDatePicker.Location = new System.Drawing.Point(50, 38);
            this.stopDatePicker.Name = "stopDatePicker";
            this.stopDatePicker.Size = new System.Drawing.Size(308, 20);
            this.stopDatePicker.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Stop:";
            // 
            // findDurationButton
            // 
            this.findDurationButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.findDurationButton.Location = new System.Drawing.Point(135, 82);
            this.findDurationButton.Name = "findDurationButton";
            this.findDurationButton.Size = new System.Drawing.Size(100, 23);
            this.findDurationButton.TabIndex = 7;
            this.findDurationButton.Text = "Find Duration";
            this.findDurationButton.UseVisualStyleBackColor = true;
            this.findDurationButton.Click += new System.EventHandler(this.findDurationButton_Click);
            // 
            // localIntervalLabel
            // 
            this.localIntervalLabel.AutoSize = true;
            this.localIntervalLabel.Location = new System.Drawing.Point(92, 136);
            this.localIntervalLabel.Name = "localIntervalLabel";
            this.localIntervalLabel.Size = new System.Drawing.Size(0, 13);
            this.localIntervalLabel.TabIndex = 8;
            // 
            // utcIntervalLabel
            // 
            this.utcIntervalLabel.AutoSize = true;
            this.utcIntervalLabel.Location = new System.Drawing.Point(92, 162);
            this.utcIntervalLabel.Name = "utcIntervalLabel";
            this.utcIntervalLabel.Size = new System.Drawing.Size(0, 13);
            this.utcIntervalLabel.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 162);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "UTC Interval:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 136);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Local Interval:";
            // 
            // Form1
            // 
            this.AcceptButton = this.findDurationButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(370, 191);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.utcIntervalLabel);
            this.Controls.Add(this.localIntervalLabel);
            this.Controls.Add(this.findDurationButton);
            this.Controls.Add(this.stopDatePicker);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.startDatePicker);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "CalculateDuration";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker startDatePicker;
        private System.Windows.Forms.DateTimePicker stopDatePicker;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button findDurationButton;
        private System.Windows.Forms.Label localIntervalLabel;
        private System.Windows.Forms.Label utcIntervalLabel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}

