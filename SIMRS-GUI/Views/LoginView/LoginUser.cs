using SIMRS_GUI.Auth;

namespace SIMRS_GUI.Views.LoginView
{
    public partial class LoginUser : Form
    {
        public LoginUser()
        {
            InitializeComponent();
        }

        private async void TombolLogin_Click(object sender, EventArgs e)
        {
            ProsesLogin();
        }

        private void TextBoxPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                ProsesLogin();
            }
        }

        private async void ProsesLogin()
        {
            string username = TextBoxUsername.Text;
            string password = TextBoxPassword.Text;
            var response = await SessionManager.Login(username, password);
            if (!response.success)
            {
                MessageBox.Show(response.message);
            }
            else
            {
                Hide();
                MainDisplay ms = new MainDisplay(this);
                ms.Show();
                TextBoxUsername.Text = string.Empty;
                TextBoxPassword.Text = string.Empty;
            }
        }
    }
}
