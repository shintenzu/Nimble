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
    public partial class EditTask : Form
    {
        public static EditTask instance;
        public Task selectedTask;
        public User oldUser;
        public User newUser;
        public int newCat;
        public int oldCat;
        public EditTask()
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


            if (NimbleApp.main.taskCounter > 0)
            {
                for (int i = 0; i < NimbleApp.main.taskCounter; i++)
                {
                    task_CB.Items.Add("T" + NimbleApp.main.getTask(i).TaskId);
                }
            }
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

        private void assign_CB_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedTask = NimbleApp.main.getTask(task_CB.SelectedIndex);
            ED_RTB.Text = selectedTask.TaskDesc;
            assign_CB.SelectedIndex = selectedTask.UserId;
            category_CB.SelectedIndex = selectedTask.Category;
            StartDate.Value = selectedTask.StartDate;
            DueDate.Value = selectedTask.DueDate;
            
            /*
            if (NimbleApp.main.getTask(task_CB.SelectedIndex).Category == 1)
            {
                category_CB.SelectedText = "1: Requirements Analysis";
            }
            else if (NimbleApp.main.getTask(task_CB.SelectedIndex).Category == 2)
            {
                category_CB.SelectedText = "2: Designing";
            }
            else if (NimbleApp.main.getTask(task_CB.SelectedIndex).Category == 3)
            {
                category_CB.SelectedText = "3: Coding";
            }
            else if (NimbleApp.main.getTask(task_CB.SelectedIndex).Category == 4)
            {
                category_CB.SelectedText = "4: Testing";
            }
            else if (NimbleApp.main.getTask(task_CB.SelectedIndex).Category == 4)
            {
                category_CB.SelectedText = "5: Project Management";
            }
            */

        }

        private void Submit_Btn_Click(object sender, EventArgs e)
        {

            selectedTask = NimbleApp.main.getTask(task_CB.SelectedIndex);
            oldUser = NimbleApp.main.getUser(selectedTask.UserId);
            newUser = NimbleApp.main.getUser(assign_CB.SelectedIndex);
            oldCat = selectedTask.Category;
            newCat = category_CB.SelectedIndex;

            if (StartDate.Value > DueDate.Value)
            {
                MessageBox.Show("Give your team member at least one day to complete their task!");
                return;
            }

            selectedTask.TaskDesc = ED_RTB.Text;
            selectedTask.UserId = assign_CB.SelectedIndex;

            

            if (oldUser != newUser)
            {

                int uIndex = newUser.TaskCounter;

                

                oldUser.removeTask(selectedTask);

                selectedTask.StartDate = StartDate.Value;
                selectedTask.DueDate = DueDate.Value;
                selectedTask.EstEffort = ((selectedTask.DueDate - selectedTask.StartDate).Days + 1) * 5;

                newUser.addTask(uIndex, selectedTask);
                newUser.taskCounter++;
                newUser.UserEffort += selectedTask.EstEffort;
                selectedTask.UserId = newUser.UserId;
                
                //oldUser.UserEffort -= selectedTask.EstEffort;
                //oldUser.taskCounter--;

            }
            if (oldCat != newCat)
            {
                selectedTask.Category = category_CB.SelectedIndex;
                
                if (oldCat == 0)
                {
                    //task1.Category = 0;
                    Stages currentStage = NimbleApp.main.req;
                    currentStage.removeTask(selectedTask);
                    Effort_UC.instance.resetRBindings();
                }
                else if (oldCat == 1)
                {
                    //task1.Category = 1;
                    Stages currentStage = NimbleApp.main.design;
                    currentStage.removeTask(selectedTask);
                    Effort_UC.instance.resetDBindings();
                }
                else if (oldCat == 2)
                {
                    //task1.Category = 2;
                    Stages currentStage = NimbleApp.main.code;
                    currentStage.removeTask(selectedTask);
                    Effort_UC.instance.resetDBindings();
                }
                else if (oldCat == 3)
                {
                    //task1.Category = 3;
                    Stages currentStage = NimbleApp.main.test;
                    currentStage.removeTask(selectedTask);
                    Effort_UC.instance.resetDBindings();
                }
                else if (oldCat == 4)
                {
                    //task1.Category = 4;
                    Stages currentStage = NimbleApp.main.pm;
                    currentStage.removeTask(selectedTask);
                    Effort_UC.instance.resetDBindings();
                }
                
                if (category_CB.GetItemText(category_CB.SelectedItem) == "1: Requirements Analysis")
                    {
                        //task1.Category = 0;
                        Stages currentStage = NimbleApp.main.req;
                        int uIndex = currentStage.taskCounter;
                        currentStage.addTask(uIndex, selectedTask);
                        currentStage.taskCounter++;
                        currentStage.StageEffort += selectedTask.EstEffort;

                        //Effort_UC.instance.receiveR("T" + NimbleApp.main.taskCounter.ToString());
                        Effort_UC.instance.resetRBindings();
                    }
                    else if (category_CB.GetItemText(category_CB.SelectedItem) == "2: Designing")
                    {
                        //task1.Category = 1;
                        Stages currentStage = NimbleApp.main.design;
                        int uIndex = currentStage.taskCounter;
                        currentStage.addTask(uIndex, selectedTask);
                        currentStage.taskCounter++;
                        currentStage.StageEffort += selectedTask.EstEffort;
                        //Effort_UC.instance.receiveD("T" + NimbleApp.main.taskCounter.ToString());
                        Effort_UC.instance.resetDBindings();
                    }
                    else if (category_CB.GetItemText(category_CB.SelectedItem) == "3: Coding")
                    {
                        //task1.Category = 2;
                        Stages currentStage = NimbleApp.main.code;
                        int uIndex = currentStage.taskCounter;
                        currentStage.addTask(uIndex, selectedTask);
                        currentStage.taskCounter++;
                        currentStage.StageEffort += selectedTask.EstEffort;
                        //Effort_UC.instance.receiveC("T" + NimbleApp.main.taskCounter.ToString());
                        Effort_UC.instance.resetCBindings();
                    }
                    else if (category_CB.GetItemText(category_CB.SelectedItem) == "4: Testing")
                    {
                        //task1.Category = 3;
                        Stages currentStage = NimbleApp.main.test;
                        int uIndex = currentStage.taskCounter;
                        currentStage.addTask(uIndex, selectedTask);
                        currentStage.taskCounter++;
                        currentStage.StageEffort += selectedTask.EstEffort;
                        //Effort_UC.instance.receiveT("T" + NimbleApp.main.taskCounter.ToString());
                        Effort_UC.instance.resetTBindings();
                    }
                    else if (category_CB.GetItemText(category_CB.SelectedItem) == "5: Project Management")
                    {
                        //task1.Category = 4;
                        Stages currentStage = NimbleApp.main.pm;
                        int uIndex = currentStage.taskCounter;
                        currentStage.addTask(uIndex, selectedTask);
                        currentStage.taskCounter++;
                        currentStage.StageEffort += selectedTask.EstEffort;
                        //Effort_UC.instance.receivePM("T" + NimbleApp.main.taskCounter.ToString());
                        Effort_UC.instance.resetPMBindings();
                    }
                
            }


            
            this.Close();
        }
    }
}
