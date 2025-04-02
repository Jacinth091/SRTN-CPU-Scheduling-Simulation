namespace SRTN_UI.Forms
{
    partial class ProcessRow
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
            HeaderContainer = new Krypton.Toolkit.KryptonPanel();
            ArrivalTimeText = new Krypton.Toolkit.KryptonTextBox();
            BurstTimeText = new Krypton.Toolkit.KryptonTextBox();
            kryptonLabel2 = new Krypton.Toolkit.KryptonLabel();
            ProcessTitle = new Krypton.Toolkit.KryptonLabel();
            ((System.ComponentModel.ISupportInitialize)HeaderContainer).BeginInit();
            HeaderContainer.SuspendLayout();
            SuspendLayout();
            // 
            // HeaderContainer
            // 
            HeaderContainer.Controls.Add(ArrivalTimeText);
            HeaderContainer.Controls.Add(BurstTimeText);
            HeaderContainer.Controls.Add(kryptonLabel2);
            HeaderContainer.Controls.Add(ProcessTitle);
            HeaderContainer.Dock = DockStyle.Fill;
            HeaderContainer.Location = new Point(0, 0);
            HeaderContainer.Name = "HeaderContainer";
            HeaderContainer.Padding = new Padding(50, 1, 50, 1);
            HeaderContainer.Size = new Size(1060, 80);
            HeaderContainer.StateCommon.Color1 = Color.FromArgb(238, 238, 238);
            HeaderContainer.StateCommon.Color2 = Color.FromArgb(238, 238, 238);
            HeaderContainer.TabIndex = 1;
            // 
            // ArrivalTimeText
            // 
            ArrivalTimeText.AlwaysActive = false;
            ArrivalTimeText.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            ArrivalTimeText.CueHint.Color1 = Color.DimGray;
            ArrivalTimeText.CueHint.Font = new Font("Poppins", 12F);
            ArrivalTimeText.CueHint.TextV = Krypton.Toolkit.PaletteRelativeAlign.Near;
            ArrivalTimeText.Cursor = Cursors.IBeam;
            ArrivalTimeText.Location = new Point(678, 18);
            ArrivalTimeText.MaxLength = 10;
            ArrivalTimeText.Multiline = true;
            ArrivalTimeText.Name = "ArrivalTimeText";
            ArrivalTimeText.Size = new Size(314, 45);
            ArrivalTimeText.StateCommon.Back.Color1 = Color.FromArgb(251, 251, 251);
            ArrivalTimeText.StateCommon.Border.Color1 = Color.FromArgb(224, 224, 224);
            ArrivalTimeText.StateCommon.Border.Color2 = Color.FromArgb(224, 224, 224);
            ArrivalTimeText.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            ArrivalTimeText.StateCommon.Border.Rounding = 5F;
            ArrivalTimeText.StateCommon.Content.Color1 = Color.FromArgb(48, 56, 45);
            ArrivalTimeText.StateCommon.Content.Font = new Font("Poppins", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ArrivalTimeText.StateCommon.Content.Padding = new Padding(10, 1, 10, 1);
            ArrivalTimeText.StateCommon.Content.TextH = Krypton.Toolkit.PaletteRelativeAlign.Center;
            ArrivalTimeText.TabIndex = 8;
            ArrivalTimeText.TextAlign = HorizontalAlignment.Center;
            ArrivalTimeText.WordWrap = false;
            // 
            // BurstTimeText
            // 
            BurstTimeText.AlwaysActive = false;
            BurstTimeText.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            BurstTimeText.CueHint.Color1 = Color.DimGray;
            BurstTimeText.CueHint.Font = new Font("Poppins", 12F);
            BurstTimeText.CueHint.TextV = Krypton.Toolkit.PaletteRelativeAlign.Near;
            BurstTimeText.Cursor = Cursors.IBeam;
            BurstTimeText.Location = new Point(294, 18);
            BurstTimeText.MaxLength = 10;
            BurstTimeText.Multiline = true;
            BurstTimeText.Name = "BurstTimeText";
            BurstTimeText.Size = new Size(314, 45);
            BurstTimeText.StateCommon.Back.Color1 = Color.FromArgb(251, 251, 251);
            BurstTimeText.StateCommon.Border.Color1 = Color.FromArgb(224, 224, 224);
            BurstTimeText.StateCommon.Border.Color2 = Color.FromArgb(224, 224, 224);
            BurstTimeText.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            BurstTimeText.StateCommon.Border.Rounding = 5F;
            BurstTimeText.StateCommon.Content.Color1 = Color.FromArgb(48, 56, 45);
            BurstTimeText.StateCommon.Content.Font = new Font("Poppins", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BurstTimeText.StateCommon.Content.Padding = new Padding(10, 1, 10, 1);
            BurstTimeText.StateCommon.Content.TextH = Krypton.Toolkit.PaletteRelativeAlign.Center;
            BurstTimeText.TabIndex = 6;
            BurstTimeText.TextAlign = HorizontalAlignment.Center;
            BurstTimeText.WordWrap = false;
            // 
            // kryptonLabel2
            // 
            kryptonLabel2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            kryptonLabel2.Location = new Point(1738, 22);
            kryptonLabel2.Name = "kryptonLabel2";
            kryptonLabel2.Size = new Size(160, 37);
            kryptonLabel2.StateCommon.ShortText.Color1 = Color.FromArgb(238, 238, 238);
            kryptonLabel2.StateCommon.ShortText.Color2 = Color.FromArgb(238, 238, 238);
            kryptonLabel2.StateCommon.ShortText.Font = new Font("Poppins", 17F, FontStyle.Bold, GraphicsUnit.Point, 0);
            kryptonLabel2.StateCommon.ShortText.MultiLineH = Krypton.Toolkit.PaletteRelativeAlign.Center;
            kryptonLabel2.StateCommon.ShortText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Center;
            kryptonLabel2.StateCommon.ShortText.TextV = Krypton.Toolkit.PaletteRelativeAlign.Center;
            kryptonLabel2.TabIndex = 5;
            kryptonLabel2.Values.Text = "Arrival Time";
            // 
            // ProcessTitle
            // 
            ProcessTitle.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            ProcessTitle.Location = new Point(63, 22);
            ProcessTitle.MaximumSize = new Size(136, 37);
            ProcessTitle.MinimumSize = new Size(136, 37);
            ProcessTitle.Name = "ProcessTitle";
            ProcessTitle.Size = new Size(136, 37);
            ProcessTitle.StateCommon.ShortText.Color1 = Color.FromArgb(215, 35, 35);
            ProcessTitle.StateCommon.ShortText.Color2 = Color.FromArgb(238, 238, 238);
            ProcessTitle.StateCommon.ShortText.Font = new Font("Poppins", 17F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ProcessTitle.StateCommon.ShortText.MultiLineH = Krypton.Toolkit.PaletteRelativeAlign.Center;
            ProcessTitle.StateCommon.ShortText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Center;
            ProcessTitle.StateCommon.ShortText.TextV = Krypton.Toolkit.PaletteRelativeAlign.Center;
            ProcessTitle.TabIndex = 3;
            ProcessTitle.Values.Text = "Process Id";
            // 
            // ProcessRow
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(HeaderContainer);
            MaximumSize = new Size(1060, 80);
            MinimumSize = new Size(1060, 80);
            Name = "ProcessRow";
            Size = new Size(1060, 80);
            ((System.ComponentModel.ISupportInitialize)HeaderContainer).EndInit();
            HeaderContainer.ResumeLayout(false);
            HeaderContainer.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Krypton.Toolkit.KryptonPanel HeaderContainer;
        private Krypton.Toolkit.KryptonLabel kryptonLabel2;
        private Krypton.Toolkit.KryptonLabel ProcessTitle;
        private Krypton.Toolkit.KryptonTextBox BurstTimeText;
        private Krypton.Toolkit.KryptonTextBox ArrivalTimeText;
    }
}
