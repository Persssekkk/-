using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace комиксы
{
    public partial class каталог : Form
    {
        public каталог()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedImage = comboBox1.SelectedItem.ToString(); // Получаем выбранный элемент из комбобокса
            if (selectedImage == "Акции")
            {
                pictureBox1.Image = Properties.Resources.c1 ;
                pictureBox2.Image = Properties.Resources.c2;
                pictureBox3.Image = Properties.Resources.c3;
                pictureBox10.Image = Properties.Resources.c4;
                label6.Text = "Я убиваю великанов";
                label7.Text = "V — значит Vендетта";
                label7.Location = new Point(285, 210);
                label8.Text = "Нас 3";
                label8.Location = new Point(540, 210);
                label11.Text = "Маус";
                label11.Location = new Point(118, 354);
                label9.Visible = false;
                label10.Visible = false;
                pictureBox7.Visible = false;
                pictureBox8.Visible = false;
                pictureBox10.Visible = true;
                label11.Visible = true;

            }
            else if (selectedImage == "Все")
            {
                pictureBox1.Image = Properties.Resources.уке;
                pictureBox3.Image = Properties.Resources.укук;
                pictureBox2.Image = Properties.Resources.аа;
                pictureBox10.Image = Properties.Resources.c3;
                label6.Text = "Супермен. Красный сын";
                label7.Text = "Скотт Пилигримм";
                label7.Location = new Point(292, 210);
                label8.Text = "Бэтмен. Год первый";
                label8.Location = new Point(500, 210);
                label11.Text = "V — значит Vендетта";
                label11.Location = new Point(70, 354);
                label9.Visible = true;
                label10.Visible = true;
                pictureBox7.Visible = true;
                pictureBox8.Visible = true;
                pictureBox10.Visible = true;
                label11.Visible = true;
            }
            else if (selectedImage == "Новинки")
            {
               pictureBox2.Image = Properties.Resources.Огненный_удар__Книга_4;
               pictureBox3.Image = Properties.Resources.Человек_бензопила__Книга_8__Спойлер;
               pictureBox1.Image = Properties.Resources.Комикс_Люди_Икс_Золотые;
               label6.Text = "Комикс Люди Икс Золотые";
                label6.Location = new Point(50, 210);
                label8.Text = "Огненный удар. Книга 4";
                label8.Location = new Point(490, 210);
                label7.Text = "Человек бензопила. Книга 8";
                label7.Location = new Point(260, 210);
                label9.Visible = false;
                label10.Visible = false;
                label11.Visible = false;
                pictureBox7.Visible = false;
                pictureBox8.Visible = false;
                pictureBox10.Visible = false;
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Главная form2 = new Главная();
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

        private void label6_Click(object sender, EventArgs e)
        {
            картат form2 = new картат();
            form2.pictureBox1.Image = new Bitmap(pictureBox1.Image);
            form2.label1.Text = label6.Text;
              
            form2.Show();

        }

        private void label7_Click(object sender, EventArgs e)
        {
            картат form2 = new картат();
            form2.pictureBox1.Image = new Bitmap(pictureBox3.Image);
            form2.label1.Text = label7.Text;
            form2.Show();
        }

        private void label8_Click(object sender, EventArgs e)
        {
            картат form2 = new картат();
            form2.pictureBox1.Image = new Bitmap(pictureBox2.Image);
            form2.label1.Text = label8.Text;
            form2.Show();
        }

        private void label11_Click(object sender, EventArgs e)
        {
            картат form2 = new картат();
            form2.pictureBox1.Image = new Bitmap(pictureBox10.Image);
            form2.label1.Text = label11.Text;
            form2.Show();
        }

        private void label9_Click(object sender, EventArgs e)
        {
            картат form2 = new картат();
            form2.pictureBox1.Image = new Bitmap(pictureBox8.Image);
            form2.label1.Text = label9.Text;
            form2.Show();
        }

        private void label10_Click(object sender, EventArgs e)
        {
            картат form2 = new картат();
            form2.pictureBox1.Image = new Bitmap(pictureBox7.Image);
            form2.label1.Text = label10.Text;
            form2.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
        }
    }
}
