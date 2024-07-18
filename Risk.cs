using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nimble
{
    public class Risk
    {
        private int riskId;
        private string riskDesc;
        private int priority;
        private double prob;
        private double cost;
        private double rValue;

        public Risk() { }

        public Risk(int riskId)
        {
            this.riskId = riskId;
        }

        public int RiskId
        {
            get { return riskId; }
            set { this.riskId = value; }
        }

        public string RiskDesc
        {
            get { return riskDesc; }
            set { this.riskDesc = value; }
        }
        public int Priority
        {
            get { return priority; }
            set { this.priority = value; }
        }
        public double Prob
        {
            get { return prob; }
            set { this.prob = value; }
        }

        public double Cost
        {
            get { return cost; }
            set { this.cost = value; }  
        }

        public double RValue
        {
            get { return rValue; }
            set { this.rValue = value; }
        }

        
    }
}
