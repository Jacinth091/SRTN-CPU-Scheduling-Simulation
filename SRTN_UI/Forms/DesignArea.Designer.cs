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
            InputPanel = new KryptonPanel();
            kryptonPanel3 = new KryptonPanel();
            ProcessTableTitle = new KryptonLabel();
            kryptonPanel4 = new KryptonPanel();
            kryptonPanel1 = new KryptonPanel();
            GenerateBtn = new KryptonButton();
            usernameText = new KryptonTextBox();
            kryptonLabel3 = new KryptonLabel();
            Column1 = new DataGridViewTextBoxColumn();
            kryptonPanel5 = new KryptonPanel();
            ArrivalTimeText = new KryptonTextBox();
            BurstTimeText = new KryptonTextBox();
            InfoPanel = new KryptonPanel();
            AboutBtn = new KryptonButton();
            InfoBtn = new KryptonButton();
            ContinueBtn = new KryptonButton();
            ((System.ComponentModel.ISupportInitialize)MainTitlePanel).BeginInit();
            MainTitlePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)InputPanel).BeginInit();
            InputPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)kryptonPanel3).BeginInit();
            kryptonPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)kryptonPanel4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)kryptonPanel1).BeginInit();
            kryptonPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)kryptonPanel5).BeginInit();
            kryptonPanel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)InfoPanel).BeginInit();
            InfoPanel.SuspendLayout();
            SuspendLayout();
            // 
            // MainTitlePanel
            // 
            MainTitlePanel.Controls.Add(InfoPanel);
            MainTitlePanel.Location = new Point(43, 36);
            MainTitlePanel.Name = "MainTitlePanel";
            MainTitlePanel.Size = new Size(1486, 910);
            MainTitlePanel.StateCommon.Color1 = Color.FromArgb(48, 56, 65);
            MainTitlePanel.StateCommon.Color2 = Color.FromArgb(48, 56, 65);
            MainTitlePanel.TabIndex = 0;
            // 
            // InputPanel
            // 
            InputPanel.Controls.Add(kryptonPanel3);
            InputPanel.Controls.Add(kryptonPanel1);
            InputPanel.Location = new Point(25, 1021);
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
            kryptonPanel4.Location = new Point(160, 60);
            kryptonPanel4.MaximumSize = new Size(790, 465);
            kryptonPanel4.MinimumSize = new Size(790, 465);
            kryptonPanel4.Name = "kryptonPanel4";
            kryptonPanel4.Padding = new Padding(10);
            kryptonPanel4.Size = new Size(790, 465);
            kryptonPanel4.TabIndex = 0;
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
            // kryptonPanel5
            // 
            kryptonPanel5.Controls.Add(ArrivalTimeText);
            kryptonPanel5.Controls.Add(BurstTimeText);
            kryptonPanel5.Location = new Point(203, 1831);
            kryptonPanel5.Name = "kryptonPanel5";
            kryptonPanel5.Size = new Size(1060, 80);
            kryptonPanel5.TabIndex = 7;
            // 
            // ArrivalTimeText
            // 
            ArrivalTimeText.AlwaysActive = false;
            ArrivalTimeText.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            ArrivalTimeText.CueHint.Color1 = Color.DimGray;
            ArrivalTimeText.CueHint.CueHintText = "0 msec";
            ArrivalTimeText.CueHint.Font = new Font("Poppins", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ArrivalTimeText.CueHint.TextH = PaletteRelativeAlign.Center;
            ArrivalTimeText.CueHint.TextV = PaletteRelativeAlign.Inherit;
            ArrivalTimeText.Cursor = Cursors.IBeam;
            ArrivalTimeText.Location = new Point(678, 18);
            ArrivalTimeText.MaxLength = 10;
            ArrivalTimeText.Multiline = true;
            ArrivalTimeText.Name = "ArrivalTimeText";
            ArrivalTimeText.Size = new Size(314, 45);
            ArrivalTimeText.StateCommon.Back.Color1 = Color.FromArgb(251, 251, 251);
            ArrivalTimeText.StateCommon.Border.Color1 = Color.FromArgb(224, 224, 224);
            ArrivalTimeText.StateCommon.Border.Color2 = Color.FromArgb(224, 224, 224);
            ArrivalTimeText.StateCommon.Border.GraphicsHint = PaletteGraphicsHint.AntiAlias;
            ArrivalTimeText.StateCommon.Border.Rounding = 5F;
            ArrivalTimeText.StateCommon.Content.Color1 = Color.FromArgb(48, 56, 45);
            ArrivalTimeText.StateCommon.Content.Font = new Font("Poppins", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ArrivalTimeText.StateCommon.Content.Padding = new Padding(10, 1, 10, 1);
            ArrivalTimeText.StateCommon.Content.TextH = PaletteRelativeAlign.Center;
            ArrivalTimeText.TabIndex = 9;
            ArrivalTimeText.TextAlign = HorizontalAlignment.Center;
            ArrivalTimeText.WordWrap = false;
            // 
            // BurstTimeText
            // 
            BurstTimeText.AlwaysActive = false;
            BurstTimeText.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            BurstTimeText.CueHint.Color1 = Color.DimGray;
            BurstTimeText.CueHint.CueHintText = "0 msec";
            BurstTimeText.CueHint.Font = new Font("Poppins", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BurstTimeText.CueHint.TextH = PaletteRelativeAlign.Center;
            BurstTimeText.CueHint.TextV = PaletteRelativeAlign.Inherit;
            BurstTimeText.Cursor = Cursors.IBeam;
            BurstTimeText.Location = new Point(294, 18);
            BurstTimeText.MaxLength = 10;
            BurstTimeText.Multiline = true;
            BurstTimeText.Name = "BurstTimeText";
            BurstTimeText.Size = new Size(314, 45);
            BurstTimeText.StateCommon.Back.Color1 = Color.FromArgb(251, 251, 251);
            BurstTimeText.StateCommon.Border.Color1 = Color.FromArgb(224, 224, 224);
            BurstTimeText.StateCommon.Border.Color2 = Color.FromArgb(224, 224, 224);
            BurstTimeText.StateCommon.Border.GraphicsHint = PaletteGraphicsHint.AntiAlias;
            BurstTimeText.StateCommon.Border.Rounding = 5F;
            BurstTimeText.StateCommon.Content.Color1 = Color.FromArgb(48, 56, 45);
            BurstTimeText.StateCommon.Content.Font = new Font("Poppins", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BurstTimeText.StateCommon.Content.Padding = new Padding(10, 1, 10, 1);
            BurstTimeText.StateCommon.Content.TextH = PaletteRelativeAlign.Center;
            BurstTimeText.TabIndex = 7;
            BurstTimeText.TextAlign = HorizontalAlignment.Center;
            BurstTimeText.WordWrap = false;
            // 
            // InfoPanel
            // 
            InfoPanel.Controls.Add(AboutBtn);
            InfoPanel.Controls.Add(InfoBtn);
            InfoPanel.Controls.Add(ContinueBtn);
            InfoPanel.Location = new Point(29, 42);
            InfoPanel.Name = "InfoPanel";
            InfoPanel.Size = new Size(1294, 660);
            InfoPanel.StateCommon.Color1 = Color.Transparent;
            InfoPanel.StateCommon.Color2 = Color.Transparent;
            InfoPanel.TabIndex = 6;
            // 
            // AboutBtn
            // 
            AboutBtn.Anchor = AnchorStyles.None;
            AboutBtn.Location = new Point(1392, 953);
            AboutBtn.Name = "AboutBtn";
            AboutBtn.OverrideDefault.Back.Color1 = Color.FromArgb(251, 252, 252);
            AboutBtn.OverrideDefault.Back.Color2 = Color.FromArgb(251, 252, 252);
            AboutBtn.OverrideDefault.Border.Rounding = 10F;
            AboutBtn.OverrideDefault.Content.ShortText.Color1 = Color.FromArgb(58, 94, 116);
            AboutBtn.OverrideDefault.Content.ShortText.Color2 = Color.FromArgb(58, 94, 116);
            AboutBtn.OverrideDefault.Content.ShortText.Font = new Font("Poppins SemiBold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            AboutBtn.Size = new Size(127, 100);
            AboutBtn.StateCommon.Back.Color1 = Color.FromArgb(251, 252, 252);
            AboutBtn.StateCommon.Back.Color2 = Color.FromArgb(251, 252, 252);
            AboutBtn.StateCommon.Border.Color1 = Color.FromArgb(40, 73, 87);
            AboutBtn.StateCommon.Border.Color2 = Color.FromArgb(40, 73, 87);
            AboutBtn.StateCommon.Border.Rounding = 10F;
            AboutBtn.StateCommon.Border.Width = 2;
            AboutBtn.StateCommon.Content.ShortText.Color1 = Color.FromArgb(58, 94, 116);
            AboutBtn.StateCommon.Content.ShortText.Color2 = Color.FromArgb(58, 94, 116);
            AboutBtn.StateCommon.Content.ShortText.Font = new Font("Poppins SemiBold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            AboutBtn.StatePressed.Back.Color1 = Color.FromArgb(200, 200, 200);
            AboutBtn.StatePressed.Back.Color2 = Color.FromArgb(200, 200, 200);
            AboutBtn.StatePressed.Border.Color1 = Color.FromArgb(30, 50, 70);
            AboutBtn.StatePressed.Border.Color2 = Color.FromArgb(30, 50, 70);
            AboutBtn.StatePressed.Border.Rounding = 10F;
            AboutBtn.StatePressed.Content.ShortText.Color1 = Color.FromArgb(40, 80, 100);
            AboutBtn.StatePressed.Content.ShortText.Color2 = Color.FromArgb(40, 80, 100);
            AboutBtn.StateTracking.Back.Color1 = Color.FromArgb(230, 230, 230);
            AboutBtn.StateTracking.Back.Color2 = Color.FromArgb(230, 230, 230);
            AboutBtn.StateTracking.Border.Color1 = Color.FromArgb(60, 100, 120);
            AboutBtn.StateTracking.Border.Color2 = Color.FromArgb(60, 100, 120);
            AboutBtn.StateTracking.Border.Rounding = 10F;
            AboutBtn.StateTracking.Content.ShortText.Color1 = Color.FromArgb(80, 120, 140);
            AboutBtn.StateTracking.Content.ShortText.Color2 = Color.FromArgb(80, 120, 140);
            AboutBtn.TabIndex = 9;
            AboutBtn.Values.DropDownArrowColor = Color.Empty;
            AboutBtn.Values.Text = "About";
            // 
            // InfoBtn
            // 
            InfoBtn.Anchor = AnchorStyles.None;
            InfoBtn.Location = new Point(1126, 953);
            InfoBtn.Name = "InfoBtn";
            InfoBtn.OverrideDefault.Back.Color1 = Color.FromArgb(251, 252, 252);
            InfoBtn.OverrideDefault.Back.Color2 = Color.FromArgb(251, 252, 252);
            InfoBtn.OverrideDefault.Border.Rounding = 10F;
            InfoBtn.OverrideDefault.Content.ShortText.Color1 = Color.FromArgb(58, 94, 116);
            InfoBtn.OverrideDefault.Content.ShortText.Color2 = Color.FromArgb(58, 94, 116);
            InfoBtn.OverrideDefault.Content.ShortText.Font = new Font("Poppins SemiBold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            InfoBtn.Size = new Size(127, 100);
            InfoBtn.StateCommon.Back.Color1 = Color.FromArgb(251, 252, 252);
            InfoBtn.StateCommon.Back.Color2 = Color.FromArgb(251, 252, 252);
            InfoBtn.StateCommon.Border.Color1 = Color.FromArgb(40, 73, 87);
            InfoBtn.StateCommon.Border.Color2 = Color.FromArgb(40, 73, 87);
            InfoBtn.StateCommon.Border.Rounding = 10F;
            InfoBtn.StateCommon.Border.Width = 2;
            InfoBtn.StateCommon.Content.ShortText.Color1 = Color.FromArgb(58, 94, 116);
            InfoBtn.StateCommon.Content.ShortText.Color2 = Color.FromArgb(58, 94, 116);
            InfoBtn.StateCommon.Content.ShortText.Font = new Font("Poppins SemiBold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            InfoBtn.StatePressed.Back.Color1 = Color.FromArgb(200, 200, 200);
            InfoBtn.StatePressed.Back.Color2 = Color.FromArgb(200, 200, 200);
            InfoBtn.StatePressed.Border.Color1 = Color.FromArgb(30, 50, 70);
            InfoBtn.StatePressed.Border.Color2 = Color.FromArgb(30, 50, 70);
            InfoBtn.StatePressed.Border.Rounding = 10F;
            InfoBtn.StatePressed.Content.ShortText.Color1 = Color.FromArgb(40, 80, 100);
            InfoBtn.StatePressed.Content.ShortText.Color2 = Color.FromArgb(40, 80, 100);
            InfoBtn.StateTracking.Back.Color1 = Color.FromArgb(230, 230, 230);
            InfoBtn.StateTracking.Back.Color2 = Color.FromArgb(230, 230, 230);
            InfoBtn.StateTracking.Border.Color1 = Color.FromArgb(60, 100, 120);
            InfoBtn.StateTracking.Border.Color2 = Color.FromArgb(60, 100, 120);
            InfoBtn.StateTracking.Border.Rounding = 10F;
            InfoBtn.StateTracking.Content.ShortText.Color1 = Color.FromArgb(80, 120, 140);
            InfoBtn.StateTracking.Content.ShortText.Color2 = Color.FromArgb(80, 120, 140);
            InfoBtn.TabIndex = 8;
            InfoBtn.Values.DropDownArrowColor = Color.Empty;
            InfoBtn.Values.Text = "Info";
            // 
            // ContinueBtn
            // 
            ContinueBtn.Anchor = AnchorStyles.None;
            ContinueBtn.Location = new Point(1259, 953);
            ContinueBtn.Name = "ContinueBtn";
            ContinueBtn.OverrideDefault.Back.Color1 = Color.FromArgb(251, 252, 252);
            ContinueBtn.OverrideDefault.Back.Color2 = Color.FromArgb(251, 252, 252);
            ContinueBtn.OverrideDefault.Border.Rounding = 10F;
            ContinueBtn.OverrideDefault.Content.ShortText.Color1 = Color.FromArgb(58, 94, 116);
            ContinueBtn.OverrideDefault.Content.ShortText.Color2 = Color.FromArgb(58, 94, 116);
            ContinueBtn.OverrideDefault.Content.ShortText.Font = new Font("Poppins SemiBold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ContinueBtn.Size = new Size(127, 100);
            ContinueBtn.StateCommon.Back.Color1 = Color.FromArgb(251, 252, 252);
            ContinueBtn.StateCommon.Back.Color2 = Color.FromArgb(251, 252, 252);
            ContinueBtn.StateCommon.Border.Color1 = Color.FromArgb(40, 73, 87);
            ContinueBtn.StateCommon.Border.Color2 = Color.FromArgb(40, 73, 87);
            ContinueBtn.StateCommon.Border.Rounding = 10F;
            ContinueBtn.StateCommon.Border.Width = 2;
            ContinueBtn.StateCommon.Content.ShortText.Color1 = Color.FromArgb(58, 94, 116);
            ContinueBtn.StateCommon.Content.ShortText.Color2 = Color.FromArgb(58, 94, 116);
            ContinueBtn.StateCommon.Content.ShortText.Font = new Font("Poppins SemiBold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ContinueBtn.StatePressed.Back.Color1 = Color.FromArgb(200, 200, 200);
            ContinueBtn.StatePressed.Back.Color2 = Color.FromArgb(200, 200, 200);
            ContinueBtn.StatePressed.Border.Color1 = Color.FromArgb(30, 50, 70);
            ContinueBtn.StatePressed.Border.Color2 = Color.FromArgb(30, 50, 70);
            ContinueBtn.StatePressed.Border.Rounding = 10F;
            ContinueBtn.StatePressed.Content.ShortText.Color1 = Color.FromArgb(40, 80, 100);
            ContinueBtn.StatePressed.Content.ShortText.Color2 = Color.FromArgb(40, 80, 100);
            ContinueBtn.StateTracking.Back.Color1 = Color.FromArgb(230, 230, 230);
            ContinueBtn.StateTracking.Back.Color2 = Color.FromArgb(230, 230, 230);
            ContinueBtn.StateTracking.Border.Color1 = Color.FromArgb(60, 100, 120);
            ContinueBtn.StateTracking.Border.Color2 = Color.FromArgb(60, 100, 120);
            ContinueBtn.StateTracking.Border.Rounding = 10F;
            ContinueBtn.StateTracking.Content.ShortText.Color1 = Color.FromArgb(80, 120, 140);
            ContinueBtn.StateTracking.Content.ShortText.Color2 = Color.FromArgb(80, 120, 140);
            ContinueBtn.TabIndex = 3;
            ContinueBtn.Values.DropDownArrowColor = Color.Empty;
            ContinueBtn.Values.Text = "Play";
            // 
            // DesignArea
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(kryptonPanel5);
            Controls.Add(InputPanel);
            Controls.Add(MainTitlePanel);
            Name = "DesignArea";
            Size = new Size(2000, 2000);
            Load += DesignArea_Load;
            ((System.ComponentModel.ISupportInitialize)MainTitlePanel).EndInit();
            MainTitlePanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)InputPanel).EndInit();
            InputPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)kryptonPanel3).EndInit();
            kryptonPanel3.ResumeLayout(false);
            kryptonPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)kryptonPanel4).EndInit();
            ((System.ComponentModel.ISupportInitialize)kryptonPanel1).EndInit();
            kryptonPanel1.ResumeLayout(false);
            kryptonPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)kryptonPanel5).EndInit();
            kryptonPanel5.ResumeLayout(false);
            kryptonPanel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)InfoPanel).EndInit();
            InfoPanel.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Krypton.Toolkit.KryptonPanel MainTitlePanel;
        private Krypton.Toolkit.KryptonPanel InputPanel;
        private Krypton.Toolkit.KryptonPanel kryptonPanel1;
        private Krypton.Toolkit.KryptonLabel kryptonLabel3;
        private Krypton.Toolkit.KryptonTextBox usernameText;
        private Krypton.Toolkit.KryptonButton GenerateBtn;
        private Krypton.Toolkit.KryptonPanel kryptonPanel3;
        private Krypton.Toolkit.KryptonPanel kryptonPanel4;
        private Krypton.Toolkit.KryptonLabel ProcessTableTitle;
        private DataGridViewTextBoxColumn Column1;
        private KryptonPanel kryptonPanel5;
        private KryptonTextBox BurstTimeText;
        private KryptonTextBox ArrivalTimeText;
        private KryptonPanel InfoPanel;
        private KryptonButton AboutBtn;
        private KryptonButton InfoBtn;
        private KryptonButton ContinueBtn;
    }
}
