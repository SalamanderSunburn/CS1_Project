﻿namespace ContosoUI
{
    partial class ChairsSplashScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChairsSplashScreen));
            this.marqueeProgressBarControl = new DevExpress.XtraEditors.MarqueeProgressBarControl();
            this.chairsPictureEdit = new DevExpress.XtraEditors.PictureEdit();
            ((System.ComponentModel.ISupportInitialize)(this.marqueeProgressBarControl.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chairsPictureEdit.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // marqueeProgressBarControl
            // 
            this.marqueeProgressBarControl.EditValue = 0;
            this.marqueeProgressBarControl.Location = new System.Drawing.Point(1, 461);
            this.marqueeProgressBarControl.Name = "marqueeProgressBarControl";
            this.marqueeProgressBarControl.Size = new System.Drawing.Size(627, 10);
            this.marqueeProgressBarControl.TabIndex = 5;
            // 
            // chairsPictureEdit
            // 
            this.chairsPictureEdit.EditValue = ((object)(resources.GetObject("chairsPictureEdit.EditValue")));
            this.chairsPictureEdit.Location = new System.Drawing.Point(1, 1);
            this.chairsPictureEdit.Name = "chairsPictureEdit";
            this.chairsPictureEdit.Properties.AllowFocused = false;
            this.chairsPictureEdit.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.chairsPictureEdit.Properties.Appearance.Options.UseBackColor = true;
            this.chairsPictureEdit.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.chairsPictureEdit.Properties.ShowMenu = false;
            this.chairsPictureEdit.Properties.ZoomPercent = 60D;
            this.chairsPictureEdit.Size = new System.Drawing.Size(628, 433);
            this.chairsPictureEdit.TabIndex = 9;
            // 
            // ChairsSplashScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(628, 505);
            this.Controls.Add(this.chairsPictureEdit);
            this.Controls.Add(this.marqueeProgressBarControl);
            this.Name = "ChairsSplashScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.marqueeProgressBarControl.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chairsPictureEdit.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.MarqueeProgressBarControl marqueeProgressBarControl;
        private DevExpress.XtraEditors.PictureEdit chairsPictureEdit;
    }
}
