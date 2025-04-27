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

        public Process(int _processId, string _processName, double _burstTime, double _arrivalTime)
        {
            ProcessId = _processId;
            ProcessName = _processName;
            OriginalBurstTime = _burstTime;
            CurrentBurstTime = _burstTime;
            ArrivalTime = _arrivalTime;
            TurnAroundTime = 0;
            WaitingTime = 0;
            CompletionTime = 0;
            StartTime = 0;
            EndTime = 0;
            Status = ProcessStatus.New;
        }
    }
}
