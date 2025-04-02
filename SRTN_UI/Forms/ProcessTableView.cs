using Krypton.Toolkit;
using System;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SRTN_UI.Forms
{
    public partial class ProcessTableView : KryptonForm
    {
        public static ProcessTableView instance;

        public event EventHandler GenerateTableEvent;
        public event EventHandler TableAppearEvent;
        public event EventHandler ProceedEvent;
        public event EventHandler GoBackEvent;

        private KryptonPanel _tableContainer;
        private FlowLayoutPanel _tablePanel;
        private ProcessHeader _tableHeader;
        private ProcessRow[] _tableItemRow;



        //private KryptonPanel
        private const int _noOfCol = 3;
        private readonly int _tableContainerWidth = 1072;
        private readonly int _tableContainerHeight = 621;
        private double EaseOutQuad(double progress) => 1 - Math.Pow(1 - progress, 2);

        private int _processCount = 0;
        private bool TransitionInFlag = false;
        private bool TransitionOutFlag = false;
        private bool _isAnimating = false;

        public ProcessTableView()
        {
            InitializeComponent();
            InitializeEvents();
            this.Resize += (s, e) => CenterTableContainer(); // Handle form resize
        }

        private void InitializeEvents()
        {
            GenerateBtn.Click += async (s, e) =>
            {
                if(_isAnimating) { return; }
                GenerateEventAnimation();

                TableAppearEvent?.Invoke(this, EventArgs.Empty);
            };
        }

        public async void GenerateEventAnimation() 
        {
            _isAnimating = true;
            try
            {
                _processCount = GetProcessCount();
                if (_isAnimating)
                {
                    await AnimateInputPanel();
                    if (TransitionInFlag)
                    {
                        InitializeTable();
                        await Task.Delay(500);
                        GenerateTableItems();
                    }
                }
            }
            finally
            {
                _isAnimating = false ;
            }


        }

        public int GetProcessCount() => Convert.ToInt32(Numeric.Value);

        public async Task AnimateInputPanel()
        {

            if (InputContainer.InvokeRequired)
            {
                InputContainer.Invoke(new Action(async () => await AnimateInputPanel()));
                return;
            }

            //if (_isAnimating) { return; }
            int startY = InputContainer.Top;
            const int endY = 12;
            const int steps = 50;
            const int delayMs = 10;

            InputContainer.Top = startY;
            InputContainer.Visible = true;

            for (int i = 0; i <= steps; i++)
            {
                if (InputContainer.IsDisposed) break;

                double progress = (double)i / steps;
                double easedProgress = Math.Sin(progress * Math.PI / 2);
                int newY = startY + (int)((endY - startY) * easedProgress);

                InputContainer.Top = newY;
                await Task.Delay(delayMs);
            }
            TransitionInFlag = true;
        }

        public async void InitializeTable()
        {
            if (_isAnimating && _tableContainer != null) return;
            if (_tableContainer != null )
            {
                if (!_tableContainer.IsDisposed)
                {
                    Controls.Remove(_tableContainer);
                    _tableContainer.Dispose();
                }
                _tableContainer = null;
            }

            // Create new centered table
            _tableContainer = new KryptonPanel()
            {
                Name = "ProcessTable",
                Size = new Size(_tableContainerWidth, _tableContainerHeight),
                StateCommon =
                {
                    Color1 = Color.FromArgb(238,238,238),
                    Color2 = Color.FromArgb(238,238,238),
                    ColorStyle = PaletteColorStyle.Linear,
                    ColorAngle = 90f
                }
            };

            CenterTableContainer();
            Controls.Add(_tableContainer);
            _tableContainer.BringToFront();


            await AnimatePanelSlideIn(_tableContainer);
        }

        private void CenterTableContainer()
        {
            if (_tableContainer == null || _tableContainer.IsDisposed) return;

            _tableContainer.Location = new Point(
                (ClientSize.Width - _tableContainer.Width) / 2,
                (ClientSize.Height - _tableContainer.Height)
            );

            MessageBox.Show($"Width: {_tableContainer.Width} And Height: {_tableContainer.Height}");
        }

        public async Task AnimatePanelSlideIn(KryptonPanel panel, int durationMs = 500)
        {
            if (panel.InvokeRequired)
            {
                panel.Invoke(new Action(async () => await AnimatePanelSlideIn(panel, durationMs)));
                return;
            }

            int startY = (this.ClientSize.Height + panel.Height); // Start below the form
            int endY = (this.ClientSize.Height - panel.Height - 12); // Center vertically
            panel.Location = new Point((this.ClientSize.Width - panel.Width) / 2, startY);
            panel.Visible = true;

            int steps = 50;
            int delayPerStep = durationMs / steps;

            for (int i = 0; i <= steps; i++)
            {
                double progress = EaseOutQuad(i / (double)steps); // Smooth easing
                int newY = startY + (int)((endY - startY) * progress);
                panel.Top = newY;
                await Task.Delay(delayPerStep);
            }
        }

        public void GenerateTableItems()
        {

            _tableContainer.Controls.Clear();

 
            _tableHeader = new ProcessHeader()
            {
                Dock = DockStyle.Top,
                Height = 40 
            };

            _tablePanel = new FlowLayoutPanel
            {
                Dock = DockStyle.Fill, 
                AutoScroll = true,
                BorderStyle = BorderStyle.FixedSingle,
                FlowDirection = FlowDirection.TopDown,
                WrapContents = false,
                BackColor = Color.White
            };

            _tableContainer.Controls.Add(_tablePanel);

            _tableContainer.Controls.Add(_tableHeader);

            GenerateProcessRows();
        }

        public void GenerateProcessRows()
        {
            _tableItemRow = new ProcessRow[_processCount];

            for (int i = 0; i < _processCount; i++)
            {
                _tableItemRow[i] = new ProcessRow()
                {
                    ProcessTitleText = $"P{(i + 1)}"
                };
                _tablePanel.Controls.Add(_tableItemRow[i]);
            }
        }



        public static ProcessTableView GetInstance(KryptonPanel panelContainer)
        {
            if (instance == null || instance.IsDisposed)
            {
                instance = new ProcessTableView();
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