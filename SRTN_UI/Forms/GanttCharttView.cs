using Krypton.Toolkit;
using SRTN_UI.Logic;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SRTN_UI.Forms
{
    public partial class GanttChartView : KryptonForm
    {
        #region Constants and Fields

        // Constants
        private const int MaxVisibleRows = 5;
        private const int RowHeight = 50;
        private const int RowSpacing = 20;
        private const int BaseContainerHeight = 60;

        // Singleton instance
        public static GanttChartView Instance;

        // Data
        private List<Process> _UserProcessData;
        private List<Process> _Completed;
        private readonly List<Process> _dummyData = new List<Process>
        {
            new Process(1, "Process 1", 5, 0),
            new Process(2, "Process 2", 3, 1),
            new Process(3, "Process 3", 2, 2),
            new Process(4, "Process 4", 4, 3),
            new Process(5, "Process 5", 1, 4)
        };

        private Scheduler scheduler;
        private List<ExecutionSegment> _executionTimeline;

        private KryptonPanel _tableContainer;
        private TableHeader _tableHeader;
        private FlowLayoutPanel _tableRowContainer;
        private TableItemRow[] _tableRow;

        //private KryptonPanel _ganttChartContainer;
        private KryptonPanel _ganttChartPanel;
        private KryptonPanel _timeLineContainer;

        private Action GanttChartReady;

        private readonly Color[] _processColors =
        {
            Color.FromArgb(103, 155, 155),
            Color.FromArgb(166, 166, 166),
            Color.FromArgb(188, 152, 98),
            Color.FromArgb(155, 103, 103),
            Color.FromArgb(155, 103, 155)
        };

        #endregion

        #region Constructor and Initialization

        public GanttChartView()
        {
            InitializeComponent();
            scheduler = new Scheduler();
            _Completed = new List<Process>();
            _executionTimeline = new List<ExecutionSegment>();
            this.Load += async (s, e) => await InitializeEvents();
        }

        public async Task InitializeEvents()
        {
            this.Shown += async (s, e) =>
            {
                InitializeTableContainer();
                await InitializeTableView();
                await Task.Delay(1000);
                InitializeTableRows(_UserProcessData ?? _dummyData);
            };

            GanttChartReady += () =>
            {
                InitializeGanttChartContainer(_UserProcessData ?? _dummyData);
                InitializeGanttChart(_UserProcessData ?? _dummyData);
            };
        }

        #endregion

        #region Table View Methods

        private async Task InitializeTableView()
        {
            _tableContainer.Controls.Clear();

            _tableHeader = new TableHeader()
            {
                Dock = DockStyle.Top,
                Size = new Size(705, 60),
                BackColor = Color.Transparent
            };

            _tableRowContainer = new FlowLayoutPanel
            {
                Dock = DockStyle.Fill,
                AutoScroll = true,
                BorderStyle = BorderStyle.None,
                FlowDirection = FlowDirection.TopDown,
                WrapContents = false,
                BackColor = Color.FromArgb(48, 56, 65),
                Padding = new Padding(3, 5, 0, 5)
            };

            _tableContainer.Controls.Add(_tableHeader);
            _tableContainer.Controls.Add(_tableRowContainer);

            _tableHeader.BringToFront();
            _tableRowContainer.BringToFront();
        }

        private async void InitializeTableRows(List<Process> processData)
        {
            _tableRow = new TableItemRow[processData.Count];
            AdjustTableContainerSize(processData.Count);

            for (int i = 0; i < processData.Count; i++)
            {
                _tableRow[i] = CreateTableRow(processData[i], processData.Count);
                _tableRowContainer.Controls.Add(_tableRow[i]);

                if (processData.Count <= MaxVisibleRows)
                {
                    UpdateTableContainerHeight(i + 1);
                }

                await Task.Delay(500).ConfigureAwait(true);
            }

            await AnimatePanelToPosition(_tableContainer, 12, 400);
            GanttChartReady?.Invoke();
        }

        private TableItemRow CreateTableRow(Process process, int totalProcesses)
        {
            return new TableItemRow(process)
            {
                Size = new Size(totalProcesses <= 5 ? _tableContainer.Width - 10 : _tableContainer.Width - 24, RowHeight),
                BackColor = Color.FromArgb(238, 238, 238),
            };
        }

        private void AdjustTableContainerSize(int processCount)
        {
            if (processCount <= MaxVisibleRows)
            {
                int totalHeight = BaseContainerHeight +
                                 (processCount * RowHeight) +
                                 ((processCount - 1) * RowSpacing);

                _tableContainer.Size = new Size(_tableContainer.Width, totalHeight);
                _tableContainer.AutoScroll = false;
            }
            else
            {
                int totalHeight = BaseContainerHeight +
                                 (MaxVisibleRows * RowHeight) +
                                 ((MaxVisibleRows - 1) * RowSpacing);

                _tableContainer.Size = new Size(_tableContainer.Width, totalHeight);
                _tableContainer.AutoScroll = true;
            }
        }

        private void UpdateTableContainerHeight(int rowsAdded)
        {
            if (rowsAdded <= MaxVisibleRows)
            {
                int totalHeight = BaseContainerHeight +
                                 (rowsAdded * RowHeight) +
                                 ((rowsAdded - 1) * RowSpacing);

                _tableContainer.Size = new Size(_tableContainer.Width, totalHeight);
            }
        }

        #endregion

        #region Container Initialization

        public async void InitializeTableContainer()
        {
            _tableContainer = new KryptonPanel()
            {
                Name = "TableContainer",
                Size = new Size(705, BaseContainerHeight),
                StateCommon =
                {
                    Color1 = Color.White,
                    Color2 = Color.White,
                    ColorStyle = PaletteColorStyle.Linear,
                    ColorAngle = 90f
                }
            };

            CenterTableContainer(_tableContainer);
            Controls.Add(_tableContainer);
            _tableContainer.BringToFront();

            int startY = this.ClientSize.Height + _tableContainer.Height;
            int endY = (this.ClientSize.Height - 500) - (500 / 2);
            await AnimatePanelY(_tableContainer, startY, endY);
        }

        public async void InitializeGanttChartContainer(List<Process> processData)
        {
            //_ganttChartContainer = new KryptonPanel()
            //{
            //    Name = "GanttChartContainer",
            //    Size = new Size(1462, 300),
            //    Location = new Point(12, 618),
            //    StateCommon =
            //    {
            //        Color1 = Color.White,
            //        Color2 = Color.White,
            //        ColorStyle = PaletteColorStyle.Linear,
            //        ColorAngle = 90f
            //    }
            //};

            //Controls.Add(_ganttChartContainer);
            _ganttChartContainer.BringToFront();

            await AnimatePanelY(_ganttChartContainer, this.ClientSize.Height + _ganttChartContainer.Height, 407);
        }

        private async void InitializeGanttChart(List<Process> processData)
        {
            _ganttChartPanel = new KryptonPanel()
            {
                Name = "GanttChart",
                Dock = DockStyle.Fill,
                AutoScroll = true,
                BackColor = Color.White,
                Padding = new Padding(10)
            };

            _ganttChartContainer.Controls.Add(_ganttChartPanel);
            _ganttChartPanel.BringToFront();

            await Task.Delay(300);
            StartScheduler(processData);
        }

        private void RenderGanttChart(List<ExecutionSegment> timeline)
        {
            _ganttChartPanel.Controls.Clear();

            if (timeline == null || timeline.Count == 0)
                return;

            double totalDuration = timeline.Max(seg => seg.EndTime);
            int scaleFactor = CalculateScaleFactor(totalDuration);

            CreateTimeScaleHeader(totalDuration, scaleFactor);

            var processGroups = timeline.GroupBy(seg => seg.ProcessId)
                                       .OrderBy(g => g.First().ProcessId);

            int rowTop = 40;
            foreach (var group in processGroups)
            {
                // SAFE LOOKUP - Use FirstOrDefault instead of First
                var process = _Completed.FirstOrDefault(p => p.ProcessId == group.Key);

                if (process == null)
                {
                    // Create a temporary process for visualization if not found in completed list
                    process = new Process(group.Key, $"Process {group.Key}", 0, 0);
                }

                Color processColor = _processColors[group.Key % _processColors.Length];

                AddProcessLabel(process.ProcessName, rowTop);

                foreach (var segment in group.OrderBy(s => s.StartTime))
                {
                    AddExecutionBlock(segment, rowTop, processColor, scaleFactor);
                }

                rowTop += 60;
            }

            _ganttChartPanel.Height = rowTop + 20;
        }

        private void AddExecutionBlock(ExecutionSegment segment, int top, Color color, int scaleFactor)
        {
            int left = (int)(segment.StartTime * scaleFactor);
            int width = (int)((segment.EndTime - segment.StartTime) * scaleFactor);

            var block = new KryptonPanel
            {
                BackColor = color,
                Location = new Point(left, top),
                Size = new Size(width, 40),
                Tag = segment
            };

            var toolTip = new ToolTip();
            toolTip.SetToolTip(block,
                $"{segment.ProcessName}\n" +
                $"Start: {segment.StartTime:F2}\n" +
                $"End: {segment.EndTime:F2}\n" +
                $"Duration: {segment.EndTime - segment.StartTime:F2}");

            _ganttChartPanel.Controls.Add(block);
        }

        private void CreateTimeScaleHeader(double totalDuration, int scaleFactor)
        {
            var timeHeader = new KryptonPanel
            {
                Height = 30,
                Dock = DockStyle.Top,
                BackColor = Color.White
            };

            int majorInterval = (int)Math.Ceiling(totalDuration / 10);
            for (int i = 0; i <= totalDuration; i += majorInterval)
            {
                var label = new Label
                {
                    Text = i.ToString(),
                    Location = new Point((int)(i * scaleFactor), 5),
                    AutoSize = true
                };
                timeHeader.Controls.Add(label);
            }

            _ganttChartPanel.Controls.Add(timeHeader);
        }

        private int CalculateScaleFactor(double totalDuration)
        {
            const int maxWidth = 1200;
            return (int)(maxWidth / Math.Max(totalDuration, 1));
        }

        private void AddProcessLabel(string processName, int top)
        {
            var label = new Label
            {
                Text = processName,
                Location = new Point(5, top + 10),
                AutoSize = true
            };
            _ganttChartPanel.Controls.Add(label);
        }

        #endregion

        #region SRTN Scheduler Implementation

        public void StartScheduler(List<Process> data)
        {
            scheduler = new Scheduler(data);
            _Completed.Clear();
            _executionTimeline.Clear();

            scheduler.SortProcesses();

            while (scheduler.HasProcessesToSchedule())
            {
                AddArrivingProcessesToReadyQueue();

                if (scheduler.ReadyQueueHasProcesses())
                {
                    Process currentProcess = scheduler.GetShortestRemainingTimeProcess();
                    double executionStartTime = scheduler._CurrentTime;
                    double executionTime = CalculateExecutionTime(currentProcess);

                    ExecuteProcess(currentProcess, executionTime);

                    _executionTimeline.Add(new ExecutionSegment(
                        currentProcess.ProcessId,
                        executionStartTime,
                        scheduler._CurrentTime,
                        currentProcess.ProcessName
                    ));
                }
                else
                {
                    AdvanceToNextArrivalTime();
                }
            }

            DisplayResults();
            RenderGanttChart(_executionTimeline);
        }

        private void AddArrivingProcessesToReadyQueue()
        {
            foreach (var proc in scheduler._ProcessData.ToList())
            {
                if (Math.Abs(proc.ArrivalTime - scheduler._CurrentTime) < 0.001)
                {
                    proc.Status = ProcessStatus.Ready;
                    scheduler._ReadyQueue.Add(proc);
                    scheduler._ProcessData.Remove(proc);
                }
            }
        }

        private double CalculateExecutionTime(Process process)
        {
            double remainingTime = process.CurrentBurstTime;

            if (scheduler._ProcessData.Count > 0)
            {
                double nextArrivalTime = scheduler._ProcessData[0].ArrivalTime;
                double availableTime = nextArrivalTime - scheduler._CurrentTime;
                return Math.Min(remainingTime, availableTime);
            }

            return remainingTime;
        }

        private void ExecuteProcess(Process process, double executionTime)
        {
            if (process.StartTime == 0)
            {
                process.StartTime = scheduler._CurrentTime;
            }

            scheduler._CurrentTime += executionTime;
            scheduler._CurrentTime = Math.Round(scheduler._CurrentTime, 2);
            process.CurrentBurstTime -= executionTime;

            if (process.CurrentBurstTime <= 0.001)
            {
                process.CompletionTime = scheduler._CurrentTime;
                process.Status = ProcessStatus.Terminated;
                process.TurnAroundTime = process.CompletionTime - process.ArrivalTime;
                process.WaitingTime = process.TurnAroundTime - process.OriginalBurstTime;

                // Ensure the process is added to completed list
                if (!_Completed.Any(p => p.ProcessId == process.ProcessId))
                {
                    _Completed.Add(process);
                }

                scheduler._ReadyQueue.Remove(process);
            }
        }

        private void AdvanceToNextArrivalTime()
        {
            if (scheduler._ProcessData.Count > 0)
            {
                scheduler._CurrentTime = scheduler._ProcessData[0].ArrivalTime;
                scheduler._CurrentTime = Math.Round(scheduler._CurrentTime, 2);
            }
        }

        private void DisplayResults()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("SRTN Scheduling Results:");
            sb.AppendLine("Process\tCompletion\tTAT\tWaiting");

            foreach (var process in _Completed.OrderBy(p => p.ProcessId))
            {
                sb.AppendLine($"{process.ProcessName}\t{process.CompletionTime}\t\t" +
                             $"{process.TurnAroundTime}\t{process.WaitingTime}");
            }

            sb.AppendLine($"\nAverage Turnaround Time: {_Completed.Average(p => p.TurnAroundTime):F2}");
            sb.AppendLine($"Average Waiting Time: {_Completed.Average(p => p.WaitingTime):F2}");

            MessageBox.Show(sb.ToString());
        }

        #endregion

        #region Animation Helpers

        private async Task AnimatePanelY(KryptonPanel panel, int startY, int endY, int durationMs = 500)
        {
            if (panel.InvokeRequired)
            {
                panel.Invoke(new Action(async () => await AnimatePanelY(panel, startY, endY, durationMs)));
                return;
            }

            panel.Visible = true;
            await AnimatePanelPosition(panel, panel.Location.X, startY, panel.Location.X, endY, durationMs);
        }

        private async Task AnimatePanelX(KryptonPanel panel, int startX, int endX, int durationMs = 500)
        {
            if (panel.InvokeRequired)
            {
                panel.Invoke(new Action(async () => await AnimatePanelX(panel, startX, endX, durationMs)));
                return;
            }

            panel.Visible = true;
            await AnimatePanelPosition(panel, startX, panel.Location.Y, endX, panel.Location.Y, durationMs);
        }

        private async Task AnimatePanelToPosition(KryptonPanel panel, int endX, int durationMs)
        {
            await AnimatePanelX(panel, panel.Location.X, endX, durationMs);
            await AnimatePanelY(panel, panel.Location.Y, endX, durationMs);
        }

        private async Task AnimatePanelPosition(KryptonPanel panel, int startX, int startY, int endX, int endY, int durationMs)
        {
            int steps = 60;
            int delayPerStep = durationMs / steps;

            for (int i = 0; i <= steps; i++)
            {
                double progress = EaseOutQuad(i / (double)steps);
                int newX = startX + (int)((endX - startX) * progress);
                int newY = startY + (int)((endY - startY) * progress);
                panel.Location = new Point(newX, newY);
                await Task.Delay(delayPerStep);
            }
        }

        #endregion

        #region Utility Methods

        private void CenterTableContainer(KryptonPanel panelToCenter)
        {
            if (panelToCenter == null || panelToCenter.IsDisposed) return;

            panelToCenter.Location = new Point(
                (ClientSize.Width - panelToCenter.Width) / 2,
                (ClientSize.Height - panelToCenter.Height) / 2
            );
        }

        private double EaseOutQuad(double progress) => 1 - Math.Pow(1 - progress, 2);

        public void SetProcessData(List<Process> processData)
        {
            _UserProcessData = processData;
        }

        #endregion

        #region Singleton Instance Management

        public static GanttChartView GetInstance()
        {
            if (Instance == null || Instance.IsDisposed)
            {
                Instance = new GanttChartView();
                Instance.Show();
            }
            else
            {
                Instance.BringToFront();
            }
            return Instance;
        }

        public static GanttChartView GetInstance(KryptonPanel panelContainer)
        {
            if (Instance == null || Instance.IsDisposed)
            {
                Instance = new GanttChartView();
                Instance.TopLevel = false;
                Instance.FormBorderStyle = FormBorderStyle.None;
                Instance.Dock = DockStyle.Fill;
                panelContainer.Controls.Clear();
                panelContainer.Controls.Add(Instance);
                Instance.Show();
            }
            else
            {
                Instance.BringToFront();
            }
            return Instance;
        }

        #endregion
    }

    public class ExecutionSegment
    {
        public int ProcessId { get; }
        public double StartTime { get; }
        public double EndTime { get; }
        public string ProcessName { get; }

        public ExecutionSegment(int processId, double startTime, double endTime, string processName)
        {
            ProcessId = processId;
            StartTime = startTime;
            EndTime = endTime;
            ProcessName = processName;
        }
    }
}