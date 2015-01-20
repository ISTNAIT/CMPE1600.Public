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
            this.gbRadio = new System.Windows.Forms.GroupBox();
            this.rbApples = new System.Windows.Forms.RadioButton();
            this.rbOranges = new System.Windows.Forms.RadioButton();
            this.rbMangos = new System.Windows.Forms.RadioButton();
            this.rbGrapes = new System.Windows.Forms.RadioButton();
            this.btnGo = new System.Windows.Forms.Button();
            this.rbPineapples = new System.Windows.Forms.RadioButton();
            this.cbEnableApples = new System.Windows.Forms.CheckBox();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.timerEnd = new System.Windows.Forms.Timer(this.components);
            this.gbRadio.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbRadio
            // 
            this.gbRadio.Controls.Add(this.rbPineapples);
            this.gbRadio.Controls.Add(this.rbMangos);
            this.gbRadio.Controls.Add(this.rbGrapes);
            this.gbRadio.Controls.Add(this.rbOranges);
            this.gbRadio.Controls.Add(this.rbApples);
            this.gbRadio.Location = new System.Drawing.Point(12, 12);
            this.gbRadio.Name = "gbRadio";
            this.gbRadio.Size = new System.Drawing.Size(104, 153);
            this.gbRadio.TabIndex = 0;
            this.gbRadio.TabStop = false;
            this.gbRadio.Text = "Favorite Fruit";
            // 
            // rbApples
            // 
            this.rbApples.AutoSize = true;
            this.rbApples.Location = new System.Drawing.Point(6, 19);
            this.rbApples.Name = "rbApples";
            this.rbApples.Size = new System.Drawing.Size(57, 17);
            this.rbApples.TabIndex = 0;
            this.rbApples.Text = "Apples";
            this.rbApples.UseVisualStyleBackColor = true;
            this.rbApples.CheckedChanged += new System.EventHandler(this.rbApples_CheckedChanged);
            // 
            // rbOranges
            // 
            this.rbOranges.AutoSize = true;
            this.rbOranges.Location = new System.Drawing.Point(6, 42);
            this.rbOranges.Name = "rbOranges";
            this.rbOranges.Size = new System.Drawing.Size(65, 17);
            this.rbOranges.TabIndex = 1;
            this.rbOranges.Text = "Oranges";
            this.rbOranges.UseVisualStyleBackColor = true;
            // 
            // rbMangos
            // 
            this.rbMangos.AutoSize = true;
            this.rbMangos.Location = new System.Drawing.Point(6, 88);
            this.rbMangos.Name = "rbMangos";
            this.rbMangos.Size = new System.Drawing.Size(63, 17);
            this.rbMangos.TabIndex = 3;
            this.rbMangos.Text = "Mangos";
            this.rbMangos.UseVisualStyleBackColor = true;
            // 
            // rbGrapes
            // 
            this.rbGrapes.AutoSize = true;
            this.rbGrapes.Location = new System.Drawing.Point(6, 65);
            this.rbGrapes.Name = "rbGrapes";
            this.rbGrapes.Size = new System.Drawing.Size(59, 17);
            this.rbGrapes.TabIndex = 2;
            this.rbGrapes.Text = "Grapes";
            this.rbGrapes.UseVisualStyleBackColor = true;
            // 
            // btnGo
            // 
            this.btnGo.Location = new System.Drawing.Point(18, 180);
            this.btnGo.Name = "btnGo";
            this.btnGo.Size = new System.Drawing.Size(75, 23);
            this.btnGo.TabIndex = 1;
            this.btnGo.Text = "Go";
            this.btnGo.UseVisualStyleBackColor = true;
            this.btnGo.Click += new System.EventHandler(this.btnGo_Click);
            // 
            // rbPineapples
            // 
            this.rbPineapples.AutoSize = true;
            this.rbPineapples.Location = new System.Drawing.Point(8, 111);
            this.rbPineapples.Name = "rbPineapples";
            this.rbPineapples.Size = new System.Drawing.Size(77, 17);
            this.rbPineapples.TabIndex = 4;
            this.rbPineapples.Text = "Pineapples";
            this.rbPineapples.UseVisualStyleBackColor = true;
            // 
            // cbEnableApples
            // 
            this.cbEnableApples.AutoSize = true;
            this.cbEnableApples.Location = new System.Drawing.Point(154, 12);
            this.cbEnableApples.Name = "cbEnableApples";
            this.cbEnableApples.Size = new System.Drawing.Size(94, 17);
            this.cbEnableApples.TabIndex = 2;
            this.cbEnableApples.Text = "Enable Apples";
            this.cbEnableApples.UseVisualStyleBackColor = true;
            this.cbEnableApples.CheckedChanged += new System.EventHandler(this.cbEnableApples_CheckedChanged);
            // 
            // timer
            // 
            this.timer.Interval = 500;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // timerEnd
            // 
            this.timerEnd.Interval = 5000;
            this.timerEnd.Tick += new System.EventHandler(this.timerEnd_Tick);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(429, 303);
            this.Controls.Add(this.cbEnableApples);
            this.Controls.Add(this.btnGo);
            this.Controls.Add(this.gbRadio);
            this.Name = "frmMain";
            this.Text = "Demo 4";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.gbRadio.ResumeLayout(false);
            this.gbRadio.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbRadio;
        private System.Windows.Forms.RadioButton rbMangos;
        private System.Windows.Forms.RadioButton rbGrapes;
        private System.Windows.Forms.RadioButton rbOranges;
        private System.Windows.Forms.RadioButton rbApples;
        private System.Windows.Forms.Button btnGo;
        private System.Windows.Forms.RadioButton rbPineapples;
        private System.Windows.Forms.CheckBox cbEnableApples;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Timer timerEnd;
    }
}

