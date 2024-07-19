using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nimble
{
    public class Project
    {
        private int projectID;

        private Task[] tasks = new Task[200];
        private User[] users = new User[200];
        private Risk[] risks = new Risk[200];
        private Req[] reqs = new Req[200];
        private string description = string.Empty;
        private string requirements = string.Empty;
        public int teamCounter = 0;
        public int taskCounter = 0;
        public int riskCounter = 0;
        public int reqCounter = 0;
        public bool hasLeader = false;
        public bool hasManager = false;
        //public int req = 0;
        //public int design = 0;
        //public int req = 0;

        public Stages req = new Stages();
        public Stages design = new Stages();
        public Stages code = new Stages();
        public Stages test = new Stages();
        public Stages pm = new Stages();

        public Project()
        {

        }
        public Project(int projectID)
        {
            this.projectID = projectID;
        }
        
        public int ProjectID { 
            get { return projectID; } 
            set { this.projectID = value; } 
        }

        public string Description
        {
            get { return description; }
            set { this.description = value; }
        }

        public string Requirements
        {
            get { return requirements; }
            set { this.requirements = value; }
        }

        public void addUser(int Index, User newUser)
        {
            this.users[Index] = newUser;
        }
        public User getUser(int Index)
        {
            return users[Index];
        }
        public void addTask(int Index, Task newTask)
        {
            this.tasks[Index] = newTask;
        }
        public Task getTask(int Index)
        {
            return tasks[Index];
        }
        public void addRisk(int Index, Risk newRisk)
        {
            this.risks[Index] = newRisk;
        }
        public Risk getRisk(int Index)
        {
            return risks[Index];
        }
        public void addReq(int Index, Req newReq)
        {
            this.reqs[Index] = newReq;
        }
        public Req getReq(int Index)
        {
            return reqs[Index];
        }


    }
}
