namespace Demo_11
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
            this.btnGetName = new System.Windows.Forms.Button();
            this.pbPenguins = new System.Windows.Forms.PictureBox();
            this.lblName = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbPenguins)).BeginInit();
            this.SuspendLayout();
            // 
            // btnGetName
            // 
            this.btnGetName.Location = new System.Drawing.Point(109, 266);
            this.btnGetName.Name = "btnGetName";
            this.btnGetName.Size = new System.Drawing.Size(147, 23);
            this.btnGetName.TabIndex = 0;
            this.btnGetName.Text = "Name Your Penguin";
            this.btnGetName.UseVisualStyleBackColor = true;
            this.btnGetName.Click += new System.EventHandler(this.btnGetName_Click);
            // 
            // pbPenguins
            // 
            this.pbPenguins.Image = global::Demo_11.Resources.Penguins;
            this.pbPenguins.InitialImage = null;
            this.pbPenguins.Location = new System.Drawing.Point(12, 12);
            this.pbPenguins.Name = "pbPenguins";
            this.pbPenguins.Size = new System.Drawing.Size(352, 225);
            this.pbPenguins.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbPenguins.TabIndex = 1;
            this.pbPenguins.TabStop = false;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(12, 240);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(77, 13);
            this.lblName.TabIndex = 2;
            this.lblName.Text = "Penguin Name";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(376, 301);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.pbPenguins);
            this.Controls.Add(this.btnGetName);
            this.Name = "frmMain";
            this.Text = "Demo 11";
            this.Load += new System.EventHandler(this.frmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbPenguins)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGetName;
        private System.Windows.Forms.PictureBox pbPenguins;
        private System.Windows.Forms.Label lblName;
    }
}

