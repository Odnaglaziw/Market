using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App
{
    public partial class Root : Form
    {
        public Root()
        {
            MaximizeBox = false;
            InitializeComponent();
            if (File.Exists("..\\user.txt"))
            {
                string[] parts = File.ReadAllText("..\\user.txt").Trim().Split(';');
                Login login = new Login(parts[0], parts[1])
                {
                    TopLevel = false,
                    Parent = this,
                    Dock = DockStyle.Fill,
                    Enabled = true,
                };
                login.Show();
            }
            else
            {
                SignIn signIn = new SignIn()
                {
                    TopLevel = false,
                    Parent = this,
                    Dock = DockStyle.Fill,
                    Enabled = true,
                };
                signIn.Show();
            }
        }
    }
}
