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
    public partial class Login_Form : Form
    {
        public static Login_Form instance;
        public Login_Form()
        {
            InitializeComponent();
            instance = this;
        }
    }
}
