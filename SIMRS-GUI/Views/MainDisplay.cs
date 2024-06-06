using SIMRS_GUI.Views.LoginView;
using SIMRS_GUI.Views.PasienView;
using SIMRS_GUI.Views.DokterView;
using SIMRS_GUI.Views.PoliView;
using SIMRS_GUI.Views.ObatView;

namespace SIMRS_GUI
{
    public partial class MainDisplay : Form
    {
        public MainDisplay()
        {
            InitializeComponent();
        }

        public void ShowDisplay(Form display)
        {
            if (BodyPanel.Controls.Count == 1)
            {
                BodyPanel.Controls[0].Dispose();
            }
            display.Dock = DockStyle.Fill;
            BodyPanel.Controls.Add(display);
            display.Show();
        }

        private void buttonDashboard_Click(object sender, EventArgs e)
        {
            ShowDisplay(new DashboardDisplay());
        }

        private void buttonPasien_Click(object sender, EventArgs e)
        {
            ShowDisplay(new PasienDisplay(this));
        }
        private void buttonDokter_Click(object sender, EventArgs e)
        {
            ShowDisplay(new DokterDisplay(this));
        }
        private void buttonPoli_Click(object sender, EventArgs e)
        {
            ShowDisplay(new PoliDisplay(this));
        }
        private void buttonObat_Click(object sender, EventArgs e)
        {
            ShowDisplay(new ObatDisplay(this));
        }

        // Sidebar
        bool sidebarExpand = true;
        private void HamburgerMenu_Click(object sender, EventArgs e)
        {
            if (sidebarExpand)
            {
                sidebar.Width = 61;
                sidebarExpand = false;
            }
            else
            {
                sidebar.Width = 250;
                sidebarExpand = true;
            }
        }
    }
}
