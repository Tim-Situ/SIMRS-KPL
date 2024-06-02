using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SIMRS_GUI.Auth;

namespace SIMRS_GUI
{
    public partial class LoginPage : Form
    {
        public LoginPage()
        {
            InitializeComponent();
        }

        private async void tombolLogin_Click(object sender, EventArgs e)
        {
            string username = textBoxUsername.Text;
            string password = textBoxPassword.Text;
            await SessionManager.Login(username, password);
            MainDisplay main = new MainDisplay();
            main.Show();
            Hide();
            textBoxUsername.Clear();
            textBoxPassword.Clear();
        }
    }
}
