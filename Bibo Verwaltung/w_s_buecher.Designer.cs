﻿namespace Bibo_Verwaltung
{
    partial class w_s_buecher
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
            this.tsspracheBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.biboVerwaltungDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bibo_VerwaltungDataSet = new Bibo_Verwaltung.Bibo_VerwaltungDataSet();
            this.t_s_spracheTableAdapter = new Bibo_Verwaltung.Bibo_VerwaltungDataSetTableAdapters.t_s_spracheTableAdapter();
            this.gb_buch = new System.Windows.Forms.GroupBox();
            this.rb_Edit = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.bt_clear_buecher = new System.Windows.Forms.Button();
            this.rb_Neubuch = new System.Windows.Forms.RadioButton();
            this.bt_speichern_buecher = new System.Windows.Forms.Button();
            this.rb_Delete = new System.Windows.Forms.RadioButton();
            this.dTP_Erscheinungsdatum = new System.Windows.Forms.DateTimePicker();
            this.lb_Erscheinungsdatum = new System.Windows.Forms.Label();
            this.tb_Auflage = new System.Windows.Forms.TextBox();
            this.lb_Auflage = new System.Windows.Forms.Label();
            this.lb_Neupreis_Euro = new System.Windows.Forms.Label();
            this.bt_Sprache_s = new System.Windows.Forms.Button();
            this.cb_Sprache = new System.Windows.Forms.ComboBox();
            this.lb_Sprache = new System.Windows.Forms.Label();
            this.bt_Autor_s = new System.Windows.Forms.Button();
            this.cb_Autor = new System.Windows.Forms.ComboBox();
            this.lb_Verlag = new System.Windows.Forms.Label();
            this.lb_Autor = new System.Windows.Forms.Label();
            this.bt_Verlag_s = new System.Windows.Forms.Button();
            this.bt_Genre_s = new System.Windows.Forms.Button();
            this.cb_Verlag = new System.Windows.Forms.ComboBox();
            this.cb_Genre = new System.Windows.Forms.ComboBox();
            this.lb_Genre = new System.Windows.Forms.Label();
            this.tb_Neupreis = new System.Windows.Forms.TextBox();
            this.lb_Neupreis = new System.Windows.Forms.Label();
            this.tb_Titel = new System.Windows.Forms.TextBox();
            this.lb_Titel = new System.Windows.Forms.Label();
            this.tb_ISBN = new System.Windows.Forms.TextBox();
            this.lb_ISBN = new System.Windows.Forms.Label();
            this.Grid_Buch = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.tsspracheBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.biboVerwaltungDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bibo_VerwaltungDataSet)).BeginInit();
            this.gb_buch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Grid_Buch)).BeginInit();
            this.SuspendLayout();
            // 
            // tsspracheBindingSource
            // 
            this.tsspracheBindingSource.DataMember = "t_s_sprache";
            this.tsspracheBindingSource.DataSource = this.biboVerwaltungDataSetBindingSource;
            // 
            // biboVerwaltungDataSetBindingSource
            // 
            this.biboVerwaltungDataSetBindingSource.DataSource = this.bibo_VerwaltungDataSet;
            this.biboVerwaltungDataSetBindingSource.Position = 0;
            // 
            // bibo_VerwaltungDataSet
            // 
            this.bibo_VerwaltungDataSet.DataSetName = "Bibo_VerwaltungDataSet";
            this.bibo_VerwaltungDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // t_s_spracheTableAdapter
            // 
            this.t_s_spracheTableAdapter.ClearBeforeFill = true;
            // 
            // gb_buch
            // 
            this.gb_buch.Controls.Add(this.rb_Edit);
            this.gb_buch.Controls.Add(this.label1);
            this.gb_buch.Controls.Add(this.bt_clear_buecher);
            this.gb_buch.Controls.Add(this.rb_Neubuch);
            this.gb_buch.Controls.Add(this.bt_speichern_buecher);
            this.gb_buch.Controls.Add(this.rb_Delete);
            this.gb_buch.Controls.Add(this.dTP_Erscheinungsdatum);
            this.gb_buch.Controls.Add(this.lb_Erscheinungsdatum);
            this.gb_buch.Controls.Add(this.tb_Auflage);
            this.gb_buch.Controls.Add(this.lb_Auflage);
            this.gb_buch.Controls.Add(this.lb_Neupreis_Euro);
            this.gb_buch.Controls.Add(this.bt_Sprache_s);
            this.gb_buch.Controls.Add(this.cb_Sprache);
            this.gb_buch.Controls.Add(this.lb_Sprache);
            this.gb_buch.Controls.Add(this.bt_Autor_s);
            this.gb_buch.Controls.Add(this.cb_Autor);
            this.gb_buch.Controls.Add(this.lb_Verlag);
            this.gb_buch.Controls.Add(this.lb_Autor);
            this.gb_buch.Controls.Add(this.bt_Verlag_s);
            this.gb_buch.Controls.Add(this.bt_Genre_s);
            this.gb_buch.Controls.Add(this.cb_Verlag);
            this.gb_buch.Controls.Add(this.cb_Genre);
            this.gb_buch.Controls.Add(this.lb_Genre);
            this.gb_buch.Controls.Add(this.tb_Neupreis);
            this.gb_buch.Controls.Add(this.lb_Neupreis);
            this.gb_buch.Controls.Add(this.tb_Titel);
            this.gb_buch.Controls.Add(this.lb_Titel);
            this.gb_buch.Controls.Add(this.tb_ISBN);
            this.gb_buch.Controls.Add(this.lb_ISBN);
            this.gb_buch.Location = new System.Drawing.Point(20, 15);
            this.gb_buch.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gb_buch.Name = "gb_buch";
            this.gb_buch.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gb_buch.Size = new System.Drawing.Size(474, 442);
            this.gb_buch.TabIndex = 0;
            this.gb_buch.TabStop = false;
            this.gb_buch.Text = "Buecher";
            // 
            // rb_Edit
            // 
            this.rb_Edit.AutoSize = true;
            this.rb_Edit.Location = new System.Drawing.Point(193, 28);
            this.rb_Edit.Name = "rb_Edit";
            this.rb_Edit.Size = new System.Drawing.Size(134, 21);
            this.rb_Edit.TabIndex = 43;
            this.rb_Edit.Text = "Buch Bearbeiten";
            this.rb_Edit.UseVisualStyleBackColor = true;
            this.rb_Edit.CheckedChanged += new System.EventHandler(this.rb_Edit_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(172, 50);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(193, 17);
            this.label1.TabIndex = 28;
            this.label1.Text = "ISBN-Form: 123-0123456789";
            // 
            // bt_clear_buecher
            // 
            this.bt_clear_buecher.Location = new System.Drawing.Point(295, 364);
            this.bt_clear_buecher.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bt_clear_buecher.Name = "bt_clear_buecher";
            this.bt_clear_buecher.Size = new System.Drawing.Size(120, 41);
            this.bt_clear_buecher.TabIndex = 15;
            this.bt_clear_buecher.Text = "Clear";
            this.bt_clear_buecher.UseVisualStyleBackColor = true;
            this.bt_clear_buecher.Click += new System.EventHandler(this.bt_clear_buecher_Click);
            // 
            // rb_Neubuch
            // 
            this.rb_Neubuch.AutoSize = true;
            this.rb_Neubuch.Checked = true;
            this.rb_Neubuch.Location = new System.Drawing.Point(10, 28);
            this.rb_Neubuch.Name = "rb_Neubuch";
            this.rb_Neubuch.Size = new System.Drawing.Size(180, 21);
            this.rb_Neubuch.TabIndex = 41;
            this.rb_Neubuch.TabStop = true;
            this.rb_Neubuch.Text = "Neues Buch hinzufügen";
            this.rb_Neubuch.UseVisualStyleBackColor = true;
            this.rb_Neubuch.CheckedChanged += new System.EventHandler(this.rb_Neubuch_CheckedChanged);
            // 
            // bt_speichern_buecher
            // 
            this.bt_speichern_buecher.Location = new System.Drawing.Point(151, 364);
            this.bt_speichern_buecher.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.bt_speichern_buecher.Name = "bt_speichern_buecher";
            this.bt_speichern_buecher.Size = new System.Drawing.Size(120, 41);
            this.bt_speichern_buecher.TabIndex = 14;
            this.bt_speichern_buecher.Text = "Speichern";
            this.bt_speichern_buecher.UseVisualStyleBackColor = true;
            this.bt_speichern_buecher.Click += new System.EventHandler(this.Save_Buecher);
            // 
            // rb_Delete
            // 
            this.rb_Delete.AutoSize = true;
            this.rb_Delete.Location = new System.Drawing.Point(325, 28);
            this.rb_Delete.Name = "rb_Delete";
            this.rb_Delete.Size = new System.Drawing.Size(127, 21);
            this.rb_Delete.TabIndex = 42;
            this.rb_Delete.Text = "Buch Entfernen";
            this.rb_Delete.UseVisualStyleBackColor = true;
            this.rb_Delete.CheckedChanged += new System.EventHandler(this.rb_Delete_CheckedChanged);
            // 
            // dTP_Erscheinungsdatum
            // 
            this.dTP_Erscheinungsdatum.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dTP_Erscheinungsdatum.Location = new System.Drawing.Point(151, 331);
            this.dTP_Erscheinungsdatum.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dTP_Erscheinungsdatum.Name = "dTP_Erscheinungsdatum";
            this.dTP_Erscheinungsdatum.Size = new System.Drawing.Size(266, 22);
            this.dTP_Erscheinungsdatum.TabIndex = 12;
            // 
            // lb_Erscheinungsdatum
            // 
            this.lb_Erscheinungsdatum.AutoSize = true;
            this.lb_Erscheinungsdatum.Location = new System.Drawing.Point(7, 339);
            this.lb_Erscheinungsdatum.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_Erscheinungsdatum.Name = "lb_Erscheinungsdatum";
            this.lb_Erscheinungsdatum.Size = new System.Drawing.Size(137, 17);
            this.lb_Erscheinungsdatum.TabIndex = 20;
            this.lb_Erscheinungsdatum.Text = "Erscheinungsdatum:";
            // 
            // tb_Auflage
            // 
            this.tb_Auflage.Location = new System.Drawing.Point(151, 267);
            this.tb_Auflage.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tb_Auflage.Name = "tb_Auflage";
            this.tb_Auflage.Size = new System.Drawing.Size(266, 22);
            this.tb_Auflage.TabIndex = 10;
            // 
            // lb_Auflage
            // 
            this.lb_Auflage.AutoSize = true;
            this.lb_Auflage.Location = new System.Drawing.Point(7, 270);
            this.lb_Auflage.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_Auflage.Name = "lb_Auflage";
            this.lb_Auflage.Size = new System.Drawing.Size(56, 17);
            this.lb_Auflage.TabIndex = 18;
            this.lb_Auflage.Text = "Auflage";
            // 
            // lb_Neupreis_Euro
            // 
            this.lb_Neupreis_Euro.AutoSize = true;
            this.lb_Neupreis_Euro.Location = new System.Drawing.Point(427, 302);
            this.lb_Neupreis_Euro.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_Neupreis_Euro.Name = "lb_Neupreis_Euro";
            this.lb_Neupreis_Euro.Size = new System.Drawing.Size(16, 17);
            this.lb_Neupreis_Euro.TabIndex = 1;
            this.lb_Neupreis_Euro.Text = "€";
            // 
            // bt_Sprache_s
            // 
            this.bt_Sprache_s.Location = new System.Drawing.Point(427, 234);
            this.bt_Sprache_s.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bt_Sprache_s.Name = "bt_Sprache_s";
            this.bt_Sprache_s.Size = new System.Drawing.Size(30, 26);
            this.bt_Sprache_s.TabIndex = 9;
            this.bt_Sprache_s.Text = "+";
            this.bt_Sprache_s.UseVisualStyleBackColor = true;
            this.bt_Sprache_s.Click += new System.EventHandler(this.bt_Sprache_s_Click_1);
            // 
            // cb_Sprache
            // 
            this.cb_Sprache.FormattingEnabled = true;
            this.cb_Sprache.Location = new System.Drawing.Point(151, 234);
            this.cb_Sprache.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cb_Sprache.Name = "cb_Sprache";
            this.cb_Sprache.Size = new System.Drawing.Size(266, 24);
            this.cb_Sprache.TabIndex = 8;
            // 
            // lb_Sprache
            // 
            this.lb_Sprache.AutoSize = true;
            this.lb_Sprache.Location = new System.Drawing.Point(7, 237);
            this.lb_Sprache.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_Sprache.Name = "lb_Sprache";
            this.lb_Sprache.Size = new System.Drawing.Size(65, 17);
            this.lb_Sprache.TabIndex = 14;
            this.lb_Sprache.Text = "Sprache:";
            // 
            // bt_Autor_s
            // 
            this.bt_Autor_s.Location = new System.Drawing.Point(427, 135);
            this.bt_Autor_s.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bt_Autor_s.Name = "bt_Autor_s";
            this.bt_Autor_s.Size = new System.Drawing.Size(30, 26);
            this.bt_Autor_s.TabIndex = 3;
            this.bt_Autor_s.Text = "+";
            this.bt_Autor_s.UseVisualStyleBackColor = true;
            this.bt_Autor_s.Click += new System.EventHandler(this.bt_Autor_s_Click);
            // 
            // cb_Autor
            // 
            this.cb_Autor.FormattingEnabled = true;
            this.cb_Autor.Location = new System.Drawing.Point(151, 135);
            this.cb_Autor.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cb_Autor.Name = "cb_Autor";
            this.cb_Autor.Size = new System.Drawing.Size(266, 24);
            this.cb_Autor.TabIndex = 2;
            // 
            // lb_Verlag
            // 
            this.lb_Verlag.AutoSize = true;
            this.lb_Verlag.Location = new System.Drawing.Point(7, 171);
            this.lb_Verlag.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_Verlag.Name = "lb_Verlag";
            this.lb_Verlag.Size = new System.Drawing.Size(53, 17);
            this.lb_Verlag.TabIndex = 10;
            this.lb_Verlag.Text = "Verlag:";
            // 
            // lb_Autor
            // 
            this.lb_Autor.AutoSize = true;
            this.lb_Autor.Location = new System.Drawing.Point(7, 138);
            this.lb_Autor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_Autor.Name = "lb_Autor";
            this.lb_Autor.Size = new System.Drawing.Size(46, 17);
            this.lb_Autor.TabIndex = 8;
            this.lb_Autor.Text = "Autor:";
            // 
            // bt_Verlag_s
            // 
            this.bt_Verlag_s.Location = new System.Drawing.Point(427, 168);
            this.bt_Verlag_s.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bt_Verlag_s.Name = "bt_Verlag_s";
            this.bt_Verlag_s.Size = new System.Drawing.Size(30, 26);
            this.bt_Verlag_s.TabIndex = 5;
            this.bt_Verlag_s.Text = "+";
            this.bt_Verlag_s.UseVisualStyleBackColor = true;
            this.bt_Verlag_s.Click += new System.EventHandler(this.bt_Verlag_s_Click);
            // 
            // bt_Genre_s
            // 
            this.bt_Genre_s.Location = new System.Drawing.Point(427, 201);
            this.bt_Genre_s.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bt_Genre_s.Name = "bt_Genre_s";
            this.bt_Genre_s.Size = new System.Drawing.Size(30, 26);
            this.bt_Genre_s.TabIndex = 7;
            this.bt_Genre_s.Text = "+";
            this.bt_Genre_s.UseVisualStyleBackColor = true;
            this.bt_Genre_s.Click += new System.EventHandler(this.bt_Genre_s_Click);
            // 
            // cb_Verlag
            // 
            this.cb_Verlag.FormattingEnabled = true;
            this.cb_Verlag.Location = new System.Drawing.Point(151, 168);
            this.cb_Verlag.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cb_Verlag.Name = "cb_Verlag";
            this.cb_Verlag.Size = new System.Drawing.Size(266, 24);
            this.cb_Verlag.TabIndex = 4;
            // 
            // cb_Genre
            // 
            this.cb_Genre.FormattingEnabled = true;
            this.cb_Genre.Location = new System.Drawing.Point(151, 201);
            this.cb_Genre.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cb_Genre.Name = "cb_Genre";
            this.cb_Genre.Size = new System.Drawing.Size(266, 24);
            this.cb_Genre.TabIndex = 6;
            // 
            // lb_Genre
            // 
            this.lb_Genre.AutoSize = true;
            this.lb_Genre.Location = new System.Drawing.Point(7, 204);
            this.lb_Genre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_Genre.Name = "lb_Genre";
            this.lb_Genre.Size = new System.Drawing.Size(52, 17);
            this.lb_Genre.TabIndex = 5;
            this.lb_Genre.Text = "Genre:";
            // 
            // tb_Neupreis
            // 
            this.tb_Neupreis.Location = new System.Drawing.Point(151, 299);
            this.tb_Neupreis.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tb_Neupreis.Name = "tb_Neupreis";
            this.tb_Neupreis.Size = new System.Drawing.Size(266, 22);
            this.tb_Neupreis.TabIndex = 11;
            this.tb_Neupreis.Validated += new System.EventHandler(this.tb_Neupreis_Validated);
            // 
            // lb_Neupreis
            // 
            this.lb_Neupreis.AutoSize = true;
            this.lb_Neupreis.Location = new System.Drawing.Point(7, 302);
            this.lb_Neupreis.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_Neupreis.Name = "lb_Neupreis";
            this.lb_Neupreis.Size = new System.Drawing.Size(69, 17);
            this.lb_Neupreis.TabIndex = 3;
            this.lb_Neupreis.Text = "Neupreis:";
            // 
            // tb_Titel
            // 
            this.tb_Titel.Location = new System.Drawing.Point(151, 103);
            this.tb_Titel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tb_Titel.Name = "tb_Titel";
            this.tb_Titel.Size = new System.Drawing.Size(266, 22);
            this.tb_Titel.TabIndex = 1;
            this.tb_Titel.TextChanged += new System.EventHandler(this.tb_Titel_TextChanged);
            // 
            // lb_Titel
            // 
            this.lb_Titel.AutoSize = true;
            this.lb_Titel.Location = new System.Drawing.Point(7, 106);
            this.lb_Titel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_Titel.Name = "lb_Titel";
            this.lb_Titel.Size = new System.Drawing.Size(39, 17);
            this.lb_Titel.TabIndex = 3;
            this.lb_Titel.Text = "Titel:";
            // 
            // tb_ISBN
            // 
            this.tb_ISBN.Location = new System.Drawing.Point(151, 71);
            this.tb_ISBN.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tb_ISBN.Name = "tb_ISBN";
            this.tb_ISBN.Size = new System.Drawing.Size(266, 22);
            this.tb_ISBN.TabIndex = 0;
            this.tb_ISBN.TextChanged += new System.EventHandler(this.tb_ISBN_TextChanged);
            // 
            // lb_ISBN
            // 
            this.lb_ISBN.AutoSize = true;
            this.lb_ISBN.Location = new System.Drawing.Point(7, 74);
            this.lb_ISBN.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_ISBN.Name = "lb_ISBN";
            this.lb_ISBN.Size = new System.Drawing.Size(43, 17);
            this.lb_ISBN.TabIndex = 1;
            this.lb_ISBN.Text = "ISBN:";
            // 
            // Grid_Buch
            // 
            this.Grid_Buch.AllowUserToAddRows = false;
            this.Grid_Buch.AllowUserToDeleteRows = false;
            this.Grid_Buch.AllowUserToResizeColumns = false;
            this.Grid_Buch.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Grid_Buch.Location = new System.Drawing.Point(506, 15);
            this.Grid_Buch.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Grid_Buch.Name = "Grid_Buch";
            this.Grid_Buch.ReadOnly = true;
            this.Grid_Buch.RowTemplate.Height = 40;
            this.Grid_Buch.Size = new System.Drawing.Size(370, 442);
            this.Grid_Buch.TabIndex = 0;
            this.Grid_Buch.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Grid_Buch_CellDoubleClick);
            // 
            // w_s_buecher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(935, 476);
            this.Controls.Add(this.Grid_Buch);
            this.Controls.Add(this.gb_buch);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "w_s_buecher";
            this.Text = "w_s_buecher";
            this.Activated += new System.EventHandler(this.w_s_buecher_Activated);
            ((System.ComponentModel.ISupportInitialize)(this.tsspracheBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.biboVerwaltungDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bibo_VerwaltungDataSet)).EndInit();
            this.gb_buch.ResumeLayout(false);
            this.gb_buch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Grid_Buch)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource biboVerwaltungDataSetBindingSource;
        private Bibo_VerwaltungDataSet bibo_VerwaltungDataSet;
        private System.Windows.Forms.BindingSource tsspracheBindingSource;
        private Bibo_VerwaltungDataSetTableAdapters.t_s_spracheTableAdapter t_s_spracheTableAdapter;
        private System.Windows.Forms.GroupBox gb_buch;
        private System.Windows.Forms.Button bt_speichern_buecher;
        private System.Windows.Forms.DateTimePicker dTP_Erscheinungsdatum;
        private System.Windows.Forms.Label lb_Erscheinungsdatum;
        private System.Windows.Forms.TextBox tb_Auflage;
        private System.Windows.Forms.Label lb_Auflage;
        private System.Windows.Forms.Label lb_Neupreis_Euro;
        private System.Windows.Forms.Button bt_Sprache_s;
        private System.Windows.Forms.ComboBox cb_Sprache;
        private System.Windows.Forms.Label lb_Sprache;
        private System.Windows.Forms.Button bt_Autor_s;
        private System.Windows.Forms.ComboBox cb_Autor;
        private System.Windows.Forms.Label lb_Verlag;
        private System.Windows.Forms.Label lb_Autor;
        private System.Windows.Forms.Button bt_Verlag_s;
        private System.Windows.Forms.Button bt_Genre_s;
        private System.Windows.Forms.ComboBox cb_Verlag;
        private System.Windows.Forms.ComboBox cb_Genre;
        private System.Windows.Forms.Label lb_Genre;
        private System.Windows.Forms.TextBox tb_Neupreis;
        private System.Windows.Forms.Label lb_Neupreis;
        private System.Windows.Forms.TextBox tb_Titel;
        private System.Windows.Forms.Label lb_Titel;
        private System.Windows.Forms.TextBox tb_ISBN;
        private System.Windows.Forms.Label lb_ISBN;
        private System.Windows.Forms.Button bt_clear_buecher;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView Grid_Buch;
        private System.Windows.Forms.RadioButton rb_Neubuch;
        private System.Windows.Forms.RadioButton rb_Edit;
        private System.Windows.Forms.RadioButton rb_Delete;
    }
}