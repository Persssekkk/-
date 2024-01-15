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
    public partial class регистрация : Form
    {
        public регистрация()
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
            using (var context = new storeDBContext())
            {
                if (context.Clients.Any(u => u.Login == login))
                {
                    MessageBox.Show("Такой логин уже есть. Перейдите на страницу входа или выберите другой логин");
                    return;
                }
                var newclient = new Clients
                {
                    Login = login,
                    Password = password
                };
                context.Clients.Add(newclient);
                context.SaveChanges();
                MessageBox.Show("Вы успешно зарегистированы!");
                this.Hide();
                Главная form2 = new Главная();
                form2.Show();
            }

        }

        private void label4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form9 form2 = new Form9();
            form2.Show();
        }
    }
}
