using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pr8_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label1.Text = "Строка";
            label2.Text = "Тип строки";
            label3.Text = "Выберите строку и она появится в [строка]";
            label4.Text = "Количество строк в листбоксе";
            textBox3.Text = listBox1.Items.Count.ToString();
            button1.Text = "Обновить цифру";
            label5.Text = "Поиск в списке";
            button2.Text = "Поиск";
            label6.Text = "№";
            label7.Text = "№";
            label8.Text = "Строка";
            label9.Text = "Добавление строки в список";
            button3.Text = "Добавить";
            label10.Text = "Удаление строки";
            label11.Text = "По номеру";
            label12.Text = "По названию";
            button4.Text = button5.Text = "Удалить";
            button6.Text = "Очистить список";
            label13.Text = "Проверка на существование";
            button7.Text = "Проверить";
            label14.Text = "Добавление массива строк";
            button8.Text = "Добавить";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox3.Text = listBox1.Items.Count.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox5.Text = Convert.ToString(listBox1.Items.IndexOf(textBox4.Text));
        }

        private void button3_Click(object sender, EventArgs e)
        {
            listBox1.Items.Insert(Convert.ToInt32(textBox6.Text), textBox7.Text);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            listBox1.Items.RemoveAt(Convert.ToInt32(textBox8.Text));
        }

        private void button5_Click(object sender, EventArgs e)
        {
            listBox1.Items.Remove(textBox9.Text);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (listBox1.Items.Contains(textBox10.Text) == true)
            {
                textBox11.Text = "Да";
            }
            else
            {
                textBox11.Text = "Нет";
            }

        }

        private void button8_Click(object sender, EventArgs e)
        {
            string[] s = { textBox12.Text, textBox13.Text, textBox14.Text };
            listBox1.Items.AddRange(s);

        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox1.Text = Convert.ToString(listBox1.SelectedItem);
            textBox2.Text = Convert.ToString(listBox1.SelectedItem.GetType());
        }
    }
}
