using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRTN_UI.Logic
{
    public  class Process
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
        public ProcessStatus Status { get; set; }

        public Color AssignedColor { get; set; } = Color.Empty;

        //public double FirstExecutionTime { get; set; } = -1;  // When process first gets CPU
        //public double LastPreemptionTime { get; set; } = -1;  // When it was last preempted
        //public double LastReadyTime { get; set; }            // When it became ready
        //public double PreemptedWaitingTime { get; set; } = 0; // Sum of all preemption waits
        //public bool WasPreempted { get; set; } = false;      // Track if ever preempted

        public double? FirstStartTime { get; set; } = null;
        public List<(double PreemptTime, double ResumeTime)> PreemptionPairs { get; set; } = new();
        public Process(int _processId, string _processName, double _burstTime, double _arrivalTime)
        {
            ProcessId = _processId;
            ProcessName = _processName;
            OriginalBurstTime = _burstTime;
            CurrentBurstTime = _burstTime;
            ArrivalTime = _arrivalTime;
            //LastReadyTime = _arrivalTime; // Initialize with arrival time
            TurnAroundTime = 0;
            WaitingTime = 0;
            CompletionTime = 0;
            StartTime = 0;
            EndTime = 0;
            Status = ProcessStatus.New;
        }
    }
}
