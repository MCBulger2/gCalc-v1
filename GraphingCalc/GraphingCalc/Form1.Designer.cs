namespace GraphingCalc
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
            this.tbInput1 = new System.Windows.Forms.TextBox();
            this.btnGraph = new System.Windows.Forms.Button();
            this.lblY1 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbInput2 = new System.Windows.Forms.TextBox();
            this.btnColor1 = new System.Windows.Forms.Button();
            this.btnColor2 = new System.Windows.Forms.Button();
            this.nudGridSize = new System.Windows.Forms.NumericUpDown();
            this.cbShowGrid = new System.Windows.Forms.CheckBox();
            this.nudThickness = new System.Windows.Forms.NumericUpDown();
            this.nudSampleRate = new System.Windows.Forms.NumericUpDown();
            this.lblX = new System.Windows.Forms.Label();
            this.lblY = new System.Windows.Forms.Label();
            this.btnCenter = new System.Windows.Forms.Button();
            this.btnColor3 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.tbInput3 = new System.Windows.Forms.TextBox();
            this.nudRange = new System.Windows.Forms.NumericUpDown();
            this.cbRangeAuto = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.nudGridSize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudThickness)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSampleRate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudRange)).BeginInit();
            this.SuspendLayout();
            // 
            // tbInput1
            // 
            this.tbInput1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbInput1.Location = new System.Drawing.Point(872, 12);
            this.tbInput1.Name = "tbInput1";
            this.tbInput1.Size = new System.Drawing.Size(100, 20);
            this.tbInput1.TabIndex = 0;
            // 
            // btnGraph
            // 
            this.btnGraph.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGraph.Location = new System.Drawing.Point(897, 280);
            this.btnGraph.Name = "btnGraph";
            this.btnGraph.Size = new System.Drawing.Size(75, 23);
            this.btnGraph.TabIndex = 1;
            this.btnGraph.Text = "Graph";
            this.btnGraph.UseVisualStyleBackColor = true;
            this.btnGraph.Click += new System.EventHandler(this.btnGraph_Click);
            // 
            // lblY1
            // 
            this.lblY1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblY1.AutoSize = true;
            this.lblY1.Location = new System.Drawing.Point(839, 15);
            this.lblY1.Name = "lblY1";
            this.lblY1.Size = new System.Drawing.Size(26, 13);
            this.lblY1.TabIndex = 2;
            this.lblY1.Text = "Y1=";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(839, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Y2=";
            // 
            // tbInput2
            // 
            this.tbInput2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbInput2.Location = new System.Drawing.Point(872, 38);
            this.tbInput2.Name = "tbInput2";
            this.tbInput2.Size = new System.Drawing.Size(100, 20);
            this.tbInput2.TabIndex = 3;
            // 
            // btnColor1
            // 
            this.btnColor1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnColor1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnColor1.Location = new System.Drawing.Point(813, 11);
            this.btnColor1.Name = "btnColor1";
            this.btnColor1.Size = new System.Drawing.Size(20, 20);
            this.btnColor1.TabIndex = 5;
            this.btnColor1.Tag = "0";
            this.btnColor1.UseVisualStyleBackColor = true;
            this.btnColor1.Click += new System.EventHandler(this.colorSelect);
            // 
            // btnColor2
            // 
            this.btnColor2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnColor2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnColor2.Location = new System.Drawing.Point(813, 37);
            this.btnColor2.Name = "btnColor2";
            this.btnColor2.Size = new System.Drawing.Size(20, 20);
            this.btnColor2.TabIndex = 6;
            this.btnColor2.Tag = "1";
            this.btnColor2.UseVisualStyleBackColor = true;
            this.btnColor2.Click += new System.EventHandler(this.colorSelect);
            // 
            // nudGridSize
            // 
            this.nudGridSize.Location = new System.Drawing.Point(852, 610);
            this.nudGridSize.Name = "nudGridSize";
            this.nudGridSize.ReadOnly = true;
            this.nudGridSize.Size = new System.Drawing.Size(120, 20);
            this.nudGridSize.TabIndex = 7;
            this.nudGridSize.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.nudGridSize.ValueChanged += new System.EventHandler(this.nudGridSize_ValueChanged);
            // 
            // cbShowGrid
            // 
            this.cbShowGrid.AutoSize = true;
            this.cbShowGrid.Checked = true;
            this.cbShowGrid.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbShowGrid.Location = new System.Drawing.Point(897, 577);
            this.cbShowGrid.Name = "cbShowGrid";
            this.cbShowGrid.Size = new System.Drawing.Size(51, 17);
            this.cbShowGrid.TabIndex = 8;
            this.cbShowGrid.Text = "show";
            this.cbShowGrid.UseVisualStyleBackColor = true;
            this.cbShowGrid.Click += new System.EventHandler(this.cbShowGrid_Click);
            // 
            // nudThickness
            // 
            this.nudThickness.Location = new System.Drawing.Point(852, 651);
            this.nudThickness.Name = "nudThickness";
            this.nudThickness.ReadOnly = true;
            this.nudThickness.Size = new System.Drawing.Size(120, 20);
            this.nudThickness.TabIndex = 9;
            this.nudThickness.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.nudThickness.ValueChanged += new System.EventHandler(this.nudThickness_ValueChanged);
            // 
            // nudSampleRate
            // 
            this.nudSampleRate.DecimalPlaces = 2;
            this.nudSampleRate.Increment = new decimal(new int[] {
            5,
            0,
            0,
            131072});
            this.nudSampleRate.Location = new System.Drawing.Point(828, 148);
            this.nudSampleRate.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nudSampleRate.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            131072});
            this.nudSampleRate.Name = "nudSampleRate";
            this.nudSampleRate.ReadOnly = true;
            this.nudSampleRate.Size = new System.Drawing.Size(120, 20);
            this.nudSampleRate.TabIndex = 10;
            this.nudSampleRate.Value = new decimal(new int[] {
            3,
            0,
            0,
            65536});
            this.nudSampleRate.ValueChanged += new System.EventHandler(this.nudSampleRate_ValueChanged);
            // 
            // lblX
            // 
            this.lblX.AutoSize = true;
            this.lblX.Location = new System.Drawing.Point(13, 14);
            this.lblX.Name = "lblX";
            this.lblX.Size = new System.Drawing.Size(35, 13);
            this.lblX.TabIndex = 11;
            this.lblX.Text = "label2";
            // 
            // lblY
            // 
            this.lblY.AutoSize = true;
            this.lblY.Location = new System.Drawing.Point(13, 41);
            this.lblY.Name = "lblY";
            this.lblY.Size = new System.Drawing.Size(35, 13);
            this.lblY.TabIndex = 12;
            this.lblY.Text = "label3";
            // 
            // btnCenter
            // 
            this.btnCenter.Location = new System.Drawing.Point(897, 320);
            this.btnCenter.Name = "btnCenter";
            this.btnCenter.Size = new System.Drawing.Size(75, 23);
            this.btnCenter.TabIndex = 13;
            this.btnCenter.Text = "Center";
            this.btnCenter.UseVisualStyleBackColor = true;
            this.btnCenter.Click += new System.EventHandler(this.btnCenter_Click);
            // 
            // btnColor3
            // 
            this.btnColor3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnColor3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnColor3.Location = new System.Drawing.Point(813, 63);
            this.btnColor3.Name = "btnColor3";
            this.btnColor3.Size = new System.Drawing.Size(20, 20);
            this.btnColor3.TabIndex = 16;
            this.btnColor3.Tag = "2";
            this.btnColor3.UseVisualStyleBackColor = true;
            this.btnColor3.Click += new System.EventHandler(this.colorSelect);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(839, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Y3=";
            // 
            // tbInput3
            // 
            this.tbInput3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbInput3.Location = new System.Drawing.Point(872, 64);
            this.tbInput3.Name = "tbInput3";
            this.tbInput3.Size = new System.Drawing.Size(100, 20);
            this.tbInput3.TabIndex = 14;
            // 
            // nudRange
            // 
            this.nudRange.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nudRange.Location = new System.Drawing.Point(852, 815);
            this.nudRange.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudRange.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nudRange.Name = "nudRange";
            this.nudRange.ReadOnly = true;
            this.nudRange.Size = new System.Drawing.Size(120, 20);
            this.nudRange.TabIndex = 17;
            this.nudRange.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.nudRange.ValueChanged += new System.EventHandler(this.nudRange_ValueChanged);
            // 
            // cbRangeAuto
            // 
            this.cbRangeAuto.AutoSize = true;
            this.cbRangeAuto.Location = new System.Drawing.Point(897, 792);
            this.cbRangeAuto.Name = "cbRangeAuto";
            this.cbRangeAuto.Size = new System.Drawing.Size(47, 17);
            this.cbRangeAuto.TabIndex = 18;
            this.cbRangeAuto.Text = "auto";
            this.cbRangeAuto.UseVisualStyleBackColor = true;
            this.cbRangeAuto.CheckedChanged += new System.EventHandler(this.autoRange);
            // 
            // Form1
            // 
            this.AcceptButton = this.btnGraph;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(984, 961);
            this.Controls.Add(this.cbRangeAuto);
            this.Controls.Add(this.nudRange);
            this.Controls.Add(this.btnColor3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbInput3);
            this.Controls.Add(this.btnCenter);
            this.Controls.Add(this.lblY);
            this.Controls.Add(this.lblX);
            this.Controls.Add(this.nudSampleRate);
            this.Controls.Add(this.nudThickness);
            this.Controls.Add(this.cbShowGrid);
            this.Controls.Add(this.nudGridSize);
            this.Controls.Add(this.btnColor2);
            this.Controls.Add(this.btnColor1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbInput2);
            this.Controls.Add(this.lblY1);
            this.Controls.Add(this.btnGraph);
            this.Controls.Add(this.tbInput1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.PaintUpdate);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseUp);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.nudGridSize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudThickness)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSampleRate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudRange)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbInput1;
        private System.Windows.Forms.Button btnGraph;
        private System.Windows.Forms.Label lblY1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbInput2;
        private System.Windows.Forms.Button btnColor1;
        private System.Windows.Forms.Button btnColor2;
        private System.Windows.Forms.NumericUpDown nudGridSize;
        private System.Windows.Forms.CheckBox cbShowGrid;
        private System.Windows.Forms.NumericUpDown nudThickness;
        private System.Windows.Forms.NumericUpDown nudSampleRate;
        private System.Windows.Forms.Label lblX;
        private System.Windows.Forms.Label lblY;
        private System.Windows.Forms.Button btnCenter;
        private System.Windows.Forms.Button btnColor3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbInput3;
        private System.Windows.Forms.NumericUpDown nudRange;
        private System.Windows.Forms.CheckBox cbRangeAuto;
    }
}

