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
            this.Grid_Buchid = new System.Windows.Forms.DataGridView();
            this.gB_buchid = new System.Windows.Forms.GroupBox();
            this.lb = new System.Windows.Forms.Label();
            this.bt = new System.Windows.Forms.Button();
            this.rb_Delete = new System.Windows.Forms.RadioButton();
            this.rb_Edit = new System.Windows.Forms.RadioButton();
            this.rb_Neu = new System.Windows.Forms.RadioButton();
            this.cb_zustand = new System.Windows.Forms.ComboBox();
            this.dTP_aufnahme = new System.Windows.Forms.DateTimePicker();
            this.lb_aufnahme = new System.Windows.Forms.Label();
            this.lb_zustand = new System.Windows.Forms.Label();
            this.lb_id = new System.Windows.Forms.Label();
            this.lb_isbn = new System.Windows.Forms.Label();
            this.tb_id = new System.Windows.Forms.TextBox();
            this.tb_isbn = new System.Windows.Forms.TextBox();
            this.bt_zustand = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Grid_Buchid)).BeginInit();
            this.gB_buchid.SuspendLayout();
            this.SuspendLayout();
            // 
            // Grid_Buchid
            // 
            this.Grid_Buchid.AllowUserToAddRows = false;
            this.Grid_Buchid.AllowUserToDeleteRows = false;
            this.Grid_Buchid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Grid_Buchid.Location = new System.Drawing.Point(72, 23);
            this.Grid_Buchid.Margin = new System.Windows.Forms.Padding(6);
            this.Grid_Buchid.Name = "Grid_Buchid";
            this.Grid_Buchid.ReadOnly = true;
            this.Grid_Buchid.RowTemplate.Height = 24;
            this.Grid_Buchid.Size = new System.Drawing.Size(790, 758);
            this.Grid_Buchid.TabIndex = 0;
            this.Grid_Buchid.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Grid_Buch_CellDoubleClick);
            // 
            // gB_buchid
            // 
            this.gB_buchid.Controls.Add(this.bt_zustand);
            this.gB_buchid.Controls.Add(this.lb);
            this.gB_buchid.Controls.Add(this.bt);
            this.gB_buchid.Controls.Add(this.rb_Delete);
            this.gB_buchid.Controls.Add(this.rb_Edit);
            this.gB_buchid.Controls.Add(this.rb_Neu);
            this.gB_buchid.Controls.Add(this.cb_zustand);
            this.gB_buchid.Controls.Add(this.dTP_aufnahme);
            this.gB_buchid.Controls.Add(this.lb_aufnahme);
            this.gB_buchid.Controls.Add(this.lb_zustand);
            this.gB_buchid.Controls.Add(this.lb_id);
            this.gB_buchid.Controls.Add(this.lb_isbn);
            this.gB_buchid.Controls.Add(this.tb_id);
            this.gB_buchid.Controls.Add(this.tb_isbn);
            this.gB_buchid.Location = new System.Drawing.Point(914, 23);
            this.gB_buchid.Margin = new System.Windows.Forms.Padding(6);
            this.gB_buchid.Name = "gB_buchid";
            this.gB_buchid.Padding = new System.Windows.Forms.Padding(6);
            this.gB_buchid.Size = new System.Drawing.Size(754, 758);
            this.gB_buchid.TabIndex = 1;
            this.gB_buchid.TabStop = false;
            this.gB_buchid.Text = "Bücher";
            // 
            // lb
            // 
            this.lb.AutoSize = true;
            this.lb.Location = new System.Drawing.Point(181, 730);
            this.lb.Name = "lb";
            this.lb.Size = new System.Drawing.Size(0, 32);
            this.lb.TabIndex = 17;
            // 
            // bt
            // 
            this.bt.Location = new System.Drawing.Point(306, 632);
            this.bt.Name = "bt";
            this.bt.Size = new System.Drawing.Size(186, 64);
            this.bt.TabIndex = 16;
            this.bt.Text = "Hinzufügen";
            this.bt.UseVisualStyleBackColor = true;
            this.bt.Click += new System.EventHandler(this.bt_Click);
            // 
            // rb_Delete
            // 
            this.rb_Delete.AutoSize = true;
            this.rb_Delete.Location = new System.Drawing.Point(343, 528);
            this.rb_Delete.Name = "rb_Delete";
            this.rb_Delete.Size = new System.Drawing.Size(223, 36);
            this.rb_Delete.TabIndex = 14;
            this.rb_Delete.Text = "Buch löschen";
            this.rb_Delete.UseVisualStyleBackColor = true;
            this.rb_Delete.CheckedChanged += new System.EventHandler(this.rb_Delete_CheckedChanged);
            // 
            // rb_Edit
            // 
            this.rb_Edit.AutoSize = true;
            this.rb_Edit.Location = new System.Drawing.Point(343, 486);
            this.rb_Edit.Name = "rb_Edit";
            this.rb_Edit.Size = new System.Drawing.Size(260, 36);
            this.rb_Edit.TabIndex = 13;
            this.rb_Edit.Text = "Buch bearbeiten";
            this.rb_Edit.UseVisualStyleBackColor = true;
            this.rb_Edit.CheckedChanged += new System.EventHandler(this.rb_Edit_CheckedChanged);
            // 
            // rb_Neu
            // 
            this.rb_Neu.AutoSize = true;
            this.rb_Neu.Checked = true;
            this.rb_Neu.Cursor = System.Windows.Forms.Cursors.Default;
            this.rb_Neu.Location = new System.Drawing.Point(343, 444);
            this.rb_Neu.Name = "rb_Neu";
            this.rb_Neu.Size = new System.Drawing.Size(354, 36);
            this.rb_Neu.TabIndex = 12;
            this.rb_Neu.TabStop = true;
            this.rb_Neu.Text = "Neues Buch hinzufügen";
            this.rb_Neu.UseVisualStyleBackColor = true;
            this.rb_Neu.CheckedChanged += new System.EventHandler(this.rb_Neu_CheckedChanged);
            // 
            // cb_zustand
            // 
            this.cb_zustand.FormattingEnabled = true;
            this.cb_zustand.Location = new System.Drawing.Point(340, 264);
            this.cb_zustand.Name = "cb_zustand";
            this.cb_zustand.Size = new System.Drawing.Size(340, 39);
            this.cb_zustand.TabIndex = 11;
            this.cb_zustand.TextChanged += new System.EventHandler(this.cb_zustand_TextChanged);
            // 
            // dTP_aufnahme
            // 
            this.dTP_aufnahme.Location = new System.Drawing.Point(340, 347);
            this.dTP_aufnahme.Margin = new System.Windows.Forms.Padding(6);
            this.dTP_aufnahme.Name = "dTP_aufnahme";
            this.dTP_aufnahme.Size = new System.Drawing.Size(340, 38);
            this.dTP_aufnahme.TabIndex = 10;
            this.dTP_aufnahme.ValueChanged += new System.EventHandler(this.dTP_aufnahme_ValueChanged);
            // 
            // lb_aufnahme
            // 
            this.lb_aufnahme.AutoSize = true;
            this.lb_aufnahme.Location = new System.Drawing.Point(22, 347);
            this.lb_aufnahme.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lb_aufnahme.Name = "lb_aufnahme";
            this.lb_aufnahme.Size = new System.Drawing.Size(296, 32);
            this.lb_aufnahme.TabIndex = 5;
            this.lb_aufnahme.Text = "Buch Aufnahmedatum";
            // 
            // lb_zustand
            // 
            this.lb_zustand.AutoSize = true;
            this.lb_zustand.Location = new System.Drawing.Point(22, 264);
            this.lb_zustand.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lb_zustand.Name = "lb_zustand";
            this.lb_zustand.Size = new System.Drawing.Size(190, 32);
            this.lb_zustand.TabIndex = 4;
            this.lb_zustand.Text = "Buch Zustand";
            // 
            // lb_id
            // 
            this.lb_id.AutoSize = true;
            this.lb_id.Location = new System.Drawing.Point(22, 151);
            this.lb_id.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lb_id.Name = "lb_id";
            this.lb_id.Size = new System.Drawing.Size(114, 32);
            this.lb_id.TabIndex = 3;
            this.lb_id.Text = "Buch ID";
            // 
            // lb_isbn
            // 
            this.lb_isbn.AutoSize = true;
            this.lb_isbn.Location = new System.Drawing.Point(22, 50);
            this.lb_isbn.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lb_isbn.Name = "lb_isbn";
            this.lb_isbn.Size = new System.Drawing.Size(80, 32);
            this.lb_isbn.TabIndex = 2;
            this.lb_isbn.Text = "ISBN";
            // 
            // tb_id
            // 
            this.tb_id.Location = new System.Drawing.Point(340, 151);
            this.tb_id.Margin = new System.Windows.Forms.Padding(6);
            this.tb_id.Name = "tb_id";
            this.tb_id.Size = new System.Drawing.Size(340, 38);
            this.tb_id.TabIndex = 1;
            this.tb_id.TextChanged += new System.EventHandler(this.tb_id_TextChanged);
            // 
            // tb_isbn
            // 
            this.tb_isbn.Location = new System.Drawing.Point(340, 41);
            this.tb_isbn.Margin = new System.Windows.Forms.Padding(6);
            this.tb_isbn.Name = "tb_isbn";
            this.tb_isbn.Size = new System.Drawing.Size(340, 38);
            this.tb_isbn.TabIndex = 0;
            this.tb_isbn.TextChanged += new System.EventHandler(this.tb_isbn_TextChanged);
            // 
            // bt_zustand
            // 
            this.bt_zustand.Location = new System.Drawing.Point(686, 264);
            this.bt_zustand.Name = "bt_zustand";
            this.bt_zustand.Size = new System.Drawing.Size(39, 39);
            this.bt_zustand.TabIndex = 18;
            this.bt_zustand.Text = "+";
            this.bt_zustand.UseVisualStyleBackColor = true;
            this.bt_zustand.Click += new System.EventHandler(this.bt_zustand_Click);
            // 
            // w_s_buchid
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1692, 827);
            this.Controls.Add(this.gB_buchid);
            this.Controls.Add(this.Grid_Buchid);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "w_s_buchid";
            this.Text = "w_s_buchid";
            this.Activated += new System.EventHandler(this.w_s_buchid_Activated);
            ((System.ComponentModel.ISupportInitialize)(this.Grid_Buchid)).EndInit();
            this.gB_buchid.ResumeLayout(false);
            this.gB_buchid.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView Grid_Buchid;
        private System.Windows.Forms.GroupBox gB_buchid;
        private System.Windows.Forms.Label lb_aufnahme;
        private System.Windows.Forms.Label lb_zustand;
        private System.Windows.Forms.Label lb_id;
        private System.Windows.Forms.Label lb_isbn;
        private System.Windows.Forms.TextBox tb_id;
        private System.Windows.Forms.TextBox tb_isbn;
        private System.Windows.Forms.DateTimePicker dTP_aufnahme;
        private System.Windows.Forms.ComboBox cb_zustand;
        private System.Windows.Forms.RadioButton rb_Delete;
        private System.Windows.Forms.RadioButton rb_Edit;
        private System.Windows.Forms.RadioButton rb_Neu;
        private System.Windows.Forms.Button bt;
        private System.Windows.Forms.Label lb;
        private System.Windows.Forms.Button bt_zustand;
    }
}