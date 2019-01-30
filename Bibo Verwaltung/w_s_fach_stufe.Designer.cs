namespace Bibo_Verwaltung
{
    partial class w_s_fach_stufe
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
            this.gb = new System.Windows.Forms.GroupBox();
            this.tlp1 = new System.Windows.Forms.TableLayoutPanel();
            this.gv_fs = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.cb_stufe = new System.Windows.Forms.ComboBox();
            this.lb_klassenstufe = new System.Windows.Forms.Label();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.lb_faecher = new System.Windows.Forms.Label();
            this.lb = new System.Windows.Forms.Label();
            this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this.cLB_faecher = new System.Windows.Forms.CheckedListBox();
            this.tb_search = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.rb_add = new System.Windows.Forms.RadioButton();
            this.rb_edit = new System.Windows.Forms.RadioButton();
            this.rb_del = new System.Windows.Forms.RadioButton();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.bt_clear = new System.Windows.Forms.Button();
            this.bt_save = new System.Windows.Forms.Button();
            this.gb.SuspendLayout();
            this.tlp1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gv_fs)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.tableLayoutPanel6.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // gb
            // 
            this.gb.Controls.Add(this.tlp1);
            this.gb.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gb.Location = new System.Drawing.Point(0, 0);
            this.gb.Name = "gb";
            this.gb.Size = new System.Drawing.Size(1888, 992);
            this.gb.TabIndex = 0;
            this.gb.TabStop = false;
            // 
            // tlp1
            // 
            this.tlp1.ColumnCount = 2;
            this.tlp1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlp1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlp1.Controls.Add(this.gv_fs, 1, 0);
            this.tlp1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tlp1.Controls.Add(this.tableLayoutPanel4, 0, 1);
            this.tlp1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlp1.Location = new System.Drawing.Point(3, 34);
            this.tlp1.Name = "tlp1";
            this.tlp1.RowCount = 2;
            this.tlp1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90.90909F));
            this.tlp1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.090909F));
            this.tlp1.Size = new System.Drawing.Size(1882, 955);
            this.tlp1.TabIndex = 0;
            // 
            // gv_fs
            // 
            this.gv_fs.AllowUserToAddRows = false;
            this.gv_fs.AllowUserToDeleteRows = false;
            this.gv_fs.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.gv_fs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gv_fs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gv_fs.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnF2;
            this.gv_fs.Location = new System.Drawing.Point(944, 3);
            this.gv_fs.Name = "gv_fs";
            this.gv_fs.ReadOnly = true;
            this.gv_fs.RowTemplate.Height = 40;
            this.gv_fs.Size = new System.Drawing.Size(935, 862);
            this.gv_fs.TabIndex = 1;
            this.gv_fs.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel1, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel3, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.090909F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90.90909F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(935, 862);
            this.tableLayoutPanel2.TabIndex = 3;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.cb_stufe, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.lb_klassenstufe, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel5, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel6, 1, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 81);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.090909F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90.90909F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(929, 778);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // cb_stufe
            // 
            this.cb_stufe.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cb_stufe.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cb_stufe.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cb_stufe.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_stufe.FormattingEnabled = true;
            this.cb_stufe.Location = new System.Drawing.Point(467, 3);
            this.cb_stufe.Name = "cb_stufe";
            this.cb_stufe.Size = new System.Drawing.Size(459, 39);
            this.cb_stufe.TabIndex = 34;
            this.cb_stufe.SelectedIndexChanged += new System.EventHandler(this.cb_stufe_SelectedIndexChanged);
            // 
            // lb_klassenstufe
            // 
            this.lb_klassenstufe.AutoSize = true;
            this.lb_klassenstufe.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_klassenstufe.Location = new System.Drawing.Point(3, 0);
            this.lb_klassenstufe.Name = "lb_klassenstufe";
            this.lb_klassenstufe.Size = new System.Drawing.Size(458, 70);
            this.lb_klassenstufe.TabIndex = 35;
            this.lb_klassenstufe.Text = "Klassenstufe:";
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 1;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.Controls.Add(this.lb_faecher, 0, 0);
            this.tableLayoutPanel5.Controls.Add(this.lb, 0, 1);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(3, 73);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 2;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(458, 702);
            this.tableLayoutPanel5.TabIndex = 36;
            // 
            // lb_faecher
            // 
            this.lb_faecher.AutoSize = true;
            this.lb_faecher.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_faecher.Location = new System.Drawing.Point(3, 0);
            this.lb_faecher.Name = "lb_faecher";
            this.lb_faecher.Size = new System.Drawing.Size(452, 351);
            this.lb_faecher.TabIndex = 36;
            this.lb_faecher.Text = "Fächer:";
            // 
            // lb
            // 
            this.lb.AutoSize = true;
            this.lb.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lb.Location = new System.Drawing.Point(3, 670);
            this.lb.Name = "lb";
            this.lb.Size = new System.Drawing.Size(452, 32);
            this.lb.TabIndex = 37;
            // 
            // tableLayoutPanel6
            // 
            this.tableLayoutPanel6.ColumnCount = 1;
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel6.Controls.Add(this.cLB_faecher, 0, 1);
            this.tableLayoutPanel6.Controls.Add(this.tb_search, 0, 0);
            this.tableLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel6.Location = new System.Drawing.Point(467, 73);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            this.tableLayoutPanel6.RowCount = 2;
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.090909F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90.90909F));
            this.tableLayoutPanel6.Size = new System.Drawing.Size(459, 702);
            this.tableLayoutPanel6.TabIndex = 37;
            // 
            // cLB_faecher
            // 
            this.cLB_faecher.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cLB_faecher.FormattingEnabled = true;
            this.cLB_faecher.Location = new System.Drawing.Point(3, 66);
            this.cLB_faecher.Name = "cLB_faecher";
            this.cLB_faecher.Size = new System.Drawing.Size(453, 633);
            this.cLB_faecher.TabIndex = 34;
            // 
            // tb_search
            // 
            this.tb_search.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_search.Location = new System.Drawing.Point(3, 3);
            this.tb_search.Name = "tb_search";
            this.tb_search.Size = new System.Drawing.Size(453, 38);
            this.tb_search.TabIndex = 0;
            this.tb_search.TextChanged += new System.EventHandler(this.tb_search_TextChanged);
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 3;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel3.Controls.Add(this.rb_add, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.rb_edit, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.rb_del, 2, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(929, 72);
            this.tableLayoutPanel3.TabIndex = 1;
            // 
            // rb_add
            // 
            this.rb_add.AutoSize = true;
            this.rb_add.Checked = true;
            this.rb_add.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rb_add.Location = new System.Drawing.Point(3, 3);
            this.rb_add.Name = "rb_add";
            this.rb_add.Size = new System.Drawing.Size(303, 66);
            this.rb_add.TabIndex = 0;
            this.rb_add.TabStop = true;
            this.rb_add.Text = "Hinzufügen";
            this.rb_add.UseVisualStyleBackColor = true;
            this.rb_add.CheckedChanged += new System.EventHandler(this.rb_add_CheckedChanged);
            // 
            // rb_edit
            // 
            this.rb_edit.AutoSize = true;
            this.rb_edit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rb_edit.Location = new System.Drawing.Point(312, 3);
            this.rb_edit.Name = "rb_edit";
            this.rb_edit.Size = new System.Drawing.Size(303, 66);
            this.rb_edit.TabIndex = 0;
            this.rb_edit.Text = "Bearbeiten";
            this.rb_edit.UseVisualStyleBackColor = true;
            this.rb_edit.CheckedChanged += new System.EventHandler(this.rb_add_CheckedChanged);
            // 
            // rb_del
            // 
            this.rb_del.AutoSize = true;
            this.rb_del.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rb_del.Location = new System.Drawing.Point(621, 3);
            this.rb_del.Name = "rb_del";
            this.rb_del.Size = new System.Drawing.Size(305, 66);
            this.rb_del.TabIndex = 0;
            this.rb_del.Text = "Entfernen";
            this.rb_del.UseVisualStyleBackColor = true;
            this.rb_del.CheckedChanged += new System.EventHandler(this.rb_add_CheckedChanged);
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 2;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Controls.Add(this.bt_clear, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.bt_save, 1, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(3, 871);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(935, 81);
            this.tableLayoutPanel4.TabIndex = 4;
            // 
            // bt_clear
            // 
            this.bt_clear.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bt_clear.Location = new System.Drawing.Point(3, 3);
            this.bt_clear.Name = "bt_clear";
            this.bt_clear.Size = new System.Drawing.Size(461, 75);
            this.bt_clear.TabIndex = 3;
            this.bt_clear.Text = "Leeren";
            this.bt_clear.UseVisualStyleBackColor = true;
            this.bt_clear.Click += new System.EventHandler(this.bt_clear_Click);
            // 
            // bt_save
            // 
            this.bt_save.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bt_save.Location = new System.Drawing.Point(470, 3);
            this.bt_save.Name = "bt_save";
            this.bt_save.Size = new System.Drawing.Size(462, 75);
            this.bt_save.TabIndex = 2;
            this.bt_save.Text = "Speichern";
            this.bt_save.UseVisualStyleBackColor = true;
            this.bt_save.Click += new System.EventHandler(this.bt_save_Click);
            // 
            // w_s_fach_stufe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1888, 992);
            this.Controls.Add(this.gb);
            this.MinimumSize = new System.Drawing.Size(1920, 1080);
            this.Name = "w_s_fach_stufe";
            this.Text = "Zuordnung zwischen Fächern und Klassenstufe";
            this.gb.ResumeLayout(false);
            this.tlp1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gv_fs)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel5.PerformLayout();
            this.tableLayoutPanel6.ResumeLayout(false);
            this.tableLayoutPanel6.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gb;
        private System.Windows.Forms.TableLayoutPanel tlp1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.DataGridView gv_fs;
        private System.Windows.Forms.ComboBox cb_stufe;
        private System.Windows.Forms.Button bt_save;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.RadioButton rb_add;
        private System.Windows.Forms.RadioButton rb_edit;
        private System.Windows.Forms.RadioButton rb_del;
        private System.Windows.Forms.Label lb_klassenstufe;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Button bt_clear;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.Label lb_faecher;
        private System.Windows.Forms.Label lb;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel6;
        private System.Windows.Forms.CheckedListBox cLB_faecher;
        private System.Windows.Forms.TextBox tb_search;
    }
}