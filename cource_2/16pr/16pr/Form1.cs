using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _16pr
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            numericUpDown1.Minimum = 0;
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox1.Text = Convert.ToString(listBox1.SelectedItem);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(textBox1.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = Convert.ToString(listBox1.Items.Count);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < listBox1.Items.Count; i++)
            {
                if (textBox1.Text.Equals(Convert.ToString(listBox1.Items[i]))) {
                    textBox1.Text = Convert.ToString(i+1);
                    return;
                }
            }
            textBox1.Text ="not found this element" ;
        }

        private void button4_Click(object sender, EventArgs e)
        {

            listBox1.Items.Insert((int) numericUpDown1.Value, textBox1.Text);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            listBox1.Items.RemoveAt((int)numericUpDown1.Value);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
