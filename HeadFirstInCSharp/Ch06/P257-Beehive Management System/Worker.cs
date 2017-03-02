using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace P257_Beehive_Management_System
{
    class Worker : Bee
    {
        private string currentJob = string.Empty;
        public string CurrentJob
        {
            get { return currentJob; }
        }

        public override int ShiftsLeft
        {
            get
            {
                return shiftsToWork - shiftsWorked;
            }
        }

        private string[] jobsICanDo;
        private int shiftsToWork;
        private int shiftsWorked;

        public Worker(string[] jobsCanDo, double weight)
            : base(weight)
        {
            jobsICanDo = jobsCanDo;
        }

        public bool DoThisJob(string job, int numberOfShifts)
        {
            if (!string.IsNullOrEmpty(currentJob))
                return false;
            for (int i = 0; i < jobsICanDo.Length; i++)
            {
                if (jobsICanDo[i] == job)
                {
                    currentJob = job;
                    this.shiftsToWork = numberOfShifts;
                    shiftsWorked = 0;
                    return true;
                }
            }
            return false;
        }
        public bool WorkOneShift()
        {
            if (string.IsNullOrEmpty(currentJob))
                return false;
            shiftsWorked++;
            if (shiftsWorked > shiftsToWork)
            {
                shiftsWorked = shiftsToWork = 0;
                currentJob = string.Empty;
                return true;
            }
            else
                return false;
        }
    }
}
