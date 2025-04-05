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
        private KryptonPanel _currentPanel;
        private KryptonForm _currentForm;




        public MainView()
        {
            InitializeComponent();
            InitializeEvents();

            ShowPanel(MainTitlePanel);
        }

        public void InitializeEvents() 
        {
            ContinueBtn.Click += (s, e) => {
                //MessageBox.Show("Pressed");
                ContinueEvent?.Invoke(this, EventArgs.Empty);
                ShowProcessTableView(MainPanelLoader);
                //ShowGanttChartView(MainPanelLoader, new List<Process>());

            };
            this.FormClosing += OnFormClosing;

            //GenerateBtn.Click += (s, e) =>
            //{
            //    ProceedEvent?.Invoke(this, EventArgs.Empty);
            //    ShowPanel(MainTitlePanel);

            //};



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

            panelContainer.Controls.Clear();
            panelContainer.Controls.Add((Control)processTable);
            ((Control)processTable).Dock = DockStyle.Fill;


            processTable.ProcessDataReady += (processData) =>
            {
                MessageBox.Show("Process data is ready");
                ShowGanttChartView(panelContainer, processData);
            };
        }


        public void ShowGanttChartView(KryptonPanel panelContainer, List<Process> processedData)
        {
            GanttChartView ganttChartView = GanttChartView.GetInstance(panelContainer);
            ganttChartView.SetProcessData(processedData);
            panelContainer.Controls.Clear();
            panelContainer.Controls.Add((Control)ganttChartView);
            ((Control)ganttChartView).Dock = DockStyle.Fill;
        }

    }
}
