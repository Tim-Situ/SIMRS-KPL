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
