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
            this.gb_Genres = new System.Windows.Forms.GroupBox();
            this.tLP_Sprachen = new System.Windows.Forms.TableLayoutPanel();
            this.lb_Genres = new System.Windows.Forms.Label();
            this.tb_Suchen = new System.Windows.Forms.TextBox();
            this.gv_Genres = new System.Windows.Forms.DataGridView();
            this.tLP_Button = new System.Windows.Forms.TableLayoutPanel();
            this.bt_Uebernehmen = new System.Windows.Forms.Button();
            this.bt_Suchen = new System.Windows.Forms.Button();
            this.helpProvider = new System.Windows.Forms.HelpProvider();
            this.gb_Genres.SuspendLayout();
            this.tLP_Sprachen.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gv_Genres)).BeginInit();
            this.tLP_Button.SuspendLayout();
            this.SuspendLayout();
            // 
            // gb_Genres
            // 
            this.gb_Genres.Controls.Add(this.tLP_Sprachen);
            this.gb_Genres.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gb_Genres.Location = new System.Drawing.Point(0, 0);
            this.gb_Genres.Margin = new System.Windows.Forms.Padding(2, 0, 2, 2);
            this.gb_Genres.Name = "gb_Genres";
            this.gb_Genres.Padding = new System.Windows.Forms.Padding(1);
            this.gb_Genres.Size = new System.Drawing.Size(219, 571);
            this.gb_Genres.TabIndex = 64;
            this.gb_Genres.TabStop = false;
            // 
            // tLP_Sprachen
            // 
            this.tLP_Sprachen.AutoSize = true;
            this.tLP_Sprachen.ColumnCount = 1;
            this.tLP_Sprachen.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tLP_Sprachen.Controls.Add(this.lb_Genres, 0, 0);
            this.tLP_Sprachen.Controls.Add(this.tb_Suchen, 0, 1);
            this.tLP_Sprachen.Controls.Add(this.gv_Genres, 0, 2);
            this.tLP_Sprachen.Controls.Add(this.tLP_Button, 0, 3);
            this.tLP_Sprachen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tLP_Sprachen.Location = new System.Drawing.Point(1, 14);
            this.tLP_Sprachen.Name = "tLP_Sprachen";
            this.tLP_Sprachen.RowCount = 4;
            this.tLP_Sprachen.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 3F));
            this.tLP_Sprachen.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tLP_Sprachen.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 86F));
            this.tLP_Sprachen.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6F));
            this.tLP_Sprachen.Size = new System.Drawing.Size(217, 556);
            this.tLP_Sprachen.TabIndex = 61;
            // 
            // lb_Genres
            // 
            this.lb_Genres.AutoSize = true;
            this.lb_Genres.Dock = System.Windows.Forms.DockStyle.Top;
            this.helpProvider.SetHelpString(this.lb_Genres, "Suchen sie nach gespeicherten Genres.");
            this.lb_Genres.Location = new System.Drawing.Point(3, 0);
            this.lb_Genres.Name = "lb_Genres";
            this.helpProvider.SetShowHelp(this.lb_Genres, true);
            this.lb_Genres.Size = new System.Drawing.Size(211, 15);
            this.lb_Genres.TabIndex = 53;
            this.lb_Genres.Text = "Suchen:";
            // 
            // tb_Suchen
            // 
            this.tb_Suchen.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_Suchen.Enabled = false;
            this.helpProvider.SetHelpString(this.tb_Suchen, "Suchen sie nach gespeicherten Genres.");
            this.tb_Suchen.Location = new System.Drawing.Point(3, 19);
            this.tb_Suchen.Name = "tb_Suchen";
            this.helpProvider.SetShowHelp(this.tb_Suchen, true);
            this.tb_Suchen.Size = new System.Drawing.Size(211, 20);
            this.tb_Suchen.TabIndex = 52;
            this.tb_Suchen.Visible = false;
            this.tb_Suchen.TextChanged += new System.EventHandler(this.tb_Suchen_TextChanged);
            // 
            // gv_Genres
            // 
            this.gv_Genres.AllowUserToResizeColumns = false;
            this.gv_Genres.AllowUserToResizeRows = false;
            this.gv_Genres.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gv_Genres.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gv_Genres.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gv_Genres.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.helpProvider.SetHelpString(this.gv_Genres, "Hier werden all ihre gespeicherten Genres angezeigt.");
            this.gv_Genres.Location = new System.Drawing.Point(3, 46);
            this.gv_Genres.MultiSelect = false;
            this.gv_Genres.Name = "gv_Genres";
            this.gv_Genres.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.helpProvider.SetShowHelp(this.gv_Genres, true);
            this.gv_Genres.Size = new System.Drawing.Size(211, 472);
            this.gv_Genres.TabIndex = 50;
            this.gv_Genres.CellBeginEdit += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.gv_genres_CellBeginEdit);
            this.gv_Genres.UserDeletedRow += new System.Windows.Forms.DataGridViewRowEventHandler(this.gv_genres_UserDeletedRow);
            this.gv_Genres.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.dataGridView_KeyPress);
            // 
            // tLP_Button
            // 
            this.tLP_Button.AutoSize = true;
            this.tLP_Button.ColumnCount = 2;
            this.tLP_Button.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tLP_Button.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tLP_Button.Controls.Add(this.bt_Uebernehmen, 0, 0);
            this.tLP_Button.Controls.Add(this.bt_Suchen, 1, 0);
            this.tLP_Button.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tLP_Button.Location = new System.Drawing.Point(1, 521);
            this.tLP_Button.Margin = new System.Windows.Forms.Padding(1, 0, 1, 1);
            this.tLP_Button.Name = "tLP_Button";
            this.tLP_Button.RowCount = 1;
            this.tLP_Button.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tLP_Button.Size = new System.Drawing.Size(215, 34);
            this.tLP_Button.TabIndex = 54;
            // 
            // bt_Uebernehmen
            // 
            this.bt_Uebernehmen.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.bt_Uebernehmen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.helpProvider.SetHelpString(this.bt_Uebernehmen, "Klicken sie auf diesen Button, um alle Änderungen zu übernehmen.");
            this.bt_Uebernehmen.Location = new System.Drawing.Point(3, 3);
            this.bt_Uebernehmen.Name = "bt_Uebernehmen";
            this.helpProvider.SetShowHelp(this.bt_Uebernehmen, true);
            this.bt_Uebernehmen.Size = new System.Drawing.Size(123, 28);
            this.bt_Uebernehmen.TabIndex = 51;
            this.bt_Uebernehmen.Text = "Übernehmen";
            this.bt_Uebernehmen.UseVisualStyleBackColor = true;
            this.bt_Uebernehmen.Click += new System.EventHandler(this.bt_Uebernehmen_Click);
            // 
            // bt_Suchen
            // 
            this.bt_Suchen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.helpProvider.SetHelpString(this.bt_Suchen, "Klicken sie auf diesen Button, um die Suchfunktion an- bzw. auszuschalten.");
            this.bt_Suchen.Location = new System.Drawing.Point(132, 3);
            this.bt_Suchen.Name = "bt_Suchen";
            this.helpProvider.SetShowHelp(this.bt_Suchen, true);
            this.bt_Suchen.Size = new System.Drawing.Size(80, 28);
            this.bt_Suchen.TabIndex = 54;
            this.bt_Suchen.Text = "Suchen AN";
            this.bt_Suchen.UseVisualStyleBackColor = true;
            this.bt_Suchen.Click += new System.EventHandler(this.bt_Suchen_Click);
            // 
            // w_s_genres
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(219, 571);
            this.Controls.Add(this.gb_Genres);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.HelpButton = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "w_s_genres";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Genres";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.w_s_genres_FormClosing);
            this.gb_Genres.ResumeLayout(false);
            this.gb_Genres.PerformLayout();
            this.tLP_Sprachen.ResumeLayout(false);
            this.tLP_Sprachen.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gv_Genres)).EndInit();
            this.tLP_Button.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gb_Genres;
        private System.Windows.Forms.TableLayoutPanel tLP_Sprachen;
        private System.Windows.Forms.Label lb_Genres;
        private System.Windows.Forms.TextBox tb_Suchen;
        private System.Windows.Forms.DataGridView gv_Genres;
        private System.Windows.Forms.TableLayoutPanel tLP_Button;
        private System.Windows.Forms.Button bt_Uebernehmen;
        private System.Windows.Forms.Button bt_Suchen;
        private System.Windows.Forms.HelpProvider helpProvider;
    }
}