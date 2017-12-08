using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pr4_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double a;
            try
            {
                a = Convert.ToDouble(textBox1.Text);
            }
            catch (FormatException)
            {
                MessageBox.Show("Вводить только числа", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            a = Math.Pow(a, 1.0 / 3.0);
            label3.Text = "= " + Convert.ToString(a);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label2.Text = "Введите число и нажмите кнопку";
        }
    }
}
