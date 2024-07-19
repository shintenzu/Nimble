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
        //public string[] description;
        public static Overview_UC instance;
        public static List<String> names = new List<String>();
        BindingSource namesBindingSource = new BindingSource();
        public static List<String> utasks = new List<String>();
        BindingSource utasksBindingSource = new BindingSource();
        public static List<String> tasks = new List<String>();
        BindingSource tasksBindingSource = new BindingSource();
        public static List<String> reqs = new List<String>();
        BindingSource reqsBindingSource = new BindingSource();

        public Overview_UC()
        {
            InitializeComponent();
            instance = this;

        }

        public void resetRBindings()
        {
            reqsBindingSource.DataSource = reqs;
            reqs_LB.DataSource = reqsBindingSource;
            reqsBindingSource.ResetBindings(false);
        }

        public void clearReq()
        {
            reqs.Clear();
            reqsBindingSource.DataSource = reqs;
            reqs_LB.DataSource = reqsBindingSource;
            reqsBindingSource.ResetBindings(false);
        }
        public void receiveReq(string newReq)
        {
            reqs.Add(newReq);
        }

        public void resetNBindings()
        {
            namesBindingSource.DataSource = names;
            user_LB.DataSource = namesBindingSource;
            namesBindingSource.ResetBindings(false);
        }
        public void resetTBindings()
        {
            tasksBindingSource.DataSource = tasks;
            task_LB.DataSource = tasksBindingSource;
            tasksBindingSource.ResetBindings(false);
        }

        public void resetUTBindings()
        {
            utasksBindingSource.DataSource = utasks;
            UTL_LB.DataSource = utasksBindingSource;
            utasksBindingSource.ResetBindings(false);
        }

        public void clearTasks()
        {
            tasks.Clear();
            tasksBindingSource.DataSource = tasks;
            task_LB.DataSource = tasksBindingSource;
            tasksBindingSource.ResetBindings(false);
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




        public void receiveUser(string newUser)
        {
            names.Add(newUser);
        }

        public void receiveUTask(string newTask)
        {
            utasks.Add(newTask);
        }
        public void receiveTask(string newTask)
        {
            tasks.Add(newTask);
        }


        public void setDesc(string input)
        {
            Desc_RTB.Text = input;
        }
        public string getDesc() { return Desc_RTB.Text; }


        /*
        public void setReq(string input)
        {
            req_RTB.Text = input;
        }
        public string getReq() { return req_RTB.Text; }
        */

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

        private void editreq_Btn_Click(object sender, EventArgs e)
        {
            EditReq editReq = new EditReq();
            editReq.StartPosition = FormStartPosition.CenterScreen;
            editReq.Show();
        }

        private void addtask_Btn_Click(object sender, EventArgs e)
        {
            if (NimbleApp.main.teamCounter == 0)
            {
                MessageBox.Show("You need at least 1 team member to create a task!");
                return;
            }
            else
            {
                AddTask addTask = new AddTask();
                addTask.StartPosition = FormStartPosition.CenterScreen;
                addTask.Show();
            }
        }

        private void edittasks_Btn_Click(object sender, EventArgs e)
        {
            if (NimbleApp.main.taskCounter == 0)
            {
                MessageBox.Show("You need at least 1 task to edit!");
                return;
            }
            else
            {
                EditTask editTask = new EditTask();
                editTask.StartPosition = FormStartPosition.CenterScreen;
                editTask.Show();
            }
        }

        private void overviewbody_Panel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Overview_UC_Load(object sender, EventArgs e)
        {

            if (NimbleApp.main.teamCounter > 0)
            {
                for (int i = 0; i < NimbleApp.main.teamCounter; i++)
                {
                    names.Add(NimbleApp.main.getUser(i).FullName);
                }
            }

            if (NimbleApp.main.taskCounter > 0)
            {
                for (int i = 0; i < NimbleApp.main.taskCounter; i++)
                {
                    tasks.Add("T" + NimbleApp.main.getTask(i).TaskId.ToString());
                }
            }

            resetNBindings();
            resetTBindings();
            resetUTBindings();

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



        private void task_LB_Click(object sender, EventArgs e)
        {
            if (NimbleApp.main.taskCounter > 0)
            {
                TaskID_Label.Text = "Task ID: " + NimbleApp.main.getTask(task_LB.SelectedIndex).TaskId;
                //TD_Label.Text = "Task Description: " + NimbleApp.main.getTask(task_LB.SelectedIndex).TaskDesc;
                TaskDesc_RTB.Text = NimbleApp.main.getTask(task_LB.SelectedIndex).TaskDesc;
                TaskEstEffort_Label.Text = "Task Estimated Effort: " + NimbleApp.main.getTask(task_LB.SelectedIndex).EstEffort + " Person Hours";
                StartDate_Label.Text = "Start Date: " + NimbleApp.main.getTask(task_LB.SelectedIndex).StartDate.ToString("MM/dd/yyyy");
                DueDate_Label.Text = "Due Date: " + NimbleApp.main.getTask(task_LB.SelectedIndex).DueDate.ToString("MM/dd/yyyy");
                taskCat_Label.Text = "Category: " + NimbleApp.main.getTask(task_LB.SelectedIndex).CatString();
                assignID_Label.Text = "Assigned to: " + NimbleApp.main.getUser(NimbleApp.main.getTask(task_LB.SelectedIndex).UserId).FullName;
                TaskStatus_Label.Text = "Status: " + NimbleApp.main.getTask(task_LB.SelectedIndex).getStatus();
            }
        }

        private void user_LB_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void AddReq_Btn_Click(object sender, EventArgs e)
        {
            AddReq addReq = new AddReq();
            addReq.StartPosition = FormStartPosition.CenterScreen;
            addReq.Show();
        }

        private void reqs_LB_Click(object sender, EventArgs e)
        {
            if (NimbleApp.main.reqCounter > 0)
            {
                ReqID_Label.Text = "Requirements ID: " + NimbleApp.main.getReq(reqs_LB.SelectedIndex).ReqId;
                ReqDesc_RTB.Text = NimbleApp.main.getReq(reqs_LB.SelectedIndex).ReqDesc;
                ReqCat_Label.Text = "Type: " + NimbleApp.main.getReq(reqs_LB.SelectedIndex).getType();

            }
        }
    }
}
