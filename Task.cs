using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nimble
{
    public class Task
    {
        
        private int taskId;
        private string taskDesc;
        private int projectId;
        private int category;
        private int assignmentId;
        private int userId;
        //private int[] userID = new int[10];
        private double estEffort = 0;
        private double actEffort = 0;
        private DateTime startDate;
        private DateTime endDate;
        private DateTime dueDate;
        //startDate.CustomFormat = "MM/dd/yyyy";

        public Task() 
        {
            
        }
        public Task(int taskId, string taskDesc, int projectID, int category, int userID, DateTime startDate, DateTime dueDate)
        {
            this.taskId = taskId;
            this.taskDesc = taskDesc;
            this.projectId = projectID;
            this.category = category;
            //this.assignmentID = assignmentID;
            //this.userID = new int[10];            
            this.startDate = startDate;
            this.dueDate = dueDate;

            TimeSpan days = dueDate - startDate;

            int effortHours = ((int)days.TotalDays) * 5;

            this.estEffort = effortHours;
            this.actEffort = 0;
            //this.endDate = null;
        }

        public Task(int taskId, string taskDesc, DateTime startDate, DateTime dueDate)
        {
            this.taskId = taskId;
            this.taskDesc = taskDesc;
            //this.projectID = projectID;
            //this.category = category;
            //this.assignmentID = assignmentID;
            //this.userID = new int[10];
            this.startDate = startDate;
            this.dueDate = dueDate;

            TimeSpan days = dueDate - startDate;

            int effortHours = ((int)days.TotalDays) * 5;

            this.estEffort = effortHours;
            this.actEffort = 0;
            //this.endDate = null;
        }

        public int TaskId
        {
            get { return taskId; }
            set { this.taskId = value; }
        }

        public int UserId
        {
            get { return userId; }
            set { this.userId = value; }
        }

        public int ProjectID
        {
            get { return projectId; }
            set { this.projectId = value; }
        }
        public string TaskDesc
        {
            get { return taskDesc; }
            set { this.taskDesc = value; }
        }
        public int Category
        {
            get { return category; }
            set { this.category = value; }
        }

        public int AssignmentID
        {
            get { return assignmentId; }
            set { this.assignmentId = value; }
        }

        public double EstEffort
        {
            get { return estEffort; }
            set { this.estEffort = value; }
        }
        

        public double ActEffort
        {
            get { return actEffort; }
            set { this.actEffort = value; }
        }

        public DateTime StartDate
        {
            get { return startDate; }
            set { this.startDate = value; }
        }
        public DateTime EndDate
        {
            get { return endDate; }
            set { this.endDate = value; }
        }
        public DateTime DueDate
        {
            get { return dueDate; }
            set { this.dueDate = value; }
        }

        public String CatString()
        {
            string cat = string.Empty;
            if (this.category == 0)
            {
                cat = "Requirements Analysis";
            }
            else if (this.category == 1)
            {
                cat = "Design";
            }
            else if (this.category == 2)
            {
                cat = "Coding";
            }
            else if (this.category == 3)
            {
                cat = "Testing";
            }
            else if (this.category == 4)
            {
                cat = "Project Management";
            }
            return cat;
        }

        public int calcEffort()
        {
            int eff = 0;

            return eff;
        }

        /*
        public int getTaskId() { return taskId; }
        public string getTaskDesc() { return taskDesc; }
        public int getProjectID() { return projectID; }
        public int getCategory() { return category; }   
        public int getAssignmentID() { return assignmentID; }
        //public int getUserID() { return userID; }

        public DateTime? getStartDate() { return startDate; }
        public DateTime? getEndtDate() { return endDate; }
        public DateTime? getDueDate() { return dueDate; }
        public int getEffortHours() { return estEffort; }
        public int getActEffort() { return actEffort; }

        */
    }
}
