namespace SRTN_UI.Forms
{
    partial class GanttChartView
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
            MainContainer = new Krypton.Toolkit.KryptonPanel();
            ((System.ComponentModel.ISupportInitialize)MainContainer).BeginInit();
            SuspendLayout();
            // 
            // MainContainer
            // 
            MainContainer.Dock = DockStyle.Fill;
            MainContainer.Location = new Point(0, 0);
            MainContainer.Name = "MainContainer";
            MainContainer.Size = new Size(1486, 855);
            MainContainer.StateCommon.Color1 = Color.FromArgb(48, 56, 65);
            MainContainer.StateCommon.Color2 = Color.FromArgb(48, 56, 65);
            MainContainer.TabIndex = 0;
            // 
            // GanttChartView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1486, 855);
            Controls.Add(MainContainer);
            FormBorderStyle = FormBorderStyle.None;
            MaximumSize = new Size(1486, 855);
            MinimumSize = new Size(1486, 855);
            Name = "GanttChartView";
            StartPosition = FormStartPosition.CenterScreen;
            StateCommon.Back.Color1 = Color.Transparent;
            StateCommon.Back.Color2 = Color.Transparent;
            StateCommon.Border.Color1 = Color.Transparent;
            StateCommon.Border.Color2 = Color.Transparent;
            StateCommon.Border.Rounding = 0F;
            StateCommon.Border.Width = -10;
            StateCommon.Header.Back.Color1 = Color.Transparent;
            StateCommon.Header.Back.Color2 = Color.Transparent;
            StateCommon.Header.Border.Color1 = Color.Transparent;
            StateCommon.Header.Border.Color2 = Color.Transparent;
            StateCommon.Header.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.None;
            StateCommon.Header.Border.Rounding = 0F;
            StateCommon.Header.Border.Width = -10;
            StateCommon.Header.Content.ShortText.Color1 = Color.Transparent;
            StateCommon.Header.Content.ShortText.Color2 = Color.Transparent;
            StateCommon.OverlayHeaders = Krypton.Toolkit.InheritBool.False;
            Text = "ProcessTableView";
            TransparencyKey = Color.Transparent;
            ((System.ComponentModel.ISupportInitialize)MainContainer).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Krypton.Toolkit.KryptonPanel MainContainer;
    }
}