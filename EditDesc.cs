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
    public partial class EditDesc : Form
    {
        public static EditDesc instance;
        //public static string Desc = string.Empty;
        public EditDesc()
        {
            InitializeComponent();
            instance = this;
            NimbleApp.main.Description = ED_RTB.Text;
            //ED_RTB.Text = Overview_UC.instance.getDesc();
        }

        private void EDNavClose_Btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Cancel_Btn_Click(object sender, EventArgs e)
        {
            this.Close();
            ED_RTB.Text = string.Empty;

        }

        private void EDSubmit_Btn_Click(object sender, EventArgs e)
        {
            Overview_UC.instance.setDesc(ED_RTB.Text);
            NimbleApp.main.Description = ED_RTB.Text;
            this.Close(); 
        }
    }
}
