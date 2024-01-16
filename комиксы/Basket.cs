using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using комиксы.Models;

namespace комиксы
{
    public partial class корзина : Form
    {
        public корзина()
        {
            InitializeComponent();

        }

        
        public int Amount; 
        private void корзина_Load(object sender, EventArgs e)
        {
            using (var context = new storeDBContext())
            {
                var result = context.Cart
                     .OrderBy(cartItem => cartItem.ProductsId)
                     .Join(context.Products,
                            cartItem => cartItem.ProductsId,
                             product => product.IdProducts,
                            (cartItem, product) => new
                            {
                                CartItem = cartItem,
                                Product = product
                             })
                         .Where(joinResult => joinResult.CartItem.ProductsId == joinResult.Product.IdProducts &&
                         joinResult.CartItem.ClientsId == Info.CurentUser)
                        .ToList();

                flowLayoutPanel1.Controls.Clear();

                foreach (var Result in result)
                {
                    BasketContorll basketContorll = new BasketContorll();
                    basketContorll.SetProductInfo(Result.Product.Photo, Result.Product.Name,
                        Result.Product.Price, Result.Product.IdProducts);

                    label6.Text = SaveSum(basketContorll.label6, label6).ToString();
                    flowLayoutPanel1.Controls.Add(basketContorll);
                }

               
            }
            label6.Text += "₽";
        }


        private int SaveSum(Label labelLink, Label labelToSave)
        {
            return (int.Parse(labelToSave.Text) + int.Parse(labelLink.Text));
        }
        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            заказ form2 = new заказ();
            form2.Show();
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
    }
}
