using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using комиксы.Models;

namespace комиксы
{
    public partial class заказ : Form
    {
        public заказ()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void заказ_Load(object sender, EventArgs e)
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

                    label1.Text = SaveSum(basketContorll.label6, label1).ToString();
                    flowLayoutPanel1.Controls.Add(basketContorll);
                }

            }
            label1.Text += "₽";
        }
        private int SaveSum(Label labelLink, Label labelToSave)
        {
            return (int.Parse(labelToSave.Text) + int.Parse(labelLink.Text));
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
