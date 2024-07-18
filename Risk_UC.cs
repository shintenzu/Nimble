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
    public partial class Risk_UC : UserControl
    {
        public static List<String> risks = new List<String>();
        BindingSource risksBindingSource = new BindingSource();
        public static Risk_UC instance;
        public Risk_UC()
        {
            InitializeComponent();
            instance = this;
            EditRisks_Btn.Hide();
        }

        public void resetRBindings()
        {
            risksBindingSource.DataSource = risks;
            risk_LB.DataSource = risksBindingSource;
            risksBindingSource.ResetBindings(false);
        }

        public void clearRisks()
        {
            risks.Clear();
            risksBindingSource.DataSource = risks;
            risk_LB.DataSource = risksBindingSource;
            risksBindingSource.ResetBindings(false);
        }
        public void receiveRisk(string newRisk)
        {
            risks.Add(newRisk);
        }

        private void AddRisk_Btn_Click(object sender, EventArgs e)
        {
            AddRisk addRisk = new AddRisk();
            addRisk.StartPosition = FormStartPosition.CenterScreen;
            addRisk.Show();
        }

        private void EditRisks_Btn_Click(object sender, EventArgs e)
        {

        }

        private void risk_LB_Click(object sender, EventArgs e)
        {
            if (NimbleApp.main.riskCounter > 0)
            {
                RidkID_Label.Text = "Risk ID: " + NimbleApp.main.getRisk(risk_LB.SelectedIndex).RiskId;
                //TD_Label.Text = "Task Description: " + NimbleApp.main.getTask(task_LB.SelectedIndex).TaskDesc;
                RiskDesc_RTB.Text = NimbleApp.main.getRisk(risk_LB.SelectedIndex).RiskDesc;
                RiskMit_RTB.Text = NimbleApp.main.getRisk(risk_LB.SelectedIndex).Mitigation;
                RiskPri_Label.Text = "Risk Priority: " + NimbleApp.main.getRisk(risk_LB.SelectedIndex).Priority;
                RiskProb_Label.Text = "Risk Probability: " + NimbleApp.main.getRisk(risk_LB.SelectedIndex).Prob;
                RiskCost_Label.Text = "Risk Cost: $" + NimbleApp.main.getRisk(risk_LB.SelectedIndex).Cost;
                RiskValue_Label.Text = "Risk Value: $" + NimbleApp.main.getRisk(risk_LB.SelectedIndex).RValue;
            }
        }
    }
}
