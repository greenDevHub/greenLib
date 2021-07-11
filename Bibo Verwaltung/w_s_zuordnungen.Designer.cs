namespace Bibo_Verwaltung
{
    partial class w_s_zuordnungen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(w_s_zuordnungen));
            this.mT_klassenstufebuch = new MetroFramework.Controls.MetroTile();
            this.metroTile1 = new MetroFramework.Controls.MetroTile();
            this.mT_klassenstufefach = new MetroFramework.Controls.MetroTile();
            this.mT_fachbuch = new MetroFramework.Controls.MetroTile();
            this.mT_Klassenstufen = new MetroFramework.Controls.MetroTile();
            this.styleManagerAssignment = new MetroFramework.Components.MetroStyleManager(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.styleManagerAssignment)).BeginInit();
            this.SuspendLayout();
            // 
            // mT_klassenstufebuch
            // 
            this.mT_klassenstufebuch.ActiveControl = null;
            this.mT_klassenstufebuch.Location = new System.Drawing.Point(8, 13);
            this.mT_klassenstufebuch.Margin = new System.Windows.Forms.Padding(8, 8, 3, 3);
            this.mT_klassenstufebuch.Name = "mT_klassenstufebuch";
            this.mT_klassenstufebuch.Size = new System.Drawing.Size(157, 46);
            this.mT_klassenstufebuch.Style = MetroFramework.MetroColorStyle.Orange;
            this.mT_klassenstufebuch.TabIndex = 14;
            this.mT_klassenstufebuch.Text = "Klassenstufe - Bücher";
            this.mT_klassenstufebuch.UseSelectable = true;
            this.mT_klassenstufebuch.Click += new System.EventHandler(this.btBookGradeClick);
            // 
            // metroTile1
            // 
            this.metroTile1.ActiveControl = null;
            this.metroTile1.Location = new System.Drawing.Point(172, 119);
            this.metroTile1.Margin = new System.Windows.Forms.Padding(3, 3, 3, 8);
            this.metroTile1.Name = "metroTile1";
            this.metroTile1.Size = new System.Drawing.Size(155, 46);
            this.metroTile1.Style = MetroFramework.MetroColorStyle.Brown;
            this.metroTile1.TabIndex = 18;
            this.metroTile1.Text = "Zurück";
            this.metroTile1.UseSelectable = true;
            this.metroTile1.Click += new System.EventHandler(this.btCloseClick);
            // 
            // mT_klassenstufefach
            // 
            this.mT_klassenstufefach.ActiveControl = null;
            this.mT_klassenstufefach.Location = new System.Drawing.Point(334, 13);
            this.mT_klassenstufefach.Margin = new System.Windows.Forms.Padding(3, 8, 8, 3);
            this.mT_klassenstufefach.Name = "mT_klassenstufefach";
            this.mT_klassenstufefach.Size = new System.Drawing.Size(157, 46);
            this.mT_klassenstufefach.Style = MetroFramework.MetroColorStyle.Orange;
            this.mT_klassenstufefach.TabIndex = 16;
            this.mT_klassenstufefach.Text = "Klassenstufe - Fächer";
            this.mT_klassenstufefach.UseSelectable = true;
            this.mT_klassenstufefach.Click += new System.EventHandler(this.btSubjectGradeClick);
            // 
            // mT_fachbuch
            // 
            this.mT_fachbuch.ActiveControl = null;
            this.mT_fachbuch.Location = new System.Drawing.Point(172, 67);
            this.mT_fachbuch.Margin = new System.Windows.Forms.Padding(3, 8, 3, 3);
            this.mT_fachbuch.Name = "mT_fachbuch";
            this.mT_fachbuch.Size = new System.Drawing.Size(155, 46);
            this.mT_fachbuch.Style = MetroFramework.MetroColorStyle.Orange;
            this.mT_fachbuch.TabIndex = 15;
            this.mT_fachbuch.Text = "Fächer - Bücher";
            this.mT_fachbuch.UseSelectable = true;
            this.mT_fachbuch.Click += new System.EventHandler(this.btBookSubjectClick);
            // 
            // mT_Klassenstufen
            // 
            this.mT_Klassenstufen.ActiveControl = null;
            this.mT_Klassenstufen.BackColor = System.Drawing.Color.OrangeRed;
            this.mT_Klassenstufen.Location = new System.Drawing.Point(172, 13);
            this.mT_Klassenstufen.Margin = new System.Windows.Forms.Padding(4);
            this.mT_Klassenstufen.Name = "mT_Klassenstufen";
            this.mT_Klassenstufen.Size = new System.Drawing.Size(155, 46);
            this.mT_Klassenstufen.Style = MetroFramework.MetroColorStyle.Orange;
            this.mT_Klassenstufen.TabIndex = 17;
            this.mT_Klassenstufen.Text = "Klassenstufe - Klassen";
            this.mT_Klassenstufen.UseSelectable = true;
            this.mT_Klassenstufen.Click += new System.EventHandler(this.btClassGradeClick);
            // 
            // styleManagerAssignment
            // 
            this.styleManagerAssignment.Owner = this;
            this.styleManagerAssignment.Style = MetroFramework.MetroColorStyle.White;
            // 
            // w_s_zuordnungen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(499, 171);
            this.ControlBox = false;
            this.Controls.Add(this.mT_klassenstufebuch);
            this.Controls.Add(this.metroTile1);
            this.Controls.Add(this.mT_klassenstufefach);
            this.Controls.Add(this.mT_Klassenstufen);
            this.Controls.Add(this.mT_fachbuch);
            this.DisplayHeader = false;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Movable = false;
            this.Name = "w_s_zuordnungen";
            this.Padding = new System.Windows.Forms.Padding(0, 30, 0, 0);
            this.Resizable = false;
            this.ShadowType = MetroFramework.Forms.MetroFormShadowType.None;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Style = MetroFramework.MetroColorStyle.Orange;
            this.Text = "w_s_zuordnungen";
            ((System.ComponentModel.ISupportInitialize)(this.styleManagerAssignment)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private MetroFramework.Controls.MetroTile mT_klassenstufebuch;
        private MetroFramework.Controls.MetroTile metroTile1;
        private MetroFramework.Controls.MetroTile mT_klassenstufefach;
        private MetroFramework.Controls.MetroTile mT_fachbuch;
        private MetroFramework.Controls.MetroTile mT_Klassenstufen;
        private MetroFramework.Components.MetroStyleManager styleManagerAssignment;
    }
}