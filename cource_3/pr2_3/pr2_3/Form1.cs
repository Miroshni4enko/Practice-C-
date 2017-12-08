using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pr2_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Text = "Пример подсказки";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            label1.Text = "Введите ваше имя до нажатия кнопки";
            button1.Text = "Стартуем";
            toolTip1.SetToolTip(textBox1, "Для ввода имени");
            toolTip1.IsBalloon = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Привет, " + textBox1.Text, "Приветсвие", MessageBoxButtons.OK);
        }
    }
}
