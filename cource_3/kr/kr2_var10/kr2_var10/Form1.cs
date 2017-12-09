using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kr2_var10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double step  = double.Parse(textBox1.Text);
            double start = double.Parse(textBox2.Text);
            double finish = double.Parse(textBox3.Text);
            double a = double.Parse(textBox4.Text);
            Random rnd = new Random();
            double q;
            string param;
            for (; start <= finish; start += step) {
                q = rnd.NextDouble();
                param = " x = " + start + "; q = " + q + "; ";
                if (q > 0 && q <= 0.55) {
                    
                    listBox1.Items.Add(param + " f1 =  " +  fun1(a, start, q));
                }
                if ( q > 0.55  && q <= 1)
                {
                    
                    listBox2.Items.Add(param + " f2 = " + fun2(start, q));
                }
            } 
        }

        double fun1(double a, double x, double q)
        {
            return Math.Log(a - x) / (q + x);
        }
        double fun2(double x, double q)
        {
            return Math.Pow((q + x), 1 / 3);
        }
    }
}
