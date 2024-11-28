using DataAccess.Repositories;
using DataAccess;
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
using Models.Models;

namespace App
{
    public partial class Login : Form
    {
        public Login()
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
        public Login(string email, string password)
        {
            InitializeComponent();
            LoginBox.Text = email;
            PasswordBox.Text = password;
            checkBox1.Checked = true;
            label3.MouseEnter += (s, e) =>
            {
                label3.ForeColor = Color.Cyan;
            };
            label3.MouseLeave += (s, e) =>
            {
                label3.ForeColor = Color.White;
            };
        }

        private void label3_Click(object sender, EventArgs e)
        {
            SignIn signIn = new SignIn()
            {
                TopLevel = false,
                Parent = this.Parent,
                Dock = DockStyle.Fill,
                Enabled = true,
            };
            signIn.Show();
            Close();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
        

        private async void button1_Click(object sender, EventArgs e)
        {
            if (LoginBox.Text == string.Empty || PasswordBox.Text == string.Empty)
            {
                MessageBox.Show("Заполните все поля.");
                return;
            }
            UserRepository userRepository = new UserRepository(new MarketContext());
            User user = await userRepository.GetByLogin(LoginBox.Text.Trim());
            if (user == null)
            {
                MessageBox.Show("Пользователя с таким логином не существует.");
                return;
            }
            try
            {
                Cursor.Current = Cursors.WaitCursor;
                if (!Program.VerifyPassword(PasswordBox.Text.Trim(), user.Password))
                {
                    MessageBox.Show("Неверный пароль.");
                }
                else
                {
                    if (checkBox1.Checked)
                    {
                        File.WriteAllText("..\\user.txt",$"{user.Email};{PasswordBox.Text.Trim()}");
                    }
                    Program.user = user;
                    Form form = new Main()
                    {
                        TopLevel = false,
                        Parent = this.Parent,
                        Dock = DockStyle.Fill,
                        Enabled = true,
                    };
                    
                    form.Show();
                    Close();
                }
            }
            finally
            {
                Cursor.Current = Cursors.Default;
            }
        }
    }
}
