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
    public partial class EditTeam : Form
    {
        public static EditTeam instance;
        public User selectedUser;
        public EditTeam()
        {
            InitializeComponent();
            instance = this;

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
            selectedUser = NimbleApp.main.getUser(assign_CB.SelectedIndex);
            FullName_TB.Text = selectedUser.FullName;
            //assign_CB.SelectedIndex = selectedTask.UserId;
            Role_CB.SelectedIndex = selectedUser.RoleId;
        }

        private void Submit_Btn_Click(object sender, EventArgs e)
        {
            
            selectedUser = NimbleApp.main.getUser(assign_CB.SelectedIndex);
            int oldRole = selectedUser.RoleId;
            int newRole = Role_CB.SelectedIndex;

            if (oldRole != newRole)
            {
                if (newRole == 0 && NimbleApp.main.hasLeader == true)
                {
                    MessageBox.Show("You already have a project owner");
                    return;
                }
                else if (newRole == 0 && NimbleApp.main.hasLeader == false)
                {
                    if (oldRole == 1)
                    {
                        selectedUser.RoleId = Role_CB.SelectedIndex;
                        NimbleApp.main.hasLeader = true;
                        NimbleApp.main.hasManager = false;
                        NimbleApp.instance.PO_Label.Text = "Project Owner: " + FullName_TB.Text;
                        NimbleApp.instance.PM_Label.Text = "Project Manager: NA (Add A Project Manager)";
                    }
                    else
                    {
                        selectedUser.RoleId = Role_CB.SelectedIndex;
                        NimbleApp.main.hasLeader = true;
                        NimbleApp.instance.PO_Label.Text = "Project Owner: " + FullName_TB.Text;
                    }
                    
                }

                if (newRole == 1 && NimbleApp.main.hasManager == true)
                {
                    MessageBox.Show("You already have a project manager");
                    return;
                }
                else if (newRole == 1 && NimbleApp.main.hasManager == false)
                {
                    if (oldRole == 0)
                    {
                        selectedUser.RoleId = Role_CB.SelectedIndex;
                        NimbleApp.main.hasManager = true;
                        NimbleApp.main.hasLeader = false;
                        NimbleApp.instance.PM_Label.Text = "Project Manager: " + FullName_TB.Text;
                        NimbleApp.instance.PO_Label.Text = "Project Owner: NA (Add A Project Owner)";
                    }
                    else
                    {
                        selectedUser.RoleId = Role_CB.SelectedIndex;
                        NimbleApp.main.hasManager = true;
                        NimbleApp.instance.PM_Label.Text = "Project Manager: " + FullName_TB.Text;
                    }

                }
            }

            selectedUser.FullName = FullName_TB.Text;

            Overview_UC.instance.resetUsers();
            Team_UC.instance.resetUsers();
            this.Close();



        }
    }
}
