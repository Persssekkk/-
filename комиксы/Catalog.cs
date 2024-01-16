using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using комиксы.Models;

namespace комиксы
{
    public partial class каталог : Form
    {
        public каталог()
        {
            InitializeComponent();
        }
        private int itemsPerPage = 6;
        private int currentPage = 1;

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            каталог_Load(sender, e);
            UpdateNavigationButtons();
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
            корзина form5 = new корзина();
            form5.Show();
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

        private void каталог_Load(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
            {
                using (var context = new storeDBContext())
                {
                    var products = context.Products
                        .OrderBy(a => a.IdProducts)
                        .Skip((currentPage - 1) * itemsPerPage)
                        .Take(itemsPerPage)
                        .ToList();

                    tableLayoutPanel1.Controls.Clear();

                    foreach (var product in products)
                    {
                        ProductControl productControl = new ProductControl();

                        productControl.SetProductInfo(product.Photo,
                            product.Name, product.IdProducts);

                        tableLayoutPanel1.Controls.Add(productControl);
                    }

                    UpdateNavigationButtons();
                }
            }
            else
            {
                using (var context = new storeDBContext())
                {
                    var products = context.Products
                        .OrderBy(a => a.IdProducts)
                        .Skip((currentPage - 1) * itemsPerPage)
                        .Where(a => a.Type == comboBox1.SelectedIndex.ToString())
                        .Take(itemsPerPage)
                        .ToList();

                    tableLayoutPanel1.Controls.Clear();

                    foreach (var product in products)
                    {
                        ProductControl productControl = new ProductControl();

                        productControl.SetProductInfo(product.Photo,
                            product.Name, product.IdProducts);

                        tableLayoutPanel1.Controls.Add(productControl);
                    }


                }
            }
        }
        private void UpdateNavigationButtons()
        {
            button1.Visible = HasNextPage();
            button2.Visible = HasPreviousPage();
        }


        private bool HasNextPage()
        {
            if (comboBox1.SelectedIndex == 0)
            {
                using (var context = new storeDBContext())
                {
                    return context.Products
                        .OrderBy(a => a.IdProducts)
                        .Skip(currentPage * itemsPerPage)
                        .Any();
                }

            }
            else
            {
                using (var context = new storeDBContext())
                {
                    return context.Products
                        .OrderBy(a => a.IdProducts)
                        .Where(a => a.Type == comboBox1.SelectedIndex.ToString())
                        .Skip(currentPage * itemsPerPage)
                        .Any();
                }
            }

        }

        private bool HasPreviousPage()
        {
            if(comboBox1.SelectedIndex == 0)
            {
                using (var context = new storeDBContext())
                {
                    return context.Products
                        .OrderBy(a => a.IdProducts)
                        .Take((currentPage - 1) * itemsPerPage)
                        .Any();
                }
            }
            else
            {
                using (var context = new storeDBContext())
                {
                    return context.Products
                        .OrderBy(a => a.IdProducts)
                        .Where(a => a.Type == comboBox1.SelectedIndex.ToString())
                        .Take((currentPage - 1) * itemsPerPage)
                        .Any();
                }
            }
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            currentPage--;

            if (currentPage < 1)
            {
                currentPage = 1;
            }

            каталог_Load(sender, e);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            currentPage++;
            каталог_Load(sender, e);

        }
    }

}

