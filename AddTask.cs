using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.Linq;
using System.Reflection;
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

            //StartDate.ShowUpDown = true;
            StartDate.Format = DateTimePickerFormat.Custom;
            //StartDate.CustomFormat = "MM/dd/yyyy hh:mm:ss";
            StartDate.CustomFormat = "MM/dd/yyyy";
            //DueDate.ShowUpDown = true;
            DueDate.Format = DateTimePickerFormat.Custom;
            DueDate.CustomFormat = "MM/dd/yyyy";


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
            if (ED_RTB.Text == string.Empty)
            {
                MessageBox.Show("Please enter your task description!");
                return;
            }
          

            else if (assign_CB.SelectedIndex == -1)
            {
                MessageBox.Show("Please assign your task to someone!");
                return;
            }
            else if (category_CB.SelectedIndex == -1)
            {
                MessageBox.Show("Please give your task a category!");
                return;
            }
            else if (StartDate.Value > DueDate.Value)
            {
                MessageBox.Show("Give your team member at least one day to complete their task!");
                return;
            }

            else
            {
                Task task1 = new Task();
                //start = StartDate.Value;
                task1.StartDate = StartDate.Value;
                task1.DueDate = DueDate.Value;



                task1.EstEffort = ((task1.DueDate - task1.StartDate).Days + 1) * 5;


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
                    currentUser.UserEffort += task1.EstEffort;
                    task1.UserId = currentUser.UserId;
                    task1.Category = category_CB.SelectedIndex;

                }

                if (category_CB.GetItemText(category_CB.SelectedItem) == "1: Requirements Analysis")
                {
                    //task1.Category = 0;
                    Stages currentStage = NimbleApp.main.req;
                    int uIndex = currentStage.taskCounter;
                    currentStage.addTask(uIndex, task1);
                    currentStage.taskCounter++;
                    currentStage.StageEffort += task1.EstEffort;
                    
                    //Effort_UC.instance.receiveR("T" + NimbleApp.main.taskCounter.ToString());
                    Effort_UC.instance.resetRBindings();
                }
                else if (category_CB.GetItemText(category_CB.SelectedItem) == "2: Designing")
                {
                    //task1.Category = 1;
                    Stages currentStage = NimbleApp.main.design;
                    int uIndex = currentStage.taskCounter;
                    currentStage.addTask(uIndex, task1);
                    currentStage.taskCounter++;
                    currentStage.StageEffort += task1.EstEffort;
                    //Effort_UC.instance.receiveD("T" + NimbleApp.main.taskCounter.ToString());
                    Effort_UC.instance.resetDBindings();
                }
                else if (category_CB.GetItemText(category_CB.SelectedItem) == "3: Coding")
                {
                    //task1.Category = 2;
                    Stages currentStage = NimbleApp.main.code;
                    int uIndex = currentStage.taskCounter;
                    currentStage.addTask(uIndex, task1);
                    currentStage.taskCounter++;
                    currentStage.StageEffort += task1.EstEffort;
                    //Effort_UC.instance.receiveC("T" + NimbleApp.main.taskCounter.ToString());
                    Effort_UC.instance.resetCBindings();
                }
                else if (category_CB.GetItemText(category_CB.SelectedItem) == "4: Testing")
                {
                    //task1.Category = 3;
                    Stages currentStage = NimbleApp.main.test;
                    int uIndex = currentStage.taskCounter;
                    currentStage.addTask(uIndex, task1);
                    currentStage.taskCounter++;
                    currentStage.StageEffort += task1.EstEffort;
                    //Effort_UC.instance.receiveT("T" + NimbleApp.main.taskCounter.ToString());
                    Effort_UC.instance.resetTBindings();
                }
                else if (category_CB.GetItemText(category_CB.SelectedItem) == "5: Project Management")
                {
                    //task1.Category = 4;
                    Stages currentStage = NimbleApp.main.pm;
                    int uIndex = currentStage.taskCounter;
                    currentStage.addTask(uIndex, task1);
                    currentStage.taskCounter++;
                    currentStage.StageEffort += task1.EstEffort;
                    //Effort_UC.instance.receivePM("T" + NimbleApp.main.taskCounter.ToString());
                    Effort_UC.instance.resetPMBindings();
                }

                //1: Requirements Analysis
                //2: Designing
                //3: Coding
                //4: Testing
                //5: Project Management

                NimbleApp.main.taskCounter++;

                this.Close();
            }
        }
    }
}
