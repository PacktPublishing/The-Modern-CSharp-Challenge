namespace RandomItems
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
            this.arrayItemTextBox = new System.Windows.Forms.TextBox();
            this.listItemTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.selectButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Array Item:";
            // 
            // arrayItemTextBox
            // 
            this.arrayItemTextBox.Location = new System.Drawing.Point(75, 61);
            this.arrayItemTextBox.Name = "arrayItemTextBox";
            this.arrayItemTextBox.ReadOnly = true;
            this.arrayItemTextBox.Size = new System.Drawing.Size(100, 20);
            this.arrayItemTextBox.TabIndex = 1;
            // 
            // listItemTextBox
            // 
            this.listItemTextBox.Location = new System.Drawing.Point(75, 87);
            this.listItemTextBox.Name = "listItemTextBox";
            this.listItemTextBox.ReadOnly = true;
            this.listItemTextBox.Size = new System.Drawing.Size(100, 20);
            this.listItemTextBox.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "list Item:";
            // 
            // selectButton
            // 
            this.selectButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.selectButton.Location = new System.Drawing.Point(105, 12);
            this.selectButton.Name = "selectButton";
            this.selectButton.Size = new System.Drawing.Size(75, 23);
            this.selectButton.TabIndex = 4;
            this.selectButton.Text = "Select";
            this.selectButton.UseVisualStyleBackColor = true;
            this.selectButton.Click += new System.EventHandler(this.selectButton_Click);
            // 
            // Form1
            // 
            this.AcceptButton = this.selectButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 119);
            this.Controls.Add(this.selectButton);
            this.Controls.Add(this.listItemTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.arrayItemTextBox);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "RandomItems";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox arrayItemTextBox;
        private System.Windows.Forms.TextBox listItemTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button selectButton;
    }
}

