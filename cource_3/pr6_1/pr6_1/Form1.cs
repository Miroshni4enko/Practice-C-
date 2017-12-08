using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pr6_1
{
    public partial class Form1 : Form
    {
        int[] p = new int[4];
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.Text = "Фигуры";
            button1.Text = "Нарисовать выбранную фигуру";
            string[] s = { "Круг", "Прямоугольник", "Эллипс" };
            comboBox1.Items.AddRange(s);
            pictureBox1.BackColor = Color.Yellow;
    
        }

        private void button1_Click(object sender, EventArgs e)
        {
            p[0] = Convert.ToInt32(textBox1.Text);
            p[1] = Convert.ToInt32(textBox2.Text);
            p[2] = Convert.ToInt32(textBox3.Text);
            p[3] = Convert.ToInt32(textBox4.Text);
            pictureBox1.Refresh();
            Brush brush = Brushes.Blue;
            Graphics g = pictureBox1.CreateGraphics();
            switch (comboBox1.SelectedIndex)
            {
                case 0:
                    g.FillEllipse(brush, p[0], p[1], p[2], p[3]);
                    break;
                case 1:
                    g.FillRectangle(brush, p[0], p[1], p[2], p[3]);
                    break;
                case 2:
                    g.FillEllipse(brush, p[0], p[1], p[2], p[3]);
                    break;
            }

        }
    }
}
