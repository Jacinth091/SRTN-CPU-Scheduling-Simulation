namespace SRTN_UI.Forms
{
    partial class ResultItemRow
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
            ProcessIdCol = new Krypton.Toolkit.KryptonLabel();
            OriginalBurstCol = new Krypton.Toolkit.KryptonLabel();
            ArrivalCol = new Krypton.Toolkit.KryptonLabel();
            TableRow = new Krypton.Toolkit.KryptonPanel();
            TurnAroundTimeCol = new Krypton.Toolkit.KryptonLabel();
            CompletionTimeCol = new Krypton.Toolkit.KryptonLabel();
            WaitingTimeCol = new Krypton.Toolkit.KryptonLabel();
            ((System.ComponentModel.ISupportInitialize)TableRow).BeginInit();
            TableRow.SuspendLayout();
            SuspendLayout();
            // 
            // ProcessIdCol
            // 
            ProcessIdCol.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            ProcessIdCol.Location = new Point(47, 16);
            ProcessIdCol.Name = "ProcessIdCol";
            ProcessIdCol.Size = new Size(46, 33);
            ProcessIdCol.StateCommon.ShortText.Color1 = Color.FromArgb(215, 35, 35);
            ProcessIdCol.StateCommon.ShortText.Font = new Font("Poppins", 15F, FontStyle.Bold);
            ProcessIdCol.StateCommon.ShortText.MultiLineH = Krypton.Toolkit.PaletteRelativeAlign.Center;
            ProcessIdCol.StateCommon.ShortText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Center;
            ProcessIdCol.StateCommon.ShortText.TextV = Krypton.Toolkit.PaletteRelativeAlign.Center;
            ProcessIdCol.TabIndex = 4;
            ProcessIdCol.Values.Text = "0.0";
            // 
            // OriginalBurstCol
            // 
            OriginalBurstCol.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            OriginalBurstCol.Location = new Point(206, 16);
            OriginalBurstCol.Name = "OriginalBurstCol";
            OriginalBurstCol.Size = new Size(46, 33);
            OriginalBurstCol.StateCommon.ShortText.Color1 = Color.FromArgb(215, 35, 35);
            OriginalBurstCol.StateCommon.ShortText.Font = new Font("Poppins", 15F, FontStyle.Bold);
            OriginalBurstCol.StateCommon.ShortText.MultiLineH = Krypton.Toolkit.PaletteRelativeAlign.Center;
            OriginalBurstCol.StateCommon.ShortText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Center;
            OriginalBurstCol.StateCommon.ShortText.TextV = Krypton.Toolkit.PaletteRelativeAlign.Center;
            OriginalBurstCol.TabIndex = 5;
            OriginalBurstCol.Values.Text = "0.0 ";
            // 
            // ArrivalCol
            // 
            ArrivalCol.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            ArrivalCol.Location = new Point(345, 16);
            ArrivalCol.Name = "ArrivalCol";
            ArrivalCol.Size = new Size(46, 33);
            ArrivalCol.StateCommon.ShortText.Color1 = Color.FromArgb(215, 35, 35);
            ArrivalCol.StateCommon.ShortText.Font = new Font("Poppins", 15F, FontStyle.Bold);
            ArrivalCol.StateCommon.ShortText.MultiLineH = Krypton.Toolkit.PaletteRelativeAlign.Center;
            ArrivalCol.StateCommon.ShortText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Center;
            ArrivalCol.StateCommon.ShortText.TextV = Krypton.Toolkit.PaletteRelativeAlign.Center;
            ArrivalCol.TabIndex = 6;
            ArrivalCol.Values.Text = "0.0";
            // 
            // TableRow
            // 
            TableRow.Controls.Add(TurnAroundTimeCol);
            TableRow.Controls.Add(CompletionTimeCol);
            TableRow.Controls.Add(WaitingTimeCol);
            TableRow.Controls.Add(ArrivalCol);
            TableRow.Controls.Add(OriginalBurstCol);
            TableRow.Controls.Add(ProcessIdCol);
            TableRow.Dock = DockStyle.Fill;
            TableRow.Location = new Point(0, 0);
            TableRow.Name = "TableRow";
            TableRow.Size = new Size(789, 60);
            TableRow.StateCommon.Color1 = Color.FromArgb(238, 238, 238);
            TableRow.StateCommon.Color2 = Color.FromArgb(238, 238, 238);
            TableRow.TabIndex = 1;
            // 
            // TurnAroundTimeCol
            // 
            TurnAroundTimeCol.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            TurnAroundTimeCol.Location = new Point(690, 17);
            TurnAroundTimeCol.Name = "TurnAroundTimeCol";
            TurnAroundTimeCol.Size = new Size(46, 33);
            TurnAroundTimeCol.StateCommon.ShortText.Color1 = Color.FromArgb(215, 35, 35);
            TurnAroundTimeCol.StateCommon.ShortText.Font = new Font("Poppins", 15F, FontStyle.Bold);
            TurnAroundTimeCol.StateCommon.ShortText.MultiLineH = Krypton.Toolkit.PaletteRelativeAlign.Center;
            TurnAroundTimeCol.StateCommon.ShortText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Center;
            TurnAroundTimeCol.StateCommon.ShortText.TextV = Krypton.Toolkit.PaletteRelativeAlign.Center;
            TurnAroundTimeCol.TabIndex = 9;
            TurnAroundTimeCol.Values.Text = "0.0 ";
            // 
            // CompletionTimeCol
            // 
            CompletionTimeCol.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            CompletionTimeCol.Location = new Point(594, 17);
            CompletionTimeCol.Name = "CompletionTimeCol";
            CompletionTimeCol.Size = new Size(46, 33);
            CompletionTimeCol.StateCommon.ShortText.Color1 = Color.FromArgb(215, 35, 35);
            CompletionTimeCol.StateCommon.ShortText.Font = new Font("Poppins", 15F, FontStyle.Bold);
            CompletionTimeCol.StateCommon.ShortText.MultiLineH = Krypton.Toolkit.PaletteRelativeAlign.Center;
            CompletionTimeCol.StateCommon.ShortText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Center;
            CompletionTimeCol.StateCommon.ShortText.TextV = Krypton.Toolkit.PaletteRelativeAlign.Center;
            CompletionTimeCol.TabIndex = 8;
            CompletionTimeCol.Values.Text = "0.0 ";
            // 
            // WaitingTimeCol
            // 
            WaitingTimeCol.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            WaitingTimeCol.Location = new Point(493, 16);
            WaitingTimeCol.Name = "WaitingTimeCol";
            WaitingTimeCol.Size = new Size(46, 33);
            WaitingTimeCol.StateCommon.ShortText.Color1 = Color.FromArgb(215, 35, 35);
            WaitingTimeCol.StateCommon.ShortText.Font = new Font("Poppins", 15F, FontStyle.Bold);
            WaitingTimeCol.StateCommon.ShortText.MultiLineH = Krypton.Toolkit.PaletteRelativeAlign.Center;
            WaitingTimeCol.StateCommon.ShortText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Center;
            WaitingTimeCol.StateCommon.ShortText.TextV = Krypton.Toolkit.PaletteRelativeAlign.Center;
            WaitingTimeCol.TabIndex = 7;
            WaitingTimeCol.Values.Text = "0.0 ";
            // 
            // ResultItemRow
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(48, 56, 65);
            Controls.Add(TableRow);
            Name = "ResultItemRow";
            Size = new Size(789, 60);
            ((System.ComponentModel.ISupportInitialize)TableRow).EndInit();
            TableRow.ResumeLayout(false);
            TableRow.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Krypton.Toolkit.KryptonLabel ProcessIdCol;
        private Krypton.Toolkit.KryptonLabel OriginalBurstCol;
        private Krypton.Toolkit.KryptonLabel ArrivalCol;
        private Krypton.Toolkit.KryptonPanel TableRow;
        private Krypton.Toolkit.KryptonLabel TurnAroundTimeCol;
        private Krypton.Toolkit.KryptonLabel CompletionTimeCol;
        private Krypton.Toolkit.KryptonLabel WaitingTimeCol;
    }
}
