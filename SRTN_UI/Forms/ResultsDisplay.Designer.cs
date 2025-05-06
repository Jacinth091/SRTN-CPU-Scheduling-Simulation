namespace SRTN_UI.Forms
{
    partial class ResultsDisplay
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
            TurnAroundTime = new Krypton.Toolkit.KryptonLabel();
            CompletionTime = new Krypton.Toolkit.KryptonLabel();
            WaitingTime = new Krypton.Toolkit.KryptonLabel();
            kryptonLabel3 = new Krypton.Toolkit.KryptonLabel();
            kryptonLabel2 = new Krypton.Toolkit.KryptonLabel();
            kryptonLabel1 = new Krypton.Toolkit.KryptonLabel();
            ((System.ComponentModel.ISupportInitialize)kryptonPanel1).BeginInit();
            kryptonPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // kryptonPanel1
            // 
            kryptonPanel1.Controls.Add(TurnAroundTime);
            kryptonPanel1.Controls.Add(CompletionTime);
            kryptonPanel1.Controls.Add(WaitingTime);
            kryptonPanel1.Controls.Add(kryptonLabel3);
            kryptonPanel1.Controls.Add(kryptonLabel2);
            kryptonPanel1.Controls.Add(kryptonLabel1);
            kryptonPanel1.Dock = DockStyle.Fill;
            kryptonPanel1.Location = new Point(0, 0);
            kryptonPanel1.Name = "kryptonPanel1";
            kryptonPanel1.Size = new Size(1376, 100);
            kryptonPanel1.StateCommon.Color1 = Color.FromArgb(238, 238, 238);
            kryptonPanel1.TabIndex = 0;
            // 
            // TurnAroundTime
            // 
            TurnAroundTime.Location = new Point(1118, 56);
            TurnAroundTime.Name = "TurnAroundTime";
            TurnAroundTime.Size = new Size(120, 35);
            TurnAroundTime.StateCommon.ShortText.Color1 = Color.FromArgb(215, 35, 35);
            TurnAroundTime.StateCommon.ShortText.Font = new Font("Poppins", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            TurnAroundTime.TabIndex = 5;
            TurnAroundTime.Values.Text = "0.0 msec.";
            // 
            // CompletionTime
            // 
            CompletionTime.Location = new Point(596, 56);
            CompletionTime.Name = "CompletionTime";
            CompletionTime.Size = new Size(120, 35);
            CompletionTime.StateCommon.ShortText.Color1 = Color.FromArgb(215, 35, 35);
            CompletionTime.StateCommon.ShortText.Font = new Font("Poppins", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            CompletionTime.TabIndex = 4;
            CompletionTime.Values.Text = "0.0 msec.";
            // 
            // WaitingTime
            // 
            WaitingTime.Location = new Point(105, 56);
            WaitingTime.Name = "WaitingTime";
            WaitingTime.Size = new Size(120, 35);
            WaitingTime.StateCommon.ShortText.Color1 = Color.FromArgb(215, 35, 35);
            WaitingTime.StateCommon.ShortText.Font = new Font("Poppins", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            WaitingTime.TabIndex = 3;
            WaitingTime.Values.Text = "0.0 msec.";
            // 
            // kryptonLabel3
            // 
            kryptonLabel3.Location = new Point(1001, 15);
            kryptonLabel3.Name = "kryptonLabel3";
            kryptonLabel3.Size = new Size(311, 35);
            kryptonLabel3.StateCommon.ShortText.Color1 = Color.FromArgb(215, 35, 35);
            kryptonLabel3.StateCommon.ShortText.Font = new Font("Poppins", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            kryptonLabel3.TabIndex = 2;
            kryptonLabel3.Values.Text = "Average Turn Around Time";
            // 
            // kryptonLabel2
            // 
            kryptonLabel2.Location = new Point(496, 15);
            kryptonLabel2.Name = "kryptonLabel2";
            kryptonLabel2.Size = new Size(304, 35);
            kryptonLabel2.StateCommon.ShortText.Color1 = Color.FromArgb(215, 35, 35);
            kryptonLabel2.StateCommon.ShortText.Font = new Font("Poppins", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            kryptonLabel2.TabIndex = 1;
            kryptonLabel2.Values.Text = "Average Completion Time";
            // 
            // kryptonLabel1
            // 
            kryptonLabel1.Location = new Point(54, 15);
            kryptonLabel1.Name = "kryptonLabel1";
            kryptonLabel1.Size = new Size(261, 35);
            kryptonLabel1.StateCommon.ShortText.Color1 = Color.FromArgb(215, 35, 35);
            kryptonLabel1.StateCommon.ShortText.Font = new Font("Poppins", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            kryptonLabel1.TabIndex = 0;
            kryptonLabel1.Values.Text = "Average Waiting TIme";
            // 
            // ResultsDisplay
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(kryptonPanel1);
            Name = "ResultsDisplay";
            Size = new Size(1376, 100);
            ((System.ComponentModel.ISupportInitialize)kryptonPanel1).EndInit();
            kryptonPanel1.ResumeLayout(false);
            kryptonPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Krypton.Toolkit.KryptonPanel kryptonPanel1;
        private Krypton.Toolkit.KryptonLabel WaitingTime;
        private Krypton.Toolkit.KryptonLabel kryptonLabel3;
        private Krypton.Toolkit.KryptonLabel kryptonLabel2;
        private Krypton.Toolkit.KryptonLabel kryptonLabel1;
        private Krypton.Toolkit.KryptonLabel TurnAroundTime;
        private Krypton.Toolkit.KryptonLabel CompletionTime;
    }
}
