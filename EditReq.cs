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
    public partial class EditReq : Form
    {
        public static EditReq instance;
        public EditReq()
        {
            InitializeComponent();
            instance = this;
            //RTB.Text = Overview_UC.instance.getReq();
            RTB.Text = NimbleApp.main.Requirements;
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
            Overview_UC.instance.setReq(RTB.Text);
            NimbleApp.main.Requirements = RTB.Text;
            this.Close();
        }
    }
}
