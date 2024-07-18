using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace Nimble
{
    public partial class AddRisk : Form
    {
        public static AddRisk instance;
        public AddRisk()
        {
            InitializeComponent();
            RiskID_TB.Text = NimbleApp.main.riskCounter.ToString();
        }

        private void Cancel_Btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ATNavClose_Btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Submit_Btn_Click(object sender, EventArgs e)
        {
            if (cost_TB.Text == string.Empty)
            {
                MessageBox.Show("Please enter a value to Cost!");
                return;
            }
            //else if (!radioButton1.Checked && !radioButton2.Checked)
            //{
            //    MessageBox.Show("Please check one radio button!");
            //    return;
            //}
            else if (RD_RTB.Text == string.Empty)
            {
                MessageBox.Show("Please enter your risk description");
                return;
            }
            else if (Priority_CB.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a value for Priority!");
                return;
            }
            else if (Probability_CB.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a value for Probability!");
                return;
            }

            else
            {
                Risk risk1 = new Risk();

                risk1.RiskId = NimbleApp.main.riskCounter;
                risk1.RiskDesc = RD_RTB.Text;
                if (Priority_CB.GetItemText(Priority_CB.SelectedItem) == "1: High")
                {
                    risk1.Priority = 1;
                }
                else if (Priority_CB.GetItemText(Priority_CB.SelectedItem) == "2: Medium")
                {
                    risk1.Priority = 2;
                }
                else if (Priority_CB.GetItemText(Priority_CB.SelectedItem) == "3: Low")
                {
                    risk1.Priority = 3;
                }
                else
                {
                    risk1.Priority = 0;
                }

                if (Probability_CB.GetItemText(Probability_CB.SelectedItem) == "10%")
                {
                    risk1.Prob = 0.1;
                }
                else if (Probability_CB.GetItemText(Probability_CB.SelectedItem) == "20%")
                {
                    risk1.Prob = 0.2;
                }
                else if (Probability_CB.GetItemText(Probability_CB.SelectedItem) == "30%")
                {
                    risk1.Prob = 0.3;
                }
                else if (Probability_CB.GetItemText(Probability_CB.SelectedItem) == "40%")
                {
                    risk1.Prob = 0.4;
                }
                else if (Probability_CB.GetItemText(Probability_CB.SelectedItem) == "50%")
                {
                    risk1.Prob = 0.5;
                }
                else if (Probability_CB.GetItemText(Probability_CB.SelectedItem) == "60%")
                {
                    risk1.Prob = 0.6;
                }
                else if (Probability_CB.GetItemText(Probability_CB.SelectedItem) == "70%")
                {
                    risk1.Prob = 0.7;
                }
                else if (Probability_CB.GetItemText(Probability_CB.SelectedItem) == "70%")
                {
                    risk1.Prob = 0.7;
                }
                else if (Probability_CB.GetItemText(Probability_CB.SelectedItem) == "80%")
                {
                    risk1.Prob = 0.8;
                }
                else if (Probability_CB.GetItemText(Probability_CB.SelectedItem) == "90%")
                {
                    risk1.Prob = 0.9;
                }
                else if (Probability_CB.GetItemText(Probability_CB.SelectedItem) == "100%")
                {
                    risk1.Prob = 1.0;
                }
                else
                {
                    risk1.Prob = 0.0;
                }

                risk1.Cost = Int64.Parse(cost_TB.Text);

                risk1.RValue = (risk1.Prob) * (risk1.Cost);


                NimbleApp.main.addRisk(NimbleApp.main.riskCounter, risk1);
                Risk_UC.instance.receiveRisk("R" + NimbleApp.main.riskCounter.ToString());
                Risk_UC.instance.resetRBindings();


                NimbleApp.main.riskCounter++;

                this.Close();
            }
            


        }

        private void cost_TB_KeyPress(object sender, KeyPressEventArgs e)
        {
            var regex = new Regex(@"[^0-9]");

            if (regex.IsMatch(e.KeyChar.ToString()))
            {
                e.Handled = true;
            }
        }
           
    }
}
