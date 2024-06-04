namespace SIMRS_GUI
{
    public partial class MainDisplay : Form
    {
        DashboardDisplay dashboard;
        PasienDisplay pasien;
        public MainDisplay()
        {
            InitializeComponent();
        }

        private void MainDisplayDraft_Load(object sender, EventArgs e)
        {

        }

        private void buttonDashboard_Click(object sender, EventArgs e)
        {
            if (BodyPanel.Controls.Count == 1)
            {
                BodyPanel.Controls[0].Dispose();
            }
            dashboard = new DashboardDisplay();
            dashboard.Dock = DockStyle.Fill;
            BodyPanel.Controls.Add(dashboard);
            dashboard.Show();
        }

        private void buttonPasien_Click(object sender, EventArgs e)
        {
            if (BodyPanel.Controls.Count == 1)
            {
                BodyPanel.Controls[0].Dispose();
            }

            pasien = new PasienDisplay(this);
            pasien.Dock = DockStyle.Fill;
            BodyPanel.Controls.Add(pasien);
            pasien.Show();
        }

        bool sidebarExpand = true;
        private void sidebarTransition_Tick(object sender, EventArgs e)
        {
            if (sidebarExpand)
            {
                sidebar.Width -= 10;
                if (sidebar.Width <= 61)
                {
                    sidebarExpand = false;
                    sidebarTransition.Stop();

                    /*buttonDashboard.Width = sidebar.Width;
                    buttonPasien.Width = sidebar.Width;
                    buttonDokter.Width = sidebar.Width;
                    buttonObat.Width = sidebar.Width;
                    buttonPemeriksaan.Width = sidebar.Width;
                    buttonPembayaran.Width = sidebar.Width;*/
                }
            }
            else
            {
                sidebar.Width += 10;
                if (sidebar.Width >= 222)
                {
                    sidebarExpand = true;
                    sidebarTransition.Stop();

                    buttonDashboard.Width = sidebar.Width;
                    buttonPasien.Width = sidebar.Width;
                    buttonDokter.Width = sidebar.Width;
                    buttonObat.Width = sidebar.Width;
                    buttonPemeriksaan.Width = sidebar.Width;
                    buttonPembayaran.Width = sidebar.Width;
                }
            }
        }

        private void hamburgerMenu_Click(object sender, EventArgs e)
        {
            sidebarTransition.Start();
        }



        private void sidebar_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
