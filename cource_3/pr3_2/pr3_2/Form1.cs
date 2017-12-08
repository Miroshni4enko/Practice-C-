using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pr3_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox1.BackColor = Color.Yellow;
            button1.Text = "Enter";
            textBox1.PasswordChar = '*';

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Your password: " + textBox1.Text, "Password", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
