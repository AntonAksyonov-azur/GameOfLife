namespace ConwayGameofLife
{
    partial class FrmMain
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.pBox = new System.Windows.Forms.PictureBox();
            this.nudPixelSize = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnNextGeneration = new System.Windows.Forms.Button();
            this.btnGenerateRandom = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnDimDown = new System.Windows.Forms.Button();
            this.btnDimUp = new System.Windows.Forms.Button();
            this.cbDrawGrid = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.nudRandomCount = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.nudWorldHeight = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.nudWorldWidth = new System.Windows.Forms.NumericUpDown();
            this.btnGenerateClean = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsslMouseCoordinates = new System.Windows.Forms.ToolStripStatusLabel();
            this.lGeneration = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.nudTimerInterval = new System.Windows.Forms.NumericUpDown();
            this.btnEnableDisableTimer = new System.Windows.Forms.Button();
            this.timerWorldGeneration = new System.Windows.Forms.Timer(this.components);
            this.btnSelectElementColor = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSelectBackgroundColor = new System.Windows.Forms.Button();
            this.btnSelectGridColor = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPixelSize)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudRandomCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudWorldHeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudWorldWidth)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudTimerInterval)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pBox
            // 
            this.pBox.BackColor = System.Drawing.Color.Black;
            this.pBox.Location = new System.Drawing.Point(6, 10);
            this.pBox.Name = "pBox";
            this.pBox.Size = new System.Drawing.Size(640, 480);
            this.pBox.TabIndex = 0;
            this.pBox.TabStop = false;
            this.pBox.Paint += new System.Windows.Forms.PaintEventHandler(this.pBox_Paint);
            this.pBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pBox_MouseClick);
            this.pBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pBox_MouseDown);
            this.pBox.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pBox_MouseMove);
            this.pBox.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pBox_MouseUp);
            // 
            // nudPixelSize
            // 
            this.nudPixelSize.Location = new System.Drawing.Point(9, 71);
            this.nudPixelSize.Maximum = new decimal(new int[] {
            128,
            0,
            0,
            0});
            this.nudPixelSize.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudPixelSize.Name = "nudPixelSize";
            this.nudPixelSize.Size = new System.Drawing.Size(88, 20);
            this.nudPixelSize.TabIndex = 2;
            this.nudPixelSize.Value = new decimal(new int[] {
            16,
            0,
            0,
            0});
            this.nudPixelSize.ValueChanged += new System.EventHandler(this.nudPixelSize_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Pixel presentaion size";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.pBox);
            this.groupBox3.Location = new System.Drawing.Point(171, 5);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(651, 496);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            // 
            // btnNextGeneration
            // 
            this.btnNextGeneration.Location = new System.Drawing.Point(6, 58);
            this.btnNextGeneration.Name = "btnNextGeneration";
            this.btnNextGeneration.Size = new System.Drawing.Size(143, 23);
            this.btnNextGeneration.TabIndex = 6;
            this.btnNextGeneration.Text = "Force Next Generation";
            this.btnNextGeneration.UseVisualStyleBackColor = true;
            this.btnNextGeneration.Click += new System.EventHandler(this.btnNextStep_Click);
            // 
            // btnGenerateRandom
            // 
            this.btnGenerateRandom.Location = new System.Drawing.Point(68, 134);
            this.btnGenerateRandom.Name = "btnGenerateRandom";
            this.btnGenerateRandom.Size = new System.Drawing.Size(81, 23);
            this.btnGenerateRandom.TabIndex = 7;
            this.btnGenerateRandom.Text = "Random";
            this.btnGenerateRandom.UseVisualStyleBackColor = true;
            this.btnGenerateRandom.Click += new System.EventHandler(this.btnGenerateNew_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnDimDown);
            this.groupBox4.Controls.Add(this.btnDimUp);
            this.groupBox4.Controls.Add(this.cbDrawGrid);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Controls.Add(this.nudRandomCount);
            this.groupBox4.Controls.Add(this.label1);
            this.groupBox4.Controls.Add(this.nudPixelSize);
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Controls.Add(this.nudWorldHeight);
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Controls.Add(this.nudWorldWidth);
            this.groupBox4.Controls.Add(this.btnGenerateClean);
            this.groupBox4.Controls.Add(this.btnGenerateRandom);
            this.groupBox4.Location = new System.Drawing.Point(6, 3);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(165, 192);
            this.groupBox4.TabIndex = 8;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Generation";
            // 
            // btnDimDown
            // 
            this.btnDimDown.Location = new System.Drawing.Point(130, 68);
            this.btnDimDown.Name = "btnDimDown";
            this.btnDimDown.Size = new System.Drawing.Size(29, 23);
            this.btnDimDown.TabIndex = 18;
            this.btnDimDown.Text = "D";
            this.btnDimDown.UseVisualStyleBackColor = true;
            this.btnDimDown.Click += new System.EventHandler(this.btnDimDown_Click);
            // 
            // btnDimUp
            // 
            this.btnDimUp.Location = new System.Drawing.Point(97, 68);
            this.btnDimUp.Name = "btnDimUp";
            this.btnDimUp.Size = new System.Drawing.Size(29, 23);
            this.btnDimUp.TabIndex = 17;
            this.btnDimUp.Text = "U";
            this.btnDimUp.UseVisualStyleBackColor = true;
            this.btnDimUp.Click += new System.EventHandler(this.btnDimUp_Click);
            // 
            // cbDrawGrid
            // 
            this.cbDrawGrid.AutoSize = true;
            this.cbDrawGrid.Checked = true;
            this.cbDrawGrid.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbDrawGrid.Location = new System.Drawing.Point(9, 163);
            this.cbDrawGrid.Name = "cbDrawGrid";
            this.cbDrawGrid.Size = new System.Drawing.Size(73, 17);
            this.cbDrawGrid.TabIndex = 16;
            this.cbDrawGrid.Text = "Draw Grid";
            this.cbDrawGrid.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 121);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Count:";
            // 
            // nudRandomCount
            // 
            this.nudRandomCount.Location = new System.Drawing.Point(9, 137);
            this.nudRandomCount.Maximum = new decimal(new int[] {
            3000,
            0,
            0,
            0});
            this.nudRandomCount.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudRandomCount.Name = "nudRandomCount";
            this.nudRandomCount.Size = new System.Drawing.Size(53, 20);
            this.nudRandomCount.TabIndex = 14;
            this.nudRandomCount.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(79, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Height:";
            // 
            // nudWorldHeight
            // 
            this.nudWorldHeight.Location = new System.Drawing.Point(82, 32);
            this.nudWorldHeight.Maximum = new decimal(new int[] {
            480,
            0,
            0,
            0});
            this.nudWorldHeight.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudWorldHeight.Name = "nudWorldHeight";
            this.nudWorldHeight.Size = new System.Drawing.Size(67, 20);
            this.nudWorldHeight.TabIndex = 11;
            this.nudWorldHeight.Value = new decimal(new int[] {
            30,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Width:";
            // 
            // nudWorldWidth
            // 
            this.nudWorldWidth.Location = new System.Drawing.Point(9, 32);
            this.nudWorldWidth.Maximum = new decimal(new int[] {
            640,
            0,
            0,
            0});
            this.nudWorldWidth.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudWorldWidth.Name = "nudWorldWidth";
            this.nudWorldWidth.Size = new System.Drawing.Size(67, 20);
            this.nudWorldWidth.TabIndex = 9;
            this.nudWorldWidth.Value = new decimal(new int[] {
            40,
            0,
            0,
            0});
            // 
            // btnGenerateClean
            // 
            this.btnGenerateClean.Location = new System.Drawing.Point(6, 97);
            this.btnGenerateClean.Name = "btnGenerateClean";
            this.btnGenerateClean.Size = new System.Drawing.Size(143, 23);
            this.btnGenerateClean.TabIndex = 8;
            this.btnGenerateClean.Text = "Generate Clean";
            this.btnGenerateClean.UseVisualStyleBackColor = true;
            this.btnGenerateClean.Click += new System.EventHandler(this.btnGenerateClean_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolStripStatusLabel2,
            this.tsslMouseCoordinates});
            this.statusStrip1.Location = new System.Drawing.Point(0, 504);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(826, 22);
            this.statusStrip1.TabIndex = 9;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(196, 17);
            this.toolStripStatusLabel1.Text = "Note, that size of view area is 640x480";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(11, 17);
            this.toolStripStatusLabel2.Text = "|";
            // 
            // tsslMouseCoordinates
            // 
            this.tsslMouseCoordinates.Name = "tsslMouseCoordinates";
            this.tsslMouseCoordinates.Size = new System.Drawing.Size(138, 17);
            this.tsslMouseCoordinates.Text = "Mouse coordinates  = (0:0)";
            // 
            // lGeneration
            // 
            this.lGeneration.AutoSize = true;
            this.lGeneration.Location = new System.Drawing.Point(6, 84);
            this.lGeneration.Name = "lGeneration";
            this.lGeneration.Size = new System.Drawing.Size(112, 13);
            this.lGeneration.TabIndex = 10;
            this.lGeneration.Text = "Current generation = 0";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.label4);
            this.groupBox5.Controls.Add(this.nudTimerInterval);
            this.groupBox5.Controls.Add(this.btnEnableDisableTimer);
            this.groupBox5.Controls.Add(this.btnNextGeneration);
            this.groupBox5.Controls.Add(this.lGeneration);
            this.groupBox5.Location = new System.Drawing.Point(6, 201);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(165, 108);
            this.groupBox5.TabIndex = 11;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Generation control";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Interval:";
            // 
            // nudTimerInterval
            // 
            this.nudTimerInterval.Location = new System.Drawing.Point(9, 32);
            this.nudTimerInterval.Maximum = new decimal(new int[] {
            3000,
            0,
            0,
            0});
            this.nudTimerInterval.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudTimerInterval.Name = "nudTimerInterval";
            this.nudTimerInterval.Size = new System.Drawing.Size(53, 20);
            this.nudTimerInterval.TabIndex = 12;
            this.nudTimerInterval.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.nudTimerInterval.ValueChanged += new System.EventHandler(this.nudTimerInterval_ValueChanged);
            // 
            // btnEnableDisableTimer
            // 
            this.btnEnableDisableTimer.Location = new System.Drawing.Point(68, 29);
            this.btnEnableDisableTimer.Name = "btnEnableDisableTimer";
            this.btnEnableDisableTimer.Size = new System.Drawing.Size(81, 23);
            this.btnEnableDisableTimer.TabIndex = 11;
            this.btnEnableDisableTimer.Text = "Enable Timer";
            this.btnEnableDisableTimer.UseVisualStyleBackColor = true;
            this.btnEnableDisableTimer.Click += new System.EventHandler(this.btnEnableDisableTimer_Click);
            // 
            // timerWorldGeneration
            // 
            this.timerWorldGeneration.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // btnSelectElementColor
            // 
            this.btnSelectElementColor.Location = new System.Drawing.Point(6, 19);
            this.btnSelectElementColor.Name = "btnSelectElementColor";
            this.btnSelectElementColor.Size = new System.Drawing.Size(147, 23);
            this.btnSelectElementColor.TabIndex = 12;
            this.btnSelectElementColor.Text = "Element elementColor";
            this.btnSelectElementColor.UseVisualStyleBackColor = true;
            this.btnSelectElementColor.Click += new System.EventHandler(this.btnSelectElementColor_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnSelectBackgroundColor);
            this.groupBox1.Controls.Add(this.btnSelectGridColor);
            this.groupBox1.Controls.Add(this.btnSelectElementColor);
            this.groupBox1.Location = new System.Drawing.Point(0, 315);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(171, 107);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Colors";
            // 
            // btnSelectBackgroundColor
            // 
            this.btnSelectBackgroundColor.Location = new System.Drawing.Point(6, 77);
            this.btnSelectBackgroundColor.Name = "btnSelectBackgroundColor";
            this.btnSelectBackgroundColor.Size = new System.Drawing.Size(147, 23);
            this.btnSelectBackgroundColor.TabIndex = 14;
            this.btnSelectBackgroundColor.Text = "Background";
            this.btnSelectBackgroundColor.UseVisualStyleBackColor = true;
            this.btnSelectBackgroundColor.Click += new System.EventHandler(this.btnSelectBackgroundColor_Click);
            // 
            // btnSelectGridColor
            // 
            this.btnSelectGridColor.Location = new System.Drawing.Point(6, 48);
            this.btnSelectGridColor.Name = "btnSelectGridColor";
            this.btnSelectGridColor.Size = new System.Drawing.Size(147, 23);
            this.btnSelectGridColor.TabIndex = 13;
            this.btnSelectGridColor.Text = "Grid";
            this.btnSelectGridColor.UseVisualStyleBackColor = true;
            this.btnSelectGridColor.Click += new System.EventHandler(this.btnSelectGridColor_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(826, 526);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FrmMain";
            this.Text = "Conway\'s Game Of Life";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPixelSize)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudRandomCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudWorldHeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudWorldWidth)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudTimerInterval)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pBox;
        private System.Windows.Forms.NumericUpDown nudPixelSize;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnNextGeneration;
        private System.Windows.Forms.Button btnGenerateRandom;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnGenerateClean;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown nudWorldHeight;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown nudWorldWidth;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel tsslMouseCoordinates;
        private System.Windows.Forms.Label lGeneration;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button btnEnableDisableTimer;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown nudTimerInterval;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.Timer timerWorldGeneration;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown nudRandomCount;
        private System.Windows.Forms.Button btnSelectElementColor;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnSelectBackgroundColor;
        private System.Windows.Forms.Button btnSelectGridColor;
        private System.Windows.Forms.CheckBox cbDrawGrid;
        private System.Windows.Forms.Button btnDimDown;
        private System.Windows.Forms.Button btnDimUp;
    }
}

