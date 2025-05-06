namespace SRTN_UI.Forms
{
    partial class GanttChartView
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            MainContainer = new Krypton.Toolkit.KryptonPanel();
            _ganttChartContainer = new Krypton.Toolkit.KryptonPanel();
            _timeLineContainer = new Krypton.Toolkit.KryptonPanel();
            _ganttChartPanel = new Krypton.Toolkit.KryptonPanel();
            ComputeBtn = new Krypton.Toolkit.KryptonButton();
            HomeBtn = new Krypton.Toolkit.KryptonButton();
            ReplayBtn = new Krypton.Toolkit.KryptonButton();
            kryptonLabel1 = new Krypton.Toolkit.KryptonLabel();
            ((System.ComponentModel.ISupportInitialize)MainContainer).BeginInit();
            MainContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)_ganttChartContainer).BeginInit();
            _ganttChartContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)_timeLineContainer).BeginInit();
            ((System.ComponentModel.ISupportInitialize)_ganttChartPanel).BeginInit();
            _ganttChartPanel.SuspendLayout();
            SuspendLayout();
            // 
            // MainContainer
            // 
            MainContainer.Controls.Add(_ganttChartContainer);
            MainContainer.Dock = DockStyle.Fill;
            MainContainer.Location = new Point(0, 0);
            MainContainer.MaximumSize = new Size(1506, 882);
            MainContainer.MinimumSize = new Size(1506, 882);
            MainContainer.Name = "MainContainer";
            MainContainer.Size = new Size(1506, 882);
            MainContainer.StateCommon.Color1 = Color.FromArgb(48, 56, 65);
            MainContainer.StateCommon.Color2 = Color.FromArgb(48, 56, 65);
            MainContainer.TabIndex = 0;
            // 
            // _ganttChartContainer
            // 
            _ganttChartContainer.Controls.Add(_timeLineContainer);
            _ganttChartContainer.Controls.Add(_ganttChartPanel);
            _ganttChartContainer.Location = new Point(3, 608);
            _ganttChartContainer.Name = "_ganttChartContainer";
            _ganttChartContainer.Padding = new Padding(20);
            _ganttChartContainer.Size = new Size(1503, 274);
            _ganttChartContainer.StateCommon.Color1 = Color.FromArgb(48, 56, 65);
            _ganttChartContainer.StateCommon.Color2 = Color.Gainsboro;
            _ganttChartContainer.TabIndex = 0;
            _ganttChartContainer.Visible = false;
            // 
            // _timeLineContainer
            // 
            _timeLineContainer.Dock = DockStyle.Fill;
            _timeLineContainer.Location = new Point(20, 82);
            _timeLineContainer.Name = "_timeLineContainer";
            _timeLineContainer.Size = new Size(1463, 172);
            _timeLineContainer.StateCommon.Color1 = Color.FromArgb(238, 238, 238);
            _timeLineContainer.TabIndex = 1;
            _timeLineContainer.Paint += _timeLineContainer_Paint;
            // 
            // _ganttChartPanel
            // 
            _ganttChartPanel.Controls.Add(ComputeBtn);
            _ganttChartPanel.Controls.Add(HomeBtn);
            _ganttChartPanel.Controls.Add(ReplayBtn);
            _ganttChartPanel.Controls.Add(kryptonLabel1);
            _ganttChartPanel.Dock = DockStyle.Top;
            _ganttChartPanel.Location = new Point(20, 20);
            _ganttChartPanel.Name = "_ganttChartPanel";
            _ganttChartPanel.Size = new Size(1463, 62);
            _ganttChartPanel.StateCommon.Color1 = Color.Transparent;
            _ganttChartPanel.TabIndex = 0;
            // 
            // ComputeBtn
            // 
            ComputeBtn.Anchor = AnchorStyles.None;
            ComputeBtn.Location = new Point(954, 7);
            ComputeBtn.Name = "ComputeBtn";
            ComputeBtn.OverrideDefault.Back.Color1 = Color.FromArgb(0, 123, 115);
            ComputeBtn.OverrideDefault.Back.Color2 = Color.FromArgb(0, 123, 115);
            ComputeBtn.OverrideDefault.Border.Rounding = 10F;
            ComputeBtn.OverrideDefault.Content.ShortText.Color1 = Color.White;
            ComputeBtn.OverrideDefault.Content.ShortText.Color2 = Color.White;
            ComputeBtn.OverrideDefault.Content.ShortText.Font = new Font("Poppins SemiBold", 12F, FontStyle.Bold);
            ComputeBtn.Size = new Size(230, 52);
            ComputeBtn.StateCommon.Back.Color1 = Color.FromArgb(0, 123, 115);
            ComputeBtn.StateCommon.Back.Color2 = Color.FromArgb(0, 123, 115);
            ComputeBtn.StateCommon.Border.Color1 = Color.FromArgb(0, 105, 98);
            ComputeBtn.StateCommon.Border.Color2 = Color.FromArgb(0, 105, 98);
            ComputeBtn.StateCommon.Border.Rounding = 10F;
            ComputeBtn.StateCommon.Border.Width = 2;
            ComputeBtn.StateCommon.Content.ShortText.Color1 = Color.White;
            ComputeBtn.StateCommon.Content.ShortText.Color2 = Color.White;
            ComputeBtn.StateCommon.Content.ShortText.Font = new Font("Poppins SemiBold", 12F, FontStyle.Bold);
            ComputeBtn.StateCommon.Content.ShortText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Center;
            ComputeBtn.StateCommon.Content.ShortText.TextV = Krypton.Toolkit.PaletteRelativeAlign.Center;
            ComputeBtn.StatePressed.Back.Color1 = Color.FromArgb(0, 95, 90);
            ComputeBtn.StatePressed.Back.Color2 = Color.FromArgb(0, 95, 90);
            ComputeBtn.StatePressed.Border.Color1 = Color.FromArgb(0, 80, 75);
            ComputeBtn.StatePressed.Border.Color2 = Color.FromArgb(0, 80, 75);
            ComputeBtn.StatePressed.Border.Rounding = 10F;
            ComputeBtn.StatePressed.Content.ShortText.Color1 = Color.White;
            ComputeBtn.StatePressed.Content.ShortText.Color2 = Color.White;
            ComputeBtn.StatePressed.Content.ShortText.Font = new Font("Poppins SemiBold", 12F, FontStyle.Bold);
            ComputeBtn.StateTracking.Back.Color1 = Color.FromArgb(0, 140, 130);
            ComputeBtn.StateTracking.Back.Color2 = Color.FromArgb(0, 140, 130);
            ComputeBtn.StateTracking.Border.Color1 = Color.FromArgb(0, 120, 110);
            ComputeBtn.StateTracking.Border.Color2 = Color.FromArgb(0, 120, 110);
            ComputeBtn.StateTracking.Border.Rounding = 10F;
            ComputeBtn.StateTracking.Content.ShortText.Color1 = Color.White;
            ComputeBtn.StateTracking.Content.ShortText.Color2 = Color.White;
            ComputeBtn.StateTracking.Content.ShortText.Font = new Font("Poppins SemiBold", 12F, FontStyle.Bold);
            ComputeBtn.TabIndex = 6;
            ComputeBtn.ToolTipValues.Description = "Click to display the computation result.";
            ComputeBtn.ToolTipValues.EnableToolTips = true;
            ComputeBtn.ToolTipValues.Heading = "Computation";
            ComputeBtn.ToolTipValues.ImageTransparentColor = Color.Transparent;
            ComputeBtn.Values.DropDownArrowColor = Color.Empty;
            ComputeBtn.Values.Text = "Show Computation";
            // 
            // HomeBtn
            // 
            HomeBtn.Anchor = AnchorStyles.None;
            HomeBtn.Location = new Point(1323, 7);
            HomeBtn.Name = "HomeBtn";
            HomeBtn.OverrideDefault.Back.Color1 = Color.FromArgb(240, 180, 25);
            HomeBtn.OverrideDefault.Back.Color2 = Color.FromArgb(240, 180, 25);
            HomeBtn.OverrideDefault.Border.Rounding = 10F;
            HomeBtn.OverrideDefault.Content.ShortText.Color1 = Color.FromArgb(50, 40, 10);
            HomeBtn.OverrideDefault.Content.ShortText.Color2 = Color.FromArgb(50, 40, 10);
            HomeBtn.OverrideDefault.Content.ShortText.Font = new Font("Poppins SemiBold", 15.75F, FontStyle.Bold);
            HomeBtn.Size = new Size(127, 52);
            HomeBtn.StateCommon.Back.Color1 = Color.FromArgb(240, 180, 25);
            HomeBtn.StateCommon.Back.Color2 = Color.FromArgb(240, 180, 25);
            HomeBtn.StateCommon.Border.Color1 = Color.FromArgb(200, 140, 20);
            HomeBtn.StateCommon.Border.Color2 = Color.FromArgb(200, 140, 20);
            HomeBtn.StateCommon.Border.Rounding = 10F;
            HomeBtn.StateCommon.Border.Width = 2;
            HomeBtn.StateCommon.Content.ShortText.Color1 = Color.FromArgb(50, 40, 10);
            HomeBtn.StateCommon.Content.ShortText.Color2 = Color.FromArgb(50, 40, 10);
            HomeBtn.StateCommon.Content.ShortText.Font = new Font("Poppins SemiBold", 15.75F, FontStyle.Bold);
            HomeBtn.StatePressed.Back.Color1 = Color.FromArgb(220, 160, 30);
            HomeBtn.StatePressed.Back.Color2 = Color.FromArgb(220, 160, 30);
            HomeBtn.StatePressed.Border.Color1 = Color.FromArgb(180, 120, 20);
            HomeBtn.StatePressed.Border.Color2 = Color.FromArgb(180, 120, 20);
            HomeBtn.StatePressed.Border.Rounding = 10F;
            HomeBtn.StatePressed.Content.ShortText.Color1 = Color.FromArgb(40, 30, 5);
            HomeBtn.StatePressed.Content.ShortText.Color2 = Color.FromArgb(40, 30, 5);
            HomeBtn.StateTracking.Back.Color1 = Color.FromArgb(250, 200, 50);
            HomeBtn.StateTracking.Back.Color2 = Color.FromArgb(250, 200, 50);
            HomeBtn.StateTracking.Border.Color1 = Color.FromArgb(210, 160, 30);
            HomeBtn.StateTracking.Border.Color2 = Color.FromArgb(210, 160, 30);
            HomeBtn.StateTracking.Border.Rounding = 10F;
            HomeBtn.StateTracking.Content.ShortText.Color1 = Color.FromArgb(60, 50, 15);
            HomeBtn.StateTracking.Content.ShortText.Color2 = Color.FromArgb(60, 50, 15);
            HomeBtn.TabIndex = 5;
            HomeBtn.ToolTipValues.Description = "Click to return to the main dashboard.";
            HomeBtn.ToolTipValues.EnableToolTips = true;
            HomeBtn.ToolTipValues.Heading = "Home";
            HomeBtn.ToolTipValues.ImageTransparentColor = Color.Transparent;
            HomeBtn.Values.DropDownArrowColor = Color.Empty;
            HomeBtn.Values.Text = "Home";
            // 
            // ReplayBtn
            // 
            ReplayBtn.Anchor = AnchorStyles.None;
            ReplayBtn.Location = new Point(1190, 7);
            ReplayBtn.Name = "ReplayBtn";
            ReplayBtn.OverrideDefault.Back.Color1 = Color.FromArgb(215, 35, 35);
            ReplayBtn.OverrideDefault.Back.Color2 = Color.FromArgb(215, 35, 35);
            ReplayBtn.OverrideDefault.Border.Rounding = 10F;
            ReplayBtn.OverrideDefault.Content.ShortText.Color1 = Color.White;
            ReplayBtn.OverrideDefault.Content.ShortText.Color2 = Color.White;
            ReplayBtn.OverrideDefault.Content.ShortText.Font = new Font("Poppins SemiBold", 15.75F, FontStyle.Bold);
            ReplayBtn.Size = new Size(127, 52);
            ReplayBtn.StateCommon.Back.Color1 = Color.FromArgb(215, 35, 35);
            ReplayBtn.StateCommon.Back.Color2 = Color.FromArgb(215, 35, 35);
            ReplayBtn.StateCommon.Border.Color1 = Color.FromArgb(185, 30, 30);
            ReplayBtn.StateCommon.Border.Color2 = Color.FromArgb(185, 30, 30);
            ReplayBtn.StateCommon.Border.Rounding = 10F;
            ReplayBtn.StateCommon.Border.Width = 2;
            ReplayBtn.StateCommon.Content.ShortText.Color1 = Color.White;
            ReplayBtn.StateCommon.Content.ShortText.Color2 = Color.White;
            ReplayBtn.StateCommon.Content.ShortText.Font = new Font("Poppins SemiBold", 15.75F, FontStyle.Bold);
            ReplayBtn.StatePressed.Back.Color1 = Color.FromArgb(175, 25, 25);
            ReplayBtn.StatePressed.Back.Color2 = Color.FromArgb(175, 25, 25);
            ReplayBtn.StatePressed.Border.Color1 = Color.FromArgb(145, 20, 20);
            ReplayBtn.StatePressed.Border.Color2 = Color.FromArgb(145, 20, 20);
            ReplayBtn.StatePressed.Border.Rounding = 10F;
            ReplayBtn.StatePressed.Content.ShortText.Color1 = Color.White;
            ReplayBtn.StatePressed.Content.ShortText.Color2 = Color.White;
            ReplayBtn.StateTracking.Back.Color1 = Color.FromArgb(235, 50, 50);
            ReplayBtn.StateTracking.Back.Color2 = Color.FromArgb(235, 50, 50);
            ReplayBtn.StateTracking.Border.Color1 = Color.FromArgb(195, 40, 40);
            ReplayBtn.StateTracking.Border.Color2 = Color.FromArgb(195, 40, 40);
            ReplayBtn.StateTracking.Border.Rounding = 10F;
            ReplayBtn.StateTracking.Content.ShortText.Color1 = Color.White;
            ReplayBtn.StateTracking.Content.ShortText.Color2 = Color.White;
            ReplayBtn.TabIndex = 4;
            ReplayBtn.ToolTipValues.Description = "Click to restart or replay the process.";
            ReplayBtn.ToolTipValues.EnableToolTips = true;
            ReplayBtn.ToolTipValues.Heading = "Replay";
            ReplayBtn.ToolTipValues.ImageTransparentColor = Color.Transparent;
            ReplayBtn.Values.DropDownArrowColor = Color.Empty;
            ReplayBtn.Values.Text = "Replay";
            // 
            // kryptonLabel1
            // 
            kryptonLabel1.Location = new Point(17, 0);
            kryptonLabel1.Name = "kryptonLabel1";
            kryptonLabel1.Size = new Size(290, 59);
            kryptonLabel1.StateCommon.ShortText.Color1 = Color.FromArgb(238, 238, 238);
            kryptonLabel1.StateCommon.ShortText.Font = new Font("Poppins", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            kryptonLabel1.StateCommon.ShortText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Center;
            kryptonLabel1.TabIndex = 0;
            kryptonLabel1.Values.Text = "GANTT CHART";
            // 
            // GanttChartView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1506, 882);
            Controls.Add(MainContainer);
            FormBorderStyle = FormBorderStyle.None;
            MaximumSize = new Size(1506, 882);
            MinimumSize = new Size(1506, 882);
            Name = "GanttChartView";
            StartPosition = FormStartPosition.CenterScreen;
            StateCommon.Back.Color1 = Color.Transparent;
            StateCommon.Back.Color2 = Color.Transparent;
            StateCommon.Border.Color1 = Color.Transparent;
            StateCommon.Border.Color2 = Color.Transparent;
            StateCommon.Border.Rounding = 0F;
            StateCommon.Border.Width = -10;
            StateCommon.Header.Back.Color1 = Color.Transparent;
            StateCommon.Header.Back.Color2 = Color.Transparent;
            StateCommon.Header.Border.Color1 = Color.Transparent;
            StateCommon.Header.Border.Color2 = Color.Transparent;
            StateCommon.Header.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.None;
            StateCommon.Header.Border.Rounding = 0F;
            StateCommon.Header.Border.Width = -10;
            StateCommon.Header.Content.ShortText.Color1 = Color.Transparent;
            StateCommon.Header.Content.ShortText.Color2 = Color.Transparent;
            StateCommon.OverlayHeaders = Krypton.Toolkit.InheritBool.False;
            Text = "ProcessTableView";
            TransparencyKey = Color.Transparent;
            ((System.ComponentModel.ISupportInitialize)MainContainer).EndInit();
            MainContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)_ganttChartContainer).EndInit();
            _ganttChartContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)_timeLineContainer).EndInit();
            ((System.ComponentModel.ISupportInitialize)_ganttChartPanel).EndInit();
            _ganttChartPanel.ResumeLayout(false);
            _ganttChartPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Krypton.Toolkit.KryptonPanel MainContainer;
        private Krypton.Toolkit.KryptonPanel _ganttChartContainer;
        private Krypton.Toolkit.KryptonPanel _timeLineContainer;
        private Krypton.Toolkit.KryptonPanel _ganttChartPanel;
        private Krypton.Toolkit.KryptonLabel kryptonLabel1;
        private Krypton.Toolkit.KryptonButton HomeBtn;
        private Krypton.Toolkit.KryptonButton ReplayBtn;
        private Krypton.Toolkit.KryptonButton ComputeBtn;
    }
}