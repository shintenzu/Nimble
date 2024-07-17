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
        //private int taskId;        
        
        //private int[] tasks;
        //private int[] users;
        //private Task[] tasks = new Task[200];
        //private User[] users = new User[200];
        //private string description = string.Empty;
        //private string requirements = string.Empty;

        private Task[] tasks;
        private User[] users;
        private string description;
        private string requirements;
        public int teamCounter;
        public int taskCounter;
            
        public Project()
        {

        }
        public Project(int projectID)
        {
            this.projectID = projectID;
            this.tasks = new Task[200];
            this.users = new User[200];
            this.description = string.Empty;
            this.requirements = string.Empty;
            this.teamCounter = 0;
            this.taskCounter = 0;
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


    }
}
