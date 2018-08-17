namespace TimeZoneChart
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
            this.timeZone0ComboBox = new System.Windows.Forms.ComboBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.timeZone1ComboBox = new System.Windows.Forms.ComboBox();
            this.timesListView = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // timeZone0ComboBox
            // 
            this.timeZone0ComboBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.timeZone0ComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.timeZone0ComboBox.FormattingEnabled = true;
            this.timeZone0ComboBox.Location = new System.Drawing.Point(3, 3);
            this.timeZone0ComboBox.Name = "timeZone0ComboBox";
            this.timeZone0ComboBox.Size = new System.Drawing.Size(274, 21);
            this.timeZone0ComboBox.TabIndex = 0;
            this.timeZone0ComboBox.SelectedIndexChanged += new System.EventHandler(this.timeZoneComboBox_SelectedIndexChanged);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.timeZone1ComboBox, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.timeZone0ComboBox, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 38);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(560, 29);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // timeZone1ComboBox
            // 
            this.timeZone1ComboBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.timeZone1ComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.timeZone1ComboBox.FormattingEnabled = true;
            this.timeZone1ComboBox.Location = new System.Drawing.Point(283, 3);
            this.timeZone1ComboBox.Name = "timeZone1ComboBox";
            this.timeZone1ComboBox.Size = new System.Drawing.Size(274, 21);
            this.timeZone1ComboBox.TabIndex = 1;
            this.timeZone1ComboBox.SelectedIndexChanged += new System.EventHandler(this.timeZoneComboBox_SelectedIndexChanged);
            // 
            // timesListView
            // 
            this.timesListView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.timesListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.timesListView.HideSelection = false;
            this.timesListView.Location = new System.Drawing.Point(12, 73);
            this.timesListView.Name = "timesListView";
            this.timesListView.Size = new System.Drawing.Size(560, 176);
            this.timesListView.TabIndex = 4;
            this.timesListView.UseCompatibleStateImageBehavior = false;
            this.timesListView.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Timezone 1";
            this.columnHeader1.Width = 279;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Timezone 2";
            this.columnHeader2.Width = 253;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Date:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(51, 12);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(238, 20);
            this.dateTimePicker1.TabIndex = 6;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 261);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.timesListView);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Form1";
            this.Text = "TimeZoneChart";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox timeZone0ComboBox;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.ComboBox timeZone1ComboBox;
        private System.Windows.Forms.ListView timesListView;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}

