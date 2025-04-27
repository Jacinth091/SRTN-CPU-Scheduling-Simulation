using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Krypton.Toolkit;
using SRTN_UI.Logic;

namespace SRTN_UI.Forms
{
    public partial class Trial : Form
    {
        // Data Structures
        private List<Process> _processes;
        private List<Process> _completedProcesses;
        private readonly List<Process> _dummyData = new List<Process>
        {
            new Process(1, "P1", 5, 26),
            new Process(2, "P2", 8, 3),
            new Process(3, "P3", 18, 0),
            new Process(4, "P4", 3, 6),
            new Process(5, "P5", 12, 0)


        };

        private readonly Color[] _processColors =
        {
            Color.FromArgb(255, 0, 128),   // Hot Pink
            Color.FromArgb(0, 255, 255),   // Cyan
            Color.FromArgb(255, 255, 0),   // Yellow
            Color.FromArgb(0, 255, 0),     // Green
            Color.FromArgb(255, 128, 0),   // Orange
            Color.FromArgb(128, 0, 255),   // Purple
            Color.FromArgb(255, 0, 0)      // Red
        };

        public Trial()
        {
            InitializeComponent();
            AutoPlayBtn.Click += (s, e) => RunSRTNScheduler();
        }

        private void RunSRTNScheduler()
        {
            _processes = new List<Process>(_dummyData);
            _completedProcesses = new List<Process>();
            var timelineSegments = new List<TimelineSegment>();

            double currentTime = 0;
            var readyQueue = new List<Process>();
            Process currentProcess = null;
            double segmentStartTime = 0;

            while (_processes.Any(p => p.CurrentBurstTime > 0))
            {

                var arrivals = _processes
                    .Where(p => p.ArrivalTime <= currentTime && p.CurrentBurstTime > 0)
                    .ToList();

                readyQueue.AddRange(arrivals);
                readyQueue = readyQueue.Distinct().ToList();

                if (readyQueue.Any())
                {
                    // Get process with shortest remaining time
                    var nextProcess = readyQueue
                        .OrderBy(p => p.CurrentBurstTime)
                        .First();

                    if (currentProcess != nextProcess)
                    {
                        // Record previous segment if exists
                        if (currentProcess != null)
                        {
                            timelineSegments.Add(new TimelineSegment
                            {
                                Process = currentProcess,
                                StartTime = segmentStartTime,
                                EndTime = currentTime
                            });
                        }

                        currentProcess = nextProcess;
                        segmentStartTime = currentTime;

                        if (currentProcess.StartTime == -1)
                            currentProcess.StartTime = currentTime;
                    }

                    // Execute for 1 time unit
                    currentProcess.CurrentBurstTime -= 1;
                    currentTime += 1;

                    if (currentProcess.CurrentBurstTime <= 0)
                    {
                        // Process completed
                        timelineSegments.Add(new TimelineSegment
                        {
                            Process = currentProcess,
                            StartTime = segmentStartTime,
                            EndTime = currentTime
                        });
                        currentProcess.CompletionTime = currentTime;
                        _completedProcesses.Add(currentProcess);
                        readyQueue.Remove(currentProcess);
                        currentProcess = null;
                    }
                }
                else
                {
                    // CPU idle
                    timelineSegments.Add(new TimelineSegment
                    {
                        Process = null, // Indicates idle time
                        StartTime = currentTime,
                        EndTime = currentTime + 1
                    });
                    currentTime += 1;
                }
            }

            VisualizeSingleLineTimeline(timelineSegments);
            //CalculateMetrics();
        }

