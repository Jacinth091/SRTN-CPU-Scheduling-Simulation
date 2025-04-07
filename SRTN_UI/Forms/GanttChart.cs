using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using Krypton.Toolkit;

namespace SRTN_UI.Forms
{
    public class GanttChart : KryptonPanel
    {
        private readonly List<GanttBar> _bars = new List<GanttBar>();
        private int _timeScale = 50; // pixels per time unit
        private Font _labelFont = new Font("Segoe UI", 8f);
        private const int BarHeight = 40; // Fixed height for all bars
        private const int BarYPosition = 50; // Vertical position for the single line

        public void AddBar(string processName, Color color, double startTime, double duration)
        {
            var bar = new GanttBar
            {
                ProcessName = processName,
                Color = color,
                StartTime = startTime,
                Duration = duration
            };
            _bars.Add(bar);
            Invalidate(); // Trigger redraw
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            // Draw timeline
            e.Graphics.DrawLine(Pens.Black, 30, 30, Width - 30, 30);

            // Draw time markers
            for (int i = 0; i <= 10; i++)
            {
                int x = 30 + (i * _timeScale);
                e.Graphics.DrawLine(Pens.Gray, x, 25, x, 35);
                e.Graphics.DrawString(i.ToString(), _labelFont, Brushes.Black, x - 5, 10);
            }

            // Draw all bars on the same line
            foreach (var bar in _bars)
            {
                int x = 30 + (int)(bar.StartTime * _timeScale);
                int width = (int)(bar.Duration * _timeScale);

                using (var brush = new SolidBrush(bar.Color))
                {
                    // Draw the bar at fixed Y position
                    e.Graphics.FillRectangle(brush, x, BarYPosition, width, BarHeight);
                    e.Graphics.DrawRectangle(Pens.Black, x, BarYPosition, width, BarHeight);

                    // Draw process name above the bar
                    e.Graphics.DrawString(bar.ProcessName, _labelFont, Brushes.Black,
                                         x + 5, BarYPosition - 15);

                    // Draw duration text inside the bar
                    e.Graphics.DrawString(bar.Duration.ToString("0.0"), _labelFont, Brushes.White,
                                         x + (width / 2) - 10, BarYPosition + (BarHeight / 2) - 5);
                }
            }
        }
    }
}