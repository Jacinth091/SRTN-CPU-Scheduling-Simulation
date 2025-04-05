using Krypton.Toolkit;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SRTN_UI.Forms
{
    public partial class ProcessRow : UserControl
    {
        public string ProcessTitleText
        {
            get => ProcessTitle.Text;
            set => ProcessTitle.Text = value?.Trim();
        }

        public KryptonTextBox ArrivalTimeTB { get => ArrivalTimeText; }
        public KryptonTextBox BurstTimeTB { get => BurstTimeText; }
        public ProcessRow()
        {
            InitializeComponent();

            // Add labels and textboxes to panel
            //this.Controls.Add(new KryptonLabel { Text = processName });
        }

        private void ArrivalTimeText_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
