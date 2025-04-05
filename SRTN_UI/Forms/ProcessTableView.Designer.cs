namespace SRTN_UI.Forms
{
    partial class ProcessTableView
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
            InputContainer = new Krypton.Toolkit.KryptonPanel();
            ProceedBtn = new Krypton.Toolkit.KryptonButton();
            Numeric = new Krypton.Toolkit.KryptonNumericUpDown();
            GenerateBtn = new Krypton.Toolkit.KryptonButton();
            kryptonLabel3 = new Krypton.Toolkit.KryptonLabel();
            ((System.ComponentModel.ISupportInitialize)MainContainer).BeginInit();
            MainContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)InputContainer).BeginInit();
            InputContainer.SuspendLayout();
            SuspendLayout();
            // 
            // MainContainer
            // 
            MainContainer.Controls.Add(InputContainer);
            MainContainer.Dock = DockStyle.Fill;
            MainContainer.Location = new Point(0, 0);
            MainContainer.Name = "MainContainer";
            MainContainer.Size = new Size(1486, 855);
            MainContainer.StateCommon.Color1 = Color.FromArgb(48, 56, 65);
            MainContainer.StateCommon.Color2 = Color.FromArgb(48, 56, 65);
            MainContainer.TabIndex = 0;
            // 
            // InputContainer
            // 
            InputContainer.Controls.Add(ProceedBtn);
            InputContainer.Controls.Add(Numeric);
            InputContainer.Controls.Add(GenerateBtn);
            InputContainer.Controls.Add(kryptonLabel3);
            InputContainer.Location = new Point(-25, 350);
            InputContainer.Name = "InputContainer";
            InputContainer.PanelBackStyle = Krypton.Toolkit.PaletteBackStyle.PanelAlternate;
            InputContainer.Size = new Size(1486, 159);
            InputContainer.StateCommon.Color1 = Color.Transparent;
            InputContainer.StateCommon.Color2 = Color.Transparent;
            InputContainer.TabIndex = 1;
            // 
            // ProceedBtn
            // 
            ProceedBtn.Location = new Point(795, 87);
            ProceedBtn.Name = "ProceedBtn";
            ProceedBtn.OverrideDefault.Back.Color1 = Color.FromArgb(6, 208, 1);
            ProceedBtn.OverrideDefault.Back.Color2 = Color.FromArgb(6, 208, 1);
            ProceedBtn.OverrideDefault.Border.Color1 = Color.White;
            ProceedBtn.OverrideDefault.Border.Color2 = Color.White;
            ProceedBtn.OverrideDefault.Border.Rounding = 10F;
            ProceedBtn.OverrideDefault.Border.Width = 2;
            ProceedBtn.OverrideDefault.Content.ShortText.Color1 = Color.White;
            ProceedBtn.OverrideDefault.Content.ShortText.Color2 = Color.White;
            ProceedBtn.OverrideDefault.Content.ShortText.Font = new Font("Poppins SemiBold", 12F, FontStyle.Bold);
            ProceedBtn.Size = new Size(160, 45);
            ProceedBtn.StateCommon.Back.Color1 = Color.FromArgb(6, 208, 1);
            ProceedBtn.StateCommon.Back.Color2 = Color.FromArgb(6, 208, 1);
            ProceedBtn.StateCommon.Border.Color1 = Color.White;
            ProceedBtn.StateCommon.Border.Color2 = Color.White;
            ProceedBtn.StateCommon.Border.Rounding = 10F;
            ProceedBtn.StateCommon.Border.Width = 2;
            ProceedBtn.StateCommon.Content.ShortText.Color1 = Color.White;
            ProceedBtn.StateCommon.Content.ShortText.Color2 = Color.White;
            ProceedBtn.StateCommon.Content.ShortText.Font = new Font("Poppins SemiBold", 12F, FontStyle.Bold);
            ProceedBtn.StateDisabled.Back.Color1 = Color.Silver;
            ProceedBtn.StateDisabled.Back.Color2 = Color.Silver;
            ProceedBtn.StatePressed.Back.Color1 = Color.FromArgb(5, 180, 0);
            ProceedBtn.StatePressed.Back.Color2 = Color.FromArgb(5, 180, 0);
            ProceedBtn.StatePressed.Border.Color1 = Color.White;
            ProceedBtn.StatePressed.Border.Color2 = Color.White;
            ProceedBtn.StatePressed.Content.ShortText.Color1 = Color.WhiteSmoke;
            ProceedBtn.StateTracking.Back.Color1 = Color.FromArgb(20, 230, 15);
            ProceedBtn.StateTracking.Back.Color2 = Color.FromArgb(20, 230, 15);
            ProceedBtn.StateTracking.Border.Color1 = Color.White;
            ProceedBtn.StateTracking.Border.Color2 = Color.White;
            ProceedBtn.StateTracking.Content.ShortText.Color1 = Color.White;
            ProceedBtn.TabIndex = 6;
            ProceedBtn.Values.DropDownArrowColor = Color.Empty;
            ProceedBtn.Values.Text = "Proceed";
            // 
            // Numeric
            // 
            Numeric.Increment = new decimal(new int[] { 1, 0, 0, 0 });
            Numeric.Location = new Point(866, 24);
            Numeric.Maximum = new decimal(new int[] { 20, 0, 0, 0 });
            Numeric.Minimum = new decimal(new int[] { 2, 0, 0, 0 });
            Numeric.Name = "Numeric";
            Numeric.Size = new Size(89, 39);
            Numeric.StateCommon.Back.Color1 = Color.FromArgb(58, 71, 80);
            Numeric.StateCommon.Border.Color1 = Color.FromArgb(215, 35, 35);
            Numeric.StateCommon.Border.Color2 = Color.FromArgb(215, 35, 35);
            Numeric.StateCommon.Border.Rounding = 5F;
            Numeric.StateCommon.Content.Color1 = Color.FromArgb(252, 252, 252);
            Numeric.StateCommon.Content.Font = new Font("Poppins", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Numeric.StateCommon.Content.Padding = new Padding(10);
            Numeric.StateCommon.Content.TextH = Krypton.Toolkit.PaletteRelativeAlign.Center;
            Numeric.TabIndex = 5;
            Numeric.UpDownButtonStyle = Krypton.Toolkit.ButtonStyle.NavigatorOverflow;
            Numeric.Value = new decimal(new int[] { 2, 0, 0, 0 });
            // 
            // GenerateBtn
            // 
            GenerateBtn.Location = new Point(572, 87);
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
            // kryptonLabel3
            // 
            kryptonLabel3.Location = new Point(559, 27);
            kryptonLabel3.Name = "kryptonLabel3";
            kryptonLabel3.Size = new Size(282, 37);
            kryptonLabel3.StateCommon.ShortText.Color1 = Color.FromArgb(238, 238, 238);
            kryptonLabel3.StateCommon.ShortText.Color2 = Color.FromArgb(238, 238, 238);
            kryptonLabel3.StateCommon.ShortText.Font = new Font("Poppins", 17F, FontStyle.Bold, GraphicsUnit.Point, 0);
            kryptonLabel3.StateCommon.ShortText.MultiLineH = Krypton.Toolkit.PaletteRelativeAlign.Center;
            kryptonLabel3.StateCommon.ShortText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Center;
            kryptonLabel3.StateCommon.ShortText.TextV = Krypton.Toolkit.PaletteRelativeAlign.Center;
            kryptonLabel3.TabIndex = 2;
            kryptonLabel3.Values.Text = "How many processes?";
            // 
            // ProcessTableView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1486, 855);
            Controls.Add(MainContainer);
            FormBorderStyle = FormBorderStyle.None;
            MaximumSize = new Size(1486, 855);
            MinimumSize = new Size(1486, 855);
            Name = "ProcessTableView";
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
            MainContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)InputContainer).EndInit();
            InputContainer.ResumeLayout(false);
            InputContainer.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Krypton.Toolkit.KryptonPanel MainContainer;
        private Krypton.Toolkit.KryptonPanel InputContainer;
        private Krypton.Toolkit.KryptonNumericUpDown Numeric;
        private Krypton.Toolkit.KryptonButton GenerateBtn;
        private Krypton.Toolkit.KryptonLabel kryptonLabel3;
        private Krypton.Toolkit.KryptonButton ProceedBtn;
    }
}