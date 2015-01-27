namespace Demo_5
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
            this.nudNumber = new System.Windows.Forms.NumericUpDown();
            this.lblNumber = new System.Windows.Forms.Label();
            this.btnGo = new System.Windows.Forms.Button();
            this.lbStooges = new System.Windows.Forms.ListBox();
            this.btnDelete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudNumber)).BeginInit();
            this.SuspendLayout();
            // 
            // nudNumber
            // 
            this.nudNumber.Location = new System.Drawing.Point(77, 13);
            this.nudNumber.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.nudNumber.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            this.nudNumber.Name = "nudNumber";
            this.nudNumber.Size = new System.Drawing.Size(117, 20);
            this.nudNumber.TabIndex = 0;
            this.nudNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nudNumber.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudNumber.ValueChanged += new System.EventHandler(this.nudNumber_ValueChanged);
            // 
            // lblNumber
            // 
            this.lblNumber.AutoSize = true;
            this.lblNumber.Location = new System.Drawing.Point(12, 15);
            this.lblNumber.Name = "lblNumber";
            this.lblNumber.Size = new System.Drawing.Size(44, 13);
            this.lblNumber.TabIndex = 1;
            this.lblNumber.Text = "Number";
            // 
            // btnGo
            // 
            this.btnGo.Location = new System.Drawing.Point(61, 150);
            this.btnGo.Name = "btnGo";
            this.btnGo.Size = new System.Drawing.Size(75, 23);
            this.btnGo.TabIndex = 2;
            this.btnGo.Text = "Go";
            this.btnGo.UseVisualStyleBackColor = true;
            this.btnGo.Click += new System.EventHandler(this.btnGo_Click);
            // 
            // lbStooges
            // 
            this.lbStooges.FormattingEnabled = true;
            this.lbStooges.Location = new System.Drawing.Point(16, 39);
            this.lbStooges.Name = "lbStooges";
            this.lbStooges.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.lbStooges.Size = new System.Drawing.Size(178, 82);
            this.lbStooges.TabIndex = 3;
            this.lbStooges.SelectedIndexChanged += new System.EventHandler(this.lbStooges_SelectedIndexChanged);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(61, 189);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 4;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(212, 252);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.lbStooges);
            this.Controls.Add(this.btnGo);
            this.Controls.Add(this.lblNumber);
            this.Controls.Add(this.nudNumber);
            this.Name = "frmMain";
            this.Text = "Demo 4";
            this.Load += new System.EventHandler(this.frmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudNumber)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown nudNumber;
        private System.Windows.Forms.Label lblNumber;
        private System.Windows.Forms.Button btnGo;
        private System.Windows.Forms.ListBox lbStooges;
        private System.Windows.Forms.Button btnDelete;
    }
}

