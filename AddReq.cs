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
    public partial class AddReq : Form
    {
        public AddReq()
        {
            InitializeComponent();
            Req_TB.Text = NimbleApp.main.reqCounter.ToString();
        }

        private void NavClose_Btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Cancel_Btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Submit_Btn_Click(object sender, EventArgs e)
        {
            if (RD_RTB.Text == string.Empty)
            {
                MessageBox.Show("Please enter your requirement description");
                return;
            }
            else if (Category_CB.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a requirement type!");
                return;
            }
          
            else
            {
                Req req1 = new Req();

                req1.ReqId = NimbleApp.main.reqCounter;
                req1.ReqDesc = RD_RTB.Text;
                req1.Category = Category_CB.SelectedIndex;






                NimbleApp.main.addReq(NimbleApp.main.reqCounter, req1);
                Req_UC.instance.receiveReq("Requirement " + NimbleApp.main.reqCounter.ToString());
                Req_UC.instance.resetRBindings();
                Overview_UC.instance.receiveReq("Requirement " + NimbleApp.main.reqCounter.ToString());
                Overview_UC.instance.resetRBindings();


                NimbleApp.main.reqCounter++;

                this.Close();
            }

            this.Close();
        }
    }
}
