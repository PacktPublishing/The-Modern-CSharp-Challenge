namespace GaussianElimination
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
            this.coefficientsTextBox = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.resultsTextBox = new System.Windows.Forms.TextBox();
            this.lblVariables = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.valuesTextBox = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.solveButton = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // coefficientsTextBox
            // 
            this.coefficientsTextBox.AcceptsReturn = true;
            this.coefficientsTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.coefficientsTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.coefficientsTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.coefficientsTextBox.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.coefficientsTextBox.ForeColor = System.Drawing.SystemColors.WindowText;
            this.coefficientsTextBox.Location = new System.Drawing.Point(3, 3);
            this.coefficientsTextBox.MaxLength = 0;
            this.coefficientsTextBox.Multiline = true;
            this.coefficientsTextBox.Name = "coefficientsTextBox";
            this.coefficientsTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.coefficientsTextBox.Size = new System.Drawing.Size(129, 81);
            this.coefficientsTextBox.TabIndex = 12;
            this.coefficientsTextBox.Text = " 1  4   1  2 1\r\n32 16   8  4 2\r\n12 81  27  9 3\r\n24 56  64 16 4\r\n25 25 125 25 5";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel1.Controls.Add(this.coefficientsTextBox, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.resultsTextBox, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.lblVariables, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.Label1, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.valuesTextBox, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 12);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(263, 330);
            this.tableLayoutPanel1.TabIndex = 19;
            // 
            // resultsTextBox
            // 
            this.resultsTextBox.AcceptsReturn = true;
            this.resultsTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.tableLayoutPanel1.SetColumnSpan(this.resultsTextBox, 4);
            this.resultsTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.resultsTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.resultsTextBox.Font = new System.Drawing.Font("Courier New", 8.25F);
            this.resultsTextBox.ForeColor = System.Drawing.SystemColors.WindowText;
            this.resultsTextBox.Location = new System.Drawing.Point(3, 130);
            this.resultsTextBox.MaxLength = 0;
            this.resultsTextBox.Multiline = true;
            this.resultsTextBox.Name = "resultsTextBox";
            this.resultsTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.resultsTextBox.Size = new System.Drawing.Size(257, 197);
            this.resultsTextBox.TabIndex = 17;
            // 
            // lblVariables
            // 
            this.lblVariables.BackColor = System.Drawing.SystemColors.Control;
            this.lblVariables.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblVariables.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblVariables.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblVariables.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVariables.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblVariables.Location = new System.Drawing.Point(138, 0);
            this.lblVariables.Name = "lblVariables";
            this.lblVariables.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblVariables.Size = new System.Drawing.Size(34, 87);
            this.lblVariables.TabIndex = 14;
            this.lblVariables.Text = "x0\r\nx1\r\nx2\r\nx3\r\n...";
            this.lblVariables.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Label1
            // 
            this.Label1.BackColor = System.Drawing.Color.Transparent;
            this.Label1.Cursor = System.Windows.Forms.Cursors.Default;
            this.Label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Label1.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Label1.Location = new System.Drawing.Point(178, 0);
            this.Label1.Name = "Label1";
            this.Label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label1.Size = new System.Drawing.Size(24, 87);
            this.Label1.TabIndex = 15;
            this.Label1.Text = "=";
            this.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // valuesTextBox
            // 
            this.valuesTextBox.AcceptsReturn = true;
            this.valuesTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.valuesTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.valuesTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.valuesTextBox.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.valuesTextBox.ForeColor = System.Drawing.SystemColors.WindowText;
            this.valuesTextBox.Location = new System.Drawing.Point(208, 3);
            this.valuesTextBox.MaxLength = 0;
            this.valuesTextBox.Multiline = true;
            this.valuesTextBox.Name = "valuesTextBox";
            this.valuesTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.valuesTextBox.Size = new System.Drawing.Size(52, 81);
            this.valuesTextBox.TabIndex = 13;
            this.valuesTextBox.Text = "17\r\n-1\r\n28\r\n0\r\n60";
            this.valuesTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // panel1
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.panel1, 4);
            this.panel1.Controls.Add(this.solveButton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 90);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(257, 34);
            this.panel1.TabIndex = 16;
            // 
            // solveButton
            // 
            this.solveButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.solveButton.BackColor = System.Drawing.SystemColors.Control;
            this.solveButton.Cursor = System.Windows.Forms.Cursors.Default;
            this.solveButton.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.solveButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.solveButton.Location = new System.Drawing.Point(89, 0);
            this.solveButton.Name = "solveButton";
            this.solveButton.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.solveButton.Size = new System.Drawing.Size(75, 23);
            this.solveButton.TabIndex = 16;
            this.solveButton.Text = "Solve";
            this.solveButton.UseVisualStyleBackColor = false;
            this.solveButton.Click += new System.EventHandler(this.solveButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(287, 354);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Form1";
            this.Text = "GaussianElimination";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.TextBox coefficientsTextBox;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        public System.Windows.Forms.TextBox resultsTextBox;
        public System.Windows.Forms.Label lblVariables;
        public System.Windows.Forms.Label Label1;
        public System.Windows.Forms.TextBox valuesTextBox;
        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.Button solveButton;
    }
}

