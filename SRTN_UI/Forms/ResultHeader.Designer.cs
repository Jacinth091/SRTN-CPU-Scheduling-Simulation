namespace SRTN_UI.Forms
{
    partial class ResultHeader
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            kryptonPanel1 = new Krypton.Toolkit.KryptonPanel();
            ArrivalTime = new Krypton.Toolkit.KryptonLabel();
            BurstTime = new Krypton.Toolkit.KryptonLabel();
            ProcessTitle = new Krypton.Toolkit.KryptonLabel();
            WaitingTime = new Krypton.Toolkit.KryptonLabel();
            CompletionTime = new Krypton.Toolkit.KryptonLabel();
            TurnAroundTime = new Krypton.Toolkit.KryptonLabel();
            ((System.ComponentModel.ISupportInitialize)kryptonPanel1).BeginInit();
            kryptonPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // kryptonPanel1
            // 
            kryptonPanel1.Controls.Add(TurnAroundTime);
            kryptonPanel1.Controls.Add(CompletionTime);
            kryptonPanel1.Controls.Add(WaitingTime);
            kryptonPanel1.Controls.Add(ArrivalTime);
            kryptonPanel1.Controls.Add(BurstTime);
            kryptonPanel1.Controls.Add(ProcessTitle);
            kryptonPanel1.Dock = DockStyle.Fill;
            kryptonPanel1.Location = new Point(0, 0);
            kryptonPanel1.Name = "kryptonPanel1";
            kryptonPanel1.Size = new Size(789, 60);
            kryptonPanel1.StateCommon.Color1 = Color.FromArgb(215, 35, 35);
            kryptonPanel1.TabIndex = 1;
            // 
            // ArrivalTime
            // 
            ArrivalTime.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            ArrivalTime.Location = new Point(328, 16);
            ArrivalTime.Name = "ArrivalTime";
            ArrivalTime.Size = new Size(115, 27);
            ArrivalTime.StateCommon.ShortText.Color1 = Color.FromArgb(238, 238, 238);
            ArrivalTime.StateCommon.ShortText.Color2 = Color.FromArgb(238, 238, 238);
            ArrivalTime.StateCommon.ShortText.Font = new Font("Poppins", 12F, FontStyle.Bold);
            ArrivalTime.StateCommon.ShortText.MultiLineH = Krypton.Toolkit.PaletteRelativeAlign.Center;
            ArrivalTime.StateCommon.ShortText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Center;
            ArrivalTime.StateCommon.ShortText.TextV = Krypton.Toolkit.PaletteRelativeAlign.Center;
            ArrivalTime.TabIndex = 6;
            ArrivalTime.Values.Text = "Arrival Time";
            // 
            // BurstTime
            // 
            BurstTime.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            BurstTime.Location = new Point(180, 16);
            BurstTime.Name = "BurstTime";
            BurstTime.Size = new Size(102, 28);
            BurstTime.StateCommon.ShortText.Color1 = Color.FromArgb(238, 238, 238);
            BurstTime.StateCommon.ShortText.Color2 = Color.FromArgb(238, 238, 238);
            BurstTime.StateCommon.ShortText.Font = new Font("Poppins", 12F, FontStyle.Bold);
            BurstTime.StateCommon.ShortText.MultiLineH = Krypton.Toolkit.PaletteRelativeAlign.Center;
            BurstTime.StateCommon.ShortText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Center;
            BurstTime.StateCommon.ShortText.TextV = Krypton.Toolkit.PaletteRelativeAlign.Center;
            BurstTime.TabIndex = 5;
            BurstTime.Values.Text = "Burst Time\r\n";
            // 
            // ProcessTitle
            // 
            ProcessTitle.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            ProcessTitle.Location = new Point(30, 16);
            ProcessTitle.Name = "ProcessTitle";
            ProcessTitle.Size = new Size(99, 27);
            ProcessTitle.StateCommon.ShortText.Color1 = Color.FromArgb(238, 238, 238);
            ProcessTitle.StateCommon.ShortText.Color2 = Color.FromArgb(238, 238, 238);
            ProcessTitle.StateCommon.ShortText.Font = new Font("Poppins", 12F, FontStyle.Bold);
            ProcessTitle.StateCommon.ShortText.MultiLineH = Krypton.Toolkit.PaletteRelativeAlign.Center;
            ProcessTitle.StateCommon.ShortText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Center;
            ProcessTitle.StateCommon.ShortText.TextV = Krypton.Toolkit.PaletteRelativeAlign.Center;
            ProcessTitle.TabIndex = 4;
            ProcessTitle.Values.Text = "Process ID";
            // 
            // WaitingTime
            // 
            WaitingTime.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            WaitingTime.Location = new Point(493, 16);
            WaitingTime.Name = "WaitingTime";
            WaitingTime.Size = new Size(39, 27);
            WaitingTime.StateCommon.ShortText.Color1 = Color.FromArgb(238, 238, 238);
            WaitingTime.StateCommon.ShortText.Color2 = Color.FromArgb(238, 238, 238);
            WaitingTime.StateCommon.ShortText.Font = new Font("Poppins", 12F, FontStyle.Bold);
            WaitingTime.StateCommon.ShortText.MultiLineH = Krypton.Toolkit.PaletteRelativeAlign.Center;
            WaitingTime.StateCommon.ShortText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Center;
            WaitingTime.StateCommon.ShortText.TextV = Krypton.Toolkit.PaletteRelativeAlign.Center;
            WaitingTime.TabIndex = 7;
            WaitingTime.Values.Text = "WT";
            // 
            // CompletionTime
            // 
            CompletionTime.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            CompletionTime.Location = new Point(594, 17);
            CompletionTime.Name = "CompletionTime";
            CompletionTime.Size = new Size(34, 27);
            CompletionTime.StateCommon.ShortText.Color1 = Color.FromArgb(238, 238, 238);
            CompletionTime.StateCommon.ShortText.Color2 = Color.FromArgb(238, 238, 238);
            CompletionTime.StateCommon.ShortText.Font = new Font("Poppins", 12F, FontStyle.Bold);
            CompletionTime.StateCommon.ShortText.MultiLineH = Krypton.Toolkit.PaletteRelativeAlign.Center;
            CompletionTime.StateCommon.ShortText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Center;
            CompletionTime.StateCommon.ShortText.TextV = Krypton.Toolkit.PaletteRelativeAlign.Center;
            CompletionTime.TabIndex = 8;
            CompletionTime.Values.Text = "CT";
            // 
            // TurnAroundTime
            // 
            TurnAroundTime.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            TurnAroundTime.Location = new Point(690, 17);
            TurnAroundTime.Name = "TurnAroundTime";
            TurnAroundTime.Size = new Size(43, 27);
            TurnAroundTime.StateCommon.ShortText.Color1 = Color.FromArgb(238, 238, 238);
            TurnAroundTime.StateCommon.ShortText.Color2 = Color.FromArgb(238, 238, 238);
            TurnAroundTime.StateCommon.ShortText.Font = new Font("Poppins", 12F, FontStyle.Bold);
            TurnAroundTime.StateCommon.ShortText.MultiLineH = Krypton.Toolkit.PaletteRelativeAlign.Center;
            TurnAroundTime.StateCommon.ShortText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Center;
            TurnAroundTime.StateCommon.ShortText.TextV = Krypton.Toolkit.PaletteRelativeAlign.Center;
            TurnAroundTime.TabIndex = 9;
            TurnAroundTime.Values.Text = "TAT";
            // 
            // ResultHeader
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(kryptonPanel1);
            Name = "ResultHeader";
            Size = new Size(789, 60);
            ((System.ComponentModel.ISupportInitialize)kryptonPanel1).EndInit();
            kryptonPanel1.ResumeLayout(false);
            kryptonPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Krypton.Toolkit.KryptonPanel kryptonPanel1;
        private Krypton.Toolkit.KryptonLabel ArrivalTime;
        private Krypton.Toolkit.KryptonLabel BurstTime;
        private Krypton.Toolkit.KryptonLabel ProcessTitle;
        private Krypton.Toolkit.KryptonLabel TurnAroundTime;
        private Krypton.Toolkit.KryptonLabel CompletionTime;
        private Krypton.Toolkit.KryptonLabel WaitingTime;
    }
}
