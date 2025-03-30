using System;
using STRN_Logic;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            // List Of Processes - Dili pani siya mao gyud for testing purposes lang
            // Para lang ma store ang mga processes sa list
            List<Process> processes = new List<Process>();
            processes.Add(new Process(1, "P1", 8.6, 14.0));
            processes.Add(new Process(2, "P2", 4.0, 8.5));
            processes.Add(new Process(3, "P3", 12.5, 0));
            processes.Add(new Process(4, "P4", 4.9, 0));
            processes.Add(new Process(5, "P5", 6.7, 9.3));


            // Kani siya kay mo sort sa mga processes according sa arrival time
            // para ma determine ang order sa pag execute sa mga processes
            // Para sunod nalang ilang order base sa ilang arrival time
            processes = processes.OrderBy(p => p.ArrivalTime).ToList();

            // Kani siya kay pina gantt chart representation sa mga processes
            // para ma visualize ang order sa pag execute sa mga processes
            // Pero for visual purposes sa console rani
            Dictionary<double, Process> currentThread = new Dictionary<double, Process>();

            // Kani siya kay murag pina simulation sa readyQueue sa mga processes
            // Para dili siya ditso sa currentThread, instead ma load sa siya sa readyqueue
            // Tapos diri nata mag kuha sa mga process base sa pina ka gamay na bursttime
            List<Process> readyQueue = new List<Process>();

            // Kani for Testing purposes, para ma store tong mga completed processes
            List<Process> completedProcesses = new List<Process>();

            // Kani for timer para gamiton pang minus sa burst time sa current Processes
            double currentTime = 0.0;
            Console.Write("Process List: ");
            foreach (Process proc in processes) 
            {
                Console.Write($"{proc.ProcessName}, ");
            }
            Console.WriteLine("\n\n");

            // Samtang naa pay sulod ang mga processes or readyQueue na list
            // Mo padayung og run ang while loop
            while (processes.Count > 0 || readyQueue.Count > 0)
            {
                // Kani siya kay mag loop sa kada processes 
                // Tapos i add sa ready queue if ang process arrival time kay the same sa current time
                foreach (var proc in processes.ToList())
                {
                    if (proc.ArrivalTime <= currentTime) // mao ni ang condition
                    {
                        readyQueue.Add(proc); // Mao ni siya na add sa ready queue
                        processes.Remove(proc); // mao ni siya na remove sa processes list
                    }
                }

                if (readyQueue.Count >0) // samtang naa pay sulod sa ready queue
                {
                    Process shortestJob = FindShortestNextProcess(readyQueue); // Mokuha tag shortest process
                    currentThread.Add(currentTime, shortestJob);// niya gi add sa CurrentThread para makita nato kung kinsay nag process una



                    //double nextEventTime = processes.Count > 0 ? processes[0].ArrivalTime : double.MaxValue;


                    //double executionTime = Math.Min(shortestJob.CurrentBurstTime, nextEventTime - currentTime);
                    /// <summary>
                    /// nextEventTime kay murag nag set sa time duration sa next process sa process list
                    /// nag kuha siya sa processes[0].ArrivalTime kay remember gi order og gi sort na nato 
                    /// and processes na list, so we can safley assume na ang first item sa processess list 
                    /// kay ang next na mo process 
                    /// Example
                    /// If Ang process List naay duha ka process, P1 = 0, P2= 5
                    /// ang P1 na butang sa readyQueue, niya si P2 naa pa sa processes List
                    /// si nextEventTime kay mo refer ni P2 kay wala naman si P1 niya sorted naman sila
                    ///  ----
                    ///  NextEventTime also Tells us on when the next process will arrive base on the current Time
                    ///  the preemption method will work because of nextEventTime

                    /// </summary>
                    double nextEventTime;

                    // Nag check if naa pabay sulod ang process na List
                    if (processes.Count > 0) 
                    {
                        // If naa pa, mo refer siya sa first item sa list og iya i set
                        // ang arrival time sa nextEventTime
                        nextEventTime = processes[0].ArrivalTime;
                        
                    }
                    else
                    {
                        // If ever wala nay sulod, iya i set og pinaka max value;
                        nextEventTime = double.MaxValue;
                    }


                    /// <summary>
                    /// ExecutionTime picks the time between the shortedJob's CurrentBurst Time
                    /// and the nextEventtime- currentTime's Time
                    /// 
                    /// 
                    /// <summary>
                    double executionTime;

                    // Iya i check diri if ever kinsay mas gamay nila
                    // If ang current Process kay mahuman before sa nextEventTime (nextProcess)

                    if (shortestJob.CurrentBurstTime <= nextEventTime - currentTime)
                    {
                        // Kay if Mahuman ang current Process before ang next Process
                        // Ang CurrentBurstTime ang interval before mag start ang next Process
                        executionTime = shortestJob.CurrentBurstTime;
                    }
                    else
                    {
                        // If ever maabot ang next Process kaysa mahuman ang current Process 
                        // Kay iya i 
                        executionTime = nextEventTime - currentTime;
                    }

                    // If unsay value sa executionTime kay iya i add sa currentTime
                    // In order to tell the time is moving, para mo proceed ang time 
                    currentTime += executionTime;
                    // For Rounding into 2 decimmals rani diri dapita
                    currentTime = Math.Round(currentTime, 2);

                    // Kani na line, It will deduct the CurrentBurstTime based on the value sa execution Time
                    // For example, p1 kay 10 iya burst time, niya ni process siyag 4 , so i minus siya mahimog 6
                    shortestJob.CurrentBurstTime -= executionTime;

                    // Kani if ever ma lessthan or 0 na iya burst time
                    // Meaning humana siya og process
                    if (shortestJob.CurrentBurstTime <= 0.0)
                    {
                        // Ang current Time kay i set as the completion Time sa current Process (shortestJob variable)
                        shortestJob.CompletionTime = currentTime;
                        // I add siya sa Completed na list
                        completedProcesses.Add(shortestJob);
                        // Tapos i remove siya sa ReadyQueue
                        readyQueue.Remove(shortestJob);
                    }
                }
                else// Kaning else, If ever walay sulod ang readyQueue, iya i set ang currentTime sa process[0].Arrival Time
                // PAra mo jump siya og time instead mag idle
                {
                    currentTime = processes[0].ArrivalTime;
                    currentTime = Math.Round(currentTime, 2);
                }
            }

            // Kani siya for testing purposes pang display sa list
            Console.WriteLine("Process Execution Order:");
            foreach (var process in completedProcesses)
            {
                Console.WriteLine($"{process.ProcessName} - Completed at time {process.CompletionTime}");
            }

            Console.WriteLine("Gantt Chart Representation\n");
            foreach (var process in currentThread)
            {
                Console.Write($"| {process.Key} => {process.Value.ProcessName} ");
            }


        }
        static Process FindShortestNextProcess(List<Process> readyQueue)
        { 
            if(readyQueue.Count == 0) { return null; } // Kani siya if walay sulod ang reeady queue, mo return og wala
            Process shortestProc = readyQueue[0];// Assuming na ang first na item sa list kay shortest

            foreach (Process proc in readyQueue)
            {
                if (proc.CurrentBurstTime > 0.0f) // ga filter sa readyQueue na dapat greater than 0 ilang burst time
                    // If less than or equal to zero meaning Humana silag process
                {
                    //Kani kay ga check if ang current Proccess na proc kay mas gamay sa 
                    // Gi set na procces which is "shortestProc" 
                    // Iya i assign ang current Process sa foreach sa shortestProc na variable
                    if (proc.CurrentBurstTime < shortestProc.CurrentBurstTime)  
                    {
                        shortestProc = proc;

                    }
                
                }
            }
            // Iya i return ang shortestProc
            return shortestProc;

        }
    }
}