using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D ;
using System.Text;
using System.Windows.Forms;

namespace game
{
    public partial class FormMain : Form
    {
        private bool t = false  ;
        private bool z = true ;
        private int v = 0;
        private int v1 = 0; 
        private int x1 = 3;
        private int x = 25;
        private int y = 0;
        public FormMain()
        {
            InitializeComponent();
        }

        private void bong_Paint(object sender, PaintEventArgs e)
        {
            GraphicsPath c = new GraphicsPath();
            c.AddEllipse(0, 0, 30, 30);
            PathGradientBrush pthGrBrush = new PathGradientBrush(c);
            pthGrBrush.CenterColor = Color.White;
            Color[] colors = { Color.Red };
            pthGrBrush.SurroundColors = colors;
            e.Graphics.FillEllipse(pthGrBrush, 0, 0, 30, 30);
            c.Dispose();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            if (z)
            {
                y += 3;
                //bong.Location = new Point(x, y);
                if (y >= 127)
                {
                    v += v1;
                    z = false;
                    if (v >= 127)
                    {
                        timer.Enabled = false;
                        //bong.Location = new Point(x, 127);
                        timer1.Enabled = true;
                    }
                }
            }
            else
            {
                y -= 3;
               // bong.Location = new Point(x, y);
                if (y <= v)
                {
                    z = true;
                }
            }
            if (t)
            {
               x += x1;
              //  bong.Location = new Point(x, y);
                if (x >= 135)
                {
                    t = false;
                }
            }
            else
            {
                x -= x1;
               // bong.Location = new Point(x, y);
                if (x <= 0)
                {
                    t = true;
                }
            }
        }

        private void Btbatdau_Click(object sender, EventArgs e)
        {
            v1 = 30;
            x1 = 0;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            y += 3;
           // bong.Location = new Point(x, y);
            if (y >= 157)
            {
                x = 25;
                y = -300;
                x1 = 3;
                v = 0;
                v1 = 0;
                timer1.Enabled = false;
                timer.Enabled = true;
                MessageBox.Show("Bắt Đầu");
                Form2 frm2 = new Form2();
                frm2.Show();                         
              
            }
        }

        private void btthongtin_Click(object sender, EventArgs e)
        {
            Form3 frm3 = new Form3();
            frm3.ShowDialog();
        }

        private void btthoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }


    }
}