using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

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
        private double userEffort = 0;
        public int taskCounter = 0;

        public User() { }

        public User(int userId, string fullName, int roleId) 
        { 
            this.userId = userId;
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

        public double UserEffort
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

        public void removeTask(Task newTask)
        {
            
            Task[] temp = new Task[100];
            int tempCounter = 0;
            Task ttask = new Task();
            ttask = newTask;
            for (int i = 0; i < this.tasks.Length; i++) 
            { if (this.tasks[i] != newTask)
                {
                    temp[tempCounter] = this.tasks[i];
                    tempCounter++;
                }
            }

            this.tasks = temp;
            taskCounter--;
            if (this.userEffort > 0) 
            {
                this.userEffort -= newTask.EstEffort;
            }
            

        }

        public string getRole()
        {
            if (this.roleId == 0)
            {
                return "Project Owner";
            }
            else if (this.roleId == 1)
            {
                return "Project Manager";
            }
            else if (this.roleId == 2)
            {
                return "Designer";
            }
            else if (this.roleId == 3)
            {
                return "Programmer";
            }
            else if (this.roleId == 4)
            {
                return "Tester";
            }
            else
            {
                return "";
            }
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
