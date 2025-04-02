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
        public ProcessRow()
        {
            InitializeComponent();
        }

    }
}
