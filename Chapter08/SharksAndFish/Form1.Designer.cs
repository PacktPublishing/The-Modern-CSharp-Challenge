namespace SharksAndFish
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
            this.label1 = new System.Windows.Forms.Label();
            this.gridWidthTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.gridHeightTextBox = new System.Windows.Forms.TextBox();
            this.numSharksTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.numFishTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.startStopButton = new System.Windows.Forms.Button();
            this.oceanPictureBox = new System.Windows.Forms.PictureBox();
            this.msPerTurnTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.turnTimer = new System.Windows.Forms.Timer(this.components);
            this.currentNumSharksTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.currentNumFishTextBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.fishEnergyValueTextBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.fishBreedingTimeTextBox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.sharkEnergyLossTextBox = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.sharkSplitEnergyTextBox = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.turnTextbox = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.oceanPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Grid Width:";
            // 
            // gridWidthTextBox
            // 
            this.gridWidthTextBox.Location = new System.Drawing.Point(81, 12);
            this.gridWidthTextBox.Name = "gridWidthTextBox";
            this.gridWidthTextBox.Size = new System.Drawing.Size(61, 20);
            this.gridWidthTextBox.TabIndex = 0;
            this.gridWidthTextBox.Text = "100";
            this.gridWidthTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Grid Height:";
            // 
            // gridHeightTextBox
            // 
            this.gridHeightTextBox.Location = new System.Drawing.Point(81, 38);
            this.gridHeightTextBox.Name = "gridHeightTextBox";
            this.gridHeightTextBox.Size = new System.Drawing.Size(61, 20);
            this.gridHeightTextBox.TabIndex = 1;
            this.gridHeightTextBox.Text = "100";
            this.gridHeightTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // numSharksTextBox
            // 
            this.numSharksTextBox.Location = new System.Drawing.Point(231, 12);
            this.numSharksTextBox.Name = "numSharksTextBox";
            this.numSharksTextBox.Size = new System.Drawing.Size(61, 20);
            this.numSharksTextBox.TabIndex = 3;
            this.numSharksTextBox.Text = "100";
            this.numSharksTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(157, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "# Sharks:";
            // 
            // numFishTextBox
            // 
            this.numFishTextBox.Location = new System.Drawing.Point(380, 12);
            this.numFishTextBox.Name = "numFishTextBox";
            this.numFishTextBox.Size = new System.Drawing.Size(61, 20);
            this.numFishTextBox.TabIndex = 6;
            this.numFishTextBox.Text = "200";
            this.numFishTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(310, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "# Fish:";
            // 
            // startStopButton
            // 
            this.startStopButton.Location = new System.Drawing.Point(287, 90);
            this.startStopButton.Name = "startStopButton";
            this.startStopButton.Size = new System.Drawing.Size(75, 23);
            this.startStopButton.TabIndex = 12;
            this.startStopButton.Text = "Start";
            this.startStopButton.UseVisualStyleBackColor = true;
            this.startStopButton.Click += new System.EventHandler(this.startStopButton_Click);
            // 
            // oceanPictureBox
            // 
            this.oceanPictureBox.BackColor = System.Drawing.Color.White;
            this.oceanPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.oceanPictureBox.Location = new System.Drawing.Point(12, 119);
            this.oceanPictureBox.Name = "oceanPictureBox";
            this.oceanPictureBox.Size = new System.Drawing.Size(100, 100);
            this.oceanPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.oceanPictureBox.TabIndex = 7;
            this.oceanPictureBox.TabStop = false;
            // 
            // msPerTurnTextBox
            // 
            this.msPerTurnTextBox.Location = new System.Drawing.Point(81, 64);
            this.msPerTurnTextBox.Name = "msPerTurnTextBox";
            this.msPerTurnTextBox.Size = new System.Drawing.Size(61, 20);
            this.msPerTurnTextBox.TabIndex = 2;
            this.msPerTurnTextBox.Text = "100";
            this.msPerTurnTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 67);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "ms/Turn:";
            // 
            // turnTimer
            // 
            this.turnTimer.Tick += new System.EventHandler(this.turnTimer_Tick);
            // 
            // currentNumSharksTextBox
            // 
            this.currentNumSharksTextBox.Location = new System.Drawing.Point(516, 64);
            this.currentNumSharksTextBox.Name = "currentNumSharksTextBox";
            this.currentNumSharksTextBox.ReadOnly = true;
            this.currentNumSharksTextBox.Size = new System.Drawing.Size(61, 20);
            this.currentNumSharksTextBox.TabIndex = 11;
            this.currentNumSharksTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(457, 67);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "# Sharks:";
            // 
            // currentNumFishTextBox
            // 
            this.currentNumFishTextBox.Location = new System.Drawing.Point(516, 38);
            this.currentNumFishTextBox.Name = "currentNumFishTextBox";
            this.currentNumFishTextBox.ReadOnly = true;
            this.currentNumFishTextBox.Size = new System.Drawing.Size(61, 20);
            this.currentNumFishTextBox.TabIndex = 10;
            this.currentNumFishTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(457, 41);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(39, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "# Fish:";
            // 
            // fishEnergyValueTextBox
            // 
            this.fishEnergyValueTextBox.Location = new System.Drawing.Point(380, 64);
            this.fishEnergyValueTextBox.Name = "fishEnergyValueTextBox";
            this.fishEnergyValueTextBox.Size = new System.Drawing.Size(61, 20);
            this.fishEnergyValueTextBox.TabIndex = 8;
            this.fishEnergyValueTextBox.Text = "100";
            this.fishEnergyValueTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(310, 67);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(43, 13);
            this.label8.TabIndex = 17;
            this.label8.Text = "Energy:";
            // 
            // fishBreedingTimeTextBox
            // 
            this.fishBreedingTimeTextBox.Location = new System.Drawing.Point(380, 38);
            this.fishBreedingTimeTextBox.Name = "fishBreedingTimeTextBox";
            this.fishBreedingTimeTextBox.Size = new System.Drawing.Size(61, 20);
            this.fishBreedingTimeTextBox.TabIndex = 7;
            this.fishBreedingTimeTextBox.Text = "20";
            this.fishBreedingTimeTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(310, 41);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(64, 13);
            this.label9.TabIndex = 14;
            this.label9.Text = "Breed Time:";
            // 
            // sharkEnergyLossTextBox
            // 
            this.sharkEnergyLossTextBox.Location = new System.Drawing.Point(231, 38);
            this.sharkEnergyLossTextBox.Name = "sharkEnergyLossTextBox";
            this.sharkEnergyLossTextBox.Size = new System.Drawing.Size(61, 20);
            this.sharkEnergyLossTextBox.TabIndex = 4;
            this.sharkEnergyLossTextBox.Text = "1";
            this.sharkEnergyLossTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(157, 41);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(68, 13);
            this.label10.TabIndex = 18;
            this.label10.Text = "Energy Loss:";
            // 
            // sharkSplitEnergyTextBox
            // 
            this.sharkSplitEnergyTextBox.Location = new System.Drawing.Point(231, 64);
            this.sharkSplitEnergyTextBox.Name = "sharkSplitEnergyTextBox";
            this.sharkSplitEnergyTextBox.Size = new System.Drawing.Size(61, 20);
            this.sharkSplitEnergyTextBox.TabIndex = 5;
            this.sharkSplitEnergyTextBox.Text = "10";
            this.sharkSplitEnergyTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(157, 67);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(66, 13);
            this.label11.TabIndex = 20;
            this.label11.Text = "Split Energy:";
            // 
            // turnTextbox
            // 
            this.turnTextbox.Location = new System.Drawing.Point(516, 12);
            this.turnTextbox.Name = "turnTextbox";
            this.turnTextbox.ReadOnly = true;
            this.turnTextbox.Size = new System.Drawing.Size(61, 20);
            this.turnTextbox.TabIndex = 9;
            this.turnTextbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(457, 15);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(32, 13);
            this.label12.TabIndex = 22;
            this.label12.Text = "Turn:";
            // 
            // Form1
            // 
            this.AcceptButton = this.startStopButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 231);
            this.Controls.Add(this.turnTextbox);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.sharkSplitEnergyTextBox);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.sharkEnergyLossTextBox);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.fishEnergyValueTextBox);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.fishBreedingTimeTextBox);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.currentNumSharksTextBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.currentNumFishTextBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.msPerTurnTextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.oceanPictureBox);
            this.Controls.Add(this.startStopButton);
            this.Controls.Add(this.numSharksTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.numFishTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.gridHeightTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.gridWidthTextBox);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "SharksAndFish";
            ((System.ComponentModel.ISupportInitialize)(this.oceanPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox gridWidthTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox gridHeightTextBox;
        private System.Windows.Forms.TextBox numSharksTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox numFishTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button startStopButton;
        private System.Windows.Forms.PictureBox oceanPictureBox;
        private System.Windows.Forms.TextBox msPerTurnTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Timer turnTimer;
        private System.Windows.Forms.TextBox currentNumSharksTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox currentNumFishTextBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox fishEnergyValueTextBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox fishBreedingTimeTextBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox sharkEnergyLossTextBox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox sharkSplitEnergyTextBox;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox turnTextbox;
        private System.Windows.Forms.Label label12;
    }
}

