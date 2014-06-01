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
            this.gbStooge = new System.Windows.Forms.GroupBox();
            this.rbCurlyJoe = new System.Windows.Forms.RadioButton();
            this.rbCurly = new System.Windows.Forms.RadioButton();
            this.rbMoe = new System.Windows.Forms.RadioButton();
            this.rbLarry = new System.Windows.Forms.RadioButton();
            this.btnSelect = new System.Windows.Forms.Button();
            this.cbConfirm = new System.Windows.Forms.CheckBox();
            this.gbStooge.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbStooge
            // 
            this.gbStooge.Controls.Add(this.rbCurlyJoe);
            this.gbStooge.Controls.Add(this.rbCurly);
            this.gbStooge.Controls.Add(this.rbMoe);
            this.gbStooge.Controls.Add(this.rbLarry);
            this.gbStooge.Location = new System.Drawing.Point(12, 12);
            this.gbStooge.Name = "gbStooge";
            this.gbStooge.Size = new System.Drawing.Size(133, 117);
            this.gbStooge.TabIndex = 0;
            this.gbStooge.TabStop = false;
            this.gbStooge.Text = "Favorite Stooge";
            // 
            // rbCurlyJoe
            // 
            this.rbCurlyJoe.AutoSize = true;
            this.rbCurlyJoe.Location = new System.Drawing.Point(22, 88);
            this.rbCurlyJoe.Name = "rbCurlyJoe";
            this.rbCurlyJoe.Size = new System.Drawing.Size(68, 17);
            this.rbCurlyJoe.TabIndex = 3;
            this.rbCurlyJoe.Text = "Curly Joe";
            this.rbCurlyJoe.UseVisualStyleBackColor = true;
            this.rbCurlyJoe.CheckedChanged += new System.EventHandler(this.rbCurlyJoe_CheckedChanged);
            // 
            // rbCurly
            // 
            this.rbCurly.AutoSize = true;
            this.rbCurly.Location = new System.Drawing.Point(22, 65);
            this.rbCurly.Name = "rbCurly";
            this.rbCurly.Size = new System.Drawing.Size(48, 17);
            this.rbCurly.TabIndex = 2;
            this.rbCurly.Text = "Curly";
            this.rbCurly.UseVisualStyleBackColor = true;
            this.rbCurly.CheckedChanged += new System.EventHandler(this.rbCurly_CheckedChanged);
            // 
            // rbMoe
            // 
            this.rbMoe.AutoSize = true;
            this.rbMoe.Location = new System.Drawing.Point(22, 42);
            this.rbMoe.Name = "rbMoe";
            this.rbMoe.Size = new System.Drawing.Size(46, 17);
            this.rbMoe.TabIndex = 1;
            this.rbMoe.Text = "Moe";
            this.rbMoe.UseVisualStyleBackColor = true;
            this.rbMoe.CheckedChanged += new System.EventHandler(this.rbMoe_CheckedChanged);
            // 
            // rbLarry
            // 
            this.rbLarry.AutoSize = true;
            this.rbLarry.Checked = true;
            this.rbLarry.Location = new System.Drawing.Point(22, 19);
            this.rbLarry.Name = "rbLarry";
            this.rbLarry.Size = new System.Drawing.Size(48, 17);
            this.rbLarry.TabIndex = 0;
            this.rbLarry.TabStop = true;
            this.rbLarry.Text = "Larry";
            this.rbLarry.UseVisualStyleBackColor = true;
            this.rbLarry.CheckedChanged += new System.EventHandler(this.rbLarry_CheckedChanged);
            // 
            // btnSelect
            // 
            this.btnSelect.Location = new System.Drawing.Point(212, 71);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(75, 23);
            this.btnSelect.TabIndex = 1;
            this.btnSelect.Text = "Select";
            this.btnSelect.UseVisualStyleBackColor = true;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // cbConfirm
            // 
            this.cbConfirm.AutoSize = true;
            this.cbConfirm.Checked = true;
            this.cbConfirm.CheckState = System.Windows.Forms.CheckState.Indeterminate;
            this.cbConfirm.Location = new System.Drawing.Point(196, 31);
            this.cbConfirm.Name = "cbConfirm";
            this.cbConfirm.Size = new System.Drawing.Size(108, 17);
            this.cbConfirm.TabIndex = 2;
            this.cbConfirm.Text = "Confirm Selection";
            this.cbConfirm.ThreeState = true;
            this.cbConfirm.UseVisualStyleBackColor = true;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(317, 140);
            this.Controls.Add(this.cbConfirm);
            this.Controls.Add(this.btnSelect);
            this.Controls.Add(this.gbStooge);
            this.Name = "frmMain";
            this.Text = "Stooges";
            this.gbStooge.ResumeLayout(false);
            this.gbStooge.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbStooge;
        private System.Windows.Forms.RadioButton rbCurlyJoe;
        private System.Windows.Forms.RadioButton rbCurly;
        private System.Windows.Forms.RadioButton rbMoe;
        private System.Windows.Forms.RadioButton rbLarry;
        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.CheckBox cbConfirm;
    }
}

