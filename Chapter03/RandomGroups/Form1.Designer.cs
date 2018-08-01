namespace RandomGroups
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.listListBox = new System.Windows.Forms.ListBox();
            this.arrayListBox = new System.Windows.Forms.ListBox();
            this.chooseButton = new System.Windows.Forms.Button();
            this.numItemsTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.listListBox, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.arrayListBox, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 51);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(260, 98);
            this.tableLayoutPanel1.TabIndex = 7;
            // 
            // listListBox
            // 
            this.listListBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listListBox.FormattingEnabled = true;
            this.listListBox.IntegralHeight = false;
            this.listListBox.Location = new System.Drawing.Point(133, 3);
            this.listListBox.Name = "listListBox";
            this.listListBox.Size = new System.Drawing.Size(124, 92);
            this.listListBox.TabIndex = 1;
            // 
            // arrayListBox
            // 
            this.arrayListBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.arrayListBox.FormattingEnabled = true;
            this.arrayListBox.IntegralHeight = false;
            this.arrayListBox.Location = new System.Drawing.Point(3, 3);
            this.arrayListBox.Name = "arrayListBox";
            this.arrayListBox.Size = new System.Drawing.Size(124, 92);
            this.arrayListBox.TabIndex = 0;
            // 
            // chooseButton
            // 
            this.chooseButton.Location = new System.Drawing.Point(197, 12);
            this.chooseButton.Name = "chooseButton";
            this.chooseButton.Size = new System.Drawing.Size(75, 23);
            this.chooseButton.TabIndex = 6;
            this.chooseButton.Text = "Choose";
            this.chooseButton.UseVisualStyleBackColor = true;
            this.chooseButton.Click += new System.EventHandler(this.chooseButton_Click);
            // 
            // numItemsTextBox
            // 
            this.numItemsTextBox.Location = new System.Drawing.Point(63, 14);
            this.numItemsTextBox.Name = "numItemsTextBox";
            this.numItemsTextBox.Size = new System.Drawing.Size(42, 20);
            this.numItemsTextBox.TabIndex = 5;
            this.numItemsTextBox.Text = "5";
            this.numItemsTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "# Items:";
            // 
            // Form1
            // 
            this.AcceptButton = this.chooseButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 161);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.chooseButton);
            this.Controls.Add(this.numItemsTextBox);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "RandomGroups";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.ListBox listListBox;
        private System.Windows.Forms.ListBox arrayListBox;
        private System.Windows.Forms.Button chooseButton;
        private System.Windows.Forms.TextBox numItemsTextBox;
        private System.Windows.Forms.Label label1;
    }
}

