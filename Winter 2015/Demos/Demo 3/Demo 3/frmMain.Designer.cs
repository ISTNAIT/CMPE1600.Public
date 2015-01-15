namespace Demo_3
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
            this.tbrValue = new System.Windows.Forms.TrackBar();
            this.tbxValue = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.tbrValue)).BeginInit();
            this.SuspendLayout();
            // 
            // tbrValue
            // 
            this.tbrValue.Location = new System.Drawing.Point(12, 60);
            this.tbrValue.Maximum = 110;
            this.tbrValue.Minimum = 10;
            this.tbrValue.Name = "tbrValue";
            this.tbrValue.Size = new System.Drawing.Size(230, 45);
            this.tbrValue.TabIndex = 0;
            this.tbrValue.TickFrequency = 5;
            this.tbrValue.TickStyle = System.Windows.Forms.TickStyle.TopLeft;
            this.tbrValue.Value = 55;
            this.tbrValue.Scroll += new System.EventHandler(this.tbrValue_Scroll);
            // 
            // tbxValue
            // 
            this.tbxValue.Location = new System.Drawing.Point(70, 12);
            this.tbxValue.Name = "tbxValue";
            this.tbxValue.Size = new System.Drawing.Size(100, 20);
            this.tbxValue.TabIndex = 1;
            this.tbxValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbxValue.Leave += new System.EventHandler(this.tbxValue_Leave);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(254, 110);
            this.Controls.Add(this.tbxValue);
            this.Controls.Add(this.tbrValue);
            this.Name = "frmMain";
            this.Text = "Demo 3";
            this.Load += new System.EventHandler(this.frmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tbrValue)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TrackBar tbrValue;
        private System.Windows.Forms.TextBox tbxValue;
    }
}

