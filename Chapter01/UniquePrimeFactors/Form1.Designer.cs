namespace UniquePrimeFactors
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
            this.uniqueFactorsTextBox = new System.Windows.Forms.TextBox();
            this.btnGo = new System.Windows.Forms.Button();
            this.txtNumber = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.factorsTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // uniqueFactorsTextBox
            // 
            this.uniqueFactorsTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.uniqueFactorsTextBox.Location = new System.Drawing.Point(126, 119);
            this.uniqueFactorsTextBox.Name = "uniqueFactorsTextBox";
            this.uniqueFactorsTextBox.ReadOnly = true;
            this.uniqueFactorsTextBox.Size = new System.Drawing.Size(244, 22);
            this.uniqueFactorsTextBox.TabIndex = 24;
            // 
            // btnGo
            // 
            this.btnGo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGo.Location = new System.Drawing.Point(295, 12);
            this.btnGo.Name = "btnGo";
            this.btnGo.Size = new System.Drawing.Size(75, 23);
            this.btnGo.TabIndex = 23;
            this.btnGo.Text = "Go";
            this.btnGo.UseVisualStyleBackColor = true;
            this.btnGo.Click += new System.EventHandler(this.btnGo_Click);
            // 
            // txtNumber
            // 
            this.txtNumber.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNumber.Location = new System.Drawing.Point(126, 12);
            this.txtNumber.Name = "txtNumber";
            this.txtNumber.Size = new System.Drawing.Size(154, 22);
            this.txtNumber.TabIndex = 22;
            this.txtNumber.Text = "12345678901224";
            this.txtNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 17);
            this.label1.TabIndex = 21;
            this.label1.Text = "Number:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 17);
            this.label2.TabIndex = 25;
            this.label2.Text = "Unique Factors:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 17);
            this.label3.TabIndex = 27;
            this.label3.Text = "Factors:";
            // 
            // factorsTextBox
            // 
            this.factorsTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.factorsTextBox.Location = new System.Drawing.Point(126, 91);
            this.factorsTextBox.Name = "factorsTextBox";
            this.factorsTextBox.ReadOnly = true;
            this.factorsTextBox.Size = new System.Drawing.Size(244, 22);
            this.factorsTextBox.TabIndex = 26;
            // 
            // Form1
            // 
            this.AcceptButton = this.btnGo;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(382, 153);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.factorsTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.uniqueFactorsTextBox);
            this.Controls.Add(this.btnGo);
            this.Controls.Add(this.txtNumber);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "UniquePrimeFactors";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox uniqueFactorsTextBox;
        private System.Windows.Forms.Button btnGo;
        private System.Windows.Forms.TextBox txtNumber;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox factorsTextBox;
    }
}

