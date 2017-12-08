using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pr5_1
{
    public partial class Form1 : Form
    {
        int[] koordinati = new int[4];
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label1.Text = "Начало";
            label2.Text = "Конец";
            label3.Text = "X";
            label4.Text = "Y";
            button1.Text = "Рисовать";

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            Pen pen = new Pen(Color.Blue);
            e.Graphics.DrawLine(pen, koordinati[0], koordinati[1], koordinati[2], koordinati[3]);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            koordinati[0] = Convert.ToInt32(textBox1.Text);
            koordinati[1] = Convert.ToInt32(textBox2.Text);
            koordinati[2] = Convert.ToInt32(textBox3.Text);
            koordinati[3] = Convert.ToInt32(textBox4.Text);
            pictureBox1.Refresh();
        }
    }
}
