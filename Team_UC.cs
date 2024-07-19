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
    public partial class Team_UC : UserControl
    {
        public static List<String> names = new List<String>();
        BindingSource namesBindingSource = new BindingSource();
        public static List<String> utasks = new List<String>();
        BindingSource utasksBindingSource = new BindingSource();
        public static Team_UC instance;
        public Team_UC()
        {
            InitializeComponent();
            instance = this;
        }

        public void receiveUser(string newUser)
        {
            names.Add(newUser);
        }

        public void receiveUTask(string newTask)
        {
            utasks.Add(newTask);
        }

        public void clearUTasks()
        {
            utasks.Clear();
            utasksBindingSource.DataSource = utasks;
            UTL_LB.DataSource = utasksBindingSource;
            utasksBindingSource.ResetBindings(false);
        }

        public void clearUsers()
        {
            names.Clear();
            namesBindingSource.DataSource = names;
            user_LB.DataSource = namesBindingSource;
            namesBindingSource.ResetBindings(false);
        }

        public void resetUsers()
        {
            names.Clear();

            if (NimbleApp.main.teamCounter > 0)
            {
                for (int i = 0; i < NimbleApp.main.teamCounter; i++)
                {
                    names.Add(NimbleApp.main.getUser(i).FullName);
                }
            }

            namesBindingSource.DataSource = names;
            user_LB.DataSource = namesBindingSource;
            namesBindingSource.ResetBindings(false);
        }

        public void resetUTBindings()
        {
            utasksBindingSource.DataSource = utasks;
            UTL_LB.DataSource = utasksBindingSource;
            utasksBindingSource.ResetBindings(false);
        }
        public void resetNBindings()
        {
            namesBindingSource.DataSource = names;
            user_LB.DataSource = namesBindingSource;
            namesBindingSource.ResetBindings(false);
        }


        private void user_LB_Click(object sender, EventArgs e)
        {
            if (NimbleApp.main.teamCounter > 0)
            {
                clearUTasks();
                UserID_Label.Text = "ID: " + NimbleApp.main.getUser(user_LB.SelectedIndex).UserId;
                TeamName_Label.Text = "Name: " + NimbleApp.main.getUser(user_LB.SelectedIndex).FullName;
                uTaskCount_Label.Text = "Task Count: " + NimbleApp.main.getUser(user_LB.SelectedIndex).TaskCounter;
                UserEffort_Label.Text = "User Effort: " + NimbleApp.main.getUser(user_LB.SelectedIndex).UserEffort + " Person Hours";
                UserRole_Label.Text = "User Role: " + NimbleApp.main.getUser(user_LB.SelectedIndex).getRole();

                if (NimbleApp.main.getUser(user_LB.SelectedIndex).taskCounter > 0)
                {
                    for (int i = 0; i < NimbleApp.main.getUser(user_LB.SelectedIndex).taskCounter; i++)
                    {
                        utasks.Add("T" + NimbleApp.main.getUser(user_LB.SelectedIndex).getTask(i).TaskId.ToString());
                    }
                }

                resetUTBindings();

            }
        }

        private void UTL_LB_Click(object sender, EventArgs e)
        {
            if (NimbleApp.main.getUser(user_LB.SelectedIndex).taskCounter > 0)
            {
                TaskID_Label.Text = "Task ID: " + NimbleApp.main.getUser(user_LB.SelectedIndex).getTask(UTL_LB.SelectedIndex).TaskId;
                TD_Label.Text = "Task Description: " + NimbleApp.main.getUser(user_LB.SelectedIndex).getTask(UTL_LB.SelectedIndex).TaskDesc;
            }
        }

        private void addteam_Btn_Click(object sender, EventArgs e)
        {
            AddTeam addTeam = new AddTeam();
            addTeam.StartPosition = FormStartPosition.CenterScreen;
            addTeam.Show();
        }

        private void editteam_Btn_Click(object sender, EventArgs e)
        {
            if (NimbleApp.main.teamCounter == 0)
            {
                MessageBox.Show("You need at least 1 team member to edit!");
                return;
            }
            else
            {
                EditTeam editTeam = new EditTeam();
                editTeam.StartPosition = FormStartPosition.CenterScreen;
                editTeam.Show();
            }
        }
    }
}
