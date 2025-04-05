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
                //List<Process> dummyData = new List<Process>();
                //dummyData.Add(new Process(1, "Process 1", 5, 0));
                //dummyData.Add(new Process(2, "Process 2", 3, 1));
                //dummyData.Add(new Process(3, "Process 3", 2, 2));
                //dummyData.Add(new Process(4, "Process 4", 4, 3));
                //dummyData.Add(new Process(5, "Process 5", 1, 4));
                InitializeTableRows(_processedData);

            };
        }

        private async void InitializeTableRows(List<Process> processData)
        {
            _tableRow = new TableItemRow[processData.Count];

            for (int i = 0; i < processData.Count; i++)
            {
                _tableRow[i] = new TableItemRow(processData[i])
                {
                    //Dock = DockStyle.Top,
                    Size = new Size(processData.Count <= 4 ? _tableContainer.Width - 13: _tableContainer.Width - 25, 73),
                    BackColor = Color.Red
                };

                //_tableView._tableContainer.Controls.Add(_tableRow[i]);
                _tableRowContainer.Controls.Add(_tableRow[i]);
                //_tableRow[i].BringToFront();
                await Task.Delay(1000).ConfigureAwait(true); // Return to UI context
            }

        }

        private async Task InitializeTableView()
        {
            //_tableView = new TableView()
            //{
            //    Dock = DockStyle.Fill,
            //    Height = 40,
            //    BackColor = Color.FromArgb(48, 56, 65),

            //};
            //_tableContainer.Controls.Add(_tableView);
            //_tableView.BringToFront();

            _tableContainer.Controls.Clear();
            _tableHeader = new TableHeader()
            {
                Dock = DockStyle.Top,
                Height = 80,
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
                Size = new Size(840, 400),

                BackColor = Color.FromArgb(48, 56, 65),
                
                StateCommon =
                {
                    Color1 = Color.FromArgb(48, 56, 65),
                    Color2 = Color.FromArgb(48, 56, 65),
                    ColorStyle = PaletteColorStyle.Linear,
                    ColorAngle = 90f
                }
            };
            CenterTableContainer(_tableContainer);
            Controls.Add(_tableContainer);
            _tableContainer.BringToFront();

            await AnimatePanelSlideInAsync(_tableContainer);

        }
        private void CenterTableContainer(KryptonPanel panelToCenter)
        {
            if (panelToCenter == null || panelToCenter.IsDisposed) return;

            panelToCenter.Location = new Point(
                (ClientSize.Width - panelToCenter.Width) / 2,
                (ClientSize.Height - panelToCenter.Height) / 2
            );
        }
        private async Task AnimatePanelSlideInAsync(KryptonPanel panel, int durationMs = 500)
        {
            if (panel.InvokeRequired)
            {
                panel.Invoke(new Action(async () => await AnimatePanelSlideInAsync(panel, durationMs)));
                return;
            }

            int startY = (this.ClientSize.Height + panel.Height);
            int endY = (this.ClientSize.Height - panel.Height) - (panel.Height / 2);
            //panel.Location = new Point((this.ClientSize.Width - panel.Width), startY);
            panel.StateCommon.Color1 = Color.FromArgb(48, 56, 65);
            panel.StateCommon.Color2 = Color.FromArgb(48, 56, 65);
            panel.Visible = true;

            int steps = 60;
            int delayPerStep = durationMs / steps;

            for (int i = 0; i <= steps; i++)
            {
                double progress = EaseOutQuad(i / (double)steps);
                int newY = startY + (int)((endY - startY) * progress);
                panel.Top = newY;
                await Task.Delay(delayPerStep);
            }
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