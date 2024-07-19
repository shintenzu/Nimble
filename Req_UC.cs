using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TrackBar;

namespace Nimble
{
    public partial class Req_UC : UserControl
    {
        public static List<String> reqs = new List<String>();
        BindingSource reqsBindingSource = new BindingSource();
        public static Req_UC instance;
        public Req_UC()
        {
            InitializeComponent();
            instance = this;
            EditReq_Btn.Hide();
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

        private void reqs_LB_Click(object sender, EventArgs e)
        {
            if (NimbleApp.main.reqCounter > 0)
            {
                ReqID_Label.Text = "Requirements ID: " + NimbleApp.main.getReq(reqs_LB.SelectedIndex).ReqId;
                ReqDesc_RTB.Text = NimbleApp.main.getReq(reqs_LB.SelectedIndex).ReqDesc;
                ReqCat_Label.Text = "Requirements Type: " + NimbleApp.main.getReq(reqs_LB.SelectedIndex).getType();

            }
        }

        private void AddReq_Btn_Click(object sender, EventArgs e)
        {
            AddReq addReq = new AddReq();
            addReq.StartPosition = FormStartPosition.CenterScreen;
            addReq.Show();
        }

        private void EditReq_Btn_Click(object sender, EventArgs e)
        {

        }
    }
}
