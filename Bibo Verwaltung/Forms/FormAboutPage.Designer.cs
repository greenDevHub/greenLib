
namespace Bibo_Verwaltung.Forms
{
    partial class FormAboutPage
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAboutPage));
            this.styleManagerAbout = new MetroFramework.Components.MetroStyleManager(this.components);
            this.lbVersionText = new MetroFramework.Controls.MetroLabel();
            this.lbVersionNumber = new MetroFramework.Controls.MetroLabel();
            this.btCheckForVersion = new MetroFramework.Controls.MetroButton();
            this.btClose = new MetroFramework.Controls.MetroButton();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.lbNewestVersionNumber = new MetroFramework.Controls.MetroLabel();
            this.lbNewestVersionText = new MetroFramework.Controls.MetroLabel();
            this.btNews = new MetroFramework.Controls.MetroButton();
            ((System.ComponentModel.ISupportInitialize)(this.styleManagerAbout)).BeginInit();
            this.SuspendLayout();
            // 
            // styleManagerAbout
            // 
            this.styleManagerAbout.Owner = this;
            // 
            // lbVersionText
            // 
            this.lbVersionText.AutoSize = true;
            this.lbVersionText.Location = new System.Drawing.Point(23, 123);
            this.lbVersionText.Name = "lbVersionText";
            this.lbVersionText.Size = new System.Drawing.Size(112, 20);
            this.lbVersionText.TabIndex = 0;
            this.lbVersionText.Text = "Aktuelle Version:";
            // 
            // lbVersionNumber
            // 
            this.lbVersionNumber.AutoSize = true;
            this.lbVersionNumber.Location = new System.Drawing.Point(133, 123);
            this.lbVersionNumber.Name = "lbVersionNumber";
            this.lbVersionNumber.Size = new System.Drawing.Size(39, 20);
            this.lbVersionNumber.TabIndex = 1;
            this.lbVersionNumber.Text = "0.0.0";
            // 
            // btCheckForVersion
            // 
            this.btCheckForVersion.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btCheckForVersion.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btCheckForVersion.FontWeight = MetroFramework.MetroButtonWeight.Light;
            this.btCheckForVersion.Location = new System.Drawing.Point(23, 145);
            this.btCheckForVersion.MaximumSize = new System.Drawing.Size(0, 24);
            this.btCheckForVersion.MinimumSize = new System.Drawing.Size(38, 24);
            this.btCheckForVersion.Name = "btCheckForVersion";
            this.btCheckForVersion.Size = new System.Drawing.Size(442, 24);
            this.btCheckForVersion.TabIndex = 7;
            this.btCheckForVersion.Text = "Auf neue Version prüfen";
            this.btCheckForVersion.UseSelectable = true;
            this.btCheckForVersion.Click += new System.EventHandler(this.btCheckForVersion_Click);
            // 
            // btClose
            // 
            this.btClose.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btClose.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btClose.FontWeight = MetroFramework.MetroButtonWeight.Light;
            this.btClose.Location = new System.Drawing.Point(23, 205);
            this.btClose.MaximumSize = new System.Drawing.Size(0, 24);
            this.btClose.MinimumSize = new System.Drawing.Size(38, 24);
            this.btClose.Name = "btClose";
            this.btClose.Size = new System.Drawing.Size(442, 24);
            this.btClose.TabIndex = 7;
            this.btClose.Text = "Schließen";
            this.btClose.UseSelectable = true;
            this.btClose.Click += new System.EventHandler(this.btClose_Click);
            // 
            // metroLabel1
            // 
            this.metroLabel1.Location = new System.Drawing.Point(23, 65);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(442, 39);
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "greenLib wurde und wird entwickelt von GreenDev, bestehend aus Robert Jehring, Er" +
    "ik Gösche, Justin Brückner, Josua Gehmlich und Laurenz Riedel.";
            this.metroLabel1.WrapToLine = true;
            // 
            // lbNewestVersionNumber
            // 
            this.lbNewestVersionNumber.AutoSize = true;
            this.lbNewestVersionNumber.Location = new System.Drawing.Point(429, 123);
            this.lbNewestVersionNumber.Name = "lbNewestVersionNumber";
            this.lbNewestVersionNumber.Size = new System.Drawing.Size(15, 20);
            this.lbNewestVersionNumber.TabIndex = 1;
            this.lbNewestVersionNumber.Text = "-";
            // 
            // lbNewestVersionText
            // 
            this.lbNewestVersionText.AutoSize = true;
            this.lbNewestVersionText.Location = new System.Drawing.Point(319, 123);
            this.lbNewestVersionText.Name = "lbNewestVersionText";
            this.lbNewestVersionText.Size = new System.Drawing.Size(107, 20);
            this.lbNewestVersionText.TabIndex = 0;
            this.lbNewestVersionText.Text = "Neuste Version:";
            // 
            // btNews
            // 
            this.btNews.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btNews.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btNews.FontWeight = MetroFramework.MetroButtonWeight.Light;
            this.btNews.Location = new System.Drawing.Point(23, 175);
            this.btNews.MaximumSize = new System.Drawing.Size(0, 24);
            this.btNews.MinimumSize = new System.Drawing.Size(38, 24);
            this.btNews.Name = "btNews";
            this.btNews.Size = new System.Drawing.Size(442, 24);
            this.btNews.TabIndex = 7;
            this.btNews.Text = "Neuigkeiten für die aktuelle Version";
            this.btNews.UseSelectable = true;
            this.btNews.Click += new System.EventHandler(this.btNews_Click);
            // 
            // FormAboutPage
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(488, 241);
            this.Controls.Add(this.btClose);
            this.Controls.Add(this.btNews);
            this.Controls.Add(this.btCheckForVersion);
            this.Controls.Add(this.lbNewestVersionNumber);
            this.Controls.Add(this.lbVersionNumber);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.lbNewestVersionText);
            this.Controls.Add(this.lbVersionText);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormAboutPage";
            this.Resizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Über greenLib";
            ((System.ComponentModel.ISupportInitialize)(this.styleManagerAbout)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Components.MetroStyleManager styleManagerAbout;
        private MetroFramework.Controls.MetroLabel lbVersionNumber;
        private MetroFramework.Controls.MetroLabel lbVersionText;
        private MetroFramework.Controls.MetroButton btCheckForVersion;
        private MetroFramework.Controls.MetroButton btClose;
        private MetroFramework.Controls.MetroLabel lbNewestVersionNumber;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel lbNewestVersionText;
        private MetroFramework.Controls.MetroButton btNews;
    }
}