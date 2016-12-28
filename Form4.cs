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
    public partial class Form4 : Form
    {
        private int x = 10;
        private int y = 0;
        private int u = 50;
        private bool phai;
        private bool trai;
        private bool z = true;
        private int nen = 0;
        private int docao = 120;  
        public Form4()
        {
            InitializeComponent();
        }

        private void bong_Paint(object sender, PaintEventArgs e)
        {
            GraphicsPath c = new GraphicsPath();
            c.AddEllipse(0, 0, u, u);
            PathGradientBrush pthGrBrush = new PathGradientBrush(c);
            pthGrBrush.CenterColor = Color.White;
            Color[] colors = { Color.Red };
            pthGrBrush.SurroundColors = colors;
            e.Graphics.FillEllipse(pthGrBrush, 0, 0, u, u);
        }

        private void bong1_Paint(object sender, PaintEventArgs e)
        {
            GraphicsPath c = new GraphicsPath();
            c.AddEllipse(0, 20, u, 30);
            PathGradientBrush pthGrBrush = new PathGradientBrush(c);
            pthGrBrush.CenterColor = Color.White;
            Color[] colors = { Color.Red };
            pthGrBrush.SurroundColors = colors;
            e.Graphics.FillEllipse(pthGrBrush, 0, 20, u, 30);
            c.Dispose();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            if (z) // bong di xuong
            {
                y += 10;
                bong.Location = new Point(x, y);
                if (y >= (325 - nen))
                {
                    //bong.Hide();
                    bong1.Location = new Point(x, 325 - nen);
                    //timer.Enabled = false;
                    bong1.Show();
                    z = false;
                }
            }
            else  // bong di len
            {
                y -= 10;
                bong1.Hide();
                bong.Location = new Point(x, y);
                bong.Show();
                if (y <= docao)
                {
                    z = true;
                }
            }
        }

        private void Form4_Load(object sender, EventArgs e)
        {

            bong1.Hide();
            bongve.Hide();
            boom.Hide();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (phai)
            {
                x += 1;
                if (x >= 520)
                {
                    trai = true;
                    phai = false;
                }
            }
            else if (trai)
            {
                x -= 1;
                if (x <= 0)
                {
                    phai = true;
                    trai = false;
                }
            }
        }

        private void Form4_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Right)
            {
                phai = true;
                trai = false;
            }
            else if (e.KeyCode == Keys.Left)
            {
                trai = true;
                phai = false;
            }
            else if (e.KeyCode == Keys.Down)
            {
                z = true;
            }
            else if (e.KeyCode == Keys.Up)
            {
                trai = false;
                phai = false;
                x = 310;
                y = 30;
                z = true;
            }
            else if (e.KeyCode == Keys.W)
            {
                trai = false;
                phai = false;
                x = 500;
                y = 30;
                z = true;
            }
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            if (x >= 30 && x <= 115 && y >= 210 && y <= 220)
            {
                timer.Enabled = false;
                timer3.Enabled = false;
                boom.Show();
                bong.Hide();
                boom.Location = new Point(x, y);
                MessageBox.Show("Trò chơi kết thúc !!");
                this.Close();
            }
            if (x >= 118 && x <= 140 && y >= 242 && y <= 295)
            {
                timer.Enabled = false;
                timer3.Enabled = false;
                boom.Show();
                bong.Hide();
                boom.Location = new Point(x, y);
                MessageBox.Show("Trò chơi kết thúc !!");
                this.Close();
            }
            if (x >= 242 && x <= 300 && y >= 230 && y <= 238)
            {
                timer.Enabled = false;
                timer3.Enabled = false;
                boom.Show();
                bong.Hide();
                bong1.Hide();
                boom.Location = new Point(x, y);
                MessageBox.Show("Trò chơi kết thúc !!");
                this.Close();
            }
            if (x >= 372 && x <= 520 && y >= 260 && y <= 267)
            {
                timer.Enabled = false;
                timer3.Enabled = false;
                boom.Show();
                bong.Hide();
                boom.Location = new Point(x, y);
                MessageBox.Show("Trò chơi kết thúc !!");
                this.Close();
            }
            if (x >= 435 && x <= 520 && y >= 153 && y <= 160)
            {
                timer.Enabled = false;
                timer3.Enabled = false;
                boom.Show();
                bong.Hide();
                boom.Location = new Point(x, y);
                MessageBox.Show("Trò chơi kết thúc !!");
                this.Close();
            }
            if (x >= 124 && x <= 520 && y <= 20)
            {
                timer.Enabled = false;
                timer3.Enabled = false;
                bong.Hide();
                boom.Show();
                boom.Location = new Point(x, y);
                MessageBox.Show("Trò chơi kết thúc !!");
                this.Close();
            }
            if (x >= 495 && x <= 505 && y == 80)
            {
                timer.Enabled = false;
                timer3.Enabled = false;
                bong.Hide();
                bong1.Hide();
                bongve.Show();
                timer4.Enabled = true;
            }
            ///////////////////////////////
            if (x >= 20 && x <= 23 && y <= 209 && y >= 0)
            {
                phai = false;
                trai = true;
            }
            if (x >= 121 && x <= 124 && y <= 209 && y >= 0)
            {
                phai = true;
                trai = false;
            }
            if (x >= 61 && x <= 64 && y <= 325 && y >= 300)
            {
                phai = false;
                trai = true;
            }
            if (x >= 301 && x <= 303 && y <= 295 && y >= 230)
            {
                phai = true;
                trai = false;
            }
            if (x >= 393 && x <= 396 && y <= 325 && y >= 300)
            {
                phai = true;
                trai = false;
            }
            if (x >= 368 && x <= 371 && y <= 260 && y >= 190)
            {
                phai = false;
                trai = true;
            }
            if (x >= 431 && x <= 434 && y <= 154 && y >= 83)
            {
                phai = false;
                trai = true;
            }
            ///////////////////////////////
            if (x >= 0 && x <= 520)
            {

                if (x >= 65 && x <= 380)
                {
                    docao = 90;
                    nen = 30;
                    if (x >= 119 && x <= 290)
                    {
                        docao = 60;
                        nen = 90;
                    }
                }
                if (x >= 370 && x <= 520)
                {
                    if (y <= 181)
                    {
                        docao = 21;
                        nen = 145;
                    }
                }
                if (x >= 435 && x <= 520)
                {
                    docao = 0;
                    nen = 245;
                }
            } 
        }

        private void timer4_Tick(object sender, EventArgs e)
        {
            pictureBox8.BackColor = Color.WhiteSmoke ;
            x += 2;
            bongve.Show();
            bongve.Location = new Point(x, y);
            if (x >= 575)
            {
                timer4.Enabled = false;
                MessageBox.Show("Chúc mừng bạn đã chiến thắng !!!");
                Form5 frm5 = new Form5();
                this.Close();
                frm5.Show();

            }
        }
     
    }
}