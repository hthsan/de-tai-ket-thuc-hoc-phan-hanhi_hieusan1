namespace game
{
    partial class FormMain
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
            this.btthongtin = new System.Windows.Forms.Button();
            this.btthoat = new System.Windows.Forms.Button();
            this.Btbatdau = new System.Windows.Forms.Button();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lb = new DevComponents.DotNetBar.Controls.ReflectionLabel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btthongtin
            // 
            this.btthongtin.Location = new System.Drawing.Point(104, 151);
            this.btthongtin.Name = "btthongtin";
            this.btthongtin.Size = new System.Drawing.Size(90, 33);
            this.btthongtin.TabIndex = 2;
            this.btthongtin.Text = "Thông tin";
            this.btthongtin.UseVisualStyleBackColor = true;
            this.btthongtin.Click += new System.EventHandler(this.btthongtin_Click);
            // 
            // btthoat
            // 
            this.btthoat.Location = new System.Drawing.Point(104, 199);
            this.btthoat.Name = "btthoat";
            this.btthoat.Size = new System.Drawing.Size(90, 33);
            this.btthoat.TabIndex = 3;
            this.btthoat.Text = "Thoát";
            this.btthoat.UseVisualStyleBackColor = true;
            this.btthoat.Click += new System.EventHandler(this.btthoat_Click);
            // 
            // Btbatdau
            // 
            this.Btbatdau.Location = new System.Drawing.Point(104, 99);
            this.Btbatdau.Name = "Btbatdau";
            this.Btbatdau.Size = new System.Drawing.Size(90, 33);
            this.Btbatdau.TabIndex = 0;
            this.Btbatdau.Text = "Bắt đầu";
            this.Btbatdau.UseVisualStyleBackColor = true;
            this.Btbatdau.Click += new System.EventHandler(this.Btbatdau_Click);
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Interval = 10;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lb
            // 
            this.lb.BackColor = System.Drawing.Color.Transparent;
            this.lb.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb.ForeColor = System.Drawing.Color.MediumBlue;
            this.lb.Location = new System.Drawing.Point(57, 8);
            this.lb.Name = "lb";
            this.lb.Size = new System.Drawing.Size(174, 73);
            this.lb.TabIndex = 6;
            this.lb.Text = "Dẫn bóng";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.lb);
            this.panel2.Location = new System.Drawing.Point(12, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(288, 81);
            this.panel2.TabIndex = 7;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Bai_Tap_Nhom_8.Properties.Resources.new_00;
            this.ClientSize = new System.Drawing.Size(312, 278);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btthongtin);
            this.Controls.Add(this.Btbatdau);
            this.Controls.Add(this.btthoat);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Game Mini";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btthongtin;
        private System.Windows.Forms.Button btthoat;
        private System.Windows.Forms.Button Btbatdau;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Timer timer1;
        private DevComponents.DotNetBar.Controls.ReflectionLabel lb;
        private System.Windows.Forms.Panel panel2;

    }
}

