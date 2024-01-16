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
    public partial class Autorization : Form
    {
        public Autorization()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox1.Text == "admin" && textBox2.Text == "admin")
            {
                AdminPanel adminPanel = new AdminPanel();
                this.Hide();
                adminPanel.Show();
                return;
            }
            string login = textBox1.Text;
            string password = textBox2.Text;
            if (string.IsNullOrEmpty(login) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Введите логин и пароль");
                return;
            }
            Info.CurentUser = IsValidLogin(login, password);
            if (Info.CurentUser != 0)
            {
                Главная mainPage = new Главная();
                mainPage.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Неверные логин или пароль");
            }
        }
        private long IsValidLogin(string login, string password)
        {
            using (var context = new storeDBContext())
            {
                var clients = context.Clients.FirstOrDefault(u=> u.Login == login && u.Password == password);
                if (clients != null)
                {
                    long inofo = clients.ClientsId;
                    return inofo;
                }
                else
                {
                    return 0;
                }
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {
            this.Hide();
            регистрация form2 = new регистрация();
            form2.Show();
        }

    }
}
