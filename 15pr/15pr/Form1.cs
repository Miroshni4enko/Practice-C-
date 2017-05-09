using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Math;

namespace _15pr
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        double function(double x, double dx, double k)
        {
            return  Pow(Tan(k*x),2.0) + Log(k-x) - Pow(k*x,1.0/2.0); 
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double x_min, x_max, dx, k;
            x_min =  Convert.ToDouble(textBox1.Text);
            x_max = Convert.ToDouble(textBox2.Text);
            dx = Convert.ToDouble(textBox3.Text);
            k = Convert.ToDouble(textBox4.Text);
            System.Object[] ItemObject = new System.Object[10];
            for (double x = x_min; x < x_max; x +=dx)
            {
                listBox1.Items.Add( " for x = " + x + " y =" + function(x,dx,k));
            }
        }

        
    }
}
