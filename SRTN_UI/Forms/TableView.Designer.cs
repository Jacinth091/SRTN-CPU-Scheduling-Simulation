namespace SRTN_UI.Forms
{
    partial class TableView
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
            TableContainer = new Krypton.Toolkit.KryptonPanel();
            TableHeader = new Krypton.Toolkit.KryptonPanel();
            ProcessTitle = new Krypton.Toolkit.KryptonLabel();
            kryptonLabel1 = new Krypton.Toolkit.KryptonLabel();
            kryptonLabel2 = new Krypton.Toolkit.KryptonLabel();
            kryptonLabel3 = new Krypton.Toolkit.KryptonLabel();
            kryptonLabel4 = new Krypton.Toolkit.KryptonLabel();
            kryptonLabel5 = new Krypton.Toolkit.KryptonLabel();
            TableRowContainer = new FlowLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)TableContainer).BeginInit();
            TableContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)TableHeader).BeginInit();
            TableHeader.SuspendLayout();
            SuspendLayout();
            // 
            // TableContainer
            // 
            TableContainer.Controls.Add(TableRowContainer);
            TableContainer.Controls.Add(TableHeader);
            TableContainer.Dock = DockStyle.Fill;
            TableContainer.Location = new Point(0, 0);
            TableContainer.Name = "TableContainer";
            TableContainer.Size = new Size(1215, 400);
            TableContainer.StateCommon.Color1 = Color.FromArgb(48, 56, 65);
            TableContainer.StateCommon.Color2 = Color.FromArgb(48, 56, 65);
            TableContainer.TabIndex = 0;
            // 
            // TableHeader
            // 
            TableHeader.Controls.Add(kryptonLabel5);
            TableHeader.Controls.Add(kryptonLabel4);
            TableHeader.Controls.Add(kryptonLabel3);
            TableHeader.Controls.Add(kryptonLabel2);
            TableHeader.Controls.Add(kryptonLabel1);
            TableHeader.Controls.Add(ProcessTitle);
            TableHeader.Dock = DockStyle.Top;
            TableHeader.Location = new Point(0, 0);
            TableHeader.Name = "TableHeader";
            TableHeader.Size = new Size(1215, 73);
            TableHeader.StateCommon.Color1 = Color.FromArgb(238, 238, 238);
            TableHeader.StateCommon.Color2 = Color.FromArgb(238, 238, 238);
            TableHeader.TabIndex = 0;
            // 
            // ProcessTitle
            // 
            ProcessTitle.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            ProcessTitle.Location = new Point(31, 17);
            ProcessTitle.Name = "ProcessTitle";
            ProcessTitle.Size = new Size(121, 33);
            ProcessTitle.StateCommon.ShortText.Color1 = Color.FromArgb(215, 35, 35);
            ProcessTitle.StateCommon.ShortText.Color2 = Color.FromArgb(238, 238, 238);
            ProcessTitle.StateCommon.ShortText.Font = new Font("Poppins", 15F, FontStyle.Bold);
            ProcessTitle.StateCommon.ShortText.MultiLineH = Krypton.Toolkit.PaletteRelativeAlign.Center;
            ProcessTitle.StateCommon.ShortText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Center;
            ProcessTitle.StateCommon.ShortText.TextV = Krypton.Toolkit.PaletteRelativeAlign.Center;
            ProcessTitle.TabIndex = 4;
            ProcessTitle.Values.Text = "Process Id";
            // 
            // kryptonLabel1
            // 
            kryptonLabel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            kryptonLabel1.Location = new Point(178, 17);
            kryptonLabel1.Name = "kryptonLabel1";
            kryptonLabel1.Size = new Size(174, 33);
            kryptonLabel1.StateCommon.ShortText.Color1 = Color.FromArgb(215, 35, 35);
            kryptonLabel1.StateCommon.ShortText.Color2 = Color.FromArgb(238, 238, 238);
            kryptonLabel1.StateCommon.ShortText.Font = new Font("Poppins", 15F, FontStyle.Bold);
            kryptonLabel1.StateCommon.ShortText.MultiLineH = Krypton.Toolkit.PaletteRelativeAlign.Center;
            kryptonLabel1.StateCommon.ShortText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Center;
            kryptonLabel1.StateCommon.ShortText.TextV = Krypton.Toolkit.PaletteRelativeAlign.Center;
            kryptonLabel1.TabIndex = 5;
            kryptonLabel1.Values.Text = "CPU Burst TIme";
            // 
            // kryptonLabel2
            // 
            kryptonLabel2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            kryptonLabel2.Location = new Point(381, 17);
            kryptonLabel2.Name = "kryptonLabel2";
            kryptonLabel2.Size = new Size(142, 33);
            kryptonLabel2.StateCommon.ShortText.Color1 = Color.FromArgb(215, 35, 35);
            kryptonLabel2.StateCommon.ShortText.Color2 = Color.FromArgb(238, 238, 238);
            kryptonLabel2.StateCommon.ShortText.Font = new Font("Poppins", 15F, FontStyle.Bold);
            kryptonLabel2.StateCommon.ShortText.MultiLineH = Krypton.Toolkit.PaletteRelativeAlign.Center;
            kryptonLabel2.StateCommon.ShortText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Center;
            kryptonLabel2.StateCommon.ShortText.TextV = Krypton.Toolkit.PaletteRelativeAlign.Center;
            kryptonLabel2.TabIndex = 6;
            kryptonLabel2.Values.Text = "Arrival Time";
            // 
            // kryptonLabel3
            // 
            kryptonLabel3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            kryptonLabel3.Location = new Point(560, 17);
            kryptonLabel3.Name = "kryptonLabel3";
            kryptonLabel3.Size = new Size(213, 33);
            kryptonLabel3.StateCommon.ShortText.Color1 = Color.FromArgb(215, 35, 35);
            kryptonLabel3.StateCommon.ShortText.Color2 = Color.FromArgb(238, 238, 238);
            kryptonLabel3.StateCommon.ShortText.Font = new Font("Poppins", 15F, FontStyle.Bold);
            kryptonLabel3.StateCommon.ShortText.MultiLineH = Krypton.Toolkit.PaletteRelativeAlign.Center;
            kryptonLabel3.StateCommon.ShortText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Center;
            kryptonLabel3.StateCommon.ShortText.TextV = Krypton.Toolkit.PaletteRelativeAlign.Center;
            kryptonLabel3.TabIndex = 7;
            kryptonLabel3.Values.Text = "Current Burst TIme";
            // 
            // kryptonLabel4
            // 
            kryptonLabel4.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            kryptonLabel4.Location = new Point(808, 17);
            kryptonLabel4.Name = "kryptonLabel4";
            kryptonLabel4.Size = new Size(154, 33);
            kryptonLabel4.StateCommon.ShortText.Color1 = Color.FromArgb(215, 35, 35);
            kryptonLabel4.StateCommon.ShortText.Color2 = Color.FromArgb(238, 238, 238);
            kryptonLabel4.StateCommon.ShortText.Font = new Font("Poppins", 15F, FontStyle.Bold);
            kryptonLabel4.StateCommon.ShortText.MultiLineH = Krypton.Toolkit.PaletteRelativeAlign.Center;
            kryptonLabel4.StateCommon.ShortText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Center;
            kryptonLabel4.StateCommon.ShortText.TextV = Krypton.Toolkit.PaletteRelativeAlign.Center;
            kryptonLabel4.TabIndex = 8;
            kryptonLabel4.Values.Text = "Waiting Time";
            // 
            // kryptonLabel5
            // 
            kryptonLabel5.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            kryptonLabel5.Location = new Point(987, 17);
            kryptonLabel5.Name = "kryptonLabel5";
            kryptonLabel5.Size = new Size(202, 33);
            kryptonLabel5.StateCommon.ShortText.Color1 = Color.FromArgb(215, 35, 35);
            kryptonLabel5.StateCommon.ShortText.Color2 = Color.FromArgb(238, 238, 238);
            kryptonLabel5.StateCommon.ShortText.Font = new Font("Poppins", 15F, FontStyle.Bold);
            kryptonLabel5.StateCommon.ShortText.MultiLineH = Krypton.Toolkit.PaletteRelativeAlign.Center;
            kryptonLabel5.StateCommon.ShortText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Center;
            kryptonLabel5.StateCommon.ShortText.TextV = Krypton.Toolkit.PaletteRelativeAlign.Center;
            kryptonLabel5.TabIndex = 9;
            kryptonLabel5.Values.Text = "Turn Around TIme";
            // 
            // TableRowContainer
            // 
            TableRowContainer.BackColor = Color.Transparent;
            TableRowContainer.Dock = DockStyle.Fill;
            TableRowContainer.FlowDirection = FlowDirection.TopDown;
            TableRowContainer.Location = new Point(0, 73);
            TableRowContainer.Name = "TableRowContainer";
            TableRowContainer.Size = new Size(1215, 327);
            TableRowContainer.TabIndex = 1;
            // 
            // TableView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(TableContainer);
            MaximumSize = new Size(1215, 400);
            MinimumSize = new Size(1215, 400);
            Name = "TableView";
            Size = new Size(1215, 400);
            ((System.ComponentModel.ISupportInitialize)TableContainer).EndInit();
            TableContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)TableHeader).EndInit();
            TableHeader.ResumeLayout(false);
            TableHeader.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Krypton.Toolkit.KryptonPanel TableContainer;
        private Krypton.Toolkit.KryptonPanel TableHeader;
        private Krypton.Toolkit.KryptonLabel kryptonLabel5;
        private Krypton.Toolkit.KryptonLabel kryptonLabel4;
        private Krypton.Toolkit.KryptonLabel kryptonLabel3;
        private Krypton.Toolkit.KryptonLabel kryptonLabel2;
        private Krypton.Toolkit.KryptonLabel kryptonLabel1;
        private Krypton.Toolkit.KryptonLabel ProcessTitle;
        private FlowLayoutPanel TableRowContainer;
    }
}
