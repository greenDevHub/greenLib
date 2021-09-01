
namespace Bibo_Verwaltung.Forms
{
    partial class FormUpdateLog
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormUpdateLog));
            this.styleManagerLog = new MetroFramework.Components.MetroStyleManager(this.components);
            this.lbNews = new MetroFramework.Controls.MetroLabel();
            this.btClose = new MetroFramework.Controls.MetroButton();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            ((System.ComponentModel.ISupportInitialize)(this.styleManagerLog)).BeginInit();
            this.metroPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // styleManagerLog
            // 
            this.styleManagerLog.Owner = this;
            // 
            // lbNews
            // 
            this.lbNews.AutoSize = true;
            this.lbNews.Location = new System.Drawing.Point(0, 0);
            this.lbNews.MaximumSize = new System.Drawing.Size(425, 0);
            this.lbNews.Name = "lbNews";
            this.lbNews.Size = new System.Drawing.Size(0, 0);
            this.lbNews.TabIndex = 2;
            this.lbNews.WrapToLine = true;
            // 
            // btClose
            // 
            this.btClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btClose.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btClose.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.btClose.Location = new System.Drawing.Point(404, 254);
            this.btClose.Name = "btClose";
            this.btClose.Size = new System.Drawing.Size(135, 24);
            this.btClose.TabIndex = 4;
            this.btClose.Text = "Schließen";
            this.btClose.UseSelectable = true;
            this.btClose.Click += new System.EventHandler(this.btClose_Click);
            // 
            // metroPanel1
            // 
            this.metroPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.metroPanel1.AutoScroll = true;
            this.metroPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.metroPanel1.Controls.Add(this.lbNews);
            this.metroPanel1.HorizontalScrollbar = true;
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(20, 60);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(519, 188);
            this.metroPanel1.TabIndex = 5;
            this.metroPanel1.VerticalScrollbar = true;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 5;
            // 
            // FormUpdateLog
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(562, 293);
            this.Controls.Add(this.metroPanel1);
            this.Controls.Add(this.btClose);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormUpdateLog";
            this.Resizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Neuigkeiten zum Update x.x.x";
            ((System.ComponentModel.ISupportInitialize)(this.styleManagerLog)).EndInit();
            this.metroPanel1.ResumeLayout(false);
            this.metroPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Components.MetroStyleManager styleManagerLog;
        private MetroFramework.Controls.MetroLabel lbNews;
        private MetroFramework.Controls.MetroButton btClose;
        private MetroFramework.Controls.MetroPanel metroPanel1;
    }
}