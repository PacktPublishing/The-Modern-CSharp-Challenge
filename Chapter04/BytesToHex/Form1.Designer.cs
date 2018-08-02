namespace BytesToHex
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
            this.originalTextBox = new System.Windows.Forms.TextBox();
            this.toHexButton = new System.Windows.Forms.Button();
            this.toStringButton = new System.Windows.Forms.Button();
            this.hexTextBox = new System.Windows.Forms.TextBox();
            this.stringTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // originalTextBox
            // 
            this.originalTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.originalTextBox.Location = new System.Drawing.Point(12, 12);
            this.originalTextBox.Multiline = true;
            this.originalTextBox.Name = "originalTextBox";
            this.originalTextBox.Size = new System.Drawing.Size(151, 94);
            this.originalTextBox.TabIndex = 0;
            this.originalTextBox.Text = "It is better to keep your mouth closed and let people think you are a fool than t" +
    "o open it and remove all doubt. -- Mark Twain";
            // 
            // toHexButton
            // 
            this.toHexButton.Location = new System.Drawing.Point(169, 48);
            this.toHexButton.Name = "toHexButton";
            this.toHexButton.Size = new System.Drawing.Size(35, 23);
            this.toHexButton.TabIndex = 1;
            this.toHexButton.Text = "-->";
            this.toHexButton.UseVisualStyleBackColor = true;
            this.toHexButton.Click += new System.EventHandler(this.toHexButton_Click);
            // 
            // toStringButton
            // 
            this.toStringButton.Location = new System.Drawing.Point(367, 48);
            this.toStringButton.Name = "toStringButton";
            this.toStringButton.Size = new System.Drawing.Size(35, 23);
            this.toStringButton.TabIndex = 3;
            this.toStringButton.Text = "-->";
            this.toStringButton.UseVisualStyleBackColor = true;
            this.toStringButton.Click += new System.EventHandler(this.toStringButton_Click);
            // 
            // hexTextBox
            // 
            this.hexTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.hexTextBox.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hexTextBox.Location = new System.Drawing.Point(210, 12);
            this.hexTextBox.Multiline = true;
            this.hexTextBox.Name = "hexTextBox";
            this.hexTextBox.Size = new System.Drawing.Size(151, 94);
            this.hexTextBox.TabIndex = 2;
            // 
            // stringTextBox
            // 
            this.stringTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.stringTextBox.Location = new System.Drawing.Point(408, 12);
            this.stringTextBox.Multiline = true;
            this.stringTextBox.Name = "stringTextBox";
            this.stringTextBox.Size = new System.Drawing.Size(151, 94);
            this.stringTextBox.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(573, 118);
            this.Controls.Add(this.stringTextBox);
            this.Controls.Add(this.toStringButton);
            this.Controls.Add(this.hexTextBox);
            this.Controls.Add(this.toHexButton);
            this.Controls.Add(this.originalTextBox);
            this.Name = "Form1";
            this.Text = "BytesToHex";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox originalTextBox;
        private System.Windows.Forms.Button toHexButton;
        private System.Windows.Forms.Button toStringButton;
        private System.Windows.Forms.TextBox hexTextBox;
        private System.Windows.Forms.TextBox stringTextBox;
    }
}

