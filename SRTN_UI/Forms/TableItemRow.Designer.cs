namespace SRTN_UI.Forms
{
    partial class TableItemRow
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
            CurrentBurstCol = new Krypton.Toolkit.KryptonLabel();
            StatusCol = new Krypton.Toolkit.KryptonLabel();
            TableRow = new Krypton.Toolkit.KryptonPanel();
            ((System.ComponentModel.ISupportInitialize)TableRow).BeginInit();
            TableRow.SuspendLayout();
            SuspendLayout();
            // 
            // ProcessIdCol
            // 
            ProcessIdCol.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            ProcessIdCol.Location = new Point(54, 9);
            ProcessIdCol.Name = "ProcessIdCol";
            ProcessIdCol.Size = new Size(46, 33);
            ProcessIdCol.StateCommon.ShortText.Color1 = Color.FromArgb(238, 238, 238);
            ProcessIdCol.StateCommon.ShortText.Color2 = Color.FromArgb(238, 238, 238);
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
            OriginalBurstCol.Location = new Point(172, 9);
            OriginalBurstCol.Name = "OriginalBurstCol";
            OriginalBurstCol.Size = new Size(46, 33);
            OriginalBurstCol.StateCommon.ShortText.Color1 = Color.FromArgb(238, 238, 238);
            OriginalBurstCol.StateCommon.ShortText.Color2 = Color.FromArgb(238, 238, 238);
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
            ArrivalCol.Location = new Point(294, 9);
            ArrivalCol.Name = "ArrivalCol";
            ArrivalCol.Size = new Size(46, 33);
            ArrivalCol.StateCommon.ShortText.Color1 = Color.FromArgb(238, 238, 238);
            ArrivalCol.StateCommon.ShortText.Color2 = Color.FromArgb(238, 238, 238);
            ArrivalCol.StateCommon.ShortText.Font = new Font("Poppins", 15F, FontStyle.Bold);
            ArrivalCol.StateCommon.ShortText.MultiLineH = Krypton.Toolkit.PaletteRelativeAlign.Center;
            ArrivalCol.StateCommon.ShortText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Center;
            ArrivalCol.StateCommon.ShortText.TextV = Krypton.Toolkit.PaletteRelativeAlign.Center;
            ArrivalCol.TabIndex = 6;
            ArrivalCol.Values.Text = "0.0";
            // 
            // CurrentBurstCol
            // 
            CurrentBurstCol.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            CurrentBurstCol.Location = new Point(438, 9);
            CurrentBurstCol.Name = "CurrentBurstCol";
            CurrentBurstCol.Size = new Size(46, 33);
            CurrentBurstCol.StateCommon.ShortText.Color1 = Color.FromArgb(238, 238, 238);
            CurrentBurstCol.StateCommon.ShortText.Color2 = Color.FromArgb(238, 238, 238);
            CurrentBurstCol.StateCommon.ShortText.Font = new Font("Poppins", 15F, FontStyle.Bold);
            CurrentBurstCol.StateCommon.ShortText.MultiLineH = Krypton.Toolkit.PaletteRelativeAlign.Center;
            CurrentBurstCol.StateCommon.ShortText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Center;
            CurrentBurstCol.StateCommon.ShortText.TextV = Krypton.Toolkit.PaletteRelativeAlign.Center;
            CurrentBurstCol.TabIndex = 7;
            CurrentBurstCol.Values.Text = "0.0";
            // 
            // StatusCol
            // 
            StatusCol.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            StatusCol.Location = new Point(566, 9);
            StatusCol.Name = "StatusCol";
            StatusCol.Size = new Size(97, 33);
            StatusCol.StateCommon.ShortText.Color1 = Color.FromArgb(238, 238, 238);
            StatusCol.StateCommon.ShortText.Color2 = Color.FromArgb(238, 238, 238);
            StatusCol.StateCommon.ShortText.Font = new Font("Poppins", 15F, FontStyle.Bold);
            StatusCol.StateCommon.ShortText.MultiLineH = Krypton.Toolkit.PaletteRelativeAlign.Center;
            StatusCol.StateCommon.ShortText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Center;
            StatusCol.StateCommon.ShortText.TextV = Krypton.Toolkit.PaletteRelativeAlign.Center;
            StatusCol.TabIndex = 10;
            StatusCol.Values.Text = "Waiting";
            // 
            // TableRow
            // 
            TableRow.Controls.Add(StatusCol);
            TableRow.Controls.Add(CurrentBurstCol);
            TableRow.Controls.Add(ArrivalCol);
            TableRow.Controls.Add(OriginalBurstCol);
            TableRow.Controls.Add(ProcessIdCol);
            TableRow.Dock = DockStyle.Fill;
            TableRow.Location = new Point(0, 0);
            TableRow.Name = "TableRow";
            TableRow.Size = new Size(705, 50);
            TableRow.StateCommon.Color1 = Color.Transparent;
            TableRow.StateCommon.Color2 = Color.Transparent;
            TableRow.TabIndex = 1;
            // 
            // TableItemRow
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(48, 56, 65);
            Controls.Add(TableRow);
            Name = "TableItemRow";
            Size = new Size(705, 50);
            ((System.ComponentModel.ISupportInitialize)TableRow).EndInit();
            TableRow.ResumeLayout(false);
            TableRow.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Krypton.Toolkit.KryptonLabel ProcessIdCol;
        private Krypton.Toolkit.KryptonLabel OriginalBurstCol;
        private Krypton.Toolkit.KryptonLabel ArrivalCol;
        private Krypton.Toolkit.KryptonLabel CurrentBurstCol;
        private Krypton.Toolkit.KryptonLabel StatusCol;
        private Krypton.Toolkit.KryptonPanel TableRow;
    }
}
