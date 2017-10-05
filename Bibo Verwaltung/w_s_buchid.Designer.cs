namespace Bibo_Verwaltung
{
    partial class w_s_buchid
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
            this.grid_buchid = new System.Windows.Forms.DataGridView();
            this.gB_buchid = new System.Windows.Forms.GroupBox();
            this.bt_clear = new System.Windows.Forms.Button();
            this.bt_zustand_add = new System.Windows.Forms.Button();
            this.lb = new System.Windows.Forms.Label();
            this.bt_add = new System.Windows.Forms.Button();
            this.rb_delete = new System.Windows.Forms.RadioButton();
            this.rb_edit = new System.Windows.Forms.RadioButton();
            this.rb_neu = new System.Windows.Forms.RadioButton();
            this.cb_zustand = new System.Windows.Forms.ComboBox();
            this.dTP_aufnahme = new System.Windows.Forms.DateTimePicker();
            this.lb_aufnahme = new System.Windows.Forms.Label();
            this.lb_zustand = new System.Windows.Forms.Label();
            this.lb_id = new System.Windows.Forms.Label();
            this.lb_isbn = new System.Windows.Forms.Label();
            this.tb_id = new System.Windows.Forms.TextBox();
            this.tb_isbn = new System.Windows.Forms.TextBox();
            this.bt_close = new System.Windows.Forms.Button();
            this.bt_export = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grid_buchid)).BeginInit();
            this.gB_buchid.SuspendLayout();
            this.SuspendLayout();
            // 
            // grid_buchid
            // 
            this.grid_buchid.AllowUserToAddRows = false;
            this.grid_buchid.AllowUserToDeleteRows = false;
            this.grid_buchid.AllowUserToResizeColumns = false;
            this.grid_buchid.AllowUserToResizeRows = false;
            this.grid_buchid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.grid_buchid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_buchid.Location = new System.Drawing.Point(300, 13);
            this.grid_buchid.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.grid_buchid.MultiSelect = false;
            this.grid_buchid.Name = "grid_buchid";
            this.grid_buchid.ReadOnly = true;
            this.grid_buchid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.grid_buchid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grid_buchid.Size = new System.Drawing.Size(578, 396);
            this.grid_buchid.TabIndex = 0;
            this.grid_buchid.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Grid_Buch_CellDoubleClick);
            // 
            // gB_buchid
            // 
            this.gB_buchid.Controls.Add(this.bt_clear);
            this.gB_buchid.Controls.Add(this.bt_zustand_add);
            this.gB_buchid.Controls.Add(this.lb);
            this.gB_buchid.Controls.Add(this.bt_add);
            this.gB_buchid.Controls.Add(this.rb_delete);
            this.gB_buchid.Controls.Add(this.rb_edit);
            this.gB_buchid.Controls.Add(this.rb_neu);
            this.gB_buchid.Controls.Add(this.cb_zustand);
            this.gB_buchid.Controls.Add(this.dTP_aufnahme);
            this.gB_buchid.Controls.Add(this.lb_aufnahme);
            this.gB_buchid.Controls.Add(this.lb_zustand);
            this.gB_buchid.Controls.Add(this.lb_id);
            this.gB_buchid.Controls.Add(this.lb_isbn);
            this.gB_buchid.Controls.Add(this.tb_id);
            this.gB_buchid.Controls.Add(this.tb_isbn);
            this.gB_buchid.Location = new System.Drawing.Point(6, 13);
            this.gB_buchid.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gB_buchid.Name = "gB_buchid";
            this.gB_buchid.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gB_buchid.Size = new System.Drawing.Size(283, 426);
            this.gB_buchid.TabIndex = 1;
            this.gB_buchid.TabStop = false;
            this.gB_buchid.Text = "Bücher";
            // 
            // bt_clear
            // 
            this.bt_clear.Location = new System.Drawing.Point(184, 142);
            this.bt_clear.Name = "bt_clear";
            this.bt_clear.Size = new System.Drawing.Size(72, 24);
            this.bt_clear.TabIndex = 19;
            this.bt_clear.Text = "Leeren";
            this.bt_clear.UseVisualStyleBackColor = true;
            // 
            // bt_zustand_add
            // 
            this.bt_zustand_add.Location = new System.Drawing.Point(261, 92);
            this.bt_zustand_add.Margin = new System.Windows.Forms.Padding(2);
            this.bt_zustand_add.Name = "bt_zustand_add";
            this.bt_zustand_add.Size = new System.Drawing.Size(15, 16);
            this.bt_zustand_add.TabIndex = 18;
            this.bt_zustand_add.Text = "+";
            this.bt_zustand_add.UseVisualStyleBackColor = true;
            this.bt_zustand_add.Click += new System.EventHandler(this.bt_zustand_Click);
            // 
            // lb
            // 
            this.lb.AutoSize = true;
            this.lb.Location = new System.Drawing.Point(68, 306);
            this.lb.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb.Name = "lb";
            this.lb.Size = new System.Drawing.Size(0, 13);
            this.lb.TabIndex = 17;
            // 
            // bt_add
            // 
            this.bt_add.Location = new System.Drawing.Point(99, 142);
            this.bt_add.Name = "bt_add";
            this.bt_add.Size = new System.Drawing.Size(72, 24);
            this.bt_add.TabIndex = 16;
            this.bt_add.Text = "Hinzufügen";
            this.bt_add.UseVisualStyleBackColor = true;
            this.bt_add.Click += new System.EventHandler(this.bt_Click);
            // 
            // rb_delete
            // 
            this.rb_delete.AutoSize = true;
            this.rb_delete.Location = new System.Drawing.Point(206, 19);
            this.rb_delete.Margin = new System.Windows.Forms.Padding(2);
            this.rb_delete.Name = "rb_delete";
            this.rb_delete.Size = new System.Drawing.Size(71, 17);
            this.rb_delete.TabIndex = 14;
            this.rb_delete.Text = "Entfernen";
            this.rb_delete.UseVisualStyleBackColor = true;
            this.rb_delete.CheckedChanged += new System.EventHandler(this.rb_Delete_CheckedChanged);
            // 
            // rb_edit
            // 
            this.rb_edit.AutoSize = true;
            this.rb_edit.Location = new System.Drawing.Point(106, 19);
            this.rb_edit.Margin = new System.Windows.Forms.Padding(2);
            this.rb_edit.Name = "rb_edit";
            this.rb_edit.Size = new System.Drawing.Size(76, 17);
            this.rb_edit.TabIndex = 13;
            this.rb_edit.Text = "Bearbeiten";
            this.rb_edit.UseVisualStyleBackColor = true;
            this.rb_edit.CheckedChanged += new System.EventHandler(this.rb_Edit_CheckedChanged);
            // 
            // rb_neu
            // 
            this.rb_neu.AutoSize = true;
            this.rb_neu.Checked = true;
            this.rb_neu.Cursor = System.Windows.Forms.Cursors.Default;
            this.rb_neu.Location = new System.Drawing.Point(6, 19);
            this.rb_neu.Margin = new System.Windows.Forms.Padding(2);
            this.rb_neu.Name = "rb_neu";
            this.rb_neu.Size = new System.Drawing.Size(79, 17);
            this.rb_neu.TabIndex = 12;
            this.rb_neu.TabStop = true;
            this.rb_neu.Text = "Hinzufügen";
            this.rb_neu.UseVisualStyleBackColor = true;
            this.rb_neu.CheckedChanged += new System.EventHandler(this.rb_Neu_CheckedChanged);
            // 
            // cb_zustand
            // 
            this.cb_zustand.FormattingEnabled = true;
            this.cb_zustand.Location = new System.Drawing.Point(99, 92);
            this.cb_zustand.Name = "cb_zustand";
            this.cb_zustand.Size = new System.Drawing.Size(158, 21);
            this.cb_zustand.TabIndex = 11;
            this.cb_zustand.TextChanged += new System.EventHandler(this.cb_zustand_TextChanged);
            // 
            // dTP_aufnahme
            // 
            this.dTP_aufnahme.Location = new System.Drawing.Point(99, 118);
            this.dTP_aufnahme.Name = "dTP_aufnahme";
            this.dTP_aufnahme.Size = new System.Drawing.Size(158, 20);
            this.dTP_aufnahme.TabIndex = 10;
            this.dTP_aufnahme.ValueChanged += new System.EventHandler(this.dTP_aufnahme_ValueChanged);
            // 
            // lb_aufnahme
            // 
            this.lb_aufnahme.AutoSize = true;
            this.lb_aufnahme.Location = new System.Drawing.Point(4, 122);
            this.lb_aufnahme.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_aufnahme.Name = "lb_aufnahme";
            this.lb_aufnahme.Size = new System.Drawing.Size(87, 13);
            this.lb_aufnahme.TabIndex = 5;
            this.lb_aufnahme.Text = "Aufnahmedatum:";
            // 
            // lb_zustand
            // 
            this.lb_zustand.AutoSize = true;
            this.lb_zustand.Location = new System.Drawing.Point(4, 94);
            this.lb_zustand.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_zustand.Name = "lb_zustand";
            this.lb_zustand.Size = new System.Drawing.Size(49, 13);
            this.lb_zustand.TabIndex = 4;
            this.lb_zustand.Text = "Zustand:";
            // 
            // lb_id
            // 
            this.lb_id.AutoSize = true;
            this.lb_id.Location = new System.Drawing.Point(4, 70);
            this.lb_id.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_id.Name = "lb_id";
            this.lb_id.Size = new System.Drawing.Size(21, 13);
            this.lb_id.TabIndex = 3;
            this.lb_id.Text = "ID:";
            // 
            // lb_isbn
            // 
            this.lb_isbn.AutoSize = true;
            this.lb_isbn.Location = new System.Drawing.Point(4, 46);
            this.lb_isbn.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_isbn.Name = "lb_isbn";
            this.lb_isbn.Size = new System.Drawing.Size(35, 13);
            this.lb_isbn.TabIndex = 2;
            this.lb_isbn.Text = "ISBN:";
            // 
            // tb_id
            // 
            this.tb_id.Location = new System.Drawing.Point(99, 67);
            this.tb_id.Name = "tb_id";
            this.tb_id.Size = new System.Drawing.Size(158, 20);
            this.tb_id.TabIndex = 1;
            this.tb_id.TextChanged += new System.EventHandler(this.tb_id_TextChanged);
            // 
            // tb_isbn
            // 
            this.tb_isbn.Location = new System.Drawing.Point(99, 43);
            this.tb_isbn.Name = "tb_isbn";
            this.tb_isbn.Size = new System.Drawing.Size(158, 20);
            this.tb_isbn.TabIndex = 0;
            this.tb_isbn.TextChanged += new System.EventHandler(this.tb_isbn_TextChanged);
            // 
            // bt_close
            // 
            this.bt_close.Location = new System.Drawing.Point(616, 416);
            this.bt_close.Name = "bt_close";
            this.bt_close.Size = new System.Drawing.Size(262, 23);
            this.bt_close.TabIndex = 21;
            this.bt_close.Text = "Schließen";
            this.bt_close.UseVisualStyleBackColor = true;
            // 
            // bt_export
            // 
            this.bt_export.Location = new System.Drawing.Point(300, 416);
            this.bt_export.Name = "bt_export";
            this.bt_export.Size = new System.Drawing.Size(262, 23);
            this.bt_export.TabIndex = 22;
            this.bt_export.Text = "Exportieren";
            this.bt_export.UseVisualStyleBackColor = true;
            // 
            // w_s_buchid
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(886, 449);
            this.Controls.Add(this.bt_export);
            this.Controls.Add(this.bt_close);
            this.Controls.Add(this.gB_buchid);
            this.Controls.Add(this.grid_buchid);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "w_s_buchid";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Exemplare";
            this.Activated += new System.EventHandler(this.w_s_buchid_Activated);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.w_s_buchid_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.grid_buchid)).EndInit();
            this.gB_buchid.ResumeLayout(false);
            this.gB_buchid.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView grid_buchid;
        private System.Windows.Forms.GroupBox gB_buchid;
        private System.Windows.Forms.Label lb_aufnahme;
        private System.Windows.Forms.Label lb_zustand;
        private System.Windows.Forms.Label lb_id;
        private System.Windows.Forms.Label lb_isbn;
        private System.Windows.Forms.TextBox tb_id;
        private System.Windows.Forms.TextBox tb_isbn;
        private System.Windows.Forms.DateTimePicker dTP_aufnahme;
        private System.Windows.Forms.ComboBox cb_zustand;
        private System.Windows.Forms.RadioButton rb_delete;
        private System.Windows.Forms.RadioButton rb_edit;
        private System.Windows.Forms.RadioButton rb_neu;
        private System.Windows.Forms.Button bt_add;
        private System.Windows.Forms.Label lb;
        private System.Windows.Forms.Button bt_zustand_add;
        private System.Windows.Forms.Button bt_clear;
        private System.Windows.Forms.Button bt_close;
        private System.Windows.Forms.Button bt_export;
    }
}