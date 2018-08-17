namespace DaysOfTheWeek
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
            this.goButton = new System.Windows.Forms.Button();
            this.datesListBox = new System.Windows.Forms.ListBox();
            this.birthdateMonthCalendar = new System.Windows.Forms.MonthCalendar();
            this.SuspendLayout();
            // 
            // goButton
            // 
            this.goButton.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.goButton.Location = new System.Drawing.Point(255, 85);
            this.goButton.Name = "goButton";
            this.goButton.Size = new System.Drawing.Size(75, 23);
            this.goButton.TabIndex = 2;
            this.goButton.Text = "Go";
            this.goButton.UseVisualStyleBackColor = true;
            this.goButton.Click += new System.EventHandler(this.goButton_Click);
            // 
            // datesListBox
            // 
            this.datesListBox.FormattingEnabled = true;
            this.datesListBox.IntegralHeight = false;
            this.datesListBox.Location = new System.Drawing.Point(338, 18);
            this.datesListBox.Name = "datesListBox";
            this.datesListBox.Size = new System.Drawing.Size(234, 162);
            this.datesListBox.TabIndex = 3;
            // 
            // birthdateMonthCalendar
            // 
            this.birthdateMonthCalendar.Location = new System.Drawing.Point(18, 18);
            this.birthdateMonthCalendar.Name = "birthdateMonthCalendar";
            this.birthdateMonthCalendar.TabIndex = 5;
            // 
            // Form1
            // 
            this.AcceptButton = this.goButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 193);
            this.Controls.Add(this.birthdateMonthCalendar);
            this.Controls.Add(this.datesListBox);
            this.Controls.Add(this.goButton);
            this.Name = "Form1";
            this.Text = "DaysOfTheWeek";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button goButton;
        private System.Windows.Forms.ListBox datesListBox;
        private System.Windows.Forms.MonthCalendar birthdateMonthCalendar;
    }
}

