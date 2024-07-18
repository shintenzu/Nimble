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
    public partial class Effort_UC : UserControl
    {
        public static List<String> r = new List<String>();
        BindingSource rBindingSource = new BindingSource();
        public static List<String> d = new List<String>();
        BindingSource dBindingSource = new BindingSource();
        public static List<String> c = new List<String>();
        BindingSource cBindingSource = new BindingSource();
        public static List<String> t = new List<String>();
        BindingSource tBindingSource = new BindingSource();
        public static List<String> pm = new List<String>();
        BindingSource pmBindingSource = new BindingSource();

        public static Effort_UC instance;
        public Effort_UC()
        {
            InitializeComponent();
            instance = this;
        }

        public void receiveR(string newTask)
        {
            r.Add(newTask);
        }
        public void receiveD(string newTask)
        {
            d.Add(newTask);
        }
        public void receiveC(string newTask)
        {
            c.Add(newTask);
        }
        public void receiveT(string newTask)
        {
            t.Add(newTask);
        }
        public void receivePM(string newTask)
        {
            pm.Add(newTask);
        }

        public void clearR()
        {
            r.Clear();
            rBindingSource.DataSource = r;
            R_LB.DataSource = rBindingSource;
            rBindingSource.ResetBindings(false);
        }

        public void clearD()
        {
            d.Clear();
            dBindingSource.DataSource = d;
            D_LB.DataSource = dBindingSource;
            dBindingSource.ResetBindings(false);
        }

        public void clearC()
        {
            c.Clear();
            cBindingSource.DataSource = c;
            C_LB.DataSource = cBindingSource;
            cBindingSource.ResetBindings(false);
        }

        public void clearT()
        {
            t.Clear();
            tBindingSource.DataSource = t;
            T_LB.DataSource = tBindingSource;
            tBindingSource.ResetBindings(false);
        }
        public void clearPM()
        {
            pm.Clear();
            pmBindingSource.DataSource = pm;
            PM_LB.DataSource = pmBindingSource;
            pmBindingSource.ResetBindings(false);
        }

        public void resetRBindings()
        {
            if (NimbleApp.main.req.taskCounter > 0)
            {
                clearR();
                for (int i = 0; i < NimbleApp.main.req.taskCounter; i++)
                {
                    r.Add("T" + NimbleApp.main.req.getTask(i).TaskId.ToString());
                }
            }
            rBindingSource.DataSource = r;
            R_LB.DataSource = rBindingSource;
            rBindingSource.ResetBindings(false);
            REffort_Label.Text = "Effort: " + NimbleApp.main.req.StageEffort + " Person Hours";
            
        }

        public void resetDBindings()
        {
            if (NimbleApp.main.design.taskCounter > 0)
            {
                clearD();
                for (int i = 0; i < NimbleApp.main.design.taskCounter; i++)
                {
                    d.Add("T" + NimbleApp.main.design.getTask(i).TaskId.ToString());
                }
            }
            dBindingSource.DataSource = d;
            D_LB.DataSource = dBindingSource;
            dBindingSource.ResetBindings(false);
            DEffort_Label.Text = "Effort: " + NimbleApp.main.design.StageEffort + " Person Hours";
        }
        public void resetCBindings()
        {
            if (NimbleApp.main.code.taskCounter > 0)
            {
                clearC();
                for (int i = 0; i < NimbleApp.main.code.taskCounter; i++)
                {
                    c.Add("T" + NimbleApp.main.code.getTask(i).TaskId.ToString());
                }
            }
            cBindingSource.DataSource = c;
            C_LB.DataSource = cBindingSource;
            cBindingSource.ResetBindings(false);
            CEffort_Label.Text = "Effort: " + NimbleApp.main.code.StageEffort + " Person Hours";
        }
        public void resetTBindings()
        {
            if (NimbleApp.main.test.taskCounter > 0)
            {
                clearT();
                for (int i = 0; i < NimbleApp.main.test.taskCounter; i++)
                {
                    t.Add("T" + NimbleApp.main.test.getTask(i).TaskId.ToString());
                }
            }
            tBindingSource.DataSource = t;
            T_LB.DataSource = tBindingSource;
            tBindingSource.ResetBindings(false);
            TEffort_Label.Text = "Effort: " + NimbleApp.main.test.StageEffort + " Person Hours";
        }
        public void resetPMBindings()
        {
            if (NimbleApp.main.pm.taskCounter > 0)
            {
                clearPM();
                for (int i = 0; i < NimbleApp.main.pm.taskCounter; i++)
                {
                    pm.Add("T" + NimbleApp.main.pm.getTask(i).TaskId.ToString());
                }
            }
            pmBindingSource.DataSource = pm;
            PM_LB.DataSource = pmBindingSource;
            pmBindingSource.ResetBindings(false);
            PMEffort_Label.Text = "Effort: " + NimbleApp.main.pm.StageEffort + " Person Hours";
        }
    }
}
