using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pr2_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Text = "Предупреждение";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            label1.Text = "На меня курсор не наводить";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_MouseHover(object sender, EventArgs e)
        {
            label1.ForeColor = Color.Red;
            label1.Text = "А я предупреждал";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            MessageBox.Show("Тікай з міста", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
