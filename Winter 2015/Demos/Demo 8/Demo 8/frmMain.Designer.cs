namespace Demo_8
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
            this.btnStartThread = new System.Windows.Forms.Button();
            this.lblThread = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnStartThread
            // 
            this.btnStartThread.Location = new System.Drawing.Point(12, 12);
            this.btnStartThread.Name = "btnStartThread";
            this.btnStartThread.Size = new System.Drawing.Size(128, 23);
            this.btnStartThread.TabIndex = 0;
            this.btnStartThread.Text = "Start Thread (boom!)";
            this.btnStartThread.UseVisualStyleBackColor = true;
            this.btnStartThread.Click += new System.EventHandler(this.ShowMessage);
            // 
            // lblThread
            // 
            this.lblThread.AutoSize = true;
            this.lblThread.Location = new System.Drawing.Point(147, 17);
            this.lblThread.Name = "lblThread";
            this.lblThread.Size = new System.Drawing.Size(97, 13);
            this.lblThread.TabIndex = 1;
            this.lblThread.Text = "Thread not started.";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(277, 53);
            this.Controls.Add(this.lblThread);
            this.Controls.Add(this.btnStartThread);
            this.Name = "frmMain";
            this.Text = "Demo 8 - Multithreading";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnStartThread;
        private System.Windows.Forms.Label lblThread;
    }
}

