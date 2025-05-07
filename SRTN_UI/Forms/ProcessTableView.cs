using Krypton.Toolkit;
using SRTN_UI.Logic;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SRTN_UI.Forms
{
    public partial class ProcessTableView : KryptonForm
    {
        #region Constants and Fields
        private const int NUMBER_OF_COLUMNS = 3;
        private const int TABLE_CONTAINER_WIDTH = 1072;
        private const int TABLE_CONTAINER_HEIGHT = 621;
        private const int MAX_INPUT_VALUE = 15;
        private const int MIN_INPUT_VALUE = 0;
        private const string TIME_SUFFIX = " msec";

        private bool _isProcessExecuted = false;

        public static ProcessTableView Instance;
        private MainView _mainView;

        public event EventHandler GenerateTableEvent;
        public event EventHandler TableAppearEvent;
        public event EventHandler ProceedEvent;
        public event EventHandler GoBackEvent;
        public event Action<List<Process>> ProcessDataReady;

        private KryptonPanel _tableContainer;
        private FlowLayoutPanel _tablePanel;
        private ProcessHeader _tableHeader;
        private ProcessRow[] _tableItemRows;
        private KryptonTextBox[,] _tableRowTextBoxes;

        private int _processCount = 0;
        private int _currentRowIndex = 0;
        private int _textBoxFilledCount = 0;

        private bool _transitionInFlag = false;
        private bool _transitionOutFlag = false;
        private bool _isAnimating = false;
        private bool _hasTextBoxesFilled = false;
        private bool _collectingBurstTimes = true;
        #endregion

        #region Constructor and Initialization
        public ProcessTableView()
        {
            InitializeComponent();
            InitializeEvents();
            //this.Resize += (s, e) => CenterTableContainer();

        }

        private void InitializeEvents()
        {

            this.Shown += (s, e) => ProceedBtn.Enabled = false;
            this.MouseClick += MouseClickEvent;

            GenerateBtn.Click += async (s, e) =>
            {
                if (_isAnimating) return;
                await GenerateEventAnimationAsync();
                TableAppearEvent?.Invoke(this, EventArgs.Empty);
            };

            ProceedBtn.Click += (s, e) =>
            {
                //if (_isProcessExecuted) return;
                var processList = GetProcessData();
                var result = MessageBox.Show("Are you sure you want to proceed?",
                    "Review Table", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                //_isProcessExecuted = false;
                ProceedBtn.Enabled = false; // Optional: disable the button
                if (result == DialogResult.Yes)
                {
                    ProcessDataReady?.Invoke(processList);
                }
                else
                {
                    ProceedBtn.Enabled = true;
                }
            };

            GoBackBtn.Click += (s, e) =>
            {
                if (_mainView != null)
                {
                    var result = MessageBox.Show("Are you sure you want to go back?",
                    "Go Back", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (result == DialogResult.Yes)
                    {
                        _mainView.ShowPanel(_mainView.MainScreen);
                    }
                }
            };

            Numeric.ValueChanged += (s, e) => ValidateNumericInput();
            Numeric.KeyUp += (s, e) =>
            {
                if (e.KeyCode == Keys.Enter)
                {
                    ValidateNumericInput();
                }
            };
        }

        private void MouseClickEvent(object? sender, MouseEventArgs e)
        {
            CheckAllTextBoxesFilled();
        }

        private void ValidateNumericInput()
        {
            decimal value = Numeric.Value;

            // Check if value is below minimum (2)
            if (value < Numeric.Minimum)
            {
                MessageBox.Show($"Value cannot be less than {Numeric.Minimum}.", "Invalid Input",
                               MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Numeric.Value = Numeric.Minimum;
                return;
            }

            // Check if value is above maximum (5)
            if (value > Numeric.Maximum)
            {
                MessageBox.Show($"Value cannot be greater than {Numeric.Maximum}.", "Invalid Input",
                               MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Numeric.Value = Numeric.Maximum;
                return;
            }

            // Check for negative values (though your min is 2, this is redundant but included per your request)
            if (value < 0)
            {
                MessageBox.Show("Negative values are not allowed.", "Invalid Input",
                               MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Numeric.Value = Numeric.Minimum;
                return;
            }
        }

        #endregion

        #region Public Methods
        public static ProcessTableView GetInstance(KryptonPanel panelContainer)
        {
            if (Instance == null || Instance.IsDisposed)
            {
                Instance = new ProcessTableView
                {
                    TopLevel = false,
                    FormBorderStyle = FormBorderStyle.None,
                    Dock = DockStyle.Fill
                };

                panelContainer.Controls.Clear();
                panelContainer.Controls.Add(Instance);
                Instance.Show();
            }
            else
            {
                Instance.BringToFront();
            }
            return Instance;
        }

        public int GetProcessCount() => Convert.ToInt32(Numeric.Value);

        public List<Process> GetProcessData()
        {
            var processList = new List<Process>();

            for (int i = 0; i < _processCount; i++)
            {
                string burstTimeText = CleanTimeText(_tableRowTextBoxes[i, 0].Text);
                string arrivalTimeText = CleanTimeText(_tableRowTextBoxes[i, 1].Text);

                if (double.TryParse(burstTimeText, out double burstTime) &&
                    double.TryParse(arrivalTimeText, out double arrivalTime))
                {
                    processList.Add(new Process(
                        _processId: (i + 1),
                        _processName: $"P{(i + 1)}",
                        _burstTime: burstTime,
                        _arrivalTime: arrivalTime
                    ));
                }
            }

            return processList;
        }
        #endregion

        #region Animation Methods
        public async Task GenerateEventAnimationAsync()
        {
            _isAnimating = true;
            try
            {
                _processCount = GetProcessCount();
                if (_isAnimating)
                {
                    await AnimateInputPanelAsync();
                    if (_transitionInFlag)
                    {
                        InitializeTableAsync();
                        //await Task.Delay(200);
                        GenerateTableItems();
                    }
                }
            }
            finally
            {
                _isAnimating = false;
            }
        }

        private async Task AnimateInputPanelAsync()
        {
            if (InputContainer.InvokeRequired)
            {
                InputContainer.Invoke(new Action(async () => await AnimateInputPanelAsync()));
                return;
            }

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
            _transitionInFlag = true;
        }

        private async void InitializeTableAsync()
        {
            if (_isAnimating && _tableContainer != null) return;

            CleanupExistingTable();

            _tableContainer = new KryptonPanel()
            {
                Name = "ProcessTable",
                Size = new Size(TABLE_CONTAINER_WIDTH, TABLE_CONTAINER_HEIGHT),
                BackColor = Color.Transparent,
                StateCommon =
                    {
                        Color1 = Color.Transparent,
                        Color2 = Color.Transparent,
                        ColorStyle = PaletteColorStyle.Linear,
                        ColorAngle = 90f
                    }
            };

            CenterTableContainer();
            Controls.Add(_tableContainer);

            _tableContainer.BringToFront();

            await AnimatePanelSlideInAsync(_tableContainer);
        }

        private async Task AnimatePanelSlideInAsync(KryptonPanel panel, int durationMs = 500)
        {
            if (panel.InvokeRequired)
            {
                panel.Invoke(new Action(async () => await AnimatePanelSlideInAsync(panel, durationMs)));
                return;
            }

            int startY = (this.ClientSize.Height + panel.Height);
            int endY = (this.ClientSize.Height - panel.Height - 30);
            panel.Location = new Point((this.ClientSize.Width - panel.Width) / 2, startY);
            panel.StateCommon.Color1 = Color.Transparent;
            panel.StateCommon.Color2 = Color.Transparent;
            panel.Visible = true;

            int steps = 50;
            int delayPerStep = durationMs / steps;

            for (int i = 0; i <= steps; i++)
            {
                double progress = EaseOutQuad(i / (double)steps);
                int newY = startY + (int)((endY - startY) * progress);
                panel.Top = newY;
                await Task.Delay(delayPerStep);
            }
        }
        #endregion

        #region Table Generation Methods
        private void GenerateTableItems()
        {
            _tableContainer.Controls.Clear();
            _tableHeader = new ProcessHeader()
            {
                Dock = DockStyle.Top,
                Height = 40,
                BackColor = Color.Transparent
            };
            _tablePanel = new FlowLayoutPanel
            {
                Dock = DockStyle.Fill,
                AutoScroll = true,
                BorderStyle = BorderStyle.None,
                FlowDirection = FlowDirection.TopDown,
                WrapContents = false,
                BackColor = Color.FromArgb(48, 56, 65),
                Padding = new Padding(3, 5, 0, 5)
            };

            _tableContainer.Controls.Add(_tableHeader);
            _tableContainer.Controls.Add(_tablePanel);


            _tableHeader.BringToFront();
            _tablePanel.BringToFront();

            GenerateProcessRows();
        }

        private async void GenerateProcessRows()
        {
            _tableItemRows = new ProcessRow[_processCount];
            _tableRowTextBoxes = new KryptonTextBox[_processCount, 2];

            for (int i = 0; i < _processCount; i++)
            {
                _tableItemRows[i] = new ProcessRow()
                {
                    ProcessTitleText = $"P{(i + 1)}",
                    Size = new Size(_processCount <= 6 ? _tableContainer.Width - 13 : _tableContainer.Width - 28, 80),
                    BackColor = Color.Transparent
                };

                _tableRowTextBoxes[i, 0] = _tableItemRows[i].BurstTimeTB;
                _tableRowTextBoxes[i, 1] = _tableItemRows[i].ArrivalTimeTB;

                _tableRowTextBoxes[i, 0].Enabled = true;
                _tableRowTextBoxes[i, 1].Enabled = false;

                await Task.Delay(500);
                _tablePanel.Controls.Add(_tableItemRows[i]);
            }

            InitializeTextBoxEvents();
        }
        #endregion

        #region Helper Methods
        private void CenterTableContainer()
        {
            if (_tableContainer == null || _tableContainer.IsDisposed) return;

            _tableContainer.Location = new Point(
                (ClientSize.Width - _tableContainer.Width) / 2,
                (ClientSize.Height - _tableContainer.Height) / 3
            );
        }

        private void CleanupExistingTable()
        {
            if (_tableContainer != null)
            {
                if (!_tableContainer.IsDisposed)
                {
                    Controls.Remove(_tableContainer);
                    _tableContainer.Dispose();
                }
                _tableContainer = null;
            }
        }

        private double EaseOutQuad(double progress) => 1 - Math.Pow(1 - progress, 2);

        private string CleanTimeText(string text) => text.Replace(TIME_SUFFIX, "").Trim();
        #endregion

        #region TextBox Handling
        private void InitializeTextBoxEvents()
        {
            for (int i = 0; i < _processCount; i++)
            {
                int currentIndex = i;

                SetupTextBoxEvents(_tableRowTextBoxes[i, 0], currentIndex, isBurstTime: true);
                SetupTextBoxEvents(_tableRowTextBoxes[i, 1], currentIndex, isBurstTime: false);
            }
        }

        private void SetupTextBoxEvents(KryptonTextBox textBox, int index, bool isBurstTime)
        {
            // TextChanged handler - disable proceed button on any change
            textBox.TextChanged += (s, e) =>
            {
                // Delay check in case of race conditions (optional)
                BeginInvoke((Action)(() => CheckAllTextBoxesFilled()));
            };

            // Existing Enter handler
            textBox.Enter += (s, e) =>
            {
                textBox.Text = CleanTimeText(textBox.Text);
            };

            // Modified Leave handler - checks ALL fields
            textBox.Leave += (s, e) =>
            {
                string cleanText = CleanTimeText(textBox.Text);
                if (!string.IsNullOrWhiteSpace(cleanText))
                {
                    if (!ValidateInput(cleanText, isBurstTime ? "burst time" : "arrival time", isBurstTime))
                    {
                        textBox.Clear();
                        return;
                    }
                }
                FormatTimeTextBox(textBox);
                CheckAllTextBoxesFilled(); // Check ALL fields whenever any field loses focus
            };

            textBox.KeyDown += (s, e) =>
            {
                if (e.KeyCode == Keys.Enter)
                {
                    e.SuppressKeyPress = true;
                    e.Handled = true;
                    HandleEnterKeyPress(textBox, index, isBurstTime);
                }
            };


        }

        private void FormatTimeTextBox(KryptonTextBox textBox)
        {
            string cleanText = CleanTimeText(textBox.Text);
            if (double.TryParse(cleanText, out _) && !string.IsNullOrWhiteSpace(cleanText))
            {
                textBox.Text = cleanText + TIME_SUFFIX;
            }
        }

        private void HandleEnterKeyPress(KryptonTextBox textBox, int index, bool isBurstTime)
        {
            string cleanText = CleanTimeText(textBox.Text);

            if (!ValidateInput(cleanText, isBurstTime ? "burst time" : "arrival time", isBurstTime))
            {
                textBox.Clear();
                return;
            }

            textBox.Text = cleanText;
            FormatTimeTextBox(textBox);

            if (isBurstTime)
            {
                HandleBurstTimeNavigation(index);
            }
            else
            {
                HandleArrivalTimeNavigation(index);
            }

            // Check ALL fields after navigation
            CheckAllTextBoxesFilled();
        }

        private bool ValidateInput(string text, string fieldName, bool isBurstTime)
        {
            if (!double.TryParse(text, out double value) || string.IsNullOrWhiteSpace(text))
            {
                MessageBox.Show($"Please enter a valid {fieldName}");
                return false;
            }

            if (isBurstTime)
            {
                // Burst time validation (2-15)
                if (value < MIN_INPUT_VALUE + 2 || value > MAX_INPUT_VALUE)
                {
                    MessageBox.Show($"Burst time must be between {MIN_INPUT_VALUE + 2} and {MAX_INPUT_VALUE} msec");
                    return false;
                }
            }
            else
            {
                // Arrival time validation (0-15)
                if (value < MIN_INPUT_VALUE || value > MAX_INPUT_VALUE || value < 0)
                {
                    MessageBox.Show($"Arrival time must be between {MIN_INPUT_VALUE} and {MAX_INPUT_VALUE} msec");
                    return false;
                }
            }

            return true;
        }

        private void CheckAllTextBoxesFilled()
        {
            bool allValid = true;

            for (int i = 0; i < _processCount; i++)
            {
                string burstText = CleanTimeText(_tableRowTextBoxes[i, 0].Text);
                string arrivalText = CleanTimeText(_tableRowTextBoxes[i, 1].Text);

                if (string.IsNullOrWhiteSpace(burstText) || !double.TryParse(burstText, out _) ||
                    string.IsNullOrWhiteSpace(arrivalText) || !double.TryParse(arrivalText, out _))
                {
                    allValid = false;
                    break;
                }
            }

            ProceedBtn.Enabled = allValid;
        }

        private void HandleBurstTimeNavigation(int currentIndex)
        {
            if (string.IsNullOrWhiteSpace(_tableRowTextBoxes[currentIndex, 0].Text))
            {
                MessageBox.Show("Please enter burst time");
                _tableRowTextBoxes[currentIndex, 0].Focus();
                return;
            }

            if (currentIndex + 1 < _processCount)
            {
                _tableRowTextBoxes[currentIndex + 1, 0].Focus();
            }
            else
            {
                // Switch to arrival times
                for (int i = 0; i < _processCount; i++)
                {
                    _tableRowTextBoxes[i, 1].Enabled = true;
                    _tableRowTextBoxes[i, 0].Enabled = false;
                }
                _tableRowTextBoxes[0, 1].Focus();
            }
        }

        private async void HandleArrivalTimeNavigation(int currentIndex)
        {
            if (string.IsNullOrWhiteSpace(_tableRowTextBoxes[currentIndex, 1].Text))
            {
                MessageBox.Show("Please enter arrival time");
                return;
            }

            if (currentIndex + 1 < _processCount)
            {
                _tableRowTextBoxes[currentIndex + 1, 1].Focus();
            }
            else
            {
                _tableRowTextBoxes[currentIndex, 1].StateCommon.Back.Color1 = Color.LightGreen;
                await Task.Delay(300);

                this.Invoke(() =>
                {
                    // Enable all textboxes
                    foreach (var textBox in _tableRowTextBoxes)
                    {
                        textBox.Enabled = true;
                        if (textBox == _tableRowTextBoxes[currentIndex, 1])
                            textBox.StateCommon.Back.Color1 = Color.FromArgb(251, 251, 251);
                    }

                    // Final validation of ALL fields
                    CheckAllTextBoxesFilled();

                    // Focus proceed button only if enabled
                    if (ProceedBtn.Enabled)
                    {
                        ProceedBtn.Focus();
                    }
                });
            }
        }
        #endregion
        public void setMainView(MainView mainView)
        {
            _mainView = mainView;
        }

    }
}