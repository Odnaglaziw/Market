using DataAccess;
using DataAccess.Repositories;
using Models.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App
{
    public partial class SignIn : Form
    {
        public SignIn()
        {
            InitializeComponent();
            label3.MouseEnter += (s, e) =>
            {
                label3.ForeColor = Color.Cyan;
            };
            label3.MouseLeave += (s, e) =>
            {
                label3.ForeColor = Color.White;
            };
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private async void button1_Click(object sender, EventArgs e)
        {
            if(LoginBox.Text == string.Empty || PasswordBox.Text == string.Empty)
            {
                MessageBox.Show("Заполните все поля.");
                return;
            }
            UserRepository userRepository = new UserRepository(new MarketContext());
            User user = await userRepository.GetByLogin(LoginBox.Text.Trim());
            if (user != null)
            {
                MessageBox.Show("Пользователь с таким логином уже существует.");
                return;
            }
            user = new User()
            {
                Name = "user",
                Password = Program.HashPassword(PasswordBox.Text),
                Email = LoginBox.Text,
                Role = checkBox1.Checked ? Role.Seller : Role.User
            };
            await userRepository.AddAsync(user);
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {
            Login login = new Login()
            {
                TopLevel = false,
                Parent = this.Parent,
                Dock = DockStyle.Fill,
                Enabled = true,
            };
            login.Show();
            Close();
        }
        
    }
}
