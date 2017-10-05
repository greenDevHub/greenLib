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
            this.gb_buch = new System.Windows.Forms.GroupBox();
            this.bt_pic_delete = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.bt_picture = new System.Windows.Forms.Button();
            this.lb_isbn_vorlage = new System.Windows.Forms.Label();
            this.rb_Update_Buch = new System.Windows.Forms.RadioButton();
            this.bt_clear_buecher = new System.Windows.Forms.Button();
            this.rb_Add_Buch = new System.Windows.Forms.RadioButton();
            this.cb_Autor = new System.Windows.Forms.ComboBox();
            this.bt_speichern_buecher = new System.Windows.Forms.Button();
            this.rb_Delete_Buch = new System.Windows.Forms.RadioButton();
            this.dTP_Erscheinungsdatum = new System.Windows.Forms.DateTimePicker();
            this.lb_Erscheinungsdatum = new System.Windows.Forms.Label();
            this.tb_Auflage = new System.Windows.Forms.TextBox();
            this.lb_Auflage = new System.Windows.Forms.Label();
            this.lb_Neupreis_Euro = new System.Windows.Forms.Label();
            this.bt_Sprache_s = new System.Windows.Forms.Button();
            this.cb_Sprache = new System.Windows.Forms.ComboBox();
            this.lb_Sprache = new System.Windows.Forms.Label();
            this.bt_Autor_s = new System.Windows.Forms.Button();
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
            this.bt_Schliessen = new System.Windows.Forms.Button();
            this.bt_Excel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.tsspracheBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.biboVerwaltungDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bibo_VerwaltungDataSet)).BeginInit();
            this.gb_buch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
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
            this.gb_buch.Controls.Add(this.bt_pic_delete);
            this.gb_buch.Controls.Add(this.pictureBox1);
            this.gb_buch.Controls.Add(this.bt_picture);
            this.gb_buch.Controls.Add(this.lb_isbn_vorlage);
            this.gb_buch.Controls.Add(this.rb_Update_Buch);
            this.gb_buch.Controls.Add(this.bt_clear_buecher);
            this.gb_buch.Controls.Add(this.rb_Add_Buch);
            this.gb_buch.Controls.Add(this.cb_Autor);
            this.gb_buch.Controls.Add(this.bt_speichern_buecher);
            this.gb_buch.Controls.Add(this.rb_Delete_Buch);
            this.gb_buch.Controls.Add(this.dTP_Erscheinungsdatum);
            this.gb_buch.Controls.Add(this.lb_Erscheinungsdatum);
            this.gb_buch.Controls.Add(this.tb_Auflage);
            this.gb_buch.Controls.Add(this.lb_Auflage);
            this.gb_buch.Controls.Add(this.lb_Neupreis_Euro);
            this.gb_buch.Controls.Add(this.bt_Sprache_s);
            this.gb_buch.Controls.Add(this.cb_Sprache);
            this.gb_buch.Controls.Add(this.lb_Sprache);
            this.gb_buch.Controls.Add(this.bt_Autor_s);
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
            this.gb_buch.Location = new System.Drawing.Point(6, 13);
            this.gb_buch.Name = "gb_buch";
            this.gb_buch.Size = new System.Drawing.Size(297, 426);
            this.gb_buch.TabIndex = 0;
            this.gb_buch.TabStop = false;
            this.gb_buch.Text = "Bücher";
            // 
            // bt_pic_delete
            // 
            this.bt_pic_delete.Location = new System.Drawing.Point(3, 306);
            this.bt_pic_delete.Name = "bt_pic_delete";
            this.bt_pic_delete.Size = new System.Drawing.Size(106, 24);
            this.bt_pic_delete.TabIndex = 47;
            this.bt_pic_delete.Text = "Bild entfernen";
            this.bt_pic_delete.UseVisualStyleBackColor = true;
            this.bt_pic_delete.Click += new System.EventHandler(this.bt_pic_add_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(113, 275);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(158, 115);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 46;
            this.pictureBox1.TabStop = false;
            // 
            // bt_picture
            // 
            this.bt_picture.Location = new System.Drawing.Point(4, 275);
            this.bt_picture.Name = "bt_picture";
            this.bt_picture.Size = new System.Drawing.Size(105, 24);
            this.bt_picture.TabIndex = 45;
            this.bt_picture.Text = "Bild auswählen";
            this.bt_picture.UseVisualStyleBackColor = true;
            this.bt_picture.Click += new System.EventHandler(this.bt_picture_Click);
            // 
            // lb_isbn_vorlage
            // 
            this.lb_isbn_vorlage.AutoSize = true;
            this.lb_isbn_vorlage.BackColor = System.Drawing.SystemColors.Window;
            this.lb_isbn_vorlage.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.lb_isbn_vorlage.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_isbn_vorlage.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.lb_isbn_vorlage.Location = new System.Drawing.Point(114, 62);
            this.lb_isbn_vorlage.Margin = new System.Windows.Forms.Padding(0);
            this.lb_isbn_vorlage.Name = "lb_isbn_vorlage";
            this.lb_isbn_vorlage.Size = new System.Drawing.Size(88, 13);
            this.lb_isbn_vorlage.TabIndex = 44;
            this.lb_isbn_vorlage.Text = "123-0123456789";
            this.lb_isbn_vorlage.Click += new System.EventHandler(this.lb_isbn_vorlage_Click);
            // 
            // rb_Update_Buch
            // 
            this.rb_Update_Buch.AutoSize = true;
            this.rb_Update_Buch.Location = new System.Drawing.Point(106, 19);
            this.rb_Update_Buch.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.rb_Update_Buch.Name = "rb_Update_Buch";
            this.rb_Update_Buch.Size = new System.Drawing.Size(76, 17);
            this.rb_Update_Buch.TabIndex = 43;
            this.rb_Update_Buch.Text = "Bearbeiten";
            this.rb_Update_Buch.UseVisualStyleBackColor = true;
            this.rb_Update_Buch.CheckedChanged += new System.EventHandler(this.rb_Edit_CheckedChanged);
            // 
            // bt_clear_buecher
            // 
            this.bt_clear_buecher.Location = new System.Drawing.Point(199, 395);
            this.bt_clear_buecher.Name = "bt_clear_buecher";
            this.bt_clear_buecher.Size = new System.Drawing.Size(72, 24);
            this.bt_clear_buecher.TabIndex = 15;
            this.bt_clear_buecher.Text = "Leeren";
            this.bt_clear_buecher.UseVisualStyleBackColor = true;
            this.bt_clear_buecher.Click += new System.EventHandler(this.bt_clear_buecher_Click);
            // 
            // rb_Add_Buch
            // 
            this.rb_Add_Buch.AutoSize = true;
            this.rb_Add_Buch.Checked = true;
            this.rb_Add_Buch.Location = new System.Drawing.Point(6, 19);
            this.rb_Add_Buch.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.rb_Add_Buch.Name = "rb_Add_Buch";
            this.rb_Add_Buch.Size = new System.Drawing.Size(79, 17);
            this.rb_Add_Buch.TabIndex = 41;
            this.rb_Add_Buch.TabStop = true;
            this.rb_Add_Buch.Text = "Hinzufügen";
            this.rb_Add_Buch.UseVisualStyleBackColor = true;
            this.rb_Add_Buch.CheckedChanged += new System.EventHandler(this.rb_Neubuch_CheckedChanged);
            // 
            // cb_Autor
            // 
            this.cb_Autor.FormattingEnabled = true;
            this.cb_Autor.Location = new System.Drawing.Point(113, 110);
            this.cb_Autor.Name = "cb_Autor";
            this.cb_Autor.Size = new System.Drawing.Size(158, 21);
            this.cb_Autor.TabIndex = 2;
            this.cb_Autor.TextChanged += new System.EventHandler(this.cb_Autor_TextChanged);
            // 
            // bt_speichern_buecher
            // 
            this.bt_speichern_buecher.Location = new System.Drawing.Point(113, 395);
            this.bt_speichern_buecher.Name = "bt_speichern_buecher";
            this.bt_speichern_buecher.Size = new System.Drawing.Size(72, 24);
            this.bt_speichern_buecher.TabIndex = 14;
            this.bt_speichern_buecher.Text = "Speichern";
            this.bt_speichern_buecher.UseVisualStyleBackColor = true;
            this.bt_speichern_buecher.Click += new System.EventHandler(this.Save_Buecher);
            // 
            // rb_Delete_Buch
            // 
            this.rb_Delete_Buch.AutoSize = true;
            this.rb_Delete_Buch.Location = new System.Drawing.Point(206, 19);
            this.rb_Delete_Buch.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.rb_Delete_Buch.Name = "rb_Delete_Buch";
            this.rb_Delete_Buch.Size = new System.Drawing.Size(71, 17);
            this.rb_Delete_Buch.TabIndex = 42;
            this.rb_Delete_Buch.Text = "Entfernen";
            this.rb_Delete_Buch.UseVisualStyleBackColor = true;
            this.rb_Delete_Buch.CheckedChanged += new System.EventHandler(this.rb_Delete_CheckedChanged);
            // 
            // dTP_Erscheinungsdatum
            // 
            this.dTP_Erscheinungsdatum.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dTP_Erscheinungsdatum.Location = new System.Drawing.Point(113, 250);
            this.dTP_Erscheinungsdatum.Name = "dTP_Erscheinungsdatum";
            this.dTP_Erscheinungsdatum.Size = new System.Drawing.Size(158, 20);
            this.dTP_Erscheinungsdatum.TabIndex = 12;
            // 
            // lb_Erscheinungsdatum
            // 
            this.lb_Erscheinungsdatum.AutoSize = true;
            this.lb_Erscheinungsdatum.Location = new System.Drawing.Point(6, 253);
            this.lb_Erscheinungsdatum.Name = "lb_Erscheinungsdatum";
            this.lb_Erscheinungsdatum.Size = new System.Drawing.Size(103, 13);
            this.lb_Erscheinungsdatum.TabIndex = 20;
            this.lb_Erscheinungsdatum.Text = "Erscheinungsdatum:";
            // 
            // tb_Auflage
            // 
            this.tb_Auflage.Location = new System.Drawing.Point(113, 205);
            this.tb_Auflage.Name = "tb_Auflage";
            this.tb_Auflage.Size = new System.Drawing.Size(158, 20);
            this.tb_Auflage.TabIndex = 10;
            this.tb_Auflage.TextChanged += new System.EventHandler(this.tb_Auflage_TextChanged);
            // 
            // lb_Auflage
            // 
            this.lb_Auflage.AutoSize = true;
            this.lb_Auflage.Location = new System.Drawing.Point(6, 206);
            this.lb_Auflage.Name = "lb_Auflage";
            this.lb_Auflage.Size = new System.Drawing.Size(43, 13);
            this.lb_Auflage.TabIndex = 18;
            this.lb_Auflage.Text = "Auflage";
            // 
            // lb_Neupreis_Euro
            // 
            this.lb_Neupreis_Euro.AutoSize = true;
            this.lb_Neupreis_Euro.Location = new System.Drawing.Point(277, 230);
            this.lb_Neupreis_Euro.Name = "lb_Neupreis_Euro";
            this.lb_Neupreis_Euro.Size = new System.Drawing.Size(13, 13);
            this.lb_Neupreis_Euro.TabIndex = 1;
            this.lb_Neupreis_Euro.Text = "€";
            // 
            // bt_Sprache_s
            // 
            this.bt_Sprache_s.Location = new System.Drawing.Point(277, 185);
            this.bt_Sprache_s.Name = "bt_Sprache_s";
            this.bt_Sprache_s.Size = new System.Drawing.Size(15, 16);
            this.bt_Sprache_s.TabIndex = 9;
            this.bt_Sprache_s.Text = "+";
            this.bt_Sprache_s.UseVisualStyleBackColor = true;
            this.bt_Sprache_s.Click += new System.EventHandler(this.bt_Sprache_s_Click_1);
            // 
            // cb_Sprache
            // 
            this.cb_Sprache.FormattingEnabled = true;
            this.cb_Sprache.Location = new System.Drawing.Point(113, 182);
            this.cb_Sprache.Name = "cb_Sprache";
            this.cb_Sprache.Size = new System.Drawing.Size(158, 21);
            this.cb_Sprache.TabIndex = 8;
            this.cb_Sprache.TextChanged += new System.EventHandler(this.cb_Sprache_TextChanged);
            // 
            // lb_Sprache
            // 
            this.lb_Sprache.AutoSize = true;
            this.lb_Sprache.Location = new System.Drawing.Point(6, 184);
            this.lb_Sprache.Name = "lb_Sprache";
            this.lb_Sprache.Size = new System.Drawing.Size(50, 13);
            this.lb_Sprache.TabIndex = 14;
            this.lb_Sprache.Text = "Sprache:";
            // 
            // bt_Autor_s
            // 
            this.bt_Autor_s.Location = new System.Drawing.Point(277, 114);
            this.bt_Autor_s.Name = "bt_Autor_s";
            this.bt_Autor_s.Size = new System.Drawing.Size(15, 16);
            this.bt_Autor_s.TabIndex = 3;
            this.bt_Autor_s.Text = "+";
            this.bt_Autor_s.UseVisualStyleBackColor = true;
            this.bt_Autor_s.Click += new System.EventHandler(this.bt_Autor_s_Click);
            // 
            // lb_Verlag
            // 
            this.lb_Verlag.AutoSize = true;
            this.lb_Verlag.Location = new System.Drawing.Point(6, 137);
            this.lb_Verlag.Name = "lb_Verlag";
            this.lb_Verlag.Size = new System.Drawing.Size(40, 13);
            this.lb_Verlag.TabIndex = 10;
            this.lb_Verlag.Text = "Verlag:";
            // 
            // lb_Autor
            // 
            this.lb_Autor.AutoSize = true;
            this.lb_Autor.Location = new System.Drawing.Point(6, 112);
            this.lb_Autor.Name = "lb_Autor";
            this.lb_Autor.Size = new System.Drawing.Size(35, 13);
            this.lb_Autor.TabIndex = 8;
            this.lb_Autor.Text = "Autor:";
            // 
            // bt_Verlag_s
            // 
            this.bt_Verlag_s.Location = new System.Drawing.Point(277, 139);
            this.bt_Verlag_s.Name = "bt_Verlag_s";
            this.bt_Verlag_s.Size = new System.Drawing.Size(15, 16);
            this.bt_Verlag_s.TabIndex = 5;
            this.bt_Verlag_s.Text = "+";
            this.bt_Verlag_s.UseVisualStyleBackColor = true;
            this.bt_Verlag_s.Click += new System.EventHandler(this.bt_Verlag_s_Click);
            // 
            // bt_Genre_s
            // 
            this.bt_Genre_s.Location = new System.Drawing.Point(277, 162);
            this.bt_Genre_s.Name = "bt_Genre_s";
            this.bt_Genre_s.Size = new System.Drawing.Size(15, 16);
            this.bt_Genre_s.TabIndex = 7;
            this.bt_Genre_s.Text = "+";
            this.bt_Genre_s.UseVisualStyleBackColor = true;
            this.bt_Genre_s.Click += new System.EventHandler(this.bt_Genre_s_Click);
            // 
            // cb_Verlag
            // 
            this.cb_Verlag.FormattingEnabled = true;
            this.cb_Verlag.Location = new System.Drawing.Point(113, 136);
            this.cb_Verlag.Name = "cb_Verlag";
            this.cb_Verlag.Size = new System.Drawing.Size(158, 21);
            this.cb_Verlag.TabIndex = 4;
            this.cb_Verlag.TextChanged += new System.EventHandler(this.cb_Verlag_TextChanged);
            // 
            // cb_Genre
            // 
            this.cb_Genre.FormattingEnabled = true;
            this.cb_Genre.Location = new System.Drawing.Point(113, 159);
            this.cb_Genre.Name = "cb_Genre";
            this.cb_Genre.Size = new System.Drawing.Size(158, 21);
            this.cb_Genre.TabIndex = 6;
            this.cb_Genre.TextChanged += new System.EventHandler(this.cb_Genre_TextChanged);
            // 
            // lb_Genre
            // 
            this.lb_Genre.AutoSize = true;
            this.lb_Genre.Location = new System.Drawing.Point(6, 160);
            this.lb_Genre.Name = "lb_Genre";
            this.lb_Genre.Size = new System.Drawing.Size(39, 13);
            this.lb_Genre.TabIndex = 5;
            this.lb_Genre.Text = "Genre:";
            // 
            // tb_Neupreis
            // 
            this.tb_Neupreis.Location = new System.Drawing.Point(113, 228);
            this.tb_Neupreis.Name = "tb_Neupreis";
            this.tb_Neupreis.Size = new System.Drawing.Size(158, 20);
            this.tb_Neupreis.TabIndex = 11;
            this.tb_Neupreis.TextChanged += new System.EventHandler(this.tb_Neupreis_TextChanged);
            this.tb_Neupreis.Validated += new System.EventHandler(this.tb_Neupreis_Validated);
            // 
            // lb_Neupreis
            // 
            this.lb_Neupreis.AutoSize = true;
            this.lb_Neupreis.Location = new System.Drawing.Point(6, 229);
            this.lb_Neupreis.Name = "lb_Neupreis";
            this.lb_Neupreis.Size = new System.Drawing.Size(52, 13);
            this.lb_Neupreis.TabIndex = 3;
            this.lb_Neupreis.Text = "Neupreis:";
            // 
            // tb_Titel
            // 
            this.tb_Titel.Location = new System.Drawing.Point(113, 86);
            this.tb_Titel.Name = "tb_Titel";
            this.tb_Titel.Size = new System.Drawing.Size(158, 20);
            this.tb_Titel.TabIndex = 1;
            this.tb_Titel.TextChanged += new System.EventHandler(this.tb_Titel_TextChanged);
            // 
            // lb_Titel
            // 
            this.lb_Titel.AutoSize = true;
            this.lb_Titel.Location = new System.Drawing.Point(6, 87);
            this.lb_Titel.Name = "lb_Titel";
            this.lb_Titel.Size = new System.Drawing.Size(30, 13);
            this.lb_Titel.TabIndex = 3;
            this.lb_Titel.Text = "Titel:";
            // 
            // tb_ISBN
            // 
            this.tb_ISBN.Location = new System.Drawing.Point(113, 60);
            this.tb_ISBN.Name = "tb_ISBN";
            this.tb_ISBN.Size = new System.Drawing.Size(158, 20);
            this.tb_ISBN.TabIndex = 0;
            this.tb_ISBN.Click += new System.EventHandler(this.tb_ISBN_Click);
            this.tb_ISBN.TextChanged += new System.EventHandler(this.tb_ISBN_TextChanged);
            // 
            // lb_ISBN
            // 
            this.lb_ISBN.AutoSize = true;
            this.lb_ISBN.Location = new System.Drawing.Point(5, 61);
            this.lb_ISBN.Name = "lb_ISBN";
            this.lb_ISBN.Size = new System.Drawing.Size(35, 13);
            this.lb_ISBN.TabIndex = 1;
            this.lb_ISBN.Text = "ISBN:";
            // 
            // Grid_Buch
            // 
            this.Grid_Buch.AllowUserToAddRows = false;
            this.Grid_Buch.AllowUserToDeleteRows = false;
            this.Grid_Buch.AllowUserToResizeColumns = false;
            this.Grid_Buch.AllowUserToResizeRows = false;
            this.Grid_Buch.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.Grid_Buch.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Grid_Buch.Location = new System.Drawing.Point(308, 13);
            this.Grid_Buch.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Grid_Buch.MultiSelect = false;
            this.Grid_Buch.Name = "Grid_Buch";
            this.Grid_Buch.ReadOnly = true;
            this.Grid_Buch.RowHeadersVisible = false;
            this.Grid_Buch.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.Grid_Buch.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.Grid_Buch.Size = new System.Drawing.Size(571, 396);
            this.Grid_Buch.TabIndex = 0;
            this.Grid_Buch.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Grid_Buch_CellDoubleClick);
            this.Grid_Buch.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.Grid_Buch_CellMouseClick);
            // 
            // bt_Schliessen
            // 
            this.bt_Schliessen.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.bt_Schliessen.Location = new System.Drawing.Point(616, 416);
            this.bt_Schliessen.Name = "bt_Schliessen";
            this.bt_Schliessen.Size = new System.Drawing.Size(262, 23);
            this.bt_Schliessen.TabIndex = 1;
            this.bt_Schliessen.Text = "Schließen";
            this.bt_Schliessen.UseVisualStyleBackColor = true;
            // 
            // bt_Excel
            // 
            this.bt_Excel.Location = new System.Drawing.Point(308, 416);
            this.bt_Excel.Name = "bt_Excel";
            this.bt_Excel.Size = new System.Drawing.Size(262, 23);
            this.bt_Excel.TabIndex = 1;
            this.bt_Excel.Text = "Bücher in Exceltabelle speichern";
            this.bt_Excel.UseVisualStyleBackColor = true;
            this.bt_Excel.Click += new System.EventHandler(this.bt_Excel_Click);
            // 
            // w_s_buecher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(886, 449);
            this.Controls.Add(this.bt_Excel);
            this.Controls.Add(this.bt_Schliessen);
            this.Controls.Add(this.Grid_Buch);
            this.Controls.Add(this.gb_buch);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "w_s_buecher";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bücher";
            this.Activated += new System.EventHandler(this.w_s_buecher_Activated);
            ((System.ComponentModel.ISupportInitialize)(this.tsspracheBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.biboVerwaltungDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bibo_VerwaltungDataSet)).EndInit();
            this.gb_buch.ResumeLayout(false);
            this.gb_buch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
        private System.Windows.Forms.Label lb_ISBN;
        private System.Windows.Forms.Button bt_clear_buecher;
        private System.Windows.Forms.DataGridView Grid_Buch;
        private System.Windows.Forms.RadioButton rb_Add_Buch;
        private System.Windows.Forms.RadioButton rb_Update_Buch;
        private System.Windows.Forms.RadioButton rb_Delete_Buch;
        public System.Windows.Forms.TextBox tb_ISBN;
        private System.Windows.Forms.Button bt_Schliessen;
        private System.Windows.Forms.Button bt_Excel;
        private System.Windows.Forms.Label lb_isbn_vorlage;
        private System.Windows.Forms.Button bt_picture;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button bt_pic_delete;
    }
}