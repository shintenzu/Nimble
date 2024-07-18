using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nimble
{
    
    public partial class AddTeam : Form
    {
        
        public static AddTeam instance;
        public AddTeam()
        {
            InitializeComponent();
            instance = this;
            userID_TB.Text = NimbleApp.main.teamCounter.ToString(); ;
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
            if (FullName_TB.Text == string.Empty)
            {
                MessageBox.Show("Please enter your team member's Name!");
                return;
            }


            else if (Role_CB.SelectedIndex == -1)
            {
                MessageBox.Show("Please select your team member's role!");
                return;
            }
            else if ((Role_CB.GetItemText(Role_CB.SelectedItem) == "1: Project Owner") && (NimbleApp.main.hasLeader == true))
            {
                MessageBox.Show("You already have a project owner");
                return;
            }
            else if ((Role_CB.GetItemText(Role_CB.SelectedItem) == "2: Project Manager") && (NimbleApp.main.hasManager == true))
            {
                MessageBox.Show("You already have a project manager");
                return;
            }

            else
            {

                User user1 = new User();

                user1.UserId = NimbleApp.main.teamCounter;
                user1.FullName = FullName_TB.Text;

                if (Role_CB.GetItemText(Role_CB.SelectedItem) == "1: Project Owner")
                {
                    user1.RoleId = 1;
                    NimbleApp.instance.PO_Label.Text = "Project Owner: " +FullName_TB.Text;
                    NimbleApp.main.hasLeader = true;
                }
                else if (Role_CB.GetItemText(Role_CB.SelectedItem) == "2: Project Manager")
                {
                    user1.RoleId = 2;
                    NimbleApp.instance.PM_Label.Text = "Project Manager: " + FullName_TB.Text;
                    NimbleApp.main.hasManager = true;
                }
                else if (Role_CB.GetItemText(Role_CB.SelectedItem) == "3: Designer")
                {
                    user1.RoleId = 3;                  
                }
                else if (Role_CB.GetItemText(Role_CB.SelectedItem) == "4: Coder")
                {
                    user1.RoleId = 4;
                }

                //1: Project Owner
                //2: Project Manager
                //3: Designer
                //4: Coder


                NimbleApp.main.addUser(NimbleApp.main.teamCounter, user1);
                NimbleApp.main.teamCounter++;
                Overview_UC.instance.receiveUser(FullName_TB.Text);
                Overview_UC.instance.resetNBindings();
                Team_UC.instance.receiveUser(FullName_TB.Text);
                Team_UC.instance.resetNBindings();


                this.Close();
            }
        }
    }
}
