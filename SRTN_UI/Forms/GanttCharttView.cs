using Krypton.Toolkit;
using SRTN_UI.Logic;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace SRTN_UI.Forms
{
    public partial class GanttChartView : KryptonForm
    {
        public static GanttChartView instance;
        private List<Process> _processedData;


        private KryptonPanel _tableContainer;
        private TableView _tableView;
        private TableHeader _tableHeader;
        private FlowLayoutPanel _tableRowContainer;
        private FlowLayoutPanel _trial;
        private TableItemRow[] _tableRow;

        private Action GanttChartReady;

        private const int MaxVisibleRows = 5;
        private const int RowHeight = 50;
        private const int RowSpacing = 20;
        private const int BaseContainerHeight = 60; 

        public GanttChartView()
        {
            InitializeComponent();
            this.Load += async (s,e) => await InitializeEvents();

        }

        public async Task InitializeEvents()
        {
            this.Shown += async (s, e) =>
            {
                //MessageBox.Show("")
                InitializeTableContainer();
                //await Task.Delay(5000);
                await InitializeTableView();
                await Task.Delay(1000);
                //List<Process> dummyData = new List<Process>();
                //dummyData.Add(new Process(1, "Process 1", 5, 0));
                //dummyData.Add(new Process(2, "Process 2", 3, 1));
                //dummyData.Add(new Process(3, "Process 3", 2, 2));
                //dummyData.Add(new Process(4, "Process 4", 4, 3));
                //dummyData.Add(new Process(5, "Process 5", 1, 4));
                InitializeTableRows(_processedData);
                await Task.Delay(1000);
                GanttChartReady?.Invoke();
            };

            GanttChartReady += async () =>
            {
                await Task.Delay(1000);
                InitializeGanttChart();
            };
        }

        private async void InitializeTableRows(List<Process> processData)
        {
            _tableRow = new TableItemRow[processData.Count];

            // Calculate the maximum height (for 5 rows)
            int maxHeight = BaseContainerHeight + (MaxVisibleRows * (RowHeight));

            // Set initial container size
            if (processData.Count <= MaxVisibleRows)
            {
                _tableContainer.Size = new Size(_tableContainer.Width,
                    BaseContainerHeight + (processData.Count * (RowHeight + RowSpacing)));
                _tableContainer.AutoScroll = true;
            }
            else
            {
                _tableContainer.Size = new Size(_tableContainer.Width, maxHeight);
                _tableContainer.AutoScroll = false;
            }

            for (int i = 0; i < processData.Count; i++)
            {
                _tableRow[i] = new TableItemRow(processData[i])
                {
                    Size = new Size(processData.Count <= 5 ? _tableContainer.Width - 10 : _tableContainer.Width - 22,
                                  RowHeight),
                    BackColor = Color.Red,
                };

                _tableRowContainer.Controls.Add(_tableRow[i]);
                if (processData.Count <= MaxVisibleRows)
                {
                    _tableContainer.Size = new Size(_tableContainer.Width,
                        BaseContainerHeight + ((i + 1) * (RowHeight + RowSpacing)));
                }

                await Task.Delay(500).ConfigureAwait(true);
            }

            await AnimatePanelX(_tableContainer, _tableContainer.Location.X, 12, 400).ConfigureAwait(true);
            await AnimatePanelY(_tableContainer, _tableContainer.Location.Y, 12, 400).ConfigureAwait(true);
        }
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



        public async void InitializeTableContainer()
        {
            _tableContainer = new KryptonPanel()
            {
                Name = "TableContainer",
                Size = new Size(705, BaseContainerHeight),

                //BackColor = Color.FromArgb(48, 56, 65),
                
                StateCommon =
                {
                    //Color1 = Color.FromArgb(48, 56, 65),
                    Color1 = Color.White,
                    //Color2 = Color.FromArgb(48, 56, 65),
                    Color2 = Color.White,
                    ColorStyle = PaletteColorStyle.Linear,
                    ColorAngle = 90f
                }
            };
            CenterTableContainer(_tableContainer);
            Controls.Add(_tableContainer);
            _tableContainer.BringToFront();

            int startY = (this.ClientSize.Height + _tableContainer.Height);
            int endY = (this.ClientSize.Height - 500) - (500  / 2);
            await AnimatePanelY(_tableContainer, startY, endY);

        }
        private void CenterTableContainer(KryptonPanel panelToCenter)
        {
            if (panelToCenter == null || panelToCenter.IsDisposed) return;

            panelToCenter.Location = new Point(
                (ClientSize.Width - panelToCenter.Width) / 2,
                (ClientSize.Height - panelToCenter.Height) / 2
            );
        }
        private async Task AnimatePanelY(KryptonPanel panel, int startY, int endY,int durationMs = 500)
        {
            if (panel.InvokeRequired)
            {
                panel.Invoke(new Action(async () => await AnimatePanelY(panel, startY,endY, durationMs)));
                return;
            }

            //panel.Location = new Point((this.ClientSize.Width - panel.Width), startY);
            //panel.StateCommon.Color1 = Color.FromArgb(48, 56, 65);
            //panel.StateCommon.Color2 = Color.FromArgb(48, 56, 65);
            panel.Visible = true;

            int steps = 60;
            int delayPerStep = durationMs / steps;

            for (int i = 0; i <= steps; i++)
            {
                double progress = EaseOutQuad(i / (double)steps);
                int newY = startY + (int)((endY - startY) * progress);
                panel.Location = new Point(panel.Location.X,newY);
                await Task.Delay(delayPerStep);
            }
        }

        private async Task AnimatePanelX(KryptonPanel panel, int starX, int endX, int durationMs = 500)
        {
            if (panel.InvokeRequired)
            {
                panel.Invoke(new Action(async () => await AnimatePanelX(panel, starX, endX, durationMs)));
                return;
            }
            //panel.Location = new Point((this.ClientSize.Width - panel.Width), startY);
            //panel.StateCommon.Color1 = Color.FromArgb(48, 56, 65);
            //panel.StateCommon.Color2 = Color.FromArgb(48, 56, 65);
            panel.Visible = true;

            int steps = 60;
            int delayPerStep = durationMs / steps;

            for (int i = 0; i <= steps; i++)
            {
                double progress = EaseOutQuad(i / (double)steps);
                int newX = starX + (int)((endX- starX) * progress);
                panel.Location = new Point( newX, panel.Location.Y);
                await Task.Delay(delayPerStep);
            }
        }


        public void InitializeGanttChart() 
        {
            var ganttChart = new GanttChart
            {
                Dock = DockStyle.Fill,
                BackColor = Color.White,
                //PanelStyle = PaletteBackStyle.PanelClient
            };
            
            //// Add sample processes
            //ganttChart.AddBar("P1", Color.Red, 0, 3.5f);
            //ganttChart.AddBar("P2", Color.Blue, 3.5f, 2f);
            //ganttChart.AddBar("P3", Color.Green, 5.5f, 4f);
            //ganttChart.AddBar("P1", Color.Red, 0, 3.5f);
            //ganttChart.AddBar("P2", Color.Blue, 3.5f, 2f);
            //ganttChart.AddBar("P3", Color.Green, 5.5f, 4f);
            //ganttChart.AddBar("P1", Color.Red, 0, 3.5f);
            //ganttChart.AddBar("P2", Color.Blue, 3.5f, 2f);
            //ganttChart.AddBar("P3", Color.Green, 5.5f, 4f);

            foreach(Process proc in _processedData)
            {
                ganttChart.AddBar(proc.ProcessId.ToString(), Color.Red, proc.ArrivalTime, proc.OriginalBurstTime);
            }

            ChartContainer.Controls.Add(ganttChart);
        }




        public void SetProcessData(List<Process> processData)
        {
            _processedData = processData;

        }
        private double EaseOutQuad(double progress) => 1 - Math.Pow(1 - progress, 2);
        public static GanttChartView GetInstance()
        {
            if (instance == null || instance.IsDisposed)
            {
                instance = new GanttChartView();
                instance.Show();
            }
            else
            {
                instance.BringToFront();
            }
            return instance;
        }

        public static GanttChartView GetInstance(KryptonPanel panelContainer)
        {
            if (instance == null || instance.IsDisposed)
            {
                instance = new GanttChartView();
                instance.TopLevel = false;
                instance.FormBorderStyle = FormBorderStyle.None;
                instance.Dock = DockStyle.Fill;
                panelContainer.Controls.Clear();
                panelContainer.Controls.Add(instance);
                instance.Show();
            }
            else
            {
                instance.BringToFront();
            }
            return instance;
        }
    }
}