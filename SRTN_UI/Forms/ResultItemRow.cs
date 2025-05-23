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
    public partial class ResultItemRow : UserControl
    {
        public ResultItemRow()
        {
            InitializeComponent();
        }

        public ResultItemRow(Process process)
        {
            InitializeComponent();
            ProcessIdCol.Text = "P" + process.ProcessId.ToString();
            CompletionTimeCol.Text = process.CompletionTime.ToString() + " msec.";
            WaitingTimeCol.Text = process.WaitingTime.ToString() + " msec.";
            TurnAroundTimeCol.Text = process.TurnAroundTime.ToString() + " msec.";
            //StatusCol.Text = process.Status.ToString();
        }
    }
}
