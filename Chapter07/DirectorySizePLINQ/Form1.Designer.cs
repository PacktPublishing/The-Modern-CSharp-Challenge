namespace DirectorySizePLINQ
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
            this.fileSizeTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.bytesTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.includeSubdirsCheckBox = new System.Windows.Forms.CheckBox();
            this.calculateButton = new System.Windows.Forms.Button();
            this.directoryTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.foreachTimeTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.linqTimeTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.plinqTimeTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.numTrialsTextBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // fileSizeTextBox
            // 
            this.fileSizeTextBox.Location = new System.Drawing.Point(100, 253);
            this.fileSizeTextBox.Name = "fileSizeTextBox";
            this.fileSizeTextBox.ReadOnly = true;
            this.fileSizeTextBox.Size = new System.Drawing.Size(75, 20);
            this.fileSizeTextBox.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 257);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 40;
            this.label3.Text = "File Size:";
            // 
            // bytesTextBox
            // 
            this.bytesTextBox.Location = new System.Drawing.Point(100, 227);
            this.bytesTextBox.Name = "bytesTextBox";
            this.bytesTextBox.ReadOnly = true;
            this.bytesTextBox.Size = new System.Drawing.Size(75, 20);
            this.bytesTextBox.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 231);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 39;
            this.label2.Text = "Bytes:";
            // 
            // includeSubdirsCheckBox
            // 
            this.includeSubdirsCheckBox.AutoSize = true;
            this.includeSubdirsCheckBox.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.includeSubdirsCheckBox.Location = new System.Drawing.Point(12, 53);
            this.includeSubdirsCheckBox.Name = "includeSubdirsCheckBox";
            this.includeSubdirsCheckBox.Size = new System.Drawing.Size(102, 17);
            this.includeSubdirsCheckBox.TabIndex = 2;
            this.includeSubdirsCheckBox.Text = "Include Subdirs:";
            this.includeSubdirsCheckBox.UseVisualStyleBackColor = true;
            this.includeSubdirsCheckBox.CheckedChanged += new System.EventHandler(this.includeSubdirsCheckBox_CheckedChanged);
            // 
            // calculateButton
            // 
            this.calculateButton.Enabled = false;
            this.calculateButton.Location = new System.Drawing.Point(100, 102);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(75, 23);
            this.calculateButton.TabIndex = 4;
            this.calculateButton.Text = "Calculate";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // directoryTextBox
            // 
            this.directoryTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.directoryTextBox.Location = new System.Drawing.Point(100, 27);
            this.directoryTextBox.Name = "directoryTextBox";
            this.directoryTextBox.Size = new System.Drawing.Size(172, 20);
            this.directoryTextBox.TabIndex = 0;
            this.directoryTextBox.TextChanged += new System.EventHandler(this.TextBox_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 38;
            this.label1.Text = "Directory:";
            // 
            // foreachTimeTextBox
            // 
            this.foreachTimeTextBox.Location = new System.Drawing.Point(100, 131);
            this.foreachTimeTextBox.Name = "foreachTimeTextBox";
            this.foreachTimeTextBox.ReadOnly = true;
            this.foreachTimeTextBox.Size = new System.Drawing.Size(75, 20);
            this.foreachTimeTextBox.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 135);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 42;
            this.label4.Text = "Foreach:";
            // 
            // linqTimeTextBox
            // 
            this.linqTimeTextBox.Location = new System.Drawing.Point(100, 157);
            this.linqTimeTextBox.Name = "linqTimeTextBox";
            this.linqTimeTextBox.ReadOnly = true;
            this.linqTimeTextBox.Size = new System.Drawing.Size(75, 20);
            this.linqTimeTextBox.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 161);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 44;
            this.label5.Text = "LINQ:";
            // 
            // plinqTimeTextBox
            // 
            this.plinqTimeTextBox.Location = new System.Drawing.Point(100, 183);
            this.plinqTimeTextBox.Name = "plinqTimeTextBox";
            this.plinqTimeTextBox.ReadOnly = true;
            this.plinqTimeTextBox.Size = new System.Drawing.Size(75, 20);
            this.plinqTimeTextBox.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 187);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 13);
            this.label6.TabIndex = 46;
            this.label6.Text = "PLINQ";
            // 
            // numTrialsTextBox
            // 
            this.numTrialsTextBox.Location = new System.Drawing.Point(100, 76);
            this.numTrialsTextBox.Name = "numTrialsTextBox";
            this.numTrialsTextBox.Size = new System.Drawing.Size(75, 20);
            this.numTrialsTextBox.TabIndex = 3;
            this.numTrialsTextBox.Text = "1000";
            this.numTrialsTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numTrialsTextBox.TextChanged += new System.EventHandler(this.TextBox_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 79);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 13);
            this.label7.TabIndex = 48;
            this.label7.Text = "# Trials:";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(284, 24);
            this.menuStrip1.TabIndex = 49;
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
            this.AcceptButton = this.calculateButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 286);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.numTrialsTextBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.plinqTimeTextBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.linqTimeTextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.foreachTimeTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.fileSizeTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.bytesTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.includeSubdirsCheckBox);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.directoryTextBox);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "DirectorySizePLINQ";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox fileSizeTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox bytesTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox includeSubdirsCheckBox;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.TextBox directoryTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.TextBox foreachTimeTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox linqTimeTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox plinqTimeTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox numTrialsTextBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
    }
}

