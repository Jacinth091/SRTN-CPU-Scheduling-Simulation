namespace SRTN_UI.Forms
{
    partial class MainView
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
            MainPanelLoader = new Krypton.Toolkit.KryptonPanel();
            MainTitlePanel = new Krypton.Toolkit.KryptonPanel();
            MainScreenPanel = new Krypton.Toolkit.KryptonPanel();
            kryptonPanel4 = new Krypton.Toolkit.KryptonPanel();
            AboutBtn = new Krypton.Toolkit.KryptonButton();
            InfoBtn = new Krypton.Toolkit.KryptonButton();
            ContinueBtn = new Krypton.Toolkit.KryptonButton();
            TitleLabel = new Krypton.Toolkit.KryptonLabel();
            kryptonLabel1 = new Krypton.Toolkit.KryptonLabel();
            kryptonLabel2 = new Krypton.Toolkit.KryptonLabel();
            ((System.ComponentModel.ISupportInitialize)MainPanelLoader).BeginInit();
            MainPanelLoader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)MainTitlePanel).BeginInit();
            MainTitlePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)MainScreenPanel).BeginInit();
            MainScreenPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)kryptonPanel4).BeginInit();
            kryptonPanel4.SuspendLayout();
            SuspendLayout();
            // 
            // MainPanelLoader
            // 
            MainPanelLoader.Controls.Add(MainTitlePanel);
            MainPanelLoader.Dock = DockStyle.Fill;
            MainPanelLoader.Location = new Point(0, 0);
            MainPanelLoader.Name = "MainPanelLoader";
            MainPanelLoader.Size = new Size(1492, 837);
            MainPanelLoader.TabIndex = 0;
            // 
            // MainTitlePanel
            // 
            MainTitlePanel.Controls.Add(MainScreenPanel);
            MainTitlePanel.Dock = DockStyle.Fill;
            MainTitlePanel.Location = new Point(0, 0);
            MainTitlePanel.Name = "MainTitlePanel";
            MainTitlePanel.Size = new Size(1492, 837);
            MainTitlePanel.StateCommon.Color1 = Color.FromArgb(48, 56, 65);
            MainTitlePanel.StateCommon.Color2 = Color.FromArgb(48, 56, 65);
            MainTitlePanel.TabIndex = 1;
            // 
            // MainScreenPanel
            // 
            MainScreenPanel.Controls.Add(kryptonPanel4);
            MainScreenPanel.Dock = DockStyle.Fill;
            MainScreenPanel.Location = new Point(0, 0);
            MainScreenPanel.Name = "MainScreenPanel";
            MainScreenPanel.Padding = new Padding(20);
            MainScreenPanel.Size = new Size(1492, 837);
            MainScreenPanel.StateCommon.Color1 = Color.FromArgb(48, 56, 65);
            MainScreenPanel.StateCommon.Color2 = Color.FromArgb(48, 56, 65);
            MainScreenPanel.TabIndex = 1;
            // 
            // kryptonPanel4
            // 
            kryptonPanel4.Controls.Add(AboutBtn);
            kryptonPanel4.Controls.Add(InfoBtn);
            kryptonPanel4.Controls.Add(ContinueBtn);
            kryptonPanel4.Controls.Add(TitleLabel);
            kryptonPanel4.Controls.Add(kryptonLabel1);
            kryptonPanel4.Controls.Add(kryptonLabel2);
            kryptonPanel4.Dock = DockStyle.Fill;
            kryptonPanel4.Location = new Point(20, 20);
            kryptonPanel4.Name = "kryptonPanel4";
            kryptonPanel4.Size = new Size(1452, 797);
            kryptonPanel4.StateCommon.Color1 = Color.Transparent;
            kryptonPanel4.StateCommon.Color2 = Color.Transparent;
            kryptonPanel4.TabIndex = 5;
            kryptonPanel4.Paint += kryptonPanel4_Paint;
            // 
            // AboutBtn
            // 
            AboutBtn.Anchor = AnchorStyles.None;
            AboutBtn.Location = new Point(798, 664);
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
            InfoBtn.Location = new Point(532, 664);
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
            ContinueBtn.Location = new Point(665, 664);
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
            // TitleLabel
            // 
            TitleLabel.AutoSize = false;
            TitleLabel.Location = new Point(275, 110);
            TitleLabel.Name = "TitleLabel";
            TitleLabel.Size = new Size(852, 177);
            TitleLabel.StateCommon.ShortText.Color1 = Color.FromArgb(238, 238, 238);
            TitleLabel.StateCommon.ShortText.Color2 = Color.FromArgb(238, 238, 238);
            TitleLabel.StateCommon.ShortText.Font = new Font("Poppins", 30F, FontStyle.Bold, GraphicsUnit.Point, 0);
            TitleLabel.StateCommon.ShortText.MultiLineH = Krypton.Toolkit.PaletteRelativeAlign.Center;
            TitleLabel.StateCommon.ShortText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Center;
            TitleLabel.StateCommon.ShortText.TextV = Krypton.Toolkit.PaletteRelativeAlign.Center;
            TitleLabel.TabIndex = 0;
            TitleLabel.Values.Text = "Shortest Remaining Time Next \r\n(CPU Scheduling Algorithm)";
            // 
            // kryptonLabel1
            // 
            kryptonLabel1.Location = new Point(394, 293);
            kryptonLabel1.Name = "kryptonLabel1";
            kryptonLabel1.Size = new Size(292, 37);
            kryptonLabel1.StateCommon.ShortText.Color1 = Color.FromArgb(238, 238, 238);
            kryptonLabel1.StateCommon.ShortText.Color2 = Color.FromArgb(238, 238, 238);
            kryptonLabel1.StateCommon.ShortText.Font = new Font("Poppins", 17F, FontStyle.Bold, GraphicsUnit.Point, 0);
            kryptonLabel1.StateCommon.ShortText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Center;
            kryptonLabel1.StateCommon.ShortText.TextV = Krypton.Toolkit.PaletteRelativeAlign.Center;
            kryptonLabel1.TabIndex = 1;
            kryptonLabel1.Values.Text = "Developed By: Group 10";
            // 
            // kryptonLabel2
            // 
            kryptonLabel2.Location = new Point(394, 388);
            kryptonLabel2.Name = "kryptonLabel2";
            kryptonLabel2.Size = new Size(369, 209);
            kryptonLabel2.StateCommon.Padding = new Padding(1, 1, 70, 1);
            kryptonLabel2.StateCommon.ShortText.Color1 = Color.FromArgb(238, 238, 238);
            kryptonLabel2.StateCommon.ShortText.Color2 = Color.FromArgb(238, 238, 238);
            kryptonLabel2.StateCommon.ShortText.Font = new Font("Poppins", 17F, FontStyle.Bold, GraphicsUnit.Point, 0);
            kryptonLabel2.StateCommon.ShortText.MultiLineH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            kryptonLabel2.StateCommon.ShortText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Far;
            kryptonLabel2.TabIndex = 2;
            kryptonLabel2.Values.Text = "Members:\r\n\r\nBarral, Jacinth Cedric C.\r\nTorrepalma, Alber\r\nNuguid, Ronjay\r\nOtadoy, ";
            // 
            // MainView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(1492, 837);
            Controls.Add(MainPanelLoader);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MaximumSize = new Size(1506, 882);
            MinimumSize = new Size(1506, 882);
            Name = "MainView";
            StartPosition = FormStartPosition.CenterScreen;
            StateCommon.Back.Color1 = Color.FromArgb(48, 56, 65);
            StateCommon.Back.Color2 = Color.FromArgb(48, 56, 65);
            StateCommon.Border.Color1 = Color.FromArgb(48, 56, 65);
            StateCommon.Border.Color2 = Color.FromArgb(48, 56, 65);
            StateCommon.Border.Rounding = -10F;
            StateCommon.Header.Back.Color1 = Color.FromArgb(48, 56, 65);
            StateCommon.Header.Back.Color2 = Color.FromArgb(48, 56, 65);
            StateCommon.Header.Border.Color1 = Color.FromArgb(48, 56, 65);
            StateCommon.Header.Border.Color2 = Color.FromArgb(48, 56, 65);
            StateCommon.Header.Content.AdjacentGap = 10;
            StateCommon.Header.Content.Image.ImageH = Krypton.Toolkit.PaletteRelativeAlign.Center;
            StateCommon.Header.Content.ShortText.Color1 = Color.FromArgb(251, 252, 252);
            StateCommon.Header.Content.ShortText.Color2 = Color.FromArgb(251, 252, 252);
            StateCommon.Header.Content.ShortText.Font = new Font("Poppins Medium", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            StateCommon.Header.Content.ShortText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Center;
            Text = "Shortest Remaining Time Next (CPU Scheduling Algorithm)";
            ((System.ComponentModel.ISupportInitialize)MainPanelLoader).EndInit();
            MainPanelLoader.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)MainTitlePanel).EndInit();
            MainTitlePanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)MainScreenPanel).EndInit();
            MainScreenPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)kryptonPanel4).EndInit();
            kryptonPanel4.ResumeLayout(false);
            kryptonPanel4.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Krypton.Toolkit.KryptonPanel MainPanelLoader;
        private Krypton.Toolkit.KryptonPanel MainTitlePanel;
        private Krypton.Toolkit.KryptonPanel MainScreenPanel;
        private Krypton.Toolkit.KryptonLabel kryptonLabel2;
        private Krypton.Toolkit.KryptonLabel TitleLabel;
        private Krypton.Toolkit.KryptonPanel kryptonPanel4;
        private Krypton.Toolkit.KryptonButton ContinueBtn;
        private Krypton.Toolkit.KryptonLabel kryptonLabel1;
        private Krypton.Toolkit.KryptonButton AboutBtn;
        private Krypton.Toolkit.KryptonButton InfoBtn;
    }
}