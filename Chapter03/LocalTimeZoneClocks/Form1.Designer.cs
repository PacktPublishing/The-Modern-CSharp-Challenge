namespace LocalTimeZoneClocks
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
            this.components = new System.ComponentModel.Container();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.newYorkLabel = new System.Windows.Forms.Label();
            this.parisLabel = new System.Windows.Forms.Label();
            this.londonLabel = new System.Windows.Forms.Label();
            this.tokyoLabel = new System.Windows.Forms.Label();
            this.sydneyLabel = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.clockTimer = new System.Windows.Forms.Timer(this.components);
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 5;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Controls.Add(this.newYorkLabel, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.parisLabel, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.londonLabel, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.tokyoLabel, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.sydneyLabel, 4, 1);
            this.tableLayoutPanel1.Controls.Add(this.label5, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.label4, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.label3, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 12);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(560, 87);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // newYorkLabel
            // 
            this.newYorkLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.newYorkLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newYorkLabel.Location = new System.Drawing.Point(3, 30);
            this.newYorkLabel.Name = "newYorkLabel";
            this.newYorkLabel.Size = new System.Drawing.Size(106, 57);
            this.newYorkLabel.TabIndex = 9;
            this.newYorkLabel.Text = "00:00:00";
            this.newYorkLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // parisLabel
            // 
            this.parisLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.parisLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.parisLabel.Location = new System.Drawing.Point(115, 30);
            this.parisLabel.Name = "parisLabel";
            this.parisLabel.Size = new System.Drawing.Size(106, 57);
            this.parisLabel.TabIndex = 8;
            this.parisLabel.Text = "00:00:00";
            this.parisLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // londonLabel
            // 
            this.londonLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.londonLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.londonLabel.Location = new System.Drawing.Point(227, 30);
            this.londonLabel.Name = "londonLabel";
            this.londonLabel.Size = new System.Drawing.Size(106, 57);
            this.londonLabel.TabIndex = 7;
            this.londonLabel.Text = "00:00:00";
            this.londonLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tokyoLabel
            // 
            this.tokyoLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tokyoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tokyoLabel.Location = new System.Drawing.Point(339, 30);
            this.tokyoLabel.Name = "tokyoLabel";
            this.tokyoLabel.Size = new System.Drawing.Size(106, 57);
            this.tokyoLabel.TabIndex = 6;
            this.tokyoLabel.Text = "00:00:00";
            this.tokyoLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // sydneyLabel
            // 
            this.sydneyLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sydneyLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sydneyLabel.Location = new System.Drawing.Point(451, 30);
            this.sydneyLabel.Name = "sydneyLabel";
            this.sydneyLabel.Size = new System.Drawing.Size(106, 57);
            this.sydneyLabel.TabIndex = 5;
            this.sydneyLabel.Text = "00:00:00";
            this.sydneyLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label5.Location = new System.Drawing.Point(451, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 30);
            this.label5.TabIndex = 4;
            this.label5.Text = "Sydney";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Location = new System.Drawing.Point(339, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 30);
            this.label4.TabIndex = 3;
            this.label4.Text = "Tokyo";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Location = new System.Drawing.Point(227, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 30);
            this.label3.TabIndex = 2;
            this.label3.Text = "London";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Location = new System.Drawing.Point(115, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 30);
            this.label2.TabIndex = 1;
            this.label2.Text = "Paris";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "New York";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // clockTimer
            // 
            this.clockTimer.Interval = 1000;
            this.clockTimer.Tick += new System.EventHandler(this.clockTimer_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 111);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Form1";
            this.Text = "LocalTimeZoneClocks";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label newYorkLabel;
        private System.Windows.Forms.Label parisLabel;
        private System.Windows.Forms.Label londonLabel;
        private System.Windows.Forms.Label tokyoLabel;
        private System.Windows.Forms.Label sydneyLabel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer clockTimer;
    }
}

