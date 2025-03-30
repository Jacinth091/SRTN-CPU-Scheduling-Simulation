using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STRN_Logic
{
    public class Process
    {
        public int ProcessId { get; set; }
        public string ProcessName { get; set; }
        public double OriginalBurstTime { get; set; }
        public double CurrentBurstTime { get; set; }
        public double ArrivalTime { get; set; }
        public double TurnAroundTime { get; set; }
        public double WaitingTime { get; set; }
        public double CompletionTime { get; set; }
        public double StartTime { get; set; }
        public double EndTime { get; set; }
        public bool IsCompleted { get; set; }

        public Process(int processId, string processName, double burstTime, double arrivalTime)
        {
            ProcessId = processId;
            ProcessName = processName;
            OriginalBurstTime = burstTime;
            CurrentBurstTime = burstTime;
            ArrivalTime = arrivalTime;
            TurnAroundTime = 0;
            WaitingTime = 0;
            CompletionTime = 0;
            StartTime = 0;
            EndTime = 0;
            IsCompleted = false;
        }


    }
}
