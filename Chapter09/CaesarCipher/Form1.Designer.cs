namespace CaesarCipher
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
            this.label2 = new System.Windows.Forms.Label();
            this.ciphertextTextBox = new System.Windows.Forms.TextBox();
            this.recoveredTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.encryptShiftTextBox = new System.Windows.Forms.TextBox();
            this.decryptShiftTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.encryptButton = new System.Windows.Forms.Button();
            this.decryptButton = new System.Windows.Forms.Button();
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
            this.plaintextTextBox.Size = new System.Drawing.Size(191, 20);
            this.plaintextTextBox.TabIndex = 0;
            this.plaintextTextBox.Text = "This is the secret message.";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Ciphertext:";
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
            this.label3.TabIndex = 2;
            this.label3.Text = "Recovered:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 41);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Shift:";
            // 
            // encryptShiftTextBox
            // 
            this.encryptShiftTextBox.Location = new System.Drawing.Point(81, 38);
            this.encryptShiftTextBox.Name = "encryptShiftTextBox";
            this.encryptShiftTextBox.Size = new System.Drawing.Size(43, 20);
            this.encryptShiftTextBox.TabIndex = 1;
            this.encryptShiftTextBox.Text = "3";
            this.encryptShiftTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // decryptShiftTextBox
            // 
            this.decryptShiftTextBox.Location = new System.Drawing.Point(81, 138);
            this.decryptShiftTextBox.Name = "decryptShiftTextBox";
            this.decryptShiftTextBox.Size = new System.Drawing.Size(43, 20);
            this.decryptShiftTextBox.TabIndex = 4;
            this.decryptShiftTextBox.Text = "3";
            this.decryptShiftTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 141);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Shift:";
            // 
            // encryptButton
            // 
            this.encryptButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.encryptButton.Image = global::CaesarCipher.Properties.Resources.DownArrow;
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
            // decryptButton
            // 
            this.decryptButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.decryptButton.Image = global::CaesarCipher.Properties.Resources.DownArrow;
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 245);
            this.Controls.Add(this.decryptButton);
            this.Controls.Add(this.encryptButton);
            this.Controls.Add(this.decryptShiftTextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.encryptShiftTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.recoveredTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ciphertextTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.plaintextTextBox);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "CaesarCipher";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox plaintextTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox ciphertextTextBox;
        private System.Windows.Forms.TextBox recoveredTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox encryptShiftTextBox;
        private System.Windows.Forms.TextBox decryptShiftTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button encryptButton;
        private System.Windows.Forms.Button decryptButton;
    }
}

