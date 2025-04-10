using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRTN_UI.Logic
{
    public class Scheduler
    {
        //public List<Process>  = new List<Process>();
        public List<Process> _ProcessData;
        public List<Process> _ReadyQueue;
        public double _CurrentTime;



        public Scheduler() 
        {
            _ProcessData = new List<Process>();
            _ReadyQueue = new List<Process>();
            _CurrentTime = 0;
        }
        public Scheduler(List<Process> ProcessData) {
            _ProcessData = ProcessData;
            _ReadyQueue = new List<Process>();
            _CurrentTime = 0.0;
        }
        public void SortProcesses() 
        {
            _ProcessData = _ProcessData
                                .OrderBy(p => p.ArrivalTime)
                                .ThenBy(p => p.OriginalBurstTime)
                                .ThenBy(p => p.ProcessId)       
                                .ToList();
        }


        public bool HasProcessesToSchedule() 
        {
            return _ProcessData.Count > 0;
        }

        public bool ReadyQueueHasProcesses() 
        {
            return _ReadyQueue.Count > 0;
        }

        public Process GetShortestRemainingTimeProcess()
        {
            if (_ReadyQueue.Count == 0) { return null; }
            Process shortestProc = _ReadyQueue[0];

            foreach (Process proc in _ReadyQueue)
            {
                if (proc.CurrentBurstTime > 0.0f)
                {
                    if (proc.CurrentBurstTime < shortestProc.CurrentBurstTime)
                    {
                        shortestProc = proc;
                    }

                }
            }
            return shortestProc;

        }

    }
}
