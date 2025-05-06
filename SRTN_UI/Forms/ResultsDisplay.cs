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
    public partial class ResultsDisplay : UserControl
    {
        public ResultsDisplay()
        {
            InitializeComponent();
        }
        public ResultsDisplay(double waiting, double completion, double turnAround)
        {
            InitializeComponent();
            WaitingTime.Text = waiting.ToString() + " msec.";
            CompletionTime.Text = completion.ToString() + " msec.";
            TurnAroundTime.Text = turnAround.ToString() + " msec.";
            //StatusCol.Text = process.Status.ToString();
        }

    }
}
