namespace Bai_Tap_Nhom_8
{
    partial class Form2
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
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.bongve2 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.bongve = new System.Windows.Forms.PictureBox();
            this.boom = new System.Windows.Forms.PictureBox();
            this.bong1 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.bong = new System.Windows.Forms.PictureBox();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bongve2)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bongve)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.boom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bong1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bong)).BeginInit();
            this.SuspendLayout();
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Interval = 25;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Silver;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.bongve2);
            this.panel2.Location = new System.Drawing.Point(467, 258);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(70, 55);
            this.panel2.TabIndex = 3;
            // 
            // bongve2
            // 
            this.bongve2.BackgroundImage = global::Bai_Tap_Nhom_8.Properties.Resources._3D_68;
            this.bongve2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bongve2.Location = new System.Drawing.Point(1, -51);
            this.bongve2.Name = "bongve2";
            this.bongve2.Size = new System.Drawing.Size(65, 50);
            this.bongve2.TabIndex = 8;
            this.bongve2.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gainsboro;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.bongve);
            this.panel1.Controls.Add(this.boom);
            this.panel1.Controls.Add(this.bong1);
            this.panel1.Controls.Add(this.pictureBox4);
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.bong);
            this.panel1.Location = new System.Drawing.Point(6, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(569, 253);
            this.panel1.TabIndex = 2;
            // 
            // bongve
            // 
            this.bongve.Location = new System.Drawing.Point(470, 200);
            this.bongve.Name = "bongve";
            this.bongve.Size = new System.Drawing.Size(50, 50);
            this.bongve.TabIndex = 7;
            this.bongve.TabStop = false;
            this.bongve.Paint += new System.Windows.Forms.PaintEventHandler(this.bong_Paint);
            // 
            // boom
            // 
            this.boom.BackColor = System.Drawing.Color.Transparent;
            this.boom.BackgroundImage = global::Bai_Tap_Nhom_8.Properties.Resources.bongno;
            this.boom.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.boom.Location = new System.Drawing.Point(193, 176);
            this.boom.Name = "boom";
            this.boom.Size = new System.Drawing.Size(50, 50);
            this.boom.TabIndex = 6;
            this.boom.TabStop = false;
            // 
            // bong1
            // 
            this.bong1.Location = new System.Drawing.Point(26, 196);
            this.bong1.Name = "bong1";
            this.bong1.Size = new System.Drawing.Size(50, 50);
            this.bong1.TabIndex = 5;
            this.bong1.TabStop = false;
            this.bong1.Paint += new System.Windows.Forms.PaintEventHandler(this.bong1_Paint);
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox4.BackgroundImage = global::Bai_Tap_Nhom_8.Properties.Resources.new_03;
            this.pictureBox4.Location = new System.Drawing.Point(380, 145);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(59, 109);
            this.pictureBox4.TabIndex = 3;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.BackgroundImage = global::Bai_Tap_Nhom_8.Properties.Resources.new_03;
            this.pictureBox3.Location = new System.Drawing.Point(140, -30);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(155, 180);
            this.pictureBox3.TabIndex = 2;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.BackgroundImage = global::Bai_Tap_Nhom_8.Properties.Resources.new_02;
            this.pictureBox2.Location = new System.Drawing.Point(545, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(20, 250);
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::Bai_Tap_Nhom_8.Properties.Resources.new_01;
            this.pictureBox1.Location = new System.Drawing.Point(-2, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(22, 250);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // bong
            // 
            this.bong.Location = new System.Drawing.Point(25, 0);
            this.bong.Name = "bong";
            this.bong.Size = new System.Drawing.Size(50, 50);
            this.bong.TabIndex = 4;
            this.bong.TabStop = false;
            this.bong.Paint += new System.Windows.Forms.PaintEventHandler(this.bong_Paint);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = global::Bai_Tap_Nhom_8.Properties.Resources.new_00;
            this.ClientSize = new System.Drawing.Size(581, 309);
            this.ControlBox = false;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.MaximumSize = new System.Drawing.Size(589, 317);
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Form2_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form2_KeyDown);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bongve2)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bongve)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.boom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bong1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bong)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox bongve2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox bongve;
        private System.Windows.Forms.PictureBox boom;
        private System.Windows.Forms.PictureBox bong1;
        private System.Windows.Forms.PictureBox bong;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}