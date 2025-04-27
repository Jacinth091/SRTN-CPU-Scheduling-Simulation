namespace SRTN_UI.Forms
{
    partial class TableHeader
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
            kryptonLabel2 = new Krypton.Toolkit.KryptonLabel();
            kryptonLabel1 = new Krypton.Toolkit.KryptonLabel();
            ProcessTitle = new Krypton.Toolkit.KryptonLabel();
            ((System.ComponentModel.ISupportInitialize)kryptonPanel1).BeginInit();
            kryptonPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // kryptonPanel1
            // 
            kryptonPanel1.Controls.Add(kryptonLabel2);
            kryptonPanel1.Controls.Add(kryptonLabel1);
            kryptonPanel1.Controls.Add(ProcessTitle);
            kryptonPanel1.Dock = DockStyle.Fill;
            kryptonPanel1.Location = new Point(0, 0);
            kryptonPanel1.Name = "kryptonPanel1";
            kryptonPanel1.Size = new Size(476, 60);
            kryptonPanel1.StateCommon.Color1 = Color.FromArgb(215, 35, 35);
            kryptonPanel1.TabIndex = 1;
            // 
            // kryptonLabel2
            // 
            kryptonLabel2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            kryptonLabel2.Location = new Point(328, 16);
            kryptonLabel2.Name = "kryptonLabel2";
            kryptonLabel2.Size = new Size(115, 27);
            kryptonLabel2.StateCommon.ShortText.Color1 = Color.FromArgb(238, 238, 238);
            kryptonLabel2.StateCommon.ShortText.Color2 = Color.FromArgb(238, 238, 238);
            kryptonLabel2.StateCommon.ShortText.Font = new Font("Poppins", 12F, FontStyle.Bold);
            kryptonLabel2.StateCommon.ShortText.MultiLineH = Krypton.Toolkit.PaletteRelativeAlign.Center;
            kryptonLabel2.StateCommon.ShortText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Center;
            kryptonLabel2.StateCommon.ShortText.TextV = Krypton.Toolkit.PaletteRelativeAlign.Center;
            kryptonLabel2.TabIndex = 6;
            kryptonLabel2.Values.Text = "Arrival Time";
            // 
            // kryptonLabel1
            // 
            kryptonLabel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            kryptonLabel1.Location = new Point(180, 16);
            kryptonLabel1.Name = "kryptonLabel1";
            kryptonLabel1.Size = new Size(102, 28);
            kryptonLabel1.StateCommon.ShortText.Color1 = Color.FromArgb(238, 238, 238);
            kryptonLabel1.StateCommon.ShortText.Color2 = Color.FromArgb(238, 238, 238);
            kryptonLabel1.StateCommon.ShortText.Font = new Font("Poppins", 12F, FontStyle.Bold);
            kryptonLabel1.StateCommon.ShortText.MultiLineH = Krypton.Toolkit.PaletteRelativeAlign.Center;
            kryptonLabel1.StateCommon.ShortText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Center;
            kryptonLabel1.StateCommon.ShortText.TextV = Krypton.Toolkit.PaletteRelativeAlign.Center;
            kryptonLabel1.TabIndex = 5;
            kryptonLabel1.Values.Text = "Burst Time\r\n";
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
            // TableHeader
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(kryptonPanel1);
            Name = "TableHeader";
            Size = new Size(476, 60);
            ((System.ComponentModel.ISupportInitialize)kryptonPanel1).EndInit();
            kryptonPanel1.ResumeLayout(false);
            kryptonPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Krypton.Toolkit.KryptonPanel kryptonPanel1;
        private Krypton.Toolkit.KryptonLabel kryptonLabel2;
        private Krypton.Toolkit.KryptonLabel kryptonLabel1;
        private Krypton.Toolkit.KryptonLabel ProcessTitle;
    }
}
