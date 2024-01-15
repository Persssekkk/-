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
    public partial class корзина : Form
    {
        private List<Product> cart;
       // private FlowLayoutPanel cartDisplayPanel;
        public корзина()
        {
            cart = new List<Product>(); 
            
        }

        public void AddProductToCart(Product product)
        {
            cart.Add(product);
           // RefreshCartDisplay();
        }
        //private void RefreshCartDisplay()
        //{
        //    cartDisplayPanel.Controls.Clear(); // Очистка панели отображения
        //    foreach (Product product in cart)
        //    {
        //        Label productLabel = new Label();
        //        productLabel.Text = product.Name + " - " + product.Price;
        //        cartDisplayPanel.Controls.Add(productLabel); // Добавление товара на панель отображения
        //    }
        //}
        public корзина(object cart)
        {
            InitializeComponent();
        }

        
        private void label3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Главная form2 = new Главная();
            form2.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            this.Hide();
            каталог form2 = new каталог();
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

        private void корзина_Load(object sender, EventArgs e)
        {

        }
    }
}
