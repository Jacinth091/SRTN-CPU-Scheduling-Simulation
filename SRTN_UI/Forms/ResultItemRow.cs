using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SRTN_UI.Logic;

namespace SRTN_UI.Forms
{
    public partial class ResultItemRow : UserControl
    {
        public ResultItemRow()
        {
            InitializeComponent();
        }

        public ResultItemRow(Process process)
        {
            InitializeComponent();
            ProcessIdCol.Text = process.ProcessId.ToString();
            OriginalBurstCol.Text = process.OriginalBurstTime.ToString();
            ArrivalCol.Text = process.ArrivalTime.ToString();
            //CurrentBurstCol.Text = process.CurrentBurstTime.ToString();
            CompletionTimeCol.Text = process.CompletionTime.ToString();
            WaitingTimeCol.Text = process.WaitingTime.ToString();
            TurnAroundTimeCol.Text = process.TurnAroundTime.ToString();
            //StatusCol.Text = process.Status.ToString();
        }
    }
}
