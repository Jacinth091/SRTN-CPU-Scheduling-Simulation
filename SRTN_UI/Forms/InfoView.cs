using System;
using System.Collections.Generic;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;
using Krypton.Toolkit;

namespace SRTN_UI.Forms
{
    public partial class InfoView : KryptonForm
    {
        private List<KryptonPanel> infoPanels = new List<KryptonPanel>();
        private int currentPanelIndex = 0;
        private const int TARGET_X = 137;
        private const int TARGET_Y = 24;
        private const int ANIMATION_DURATION = 300;
        private const int ANIMATION_STEPS = 20;
        public static InfoView _instance;
        private MainView _mainView;

        public InfoView()
        {
            InitializeComponent();
            InitializeInfoPanels();
            InitializeNavigation();
        }

        private void InitializeInfoPanels()
        {
            MainContainer.Controls.Add(PanelOne);
            MainContainer.Controls.Add(PanelTwo);
            MainContainer.Controls.Add(PanelThree);
            MainContainer.Controls.Add(PanelFour);
            infoPanels.Clear();
            infoPanels.Add(PanelOne);
            infoPanels.Add(PanelTwo);
            infoPanels.Add(PanelThree);
            infoPanels.Add(PanelFour);

            // Initialize panel positions
            PanelOne.Location = new Point(TARGET_X, TARGET_Y);
            PanelOne.Visible = true;

            // Position other panels off-screen to the right
            for (int i = 1; i < infoPanels.Count; i++)
            {
                infoPanels[i].Location = new Point(this.ClientSize.Width, TARGET_Y);
                infoPanels[i].Visible = false;
            }
        }

        private void InitializeNavigation()
        {
            PreviousBtn.Click += (s, e) => Navigate(-1);
            NextButton.Click += (s, e) => Navigate(1);
            GoBackBtn.Click += (s, e) => 
            {
                if (_mainView != null)
                {
                    var result = MessageBox.Show("Are you sure you want to Home?",
                        "Gantt Chart Table", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (result == DialogResult.Yes)
                    {
                        _mainView.ShowPanel(_mainView.MainScreen); // 👈 Go back to main screen
                        this.Dispose();
                    }
                }

            };
            UpdateNavigationButtons();
        }

        private void UpdateNavigationButtons()
        {
            PreviousBtn.Enabled = currentPanelIndex > 0;
            NextButton.Enabled = currentPanelIndex < infoPanels.Count - 1;
        }

        private async void Navigate(int direction)
        {
            if ((direction < 0 && currentPanelIndex == 0) ||
                (direction > 0 && currentPanelIndex == infoPanels.Count - 1))
                return;

            var oldPanel = infoPanels[currentPanelIndex];
            currentPanelIndex += direction;
            var newPanel = infoPanels[currentPanelIndex];

            // Set initial positions for animation
            newPanel.Location = new Point(
                direction > 0 ? this.ClientSize.Width : -newPanel.Width,
                TARGET_Y);
            newPanel.Visible = true;
            newPanel.BringToFront();

            int delay = ANIMATION_DURATION / ANIMATION_STEPS;
            int oldPanelTargetX = TARGET_X + (direction * oldPanel.Width);

            for (int i = 0; i <= ANIMATION_STEPS; i++)
            {
                float progress = EaseInOutCubic((float)i / ANIMATION_STEPS);

                // Animate new panel
                int newX = Lerp(newPanel.Location.X, TARGET_X, progress);
                // Animate old panel
                int oldX = Lerp(oldPanel.Location.X, oldPanelTargetX, progress);

                newPanel.Location = new Point(newX, TARGET_Y);
                oldPanel.Location = new Point(oldX, TARGET_Y);

                await Task.Delay(delay);
            }

            // Final cleanup
            oldPanel.Visible = false;
            newPanel.Location = new Point(TARGET_X, TARGET_Y);
            UpdateNavigationButtons();
        }

        // Helper methods for smooth animation
        private int Lerp(int start, int end, float amount)
        {
            return start + (int)((end - start) * amount);
        }

        private float EaseInOutCubic(float x)
        {
            return x < 0.5f ? 4 * x * x * x : 1 - (float)Math.Pow(-2 * x + 2, 3) / 2;
        }

        public static InfoView GetInstance(KryptonPanel panelContainer)
        {
            if (_instance == null || _instance.IsDisposed)
            {
                _instance = new InfoView();
                _instance.TopLevel = false;
                _instance.FormBorderStyle = FormBorderStyle.None;
                _instance.Dock = DockStyle.Fill;
                panelContainer.Controls.Clear();
                panelContainer.Controls.Add(_instance);
                _instance.Show();
            }
            else
            {
                _instance.BringToFront();
            }
            return _instance;
        }
        public void SetMainView(MainView mainView)
        {
            _mainView = mainView;
        }

    }
}