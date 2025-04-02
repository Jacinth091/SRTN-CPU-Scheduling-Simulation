using Krypton.Toolkit;

namespace SRTN_UI.Forms
{
    partial class DesignArea
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
            MainTitlePanel = new KryptonPanel();
            kryptonPanel2 = new KryptonPanel();
            ContinueBtn = new KryptonButton();
            kryptonLabel2 = new KryptonLabel();
            kryptonLabel1 = new KryptonLabel();
            TitleCont = new KryptonPanel();
            TitleLabel = new KryptonLabel();
            InputPanel = new KryptonPanel();
            kryptonPanel3 = new KryptonPanel();
            ProcessTableTitle = new KryptonLabel();
            kryptonPanel4 = new KryptonPanel();
            ProcessTable = new KryptonDataGridView();
            kryptonPanel1 = new KryptonPanel();
            GenerateBtn = new KryptonButton();
            usernameText = new KryptonTextBox();
            kryptonLabel3 = new KryptonLabel();
            Column1 = new DataGridViewTextBoxColumn();
            Process_Id = new KryptonDataGridViewTextBoxColumn();
            Arrival_Time = new KryptonDataGridViewTextBoxColumn();
            Burst_Time = new KryptonDataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)MainTitlePanel).BeginInit();
            MainTitlePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)kryptonPanel2).BeginInit();
            kryptonPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)TitleCont).BeginInit();
            TitleCont.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)InputPanel).BeginInit();
            InputPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)kryptonPanel3).BeginInit();
            kryptonPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)kryptonPanel4).BeginInit();
            kryptonPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ProcessTable).BeginInit();
            ((System.ComponentModel.ISupportInitialize)kryptonPanel1).BeginInit();
            kryptonPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // MainTitlePanel
            // 
            MainTitlePanel.Controls.Add(kryptonPanel2);
            MainTitlePanel.Controls.Add(TitleCont);
            MainTitlePanel.Location = new Point(43, 36);
            MainTitlePanel.Name = "MainTitlePanel";
            MainTitlePanel.Size = new Size(857, 639);
            MainTitlePanel.StateCommon.Color1 = Color.FromArgb(48, 56, 65);
            MainTitlePanel.StateCommon.Color2 = Color.FromArgb(48, 56, 65);
            MainTitlePanel.TabIndex = 0;
            // 
            // kryptonPanel2
            // 
            kryptonPanel2.Controls.Add(ContinueBtn);
            kryptonPanel2.Controls.Add(kryptonLabel2);
            kryptonPanel2.Controls.Add(kryptonLabel1);
            kryptonPanel2.Dock = DockStyle.Fill;
            kryptonPanel2.Location = new Point(0, 170);
            kryptonPanel2.Name = "kryptonPanel2";
            kryptonPanel2.Size = new Size(857, 469);
            kryptonPanel2.StateCommon.Color1 = Color.Transparent;
            kryptonPanel2.StateCommon.Color2 = Color.Transparent;
            kryptonPanel2.TabIndex = 1;
            // 
            // ContinueBtn
            // 
            ContinueBtn.Location = new Point(327, 359);
            ContinueBtn.Name = "ContinueBtn";
            ContinueBtn.Size = new Size(228, 54);
            ContinueBtn.TabIndex = 3;
            ContinueBtn.Values.DropDownArrowColor = Color.Empty;
            ContinueBtn.Values.Text = "Continue";
            // 
            // kryptonLabel2
            // 
            kryptonLabel2.Location = new Point(98, 136);
            kryptonLabel2.Name = "kryptonLabel2";
            kryptonLabel2.Size = new Size(304, 175);
            kryptonLabel2.StateCommon.ShortText.Color1 = Color.FromArgb(238, 238, 238);
            kryptonLabel2.StateCommon.ShortText.Color2 = Color.FromArgb(238, 238, 238);
            kryptonLabel2.StateCommon.ShortText.Font = new Font("Poppins", 17F, FontStyle.Bold, GraphicsUnit.Point, 0);
            kryptonLabel2.StateCommon.ShortText.MultiLineH = PaletteRelativeAlign.Near;
            kryptonLabel2.StateCommon.ShortText.TextH = PaletteRelativeAlign.Center;
            kryptonLabel2.StateCommon.ShortText.TextV = PaletteRelativeAlign.Center;
            kryptonLabel2.TabIndex = 2;
            kryptonLabel2.Values.Text = "Members:\r\nBarral, Jacinth Cedric C.\r\nTorrepalma, Alber\r\nNuguid, Ronjay\r\nOtadoy, ";
            // 
            // kryptonLabel1
            // 
            kryptonLabel1.Location = new Point(98, 22);
            kryptonLabel1.Name = "kryptonLabel1";
            kryptonLabel1.Size = new Size(297, 37);
            kryptonLabel1.StateCommon.ShortText.Color1 = Color.FromArgb(238, 238, 238);
            kryptonLabel1.StateCommon.ShortText.Color2 = Color.FromArgb(238, 238, 238);
            kryptonLabel1.StateCommon.ShortText.Font = new Font("Poppins", 17F, FontStyle.Bold, GraphicsUnit.Point, 0);
            kryptonLabel1.StateCommon.ShortText.MultiLineH = PaletteRelativeAlign.Center;
            kryptonLabel1.StateCommon.ShortText.TextH = PaletteRelativeAlign.Center;
            kryptonLabel1.StateCommon.ShortText.TextV = PaletteRelativeAlign.Center;
            kryptonLabel1.TabIndex = 1;
            kryptonLabel1.Values.Text = "Developed By:  Group 10";
            // 
            // TitleCont
            // 
            TitleCont.Controls.Add(TitleLabel);
            TitleCont.Dock = DockStyle.Top;
            TitleCont.Location = new Point(0, 0);
            TitleCont.Name = "TitleCont";
            TitleCont.Size = new Size(857, 170);
            TitleCont.StateCommon.Color1 = Color.Transparent;
            TitleCont.StateCommon.Color2 = Color.Transparent;
            TitleCont.TabIndex = 0;
            // 
            // TitleLabel
            // 
            TitleLabel.Dock = DockStyle.Fill;
            TitleLabel.Location = new Point(0, 0);
            TitleLabel.Name = "TitleLabel";
            TitleLabel.Size = new Size(857, 170);
            TitleLabel.StateCommon.ShortText.Color1 = Color.FromArgb(238, 238, 238);
            TitleLabel.StateCommon.ShortText.Color2 = Color.FromArgb(238, 238, 238);
            TitleLabel.StateCommon.ShortText.Font = new Font("Poppins", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            TitleLabel.StateCommon.ShortText.MultiLineH = PaletteRelativeAlign.Center;
            TitleLabel.StateCommon.ShortText.TextH = PaletteRelativeAlign.Center;
            TitleLabel.StateCommon.ShortText.TextV = PaletteRelativeAlign.Center;
            TitleLabel.TabIndex = 0;
            TitleLabel.Values.Text = "Simulation Program For\r\nShortest Remaining Time Next \r\nCPU Scheduling Algorithm";
            // 
            // InputPanel
            // 
            InputPanel.Controls.Add(kryptonPanel3);
            InputPanel.Controls.Add(kryptonPanel1);
            InputPanel.Location = new Point(43, 717);
            InputPanel.Name = "InputPanel";
            InputPanel.Size = new Size(1086, 655);
            InputPanel.StateCommon.Color1 = Color.FromArgb(48, 56, 65);
            InputPanel.StateCommon.Color2 = Color.FromArgb(48, 56, 65);
            InputPanel.TabIndex = 6;
            InputPanel.Visible = false;
            // 
            // kryptonPanel3
            // 
            kryptonPanel3.Controls.Add(ProcessTableTitle);
            kryptonPanel3.Controls.Add(kryptonPanel4);
            kryptonPanel3.Dock = DockStyle.Fill;
            kryptonPanel3.Location = new Point(0, 104);
            kryptonPanel3.Name = "kryptonPanel3";
            kryptonPanel3.Size = new Size(1086, 551);
            kryptonPanel3.StateCommon.Color1 = Color.Transparent;
            kryptonPanel3.StateCommon.Color2 = Color.Transparent;
            kryptonPanel3.TabIndex = 1;
            // 
            // ProcessTableTitle
            // 
            ProcessTableTitle.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            ProcessTableTitle.Location = new Point(458, 6);
            ProcessTableTitle.MaximumSize = new Size(207, 37);
            ProcessTableTitle.MinimumSize = new Size(207, 37);
            ProcessTableTitle.Name = "ProcessTableTitle";
            ProcessTableTitle.Size = new Size(207, 37);
            ProcessTableTitle.StateCommon.ShortText.Color1 = Color.FromArgb(238, 238, 238);
            ProcessTableTitle.StateCommon.ShortText.Color2 = Color.FromArgb(238, 238, 238);
            ProcessTableTitle.StateCommon.ShortText.Font = new Font("Poppins", 17F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ProcessTableTitle.StateCommon.ShortText.MultiLineH = PaletteRelativeAlign.Center;
            ProcessTableTitle.StateCommon.ShortText.TextH = PaletteRelativeAlign.Center;
            ProcessTableTitle.StateCommon.ShortText.TextV = PaletteRelativeAlign.Center;
            ProcessTableTitle.TabIndex = 5;
            ProcessTableTitle.Values.Text = "Processes Table";
            // 
            // kryptonPanel4
            // 
            kryptonPanel4.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            kryptonPanel4.Controls.Add(ProcessTable);
            kryptonPanel4.Location = new Point(160, 60);
            kryptonPanel4.MaximumSize = new Size(790, 465);
            kryptonPanel4.MinimumSize = new Size(790, 465);
            kryptonPanel4.Name = "kryptonPanel4";
            kryptonPanel4.Padding = new Padding(10);
            kryptonPanel4.Size = new Size(790, 465);
            kryptonPanel4.TabIndex = 0;
            // 
            // ProcessTable
            // 
            ProcessTable.AllowUserToAddRows = false;
            ProcessTable.AllowUserToDeleteRows = false;
            ProcessTable.AllowUserToResizeColumns = false;
            ProcessTable.AllowUserToResizeRows = false;
            ProcessTable.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            ProcessTable.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            ProcessTable.BorderStyle = BorderStyle.None;
            ProcessTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ProcessTable.Columns.AddRange(new DataGridViewColumn[] { Process_Id, Arrival_Time, Burst_Time });
            ProcessTable.GridStyles.Style = DataGridViewStyle.Mixed;
            ProcessTable.GridStyles.StyleColumn = GridStyle.Sheet;
            ProcessTable.GridStyles.StyleDataCells = GridStyle.Sheet;
            ProcessTable.GridStyles.StyleRow = GridStyle.Sheet;
            ProcessTable.Location = new Point(10, 10);
            ProcessTable.MaximumSize = new Size(1067, 472);
            ProcessTable.Name = "ProcessTable";
            ProcessTable.RowHeadersVisible = false;
            ProcessTable.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            ProcessTable.RowTemplate.Height = 40;
            ProcessTable.ScrollBars = ScrollBars.Vertical;
            ProcessTable.Size = new Size(767, 46);
            ProcessTable.StateCommon.Background.Color1 = Color.FromArgb(252, 252, 252);
            ProcessTable.StateCommon.Background.Color2 = Color.WhiteSmoke;
            ProcessTable.StateCommon.Background.ColorAngle = -50F;
            ProcessTable.StateCommon.Background.ColorStyle = PaletteColorStyle.Linear25;
            ProcessTable.StateCommon.BackStyle = PaletteBackStyle.GridBackgroundList;
            ProcessTable.StateCommon.DataCell.Back.Color1 = Color.Transparent;
            ProcessTable.StateCommon.DataCell.Back.Color2 = Color.Transparent;
            ProcessTable.StateCommon.DataCell.Border.Color1 = Color.Transparent;
            ProcessTable.StateCommon.DataCell.Border.Color2 = Color.Transparent;
            ProcessTable.StateCommon.DataCell.Border.Draw = InheritBool.True;
            ProcessTable.StateCommon.DataCell.Border.DrawBorders = PaletteDrawBorders.Bottom;
            ProcessTable.StateCommon.DataCell.Border.Width = 1;
            ProcessTable.StateCommon.DataCell.Content.Color1 = Color.FromArgb(4, 70, 87);
            ProcessTable.StateCommon.DataCell.Content.Color2 = Color.FromArgb(4, 70, 87);
            ProcessTable.StateCommon.DataCell.Content.Font = new Font("Poppins", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ProcessTable.StateCommon.DataCell.Content.Padding = new Padding(2);
            ProcessTable.StateCommon.HeaderColumn.Back.Color1 = Color.FromArgb(4, 70, 87);
            ProcessTable.StateCommon.HeaderColumn.Back.Color2 = Color.FromArgb(4, 70, 87);
            ProcessTable.StateCommon.HeaderColumn.Border.Color1 = Color.Transparent;
            ProcessTable.StateCommon.HeaderColumn.Border.Color2 = Color.Transparent;
            ProcessTable.StateCommon.HeaderColumn.Border.Draw = InheritBool.False;
            ProcessTable.StateCommon.HeaderColumn.Border.Width = 0;
            ProcessTable.StateCommon.HeaderColumn.Content.Color1 = Color.FromArgb(251, 252, 252);
            ProcessTable.StateCommon.HeaderColumn.Content.Color2 = Color.FromArgb(251, 252, 252);
            ProcessTable.StateCommon.HeaderColumn.Content.Font = new Font("Poppins Medium", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ProcessTable.StateCommon.HeaderColumn.Content.Padding = new Padding(5);
            ProcessTable.StatePressed.HeaderColumn.Back.Color1 = Color.Transparent;
            ProcessTable.StatePressed.HeaderColumn.Back.Color2 = Color.Transparent;
            ProcessTable.StatePressed.HeaderColumn.Content.Color1 = Color.FromArgb(4, 70, 87);
            ProcessTable.StatePressed.HeaderColumn.Content.Color2 = Color.FromArgb(4, 70, 87);
            ProcessTable.TabIndex = 4;
            // 
            // kryptonPanel1
            // 
            kryptonPanel1.Controls.Add(GenerateBtn);
            kryptonPanel1.Controls.Add(usernameText);
            kryptonPanel1.Controls.Add(kryptonLabel3);
            kryptonPanel1.Dock = DockStyle.Top;
            kryptonPanel1.Location = new Point(0, 0);
            kryptonPanel1.Name = "kryptonPanel1";
            kryptonPanel1.Size = new Size(1086, 104);
            kryptonPanel1.StateCommon.Color1 = Color.Transparent;
            kryptonPanel1.StateCommon.Color2 = Color.Transparent;
            kryptonPanel1.TabIndex = 0;
            // 
            // GenerateBtn
            // 
            GenerateBtn.Location = new Point(628, 35);
            GenerateBtn.Name = "GenerateBtn";
            GenerateBtn.OverrideDefault.Back.Color1 = Color.FromArgb(251, 252, 252);
            GenerateBtn.OverrideDefault.Back.Color2 = Color.FromArgb(251, 252, 252);
            GenerateBtn.OverrideDefault.Border.Rounding = 10F;
            GenerateBtn.OverrideDefault.Content.ShortText.Color1 = Color.FromArgb(58, 94, 116);
            GenerateBtn.OverrideDefault.Content.ShortText.Color2 = Color.FromArgb(58, 94, 116);
            GenerateBtn.OverrideDefault.Content.ShortText.Font = new Font("Poppins SemiBold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            GenerateBtn.Size = new Size(217, 45);
            GenerateBtn.StateCommon.Back.Color1 = Color.FromArgb(251, 252, 252);
            GenerateBtn.StateCommon.Back.Color2 = Color.FromArgb(251, 252, 252);
            GenerateBtn.StateCommon.Border.Color1 = Color.FromArgb(40, 73, 87);
            GenerateBtn.StateCommon.Border.Color2 = Color.FromArgb(40, 73, 87);
            GenerateBtn.StateCommon.Border.Rounding = 10F;
            GenerateBtn.StateCommon.Border.Width = 2;
            GenerateBtn.StateCommon.Content.ShortText.Color1 = Color.FromArgb(58, 94, 116);
            GenerateBtn.StateCommon.Content.ShortText.Color2 = Color.FromArgb(58, 94, 116);
            GenerateBtn.StateCommon.Content.ShortText.Font = new Font("Poppins SemiBold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            GenerateBtn.StatePressed.Back.Color1 = Color.FromArgb(200, 200, 200);
            GenerateBtn.StatePressed.Back.Color2 = Color.FromArgb(200, 200, 200);
            GenerateBtn.StatePressed.Border.Color1 = Color.FromArgb(30, 50, 70);
            GenerateBtn.StatePressed.Border.Color2 = Color.FromArgb(30, 50, 70);
            GenerateBtn.StatePressed.Border.Rounding = 10F;
            GenerateBtn.StatePressed.Content.ShortText.Color1 = Color.FromArgb(40, 80, 100);
            GenerateBtn.StatePressed.Content.ShortText.Color2 = Color.FromArgb(40, 80, 100);
            GenerateBtn.StateTracking.Back.Color1 = Color.FromArgb(230, 230, 230);
            GenerateBtn.StateTracking.Back.Color2 = Color.FromArgb(230, 230, 230);
            GenerateBtn.StateTracking.Border.Color1 = Color.FromArgb(60, 100, 120);
            GenerateBtn.StateTracking.Border.Color2 = Color.FromArgb(60, 100, 120);
            GenerateBtn.StateTracking.Border.Rounding = 10F;
            GenerateBtn.StateTracking.Content.ShortText.Color1 = Color.FromArgb(80, 120, 140);
            GenerateBtn.StateTracking.Content.ShortText.Color2 = Color.FromArgb(80, 120, 140);
            GenerateBtn.TabIndex = 4;
            GenerateBtn.Values.DropDownArrowColor = Color.Empty;
            GenerateBtn.Values.Text = "Generate Table";
            // 
            // usernameText
            // 
            usernameText.AlwaysActive = false;
            usernameText.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            usernameText.CueHint.Color1 = Color.DimGray;
            usernameText.CueHint.CueHintText = "Number of processes";
            usernameText.CueHint.Font = new Font("Poppins", 12F);
            usernameText.CueHint.TextV = PaletteRelativeAlign.Near;
            usernameText.Cursor = Cursors.IBeam;
            usernameText.Location = new Point(327, 35);
            usernameText.Name = "usernameText";
            usernameText.Size = new Size(253, 45);
            usernameText.StateCommon.Back.Color1 = Color.FromArgb(251, 251, 251);
            usernameText.StateCommon.Border.Color1 = Color.FromArgb(224, 224, 224);
            usernameText.StateCommon.Border.Color2 = Color.FromArgb(224, 224, 224);
            usernameText.StateCommon.Border.GraphicsHint = PaletteGraphicsHint.AntiAlias;
            usernameText.StateCommon.Border.Rounding = 5F;
            usernameText.StateCommon.Content.Color1 = Color.DimGray;
            usernameText.StateCommon.Content.Font = new Font("Poppins", 12F);
            usernameText.StateCommon.Content.Padding = new Padding(10, 5, 10, 10);
            usernameText.StateCommon.Content.TextH = PaletteRelativeAlign.Near;
            usernameText.TabIndex = 3;
            usernameText.WordWrap = false;
            // 
            // kryptonLabel3
            // 
            kryptonLabel3.Location = new Point(33, 41);
            kryptonLabel3.Name = "kryptonLabel3";
            kryptonLabel3.Size = new Size(282, 37);
            kryptonLabel3.StateCommon.ShortText.Color1 = Color.FromArgb(238, 238, 238);
            kryptonLabel3.StateCommon.ShortText.Color2 = Color.FromArgb(238, 238, 238);
            kryptonLabel3.StateCommon.ShortText.Font = new Font("Poppins", 17F, FontStyle.Bold, GraphicsUnit.Point, 0);
            kryptonLabel3.StateCommon.ShortText.MultiLineH = PaletteRelativeAlign.Center;
            kryptonLabel3.StateCommon.ShortText.TextH = PaletteRelativeAlign.Center;
            kryptonLabel3.StateCommon.ShortText.TextV = PaletteRelativeAlign.Center;
            kryptonLabel3.TabIndex = 2;
            kryptonLabel3.Values.Text = "How many processes?";
            // 
            // Column1
            // 
            Column1.HeaderText = "Column1";
            Column1.Name = "Column1";
            // 
            // Process_Id
            // 
            Process_Id.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            Process_Id.Frozen = true;
            Process_Id.HeaderText = "Process ID";
            Process_Id.MinimumWidth = 100;
            Process_Id.Name = "Process_Id";
            Process_Id.ReadOnly = true;
            Process_Id.Resizable = DataGridViewTriState.False;
            Process_Id.SortMode = DataGridViewColumnSortMode.NotSortable;
            Process_Id.Width = 140;
            // 
            // Arrival_Time
            // 
            Arrival_Time.HeaderText = "Arrival Time";
            Arrival_Time.Name = "Arrival_Time";
            Arrival_Time.ReadOnly = true;
            Arrival_Time.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // Burst_Time
            // 
            Burst_Time.HeaderText = "Burst Time";
            Burst_Time.Name = "Burst_Time";
            Burst_Time.ReadOnly = true;
            Burst_Time.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // DesignArea
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(InputPanel);
            Controls.Add(MainTitlePanel);
            Name = "DesignArea";
            Size = new Size(2000, 2000);
            ((System.ComponentModel.ISupportInitialize)MainTitlePanel).EndInit();
            MainTitlePanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)kryptonPanel2).EndInit();
            kryptonPanel2.ResumeLayout(false);
            kryptonPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)TitleCont).EndInit();
            TitleCont.ResumeLayout(false);
            TitleCont.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)InputPanel).EndInit();
            InputPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)kryptonPanel3).EndInit();
            kryptonPanel3.ResumeLayout(false);
            kryptonPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)kryptonPanel4).EndInit();
            kryptonPanel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)ProcessTable).EndInit();
            ((System.ComponentModel.ISupportInitialize)kryptonPanel1).EndInit();
            kryptonPanel1.ResumeLayout(false);
            kryptonPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Krypton.Toolkit.KryptonPanel MainTitlePanel;
        private Krypton.Toolkit.KryptonPanel kryptonPanel2;
        private Krypton.Toolkit.KryptonPanel TitleCont;
        private Krypton.Toolkit.KryptonLabel TitleLabel;
        private Krypton.Toolkit.KryptonLabel kryptonLabel2;
        private Krypton.Toolkit.KryptonLabel kryptonLabel1;
        private Krypton.Toolkit.KryptonButton ContinueBtn;
        private Krypton.Toolkit.KryptonPanel InputPanel;
        private Krypton.Toolkit.KryptonPanel kryptonPanel1;
        private Krypton.Toolkit.KryptonLabel kryptonLabel3;
        private Krypton.Toolkit.KryptonTextBox usernameText;
        private Krypton.Toolkit.KryptonButton GenerateBtn;
        private Krypton.Toolkit.KryptonPanel kryptonPanel3;
        private Krypton.Toolkit.KryptonDataGridView ProcessTable;
        private Krypton.Toolkit.KryptonPanel kryptonPanel4;
        private Krypton.Toolkit.KryptonLabel ProcessTableTitle;
        private DataGridViewTextBoxColumn Column1;
        private KryptonDataGridViewTextBoxColumn Process_Id;
        private KryptonDataGridViewTextBoxColumn Arrival_Time;
        private KryptonDataGridViewTextBoxColumn Burst_Time;
    }
}
