namespace Nimble
{
    public partial class NimbleApp : Form
    {
        public static Project main;
        public static NimbleApp instance;

        public NimbleApp()
        {

            int projectCounter = 1;
            int currentProject = 1;
            main = new Project(projectCounter);
            projectCounter++;
            InitializeComponent();
            instance = this;
            navclose_Btn.Hide();
            selectproject_Btn.Hide();
            projectselect_Cbox.Hide();
            back_Btn.Hide();


        }

        private void Nimble_Load(object sender, EventArgs e)
        {
            task_uc1.Hide();
            team_uc1.Hide();
            effort_uc1.Hide();
            risk_uc1.Hide();
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
            risk_uc1.Hide();
            overview_uc1.Show();
            overview_uc1.BringToFront();
            overview_uc1.Dock = DockStyle.Fill;
        }

        private void team_Btn_Click(object sender, EventArgs e)
        {
            task_uc1.Hide();
            overview_uc1.Hide();
            effort_uc1.Hide();
            risk_uc1.Hide();
            team_uc1.Show();
            team_uc1.BringToFront();
            team_uc1.Dock = DockStyle.Fill;
        }

        private void tasks_Btn_Click(object sender, EventArgs e)
        {
            team_uc1.Hide();
            overview_uc1.Hide();
            effort_uc1.Hide();
            risk_uc1.Hide();
            task_uc1.Show();
            task_uc1.BringToFront();
            task_uc1.Dock = DockStyle.Fill;
        }

        private void effort_Btn_Click(object sender, EventArgs e)
        {
            team_uc1.Hide();
            overview_uc1.Hide();
            task_uc1.Hide();
            risk_uc1.Hide();
            effort_uc1.Show();
            effort_uc1.BringToFront();
            effort_uc1.Dock = DockStyle.Fill;
        }

        private void exit_Btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void risk_Btn_Click(object sender, EventArgs e)
        {
            team_uc1.Hide();
            overview_uc1.Hide();
            task_uc1.Hide();
            effort_uc1.Hide();
            risk_uc1.Show();
            risk_uc1.BringToFront();
            risk_uc1.Dock = DockStyle.Fill;
        }
    }
}
