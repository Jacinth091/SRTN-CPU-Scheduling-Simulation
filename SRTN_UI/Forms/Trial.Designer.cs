namespace SRTN_UI.Forms
{
    partial class Trial
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
            kryptonPanel1 = new Krypton.Toolkit.KryptonPanel();
            kryptonPanel2 = new Krypton.Toolkit.KryptonPanel();
            TimeLinePanel = new Krypton.Toolkit.KryptonPanel();
            NextStepBtn = new Krypton.Toolkit.KryptonButton();
            AutoPlayBtn = new Krypton.Toolkit.KryptonButton();
            ((System.ComponentModel.ISupportInitialize)kryptonPanel1).BeginInit();
            kryptonPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)kryptonPanel2).BeginInit();
            kryptonPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)TimeLinePanel).BeginInit();
            SuspendLayout();
            // 
            // kryptonPanel1
            // 
            kryptonPanel1.Controls.Add(kryptonPanel2);
            kryptonPanel1.Location = new Point(22, 88);
            kryptonPanel1.Name = "kryptonPanel1";
            kryptonPanel1.Padding = new Padding(20);
            kryptonPanel1.Size = new Size(992, 416);
            kryptonPanel1.TabIndex = 0;
            // 
            // kryptonPanel2
            // 
            kryptonPanel2.Controls.Add(TimeLinePanel);
            kryptonPanel2.Controls.Add(NextStepBtn);
            kryptonPanel2.Controls.Add(AutoPlayBtn);
            kryptonPanel2.Dock = DockStyle.Fill;
            kryptonPanel2.Location = new Point(20, 20);
            kryptonPanel2.Name = "kryptonPanel2";
            kryptonPanel2.Size = new Size(952, 376);
            kryptonPanel2.StateCommon.Color1 = Color.FromArgb(238, 238, 238);
            kryptonPanel2.TabIndex = 0;
            // 
            // TimeLinePanel
            // 
            TimeLinePanel.Location = new Point(3, 57);
            TimeLinePanel.Name = "TimeLinePanel";
            TimeLinePanel.Size = new Size(949, 289);
            TimeLinePanel.StateCommon.Color1 = Color.FromArgb(238, 216, 221);
            TimeLinePanel.TabIndex = 2;
            // 
            // NextStepBtn
            // 
            NextStepBtn.Location = new Point(820, 26);
            NextStepBtn.Name = "NextStepBtn";
            NextStepBtn.Size = new Size(90, 25);
            NextStepBtn.TabIndex = 1;
            NextStepBtn.Values.DropDownArrowColor = Color.Empty;
            NextStepBtn.Values.Text = "Next Step";
            // 
            // AutoPlayBtn
            // 
            AutoPlayBtn.Location = new Point(724, 26);
            AutoPlayBtn.Name = "AutoPlayBtn";
            AutoPlayBtn.Size = new Size(90, 25);
            AutoPlayBtn.TabIndex = 0;
            AutoPlayBtn.Values.DropDownArrowColor = Color.Empty;
            AutoPlayBtn.Values.Text = "Auto Play";
            // 
            // Trial
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1044, 547);
            Controls.Add(kryptonPanel1);
            Name = "Trial";
            Text = "Trial";
            ((System.ComponentModel.ISupportInitialize)kryptonPanel1).EndInit();
            kryptonPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)kryptonPanel2).EndInit();
            kryptonPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)TimeLinePanel).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Krypton.Toolkit.KryptonPanel kryptonPanel1;
        private Krypton.Toolkit.KryptonPanel kryptonPanel2;
        private Krypton.Toolkit.KryptonButton NextStepBtn;
        private Krypton.Toolkit.KryptonButton AutoPlayBtn;
        private Krypton.Toolkit.KryptonPanel TimeLinePanel;
    }
}