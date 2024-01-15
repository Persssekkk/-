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
    public partial class профиль : Form
    {
        public профиль()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Главная form2 = new Главная();
            form2.Show();
        }

        private void label7_Click(object sender, EventArgs e)
        {
            this.Hide();
            каталог form2 = new каталог();
            form2.Show();
        }

        private void label6_Click(object sender, EventArgs e)
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
    }
}
