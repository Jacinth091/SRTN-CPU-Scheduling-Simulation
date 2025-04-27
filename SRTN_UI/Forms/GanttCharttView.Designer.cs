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
            MainContainer.Name = "MainContainer";
            MainContainer.Size = new Size(1486, 855);
            MainContainer.StateCommon.Color1 = Color.FromArgb(48, 56, 65);
            MainContainer.StateCommon.Color2 = Color.FromArgb(48, 56, 65);
            MainContainer.TabIndex = 0;
            // 
            // _ganttChartContainer
            // 
            _ganttChartContainer.Controls.Add(_timeLineContainer);
            _ganttChartContainer.Controls.Add(_ganttChartPanel);
            _ganttChartContainer.Location = new Point(0, 407);
            _ganttChartContainer.Name = "_ganttChartContainer";
            _ganttChartContainer.Padding = new Padding(20);
            _ganttChartContainer.Size = new Size(1486, 448);
            _ganttChartContainer.StateCommon.Color1 = Color.FromArgb(48, 56, 65);
            _ganttChartContainer.StateCommon.Color2 = Color.Gainsboro;
            _ganttChartContainer.TabIndex = 0;
            _ganttChartContainer.Visible = false;
            // 
            // _timeLineContainer
            // 
            _timeLineContainer.Dock = DockStyle.Fill;
            _timeLineContainer.Location = new Point(20, 120);
            _timeLineContainer.Name = "_timeLineContainer";
            _timeLineContainer.Size = new Size(1446, 308);
            _timeLineContainer.StateCommon.Color1 = Color.FromArgb(238, 238, 238);
            _timeLineContainer.TabIndex = 1;
            // 
            // _ganttChartPanel
            // 
            _ganttChartPanel.Controls.Add(kryptonLabel1);
            _ganttChartPanel.Dock = DockStyle.Top;
            _ganttChartPanel.Location = new Point(20, 20);
            _ganttChartPanel.Name = "_ganttChartPanel";
            _ganttChartPanel.Size = new Size(1446, 100);
            _ganttChartPanel.StateCommon.Color1 = Color.Transparent;
            _ganttChartPanel.TabIndex = 0;
            // 
            // kryptonLabel1
            // 
            kryptonLabel1.Dock = DockStyle.Fill;
            kryptonLabel1.Location = new Point(0, 0);
            kryptonLabel1.Name = "kryptonLabel1";
            kryptonLabel1.Size = new Size(1446, 100);
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
            ClientSize = new Size(1486, 855);
            Controls.Add(MainContainer);
            FormBorderStyle = FormBorderStyle.None;
            MaximumSize = new Size(1486, 855);
            MinimumSize = new Size(1486, 855);
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
    }
}