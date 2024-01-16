using System;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using комиксы.Models;

namespace комиксы
{

    public partial class картат : Form
    {
        private long productId;
        public картат(long pId)
        {
           productId = pId;
            InitializeComponent();
            using (var context = new storeDBContext())
            {
                var result = (from Products in context.Products
                              where Products.IdProducts == pId
                              select new
                              {
                                  Products.Name,
                                  Products.Info,
                                  Products.Price,
                                  Products.Photo
                              }).FirstOrDefault();
                if (result != null)
                {
                    using (MemoryStream ms = new MemoryStream(result.Photo))
                    {
                        pictureBox1.Image = Image.FromStream(ms);
                    }
                    label1.Text = result.Name;
                    label3.Text = result.Price.ToString() + "₽";
                    richTextBox1.Text = result.Info;


                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (var context = new storeDBContext())
            {
                var newCart = new Cart
                {
                    ClientsId = Info.CurentUser,
                    ProductsId = productId
                };
                context.Cart.Add(newCart);
                context.SaveChanges();
            }
            корзина cart = new корзина();
            this.Hide();
        }

    }
}
