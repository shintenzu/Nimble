using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nimble
{
    public class User
    {
        private int userId;
        private string fullName;
        //private string lastName;
        private int roleId;
        //private int[] tasks;
        private Task[] tasks = new Task[100];
        private int userEffort = 0;
        public int taskCounter = 0;

        public User() { }

        public User(int userID, string fullName, int roleId) 
        { 
            this.userId = userID;
            this.fullName = fullName;
            this.roleId = roleId;

            //this.tasks = new Task[100];
            
            //this.userEffort = 0;   
            //this.taskCounter = 0;  
        
        }


        public int UserId
        {
            get { return userId; }
            set { this.userId = value; }
        }

        public string FullName
        {
            get { return fullName; }
            set { this.fullName = value; }
        }

        public int RoleId
        {
            get { return roleId; }
            set { this.roleId = value; }
        }

        public int UserEffort
        {
            get { return userEffort; }
            set { this.userEffort = value; }
        }

        public int TaskCounter
        {
            get { return taskCounter; }
            set { this.taskCounter = value; }
        }

        public void addTask(int Index, Task newTask)
        {
            this.tasks[Index] = newTask;
        }
        public Task getTask(int Index)
        {
            return tasks[Index];
        }


        /*
        public int getUserId() { return userId; }
        public string getFirstName() { return firstName; }
        public string getLastName() { return lastName; }
        public int getRoleId() { return roleId; }
        //public int[] getTasks() { return tasks; }
        public int getUserEffort() { return userEffort; }
        public int getTaskCounter() { return taskCounter; } 
        */
    }
}
