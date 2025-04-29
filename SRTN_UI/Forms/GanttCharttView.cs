using Krypton.Toolkit;
using SRTN_UI.Logic;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Printing;
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
        private const int RowHeight = 60;
        private const int RowSpacing = 20;
        private const int BaseContainerHeight = 60;

        // Singleton instance
        public static GanttChartView Instance;

        // Data
        private List<Process> _UserProcessData;
        private List<Process> completedProcesses;
        private readonly List<Process> _dummyData = new List<Process>
        {
            //new Process(1, "Process 1", 5, 0),
            //new Process(2, "Process 2", 3, 1),
            //new Process(3, "Process 3", 2, 2),
            //new Process(4, "Process 4", 4, 3),
            //new Process(5, "Process 5", 1, 4)
            new Process(1, "P1", 8, 0),
            new Process(2, "P2", 4, 1),
            new Process(3, "P3", 9, 2),
            new Process(4, "P4", 5, 3),
            //new Process(2, "P2", 5, 9)
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

        private Scheduler scheduler;
        //private List<ExecutionSegment> _executionTimeline;
        //_resultTableContainer
        private KryptonPanel _tableContainer;
        private TableHeader _tableHeader;
        private FlowLayoutPanel _tableRowContainer;
        private TableItemRow[] _tableRow;

        private KryptonPanel _resultTableContainer;
        private ResultHeader _resultHeader;
        private FlowLayoutPanel _resultItemRowContainer;
        private ResultItemRow[] _resultItemRow;

        //private KryptonPanel _ganttChartContainer;
        //private KryptonPanel _ganttChartPanel;
        //private KryptonPanel _timeLineContainer;

        private Action GanttChartReady;
        private Action ResultsDisplay;

        #endregion

        #region Constructor and Initialization

        public GanttChartView()
        {
            InitializeComponent();
            scheduler = new Scheduler();
            completedProcesses = new List<Process>();
            //_executionTimeline = new List<ExecutionSegment>();
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

            GanttChartReady += async () =>
            {
                InitializeGanttChartContainer(_UserProcessData ?? _dummyData);

                //InitializeTimeline();

            };
            ResultsDisplay += async () =>
            {
                InitializeResultTableContainer();
                await InitializeResultTableView();
                await Task.Delay(1000);
                //InitializeResultTableRows(completedProcesses ?? _dummyData);

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
                Size = new Size(520, 60),
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

        #region Results Table Initialization and Items

        private async Task InitializeResultTableView()
        {

            // Initialize the Result Header
            _resultHeader = new ResultHeader()
            {
                Dock = DockStyle.Top,
                Size = new Size(789, 60),
                BackColor = Color.Transparent
            };

            // Initialize the Result Rows Container
            _resultItemRowContainer = new FlowLayoutPanel
            {
                Dock = DockStyle.Fill,
                AutoScroll = true,
                BorderStyle = BorderStyle.None,
                FlowDirection = FlowDirection.TopDown,
                WrapContents = false,
                BackColor = Color.FromArgb(48, 56, 65),
                Padding = new Padding(3, 5, 0, 5)
            };

            // Add the header and row container to the main panel
            _resultTableContainer.Controls.Add(_resultHeader);
            _resultTableContainer.Controls.Add(_resultItemRowContainer);

            // Ensure the header and rows are always on top
            _resultHeader.BringToFront();
            _resultItemRowContainer.BringToFront();

            // Position the table off-screen to the right (initially)
            _resultTableContainer.Location = new Point(this.ClientSize.Width, 0); // Start off-screen on the right
            Controls.Add(_resultTableContainer);  // Add the panel to the form
            _resultTableContainer.BringToFront();
        }

        private async void InitializeResultTableRows(List<Process> processData)
        {
            _resultItemRow = new ResultItemRow[processData.Count];
            AdjustResultTableContainerSize(processData.Count);

            // Loop through the process data to create rows
            for (int i = 0; i < processData.Count; i++)
            {
                // Create a row for each process and add it to the container
                _resultItemRow[i] = CreateResultRow(processData[i], processData.Count);
                _resultItemRowContainer.Controls.Add(_resultItemRow[i]);

                // If there are fewer rows than the max, adjust container height
                if (processData.Count <= MaxVisibleRows)
                {
                    UpdateResultTableContainerHeight(i + 1);
                }

                await Task.Delay(500).ConfigureAwait(true); // Add delay to simulate dynamic row population
            }

            // Animate the panel from right to the final position
            //await AnimatePanelToPosition(_resultTableContainer, 12, 400);
            //GanttChartReady?.Invoke();
        }

        private ResultItemRow CreateResultRow(Process process, int totalProcesses)
        {
            // Create a result row based on the process data
            return new ResultItemRow(process)
            {
                Size = new Size(totalProcesses <= 5 ? _resultTableContainer.Width - 10 : _resultTableContainer.Width - 24, RowHeight),
                BackColor = Color.FromArgb(238, 238, 238),  // Adjust the background color as necessary
            };
        }

        private void AdjustResultTableContainerSize(int processCount)
        {
            if (processCount <= MaxVisibleRows)
            {
                int totalHeight = BaseContainerHeight +
                                 (processCount * RowHeight) +
                                 ((processCount - 1) * RowSpacing);

                _resultTableContainer.Size = new Size(_resultTableContainer.Width, totalHeight);
                _resultTableContainer.AutoScroll = false;
            }
            else
            {
                int totalHeight = BaseContainerHeight +
                                 (MaxVisibleRows * RowHeight) +
                                 ((MaxVisibleRows - 1) * RowSpacing);

                _resultTableContainer.Size = new Size(_resultTableContainer.Width, totalHeight);
                _resultTableContainer.AutoScroll = true;
            }
        }

        private void UpdateResultTableContainerHeight(int rowsAdded)
        {
            if (rowsAdded <= MaxVisibleRows)
            {
                int totalHeight = BaseContainerHeight +
                                 (rowsAdded * RowHeight) +
                                 ((rowsAdded - 1) * RowSpacing);

                _resultTableContainer.Size = new Size(_resultTableContainer.Width, totalHeight);
            }
        }
        #endregion


        #region Container Initialization

        public async void InitializeTableContainer()
        {
            _tableContainer = new KryptonPanel()
            {
                Name = "TableContainer",
                Size = new Size(476, BaseContainerHeight),
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

        public async void InitializeResultTableContainer()
        {
            // Initialize the result table container (KryptonPanel)
            _resultTableContainer = new KryptonPanel()
            {
                Name = "ResultTableContainer",
                Size = new Size(789, BaseContainerHeight),  // Size of the panel
                StateCommon =
                {
                    Color1 = Color.White,
                    Color2 = Color.White,
                    ColorStyle = PaletteColorStyle.Linear,
                    ColorAngle = 90f
                }
            };

            // Position the panel just outside the right side of the form
            _resultTableContainer.Location = new Point(this.ClientSize.Width, 0); // Initial position outside the form (right side)

            // Add the panel to the form's controls
            Controls.Add(_resultTableContainer);
            _resultTableContainer.BringToFront();

            // Define the destination position for the panel
            int destinationX = this.ClientSize.Width - _resultTableContainer.Width - 100; // Adjust based on your desired margin
            int destinationY =_resultTableContainer.Height-51;  // You can modify the vertical position as needed

            // Animate the panel's X and Y positions (from right to the destination)
            await AnimatePanelX(_resultTableContainer, _resultTableContainer.Location.X, destinationX, 500); // Adjust duration as needed
            await AnimatePanelY(_resultTableContainer, _resultTableContainer.Location.Y, destinationY, 500); // Adjust duration as needed
        }


        public async void InitializeGanttChartContainer(List<Process> processData)
        {

            _ganttChartContainer.BringToFront();

            await AnimatePanelY(_ganttChartContainer, this.ClientSize.Height + _ganttChartContainer.Height, 407);

            InitializeChartElements(_UserProcessData ?? _dummyData);
        }

        private async void InitializeChartElements(List<Process> processData) 
        {
            _timeLineContainer.BringToFront();

            await Task.Delay(1000);

            _timeLineContainer.Refresh();
            StartSRTNScheduling(processData);

            _timeLineContainer.Refresh();
        }

        public async void StartSRTNScheduling(List<Process> processData)
        {
            List<Process> processes = new List<Process>(processData ?? _dummyData);
            List<ProcessBlock> processBlocks = new List<ProcessBlock>();
            //List<Process> completedProcesses = new List<Process>();

            int colorCounter = 0;
            double currentTime = 0;
            double timeIncrement = 0.1;
            double smallTolerance = 0.0001;
            double maxAllowedTime = 10.0;
            double maxProcessCompletionTime = 0;
            double idleStartTime = -1;

            Process currentProcess = null;
            ProcessBlock currentBlock = null;
            Process previousProcess = null;

            double RoundTime(double time) => Math.Round(time, 2);

            // Reset processes
            foreach (var p in processes)
            {
                p.CurrentBurstTime = p.OriginalBurstTime;
                p.Status = ProcessStatus.New;
                p.PreemptionPairs = new();
                p.FirstStartTime = null;
            }

            foreach (var process in processes)
            {
                if (process.AssignedColor == Color.Empty)
                {
                    process.AssignedColor = _processColors[colorCounter++ % _processColors.Length];
                }
            }

            while (completedProcesses.Count < processes.Count)
            {
                // Step 1: Update ready processes
                foreach (var p in processes.Where(p => RoundTime(p.ArrivalTime) <= RoundTime(currentTime) && p.Status == ProcessStatus.New))
                {
                    p.Status = ProcessStatus.Ready;
                }

                // Step 2: Choose shortest remaining time process
                var readyProcesses = processes
                    .Where(p => p.Status == ProcessStatus.Ready || p.Status == ProcessStatus.Running)
                    .OrderBy(p => p.CurrentBurstTime)
                    .ThenBy(p => p.ArrivalTime)
                    .ThenBy(p => p.ProcessId)
                    .ToList();

                if (readyProcesses.Any())
                {
                    var selectedProcess = readyProcesses.First();

                    // Step 3: Preemption logic
                    if (previousProcess == null || previousProcess.ProcessId != selectedProcess.ProcessId)
                    {
                        if (currentBlock != null)
                        {
                            currentBlock.EndTime = RoundTime(currentTime);
                            processBlocks.Add(currentBlock);
                        }

                        // Handle preemption of previous
                        if (previousProcess != null && previousProcess.ProcessId != selectedProcess.ProcessId && previousProcess.Status == ProcessStatus.Running)
                        {
                            previousProcess.Status = ProcessStatus.Ready;
                            previousProcess.PreemptionPairs.Add((RoundTime(currentTime), -1));
                        }

                        // Handle resume of current
                        if (selectedProcess.PreemptionPairs.Count > 0 && selectedProcess.PreemptionPairs[^1].ResumeTime == -1)
                        {
                            var last = selectedProcess.PreemptionPairs[^1];
                            selectedProcess.PreemptionPairs[^1] = (last.PreemptTime, RoundTime(currentTime));
                        }

                        currentBlock = new ProcessBlock(
                            selectedProcess.ProcessId,
                            RoundTime(currentTime),
                            RoundTime(currentTime + timeIncrement),
                            selectedProcess.ProcessName,
                            selectedProcess.AssignedColor
                        );
                    }
                    else
                    {
                        if (currentBlock != null)
                        {
                            currentBlock.EndTime = RoundTime(currentTime + timeIncrement);
                        }
                    }

                    if (selectedProcess.FirstStartTime == null)
                    {
                        selectedProcess.FirstStartTime = RoundTime(currentTime);
                    }

                    selectedProcess.Status = ProcessStatus.Running;
                    selectedProcess.CurrentBurstTime -= timeIncrement;

                    if (selectedProcess.CurrentBurstTime <= smallTolerance)
                    {
                        selectedProcess.Status = ProcessStatus.Terminated;
                        selectedProcess.CompletionTime = RoundTime(currentTime + timeIncrement);
                        selectedProcess.TurnAroundTime = RoundTime(selectedProcess.CompletionTime - selectedProcess.ArrivalTime);

                        // Compute accurate waiting time
                        double waitingTime = (selectedProcess.FirstStartTime ?? selectedProcess.ArrivalTime) - selectedProcess.ArrivalTime;
                        foreach (var (preempt, resume) in selectedProcess.PreemptionPairs)
                        {
                            if (resume > preempt) waitingTime += resume - preempt;
                        }
                        selectedProcess.WaitingTime = RoundTime(waitingTime);

                        completedProcesses.Add(selectedProcess);

                        if (currentBlock != null)
                        {
                            currentBlock.EndTime = RoundTime(currentTime + timeIncrement);
                            processBlocks.Add(currentBlock);
                            currentBlock = null;
                        }

                        maxProcessCompletionTime = Math.Max(maxProcessCompletionTime, selectedProcess.CompletionTime);
                    }

                    previousProcess = selectedProcess;
                }
                else
                {
                    // No ready process — Idle time
                    if (currentBlock == null || currentBlock.ProcessId != -1)
                    {
                        if (currentBlock != null)
                        {
                            currentBlock.EndTime = RoundTime(currentTime);
                            processBlocks.Add(currentBlock);
                        }

                        currentBlock = new ProcessBlock(-1,
                            RoundTime(currentTime),
                            RoundTime(currentTime + timeIncrement),
                            "Idle",
                            Color.LightGray);
                    }
                    else
                    {
                        currentBlock.EndTime = RoundTime(currentTime + timeIncrement);
                    }
                }

                currentTime = RoundTime(currentTime + timeIncrement);
            }

            if (idleStartTime != -1 && RoundTime(idleStartTime) < RoundTime(currentTime))
            {
                processBlocks.Add(new ProcessBlock(-1,
                    RoundTime(idleStartTime),
                    RoundTime(currentTime),
                    "Idle",
                    Color.LightGray));
            }

            MessageBox.Show($"Max Process Completion Time : {RoundTime(maxProcessCompletionTime)} vs Max Allowed Time: {maxAllowedTime}");
            RenderGanttChart(processBlocks, RoundTime(currentTime), RoundTime(maxProcessCompletionTime) > maxAllowedTime);
            await Task.Delay(500);
        }



        private void RenderGanttChart(List<ProcessBlock> processBlocks, double totalTime, bool shouldShrink)
        {
            _timeLineContainer.Controls.Clear();
            _timeLineContainer.AutoScroll = true;

            if (processBlocks == null || processBlocks.Count == 0)
                return;

            int containerWidth = _timeLineContainer.Width - 50;
            int maxBlockWidthPerTimeUnit = 40;
            int minBlockWidthPerTimeUnit = 20;
            int minIdleBlockWidth = 25; // Minimum width for idle blocks to ensure visibility

            // Adjust scale factor based on whether we should shrink
            double scaleFactor = containerWidth / Math.Max(totalTime, 1);
            if (shouldShrink)
            {
                // Shrink if any process exceeded the maxAllowedTime
                scaleFactor *= 0.7; // Example: Shrink by half if exceeding limit
            }

            scaleFactor = Math.Min(scaleFactor, maxBlockWidthPerTimeUnit);
            scaleFactor = Math.Max(scaleFactor, minBlockWidthPerTimeUnit);

            int rowHeight = 70;
            int timelineHeight = 50;
            int margin = 10;

            var ganttRowPanel = new Panel
            {
                Height = rowHeight,
                Dock = DockStyle.Top,
                BackColor = Color.FromArgb(238, 238, 238),
                Padding = new Padding(0, 0, 0, margin)
            };

            var timelinePanel = new Panel
            {
                Height = timelineHeight,
                Dock = DockStyle.Top,
                BackColor = Color.FromArgb(238, 238, 238)
            };

            _timeLineContainer.Controls.Add(timelinePanel);
            _timeLineContainer.Controls.Add(ganttRowPanel);

            HashSet<double> timelineLabelTimes = new HashSet<double>();
            int counter = 0;
            foreach (var block in processBlocks)
            {
                //chart += block.ProcessName + " " + block.StartTime + " " + block.EndTime + "\n";
                int blockWidth = (int)((block.EndTime - block.StartTime) * scaleFactor);

                // For Idle blocks, ensure a minimum width for visibility
                if (block.ProcessId == -1)
                {
                    blockWidth = Math.Max(minIdleBlockWidth, (int)((block.EndTime - block.StartTime) * scaleFactor));
                }

                if (blockWidth <= 0) continue;



                var blockPanel = new Panel
                {
                    BackColor = block.ProcessColor,
                    Location = new Point((int)(block.StartTime * scaleFactor) + 20, margin), // <--- update here
                    Size = new Size(blockWidth, rowHeight - 2 * margin),
                    Anchor = AnchorStyles.Left | AnchorStyles.Top,
                    BorderStyle = BorderStyle.FixedSingle
                };

                if(counter ==0)
                {
                    blockPanel.Location = new Point((int)(block.StartTime * scaleFactor) + 20, margin);
                }

                if (block.ProcessId != -1)
                {
                    var label = new Label
                    {
                        Text = block.ProcessName,
                        ForeColor = GetContrastColor(block.ProcessColor),
                        TextAlign = ContentAlignment.MiddleCenter,
                        Dock = DockStyle.Fill,
                        Font = new Font("Poppins", 8, FontStyle.Bold)
                    };
                    blockPanel.Controls.Add(label);
                }
                else
                {
                    var label = new Label
                    {
                        Text = block.ProcessName,
                        ForeColor = GetContrastColor(block.ProcessColor),
                        TextAlign = ContentAlignment.MiddleCenter,
                        Dock = DockStyle.Fill,
                        Font = new Font("Poppins",8, FontStyle.Bold)
                    };
                    blockPanel.Controls.Add(label);
                }

                timelineLabelTimes.Add(block.StartTime);
                timelineLabelTimes.Add(block.EndTime);

                ganttRowPanel.Controls.Add(blockPanel);
                counter++;
            }
            counter = 0;
            foreach (var time in timelineLabelTimes.OrderBy(t => t))
            {
                // Create the line (this stays the same)
                var line = new Panel
                {
                    BackColor = Color.Black,
                    Location = new Point((int)(time * scaleFactor)+ 20, 0), // Line positioned at 0 (top)
                    Size = new Size(1, 15),
                    Anchor = AnchorStyles.Top | AnchorStyles.Left
                };
                timelinePanel.Controls.Add(line);

                // Create the label and position it below the line (adjust the Y value)
                var timeLabel = new Label
                {
                    Text = time.ToString("0.0"),
                    Location = new Point((int)(time * scaleFactor) + 20 - 5, line.Height + 10), // Adjust Y position to be below the line
                    AutoSize = true,
                    Font = new Font("Segoe UI", 8f)
                };

                if (counter == 0)
                {
                    timeLabel.Location = new Point((int)(time * scaleFactor)+15, line.Height + 10); // Adjust Y position to be below the line
                }
                timelinePanel.Controls.Add(timeLabel);
                counter++;
            }

            _timeLineContainer.Height = rowHeight + timelineHeight;
            _timeLineContainer.Refresh();

            ResultsDisplay?.Invoke();
            var orderedCompletedProc = completedProcesses.OrderBy(p => p.ProcessId).ToList();
            InitializeResultTableRows(orderedCompletedProc);
            DisplayAverageStats(completedProcesses);

            MessageBox.Show($"Turn Around Time: {_UserProcessData.First().TurnAroundTime}");
            //MessageBox.Show(chart, "Gantt Chart Data", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }


        private Color GetContrastColor(Color color)
        {
            // Calculate the perceptive luminance (human eye favors green color)
            double luminance = (0.299 * color.R + 0.587 * color.G + 0.114 * color.B) / 255;
            return luminance > 0.5 ? Color.Black : Color.White;
        }


        public async void DisplayAverageStats(List<Process> _completed)
        {
            if (_completed == null || _completed.Count == 0)
            {
                MessageBox.Show("No completed processes to display stats.");
                return;
            }

            double totalWaitingTime = 0;
            double totalTurnAroundTime = 0;
            double totalCompletionTime = 0;

            foreach (var process in _completed)
            {
                // Assuming your process already has these correct values:
                totalWaitingTime += process.WaitingTime;
                totalTurnAroundTime += process.TurnAroundTime;
                totalCompletionTime += process.CompletionTime;
            }

            double averageWaitingTime = totalWaitingTime / _completed.Count;
            double averageTurnAroundTime = totalTurnAroundTime / _completed.Count;
            double averageCompletionTime = totalCompletionTime / _completed.Count;

            KryptonPanel statsPanelContainer = new KryptonPanel()
            {
                Size = new Size(700, 50),
                StateCommon =
        {
            Color1 = Color.White,
            Color2 = Color.White,
            ColorStyle = PaletteColorStyle.Linear,
            ColorAngle = 90f
        },
                Dock = DockStyle.Bottom
            };

            Label waitingTimeLabel = new Label
            {
                Text = $"Average Waiting Time: {averageWaitingTime:0.00}",
                Location = new Point(20, 15),
                AutoSize = true,
                Font = new Font("Segoe UI", 10f, FontStyle.Bold)
            };

            Label turnAroundTimeLabel = new Label
            {
                Text = $"Average Turnaround Time: {averageTurnAroundTime:0.00}",
                Location = new Point(250, 15),
                AutoSize = true,
                Font = new Font("Segoe UI", 10f, FontStyle.Bold)
            };

            Label completionTimeLabel = new Label
            {
                Text = $"Average Completion Time: {averageCompletionTime:0.00}",
                Location = new Point(500, 15),
                AutoSize = true,
                Font = new Font("Segoe UI", 10f, FontStyle.Bold)
            };

            statsPanelContainer.Controls.Add(waitingTimeLabel);
            statsPanelContainer.Controls.Add(turnAroundTimeLabel);
            statsPanelContainer.Controls.Add(completionTimeLabel);

            _timeLineContainer.Controls.Add(statsPanelContainer);
            _timeLineContainer.Height += statsPanelContainer.Height;

            _timeLineContainer.Refresh();
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

}