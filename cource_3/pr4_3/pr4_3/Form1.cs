using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pr4_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double a, b, c;
            string s;
            s = textBox1.Text;
            a = Convert.ToDouble(s);
            s = textBox2.Text;
            b = Convert.ToDouble(s);
            s = textBox3.Text;
            c = Convert.ToDouble(s);
            double f, m, k, D = 0;
            D = b * b - 4 * a * c;

            if (a == 0 || D >= 0)
            {
                MessageBox.Show("Решение нет , или оно не комплексное");
            }
            else
            {
                f = -1 * D;
                k = Math.Sqrt(f) / (2 * a);
                m = (-b) / (2 * a);
                label7.Text = String.Format("x1={0}+{1}*i x2 ={2}-{3}*i", m, k, m, k);

                label8.Text = String.Format("D={0}", D);
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Text = "Решение квадратного уравнения (только в тех случаях когда корни комплексные)";
            button1.Text = "Решить";
            label1.Text = "x^2+ ";
            label2.Text = "x +";
            label3.Text = "=0";
            label4.Text = "Введите a b c";
            label5.Text = "";
            label6.Text = "";
            label7.Text = "";
            label8.Text = "";

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) == true)
                return;
            if (e.KeyChar == (char)Keys.Back)
                return;
            if (e.KeyChar == ',')
                return;
            e.Handled = true;

        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) == true)
                return;
            if (e.KeyChar == (char)Keys.Back)
                return;
            if (e.KeyChar == ',')
                return;
            e.Handled = true;

        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) == true)
                return;
            if (e.KeyChar == (char)Keys.Back)
                return;
            if (e.KeyChar == ',')
                return;
            e.Handled = true;

        }
    }
}
