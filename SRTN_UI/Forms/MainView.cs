using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SRTN_UI.Forms;
using SRTN_UI.Logic;
using Krypton.Toolkit;


namespace SRTN_UI.Forms
{
    public partial class MainView : KryptonForm
    {
        public event EventHandler ContinueEvent;
        public event EventHandler ProceedEvent;
        public event EventHandler StartEvent;
        public event EventHandler InfoEvent;
        public event EventHandler AboutEvent;
        public event EventHandler GoBackEvent;
        private KryptonPanel _currentPanel;
        private KryptonForm _currentForm;

        public KryptonPanel MainScreen => MainScreenPanel;


        public MainView()
        {
            InitializeComponent();
            InitializeEvents();

            ShowPanel(MainTitlePanel);
        }

        public void InitializeEvents()
        {
            ContinueBtn.Click += (s, e) =>
            {
                //MessageBox.Show("Pressed");
                ContinueEvent?.Invoke(this, EventArgs.Empty);
                ShowProcessTableView(MainPanelLoader);
                //ShowGanttChartView(MainPanelLoader, new List<Process>());

            };
            this.FormClosing += OnFormClosing;
            InfoBtn.Click += (s, e) =>
            {
                InfoEvent?.Invoke(this, EventArgs.Empty);
                ShowInfoView(MainPanelLoader);
            };


        }

        private void OnFormClosing(object? sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        public void ShowPanel(KryptonPanel panelToLoad)
        {
            if (MainPanelLoader.InvokeRequired)
            {
                MainPanelLoader.Invoke(new Action(() => ShowPanel(panelToLoad)));
                return;
            }


            MainPanelLoader.Controls.Clear();
            panelToLoad.Visible = true;
            panelToLoad.Dock = DockStyle.Fill;
            MainPanelLoader.Controls.Add(panelToLoad);
            _currentPanel = panelToLoad;
        }

        public void ShowProcessTableView(KryptonPanel panelContainer)
        {
            ProcessTableView processTable = ProcessTableView.GetInstance(panelContainer);
            processTable.setMainView(this); // 👈 Pass reference here
            panelContainer.Controls.Clear();
            panelContainer.Controls.Add((Control)processTable);
            ((Control)processTable).Dock = DockStyle.Fill;


            processTable.ProcessDataReady += (processData) =>
            {
                MessageBox.Show("Process data is ready");
                ShowGanttChartView(panelContainer, processData);
                processTable.Dispose();
            };
        }

        public void ShowGanttChartView(KryptonPanel panelContainer, List<Process> processedData)
        {
            GanttChartView ganttChartView = GanttChartView.GetInstance(panelContainer);
            ganttChartView.SetProcessData(processedData);
            ganttChartView.SetMainView(this); // 👈 Pass reference here
            panelContainer.Controls.Clear();
            panelContainer.Controls.Add(ganttChartView);
            ganttChartView.Dock = DockStyle.Fill;
        }
        public void ShowAboutView(KryptonPanel panelContainer)
        {
            //AboutView aboutView = AboutView.GetInstance(panelContainer);
            //panelContainer.Controls.Clear();
            //panelContainer.Controls.Add((Control)aboutView);
            //((Control)aboutView).Dock = DockStyle.Fill;
        }
        public void ShowInfoView(KryptonPanel panelContainer)
        {
            InfoView infoView = InfoView.GetInstance(panelContainer);
            //ganttChartView.SetProcessData(processedData);
            infoView.SetMainView(this); // 👈 Pass reference here
            panelContainer.Controls.Clear();
            panelContainer.Controls.Add(infoView);
            infoView.Dock = DockStyle.Fill;
        }
        public void ShowMainView()
        {

        }
    }
}
