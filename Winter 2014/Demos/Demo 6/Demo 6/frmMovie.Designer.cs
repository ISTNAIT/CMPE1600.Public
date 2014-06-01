namespace Demo_6
{
    partial class frmMovie
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
            this.gbMovie = new System.Windows.Forms.GroupBox();
            this.rbTiffanys = new System.Windows.Forms.RadioButton();
            this.rbBlues = new System.Windows.Forms.RadioButton();
            this.rbSerenity = new System.Windows.Forms.RadioButton();
            this.cbLike = new System.Windows.Forms.CheckBox();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.gbMovie.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbMovie
            // 
            this.gbMovie.Controls.Add(this.rbTiffanys);
            this.gbMovie.Controls.Add(this.rbBlues);
            this.gbMovie.Controls.Add(this.rbSerenity);
            this.gbMovie.Location = new System.Drawing.Point(12, 12);
            this.gbMovie.Name = "gbMovie";
            this.gbMovie.Size = new System.Drawing.Size(164, 103);
            this.gbMovie.TabIndex = 1;
            this.gbMovie.TabStop = false;
            this.gbMovie.Text = "What is your favourite movie?";
            // 
            // rbTiffanys
            // 
            this.rbTiffanys.AutoSize = true;
            this.rbTiffanys.Checked = true;
            this.rbTiffanys.Location = new System.Drawing.Point(6, 74);
            this.rbTiffanys.Name = "rbTiffanys";
            this.rbTiffanys.Size = new System.Drawing.Size(124, 17);
            this.rbTiffanys.TabIndex = 2;
            this.rbTiffanys.TabStop = true;
            this.rbTiffanys.Text = "Breakfast at Tiffany\'s";
            this.rbTiffanys.UseVisualStyleBackColor = true;
            // 
            // rbBlues
            // 
            this.rbBlues.AutoSize = true;
            this.rbBlues.Location = new System.Drawing.Point(6, 51);
            this.rbBlues.Name = "rbBlues";
            this.rbBlues.Size = new System.Drawing.Size(93, 17);
            this.rbBlues.TabIndex = 1;
            this.rbBlues.Text = "Blues Brothers";
            this.rbBlues.UseVisualStyleBackColor = true;
            // 
            // rbSerenity
            // 
            this.rbSerenity.AutoSize = true;
            this.rbSerenity.Location = new System.Drawing.Point(6, 28);
            this.rbSerenity.Name = "rbSerenity";
            this.rbSerenity.Size = new System.Drawing.Size(63, 17);
            this.rbSerenity.TabIndex = 0;
            this.rbSerenity.Text = "Serenity";
            this.rbSerenity.UseVisualStyleBackColor = true;
            // 
            // cbLike
            // 
            this.cbLike.AutoSize = true;
            this.cbLike.Location = new System.Drawing.Point(12, 121);
            this.cbLike.Name = "cbLike";
            this.cbLike.Size = new System.Drawing.Size(84, 17);
            this.cbLike.TabIndex = 2;
            this.cbLike.Text = "I like movies";
            this.cbLike.UseVisualStyleBackColor = true;
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(13, 170);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 3;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(101, 170);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // frmMovie
            // 
            this.AcceptButton = this.btnOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(190, 205);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.cbLike);
            this.Controls.Add(this.gbMovie);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmMovie";
            this.Text = "Movie";
            this.Load += new System.EventHandler(this.frmMovie_Load);
            this.gbMovie.ResumeLayout(false);
            this.gbMovie.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbMovie;
        private System.Windows.Forms.CheckBox cbLike;
        private System.Windows.Forms.RadioButton rbTiffanys;
        private System.Windows.Forms.RadioButton rbBlues;
        private System.Windows.Forms.RadioButton rbSerenity;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancel;
    }
}