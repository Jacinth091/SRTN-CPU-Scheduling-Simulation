using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRTN_UI.Logic
{

    public class ProcessBlock
    {
        public int ProcessId { get; }
        public double StartTime { get; set; }
        public double EndTime { get; set; }
        public string ProcessName { get; }
        public Color ProcessColor
        {
            get; set;
        }

        public ProcessBlock(int processId, double startTime, double endTime, string processName, Color processColor)
        {
            ProcessId = processId;
            StartTime = startTime;
            EndTime = endTime;
            ProcessName = processName;
            ProcessColor = processColor; // assign here
        }
        public ProcessBlock(int processId, string processName, Color processColor)
        {
            ProcessId = processId;
            StartTime = 0;
            EndTime = 0;
            ProcessName = processName;
            ProcessColor = processColor;
        }
    }
}
