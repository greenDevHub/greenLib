namespace Bibo_Verwaltung
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
            this.gb_buecher = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.bt_clear_buecher = new System.Windows.Forms.Button();
            this.bt_speichern_buecher = new System.Windows.Forms.Button();
            this.dTP_Erscheinungsdatum = new System.Windows.Forms.DateTimePicker();
            this.lb_Erscheinungsdatum = new System.Windows.Forms.Label();
            this.tb_Auflage = new System.Windows.Forms.TextBox();
            this.lb_Auflage = new System.Windows.Forms.Label();
            this.bt_laden_buecher = new System.Windows.Forms.Button();
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
            ((System.ComponentModel.ISupportInitialize)(this.tsspracheBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.biboVerwaltungDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bibo_VerwaltungDataSet)).BeginInit();
            this.gb_buecher.SuspendLayout();
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
            // gb_buecher
            // 
            this.gb_buecher.Controls.Add(this.label1);
            this.gb_buecher.Controls.Add(this.bt_clear_buecher);
            this.gb_buecher.Controls.Add(this.bt_speichern_buecher);
            this.gb_buecher.Controls.Add(this.dTP_Erscheinungsdatum);
            this.gb_buecher.Controls.Add(this.lb_Erscheinungsdatum);
            this.gb_buecher.Controls.Add(this.tb_Auflage);
            this.gb_buecher.Controls.Add(this.lb_Auflage);
            this.gb_buecher.Controls.Add(this.bt_laden_buecher);
            this.gb_buecher.Controls.Add(this.lb_Neupreis_Euro);
            this.gb_buecher.Controls.Add(this.bt_Sprache_s);
            this.gb_buecher.Controls.Add(this.cb_Sprache);
            this.gb_buecher.Controls.Add(this.lb_Sprache);
            this.gb_buecher.Controls.Add(this.bt_Autor_s);
            this.gb_buecher.Controls.Add(this.cb_Autor);
            this.gb_buecher.Controls.Add(this.lb_Verlag);
            this.gb_buecher.Controls.Add(this.lb_Autor);
            this.gb_buecher.Controls.Add(this.bt_Verlag_s);
            this.gb_buecher.Controls.Add(this.bt_Genre_s);
            this.gb_buecher.Controls.Add(this.cb_Verlag);
            this.gb_buecher.Controls.Add(this.cb_Genre);
            this.gb_buecher.Controls.Add(this.lb_Genre);
            this.gb_buecher.Controls.Add(this.tb_Neupreis);
            this.gb_buecher.Controls.Add(this.lb_Neupreis);
            this.gb_buecher.Controls.Add(this.tb_Titel);
            this.gb_buecher.Controls.Add(this.lb_Titel);
            this.gb_buecher.Controls.Add(this.tb_ISBN);
            this.gb_buecher.Controls.Add(this.lb_ISBN);
            this.gb_buecher.Location = new System.Drawing.Point(12, 12);
            this.gb_buecher.Name = "gb_buecher";
            this.gb_buecher.Size = new System.Drawing.Size(355, 359);
            this.gb_buecher.TabIndex = 0;
            this.gb_buecher.TabStop = false;
            this.gb_buecher.Text = "Buecher";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(144, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 13);
            this.label1.TabIndex = 28;
            this.label1.Text = "ISBN-Form: 123-0123456789";
            // 
            // bt_clear_buecher
            // 
            this.bt_clear_buecher.Location = new System.Drawing.Point(116, 293);
            this.bt_clear_buecher.Name = "bt_clear_buecher";
            this.bt_clear_buecher.Size = new System.Drawing.Size(200, 37);
            this.bt_clear_buecher.TabIndex = 15;
            this.bt_clear_buecher.Text = "Clear";
            this.bt_clear_buecher.UseVisualStyleBackColor = true;
            this.bt_clear_buecher.Click += new System.EventHandler(this.bt_clear_buecher_Click);
            // 
            // bt_speichern_buecher
            // 
            this.bt_speichern_buecher.Location = new System.Drawing.Point(226, 253);
            this.bt_speichern_buecher.Margin = new System.Windows.Forms.Padding(1);
            this.bt_speichern_buecher.Name = "bt_speichern_buecher";
            this.bt_speichern_buecher.Size = new System.Drawing.Size(90, 33);
            this.bt_speichern_buecher.TabIndex = 14;
            this.bt_speichern_buecher.Text = "Speichern";
            this.bt_speichern_buecher.UseVisualStyleBackColor = true;
            this.bt_speichern_buecher.Click += new System.EventHandler(this.Save_Buecher);
            // 
            // dTP_Erscheinungsdatum
            // 
            this.dTP_Erscheinungsdatum.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dTP_Erscheinungsdatum.Location = new System.Drawing.Point(116, 229);
            this.dTP_Erscheinungsdatum.Name = "dTP_Erscheinungsdatum";
            this.dTP_Erscheinungsdatum.Size = new System.Drawing.Size(200, 20);
            this.dTP_Erscheinungsdatum.TabIndex = 12;
            // 
            // lb_Erscheinungsdatum
            // 
            this.lb_Erscheinungsdatum.AutoSize = true;
            this.lb_Erscheinungsdatum.Location = new System.Drawing.Point(7, 235);
            this.lb_Erscheinungsdatum.Name = "lb_Erscheinungsdatum";
            this.lb_Erscheinungsdatum.Size = new System.Drawing.Size(103, 13);
            this.lb_Erscheinungsdatum.TabIndex = 20;
            this.lb_Erscheinungsdatum.Text = "Erscheinungsdatum:";
            // 
            // tb_Auflage
            // 
            this.tb_Auflage.Location = new System.Drawing.Point(116, 177);
            this.tb_Auflage.Name = "tb_Auflage";
            this.tb_Auflage.Size = new System.Drawing.Size(200, 20);
            this.tb_Auflage.TabIndex = 10;
            // 
            // lb_Auflage
            // 
            this.lb_Auflage.AutoSize = true;
            this.lb_Auflage.Location = new System.Drawing.Point(7, 180);
            this.lb_Auflage.Name = "lb_Auflage";
            this.lb_Auflage.Size = new System.Drawing.Size(43, 13);
            this.lb_Auflage.TabIndex = 18;
            this.lb_Auflage.Text = "Auflage";
            // 
            // bt_laden_buecher
            // 
            this.bt_laden_buecher.Location = new System.Drawing.Point(116, 255);
            this.bt_laden_buecher.Name = "bt_laden_buecher";
            this.bt_laden_buecher.Size = new System.Drawing.Size(93, 31);
            this.bt_laden_buecher.TabIndex = 13;
            this.bt_laden_buecher.Text = "Laden";
            this.bt_laden_buecher.UseVisualStyleBackColor = true;
            this.bt_laden_buecher.Click += new System.EventHandler(this.Load_Buecher);
            // 
            // lb_Neupreis_Euro
            // 
            this.lb_Neupreis_Euro.AutoSize = true;
            this.lb_Neupreis_Euro.Location = new System.Drawing.Point(322, 206);
            this.lb_Neupreis_Euro.Name = "lb_Neupreis_Euro";
            this.lb_Neupreis_Euro.Size = new System.Drawing.Size(13, 13);
            this.lb_Neupreis_Euro.TabIndex = 1;
            this.lb_Neupreis_Euro.Text = "€";
            // 
            // bt_Sprache_s
            // 
            this.bt_Sprache_s.Location = new System.Drawing.Point(322, 150);
            this.bt_Sprache_s.Name = "bt_Sprache_s";
            this.bt_Sprache_s.Size = new System.Drawing.Size(22, 21);
            this.bt_Sprache_s.TabIndex = 9;
            this.bt_Sprache_s.Text = "s";
            this.bt_Sprache_s.UseVisualStyleBackColor = true;
            // 
            // cb_Sprache
            // 
            this.cb_Sprache.FormattingEnabled = true;
            this.cb_Sprache.Location = new System.Drawing.Point(116, 150);
            this.cb_Sprache.Name = "cb_Sprache";
            this.cb_Sprache.Size = new System.Drawing.Size(200, 21);
            this.cb_Sprache.TabIndex = 8;
            // 
            // lb_Sprache
            // 
            this.lb_Sprache.AutoSize = true;
            this.lb_Sprache.Location = new System.Drawing.Point(7, 153);
            this.lb_Sprache.Name = "lb_Sprache";
            this.lb_Sprache.Size = new System.Drawing.Size(50, 13);
            this.lb_Sprache.TabIndex = 14;
            this.lb_Sprache.Text = "Sprache:";
            // 
            // bt_Autor_s
            // 
            this.bt_Autor_s.Location = new System.Drawing.Point(322, 69);
            this.bt_Autor_s.Name = "bt_Autor_s";
            this.bt_Autor_s.Size = new System.Drawing.Size(22, 21);
            this.bt_Autor_s.TabIndex = 3;
            this.bt_Autor_s.Text = "s";
            this.bt_Autor_s.UseVisualStyleBackColor = true;
            this.bt_Autor_s.Click += new System.EventHandler(this.Search);
            // 
            // cb_Autor
            // 
            this.cb_Autor.FormattingEnabled = true;
            this.cb_Autor.Location = new System.Drawing.Point(116, 69);
            this.cb_Autor.Name = "cb_Autor";
            this.cb_Autor.Size = new System.Drawing.Size(200, 21);
            this.cb_Autor.TabIndex = 2;
            // 
            // lb_Verlag
            // 
            this.lb_Verlag.AutoSize = true;
            this.lb_Verlag.Location = new System.Drawing.Point(7, 99);
            this.lb_Verlag.Name = "lb_Verlag";
            this.lb_Verlag.Size = new System.Drawing.Size(40, 13);
            this.lb_Verlag.TabIndex = 10;
            this.lb_Verlag.Text = "Verlag:";
            // 
            // lb_Autor
            // 
            this.lb_Autor.AutoSize = true;
            this.lb_Autor.Location = new System.Drawing.Point(7, 72);
            this.lb_Autor.Name = "lb_Autor";
            this.lb_Autor.Size = new System.Drawing.Size(35, 13);
            this.lb_Autor.TabIndex = 8;
            this.lb_Autor.Text = "Autor:";
            // 
            // bt_Verlag_s
            // 
            this.bt_Verlag_s.Location = new System.Drawing.Point(322, 96);
            this.bt_Verlag_s.Name = "bt_Verlag_s";
            this.bt_Verlag_s.Size = new System.Drawing.Size(22, 21);
            this.bt_Verlag_s.TabIndex = 5;
            this.bt_Verlag_s.Text = "s";
            this.bt_Verlag_s.UseVisualStyleBackColor = true;
            this.bt_Verlag_s.Click += new System.EventHandler(this.Search);
            // 
            // bt_Genre_s
            // 
            this.bt_Genre_s.Location = new System.Drawing.Point(322, 123);
            this.bt_Genre_s.Name = "bt_Genre_s";
            this.bt_Genre_s.Size = new System.Drawing.Size(22, 21);
            this.bt_Genre_s.TabIndex = 7;
            this.bt_Genre_s.Text = "s";
            this.bt_Genre_s.UseVisualStyleBackColor = true;
            this.bt_Genre_s.Click += new System.EventHandler(this.bt_Genre_s_Click);
            // 
            // cb_Verlag
            // 
            this.cb_Verlag.FormattingEnabled = true;
            this.cb_Verlag.Location = new System.Drawing.Point(116, 96);
            this.cb_Verlag.Name = "cb_Verlag";
            this.cb_Verlag.Size = new System.Drawing.Size(200, 21);
            this.cb_Verlag.TabIndex = 4;
            // 
            // cb_Genre
            // 
            this.cb_Genre.FormattingEnabled = true;
            this.cb_Genre.Location = new System.Drawing.Point(116, 123);
            this.cb_Genre.Name = "cb_Genre";
            this.cb_Genre.Size = new System.Drawing.Size(200, 21);
            this.cb_Genre.TabIndex = 6;
            // 
            // lb_Genre
            // 
            this.lb_Genre.AutoSize = true;
            this.lb_Genre.Location = new System.Drawing.Point(7, 126);
            this.lb_Genre.Name = "lb_Genre";
            this.lb_Genre.Size = new System.Drawing.Size(39, 13);
            this.lb_Genre.TabIndex = 5;
            this.lb_Genre.Text = "Genre:";
            // 
            // tb_Neupreis
            // 
            this.tb_Neupreis.Location = new System.Drawing.Point(116, 203);
            this.tb_Neupreis.Name = "tb_Neupreis";
            this.tb_Neupreis.Size = new System.Drawing.Size(200, 20);
            this.tb_Neupreis.TabIndex = 11;
            this.tb_Neupreis.Validated += new System.EventHandler(this.tb_Neupreis_Validated);
            // 
            // lb_Neupreis
            // 
            this.lb_Neupreis.AutoSize = true;
            this.lb_Neupreis.Location = new System.Drawing.Point(7, 206);
            this.lb_Neupreis.Name = "lb_Neupreis";
            this.lb_Neupreis.Size = new System.Drawing.Size(52, 13);
            this.lb_Neupreis.TabIndex = 3;
            this.lb_Neupreis.Text = "Neupreis:";
            // 
            // tb_Titel
            // 
            this.tb_Titel.Location = new System.Drawing.Point(116, 43);
            this.tb_Titel.Name = "tb_Titel";
            this.tb_Titel.Size = new System.Drawing.Size(200, 20);
            this.tb_Titel.TabIndex = 1;
            this.tb_Titel.TextChanged += new System.EventHandler(this.tb_Titel_TextChanged);
            // 
            // lb_Titel
            // 
            this.lb_Titel.AutoSize = true;
            this.lb_Titel.Location = new System.Drawing.Point(7, 46);
            this.lb_Titel.Name = "lb_Titel";
            this.lb_Titel.Size = new System.Drawing.Size(30, 13);
            this.lb_Titel.TabIndex = 3;
            this.lb_Titel.Text = "Titel:";
            // 
            // tb_ISBN
            // 
            this.tb_ISBN.Location = new System.Drawing.Point(116, 17);
            this.tb_ISBN.Name = "tb_ISBN";
            this.tb_ISBN.Size = new System.Drawing.Size(200, 20);
            this.tb_ISBN.TabIndex = 0;
            this.tb_ISBN.TextChanged += new System.EventHandler(this.tb_ISBN_TextChanged);
            // 
            // lb_ISBN
            // 
            this.lb_ISBN.AutoSize = true;
            this.lb_ISBN.Location = new System.Drawing.Point(7, 20);
            this.lb_ISBN.Name = "lb_ISBN";
            this.lb_ISBN.Size = new System.Drawing.Size(35, 13);
            this.lb_ISBN.TabIndex = 1;
            this.lb_ISBN.Text = "ISBN:";
            // 
            // w_s_buecher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(385, 387);
            this.Controls.Add(this.gb_buecher);
            this.Name = "w_s_buecher";
            this.Text = "w_s_buecher";
            ((System.ComponentModel.ISupportInitialize)(this.tsspracheBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.biboVerwaltungDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bibo_VerwaltungDataSet)).EndInit();
            this.gb_buecher.ResumeLayout(false);
            this.gb_buecher.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource biboVerwaltungDataSetBindingSource;
        private Bibo_VerwaltungDataSet bibo_VerwaltungDataSet;
        private System.Windows.Forms.BindingSource tsspracheBindingSource;
        private Bibo_VerwaltungDataSetTableAdapters.t_s_spracheTableAdapter t_s_spracheTableAdapter;
        private System.Windows.Forms.GroupBox gb_buecher;
        private System.Windows.Forms.Button bt_speichern_buecher;
        private System.Windows.Forms.DateTimePicker dTP_Erscheinungsdatum;
        private System.Windows.Forms.Label lb_Erscheinungsdatum;
        private System.Windows.Forms.TextBox tb_Auflage;
        private System.Windows.Forms.Label lb_Auflage;
        private System.Windows.Forms.Button bt_laden_buecher;
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
    }
}