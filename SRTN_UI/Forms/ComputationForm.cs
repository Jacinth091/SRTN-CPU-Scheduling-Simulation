using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Krypton.Toolkit;

namespace SRTN_UI.Forms
{
    public partial class ComputationForm : KryptonForm
    {
        public ComputationForm()
        {
            InitializeComponent();
        }
        public void SetData(string wt, string ct, string tat, string fullExplanation)
        {
            PerProcessData.Text = fullExplanation.ToString();
            avgWait.Text = wt.ToString();
            avgComp.Text = ct.ToString();
            avgTurn.Text = tat.ToString();
        }

    }
}
