using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pr6_2
{
    public partial class Form1 : Form
    {
        bool dozvil = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            

        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            dozvil = true;
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            dozvil = false;
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            Graphics g = pictureBox1.CreateGraphics();
            Brush brush = Brushes.Red;
            if (dozvil == true)
            {
                g.FillEllipse(brush, e.X, e.Y, 5, 5);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            button1.Text = "Очистить экран";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Graphics g = pictureBox1.CreateGraphics();
            g.Clear(SystemColors.Window);
        }
    }
}
