﻿using System;
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
    public partial class TableItemRow : UserControl
    {
        public TableItemRow()
        {
            InitializeComponent();
        }

        public TableItemRow(Process process)
        {
            InitializeComponent();
            ProcessIdCol.Text = "P"+process.ProcessId.ToString();
            OriginalBurstCol.Text = process.OriginalBurstTime.ToString() + " msec.";
            ArrivalCol.Text = process.ArrivalTime.ToString() + " msec.";
            //CurrentBurstCol.Text = process.CurrentBurstTime.ToString();
            //WaitingCol.Text = process.WaitingTime.ToString();
            //TurnCol.Text = process.TurnAroundTime.ToString();
            //StatusCol.Text = process.Status.ToString();
        }
    }
}
