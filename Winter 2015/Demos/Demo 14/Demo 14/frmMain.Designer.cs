namespace Demo_14
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
            this.components = new System.ComponentModel.Container();
            this.nudMax = new System.Windows.Forms.NumericUpDown();
            this.lblMax = new System.Windows.Forms.Label();
            this.lbTriples = new System.Windows.Forms.ListBox();
            this.lblValues = new System.Windows.Forms.Label();
            this.pbProgess = new System.Windows.Forms.ProgressBar();
            this.btnStart = new System.Windows.Forms.Button();
            this.tmrTimer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.nudMax)).BeginInit();
            this.SuspendLayout();
            // 
            // nudMax
            // 
            this.nudMax.Increment = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.nudMax.Location = new System.Drawing.Point(13, 35);
            this.nudMax.Maximum = new decimal(new int[] {
            -294967296,
            0,
            0,
            0});
            this.nudMax.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudMax.Name = "nudMax";
            this.nudMax.Size = new System.Drawing.Size(120, 20);
            this.nudMax.TabIndex = 0;
            this.nudMax.Value = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            // 
            // lblMax
            // 
            this.lblMax.AutoSize = true;
            this.lblMax.Location = new System.Drawing.Point(13, 13);
            this.lblMax.Name = "lblMax";
            this.lblMax.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblMax.Size = new System.Drawing.Size(111, 13);
            this.lblMax.TabIndex = 1;
            this.lblMax.Text = "Maximum Hypotenuse";
            // 
            // lbTriples
            // 
            this.lbTriples.FormattingEnabled = true;
            this.lbTriples.Location = new System.Drawing.Point(139, 37);
            this.lbTriples.Name = "lbTriples";
            this.lbTriples.Size = new System.Drawing.Size(281, 160);
            this.lbTriples.TabIndex = 2;
            // 
            // lblValues
            // 
            this.lblValues.AutoSize = true;
            this.lblValues.Location = new System.Drawing.Point(139, 13);
            this.lblValues.Name = "lblValues";
            this.lblValues.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblValues.Size = new System.Drawing.Size(101, 13);
            this.lblValues.TabIndex = 3;
            this.lblValues.Text = "Pythagorean Triples";
            // 
            // pbProgess
            // 
            this.pbProgess.Location = new System.Drawing.Point(13, 211);
            this.pbProgess.Name = "pbProgess";
            this.pbProgess.Size = new System.Drawing.Size(407, 23);
            this.pbProgess.TabIndex = 4;
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(13, 62);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(108, 135);
            this.btnStart.TabIndex = 5;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // tmrTimer
            // 
            this.tmrTimer.Enabled = true;
            this.tmrTimer.Tick += new System.EventHandler(this.tmrTimer_Tick);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(432, 246);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.pbProgess);
            this.Controls.Add(this.lblValues);
            this.Controls.Add(this.lbTriples);
            this.Controls.Add(this.lblMax);
            this.Controls.Add(this.nudMax);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "frmMain";
            this.Text = "Pythagorean Triples";
            this.Load += new System.EventHandler(this.frmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudMax)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown nudMax;
        private System.Windows.Forms.Label lblMax;
        private System.Windows.Forms.ListBox lbTriples;
        private System.Windows.Forms.Label lblValues;
        private System.Windows.Forms.ProgressBar pbProgess;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Timer tmrTimer;
    }
}

