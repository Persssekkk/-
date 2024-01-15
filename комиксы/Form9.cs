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
    public partial class Form9 : Form
    {
        public Form9()
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
            string login = textBox1.Text;
            string password = textBox2.Text;
            if (string.IsNullOrEmpty(login) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Введите логин и пароль");
                return;
            }
            CurrentClients.ClientsID = IsValidLogin(login, password);
            if (CurrentClients.ClientsID != 0)
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
    public static class CurrentClients
    {
        public static long ClientsID { get; set; }
    }
}
