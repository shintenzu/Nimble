using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nimble
{
    public partial class Overview_UC : UserControl
    {
        public Overview_UC()
        {
            InitializeComponent();
        }

        private void changedesc_Btn_Click(object sender, EventArgs e)
        {
            EditDesc editDesc = new EditDesc();
            editDesc.StartPosition = FormStartPosition.CenterScreen;
            editDesc.Show();

        }

        private void addteam_Btn_Click(object sender, EventArgs e)
        {
            AddTeam addTeam = new AddTeam();
            addTeam.StartPosition = FormStartPosition.CenterScreen;
            addTeam.Show();
        }

        private void editteam_Btn_Click(object sender, EventArgs e)
        {
            EditTeam editTeam = new EditTeam();
            editTeam.StartPosition = FormStartPosition.CenterScreen;
            editTeam.Show();
        }

        private void editreq_Btn_Click(object sender, EventArgs e)
        {
            EditReq editReq = new EditReq();
            editReq.StartPosition = FormStartPosition.CenterScreen;
            editReq.Show();
        }

        private void addtask_Btn_Click(object sender, EventArgs e)
        {
            AddTask addTask = new AddTask();
            addTask.StartPosition = FormStartPosition.CenterScreen;
            addTask.Show();
        }

        private void edittasks_Btn_Click(object sender, EventArgs e)
        {
            EditTask editTask = new EditTask();
            editTask.StartPosition = FormStartPosition.CenterScreen;
            editTask.Show();
        }
    }
}
