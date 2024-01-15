using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace комиксы
{
    public partial class Главная : Form
    {
        public Главная()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_Load_1(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
        Process myProcess = new Process();
        private void button1_Click(object sender, EventArgs e)
        {
            string url = "https://goo.su/wPeb"; 
            System.Diagnostics.Process.Start("cmd", "/c start " + url);
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            string url = "https://t.me/persssekkk";
            System.Diagnostics.Process.Start("cmd", "/c start " + url);
        }

        private void label1_Click(object sender, EventArgs e)
        {
            this.Hide(); 
            каталог form2 = new каталог(); 
            form2.Show(); 
        }

        private void label2_Click(object sender, EventArgs e)
        {
            this.Hide();
            корзина form2 = new корзина();
            form2.Show();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            
            поддержка form2 = new поддержка();
            form2.Show();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            this.Hide();
            профиль form2 = new профиль();
            form2.Show();
        }
    }
}
