namespace Demo_2
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
            this.btnMain = new System.Windows.Forms.Button();
            this.lblIn = new System.Windows.Forms.Label();
            this.txtIn = new System.Windows.Forms.TextBox();
            this.txtOut = new System.Windows.Forms.TextBox();
            this.lblOut = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutDemo2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnMain
            // 
            this.btnMain.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnMain.Location = new System.Drawing.Point(125, 127);
            this.btnMain.Name = "btnMain";
            this.btnMain.Size = new System.Drawing.Size(75, 23);
            this.btnMain.TabIndex = 3;
            this.btnMain.Text = "Copy";
            this.btnMain.UseVisualStyleBackColor = true;
            this.btnMain.Click += new System.EventHandler(this.btnMain_Click);
            // 
            // lblIn
            // 
            this.lblIn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblIn.AutoSize = true;
            this.lblIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIn.Location = new System.Drawing.Point(62, 45);
            this.lblIn.Name = "lblIn";
            this.lblIn.Size = new System.Drawing.Size(36, 13);
            this.lblIn.TabIndex = 1;
            this.lblIn.Text = "Input";
            // 
            // txtIn
            // 
            this.txtIn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtIn.Location = new System.Drawing.Point(100, 41);
            this.txtIn.Name = "txtIn";
            this.txtIn.Size = new System.Drawing.Size(144, 20);
            this.txtIn.TabIndex = 1;
            this.txtIn.TextChanged += new System.EventHandler(this.txtIn_TextChanged);
            // 
            // txtOut
            // 
            this.txtOut.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtOut.Location = new System.Drawing.Point(100, 67);
            this.txtOut.Name = "txtOut";
            this.txtOut.Size = new System.Drawing.Size(144, 20);
            this.txtOut.TabIndex = 2;
            // 
            // lblOut
            // 
            this.lblOut.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblOut.AutoSize = true;
            this.lblOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOut.Location = new System.Drawing.Point(55, 70);
            this.lblOut.Name = "lblOut";
            this.lblOut.Size = new System.Drawing.Size(45, 13);
            this.lblOut.TabIndex = 3;
            this.lblOut.Text = "Output";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(307, 24);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutDemo2ToolStripMenuItem});
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // aboutDemo2ToolStripMenuItem
            // 
            this.aboutDemo2ToolStripMenuItem.Name = "aboutDemo2ToolStripMenuItem";
            this.aboutDemo2ToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.aboutDemo2ToolStripMenuItem.Text = "About Demo 2";
            this.aboutDemo2ToolStripMenuItem.Click += new System.EventHandler(this.aboutDemo2ToolStripMenuItem_Click);
            // 
            // frmMain
            // 
            this.AcceptButton = this.btnMain;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(307, 162);
            this.Controls.Add(this.txtOut);
            this.Controls.Add(this.lblOut);
            this.Controls.Add(this.txtIn);
            this.Controls.Add(this.lblIn);
            this.Controls.Add(this.btnMain);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMain";
            this.Text = "Demo 2";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnMain;
        private System.Windows.Forms.Label lblIn;
        private System.Windows.Forms.TextBox txtIn;
        private System.Windows.Forms.TextBox txtOut;
        private System.Windows.Forms.Label lblOut;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutDemo2ToolStripMenuItem;
    }
}

