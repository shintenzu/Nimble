using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Nimble
{
    public partial class AddTask : Form
    {
        public static AddTask instance;
        //private DateTimePicker start = new DateTimePicker();
        //private DateTimePicker due = new DateTimePicker();
        private DateTime start = new DateTime();
        private DateTime due = new DateTime();
        public AddTask()
        {
            InitializeComponent();
            instance = this;
            taskID.Text = NimbleApp.main.taskCounter.ToString();
            if (NimbleApp.main.teamCounter > 0)
            {
                for (int i = 0; i < NimbleApp.main.teamCounter; i++)
                {
                    assign_CB.Items.Add(NimbleApp.main.getUser(i).FullName);
                }
            }
        }

        private void ATNavClose_Btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Cancel_Btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Submit_Btn_Click(object sender, EventArgs e)
        {
            Task task1 = new Task();
            //start = StartDate.Value;
            task1.StartDate = StartDate.Value;
            task1.DueDate = DueDate.Value;


            task1.TaskId = NimbleApp.main.taskCounter;
            task1.TaskDesc = ED_RTB.Text;

            NimbleApp.main.addTask(NimbleApp.main.taskCounter, task1);
            Overview_UC.instance.receiveTask("T" + NimbleApp.main.taskCounter.ToString());
            Overview_UC.instance.resetTBindings();
            Task_UC.instance.receiveTask("T" + NimbleApp.main.taskCounter.ToString());
            Task_UC.instance.resetTBindings();

            if (assign_CB.SelectedIndex > -1)
            {
                User currentUser = NimbleApp.main.getUser(assign_CB.SelectedIndex);
                int uIndex = currentUser.TaskCounter;
                currentUser.addTask(uIndex, task1);
                currentUser.taskCounter++;
                //Adding Task to selected user
                //NimbleApp.main.getUser(assign_CB.SelectedIndex).addTask(NimbleApp.main.getUser(assign_CB.SelectedIndex).taskCounter, task1);
                //assign_CB.Items[assign_CB.SelectedIndex];
                //NimbleApp.main.getUser(assign_CB.SelectedIndex).taskCounter++;
            }

            NimbleApp.main.taskCounter++;
            
            this.Close();
        }
    }
}
