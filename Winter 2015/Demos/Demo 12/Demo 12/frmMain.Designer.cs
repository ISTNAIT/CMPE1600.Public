namespace Demo_12
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
            this.ckDialog = new System.Windows.Forms.CheckBox();
            this.lblFromDialog = new System.Windows.Forms.Label();
            this.tbTitle = new System.Windows.Forms.TextBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ckDialog
            // 
            this.ckDialog.AutoSize = true;
            this.ckDialog.Location = new System.Drawing.Point(12, 12);
            this.ckDialog.Name = "ckDialog";
            this.ckDialog.Size = new System.Drawing.Size(86, 17);
            this.ckDialog.TabIndex = 0;
            this.ckDialog.Text = "Show Dialog";
            this.ckDialog.UseVisualStyleBackColor = true;
            this.ckDialog.CheckedChanged += new System.EventHandler(this.ckDialog_CheckedChanged);
            // 
            // lblFromDialog
            // 
            this.lblFromDialog.AutoSize = true;
            this.lblFromDialog.Location = new System.Drawing.Point(9, 46);
            this.lblFromDialog.Name = "lblFromDialog";
            this.lblFromDialog.Size = new System.Drawing.Size(140, 13);
            this.lblFromDialog.TabIndex = 1;
            this.lblFromDialog.Text = "Use Dialog to Edit this Label";
            // 
            // tbTitle
            // 
            this.tbTitle.Location = new System.Drawing.Point(186, 13);
            this.tbTitle.Name = "tbTitle";
            this.tbTitle.Size = new System.Drawing.Size(134, 20);
            this.tbTitle.TabIndex = 2;
            this.tbTitle.TextChanged += new System.EventHandler(this.tbTitle_TextChanged);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(128, 16);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(52, 13);
            this.lblTitle.TabIndex = 3;
            this.lblTitle.Text = "Dlg. Title:";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(332, 72);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.tbTitle);
            this.Controls.Add(this.lblFromDialog);
            this.Controls.Add(this.ckDialog);
            this.Name = "frmMain";
            this.Text = "Demo 12";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox ckDialog;
        private System.Windows.Forms.Label lblFromDialog;
        private System.Windows.Forms.TextBox tbTitle;
        private System.Windows.Forms.Label lblTitle;
    }
}

