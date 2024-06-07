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
            string username = TextBoxUsername.Text;
            string password = TextBoxPassword.Text;
            var response = await SessionManager.Login(username, password);
            /*response.message*/
            if (!response.success)
            {
                MessageBox.Show(response.message);
            } else
            {
                Hide();
                MainDisplay ms = new MainDisplay();
                ms.Show();
            }
            //TextBoxUsername.ClearUndo();
            //TextBoxPassword.ClearUndo();
        }
    }
}
