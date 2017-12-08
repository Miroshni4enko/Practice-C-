using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pr5_2
{
    public partial class Form1 : Form
    {
        int[] k = new int[6];
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            Pen pen = new Pen(Color.Red);
            e.Graphics.DrawLine(pen, k[0], k[1], k[2], k[3]);
            pen.Color = Color.White;
            e.Graphics.DrawLine(pen, k[2], k[3], k[4], k[5]);
            pen.Color = Color.Black;
            e.Graphics.DrawLine(pen, k[4], k[5], k[0], k[1]);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            button1.Text = "Рисовать";
            pictureBox1.BackColor = Color.Green;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            k[0] = Convert.ToInt32(textBox1.Text);
            k[1] = Convert.ToInt32(textBox2.Text);
            k[2] = Convert.ToInt32(textBox3.Text);
            k[3] = Convert.ToInt32(textBox4.Text);
            k[4] = Convert.ToInt32(textBox5.Text);
            k[5] = Convert.ToInt32(textBox6.Text);
            pictureBox1.Refresh();

        }
    }
}
