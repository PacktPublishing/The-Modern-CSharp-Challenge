namespace EncryptDecryptFiles
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
            this.plainfileTextBox = new System.Windows.Forms.TextBox();
            this.browsePlainfileButton = new System.Windows.Forms.Button();
            this.encryptPasswordTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.encryptButton = new System.Windows.Forms.Button();
            this.browseCipherfileButton = new System.Windows.Forms.Button();
            this.cipherfileTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.decryptButton = new System.Windows.Forms.Button();
            this.decryptPasswordTextBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.plaintextRtb = new System.Windows.Forms.RichTextBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.recovertextRtb = new System.Windows.Forms.RichTextBox();
            this.browseRecoverfileButton = new System.Windows.Forms.Button();
            this.recoverfileTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ciphertextTextBox = new System.Windows.Forms.TextBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Plainfile:";
            // 
            // plainfileTextBox
            // 
            this.plainfileTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.plainfileTextBox.Location = new System.Drawing.Point(82, 14);
            this.plainfileTextBox.Name = "plainfileTextBox";
            this.plainfileTextBox.Size = new System.Drawing.Size(580, 20);
            this.plainfileTextBox.TabIndex = 0;
            this.plainfileTextBox.Text = "Plainfile.rtf";
            this.plainfileTextBox.TextChanged += new System.EventHandler(this.TextBox_TextChanged);
            // 
            // browsePlainfileButton
            // 
            this.browsePlainfileButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.browsePlainfileButton.Image = global::EncryptDecryptFiles.Properties.Resources.Ellipsis;
            this.browsePlainfileButton.Location = new System.Drawing.Point(668, 12);
            this.browsePlainfileButton.Name = "browsePlainfileButton";
            this.browsePlainfileButton.Size = new System.Drawing.Size(23, 23);
            this.browsePlainfileButton.TabIndex = 1;
            this.browsePlainfileButton.UseVisualStyleBackColor = true;
            this.browsePlainfileButton.Click += new System.EventHandler(this.browsePlainfileButton_Click);
            // 
            // encryptPasswordTextBox
            // 
            this.encryptPasswordTextBox.Location = new System.Drawing.Point(82, 71);
            this.encryptPasswordTextBox.Name = "encryptPasswordTextBox";
            this.encryptPasswordTextBox.Size = new System.Drawing.Size(89, 20);
            this.encryptPasswordTextBox.TabIndex = 4;
            this.encryptPasswordTextBox.Text = "ThePassword";
            this.encryptPasswordTextBox.TextChanged += new System.EventHandler(this.TextBox_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 74);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Password:";
            // 
            // encryptButton
            // 
            this.encryptButton.Location = new System.Drawing.Point(191, 69);
            this.encryptButton.Name = "encryptButton";
            this.encryptButton.Size = new System.Drawing.Size(75, 23);
            this.encryptButton.TabIndex = 5;
            this.encryptButton.Text = "Encrypt";
            this.encryptButton.UseVisualStyleBackColor = true;
            this.encryptButton.Click += new System.EventHandler(this.encryptButton_Click);
            // 
            // browseCipherfileButton
            // 
            this.browseCipherfileButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.browseCipherfileButton.Image = global::EncryptDecryptFiles.Properties.Resources.Ellipsis;
            this.browseCipherfileButton.Location = new System.Drawing.Point(668, 41);
            this.browseCipherfileButton.Name = "browseCipherfileButton";
            this.browseCipherfileButton.Size = new System.Drawing.Size(23, 23);
            this.browseCipherfileButton.TabIndex = 3;
            this.browseCipherfileButton.UseVisualStyleBackColor = true;
            this.browseCipherfileButton.Click += new System.EventHandler(this.browseCipherfileButton_Click);
            // 
            // cipherfileTextBox
            // 
            this.cipherfileTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cipherfileTextBox.Location = new System.Drawing.Point(82, 43);
            this.cipherfileTextBox.Name = "cipherfileTextBox";
            this.cipherfileTextBox.Size = new System.Drawing.Size(580, 20);
            this.cipherfileTextBox.TabIndex = 2;
            this.cipherfileTextBox.Text = "Cipherfile.rtf";
            this.cipherfileTextBox.TextChanged += new System.EventHandler(this.TextBox_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Cipherfile:";
            // 
            // decryptButton
            // 
            this.decryptButton.Location = new System.Drawing.Point(191, 124);
            this.decryptButton.Name = "decryptButton";
            this.decryptButton.Size = new System.Drawing.Size(75, 23);
            this.decryptButton.TabIndex = 9;
            this.decryptButton.Text = "Decrypt";
            this.decryptButton.UseVisualStyleBackColor = true;
            this.decryptButton.Click += new System.EventHandler(this.decryptButton_Click);
            // 
            // decryptPasswordTextBox
            // 
            this.decryptPasswordTextBox.Location = new System.Drawing.Point(82, 126);
            this.decryptPasswordTextBox.Name = "decryptPasswordTextBox";
            this.decryptPasswordTextBox.Size = new System.Drawing.Size(89, 20);
            this.decryptPasswordTextBox.TabIndex = 8;
            this.decryptPasswordTextBox.Text = "ThePassword";
            this.decryptPasswordTextBox.TextChanged += new System.EventHandler(this.Decrypt_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 129);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 13);
            this.label7.TabIndex = 23;
            this.label7.Text = "Password:";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "RTF Files|*.rtf|Text Files|*.txt|All Files|*.*";
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.Filter = "RTF Files|*.rtf|Text Files|*.txt|All Files|*.*";
            // 
            // plaintextRtb
            // 
            this.plaintextRtb.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.plaintextRtb.Location = new System.Drawing.Point(3, 3);
            this.plaintextRtb.Name = "plaintextRtb";
            this.plaintextRtb.Size = new System.Drawing.Size(487, 245);
            this.plaintextRtb.TabIndex = 24;
            this.plaintextRtb.Text = "";
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(12, 153);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(679, 371);
            this.tabControl1.TabIndex = 26;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.plaintextRtb);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(493, 251);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Plaintext";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.ciphertextTextBox);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(493, 251);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Ciphertext";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.recovertextRtb);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(671, 345);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Recovered";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // recovertextRtb
            // 
            this.recovertextRtb.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.recovertextRtb.Location = new System.Drawing.Point(3, 3);
            this.recovertextRtb.Name = "recovertextRtb";
            this.recovertextRtb.Size = new System.Drawing.Size(665, 339);
            this.recovertextRtb.TabIndex = 0;
            this.recovertextRtb.Text = "";
            // 
            // browseRecoverfileButton
            // 
            this.browseRecoverfileButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.browseRecoverfileButton.Image = global::EncryptDecryptFiles.Properties.Resources.Ellipsis;
            this.browseRecoverfileButton.Location = new System.Drawing.Point(668, 96);
            this.browseRecoverfileButton.Name = "browseRecoverfileButton";
            this.browseRecoverfileButton.Size = new System.Drawing.Size(23, 23);
            this.browseRecoverfileButton.TabIndex = 28;
            this.browseRecoverfileButton.UseVisualStyleBackColor = true;
            this.browseRecoverfileButton.Click += new System.EventHandler(this.browseRecoverfileButton_Click);
            // 
            // recoverfileTextBox
            // 
            this.recoverfileTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.recoverfileTextBox.Location = new System.Drawing.Point(82, 98);
            this.recoverfileTextBox.Name = "recoverfileTextBox";
            this.recoverfileTextBox.Size = new System.Drawing.Size(580, 20);
            this.recoverfileTextBox.TabIndex = 27;
            this.recoverfileTextBox.Text = "Recoverfile.rtf";
            this.recoverfileTextBox.TextChanged += new System.EventHandler(this.Decrypt_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 29;
            this.label3.Text = "Recoverfile:";
            // 
            // ciphertextTextBox
            // 
            this.ciphertextTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ciphertextTextBox.Location = new System.Drawing.Point(3, 3);
            this.ciphertextTextBox.Multiline = true;
            this.ciphertextTextBox.Name = "ciphertextTextBox";
            this.ciphertextTextBox.Size = new System.Drawing.Size(487, 245);
            this.ciphertextTextBox.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(703, 536);
            this.Controls.Add(this.browseRecoverfileButton);
            this.Controls.Add(this.recoverfileTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.decryptPasswordTextBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.decryptButton);
            this.Controls.Add(this.browseCipherfileButton);
            this.Controls.Add(this.cipherfileTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.encryptPasswordTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.encryptButton);
            this.Controls.Add(this.browsePlainfileButton);
            this.Controls.Add(this.plainfileTextBox);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "EncryptDecryptFiles";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox plainfileTextBox;
        private System.Windows.Forms.Button browsePlainfileButton;
        private System.Windows.Forms.TextBox encryptPasswordTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button encryptButton;
        private System.Windows.Forms.Button browseCipherfileButton;
        private System.Windows.Forms.TextBox cipherfileTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button decryptButton;
        private System.Windows.Forms.TextBox decryptPasswordTextBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.RichTextBox plaintextRtb;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button browseRecoverfileButton;
        private System.Windows.Forms.TextBox recoverfileTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox recovertextRtb;
        private System.Windows.Forms.TextBox ciphertextTextBox;
    }
}

