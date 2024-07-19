using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nimble
{
    public class Req
    {
        private int reqId;
        private string reqDesc;        
        private int category;


        public Req() { }

        public Req(int reqId)
        {
            this.reqId = reqId;
        }

        public int ReqId
        {
            get { return reqId; }
            set { this.reqId = value; }
        }

        public string ReqDesc
        {
            get { return reqDesc; }
            set { this.reqDesc = value; }
        }

        public int Category
        {
            get { return category; }
            set { this.category = value; }
        }
        public string getType()
        {
            if (this.category == 0)
            {
                return "Functional";
            }
            else if (this.category == 1) {
                return "Non - Functional";
            }
            else
            {
                return "";
            }
        }
        
    }
}
