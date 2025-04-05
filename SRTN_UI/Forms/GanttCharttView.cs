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
        private DataGridView _ganttChartGrid;

        public GanttChartView()
        {
            InitializeComponent();

        }



        public void SetProcessData(List<Process> processData)
        {
            _processedData = processData;

        }

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