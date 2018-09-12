namespace Life
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
            this.worldPictureBox = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.patternsStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.stillLifesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.blockToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.beehiveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loafToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.boatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tubToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.oscillatorsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.blinkerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stoplightToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.beaconToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pulsarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pentadecathlonToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.spaceshipsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gliderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lightweightSpaceshipToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.longPatternsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rpentominoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.diehardToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.acornToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gosperGliderGunToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.infinitePatternsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pattern1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pattern2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pattern3ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.randomToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.runToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resetCounterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.wrapEdgesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.startToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.moveTimer = new System.Windows.Forms.Timer(this.components);
            this.intervalLabel = new System.Windows.Forms.Label();
            this.intervalScrollBar = new System.Windows.Forms.HScrollBar();
            this.label1 = new System.Windows.Forms.Label();
            this.turnLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.worldPictureBox)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // worldPictureBox
            // 
            this.worldPictureBox.BackColor = System.Drawing.Color.White;
            this.worldPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.worldPictureBox.Cursor = System.Windows.Forms.Cursors.Cross;
            this.worldPictureBox.Location = new System.Drawing.Point(12, 27);
            this.worldPictureBox.Name = "worldPictureBox";
            this.worldPictureBox.Size = new System.Drawing.Size(400, 400);
            this.worldPictureBox.TabIndex = 1;
            this.worldPictureBox.TabStop = false;
            this.worldPictureBox.Paint += new System.Windows.Forms.PaintEventHandler(this.worldPictureBox_Paint);
            this.worldPictureBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.worldPictureBox_MouseClick);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileStripMenuItem,
            this.patternsStripMenuItem,
            this.runToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(424, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileStripMenuItem
            // 
            this.fileStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileStripMenuItem.Name = "fileStripMenuItem";
            this.fileStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileStripMenuItem.Text = "&File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(92, 22);
            this.exitToolStripMenuItem.Text = "E&xit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // patternsStripMenuItem
            // 
            this.patternsStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clearToolStripMenuItem,
            this.toolStripMenuItem2,
            this.stillLifesToolStripMenuItem,
            this.oscillatorsToolStripMenuItem,
            this.spaceshipsToolStripMenuItem,
            this.longPatternsToolStripMenuItem,
            this.infinitePatternsToolStripMenuItem,
            this.randomToolStripMenuItem});
            this.patternsStripMenuItem.Name = "patternsStripMenuItem";
            this.patternsStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.patternsStripMenuItem.Text = "&Patterns";
            // 
            // clearToolStripMenuItem
            // 
            this.clearToolStripMenuItem.Name = "clearToolStripMenuItem";
            this.clearToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.clearToolStripMenuItem.Text = "&Clear";
            this.clearToolStripMenuItem.Click += new System.EventHandler(this.clearToolStripMenuItem_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(157, 6);
            // 
            // stillLifesToolStripMenuItem
            // 
            this.stillLifesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.blockToolStripMenuItem,
            this.beehiveToolStripMenuItem,
            this.loafToolStripMenuItem,
            this.boatToolStripMenuItem,
            this.tubToolStripMenuItem});
            this.stillLifesToolStripMenuItem.Name = "stillLifesToolStripMenuItem";
            this.stillLifesToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.stillLifesToolStripMenuItem.Text = "&Still Lifes";
            // 
            // blockToolStripMenuItem
            // 
            this.blockToolStripMenuItem.Name = "blockToolStripMenuItem";
            this.blockToolStripMenuItem.Size = new System.Drawing.Size(115, 22);
            this.blockToolStripMenuItem.Text = "&Block";
            this.blockToolStripMenuItem.Click += new System.EventHandler(this.blockToolStripMenuItem_Click);
            // 
            // beehiveToolStripMenuItem
            // 
            this.beehiveToolStripMenuItem.Name = "beehiveToolStripMenuItem";
            this.beehiveToolStripMenuItem.Size = new System.Drawing.Size(115, 22);
            this.beehiveToolStripMenuItem.Text = "B&eehive";
            this.beehiveToolStripMenuItem.Click += new System.EventHandler(this.beehiveToolStripMenuItem_Click);
            // 
            // loafToolStripMenuItem
            // 
            this.loafToolStripMenuItem.Name = "loafToolStripMenuItem";
            this.loafToolStripMenuItem.Size = new System.Drawing.Size(115, 22);
            this.loafToolStripMenuItem.Text = "&Loaf";
            this.loafToolStripMenuItem.Click += new System.EventHandler(this.loafToolStripMenuItem_Click);
            // 
            // boatToolStripMenuItem
            // 
            this.boatToolStripMenuItem.Name = "boatToolStripMenuItem";
            this.boatToolStripMenuItem.Size = new System.Drawing.Size(115, 22);
            this.boatToolStripMenuItem.Text = "B&oat";
            this.boatToolStripMenuItem.Click += new System.EventHandler(this.boatToolStripMenuItem_Click);
            // 
            // tubToolStripMenuItem
            // 
            this.tubToolStripMenuItem.Name = "tubToolStripMenuItem";
            this.tubToolStripMenuItem.Size = new System.Drawing.Size(115, 22);
            this.tubToolStripMenuItem.Text = "&Tub";
            this.tubToolStripMenuItem.Click += new System.EventHandler(this.tubToolStripMenuItem_Click);
            // 
            // oscillatorsToolStripMenuItem
            // 
            this.oscillatorsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.blinkerToolStripMenuItem,
            this.stoplightToolStripMenuItem,
            this.toadToolStripMenuItem,
            this.beaconToolStripMenuItem,
            this.pulsarToolStripMenuItem,
            this.pentadecathlonToolStripMenuItem});
            this.oscillatorsToolStripMenuItem.Name = "oscillatorsToolStripMenuItem";
            this.oscillatorsToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.oscillatorsToolStripMenuItem.Text = "&Oscillators";
            // 
            // blinkerToolStripMenuItem
            // 
            this.blinkerToolStripMenuItem.Name = "blinkerToolStripMenuItem";
            this.blinkerToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.blinkerToolStripMenuItem.Text = "&Blinker";
            this.blinkerToolStripMenuItem.Click += new System.EventHandler(this.blinkerToolStripMenuItem_Click);
            // 
            // stoplightToolStripMenuItem
            // 
            this.stoplightToolStripMenuItem.Name = "stoplightToolStripMenuItem";
            this.stoplightToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.stoplightToolStripMenuItem.Text = "&Stoplight";
            this.stoplightToolStripMenuItem.Click += new System.EventHandler(this.stoplightToolStripMenuItem_Click);
            // 
            // toadToolStripMenuItem
            // 
            this.toadToolStripMenuItem.Name = "toadToolStripMenuItem";
            this.toadToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.toadToolStripMenuItem.Text = "&Toad";
            this.toadToolStripMenuItem.Click += new System.EventHandler(this.toadToolStripMenuItem_Click);
            // 
            // beaconToolStripMenuItem
            // 
            this.beaconToolStripMenuItem.Name = "beaconToolStripMenuItem";
            this.beaconToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.beaconToolStripMenuItem.Text = "B&eacon";
            this.beaconToolStripMenuItem.Click += new System.EventHandler(this.beaconToolStripMenuItem_Click);
            // 
            // pulsarToolStripMenuItem
            // 
            this.pulsarToolStripMenuItem.Name = "pulsarToolStripMenuItem";
            this.pulsarToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.pulsarToolStripMenuItem.Text = "&Pulsar";
            this.pulsarToolStripMenuItem.Click += new System.EventHandler(this.pulsarToolStripMenuItem_Click);
            // 
            // pentadecathlonToolStripMenuItem
            // 
            this.pentadecathlonToolStripMenuItem.Name = "pentadecathlonToolStripMenuItem";
            this.pentadecathlonToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.pentadecathlonToolStripMenuItem.Text = "Pe&ntadecathlon";
            this.pentadecathlonToolStripMenuItem.Click += new System.EventHandler(this.pentadecathlonToolStripMenuItem_Click);
            // 
            // spaceshipsToolStripMenuItem
            // 
            this.spaceshipsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gliderToolStripMenuItem,
            this.lightweightSpaceshipToolStripMenuItem});
            this.spaceshipsToolStripMenuItem.Name = "spaceshipsToolStripMenuItem";
            this.spaceshipsToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.spaceshipsToolStripMenuItem.Text = "S&paceships";
            // 
            // gliderToolStripMenuItem
            // 
            this.gliderToolStripMenuItem.Name = "gliderToolStripMenuItem";
            this.gliderToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
            this.gliderToolStripMenuItem.Text = "&Glider";
            this.gliderToolStripMenuItem.Click += new System.EventHandler(this.gliderToolStripMenuItem_Click);
            // 
            // lightweightSpaceshipToolStripMenuItem
            // 
            this.lightweightSpaceshipToolStripMenuItem.Name = "lightweightSpaceshipToolStripMenuItem";
            this.lightweightSpaceshipToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
            this.lightweightSpaceshipToolStripMenuItem.Text = "&Lightweight Spaceship";
            this.lightweightSpaceshipToolStripMenuItem.Click += new System.EventHandler(this.lightweightSpaceshipToolStripMenuItem_Click);
            // 
            // longPatternsToolStripMenuItem
            // 
            this.longPatternsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.rpentominoToolStripMenuItem,
            this.diehardToolStripMenuItem,
            this.acornToolStripMenuItem,
            this.gosperGliderGunToolStripMenuItem});
            this.longPatternsToolStripMenuItem.Name = "longPatternsToolStripMenuItem";
            this.longPatternsToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.longPatternsToolStripMenuItem.Text = "&Long Patterns";
            // 
            // rpentominoToolStripMenuItem
            // 
            this.rpentominoToolStripMenuItem.Name = "rpentominoToolStripMenuItem";
            this.rpentominoToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.rpentominoToolStripMenuItem.Text = "&R-Pentomino";
            this.rpentominoToolStripMenuItem.Click += new System.EventHandler(this.rPentominoToolStripMenuItem_Click);
            // 
            // diehardToolStripMenuItem
            // 
            this.diehardToolStripMenuItem.Name = "diehardToolStripMenuItem";
            this.diehardToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.diehardToolStripMenuItem.Text = "&Diehard";
            this.diehardToolStripMenuItem.Click += new System.EventHandler(this.diehardToolStripMenuItem_Click);
            // 
            // acornToolStripMenuItem
            // 
            this.acornToolStripMenuItem.Name = "acornToolStripMenuItem";
            this.acornToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.acornToolStripMenuItem.Text = "&Acorn";
            this.acornToolStripMenuItem.Click += new System.EventHandler(this.acornToolStripMenuItem_Click);
            // 
            // gosperGliderGunToolStripMenuItem
            // 
            this.gosperGliderGunToolStripMenuItem.Name = "gosperGliderGunToolStripMenuItem";
            this.gosperGliderGunToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.gosperGliderGunToolStripMenuItem.Text = "G&osper Glider Gun";
            this.gosperGliderGunToolStripMenuItem.Click += new System.EventHandler(this.gosperGliderGunToolStripMenuItem_Click);
            // 
            // infinitePatternsToolStripMenuItem
            // 
            this.infinitePatternsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pattern1ToolStripMenuItem,
            this.pattern2ToolStripMenuItem,
            this.pattern3ToolStripMenuItem});
            this.infinitePatternsToolStripMenuItem.Name = "infinitePatternsToolStripMenuItem";
            this.infinitePatternsToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.infinitePatternsToolStripMenuItem.Text = "&Infinite Patterns";
            // 
            // pattern1ToolStripMenuItem
            // 
            this.pattern1ToolStripMenuItem.Name = "pattern1ToolStripMenuItem";
            this.pattern1ToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
            this.pattern1ToolStripMenuItem.Text = "Pattern &1";
            this.pattern1ToolStripMenuItem.Click += new System.EventHandler(this.pattern1ToolStripMenuItem_Click);
            // 
            // pattern2ToolStripMenuItem
            // 
            this.pattern2ToolStripMenuItem.Name = "pattern2ToolStripMenuItem";
            this.pattern2ToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
            this.pattern2ToolStripMenuItem.Text = "Pattern &2";
            this.pattern2ToolStripMenuItem.Click += new System.EventHandler(this.pattern2ToolStripMenuItem_Click);
            // 
            // pattern3ToolStripMenuItem
            // 
            this.pattern3ToolStripMenuItem.Name = "pattern3ToolStripMenuItem";
            this.pattern3ToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
            this.pattern3ToolStripMenuItem.Text = "Pattern &3";
            this.pattern3ToolStripMenuItem.Click += new System.EventHandler(this.pattern3ToolStripMenuItem_Click);
            // 
            // randomToolStripMenuItem
            // 
            this.randomToolStripMenuItem.Name = "randomToolStripMenuItem";
            this.randomToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.R)));
            this.randomToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.randomToolStripMenuItem.Text = "&Random";
            this.randomToolStripMenuItem.Click += new System.EventHandler(this.randomToolStripMenuItem_Click);
            // 
            // runToolStripMenuItem
            // 
            this.runToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.resetCounterToolStripMenuItem,
            this.wrapEdgesToolStripMenuItem,
            this.startToolStripMenuItem});
            this.runToolStripMenuItem.Name = "runToolStripMenuItem";
            this.runToolStripMenuItem.Size = new System.Drawing.Size(40, 20);
            this.runToolStripMenuItem.Text = "&Run";
            // 
            // resetCounterToolStripMenuItem
            // 
            this.resetCounterToolStripMenuItem.Name = "resetCounterToolStripMenuItem";
            this.resetCounterToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.resetCounterToolStripMenuItem.Text = "&Reset  Counter";
            this.resetCounterToolStripMenuItem.Click += new System.EventHandler(this.resetCounterToolStripMenuItem_Click);
            // 
            // wrapEdgesToolStripMenuItem
            // 
            this.wrapEdgesToolStripMenuItem.Checked = true;
            this.wrapEdgesToolStripMenuItem.CheckOnClick = true;
            this.wrapEdgesToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.wrapEdgesToolStripMenuItem.Name = "wrapEdgesToolStripMenuItem";
            this.wrapEdgesToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.W)));
            this.wrapEdgesToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.wrapEdgesToolStripMenuItem.Text = "&Wrap Edges";
            this.wrapEdgesToolStripMenuItem.Click += new System.EventHandler(this.wrapEdgesToolStripMenuItem_Click);
            // 
            // startToolStripMenuItem
            // 
            this.startToolStripMenuItem.Name = "startToolStripMenuItem";
            this.startToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F5;
            this.startToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.startToolStripMenuItem.Text = "&Start";
            this.startToolStripMenuItem.Click += new System.EventHandler(this.startToolStripMenuItem_Click);
            // 
            // moveTimer
            // 
            this.moveTimer.Interval = 500;
            this.moveTimer.Tick += new System.EventHandler(this.moveTimer_Tick);
            // 
            // intervalLabel
            // 
            this.intervalLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.intervalLabel.AutoSize = true;
            this.intervalLabel.Location = new System.Drawing.Point(12, 431);
            this.intervalLabel.Name = "intervalLabel";
            this.intervalLabel.Size = new System.Drawing.Size(88, 13);
            this.intervalLabel.TabIndex = 3;
            this.intervalLabel.Text = "Interval (500 ms):";
            // 
            // intervalScrollBar
            // 
            this.intervalScrollBar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.intervalScrollBar.Location = new System.Drawing.Point(110, 431);
            this.intervalScrollBar.Maximum = 1009;
            this.intervalScrollBar.Minimum = 10;
            this.intervalScrollBar.Name = "intervalScrollBar";
            this.intervalScrollBar.Size = new System.Drawing.Size(302, 13);
            this.intervalScrollBar.TabIndex = 4;
            this.intervalScrollBar.Value = 500;
            this.intervalScrollBar.ValueChanged += new System.EventHandler(this.intervalScrollBar_ValueChanged);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 449);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Turn:";
            // 
            // turnLabel
            // 
            this.turnLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.turnLabel.AutoSize = true;
            this.turnLabel.Location = new System.Drawing.Point(50, 449);
            this.turnLabel.Name = "turnLabel";
            this.turnLabel.Size = new System.Drawing.Size(13, 13);
            this.turnLabel.TabIndex = 6;
            this.turnLabel.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(424, 471);
            this.Controls.Add(this.turnLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.intervalScrollBar);
            this.Controls.Add(this.intervalLabel);
            this.Controls.Add(this.worldPictureBox);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Life";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.worldPictureBox)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox worldPictureBox;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem patternsStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clearToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem runToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem startToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fileStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Timer moveTimer;
        private System.Windows.Forms.Label intervalLabel;
        private System.Windows.Forms.HScrollBar intervalScrollBar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label turnLabel;
        private System.Windows.Forms.ToolStripMenuItem resetCounterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stillLifesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem blockToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem beehiveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loafToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem boatToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tubToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem oscillatorsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem blinkerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stoplightToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem beaconToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pulsarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pentadecathlonToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem spaceshipsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gliderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lightweightSpaceshipToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem longPatternsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rpentominoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem diehardToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem acornToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gosperGliderGunToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem wrapEdgesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem infinitePatternsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pattern1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pattern2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pattern3ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem randomToolStripMenuItem;
    }
}

