﻿using Krypton.Toolkit;

namespace SRTN_UI.Forms
{
    partial class ComputationForm
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
            PanelCont = new KryptonPanel();
            PerProcessData = new KryptonRichTextBox();
            kryptonLabel2 = new KryptonLabel();
            kryptonLabel9 = new KryptonLabel();
            avgTurn = new KryptonLabel();
            kryptonLabel5 = new KryptonLabel();
            avgComp = new KryptonLabel();
            kryptonLabel3 = new KryptonLabel();
            avgWait = new KryptonLabel();
            kryptonLabel1 = new KryptonLabel();
            ((System.ComponentModel.ISupportInitialize)PanelCont).BeginInit();
            PanelCont.SuspendLayout();
            SuspendLayout();
            // 
            // PanelCont
            // 
            PanelCont.Controls.Add(PerProcessData);
            PanelCont.Controls.Add(kryptonLabel2);
            PanelCont.Controls.Add(kryptonLabel9);
            PanelCont.Controls.Add(avgTurn);
            PanelCont.Controls.Add(kryptonLabel5);
            PanelCont.Controls.Add(avgComp);
            PanelCont.Controls.Add(kryptonLabel3);
            PanelCont.Controls.Add(avgWait);
            PanelCont.Controls.Add(kryptonLabel1);
            PanelCont.Dock = DockStyle.Fill;
            PanelCont.Location = new Point(0, 0);
            PanelCont.Name = "PanelCont";
            PanelCont.Size = new Size(1189, 552);
            PanelCont.StateCommon.Color1 = Color.FromArgb(48, 56, 65);
            PanelCont.StateCommon.Color2 = Color.FromArgb(48, 56, 65);
            PanelCont.TabIndex = 1;
            // 
            // PerProcessData
            // 
            PerProcessData.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            PerProcessData.Location = new Point(26, 101);
            PerProcessData.Name = "PerProcessData";
            PerProcessData.ReadOnly = true;
            PerProcessData.ScrollBars = RichTextBoxScrollBars.Vertical;
            PerProcessData.Size = new Size(504, 403);
            PerProcessData.StateCommon.Border.DrawBorders = PaletteDrawBorders.Top | PaletteDrawBorders.Bottom | PaletteDrawBorders.Left | PaletteDrawBorders.Right;
            PerProcessData.StateCommon.Border.Rounding = 6F;
            PerProcessData.StateCommon.Border.Width = 1;
            PerProcessData.TabIndex = 0;
            PerProcessData.Text = "Hello";
            // 
            // kryptonLabel2
            // 
            kryptonLabel2.Location = new Point(620, 38);
            kryptonLabel2.Name = "kryptonLabel2";
            kryptonLabel2.Size = new Size(259, 35);
            kryptonLabel2.StateCommon.ShortText.Color1 = Color.FromArgb(238, 238, 238);
            kryptonLabel2.StateCommon.ShortText.Font = new Font("Poppins", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            kryptonLabel2.TabIndex = 7;
            kryptonLabel2.Values.Text = "Per Process Averages:";
            // 
            // kryptonLabel9
            // 
            kryptonLabel9.Location = new Point(26, 38);
            kryptonLabel9.Name = "kryptonLabel9";
            kryptonLabel9.Size = new Size(206, 35);
            kryptonLabel9.StateCommon.ShortText.Color1 = Color.FromArgb(238, 238, 238);
            kryptonLabel9.StateCommon.ShortText.Font = new Font("Poppins", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            kryptonLabel9.TabIndex = 6;
            kryptonLabel9.Values.Text = "Per Process Data:";
            // 
            // avgTurn
            // 
            avgTurn.Location = new Point(645, 414);
            avgTurn.Name = "avgTurn";
            avgTurn.Size = new Size(297, 35);
            avgTurn.StateCommon.ShortText.Color1 = Color.FromArgb(238, 238, 238);
            avgTurn.StateCommon.ShortText.Font = new Font("Poppins", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            avgTurn.TabIndex = 5;
            avgTurn.Values.Text = "9 + 8 +8 +0 /10 = 100 msec.";
            // 
            // kryptonLabel5
            // 
            kryptonLabel5.Location = new Point(620, 360);
            kryptonLabel5.Name = "kryptonLabel5";
            kryptonLabel5.Size = new Size(311, 35);
            kryptonLabel5.StateCommon.ShortText.Color1 = Color.FromArgb(238, 238, 238);
            kryptonLabel5.StateCommon.ShortText.Font = new Font("Poppins", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            kryptonLabel5.TabIndex = 4;
            kryptonLabel5.Values.Text = "Average Turn Around Time";
            // 
            // avgComp
            // 
            avgComp.Location = new Point(645, 289);
            avgComp.Name = "avgComp";
            avgComp.Size = new Size(297, 35);
            avgComp.StateCommon.ShortText.Color1 = Color.FromArgb(238, 238, 238);
            avgComp.StateCommon.ShortText.Font = new Font("Poppins", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            avgComp.TabIndex = 3;
            avgComp.Values.Text = "9 + 8 +8 +0 /10 = 100 msec.";
            // 
            // kryptonLabel3
            // 
            kryptonLabel3.Location = new Point(620, 216);
            kryptonLabel3.Name = "kryptonLabel3";
            kryptonLabel3.Size = new Size(322, 35);
            kryptonLabel3.StateCommon.ShortText.Color1 = Color.FromArgb(238, 238, 238);
            kryptonLabel3.StateCommon.ShortText.Font = new Font("Poppins", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            kryptonLabel3.TabIndex = 2;
            kryptonLabel3.Values.Text = "Average Computation Time";
            // 
            // avgWait
            // 
            avgWait.Location = new Point(645, 156);
            avgWait.Name = "avgWait";
            avgWait.Size = new Size(297, 35);
            avgWait.StateCommon.ShortText.Color1 = Color.FromArgb(238, 238, 238);
            avgWait.StateCommon.ShortText.Font = new Font("Poppins", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            avgWait.TabIndex = 1;
            avgWait.Values.Text = "9 + 8 +8 +0 /10 = 100 msec.";
            // 
            // kryptonLabel1
            // 
            kryptonLabel1.Location = new Point(620, 101);
            kryptonLabel1.Name = "kryptonLabel1";
            kryptonLabel1.Size = new Size(261, 35);
            kryptonLabel1.StateCommon.ShortText.Color1 = Color.FromArgb(238, 238, 238);
            kryptonLabel1.StateCommon.ShortText.Font = new Font("Poppins", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            kryptonLabel1.TabIndex = 0;
            kryptonLabel1.Values.Text = "Average Waiting Time";
            // 
            // ComputationForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(1189, 552);
            Controls.Add(PanelCont);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "ComputationForm";
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
            StateCommon.Header.Content.Image.ImageH = PaletteRelativeAlign.Center;
            StateCommon.Header.Content.ShortText.Color1 = Color.FromArgb(251, 252, 252);
            StateCommon.Header.Content.ShortText.Color2 = Color.FromArgb(251, 252, 252);
            StateCommon.Header.Content.ShortText.Font = new Font("Poppins Medium", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            StateCommon.Header.Content.ShortText.TextH = PaletteRelativeAlign.Center;
            Text = "Computation Details";
            ((System.ComponentModel.ISupportInitialize)PanelCont).EndInit();
            PanelCont.ResumeLayout(false);
            PanelCont.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Krypton.Toolkit.KryptonPanel PanelCont;
        private Krypton.Toolkit.KryptonLabel avgTurn;
        private Krypton.Toolkit.KryptonLabel kryptonLabel5;
        private Krypton.Toolkit.KryptonLabel avgComp;
        private Krypton.Toolkit.KryptonLabel kryptonLabel3;
        private Krypton.Toolkit.KryptonLabel avgWait;
        private Krypton.Toolkit.KryptonLabel kryptonLabel1;
        private Krypton.Toolkit.KryptonLabel kryptonLabel9;
        private KryptonLabel kryptonLabel2;
        private KryptonRichTextBox PerProcessData;
    }
}