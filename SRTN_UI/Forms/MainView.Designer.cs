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
            InfoBtn = new Krypton.Toolkit.KryptonButton();
            picturebox = new Krypton.Toolkit.KryptonPictureBox();
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
            ((System.ComponentModel.ISupportInitialize)picturebox).BeginInit();
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
            kryptonPanel4.Controls.Add(InfoBtn);
            kryptonPanel4.Controls.Add(ContinueBtn);
            kryptonPanel4.Controls.Add(picturebox);
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
            // 
            // InfoBtn
            // 
            InfoBtn.Anchor = AnchorStyles.None;
            InfoBtn.Location = new Point(594, 664);
            InfoBtn.Name = "InfoBtn";
            InfoBtn.OverrideDefault.Back.Color1 = Color.FromArgb(230, 245, 255);
            InfoBtn.OverrideDefault.Back.Color2 = Color.FromArgb(230, 245, 255);
            InfoBtn.OverrideDefault.Border.Rounding = 10F;
            InfoBtn.OverrideDefault.Content.ShortText.Color1 = Color.FromArgb(30, 80, 130);
            InfoBtn.OverrideDefault.Content.ShortText.Color2 = Color.FromArgb(30, 80, 130);
            InfoBtn.OverrideDefault.Content.ShortText.Font = new Font("Poppins SemiBold", 15.75F, FontStyle.Bold);
            InfoBtn.OverrideDefault.Content.AdjacentGap = 10;

            InfoBtn.Size = new Size(127, 100);
            InfoBtn.StateCommon.Back.Color1 = Color.FromArgb(230, 245, 255);
            InfoBtn.StateCommon.Back.Color2 = Color.FromArgb(230, 245, 255);
            InfoBtn.StateCommon.Border.Color1 = Color.FromArgb(40, 100, 160);
            InfoBtn.StateCommon.Border.Color2 = Color.FromArgb(40, 100, 160);
            InfoBtn.StateCommon.Border.Rounding = 10F;
            InfoBtn.StateCommon.Border.Width = 2;
            InfoBtn.StateCommon.Content.AdjacentGap = 10;
            InfoBtn.StateCommon.Content.ShortText.Color1 = Color.FromArgb(30, 80, 130);
            InfoBtn.StateCommon.Content.ShortText.Color2 = Color.FromArgb(30, 80, 130);
            InfoBtn.StateCommon.Content.ShortText.Font = new Font("Poppins SemiBold", 15.75F, FontStyle.Bold);
            InfoBtn.StateDisabled.Back.Color1 = Color.FromArgb(240, 240, 240);
            InfoBtn.StateDisabled.Back.Color2 = Color.FromArgb(240, 240, 240);
            InfoBtn.StateDisabled.Border.Color1 = Color.Gray;
            InfoBtn.StateDisabled.Border.Color2 = Color.Gray;
            InfoBtn.StateDisabled.Border.Rounding = 10F;
            InfoBtn.StateDisabled.Content.ShortText.Color1 = Color.Gray;
            InfoBtn.StateDisabled.Content.ShortText.Color2 = Color.Gray;
            InfoBtn.StateDisabled.Content.AdjacentGap = 10;

            InfoBtn.StatePressed.Back.Color1 = Color.FromArgb(200, 230, 255);
            InfoBtn.StatePressed.Back.Color2 = Color.FromArgb(200, 230, 255);
            InfoBtn.StatePressed.Border.Color1 = Color.FromArgb(25, 70, 120);
            InfoBtn.StatePressed.Border.Color2 = Color.FromArgb(25, 70, 120);
            InfoBtn.StatePressed.Border.Rounding = 10F;
            InfoBtn.StatePressed.Content.ShortText.Color1 = Color.FromArgb(20, 60, 100);
            InfoBtn.StatePressed.Content.ShortText.Color2 = Color.FromArgb(20, 60, 100);
            InfoBtn.StatePressed.Content.AdjacentGap = 10;

            InfoBtn.StateTracking.Back.Color1 = Color.FromArgb(245, 250, 255);
            InfoBtn.StateTracking.Back.Color2 = Color.FromArgb(245, 250, 255);
            InfoBtn.StateTracking.Border.Color1 = Color.FromArgb(60, 120, 180);
            InfoBtn.StateTracking.Border.Color2 = Color.FromArgb(60, 120, 180);
            InfoBtn.StateTracking.Border.Rounding = 10F;
            InfoBtn.StateTracking.Content.ShortText.Color1 = Color.FromArgb(50, 90, 150);
            InfoBtn.StateTracking.Content.ShortText.Color2 = Color.FromArgb(50, 90, 150);
            InfoBtn.StateTracking.Content.AdjacentGap = 10;

            InfoBtn.TabIndex = 8;
            InfoBtn.Values.DropDownArrowColor = Color.Empty;
            InfoBtn.Values.Image = Properties.Resources.info_button__1_;
            InfoBtn.Values.Text = "Info";
            // 
            // picturebox
            // 
            picturebox.BackgroundImage = Properties.Resources.mainViewPic__4_;
            picturebox.BackgroundImageLayout = ImageLayout.Center;
            picturebox.Location = new Point(812, 172);
            picturebox.Name = "picturebox";
            picturebox.Size = new Size(597, 552);
            picturebox.TabIndex = 12;
            picturebox.TabStop = false;
            // 
            // ContinueBtn
            // 
            ContinueBtn.Anchor = AnchorStyles.None;
            ContinueBtn.Location = new Point(727, 664);
            ContinueBtn.Name = "ContinueBtn";
            ContinueBtn.OverrideDefault.Back.Color1 = Color.FromArgb(220, 255, 225);
            ContinueBtn.OverrideDefault.Back.Color2 = Color.FromArgb(220, 255, 225);
            ContinueBtn.OverrideDefault.Border.Rounding = 10F;
            ContinueBtn.OverrideDefault.Content.ShortText.Color1 = Color.FromArgb(20, 100, 40);
            ContinueBtn.OverrideDefault.Content.ShortText.Color2 = Color.FromArgb(20, 100, 40);
            ContinueBtn.OverrideDefault.Content.ShortText.Font = new Font("Poppins SemiBold", 15.75F, FontStyle.Bold);
            ContinueBtn.OverrideDefault.Content.AdjacentGap = 10;

            ContinueBtn.Size = new Size(127, 100);
            ContinueBtn.StateCommon.Back.Color1 = Color.FromArgb(220, 255, 225);
            ContinueBtn.StateCommon.Back.Color2 = Color.FromArgb(220, 255, 225);
            ContinueBtn.StateCommon.Border.Color1 = Color.FromArgb(40, 160, 80);
            ContinueBtn.StateCommon.Border.Color2 = Color.FromArgb(40, 160, 80);
            ContinueBtn.StateCommon.Border.Rounding = 10F;
            ContinueBtn.StateCommon.Border.Width = 2;
            ContinueBtn.StateCommon.Content.AdjacentGap = 10;
            ContinueBtn.StateCommon.Content.ShortText.Color1 = Color.FromArgb(20, 100, 40);
            ContinueBtn.StateCommon.Content.ShortText.Color2 = Color.FromArgb(20, 100, 40);
            ContinueBtn.StateCommon.Content.ShortText.Font = new Font("Poppins SemiBold", 15.75F, FontStyle.Bold);
            ContinueBtn.StateCommon.Content.ShortText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Center;
            ContinueBtn.StateCommon.Content.ShortText.TextV = Krypton.Toolkit.PaletteRelativeAlign.Center;
            ContinueBtn.StateDisabled.Back.Color1 = Color.FromArgb(240, 240, 240);
            ContinueBtn.StateDisabled.Back.Color2 = Color.FromArgb(240, 240, 240);
            ContinueBtn.StateDisabled.Border.Color1 = Color.Gray;
            ContinueBtn.StateDisabled.Border.Color2 = Color.Gray;
            ContinueBtn.StateDisabled.Border.Rounding = 10F;
            ContinueBtn.StateDisabled.Content.ShortText.Color1 = Color.Gray;
            ContinueBtn.StateDisabled.Content.ShortText.Color2 = Color.Gray;
            ContinueBtn.StateDisabled.Content.AdjacentGap = 10;

            ContinueBtn.StatePressed.Back.Color1 = Color.FromArgb(170, 230, 180);
            ContinueBtn.StatePressed.Back.Color2 = Color.FromArgb(170, 230, 180);
            ContinueBtn.StatePressed.Border.Color1 = Color.FromArgb(30, 130, 60);
            ContinueBtn.StatePressed.Border.Color2 = Color.FromArgb(30, 130, 60);
            ContinueBtn.StatePressed.Border.Rounding = 10F;
            ContinueBtn.StatePressed.Content.ShortText.Color1 = Color.FromArgb(10, 80, 30);
            ContinueBtn.StatePressed.Content.ShortText.Color2 = Color.FromArgb(10, 80, 30);
            ContinueBtn.StatePressed.Content.AdjacentGap = 10;

            ContinueBtn.StateTracking.Back.Color1 = Color.FromArgb(240, 255, 240);
            ContinueBtn.StateTracking.Back.Color2 = Color.FromArgb(240, 255, 240);
            ContinueBtn.StateTracking.Border.Color1 = Color.FromArgb(50, 180, 90);
            ContinueBtn.StateTracking.Border.Color2 = Color.FromArgb(50, 180, 90);
            ContinueBtn.StateTracking.Border.Rounding = 10F;
            ContinueBtn.StateTracking.Content.ShortText.Color1 = Color.FromArgb(30, 130, 60);
            ContinueBtn.StateTracking.Content.ShortText.Color2 = Color.FromArgb(30, 130, 60);
            ContinueBtn.StateTracking.Content.AdjacentGap = 10;

            ContinueBtn.TabIndex = 3;
            ContinueBtn.Values.DropDownArrowColor = Color.Empty;
            ContinueBtn.Values.Image = Properties.Resources.play_button__1_;
            ContinueBtn.Values.Text = "Play";
            // 
            // TitleLabel
            // 
            TitleLabel.AutoSize = false;
            TitleLabel.Location = new Point(282, 24);
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
            kryptonLabel1.Location = new Point(208, 324);
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
            kryptonLabel2.Location = new Point(208, 415);
            kryptonLabel2.Name = "kryptonLabel2";
            kryptonLabel2.Size = new Size(369, 209);
            kryptonLabel2.StateCommon.Padding = new Padding(1, 1, 70, 1);
            kryptonLabel2.StateCommon.ShortText.Color1 = Color.FromArgb(238, 238, 238);
            kryptonLabel2.StateCommon.ShortText.Color2 = Color.FromArgb(238, 238, 238);
            kryptonLabel2.StateCommon.ShortText.Font = new Font("Poppins", 17F, FontStyle.Bold, GraphicsUnit.Point, 0);
            kryptonLabel2.StateCommon.ShortText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            kryptonLabel2.TabIndex = 2;
            kryptonLabel2.Values.Text = "Members:\r\n\r\nBarral, Jacinth Cedric C.\r\nTorrepalma, Alber\r\nNuguid, Ronjay\r\nOtadoy, Evitha Louise C.";
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
            ((System.ComponentModel.ISupportInitialize)picturebox).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Krypton.Toolkit.KryptonPanel MainPanelLoader;
        private Krypton.Toolkit.KryptonPanel MainTitlePanel;
        private Krypton.Toolkit.KryptonPanel MainScreenPanel;
        private Krypton.Toolkit.KryptonPanel kryptonPanel4;
        private Krypton.Toolkit.KryptonButton ContinueBtn;
        private Krypton.Toolkit.KryptonButton InfoBtn;
        private Krypton.Toolkit.KryptonLabel TitleLabel;
        private Krypton.Toolkit.KryptonPictureBox picturebox;
        private Krypton.Toolkit.KryptonLabel kryptonLabel1;
        private Krypton.Toolkit.KryptonLabel kryptonLabel2;
    }
}