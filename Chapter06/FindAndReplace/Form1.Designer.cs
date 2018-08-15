namespace FindAndReplace
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
            this.findButton = new System.Windows.Forms.Button();
            this.directoryTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.targetTextBox = new System.Windows.Forms.TextBox();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.replaceButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.replaceWithTextBox = new System.Windows.Forms.TextBox();
            this.filesCheckedListBox = new System.Windows.Forms.CheckedListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.patternsComboBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // findButton
            // 
            this.findButton.Enabled = false;
            this.findButton.Location = new System.Drawing.Point(105, 208);
            this.findButton.Name = "findButton";
            this.findButton.Size = new System.Drawing.Size(75, 23);
            this.findButton.TabIndex = 52;
            this.findButton.Text = "Find";
            this.findButton.UseVisualStyleBackColor = true;
            this.findButton.Click += new System.EventHandler(this.findButton_Click);
            // 
            // directoryTextBox
            // 
            this.directoryTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.directoryTextBox.Location = new System.Drawing.Point(70, 33);
            this.directoryTextBox.Name = "directoryTextBox";
            this.directoryTextBox.Size = new System.Drawing.Size(465, 20);
            this.directoryTextBox.TabIndex = 48;
            this.directoryTextBox.TextChanged += new System.EventHandler(this.input_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 55;
            this.label1.Text = "Directory:";
            // 
            // targetTextBox
            // 
            this.targetTextBox.AcceptsReturn = true;
            this.targetTextBox.Location = new System.Drawing.Point(15, 105);
            this.targetTextBox.Multiline = true;
            this.targetTextBox.Name = "targetTextBox";
            this.targetTextBox.Size = new System.Drawing.Size(257, 97);
            this.targetTextBox.TabIndex = 50;
            this.targetTextBox.TextChanged += new System.EventHandler(this.input_TextChanged);
            // 
            // replaceButton
            // 
            this.replaceButton.Enabled = false;
            this.replaceButton.Location = new System.Drawing.Point(369, 208);
            this.replaceButton.Name = "replaceButton";
            this.replaceButton.Size = new System.Drawing.Size(75, 23);
            this.replaceButton.TabIndex = 53;
            this.replaceButton.Text = "Replace";
            this.replaceButton.UseVisualStyleBackColor = true;
            this.replaceButton.Click += new System.EventHandler(this.replaceButton_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(275, 89);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 13);
            this.label4.TabIndex = 58;
            this.label4.Text = "Replace With:";
            // 
            // replaceWithTextBox
            // 
            this.replaceWithTextBox.AcceptsReturn = true;
            this.replaceWithTextBox.Location = new System.Drawing.Point(278, 105);
            this.replaceWithTextBox.Multiline = true;
            this.replaceWithTextBox.Name = "replaceWithTextBox";
            this.replaceWithTextBox.Size = new System.Drawing.Size(257, 97);
            this.replaceWithTextBox.TabIndex = 51;
            // 
            // filesCheckedListBox
            // 
            this.filesCheckedListBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.filesCheckedListBox.CheckOnClick = true;
            this.filesCheckedListBox.FormattingEnabled = true;
            this.filesCheckedListBox.IntegralHeight = false;
            this.filesCheckedListBox.Location = new System.Drawing.Point(12, 237);
            this.filesCheckedListBox.MultiColumn = true;
            this.filesCheckedListBox.Name = "filesCheckedListBox";
            this.filesCheckedListBox.Size = new System.Drawing.Size(523, 151);
            this.filesCheckedListBox.TabIndex = 54;
            this.filesCheckedListBox.SelectedIndexChanged += new System.EventHandler(this.filesCheckedListBox_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 57;
            this.label3.Text = "Target:";
            // 
            // patternsComboBox
            // 
            this.patternsComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.patternsComboBox.FormattingEnabled = true;
            this.patternsComboBox.Items.AddRange(new object[] {
            "All Files: *.*",
            "C# FIles: *.cs;*.sln;*.resx;*.config",
            "Compiled Files: *.exe;*.obj;*.dll",
            "Image Files: *.bmp;*.png;*.jpg;*.jprg;*.tif;*.gif;*.exif"});
            this.patternsComboBox.Location = new System.Drawing.Point(70, 59);
            this.patternsComboBox.Name = "patternsComboBox";
            this.patternsComboBox.Size = new System.Drawing.Size(465, 21);
            this.patternsComboBox.TabIndex = 49;
            this.patternsComboBox.Text = "*.*";
            this.patternsComboBox.TextChanged += new System.EventHandler(this.input_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 56;
            this.label2.Text = "Patterns:";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(547, 24);
            this.menuStrip1.TabIndex = 59;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.openToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.openToolStripMenuItem.Text = "&Open...";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AcceptButton = this.findButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(547, 394);
            this.Controls.Add(this.findButton);
            this.Controls.Add(this.directoryTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.targetTextBox);
            this.Controls.Add(this.replaceButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.replaceWithTextBox);
            this.Controls.Add(this.filesCheckedListBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.patternsComboBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.menuStrip1);
            this.Name = "Form1";
            this.Text = "FindAndReplace";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button findButton;
        private System.Windows.Forms.TextBox directoryTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox targetTextBox;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Button replaceButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox replaceWithTextBox;
        private System.Windows.Forms.CheckedListBox filesCheckedListBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox patternsComboBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
    }
}