        private void VisualizeSingleLineTimeline(List<TimelineSegment> segments)
        {
            TimeLinePanel.Controls.Clear();
            const int blockHeight = 60;
            const int timeScale = 40; // pixels per time unit
            int yPos = 20;

            // Create main timeline panel
            var timelinePanel = new Panel
            {
                Height = blockHeight + 40,
                Dock = DockStyle.Top,
                BackColor = Color.White,
                BorderStyle = BorderStyle.FixedSingle,
                AutoScroll = true
            };

            // Create legend panel
            var legendPanel = new FlowLayoutPanel
            {
                Dock = DockStyle.Top,
                Height = 30,
                WrapContents = false,
                AutoScroll = true
            };

            // Draw timeline segments
            double maxTime = segments.Max(s => s.EndTime);
            int timelineWidth = (int)(maxTime * timeScale) + 100;
            var mainTimeline = new Panel
            {
                Width = timelineWidth,
                Height = blockHeight,
                Location = new Point(50, yPos)
            };

            foreach (var segment in segments)
            {
                int width = (int)((segment.EndTime - segment.StartTime) * timeScale);
                int xPos = (int)(segment.StartTime * timeScale);

                var segmentPanel = new Panel
                {
                    Width = width,
                    Height = blockHeight - 10,
                    Location = new Point(xPos, 5),
                    BackColor = segment.Process != null ? 
                        _processColors[segment.Process.ProcessId % _processColors.Length] : 
                        Color.LightGray,
                    BorderStyle = BorderStyle.FixedSingle
                };

                // Add time label
                var lblTime = new Label
                {
                    Text = segment.Process != null ? 
                        $"{segment.Process.ProcessName}\n{segment.StartTime}-{segment.EndTime}" : 
                        $"Idle\n{segment.StartTime}-{segment.EndTime}",
                    ForeColor = Color.Black,
                    BackColor = Color.Transparent,
                    TextAlign = ContentAlignment.MiddleCenter,
                    Dock = DockStyle.Fill,
                    Font = new Font("Segoe UI", 8)
                };

                segmentPanel.Controls.Add(lblTime);
                mainTimeline.Controls.Add(segmentPanel);
            }

            // Add time markers
            for (int time = 0; time <= maxTime; time++)
            {
                var marker = new Label
                {
                    Text = time.ToString(),
                    Location = new Point((int)(time * timeScale) - 5, blockHeight + 5),
                    AutoSize = true
                };
                mainTimeline.Controls.Add(marker);
            }

            // Create legend
            foreach (var process in _processes)
            {
                var legendItem = new Panel
                {
                    Width = 100,
                    Height = 20,
                    Margin = new Padding(5),
                    BackColor = _processColors[process.ProcessId % _processColors.Length],
                    BorderStyle = BorderStyle.FixedSingle
                };

                var lblLegend = new Label
                {
                    Text = process.ProcessName,
                    Dock = DockStyle.Fill,
                    TextAlign = ContentAlignment.MiddleCenter
                };

                legendItem.Controls.Add(lblLegend);
                legendPanel.Controls.Add(legendItem);
            }

            timelinePanel.Controls.Add(mainTimeline);
            TimeLinePanel.Controls.Add(timelinePanel);
            TimeLinePanel.Controls.Add(legendPanel);
        }

        private void CalculateMetrics()
        {
            var metrics = new StringBuilder();
            foreach (var p in _completedProcesses.OrderBy(p => p.ProcessId))
            {
                double turnaround = p.CompletionTime - p.ArrivalTime;
                double waiting = turnaround - p.OriginalBurstTime;

                metrics.AppendLine($"{p.ProcessName}: " +
                    $"Turnaround: {turnaround}, " +
                    $"Waiting: {waiting}");
            }

            double avgTurnaround = _completedProcesses
                .Average(p => p.CompletionTime - p.ArrivalTime);
            double avgWaiting = _completedProcesses
                .Average(p => (p.CompletionTime - p.ArrivalTime) - p.OriginalBurstTime);

            metrics.AppendLine($"\nAverage Turnaround: {avgTurnaround:F2}");
            metrics.AppendLine($"Average Waiting: {avgWaiting:F2}");

            MessageBox.Show(metrics.ToString(), "Scheduling Metrics");
        }
    }

    public class TimelineSegment
    {
        public Process Process { get; set; }
        public double StartTime { get; set; }
        public double EndTime { get; set; }
    }
}