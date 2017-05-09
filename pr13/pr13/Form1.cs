using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace pr13
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        /*№5
        Створити C# програму для малювання прямокутника.
        Колір пера -    BlueViolet,  ширина -  2 пікселі, стиль - DashDot.
        Всередині прямокутника повинен бути розміщений який-небудь текст.
        Шрифт - "Arial Black", розмір -  14. 
        Також створити пензлик для штрихування.
        Стиль штрихування – Cross, колір - DeepPink.
        Цей пензлик використати для  малювання прямокутника. 
        Розміри усіх графічних фігур – довільні.*/


        private void button1_Click(object sender, EventArgs e)
        {
            Graphics g = Graphics.FromHwnd(this.Handle);
            Pen pen1 = new Pen(Color.BlueViolet);
            pen1.Width=2;
            pen1.DashStyle = System.Drawing.Drawing2D.DashStyle.DashDot;
            Rectangle rect1 = new Rectangle(10, 10, 200, 50);
            g.DrawRectangle(pen1, rect1);
            Brush brush1 = Brushes.Black;
            Font myFont = new Font("Arial", 14);
            g.DrawString("You are welcome!", myFont, brush1, 15, 15);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Graphics g = Graphics.FromHwnd(this.Handle);
            HatchBrush brush = new HatchBrush(HatchStyle.Cross,Color.DeepPink);
            Rectangle rect2 = new Rectangle(10, 70, 200, 80);
            g.FillRectangle(brush, rect2);
        }
    }

}
   

