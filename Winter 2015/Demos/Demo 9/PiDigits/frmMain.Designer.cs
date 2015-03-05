namespace Demo_9
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
            this.btnGo = new System.Windows.Forms.Button();
            this.lblUpTo = new System.Windows.Forms.Label();
            this.nudTo = new System.Windows.Forms.NumericUpDown();
            this.pbProgress = new System.Windows.Forms.ProgressBar();
            this.nudFrom = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.lbResults = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.nudTo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudFrom)).BeginInit();
            this.SuspendLayout();
            // 
            // btnGo
            // 
            this.btnGo.Location = new System.Drawing.Point(117, 312);
            this.btnGo.Name = "btnGo";
            this.btnGo.Size = new System.Drawing.Size(75, 23);
            this.btnGo.TabIndex = 0;
            this.btnGo.Text = "Go";
            this.btnGo.UseVisualStyleBackColor = true;
            this.btnGo.Click += new System.EventHandler(this.btnGo_Click);
            // 
            // lblUpTo
            // 
            this.lblUpTo.AutoSize = true;
            this.lblUpTo.Location = new System.Drawing.Point(18, 45);
            this.lblUpTo.Name = "lblUpTo";
            this.lblUpTo.Size = new System.Drawing.Size(23, 13);
            this.lblUpTo.TabIndex = 3;
            this.lblUpTo.Text = "To:";
            // 
            // nudTo
            // 
            this.nudTo.Increment = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudTo.Location = new System.Drawing.Point(48, 43);
            this.nudTo.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.nudTo.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.nudTo.Name = "nudTo";
            this.nudTo.Size = new System.Drawing.Size(256, 20);
            this.nudTo.TabIndex = 4;
            this.nudTo.ThousandsSeparator = true;
            this.nudTo.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // pbProgress
            // 
            this.pbProgress.Location = new System.Drawing.Point(16, 276);
            this.pbProgress.Name = "pbProgress";
            this.pbProgress.Size = new System.Drawing.Size(288, 23);
            this.pbProgress.TabIndex = 5;
            // 
            // nudFrom
            // 
            this.nudFrom.Increment = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudFrom.Location = new System.Drawing.Point(48, 12);
            this.nudFrom.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.nudFrom.Name = "nudFrom";
            this.nudFrom.Size = new System.Drawing.Size(255, 20);
            this.nudFrom.TabIndex = 6;
            this.nudFrom.ThousandsSeparator = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "From:";
            // 
            // lbResults
            // 
            this.lbResults.FormattingEnabled = true;
            this.lbResults.Location = new System.Drawing.Point(16, 73);
            this.lbResults.Name = "lbResults";
            this.lbResults.Size = new System.Drawing.Size(287, 199);
            this.lbResults.TabIndex = 8;
            // 
            // frmMain
            // 
            this.AcceptButton = this.btnGo;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(315, 347);
            this.Controls.Add(this.lbResults);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nudFrom);
            this.Controls.Add(this.pbProgress);
            this.Controls.Add(this.nudTo);
            this.Controls.Add(this.lblUpTo);
            this.Controls.Add(this.btnGo);
            this.Name = "frmMain";
            this.Text = "Prime Number Generator";
            this.Load += new System.EventHandler(this.frmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudTo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudFrom)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGo;
        private System.Windows.Forms.Label lblUpTo;
        private System.Windows.Forms.NumericUpDown nudTo;
        private System.Windows.Forms.ProgressBar pbProgress;
        private System.Windows.Forms.NumericUpDown nudFrom;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lbResults;
    }
}

