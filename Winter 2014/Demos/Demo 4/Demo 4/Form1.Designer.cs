namespace Demo_4
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
            this.tmrEvents = new System.Windows.Forms.Timer(this.components);
            this.tbEventSecs = new System.Windows.Forms.TrackBar();
            this.lbStooges = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.tbEventSecs)).BeginInit();
            this.SuspendLayout();
            // 
            // tmrEvents
            // 
            this.tmrEvents.Enabled = true;
            this.tmrEvents.Interval = 1000;
            this.tmrEvents.Tick += new System.EventHandler(this.tmrEvents_Tick);
            // 
            // tbEventSecs
            // 
            this.tbEventSecs.AllowDrop = true;
            this.tbEventSecs.LargeChange = 2;
            this.tbEventSecs.Location = new System.Drawing.Point(12, 3);
            this.tbEventSecs.Maximum = 5;
            this.tbEventSecs.Minimum = 1;
            this.tbEventSecs.Name = "tbEventSecs";
            this.tbEventSecs.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.tbEventSecs.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tbEventSecs.RightToLeftLayout = true;
            this.tbEventSecs.Size = new System.Drawing.Size(45, 247);
            this.tbEventSecs.TabIndex = 0;
            this.tbEventSecs.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.tbEventSecs.Value = 1;
            this.tbEventSecs.Scroll += new System.EventHandler(this.tbEventSecs_Scroll);
            // 
            // lbStooges
            // 
            this.lbStooges.FormattingEnabled = true;
            this.lbStooges.Items.AddRange(new object[] {
            "Larry",
            "Moe",
            "Curly",
            "Curly Joe",
            "Harpo",
            "Groucho",
            "Zeppo",
            "Laurel",
            "Hardy",
            "Bud ",
            "Lou"});
            this.lbStooges.Location = new System.Drawing.Point(73, 12);
            this.lbStooges.Name = "lbStooges";
            this.lbStooges.Size = new System.Drawing.Size(326, 225);
            this.lbStooges.TabIndex = 1;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(411, 262);
            this.Controls.Add(this.lbStooges);
            this.Controls.Add(this.tbEventSecs);
            this.Name = "frmMain";
            this.Text = "Fun with Sliders, Textboxen and Timers!";
            this.Load += new System.EventHandler(this.frmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tbEventSecs)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer tmrEvents;
        private System.Windows.Forms.TrackBar tbEventSecs;
        private System.Windows.Forms.ListBox lbStooges;
    }
}

