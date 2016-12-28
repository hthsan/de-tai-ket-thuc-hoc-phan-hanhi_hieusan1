using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Drawing2D ;

namespace game
{
    public partial class Form2 : Form
    {
        private int x = 25;
        private int y = 0;
        private int t = 20;
        private int u = 50;
        private int xx = 470;
        private int yy = 200;
        private int yy2 = -50;
        private bool z = true;
        private bool phai;
        private bool trai;
        public Form2()
        {
            InitializeComponent();
            
        }

        private void timer_Tick(object sender, EventArgs e)
        {

            if (z) // bong di xuong
            {
                y += 10;
                bong.Location = new Point(x, y);
                if (y >= 200)
                {
                    bong.Hide();
                    bong1.Location = new Point(x, 200);
                    bong1.Show();
                    z = false;
                    //t += 10;
                    if (t >= 200 && y >= 200)
                    {
                        timer.Enabled = false;
                        timer1.Enabled = false;
                        bong1.Hide();
                        bong.Location = new Point(x, 200);
                        bong.Show();
                        MessageBox.Show("Phải thử thêm lần nữa mới được!"); 
                        //FormMain frm = new FormMain();
                        this.Close();
                       // frm.Show();
                        
                    }
                    if (x >= 465 && x <= 475)
                    {
                        bong.Hide();
                        bong1.Hide();
                        timer2.Enabled = true;
                        timer.Enabled = false;
                        timer1.Enabled = false;
                    }
                }
                if (y >= 95)
                {
                    if (x > 330 && x < 440)
                    {
                        z = false;
                    }
                }
            }
            else  // bong di len
            {
                y -= 10;
                bong1.Hide();
                bong.Location = new Point(x, y);
                bong.Show();
                if (y <= t)
                {
                    z = true;
                }
                if (y <= 150)
                {
                    if (x > 100 && x < 295)
                    {
                        timer.Enabled = false;
                        timer1.Enabled = false;
                        timer2.Enabled = false;
                        bong.Hide();
                        boom.Show();
                        boom.Location = new Point(x, y);
                        MessageBox.Show("Phải thử thêm lần nữa mới được!"); 
                        //FormMain frm = new FormMain();
                        this.Close();
                        //frm.Show();
                    }
                }

            }
        }
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.P)
            {
                if (timer1.Enabled == false && timer1.Enabled == false)
                {
                    timer.Enabled = true;
                    timer1.Enabled = true;
                }
                else
                {
                    timer.Enabled = false;
                    timer1.Enabled = false;
                }
            }
            if (e.KeyCode == Keys.R)
            {
                timer.Enabled = false;
                timer1.Enabled = false;
                trai = false;
                phai = false;
                x = 25;
                y = 0;
                z = true;
                boom.Hide();
                bong1.Hide();
                bong.Show();
                bong.Location = new Point(x, y);
            }

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
            c.Dispose();
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

        private void Form2_Load(object sender, EventArgs e)
        {
            bong1.Hide();
            boom.Hide();
            bongve.Hide();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            if (phai)
            {
                x += 1;
                if (x >= 495) // cham gai ben phai
                {
                    timer.Enabled = false;
                    timer1.Enabled = false;
                    bong.Hide();
                    bong1.Hide();
                    boom.Show();
                    boom.Location = new Point(x, y);
                    MessageBox.Show("Phải thử thêm lần nữa mới được!"); 
                    //FormMain frm = new FormMain();
                    this.Close();
                    //frm.Show();
                }
                if (x == 90)
                {
                    if (y >= 0 && y <= 100)
                    {
                        phai = false;
                        trai = true;
                    }

                }
                if (x == 330)
                {
                    if (y >= 95 && y <= 200)
                    {
                        phai = false;
                        trai = true;
                    }
                }
            }
            else if (trai)
            {
                x -= 1;
                if (x <= 20) // cham gai ben trai
                {
                    timer.Enabled = false;
                    timer1.Enabled = false;
                    bong.Hide();
                    bong1.Hide();
                    boom.Show();
                    boom.Location = new Point(x, y);
                    MessageBox.Show("Phải thử thêm lần nữa mới được!");                    
                    this.Close();                  
                }
                if (y >= 0 && y <= 100)
                {
                    if (x == 295)
                    {
                        trai = false;
                        phai = true;
                    }
                }
                if (y >= 95 && y <= 200)
                {
                    if (x == 440)
                    {
                        phai = true;
                        trai = false;
                    }
                }
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            bongve.Show();
            yy += 2;
            yy2 += 2;
            bongve.Location = new Point(xx, yy);
            bongve2.Location = new Point(0, yy2);
            if (yy2 >= 50)
            {
                timer2.Enabled = false;
                MessageBox.Show("Qua vòng rồi !");
                Form4 frm4 = new Form4();
                this.Close();
                frm4.Show();
            }
            else
            {
                Form6 frm6 =new Form6();
            this.Close();
            frm6.Show();
                }
        }

        private void Form2_KeyDown(object sender, KeyEventArgs e)
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
            else if (e.KeyCode == Keys.Up )
            {
                x = 470;
                y = 50;
                trai = false;
                phai = false;
                z = true;
            }
        }

       
  }
}