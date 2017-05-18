namespace Bibo_Verwaltung
{
    partial class w_s_genres
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
            this.lb_Genrename = new System.Windows.Forms.Label();
            this.tb_Genrename = new System.Windows.Forms.TextBox();
            this.gb_Genres2 = new System.Windows.Forms.GroupBox();
            this.lb_Genres = new System.Windows.Forms.Label();
            this.bt_Delete = new System.Windows.Forms.Button();
            this.bt_Bearbeiten = new System.Windows.Forms.Button();
            this.cb_Genres = new System.Windows.Forms.ComboBox();
            this.bt_Neu = new System.Windows.Forms.Button();
            this.gb_Genres1 = new System.Windows.Forms.GroupBox();
            this.bt_OK = new System.Windows.Forms.Button();
            this.gb_Genres2.SuspendLayout();
            this.gb_Genres1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lb_Genrename
            // 
            this.lb_Genrename.AutoSize = true;
            this.lb_Genrename.Location = new System.Drawing.Point(59, 27);
            this.lb_Genrename.Name = "lb_Genrename";
            this.lb_Genrename.Size = new System.Drawing.Size(39, 13);
            this.lb_Genrename.TabIndex = 31;
            this.lb_Genrename.Text = "Genre:";
            // 
            // tb_Genrename
            // 
            this.tb_Genrename.Location = new System.Drawing.Point(104, 24);
            this.tb_Genrename.Name = "tb_Genrename";
            this.tb_Genrename.Size = new System.Drawing.Size(200, 20);
            this.tb_Genrename.TabIndex = 1;
            // 
            // gb_Genres2
            // 
            this.gb_Genres2.Controls.Add(this.lb_Genres);
            this.gb_Genres2.Controls.Add(this.bt_Delete);
            this.gb_Genres2.Controls.Add(this.bt_Bearbeiten);
            this.gb_Genres2.Controls.Add(this.cb_Genres);
            this.gb_Genres2.Location = new System.Drawing.Point(12, 78);
            this.gb_Genres2.Name = "gb_Genres2";
            this.gb_Genres2.Size = new System.Drawing.Size(414, 89);
            this.gb_Genres2.TabIndex = 42;
            this.gb_Genres2.TabStop = false;
            this.gb_Genres2.Text = "Genre Verwalten: ";
            // 
            // lb_Genres
            // 
            this.lb_Genres.AutoSize = true;
            this.lb_Genres.Location = new System.Drawing.Point(54, 27);
            this.lb_Genres.Name = "lb_Genres";
            this.lb_Genres.Size = new System.Drawing.Size(44, 13);
            this.lb_Genres.TabIndex = 45;
            this.lb_Genres.Text = "Genres:";
            // 
            // bt_Delete
            // 
            this.bt_Delete.Location = new System.Drawing.Point(310, 51);
            this.bt_Delete.Name = "bt_Delete";
            this.bt_Delete.Size = new System.Drawing.Size(97, 23);
            this.bt_Delete.TabIndex = 5;
            this.bt_Delete.Text = "Löschen";
            this.bt_Delete.UseVisualStyleBackColor = true;
            this.bt_Delete.Click += new System.EventHandler(this.bt_Delete_Click);
            // 
            // bt_Bearbeiten
            // 
            this.bt_Bearbeiten.Location = new System.Drawing.Point(310, 22);
            this.bt_Bearbeiten.Name = "bt_Bearbeiten";
            this.bt_Bearbeiten.Size = new System.Drawing.Size(97, 23);
            this.bt_Bearbeiten.TabIndex = 4;
            this.bt_Bearbeiten.Text = "Umbenennen";
            this.bt_Bearbeiten.UseVisualStyleBackColor = true;
            this.bt_Bearbeiten.Click += new System.EventHandler(this.bt_Bearbeiten_Click);
            // 
            // cb_Genres
            // 
            this.cb_Genres.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cb_Genres.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cb_Genres.DropDownHeight = 105;
            this.cb_Genres.FormattingEnabled = true;
            this.cb_Genres.IntegralHeight = false;
            this.cb_Genres.Location = new System.Drawing.Point(104, 24);
            this.cb_Genres.MaxDropDownItems = 4;
            this.cb_Genres.Name = "cb_Genres";
            this.cb_Genres.Size = new System.Drawing.Size(200, 21);
            this.cb_Genres.Sorted = true;
            this.cb_Genres.TabIndex = 3;
            // 
            // bt_Neu
            // 
            this.bt_Neu.Location = new System.Drawing.Point(310, 22);
            this.bt_Neu.Name = "bt_Neu";
            this.bt_Neu.Size = new System.Drawing.Size(97, 23);
            this.bt_Neu.TabIndex = 2;
            this.bt_Neu.Text = "Speichern";
            this.bt_Neu.UseVisualStyleBackColor = true;
            this.bt_Neu.Click += new System.EventHandler(this.bt_Neu_Click);
            // 
            // gb_Genres1
            // 
            this.gb_Genres1.Controls.Add(this.tb_Genrename);
            this.gb_Genres1.Controls.Add(this.bt_Neu);
            this.gb_Genres1.Controls.Add(this.lb_Genrename);
            this.gb_Genres1.Location = new System.Drawing.Point(12, 12);
            this.gb_Genres1.Name = "gb_Genres1";
            this.gb_Genres1.Size = new System.Drawing.Size(414, 60);
            this.gb_Genres1.TabIndex = 43;
            this.gb_Genres1.TabStop = false;
            this.gb_Genres1.Text = "Genre hinzufügen:";
            // 
            // bt_OK
            // 
            this.bt_OK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.bt_OK.Location = new System.Drawing.Point(329, 173);
            this.bt_OK.Name = "bt_OK";
            this.bt_OK.Size = new System.Drawing.Size(97, 23);
            this.bt_OK.TabIndex = 44;
            this.bt_OK.Text = "Schließen";
            this.bt_OK.UseVisualStyleBackColor = true;
            // 
            // w_s_genres
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(438, 208);
            this.Controls.Add(this.bt_OK);
            this.Controls.Add(this.gb_Genres1);
            this.Controls.Add(this.gb_Genres2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "w_s_genres";
            this.Text = "Genres";
            this.Activated += new System.EventHandler(this.Fill_All);
            this.gb_Genres2.ResumeLayout(false);
            this.gb_Genres2.PerformLayout();
            this.gb_Genres1.ResumeLayout(false);
            this.gb_Genres1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lb_Genrename;
        private System.Windows.Forms.TextBox tb_Genrename;
        private System.Windows.Forms.GroupBox gb_Genres2;
        private System.Windows.Forms.ComboBox cb_Genres;
        private System.Windows.Forms.Label lb_Genres;
        private System.Windows.Forms.Button bt_Neu;
        private System.Windows.Forms.Button bt_Delete;
        private System.Windows.Forms.Button bt_Bearbeiten;
        private System.Windows.Forms.GroupBox gb_Genres1;
        private System.Windows.Forms.Button bt_OK;
    }
}