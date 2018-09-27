namespace VigenereCipher
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
            this.decryptButton = new System.Windows.Forms.Button();
            this.encryptButton = new System.Windows.Forms.Button();
            this.decryptKeyTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.encryptKeyTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.recoveredTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ciphertextTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.plaintextTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // decryptButton
            // 
            this.decryptButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.decryptButton.Image = global::VigenereCipher.Properties.Resources.DownArrow;
            this.decryptButton.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.decryptButton.Location = new System.Drawing.Point(105, 164);
            this.decryptButton.Name = "decryptButton";
            this.decryptButton.Size = new System.Drawing.Size(75, 42);
            this.decryptButton.TabIndex = 5;
            this.decryptButton.Text = "Decrypt";
            this.decryptButton.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.decryptButton.UseVisualStyleBackColor = true;
            this.decryptButton.Click += new System.EventHandler(this.decryptButton_Click);
            // 
            // encryptButton
            // 
            this.encryptButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.encryptButton.Image = global::VigenereCipher.Properties.Resources.DownArrow;
            this.encryptButton.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.encryptButton.Location = new System.Drawing.Point(105, 64);
            this.encryptButton.Name = "encryptButton";
            this.encryptButton.Size = new System.Drawing.Size(75, 42);
            this.encryptButton.TabIndex = 2;
            this.encryptButton.Text = "Encrypt";
            this.encryptButton.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.encryptButton.UseVisualStyleBackColor = true;
            this.encryptButton.Click += new System.EventHandler(this.encryptButton_Click);
            // 
            // decryptShiftTextBox
            // 
            this.decryptKeyTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.decryptKeyTextBox.Location = new System.Drawing.Point(81, 138);
            this.decryptKeyTextBox.Name = "decryptShiftTextBox";
            this.decryptKeyTextBox.Size = new System.Drawing.Size(191, 20);
            this.decryptKeyTextBox.TabIndex = 4;
            this.decryptKeyTextBox.Text = "PASSWORD";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 141);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(28, 13);
            this.label5.TabIndex = 18;
            this.label5.Text = "Key:";
            // 
            // encryptShiftTextBox
            // 
            this.encryptKeyTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.encryptKeyTextBox.Location = new System.Drawing.Point(81, 38);
            this.encryptKeyTextBox.Name = "encryptShiftTextBox";
            this.encryptKeyTextBox.Size = new System.Drawing.Size(191, 20);
            this.encryptKeyTextBox.TabIndex = 1;
            this.encryptKeyTextBox.Text = "PASSWORD";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 41);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "Key:";
            // 
            // recoveredTextBox
            // 
            this.recoveredTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.recoveredTextBox.Location = new System.Drawing.Point(81, 212);
            this.recoveredTextBox.Name = "recoveredTextBox";
            this.recoveredTextBox.Size = new System.Drawing.Size(191, 20);
            this.recoveredTextBox.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 215);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Recovered:";
            // 
            // ciphertextTextBox
            // 
            this.ciphertextTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ciphertextTextBox.Location = new System.Drawing.Point(81, 112);
            this.ciphertextTextBox.Name = "ciphertextTextBox";
            this.ciphertextTextBox.Size = new System.Drawing.Size(191, 20);
            this.ciphertextTextBox.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Ciphertext:";
            // 
            // plaintextTextBox
            // 
            this.plaintextTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.plaintextTextBox.Location = new System.Drawing.Point(81, 12);
            this.plaintextTextBox.Name = "plaintextTextBox";
            this.plaintextTextBox.Size = new System.Drawing.Size(191, 20);
            this.plaintextTextBox.TabIndex = 0;
            this.plaintextTextBox.Text = "This is the secret message.";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Plaintext:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 245);
            this.Controls.Add(this.decryptButton);
            this.Controls.Add(this.encryptButton);
            this.Controls.Add(this.decryptKeyTextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.encryptKeyTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.recoveredTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ciphertextTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.plaintextTextBox);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "VigenereCipher";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button decryptButton;
        private System.Windows.Forms.Button encryptButton;
        private System.Windows.Forms.TextBox decryptKeyTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox encryptKeyTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox recoveredTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox ciphertextTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox plaintextTextBox;
        private System.Windows.Forms.Label label1;
    }
}

