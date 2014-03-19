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
            this.pBox = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbClear = new System.Windows.Forms.RadioButton();
            this.rbDraw = new System.Windows.Forms.RadioButton();
            this.nudPixelSize = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnNextStep = new System.Windows.Forms.Button();
            this.btnGenerateRandom = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.nudWorldHeight = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.nudWorldWidth = new System.Windows.Forms.NumericUpDown();
            this.btnGenerateClean = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pBox)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudPixelSize)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudWorldHeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudWorldWidth)).BeginInit();
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
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbClear);
            this.groupBox1.Controls.Add(this.rbDraw);
            this.groupBox1.Location = new System.Drawing.Point(6, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(174, 66);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Drawing";
            // 
            // rbClear
            // 
            this.rbClear.AutoSize = true;
            this.rbClear.Location = new System.Drawing.Point(6, 42);
            this.rbClear.Name = "rbClear";
            this.rbClear.Size = new System.Drawing.Size(49, 17);
            this.rbClear.TabIndex = 1;
            this.rbClear.Text = "Clear";
            this.rbClear.UseVisualStyleBackColor = true;
            // 
            // rbDraw
            // 
            this.rbDraw.AutoSize = true;
            this.rbDraw.Checked = true;
            this.rbDraw.Location = new System.Drawing.Point(6, 19);
            this.rbDraw.Name = "rbDraw";
            this.rbDraw.Size = new System.Drawing.Size(50, 17);
            this.rbDraw.TabIndex = 0;
            this.rbDraw.TabStop = true;
            this.rbDraw.Text = "Draw";
            this.rbDraw.UseVisualStyleBackColor = true;
            // 
            // nudPixelSize
            // 
            this.nudPixelSize.Location = new System.Drawing.Point(9, 32);
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
            8,
            0,
            0,
            0});
            this.nudPixelSize.ValueChanged += new System.EventHandler(this.nudPixelSize_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Pixel Size";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.nudPixelSize);
            this.groupBox2.Location = new System.Drawing.Point(6, 210);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(174, 67);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Size";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.pBox);
            this.groupBox3.Location = new System.Drawing.Point(186, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(651, 504);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            // 
            // btnNextStep
            // 
            this.btnNextStep.Location = new System.Drawing.Point(6, 283);
            this.btnNextStep.Name = "btnNextStep";
            this.btnNextStep.Size = new System.Drawing.Size(103, 23);
            this.btnNextStep.TabIndex = 6;
            this.btnNextStep.Text = "Next Step";
            this.btnNextStep.UseVisualStyleBackColor = true;
            this.btnNextStep.Click += new System.EventHandler(this.btnNextStep_Click);
            // 
            // btnGenerateRandom
            // 
            this.btnGenerateRandom.Location = new System.Drawing.Point(6, 87);
            this.btnGenerateRandom.Name = "btnGenerateRandom";
            this.btnGenerateRandom.Size = new System.Drawing.Size(103, 23);
            this.btnGenerateRandom.TabIndex = 7;
            this.btnGenerateRandom.Text = "Generate Random";
            this.btnGenerateRandom.UseVisualStyleBackColor = true;
            this.btnGenerateRandom.Click += new System.EventHandler(this.btnGenerateNew_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Controls.Add(this.nudWorldHeight);
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Controls.Add(this.nudWorldWidth);
            this.groupBox4.Controls.Add(this.btnGenerateClean);
            this.groupBox4.Controls.Add(this.btnGenerateRandom);
            this.groupBox4.Location = new System.Drawing.Point(6, 84);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(174, 120);
            this.groupBox4.TabIndex = 8;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Generation";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(79, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Height";
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
            60,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Width";
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
            80,
            0,
            0,
            0});
            // 
            // btnGenerateClean
            // 
            this.btnGenerateClean.Location = new System.Drawing.Point(6, 58);
            this.btnGenerateClean.Name = "btnGenerateClean";
            this.btnGenerateClean.Size = new System.Drawing.Size(103, 23);
            this.btnGenerateClean.TabIndex = 8;
            this.btnGenerateClean.Text = "Generate Clean";
            this.btnGenerateClean.UseVisualStyleBackColor = true;
            this.btnGenerateClean.Click += new System.EventHandler(this.btnGenerateClean_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(849, 520);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.btnNextStep);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmMain";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pBox)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudPixelSize)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudWorldHeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudWorldWidth)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbClear;
        private System.Windows.Forms.RadioButton rbDraw;
        private System.Windows.Forms.NumericUpDown nudPixelSize;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnNextStep;
        private System.Windows.Forms.Button btnGenerateRandom;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnGenerateClean;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown nudWorldHeight;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown nudWorldWidth;
    }
}

