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
    public partial class Form5 : Form
    {
       
        public Form5()
        {
            InitializeComponent();
        }       
        private void timer2_Tick(object sender, EventArgs e)
        {
            System.Threading.Thread.Sleep(1500);
            buttonX1.Visible = true;
        }

        private void Form5_Load(object sender, EventArgs e)
        {          
            buttonX1.Visible = false;
        }

        private void buttonX1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}