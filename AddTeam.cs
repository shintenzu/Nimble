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
            User user1 = new User();
            
            user1.UserId = NimbleApp.main.teamCounter;
            user1.FullName = FullName_TB.Text;
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
