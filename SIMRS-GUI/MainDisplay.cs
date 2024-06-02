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
            if (dashboard == null)
            {
                dashboard = new DashboardDisplay();
                dashboard.FormClosed += DashboardDisplay_FormClosed;
                dashboard.MdiParent = this;
                dashboard.Show();
            }
            else
            {
                dashboard.Activate();
            }
        }
        private void DashboardDisplay_FormClosed(object sender, FormClosedEventArgs e)
        {
            dashboard = null;
        }

        private void buttonPasien_Click(object sender, EventArgs e)
        {
            if (pasien == null)
            {
                pasien = new PasienDisplay();
                pasien.FormClosed += PasienDisplay_FormClosed;
                pasien.MdiParent = this;
            }
        }

        private void PasienDisplay_FormClosed(object sender, FormClosedEventArgs e)
        {
            pasien = null;
        }
        private void nightControlBox1_Click(object sender, EventArgs e)
        {

        }

        private void PanelTop_Paint(object sender, PaintEventArgs e)
        {

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
