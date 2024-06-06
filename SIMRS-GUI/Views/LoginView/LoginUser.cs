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
            //string username = TextBoxUsername.Text;
            //string password = TextBoxPassword.Text;
            await SessionManager.Login("famuwa", "admin");
            //TextBoxUsername.ClearUndo();
            //TextBoxPassword.ClearUndo();
            Hide();
            MainDisplay ms = new MainDisplay();
            ms.Show();
        }
    }
}
