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
        private int projectID;
        private int category;
        private int assignmentID;
        //private int[] userID = new int[10];
        private int estEffort = 0;
        private int actEffort= 0;
        private DateTime? startDate;
        private DateTime? endDate;
        private DateTime? dueDate;

        public Task() 
        {
            
        }
        public Task(int taskId, string taskDesc, int projectID, int category, int userID, DateTime startDate, DateTime dueDate)
        {
            this.taskId = taskId;
            this.taskDesc = taskDesc;
            this.projectID = projectID;
            this.category = category;
            //this.assignmentID = assignmentID;
            //this.userID = new int[10];            
            this.startDate = startDate;
            this.dueDate = dueDate;

            TimeSpan days = dueDate - startDate;

            int effortHours = ((int)days.TotalDays) * 5;

            this.estEffort = effortHours;
            this.actEffort = 0;
            this.endDate = null;
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
            this.endDate = null;
        }

        public int TaskId
        {
            get { return taskId; }
            set { this.taskId = value; }
        }
        public int ProjectID
        {
            get { return projectID; }
            set { this.projectID = value; }
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
            get { return assignmentID; }
            set { this.assignmentID = value; }
        }

        public int EstEffort
        {
            get { return estEffort; }
            set { this.estEffort = value; }
        }
        

        public int ActEffort
        {
            get { return actEffort; }
            set { this.actEffort = value; }
        }

        public DateTime? StartDate
        {
            get { return startDate; }
            set { this.startDate = value; }
        }
        public DateTime? EndDate
        {
            get { return endDate; }
            set { this.endDate = value; }
        }
        public DateTime? DueDate
        {
            get { return dueDate; }
            set { this.dueDate = value; }
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
