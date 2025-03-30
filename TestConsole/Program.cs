using System;
using STRN_Logic;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Process> processes = new List<Process>();
            processes.Add(new Process(1, "P1", 4.5, 3.1));
            processes.Add(new Process(2, "P2", 9.90, 5.4));
            processes.Add(new Process(3, "P3", 4.1, 8.91));
            processes.Add(new Process(4, "P4", 13.6, 0));
            processes.Add(new Process(5, "P5", 6.9, 12.3));
            processes.Add(new Process(6, "P6", 13.6, 0));
            processes.Add(new Process(7, "P7", 13.6, 0));
            processes.Add(new Process(8, "P8", 13.6, 0));
            processes.Add(new Process(9, "P9", 13.6, 0));
            processes.Add(new Process(10, "P10", 13.6, 0));
            processes.Add(new Process(11, "P11", 13.6, 0));



            processes = processes.OrderBy(p => p.ArrivalTime).ToList();
            Dictionary<double, Process> currentThread = new Dictionary<double, Process>();
            List<Process> readyQueue = new List<Process>();
            List<Process> completedProcesses = new List<Process>();


            //// Make sure to order the processes by arrival time small to large

            //// At each arrival time of the processes, the current procees will be stopped
            //// and the next process will be put in the ready queue



            //// The among Processes in the ready queue will be compared by their burst time,
            //// the smallest burst time will be executed first
            double currentTime = 0.0;

            while (processes.Any() || readyQueue.Any())
            {
                // Add processes arriving at the current time
                foreach (var proc in processes.ToList())
                {
                    if (proc.ArrivalTime <= currentTime)
                    {
                        readyQueue.Add(proc);
                        processes.Remove(proc);
                    }
                }

                if (readyQueue.Any())
                {
                    Process shortestJob = FindShortestNextProcess(readyQueue);

                    double nextEventTime = processes.Any() ? processes[0].ArrivalTime : double.MaxValue;
                    double executionTime = Math.Min(shortestJob.CurrentBurstTime, nextEventTime - currentTime);

                    currentTime += executionTime;
                    currentTime = Math.Round(currentTime, 2);
                    shortestJob.CurrentBurstTime -= executionTime;

                    currentThread.Add(currentTime, shortestJob);
                    if (shortestJob.CurrentBurstTime <= 0.0)
                    {
                        shortestJob.CompletionTime = currentTime;
                        completedProcesses.Add(shortestJob);
                        readyQueue.Remove(shortestJob);
                    }
                }
                else
                {
                    currentTime = processes[0].ArrivalTime;
                    currentTime = Math.Round(currentTime, 2);
                }
            }


            Console.WriteLine("Process Execution Order:");
            foreach (var process in completedProcesses)
            {
                Console.WriteLine($"{process.ProcessName} - Completed at time {process.CompletionTime}");
            }

            Console.WriteLine("Gantt Chart Representation\n");
            foreach (var process in currentThread)
            {
                Console.Write($"| {process.Key} => {process.Value.ProcessName}");
            }


        }
        static Process FindShortestNextProcess(List<Process> readyQueue)
        { 
            if(readyQueue.Count == 0) { return null; }
            Process shortestProc = readyQueue[0];

            foreach (Process proc in readyQueue)
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