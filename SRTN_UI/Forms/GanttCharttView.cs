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
        private MainView _mainView;

        // Data
        private List<Process> _UserProcessData;
        private List<Process> completedProcesses;
        private List<ProcessBlock> processBlocks;


        private double currentTime = 0;
        private double maxAllowedTime = 5;
        private double maxProcessCompletionTime = 0;
        private bool _isResultsDisplayed = false;

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
            Color.FromArgb(93, 173, 226),   // Soft Blue
            Color.FromArgb(88, 214, 141),   // Mint Green
            Color.FromArgb(245, 176, 65),   // Soft Orange
            Color.FromArgb(165, 105, 189),  // Soft Purple
            Color.FromArgb(231, 76, 60),    // Coral Red
            Color.FromArgb(52, 152, 219),   // Sky Blue
            Color.FromArgb(46, 204, 113),   // Emerald Green
            Color.FromArgb(241, 196, 15),   // Sunflower Yellow
            Color.FromArgb(26, 188, 156),   // Teal
            Color.FromArgb(149, 165, 166)   // Grayish Silver
        };

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

        private KryptonPanel _averageResultContainer;
        private ResultsDisplay _averageResultsDisplay;
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
            completedProcesses = new List<Process>();
            processBlocks = new List<ProcessBlock>();
            currentTime = 0;
            ReplayBtn.Enabled = false;
            ComputeBtn.Enabled = false;
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

            };
            ResultsDisplay += async () =>
            {
                if (_isResultsDisplayed) return;

                InitializeResultTableContainer();
                await InitializeResultTableView();
                await Task.Delay(1000);
                var completedSortedList = completedProcesses
                    .OrderBy(p => p.ProcessId).ToList();
                InitializeResultTableRows(completedSortedList ?? _dummyData);
                await Task.Delay(1000);
                InitializeAverageResultsContainer();
                DisplayAverageStats(completedSortedList);
                await Task.Delay(1000);

            };
            ReplayBtn.Click += async (s,e) =>
            {
                _timeLineContainer.Controls.Clear();
                await Task.Delay(1000);
                RenderGanttChart(processBlocks, currentTime, maxProcessCompletionTime > maxAllowedTime);
                ReplayBtn.Enabled = false;
                await Task.Delay(1000);

            };
            ComputeBtn.Click += async (s, e) =>
            {
                var completedSortedList = completedProcesses
                    .OrderBy(p => p.ProcessId).ToList();

                if (completedSortedList == null || completedSortedList.Count == 0)
                {
                    MessageBox.Show("No processes to compute.");
                    return;
                }

                ShowComputationDetails(completedSortedList); // Shows detailed math
                //DisplayAverageStats(completed);    // Shows final values
            };
            HomeBtn.Click += (s, e) =>
            {
                if (_mainView != null)
                {
                    var result = MessageBox.Show("Are you sure you want to Home?",
                        "Gantt Chart Table", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (result == DialogResult.Yes)
                    {
                        _mainView.ShowPanel(_mainView.MainScreen); // 👈 Go back to main screen
                        this.Dispose();
                    }
                }
            };
        }

        public void SetMainView(MainView mainView)
        {
            _mainView = mainView;
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

            int endX = 61;
            int endY = 12; 
            await AnimatePanelX(_tableContainer, _tableContainer.Location.X, endX, 500);
            await AnimatePanelY(_tableContainer, _tableContainer.Location.Y, endY, 500);
            //await AnimatePanelToPosition(_tableContainer, 12, 400);
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

            _resultTableContainer.Location = new Point(this.ClientSize.Width, 0); 

            Controls.Add(_resultTableContainer);
            _resultTableContainer.BringToFront();

            int destinationX = this.ClientSize.Width - _resultTableContainer.Width - 61;
            int destinationY = _resultTableContainer.Height - 50; 

            // Animate the panel's X and Y positions (from right to the destination)
            await AnimatePanelX(_resultTableContainer, _resultTableContainer.Location.X, destinationX, 500); 
            await AnimatePanelY(_resultTableContainer, _resultTableContainer.Location.Y, destinationY, 500); 

        }

        public async void InitializeAverageResultsContainer()
        {
            _averageResultContainer = new KryptonPanel()
            {
                //1454, 143
                Name = "Average Result Display",
                Size = new Size(1376, 100),  // Size of the panel
                StateCommon =
                {
                    Color1 = Color.White,
                    Color2 = Color.White,
                    ColorStyle = PaletteColorStyle.Linear,
                    ColorAngle = 90f
                }
            };

           _averageResultContainer.Location = new Point(this.ClientSize.Width, 432);

            Controls.Add(_averageResultContainer);
            _averageResultContainer.BringToFront();
            //62, 443
            //int destinationX = this.ClientSize.Width - _resultTableContainer.Width - 100;
            //int destinationY = _resultTableContainer.Height - 50;
            //40, 459
            //19, 459
            //53, 43
            ////164, 432
            ///62, 457
            int destinationX = 61;
            int destinationY = 470;
            // Animate the panel's X and Y positions (from right to the destination)

            await AnimatePanelX(_averageResultContainer, _averageResultContainer.Location.X, destinationX, 500);
            await AnimatePanelY(_averageResultContainer, _averageResultContainer.Location.Y, destinationY, 500);
        }


        public async void InitializeGanttChartContainer(List<Process> processData)
        {

            _ganttChartContainer.BringToFront();
            //3, 608
            await AnimatePanelY(_ganttChartContainer, this.ClientSize.Height + _ganttChartContainer.Height, 608);
            _ganttChartContainer.BringToFront();
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
        // Logic
        public async void StartSRTNScheduling(List<Process> processData)
        {
            List<Process> processes = new List<Process>(processData ?? _dummyData);
            processBlocks = new List<ProcessBlock>();
            double timeIncrement = 0.1, smallTolerance = 0.0001;
            currentTime = 0;
            maxProcessCompletionTime = 0;
            int colorCounter = 0;

            Process currentProcess = null, previousProcess = null;
            ProcessBlock currentBlock = null;

            foreach (var p in processes)
            {
                p.CurrentBurstTime = p.OriginalBurstTime;
                p.Status = ProcessStatus.New;
                p.PreemptionPairs = new();
                p.FirstStartTime = null;
                if (p.AssignedColor == Color.Empty)
                    p.AssignedColor = _processColors[colorCounter++ % _processColors.Length];
            }

            while (completedProcesses.Count < processes.Count)
            {
                // Mark ready processes
                foreach (var p in processes.Where(p => Math.Round(p.ArrivalTime, 2) <= Math.Round(currentTime, 2) && p.Status == ProcessStatus.New))
                    p.Status = ProcessStatus.Ready;

                // Select process with shortest remaining time
                var readyProcesses = processes
                    .Where(p => p.Status == ProcessStatus.Ready || p.Status == ProcessStatus.Running)
                    .OrderBy(p => p.CurrentBurstTime)
                    .ThenBy(p => p.ArrivalTime)
                    .ThenBy(p => p.ProcessId)
                    .ToList();

                if (readyProcesses.Any())
                {
                    var selected = readyProcesses.First();

                    // Process switching logic
                    if (previousProcess?.ProcessId != selected.ProcessId)
                    {
                        if (currentBlock != null)
                        {
                            currentBlock.EndTime = Math.Round(currentTime, 2);
                            processBlocks.Add(currentBlock);
                        }

                        if (previousProcess?.Status == ProcessStatus.Running)
                        {
                            previousProcess.Status = ProcessStatus.Ready;
                            previousProcess.PreemptionPairs.Add((Math.Round(currentTime, 2), -1));
                        }

                        if (selected.PreemptionPairs.LastOrDefault().ResumeTime == -1)
                        {
                            var last = selected.PreemptionPairs[^1];
                            selected.PreemptionPairs[^1] = (last.PreemptTime, Math.Round(currentTime, 2));
                        }

                        currentBlock = new ProcessBlock(selected.ProcessId, Math.Round(currentTime, 2),
                            Math.Round(currentTime + timeIncrement, 2), selected.ProcessName, selected.AssignedColor);
                    }
                    else
                    {
                        currentBlock.EndTime = Math.Round(currentTime + timeIncrement, 2);
                    }

                    if (selected.FirstStartTime == null)
                        selected.FirstStartTime = Math.Round(currentTime, 2);

                    selected.Status = ProcessStatus.Running;
                    selected.CurrentBurstTime -= timeIncrement;

                    if (selected.CurrentBurstTime <= smallTolerance)
                    {
                        selected.Status = ProcessStatus.Terminated;
                        selected.CompletionTime = Math.Round(currentTime + timeIncrement, 2);
                        selected.TurnAroundTime = Math.Round(selected.CompletionTime - selected.ArrivalTime, 2);

                        // Compute waiting time
                        double waiting = (selected.FirstStartTime ?? selected.ArrivalTime) - selected.ArrivalTime;
                        waiting += selected.PreemptionPairs
                            .Where(p => p.ResumeTime > p.PreemptTime)
                            .Sum(p => p.ResumeTime - p.PreemptTime);
                        selected.WaitingTime = Math.Round(waiting, 2);

                        completedProcesses.Add(selected);

                        if (currentBlock != null)
                        {
                            currentBlock.EndTime = Math.Round(currentTime + timeIncrement, 2);
                            processBlocks.Add(currentBlock);
                            currentBlock = null;
                        }

                        maxProcessCompletionTime = Math.Max(maxProcessCompletionTime, selected.CompletionTime);
                    }

                    previousProcess = selected;
                }
                else
                {
                    // IDLE block
                    if (currentBlock == null || currentBlock.ProcessId != -1)
                    {
                        if (currentBlock != null)
                        {
                            currentBlock.EndTime = Math.Round(currentTime, 2);
                            processBlocks.Add(currentBlock);
                        }

                        currentBlock = new ProcessBlock(-1, Math.Round(currentTime, 2),
                            Math.Round(currentTime + timeIncrement, 2), "Idle", Color.LightGray);
                    }
                    else
                    {
                        currentBlock.EndTime = Math.Round(currentTime + timeIncrement, 2);
                    }
                }

                currentTime = Math.Round(currentTime + timeIncrement, 2);
            }

            //MessageBox.Show($"Max Process Completion Time : {Math.Round(maxProcessCompletionTime, 2)} vs Max Allowed Time: {maxAllowedTime}");
            RenderGanttChart(processBlocks, currentTime, maxProcessCompletionTime > maxAllowedTime);
            await Task.Delay(1000);

        }

        private async void RenderGanttChart(List<ProcessBlock> processBlocks, double totalTime, bool shouldShrink)
        {
            _timeLineContainer.Controls.Clear();
            _timeLineContainer.AutoScroll = true;

            if (processBlocks == null || processBlocks.Count == 0) return;

            int containerWidth = _timeLineContainer.Width - 50;
            int minVisibleWidth = 50;
            int minIdleBlockWidth = 15;

            double scaleFactor = containerWidth / Math.Max(totalTime, 1);
            if (shouldShrink)
                scaleFactor *= 0.7;

            int rowHeight = 70, timelineHeight = 50, margin = 11;

            var ganttRowPanel = new Panel
            {
                Height = rowHeight,
                Dock = DockStyle.Top,
                BackColor = Color.FromArgb(238, 238, 238),
                Padding = new Padding(0, 0, 0, margin),
            };

            var timelinePanel = new Panel
            {
                Height = timelineHeight,
                Dock = DockStyle.Top,
                BackColor = Color.FromArgb(238, 238, 238),
            };

            _timeLineContainer.Controls.Add(timelinePanel);
            _timeLineContainer.Controls.Add(ganttRowPanel);

            var timelineLabelTimes = new HashSet<double>();

            int currentX = 20; // Start rendering from 20px offset

            foreach (var block in processBlocks)
            {
                double duration = block.EndTime - block.StartTime;
                int rawWidth = (int)(duration * scaleFactor);

                int blockWidth = rawWidth;
                bool forcedMinWidth = false;

                if (block.ProcessId == -1)
                {
                    blockWidth = Math.Max(minIdleBlockWidth, rawWidth);
                }
                else
                {
                    if (rawWidth < minVisibleWidth)
                    {
                        blockWidth = minVisibleWidth;
                        forcedMinWidth = true;
                    }
                }

                if (blockWidth <= 0) continue;

                int blockX = currentX;
                currentX += blockWidth;

                var blockPanel = new Panel
                {
                    BackColor = block.ProcessColor,
                    Location = new Point(blockX, margin),
                    Size = new Size(blockWidth, rowHeight - 2 * margin),
                    Anchor = AnchorStyles.Left | AnchorStyles.Top,
                    BorderStyle = BorderStyle.FixedSingle
                };

                var label = new Label
                {
                    Text = block.ProcessName,
                    ForeColor = GetContrastColor(block.ProcessColor),
                    TextAlign = ContentAlignment.MiddleCenter,
                    Dock = DockStyle.Fill,
                    Font = new Font("Poppins", 10, FontStyle.Bold)
                };

                blockPanel.Controls.Add(label);
                ganttRowPanel.Controls.Add(blockPanel);
                ganttRowPanel.Refresh();

                foreach (var time in new[] { block.StartTime, block.EndTime })
                {
                    if (timelineLabelTimes.Contains(time)) continue;
                    timelineLabelTimes.Add(time);

                    int x;
                    if (time == block.EndTime)
                        x = blockX + blockWidth;
                    else
                        x = blockX;

                    var line = new Panel
                    {
                        BackColor = Color.Black,
                        Location = new Point(x, 0),
                        Size = new Size(1, 15),
                        Anchor = AnchorStyles.Top | AnchorStyles.Left
                    };
                    timelinePanel.Controls.Add(line);

                    var timeLabel = new Label
                    {
                        Text = time.ToString("0.0"),
                        Location = new Point(x - 5, line.Height + 10),
                        AutoSize = true,
                        Font = new Font("Poppins", 10, FontStyle.Bold)
                    };
                    timelinePanel.Controls.Add(timeLabel);
                }

                _timeLineContainer.Refresh();
                await Task.Delay(1500);
            }

            ResultsDisplay?.Invoke();
            _isResultsDisplayed = true;
            ReplayBtn.Enabled = true;
        }




        //private async void RenderGanttChart(List<ProcessBlock> processBlocks, double totalTime, bool shouldShrink)
        //{
        //    _timeLineContainer.Controls.Clear();
        //    _timeLineContainer.AutoScroll = true;

        //    if (processBlocks == null || processBlocks.Count == 0) return;

        //    // Constants
        //    //int containerWidth = 1454;
        //    //int maxBlockWidthPerTimeUnit = 25;  // Max width per 1ms
        //    //int minBlockWidthPerTimeUnit = 15;  // Min width per 1ms
        //    //int minVisibleWidth = 15;           // Absolute minimum width for any block
        //    //int minIdleBlockWidth = 15;        // Minimum width for idle blocks

        //    //// Calculate scale factor dynamically
        //    //double scaleFactor = containerWidth / Math.Max(totalTime, 1);
        //    //if (shouldShrink) scaleFactor *= 0.6;
        //    // Per-block constraints
        //    //int minVisibleWidth = 20;
        //    //int maxVisibleWidth = 20;

        //    // Clamp scale factor to enforce min/max block sizes
        //    //scaleFactor = Math.Clamp(scaleFactor, minBlockWidthPerTimeUnit, maxBlockWidthPerTimeUnit);

        //    int containerWidth = _timeLineContainer.Width - 50;
        //    int maxBlockWidthPerTimeUnit = 25;
        //    int minBlockWidthPerTimeUnit = 20;
        //    int minIdleBlockWidth = 30; // Minimum width for idle blocks to ensure visibility
        //    int minVisibleWidth = 30;           // Absolute minimum width for any block

        //    double scaleFactor = containerWidth / Math.Max(totalTime, 1);
        //    if (shouldShrink)
        //    {
        //        // Shrink if any process exceeded the maxAllowedTime
        //        scaleFactor *= 0.7; // Example: Shrink by half if exceeding limit
        //    }

        //    //scaleFactor = Math.Min(scaleFactor, maxBlockWidthPerTimeUnit);
        //    //scaleFactor = Math.Max(scaleFactor, minBlockWidthPerTimeUnit);

        //    int rowHeight = 70, timelineHeight = 50, margin = 11;

        //    // Create panels for Gantt row and timeline
        //    var ganttRowPanel = new Panel
        //    {
        //        Height = rowHeight,
        //        Dock = DockStyle.Top,
        //        BackColor = Color.FromArgb(238, 238, 238),
        //        Padding = new Padding(0, 0, 0, margin),
        //    };

        //    var timelinePanel = new Panel
        //    {
        //        Height = timelineHeight,
        //        Dock = DockStyle.Top,
        //        BackColor = Color.FromArgb(238, 238, 238),
        //    };

        //    _timeLineContainer.Controls.Add(timelinePanel);
        //    _timeLineContainer.Controls.Add(ganttRowPanel);

        //    var timelineLabelTimes = new HashSet<double>();

        //    foreach (var block in processBlocks)
        //    {
        //        // Calculate block width with scaling
        //        //int blockWidth = (int)((block.EndTime - block.StartTime) * scaleFactor);

        //        //// For Idle blocks, ensure a minimum width for visibility
        //        //if (block.ProcessId == -1)
        //        //{
        //        //    blockWidth = Math.Max(minIdleBlockWidth, (int)((block.EndTime - block.StartTime) * scaleFactor));
        //        //}
        //        //else
        //        //{
        //        //    //blockWidth = Math.Max(minIdleBlockWidth, (int)((block.EndTime - block.StartTime) * scaleFactor));
        //        //}

        //        double duration = block.EndTime - block.StartTime;
        //        int rawWidth = (int)(duration * scaleFactor);


        //        int blockWidth = rawWidth;
        //        if (block.ProcessId == -1)
        //        {
        //            // Idle block: enforce minimum width only
        //            blockWidth = Math.Max(minIdleBlockWidth, rawWidth);
        //        }

        //        if (blockWidth <= 0) continue;

        //        // === Render process block ===
        //        Panel blockPanel = new Panel
        //        {
        //            BackColor = block.ProcessColor,
        //            Location = new Point((int)(block.StartTime * scaleFactor) + 20, margin),
        //            Size = new Size(blockWidth, rowHeight - 2 * margin),
        //            Anchor = AnchorStyles.Left | AnchorStyles.Top,
        //            BorderStyle = BorderStyle.FixedSingle
        //        };

        //        Label label = new Label
        //        {
        //            Text = block.ProcessName,
        //            ForeColor = GetContrastColor(block.ProcessColor),
        //            TextAlign = ContentAlignment.MiddleCenter,
        //            Dock = DockStyle.Fill,
        //            Font = new Font("Poppins", 10, FontStyle.Bold)
        //        };

        //        blockPanel.Controls.Add(label);
        //        ganttRowPanel.Controls.Add(blockPanel);
        //        ganttRowPanel.Refresh();

        //        // === Add timeline markers ===
        //        foreach (var time in new[] { block.StartTime, block.EndTime })
        //        {
        //            if (timelineLabelTimes.Contains(time)) continue;

        //            timelineLabelTimes.Add(time);
        //            int x = (int)(time * scaleFactor) + 20;

        //            var line = new Panel
        //            {
        //                BackColor = Color.Black,
        //                Location = new Point(x, 0),
        //                Size = new Size(1, 15),
        //                Anchor = AnchorStyles.Top | AnchorStyles.Left
        //            };
        //            timelinePanel.Controls.Add(line);

        //            var timeLabel = new Label
        //            {
        //                Text = time.ToString("0.0"),
        //                Location = new Point(x - 5, line.Height + 10),
        //                AutoSize = true,
        //                Font = new Font("Poppins", 10, FontStyle.Bold)
        //            };
        //            timelinePanel.Controls.Add(timeLabel);
        //        }

        //        _timeLineContainer.Refresh();
        //        await Task.Delay(1500); // Optional: Animation delay
        //    }

        //    ResultsDisplay?.Invoke();
        //    _isResultsDisplayed = true;
        //    ReplayBtn.Enabled = true;
        //}


        //private async void RenderGanttChart(List<ProcessBlock> processBlocks, double totalTime, bool shouldShrink)
        //{
        //    _timeLineContainer.Controls.Clear();
        //    _timeLineContainer.AutoScroll = true;

        //    if (processBlocks == null || processBlocks.Count == 0) return;

        //    int containerWidth = 1454;
        //    int maxBlockWidthPerTimeUnit = 15;
        //    int minBlockWidthPerTimeUnit = 10;
        //    int minIdleBlockWidth = 10;

        //    double scaleFactor = containerWidth / Math.Max(totalTime, 1);
        //    if (shouldShrink) scaleFactor *= 0.6;

        //    scaleFactor = Math.Clamp(scaleFactor, minBlockWidthPerTimeUnit, maxBlockWidthPerTimeUnit);

        //    int rowHeight = 80, timelineHeight = 60, margin = 11;

        //    var ganttRowPanel = new Panel
        //    {
        //        Height = rowHeight,
        //        Dock = DockStyle.Top,
        //        BackColor = Color.FromArgb(238, 238, 238),
        //        Padding = new Padding(0,0, 0, margin),
        //    };

        //    var timelinePanel = new Panel
        //    {
        //        Height = timelineHeight,
        //        Dock = DockStyle.Top,
        //        BackColor = Color.FromArgb(238, 238, 238),

        //    };

        //    _timeLineContainer.Controls.Add(timelinePanel);
        //    _timeLineContainer.Controls.Add(ganttRowPanel);

        //    var timelineLabelTimes = new HashSet<double>();

        //    foreach (var block in processBlocks)
        //    {
        //        int blockWidth = (int)((block.EndTime - block.StartTime) * scaleFactor);    
        //        int minVisibleWidth = 10;

        //        if (block.ProcessId == -1)
        //        {
        //            blockWidth = Math.Max(minIdleBlockWidth, blockWidth);
        //        }
        //        else
        //        {
        //            blockWidth = Math.Max(minVisibleWidth, blockWidth);
        //        }

        //        if (blockWidth <= 0) continue;

        //        // === Render process block ===
        //        var blockPanel = new Panel
        //        {
        //            BackColor = block.ProcessColor,
        //            Location = new Point((int)(block.StartTime * scaleFactor) + 20, margin),
        //            Size = new Size(blockWidth, rowHeight - 2 * margin),
        //            Anchor = AnchorStyles.Left | AnchorStyles.Top,
        //            BorderStyle = BorderStyle.FixedSingle
        //        };

        //        var label = new Label
        //        {
        //            Text = block.ProcessName,
        //            ForeColor = GetContrastColor(block.ProcessColor),
        //            TextAlign = ContentAlignment.MiddleCenter,
        //            Dock = DockStyle.Fill,
        //            Font = new Font("Poppins", 10, FontStyle.Bold)
        //        };

        //        blockPanel.Controls.Add(label);
        //        ganttRowPanel.Controls.Add(blockPanel);
        //        ganttRowPanel.Refresh();

        //        // === Add timeline markers for this block's start and end ===
        //        foreach (var time in new[] { block.StartTime, block.EndTime })
        //        {
        //            if (timelineLabelTimes.Contains(time)) continue;

        //            timelineLabelTimes.Add(time);
        //            int x = (int)(time * scaleFactor) + 20;

        //            var line = new Panel
        //            {
        //                BackColor = Color.Black,
        //                Location = new Point(x, 0),
        //                Size = new Size(1, 15),
        //                Anchor = AnchorStyles.Top | AnchorStyles.Left
        //            };
        //            timelinePanel.Controls.Add(line);

        //            var timeLabel = new Label
        //            {
        //                Text = time.ToString("0.0"),
        //                Location = new Point(x - 5, line.Height + 10),
        //                AutoSize = true,
        //                Font = new Font("Poppins", 10, FontStyle.Bold)
        //            };
        //            timelinePanel.Controls.Add(timeLabel);

        //            timelinePanel.Refresh();
        //        }

        //        _timeLineContainer.Refresh();
        //        await Task.Delay(2000);
        //    }

        //    //_timeLineContainer.Height = rowHeight + timelineHeight;
        //    ResultsDisplay?.Invoke();
        //    _isResultsDisplayed = true;
        //    ReplayBtn.Enabled = true;
        //}



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

            double averageWaitingTime = Math.Round(totalWaitingTime / _completed.Count,2);
            double averageTurnAroundTime = Math.Round(totalTurnAroundTime / _completed.Count,2);
            double averageCompletionTime = Math.Round(totalCompletionTime / _completed.Count, 2);

            _averageResultsDisplay = new ResultsDisplay(averageWaitingTime, averageCompletionTime, averageTurnAroundTime);
            _averageResultContainer.Controls.Add(_averageResultsDisplay);
            _averageResultsDisplay.BringToFront();
            ComputeBtn.Enabled = true;
 
        }

        public void ShowComputationDetails(List<Process> _completed)
        {
            if (_completed == null || _completed.Count == 0)
            {
                MessageBox.Show("No completed processes to compute details.");
                return;
            }

            MessageBox.Show($"Completed Count: {_completed.Count}");

            StringBuilder waitingTimeExp = new StringBuilder();
            StringBuilder turnAroundTimeExp = new StringBuilder();
            StringBuilder completionTimeExp = new StringBuilder();
            StringBuilder fullExplanation = new StringBuilder();

            double totalWaitingTime = 0;
            double totalTurnAroundTime = 0;
            double totalCompletionTime = 0;

            for (int i = 0; i < _completed.Count; i++)
            {
                Process proc = _completed[i];

                // --- Completion Time ---
                double completionTime = Math.Round(proc.CompletionTime, 2);

                // --- Turnaround Time ---
                double turnAroundTime = Math.Round(proc.CompletionTime - proc.ArrivalTime, 2);
                proc.TurnAroundTime = turnAroundTime;

                // --- Waiting Time ---
                double startTime = proc.FirstStartTime ?? proc.ArrivalTime;
                if (startTime < proc.ArrivalTime)
                {
                    startTime = proc.ArrivalTime; // Prevent negative
                }
                double waiting = startTime - proc.ArrivalTime;

                var preemptionBreakdown = new StringBuilder();
                double preemptSum = 0;

                if (proc.PreemptionPairs != null)
                {
                    foreach (var pair in proc.PreemptionPairs
                        .Where(pr => pr.ResumeTime > pr.PreemptTime)
                        .OrderBy(pr => pr.PreemptTime))
                    {
                        double diff = Math.Max(0, pair.ResumeTime - pair.PreemptTime);
                        preemptSum += diff;
                        preemptionBreakdown.Append($" + ({pair.ResumeTime} - {pair.PreemptTime})");
                    }
                }

                waiting += preemptSum;
                proc.WaitingTime = Math.Max(0, Math.Round(waiting, 2)); // Ensure non-negative

                // --- Expression building ---
                waitingTimeExp.Append(proc.WaitingTime);
                turnAroundTimeExp.Append(proc.TurnAroundTime);
                completionTimeExp.Append(proc.CompletionTime);

                if (i != _completed.Count - 1)
                {
                    waitingTimeExp.Append(" + ");
                    turnAroundTimeExp.Append(" + ");
                    completionTimeExp.Append(" + ");
                }

                totalWaitingTime += proc.WaitingTime;
                totalTurnAroundTime += proc.TurnAroundTime;
                totalCompletionTime += proc.CompletionTime;

                // --- Detailed breakdown per process ---
                fullExplanation.AppendLine($"{proc.ProcessName}:");
                string waitFormula = $"({proc.FirstStartTime ?? proc.ArrivalTime} - {proc.ArrivalTime}){preemptionBreakdown}";
                fullExplanation.AppendLine($"  WT  = {waitFormula} = {proc.WaitingTime} msec.");
                fullExplanation.AppendLine($"  CT  = {proc.CompletionTime} msec.");
                fullExplanation.AppendLine($"  TAT = ({proc.CompletionTime} - {proc.ArrivalTime}) = {proc.TurnAroundTime} msec.\n");
            }

            double averageWaitingTime = Math.Round(totalWaitingTime / _completed.Count, 2);
            double averageTurnAroundTime = Math.Round(totalTurnAroundTime / _completed.Count, 2);
            double averageCompletionTime = Math.Round(totalCompletionTime / _completed.Count, 2);

            string avgWaitStr = $"= ({waitingTimeExp}) / {_completed.Count} = {averageWaitingTime} msec.\n\n";
            string avgTATStr = $"= ({turnAroundTimeExp}) / {_completed.Count} = {averageTurnAroundTime} msec.\n\n";
            string avgCTStr = $"= ({completionTimeExp}) / {_completed.Count} = {averageCompletionTime} msec.";

            // Combine everything to show
            ComputationForm compForm = new ComputationForm();
            compForm.SetData(avgWaitStr, avgCTStr, avgTATStr, fullExplanation.ToString());
            compForm.ShowDialog();
        }



        // Logic

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

        private void _timeLineContainer_Paint(object sender, PaintEventArgs e)
        {

        }
    }

}