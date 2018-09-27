namespace EncryptDecryptStrings
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
            this.plaintextTextBox = new System.Windows.Forms.TextBox();
            this.encryptButton = new System.Windows.Forms.Button();
            this.decryptButton = new System.Windows.Forms.Button();
            this.ciphertextTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.recoveredTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.encryptPasswordTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.decryptPasswordTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Plaintext:";
            // 
            // plaintextTextBox
            // 
            this.plaintextTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.plaintextTextBox.Location = new System.Drawing.Point(81, 12);
            this.plaintextTextBox.Name = "plaintextTextBox";
            this.plaintextTextBox.Size = new System.Drawing.Size(305, 20);
            this.plaintextTextBox.TabIndex = 1;
            this.plaintextTextBox.Text = "This is the secret message! これは秘密のメッセージです！";
            this.plaintextTextBox.TextChanged += new System.EventHandler(this.plaintextTextBox_TextChanged);
            // 
            // encryptButton
            // 
            this.encryptButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.encryptButton.Location = new System.Drawing.Point(162, 64);
            this.encryptButton.Name = "encryptButton";
            this.encryptButton.Size = new System.Drawing.Size(75, 23);
            this.encryptButton.TabIndex = 2;
            this.encryptButton.Text = "Encrypt";
            this.encryptButton.UseVisualStyleBackColor = true;
            this.encryptButton.Click += new System.EventHandler(this.encryptButton_Click);
            // 
            // decryptButton
            // 
            this.decryptButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.decryptButton.Location = new System.Drawing.Point(162, 145);
            this.decryptButton.Name = "decryptButton";
            this.decryptButton.Size = new System.Drawing.Size(75, 23);
            this.decryptButton.TabIndex = 5;
            this.decryptButton.Text = "Decrypt";
            this.decryptButton.UseVisualStyleBackColor = true;
            this.decryptButton.Click += new System.EventHandler(this.decryptButton_Click);
            // 
            // ciphertextTextBox
            // 
            this.ciphertextTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ciphertextTextBox.Location = new System.Drawing.Point(81, 93);
            this.ciphertextTextBox.Name = "ciphertextTextBox";
            this.ciphertextTextBox.Size = new System.Drawing.Size(305, 20);
            this.ciphertextTextBox.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Ciphertext:";
            // 
            // recoveredTextBox
            // 
            this.recoveredTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.recoveredTextBox.Location = new System.Drawing.Point(81, 174);
            this.recoveredTextBox.Name = "recoveredTextBox";
            this.recoveredTextBox.Size = new System.Drawing.Size(305, 20);
            this.recoveredTextBox.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 177);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Recovered:";
            // 
            // encryptPasswordTextBox
            // 
            this.encryptPasswordTextBox.Location = new System.Drawing.Point(81, 38);
            this.encryptPasswordTextBox.Name = "encryptPasswordTextBox";
            this.encryptPasswordTextBox.Size = new System.Drawing.Size(89, 20);
            this.encryptPasswordTextBox.TabIndex = 9;
            this.encryptPasswordTextBox.Text = "ThePassword";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 41);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Password:";
            // 
            // decryptPasswordTextBox
            // 
            this.decryptPasswordTextBox.Location = new System.Drawing.Point(81, 119);
            this.decryptPasswordTextBox.Name = "decryptPasswordTextBox";
            this.decryptPasswordTextBox.Size = new System.Drawing.Size(89, 20);
            this.decryptPasswordTextBox.TabIndex = 11;
            this.decryptPasswordTextBox.Text = "ThePassword";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 122);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Password:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(398, 209);
            this.Controls.Add(this.decryptPasswordTextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.encryptPasswordTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.recoveredTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.decryptButton);
            this.Controls.Add(this.ciphertextTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.encryptButton);
            this.Controls.Add(this.plaintextTextBox);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "EncryptDecryptStrings";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox plaintextTextBox;
        private System.Windows.Forms.Button encryptButton;
        private System.Windows.Forms.Button decryptButton;
        private System.Windows.Forms.TextBox ciphertextTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox recoveredTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox encryptPasswordTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox decryptPasswordTextBox;
        private System.Windows.Forms.Label label5;
    }
}

