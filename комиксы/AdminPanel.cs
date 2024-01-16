using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using комиксы.Models;

namespace комиксы
{
    public partial class AdminPanel : Form
    {
        public AdminPanel()
        {
            InitializeComponent();

        }
        private void Refreshbd()
        {
            using (var context = new storeDBContext())
            {
                var products = context.Products.ToList();
                if (products != null)
                {
                    dataGridView1.DataSource = products;
                }
            }
        }
        private void AdminPanel_Load(object sender, System.EventArgs e)
        {
            using (var context = new storeDBContext())
            {
                var products = context.Products.ToList();
                if (products != null)
                {
                    dataGridView1.DataSource = products;
                }
            }


        }
        private byte[] ConvertImageToByteArray(Image image)
        {

            using (MemoryStream ms = new MemoryStream())
            {

                image.Save(ms, ImageFormat.Jpeg);
                return ms.ToArray();
            }
        }

        private void button1_Click(object sender, System.EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Image Files (*.png;*.jpeg;*.jpg;*.gif;*.bmp)|*.png;*.jpeg;*.jpg;*.gif;*.bmp";
                openFileDialog.Title = "Выберите файл изображения";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string filePath = openFileDialog.FileName;
                    pictureBox1.Image = Image.FromFile(filePath);

                }
            }

            using (var context = new storeDBContext())
            {
                if (pictureBox1.Image != null)
                {
                    Products photo = new Products
                    {
                        Photo = ConvertImageToByteArray(pictureBox1.Image)
                    };
                    context.Products.Add(photo);
                    context.SaveChanges();
                    pictureBox1.Image = null;
                    Refreshbd();
                }

          
            }
        }
    }
}
