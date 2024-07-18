using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nimble
{
    public class Stages
    {
        private int stageId;
        private int projectID;
        private Task[] tasks = new Task[100];
        private double stageEffort = 0;
        public int taskCounter = 0;

        public int StageId
        {
            get { return stageId; }
            set { this.stageId = value; }
        }
        public int ProjectID
        {
            get { return projectID; }
            set { this.projectID = value; }
        }
         public double StageEffort
        {
            get { return stageEffort; }
            set { this.stageEffort = value; }
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
