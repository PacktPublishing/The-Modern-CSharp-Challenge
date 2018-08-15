namespace RomanNumerals
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
            this.arabicTextBox = new System.Windows.Forms.TextBox();
            this.romanTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.toRomanButton = new System.Windows.Forms.Button();
            this.toArabicButton = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(179, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "Arabic:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // arabicTextBox
            // 
            this.arabicTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.arabicTextBox.Location = new System.Drawing.Point(3, 36);
            this.arabicTextBox.Name = "arabicTextBox";
            this.arabicTextBox.Size = new System.Drawing.Size(179, 20);
            this.arabicTextBox.TabIndex = 1;
            this.arabicTextBox.Text = "1234567890";
            this.arabicTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // romanTextBox
            // 
            this.romanTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.romanTextBox.Location = new System.Drawing.Point(238, 36);
            this.romanTextBox.Name = "romanTextBox";
            this.romanTextBox.Size = new System.Drawing.Size(179, 20);
            this.romanTextBox.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Location = new System.Drawing.Point(238, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(179, 33);
            this.label2.TabIndex = 2;
            this.label2.Text = "Roman:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // toRomanButton
            // 
            this.toRomanButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toRomanButton.Location = new System.Drawing.Point(188, 3);
            this.toRomanButton.Name = "toRomanButton";
            this.toRomanButton.Size = new System.Drawing.Size(44, 27);
            this.toRomanButton.TabIndex = 4;
            this.toRomanButton.Text = "->";
            this.toRomanButton.UseVisualStyleBackColor = true;
            this.toRomanButton.Click += new System.EventHandler(this.toRomanButton_Click);
            // 
            // toArabicButton
            // 
            this.toArabicButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toArabicButton.Location = new System.Drawing.Point(188, 36);
            this.toArabicButton.Name = "toArabicButton";
            this.toArabicButton.Size = new System.Drawing.Size(44, 28);
            this.toArabicButton.TabIndex = 5;
            this.toArabicButton.Text = "<-";
            this.toArabicButton.UseVisualStyleBackColor = true;
            this.toArabicButton.Click += new System.EventHandler(this.toArabicButton_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.arabicTextBox, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.toRomanButton, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.toArabicButton, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.romanTextBox, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 2, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 12);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(420, 67);
            this.tableLayoutPanel1.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(444, 91);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Form1";
            this.Text = "RomanNumerals";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox arabicTextBox;
        private System.Windows.Forms.TextBox romanTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button toRomanButton;
        private System.Windows.Forms.Button toArabicButton;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    }
}

