namespace CalculateAge
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
            this.birthdatePicker = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.yearsLabel = new System.Windows.Forms.Label();
            this.monthsLabel = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.daysLabel = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Birthdate:";
            // 
            // birthdatePicker
            // 
            this.birthdatePicker.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.birthdatePicker.Location = new System.Drawing.Point(70, 12);
            this.birthdatePicker.Name = "birthdatePicker";
            this.birthdatePicker.Size = new System.Drawing.Size(202, 20);
            this.birthdatePicker.TabIndex = 1;
            this.birthdatePicker.ValueChanged += new System.EventHandler(this.birthdatePicker_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Years:";
            // 
            // yearsLabel
            // 
            this.yearsLabel.AutoSize = true;
            this.yearsLabel.Location = new System.Drawing.Point(67, 69);
            this.yearsLabel.Name = "yearsLabel";
            this.yearsLabel.Size = new System.Drawing.Size(19, 13);
            this.yearsLabel.TabIndex = 3;
            this.yearsLabel.Text = "10";
            // 
            // monthsLabel
            // 
            this.monthsLabel.AutoSize = true;
            this.monthsLabel.Location = new System.Drawing.Point(67, 94);
            this.monthsLabel.Name = "monthsLabel";
            this.monthsLabel.Size = new System.Drawing.Size(19, 13);
            this.monthsLabel.TabIndex = 5;
            this.monthsLabel.Text = "10";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 94);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Months:";
            // 
            // daysLabel
            // 
            this.daysLabel.AutoSize = true;
            this.daysLabel.Location = new System.Drawing.Point(67, 119);
            this.daysLabel.Name = "daysLabel";
            this.daysLabel.Size = new System.Drawing.Size(19, 13);
            this.daysLabel.TabIndex = 7;
            this.daysLabel.Text = "10";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 119);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(34, 13);
            this.label9.TabIndex = 6;
            this.label9.Text = "Days:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 151);
            this.Controls.Add(this.daysLabel);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.monthsLabel);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.yearsLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.birthdatePicker);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "CalculateAge";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker birthdatePicker;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label yearsLabel;
        private System.Windows.Forms.Label monthsLabel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label daysLabel;
        private System.Windows.Forms.Label label9;
    }
}

