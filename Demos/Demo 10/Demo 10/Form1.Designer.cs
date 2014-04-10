namespace Demo_10
{
    partial class frmMain
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
            this.lbPrimes = new System.Windows.Forms.ListBox();
            this.nudMin = new System.Windows.Forms.NumericUpDown();
            this.nudMax = new System.Windows.Forms.NumericUpDown();
            this.nudInterval = new System.Windows.Forms.NumericUpDown();
            this.lblMin = new System.Windows.Forms.Label();
            this.lblMax = new System.Windows.Forms.Label();
            this.lblInterval = new System.Windows.Forms.Label();
            this.lblCount = new System.Windows.Forms.Label();
            this.btnAction = new System.Windows.Forms.Button();
            this.nudCount = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.nudMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudInterval)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCount)).BeginInit();
            this.SuspendLayout();
            // 
            // lbPrimes
            // 
            this.lbPrimes.FormattingEnabled = true;
            this.lbPrimes.Location = new System.Drawing.Point(16, 102);
            this.lbPrimes.Name = "lbPrimes";
            this.lbPrimes.Size = new System.Drawing.Size(220, 277);
            this.lbPrimes.Sorted = true;
            this.lbPrimes.TabIndex = 0;
            // 
            // nudMin
            // 
            this.nudMin.Location = new System.Drawing.Point(116, 12);
            this.nudMin.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.nudMin.Name = "nudMin";
            this.nudMin.Size = new System.Drawing.Size(120, 20);
            this.nudMin.TabIndex = 1;
            this.nudMin.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nudMin.ThousandsSeparator = true;
            this.nudMin.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // nudMax
            // 
            this.nudMax.Location = new System.Drawing.Point(116, 39);
            this.nudMax.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.nudMax.Name = "nudMax";
            this.nudMax.Size = new System.Drawing.Size(120, 20);
            this.nudMax.TabIndex = 2;
            this.nudMax.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nudMax.ThousandsSeparator = true;
            this.nudMax.Value = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            // 
            // nudInterval
            // 
            this.nudInterval.Location = new System.Drawing.Point(116, 66);
            this.nudInterval.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.nudInterval.Name = "nudInterval";
            this.nudInterval.Size = new System.Drawing.Size(120, 20);
            this.nudInterval.TabIndex = 3;
            this.nudInterval.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nudInterval.ThousandsSeparator = true;
            this.nudInterval.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            // 
            // lblMin
            // 
            this.lblMin.AutoSize = true;
            this.lblMin.Location = new System.Drawing.Point(29, 18);
            this.lblMin.Name = "lblMin";
            this.lblMin.Size = new System.Drawing.Size(78, 13);
            this.lblMin.TabIndex = 4;
            this.lblMin.Text = "Minimum Value";
            // 
            // lblMax
            // 
            this.lblMax.AutoSize = true;
            this.lblMax.Location = new System.Drawing.Point(26, 45);
            this.lblMax.Name = "lblMax";
            this.lblMax.Size = new System.Drawing.Size(81, 13);
            this.lblMax.TabIndex = 5;
            this.lblMax.Text = "Maximum Value";
            // 
            // lblInterval
            // 
            this.lblInterval.AutoSize = true;
            this.lblInterval.Location = new System.Drawing.Point(14, 72);
            this.lblInterval.Name = "lblInterval";
            this.lblInterval.Size = new System.Drawing.Size(94, 13);
            this.lblInterval.TabIndex = 6;
            this.lblInterval.Text = "Values per Thread";
            // 
            // lblCount
            // 
            this.lblCount.AutoEllipsis = true;
            this.lblCount.AutoSize = true;
            this.lblCount.Location = new System.Drawing.Point(17, 390);
            this.lblCount.Name = "lblCount";
            this.lblCount.Size = new System.Drawing.Size(90, 13);
            this.lblCount.TabIndex = 7;
            this.lblCount.Text = "Number of Primes";
            // 
            // btnAction
            // 
            this.btnAction.Location = new System.Drawing.Point(101, 429);
            this.btnAction.Name = "btnAction";
            this.btnAction.Size = new System.Drawing.Size(75, 23);
            this.btnAction.TabIndex = 9;
            this.btnAction.Text = "Start";
            this.btnAction.UseVisualStyleBackColor = true;
            this.btnAction.Click += new System.EventHandler(this.btnAction_Click);
            // 
            // nudCount
            // 
            this.nudCount.Increment = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.nudCount.Location = new System.Drawing.Point(113, 388);
            this.nudCount.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.nudCount.Name = "nudCount";
            this.nudCount.Size = new System.Drawing.Size(120, 20);
            this.nudCount.TabIndex = 10;
            this.nudCount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nudCount.ThousandsSeparator = true;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(268, 464);
            this.Controls.Add(this.nudCount);
            this.Controls.Add(this.btnAction);
            this.Controls.Add(this.lblCount);
            this.Controls.Add(this.lblInterval);
            this.Controls.Add(this.lblMax);
            this.Controls.Add(this.lblMin);
            this.Controls.Add(this.nudInterval);
            this.Controls.Add(this.nudMax);
            this.Controls.Add(this.nudMin);
            this.Controls.Add(this.lbPrimes);
            this.Name = "frmMain";
            this.Text = "Find the Primes";
            ((System.ComponentModel.ISupportInitialize)(this.nudMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudInterval)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbPrimes;
        private System.Windows.Forms.NumericUpDown nudMin;
        private System.Windows.Forms.NumericUpDown nudMax;
        private System.Windows.Forms.NumericUpDown nudInterval;
        private System.Windows.Forms.Label lblMin;
        private System.Windows.Forms.Label lblMax;
        private System.Windows.Forms.Label lblInterval;
        private System.Windows.Forms.Label lblCount;
        private System.Windows.Forms.Button btnAction;
        private System.Windows.Forms.NumericUpDown nudCount;
    }
}

