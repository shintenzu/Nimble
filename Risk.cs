using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nimble
{
    public class Risk
    {
        private int riskID;
        private string riskDesc;
        private int priority;
        private int prob;
        private int cost;

        public Risk() { }

        public Risk(int riskID)
        {
            this.RiskID = riskID;
        }

        public int RiskID
        {
            get { return riskID; }
            set { this.riskID = value; }
        }
        public int Priority
        {
            get { return priority; }
            set { this.priority = value; }
        }
        public int Prob
        {
            get { return prob; }
            set { this.prob = value; }
        }

        public int Cost
        {
            get { return cost; }
            set { this.cost = value; }  
        }
    }
}
