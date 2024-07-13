namespace Nimble
{
    public partial class NimbleApp : Form
    {
        public NimbleApp()
        {
            InitializeComponent();
        }

        private void Nimble_Load(object sender, EventArgs e)
        {
            task_uc1.Hide();
            team_uc1.Hide();
            effort_uc1.Hide();
            overview_uc1.Show();
            overview_uc1.BringToFront();
            overview_uc1.Dock = DockStyle.Fill;
        }

        private void exit_Btn_MouseClick(object sender, MouseEventArgs e)
        {
            this.Close();
        }

        private void navclose_Btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void overview_Btn_Click(object sender, EventArgs e)
        {
            task_uc1.Hide();
            team_uc1.Hide();
            effort_uc1.Hide();
            overview_uc1.Show();
            overview_uc1.BringToFront();
            overview_uc1.Dock = DockStyle.Fill;
        }

        private void team_Btn_Click(object sender, EventArgs e)
        {
            task_uc1.Hide();
            overview_uc1.Hide();
            effort_uc1.Hide();
            team_uc1.Show();
            team_uc1.BringToFront();
            team_uc1.Dock = DockStyle.Fill;
        }

        private void tasks_Btn_Click(object sender, EventArgs e)
        {
            team_uc1.Hide();
            overview_uc1.Hide();
            effort_uc1.Hide();
            task_uc1.Show();
            task_uc1.BringToFront();
            task_uc1.Dock = DockStyle.Fill;
        }

        private void effort_Btn_Click(object sender, EventArgs e)
        {
            team_uc1.Hide();
            overview_uc1.Hide();
            task_uc1.Hide();
            effort_uc1.Show();
            effort_uc1.BringToFront();
            effort_uc1.Dock = DockStyle.Fill;
        }

        private void exit_Btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
