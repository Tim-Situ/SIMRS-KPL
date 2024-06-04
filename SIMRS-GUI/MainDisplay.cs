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
        private void SidebarTransition_Tick(object sender, EventArgs e)
        {
            if (sidebarExpand)
            {
                sidebar.Width -= 10;
                if (sidebar.Width <= 61)
                {
                    sidebarExpand = false;
                    sidebarTransition.Stop();
                }
            }
            else
            {
                sidebar.Width += 10;
                if (sidebar.Width >= 222)
                {
                    sidebarExpand = true;
                    sidebarTransition.Stop();
                }
            }
        }

        private void HamburgerMenu_Click(object sender, EventArgs e)
        {
            sidebarTransition.Start();
        }
    }
}
