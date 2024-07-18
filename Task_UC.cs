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
    public partial class Task_UC : UserControl
    {
        public static List<String> tasks = new List<String>();
        BindingSource tasksBindingSource = new BindingSource();
        public static Task_UC instance;
        public Task_UC()
        {
            InitializeComponent();
            instance = this;
        }

        public void resetTBindings()
        {
            tasksBindingSource.DataSource = tasks;
            task_LB.DataSource = tasksBindingSource;
            tasksBindingSource.ResetBindings(false);
        }

        public void clearTasks()
        {
            tasks.Clear();
            tasksBindingSource.DataSource = tasks;
            task_LB.DataSource = tasksBindingSource;
            tasksBindingSource.ResetBindings(false);
        }
        public void receiveTask(string newTask)
        {
            tasks.Add(newTask);
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

        private void task_LB_Click(object sender, EventArgs e)
        {
            if (NimbleApp.main.taskCounter > 0)
            {
                TaskID_Label.Text = "Task ID: " + NimbleApp.main.getTask(task_LB.SelectedIndex).TaskId;
                //TD_Label.Text = "Task Description: " + NimbleApp.main.getTask(task_LB.SelectedIndex).TaskDesc;
                TaskDesc_RTB.Text = NimbleApp.main.getTask(task_LB.SelectedIndex).TaskDesc;
                TaskEstEffort_Label.Text = "Task Estimated Effort: " + NimbleApp.main.getTask(task_LB.SelectedIndex).EstEffort + " Person Hours";
                StartDate_Label.Text = "Start Date: " + NimbleApp.main.getTask(task_LB.SelectedIndex).StartDate.ToString();
                DueDate_Label.Text = "Due Date: " + NimbleApp.main.getTask(task_LB.SelectedIndex).DueDate.ToString();
                taskCat_Label.Text = "Category: " + NimbleApp.main.getTask(task_LB.SelectedIndex).CatString();
                assignID_Label.Text = "Assigned to: " + NimbleApp.main.getUser(NimbleApp.main.getTask(task_LB.SelectedIndex).UserId).FullName;
            }
        }
    }
}
