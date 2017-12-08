using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pr3_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox1.SelectedIndex)
            {
                case 0:
                    pictureBox1.Image = Image.FromFile("d:\\All\\enimals14.jpg");
                    label1.Text = "Photo №1";
                    break;
                case 1:
                    pictureBox1.Image = Image.FromFile("d:\\All\\enimals14.jpg");
                    label1.Text = "Photo №2";
                    break;

            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.Text = "List";
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
