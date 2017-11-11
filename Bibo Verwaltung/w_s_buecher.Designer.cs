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
            this.rTB_1 = new System.Windows.Forms.RichTextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.checkbox_autor = new System.Windows.Forms.CheckBox();
            this.lb_anzahl = new System.Windows.Forms.Label();
            this.tb_anzahl = new System.Windows.Forms.TextBox();
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
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.Grid_Buch = new System.Windows.Forms.DataGridView();
            this.bt_Schliessen = new System.Windows.Forms.Button();
            this.bt_Excel = new System.Windows.Forms.Button();
            this.gb_zoom = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.tsspracheBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.biboVerwaltungDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bibo_VerwaltungDataSet)).BeginInit();
            this.gb_buch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Grid_Buch)).BeginInit();
            this.gb_zoom.SuspendLayout();
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
            this.gb_buch.Controls.Add(this.rTB_1);
            this.gb_buch.Controls.Add(this.comboBox1);
            this.gb_buch.Controls.Add(this.checkedListBox1);
            this.gb_buch.Controls.Add(this.checkbox_autor);
            this.gb_buch.Controls.Add(this.lb_anzahl);
            this.gb_buch.Controls.Add(this.tb_anzahl);
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
            this.gb_buch.Location = new System.Drawing.Point(16, 31);
            this.gb_buch.Margin = new System.Windows.Forms.Padding(8);
            this.gb_buch.Name = "gb_buch";
            this.gb_buch.Padding = new System.Windows.Forms.Padding(8);
            this.gb_buch.Size = new System.Drawing.Size(792, 1015);
            this.gb_buch.TabIndex = 0;
            this.gb_buch.TabStop = false;
            this.gb_buch.Text = "Bücher";
            this.gb_buch.Enter += new System.EventHandler(this.gb_buch_Enter);
            // 
            // rTB_1
            // 
            this.rTB_1.BackColor = System.Drawing.SystemColors.Control;
            this.rTB_1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rTB_1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)), true);
            this.rTB_1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.rTB_1.Location = new System.Drawing.Point(16, 879);
            this.rTB_1.Name = "rTB_1";
            this.rTB_1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.rTB_1.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.rTB_1.Size = new System.Drawing.Size(268, 113);
            this.rTB_1.TabIndex = 54;
            this.rTB_1.Text = "Das Buch wurde erfolgreich hinzugefügt!";
            this.rTB_1.UseWaitCursor = true;
            this.rTB_1.Visible = false;
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.Color.White;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(680, 260);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(6);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.comboBox1.Size = new System.Drawing.Size(36, 39);
            this.comboBox1.TabIndex = 53;
            this.comboBox1.Click += new System.EventHandler(this.comboBox1_Click);
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Location = new System.Drawing.Point(300, 301);
            this.checkedListBox1.Margin = new System.Windows.Forms.Padding(6);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(416, 598);
            this.checkedListBox1.TabIndex = 51;
            this.checkedListBox1.Visible = false;
            this.checkedListBox1.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.checkedListBox1_ItemCheck);
            // 
            // checkbox_autor
            // 
            this.checkbox_autor.AutoSize = true;
            this.checkbox_autor.Location = new System.Drawing.Point(254, 267);
            this.checkbox_autor.Margin = new System.Windows.Forms.Padding(6);
            this.checkbox_autor.Name = "checkbox_autor";
            this.checkbox_autor.Size = new System.Drawing.Size(34, 33);
            this.checkbox_autor.TabIndex = 51;
            this.checkbox_autor.UseVisualStyleBackColor = true;
            this.checkbox_autor.CheckedChanged += new System.EventHandler(this.checkbox_autor_CheckedChanged);
            // 
            // lb_anzahl
            // 
            this.lb_anzahl.AutoSize = true;
            this.lb_anzahl.Location = new System.Drawing.Point(16, 688);
            this.lb_anzahl.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.lb_anzahl.Name = "lb_anzahl";
            this.lb_anzahl.Size = new System.Drawing.Size(254, 32);
            this.lb_anzahl.TabIndex = 49;
            this.lb_anzahl.Text = "Anzahl Exemplare:";
            // 
            // tb_anzahl
            // 
            this.tb_anzahl.Enabled = false;
            this.tb_anzahl.Location = new System.Drawing.Point(300, 682);
            this.tb_anzahl.Margin = new System.Windows.Forms.Padding(8);
            this.tb_anzahl.Name = "tb_anzahl";
            this.tb_anzahl.Size = new System.Drawing.Size(416, 38);
            this.tb_anzahl.TabIndex = 48;
            // 
            // bt_pic_delete
            // 
            this.bt_pic_delete.Location = new System.Drawing.Point(16, 812);
            this.bt_pic_delete.Margin = new System.Windows.Forms.Padding(8);
            this.bt_pic_delete.Name = "bt_pic_delete";
            this.bt_pic_delete.Size = new System.Drawing.Size(268, 56);
            this.bt_pic_delete.TabIndex = 47;
            this.bt_pic_delete.Text = "Bild entfernen";
            this.bt_pic_delete.UseVisualStyleBackColor = true;
            this.bt_pic_delete.Click += new System.EventHandler(this.bt_pic_add_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(300, 740);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(8);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(418, 178);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 46;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseEnter += new System.EventHandler(this.pictureBox1_MouseEnter);
            this.pictureBox1.MouseLeave += new System.EventHandler(this.pictureBox1_MouseLeave);
            // 
            // bt_picture
            // 
            this.bt_picture.Location = new System.Drawing.Point(16, 740);
            this.bt_picture.Margin = new System.Windows.Forms.Padding(8);
            this.bt_picture.Name = "bt_picture";
            this.bt_picture.Size = new System.Drawing.Size(268, 56);
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
            this.lb_isbn_vorlage.Location = new System.Drawing.Point(301, 145);
            this.lb_isbn_vorlage.Margin = new System.Windows.Forms.Padding(0);
            this.lb_isbn_vorlage.Name = "lb_isbn_vorlage";
            this.lb_isbn_vorlage.Size = new System.Drawing.Size(218, 31);
            this.lb_isbn_vorlage.TabIndex = 44;
            this.lb_isbn_vorlage.Text = "123-0123456789";
            this.lb_isbn_vorlage.Click += new System.EventHandler(this.lb_isbn_vorlage_Click);
            // 
            // rb_Update_Buch
            // 
            this.rb_Update_Buch.AutoSize = true;
            this.rb_Update_Buch.Location = new System.Drawing.Point(284, 45);
            this.rb_Update_Buch.Margin = new System.Windows.Forms.Padding(4, 8, 4, 8);
            this.rb_Update_Buch.Name = "rb_Update_Buch";
            this.rb_Update_Buch.Size = new System.Drawing.Size(191, 36);
            this.rb_Update_Buch.TabIndex = 43;
            this.rb_Update_Buch.Text = "Bearbeiten";
            this.rb_Update_Buch.UseVisualStyleBackColor = true;
            this.rb_Update_Buch.CheckedChanged += new System.EventHandler(this.rb_Edit_CheckedChanged);
            // 
            // bt_clear_buecher
            // 
            this.bt_clear_buecher.Location = new System.Drawing.Point(528, 936);
            this.bt_clear_buecher.Margin = new System.Windows.Forms.Padding(8);
            this.bt_clear_buecher.Name = "bt_clear_buecher";
            this.bt_clear_buecher.Size = new System.Drawing.Size(192, 56);
            this.bt_clear_buecher.TabIndex = 15;
            this.bt_clear_buecher.Text = "Leeren";
            this.bt_clear_buecher.UseVisualStyleBackColor = true;
            this.bt_clear_buecher.Click += new System.EventHandler(this.bt_clear_buecher_Click);
            // 
            // rb_Add_Buch
            // 
            this.rb_Add_Buch.AutoSize = true;
            this.rb_Add_Buch.Checked = true;
            this.rb_Add_Buch.Location = new System.Drawing.Point(16, 45);
            this.rb_Add_Buch.Margin = new System.Windows.Forms.Padding(4, 8, 4, 8);
            this.rb_Add_Buch.Name = "rb_Add_Buch";
            this.rb_Add_Buch.Size = new System.Drawing.Size(197, 36);
            this.rb_Add_Buch.TabIndex = 41;
            this.rb_Add_Buch.TabStop = true;
            this.rb_Add_Buch.Text = "Hinzufügen";
            this.rb_Add_Buch.UseVisualStyleBackColor = true;
            this.rb_Add_Buch.CheckedChanged += new System.EventHandler(this.rb_Neubuch_CheckedChanged);
            // 
            // cb_Autor
            // 
            this.cb_Autor.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cb_Autor.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cb_Autor.FormattingEnabled = true;
            this.cb_Autor.Location = new System.Drawing.Point(300, 260);
            this.cb_Autor.Margin = new System.Windows.Forms.Padding(8);
            this.cb_Autor.Name = "cb_Autor";
            this.cb_Autor.Size = new System.Drawing.Size(416, 39);
            this.cb_Autor.TabIndex = 2;
            this.cb_Autor.TextChanged += new System.EventHandler(this.cb_Autor_TextChanged);
            // 
            // bt_speichern_buecher
            // 
            this.bt_speichern_buecher.Location = new System.Drawing.Point(300, 936);
            this.bt_speichern_buecher.Margin = new System.Windows.Forms.Padding(8);
            this.bt_speichern_buecher.Name = "bt_speichern_buecher";
            this.bt_speichern_buecher.Size = new System.Drawing.Size(192, 56);
            this.bt_speichern_buecher.TabIndex = 14;
            this.bt_speichern_buecher.Text = "Speichern";
            this.bt_speichern_buecher.UseVisualStyleBackColor = true;
            this.bt_speichern_buecher.Click += new System.EventHandler(this.Save_Buecher);
            // 
            // rb_Delete_Buch
            // 
            this.rb_Delete_Buch.AutoSize = true;
            this.rb_Delete_Buch.Location = new System.Drawing.Point(548, 45);
            this.rb_Delete_Buch.Margin = new System.Windows.Forms.Padding(4, 8, 4, 8);
            this.rb_Delete_Buch.Name = "rb_Delete_Buch";
            this.rb_Delete_Buch.Size = new System.Drawing.Size(176, 36);
            this.rb_Delete_Buch.TabIndex = 42;
            this.rb_Delete_Buch.Text = "Entfernen";
            this.rb_Delete_Buch.UseVisualStyleBackColor = true;
            this.rb_Delete_Buch.CheckedChanged += new System.EventHandler(this.rb_Delete_CheckedChanged);
            // 
            // dTP_Erscheinungsdatum
            // 
            this.dTP_Erscheinungsdatum.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dTP_Erscheinungsdatum.Location = new System.Drawing.Point(300, 624);
            this.dTP_Erscheinungsdatum.Margin = new System.Windows.Forms.Padding(8);
            this.dTP_Erscheinungsdatum.Name = "dTP_Erscheinungsdatum";
            this.dTP_Erscheinungsdatum.Size = new System.Drawing.Size(416, 38);
            this.dTP_Erscheinungsdatum.TabIndex = 12;
            // 
            // lb_Erscheinungsdatum
            // 
            this.lb_Erscheinungsdatum.AutoSize = true;
            this.lb_Erscheinungsdatum.Location = new System.Drawing.Point(16, 634);
            this.lb_Erscheinungsdatum.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.lb_Erscheinungsdatum.Name = "lb_Erscheinungsdatum";
            this.lb_Erscheinungsdatum.Size = new System.Drawing.Size(275, 32);
            this.lb_Erscheinungsdatum.TabIndex = 20;
            this.lb_Erscheinungsdatum.Text = "Erscheinungsdatum:";
            // 
            // tb_Auflage
            // 
            this.tb_Auflage.Location = new System.Drawing.Point(300, 508);
            this.tb_Auflage.Margin = new System.Windows.Forms.Padding(8);
            this.tb_Auflage.Name = "tb_Auflage";
            this.tb_Auflage.Size = new System.Drawing.Size(416, 38);
            this.tb_Auflage.TabIndex = 10;
            this.tb_Auflage.TextChanged += new System.EventHandler(this.tb_Auflage_TextChanged);
            // 
            // lb_Auflage
            // 
            this.lb_Auflage.AutoSize = true;
            this.lb_Auflage.Location = new System.Drawing.Point(16, 513);
            this.lb_Auflage.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.lb_Auflage.Name = "lb_Auflage";
            this.lb_Auflage.Size = new System.Drawing.Size(113, 32);
            this.lb_Auflage.TabIndex = 18;
            this.lb_Auflage.Text = "Auflage";
            // 
            // lb_Neupreis_Euro
            // 
            this.lb_Neupreis_Euro.AutoSize = true;
            this.lb_Neupreis_Euro.Location = new System.Drawing.Point(736, 572);
            this.lb_Neupreis_Euro.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.lb_Neupreis_Euro.Name = "lb_Neupreis_Euro";
            this.lb_Neupreis_Euro.Size = new System.Drawing.Size(31, 32);
            this.lb_Neupreis_Euro.TabIndex = 1;
            this.lb_Neupreis_Euro.Text = "€";
            // 
            // bt_Sprache_s
            // 
            this.bt_Sprache_s.Location = new System.Drawing.Point(736, 448);
            this.bt_Sprache_s.Margin = new System.Windows.Forms.Padding(8);
            this.bt_Sprache_s.Name = "bt_Sprache_s";
            this.bt_Sprache_s.Size = new System.Drawing.Size(40, 39);
            this.bt_Sprache_s.TabIndex = 9;
            this.bt_Sprache_s.Text = "+";
            this.bt_Sprache_s.UseVisualStyleBackColor = true;
            this.bt_Sprache_s.Click += new System.EventHandler(this.bt_Sprache_s_Click_1);
            // 
            // cb_Sprache
            // 
            this.cb_Sprache.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cb_Sprache.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cb_Sprache.FormattingEnabled = true;
            this.cb_Sprache.Location = new System.Drawing.Point(300, 446);
            this.cb_Sprache.Margin = new System.Windows.Forms.Padding(8);
            this.cb_Sprache.Name = "cb_Sprache";
            this.cb_Sprache.Size = new System.Drawing.Size(416, 39);
            this.cb_Sprache.TabIndex = 8;
            this.cb_Sprache.TextChanged += new System.EventHandler(this.cb_Sprache_TextChanged);
            // 
            // lb_Sprache
            // 
            this.lb_Sprache.AutoSize = true;
            this.lb_Sprache.Location = new System.Drawing.Point(16, 451);
            this.lb_Sprache.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.lb_Sprache.Name = "lb_Sprache";
            this.lb_Sprache.Size = new System.Drawing.Size(129, 32);
            this.lb_Sprache.TabIndex = 14;
            this.lb_Sprache.Text = "Sprache:";
            // 
            // bt_Autor_s
            // 
            this.bt_Autor_s.Location = new System.Drawing.Point(736, 262);
            this.bt_Autor_s.Margin = new System.Windows.Forms.Padding(8);
            this.bt_Autor_s.Name = "bt_Autor_s";
            this.bt_Autor_s.Size = new System.Drawing.Size(40, 39);
            this.bt_Autor_s.TabIndex = 3;
            this.bt_Autor_s.Text = "+";
            this.bt_Autor_s.UseVisualStyleBackColor = true;
            this.bt_Autor_s.Click += new System.EventHandler(this.bt_Autor_s_Click);
            // 
            // lb_Verlag
            // 
            this.lb_Verlag.AutoSize = true;
            this.lb_Verlag.Location = new System.Drawing.Point(16, 327);
            this.lb_Verlag.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.lb_Verlag.Name = "lb_Verlag";
            this.lb_Verlag.Size = new System.Drawing.Size(106, 32);
            this.lb_Verlag.TabIndex = 10;
            this.lb_Verlag.Text = "Verlag:";
            // 
            // lb_Autor
            // 
            this.lb_Autor.AutoSize = true;
            this.lb_Autor.Location = new System.Drawing.Point(16, 265);
            this.lb_Autor.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.lb_Autor.Name = "lb_Autor";
            this.lb_Autor.Size = new System.Drawing.Size(91, 32);
            this.lb_Autor.TabIndex = 8;
            this.lb_Autor.Text = "Autor:";
            // 
            // bt_Verlag_s
            // 
            this.bt_Verlag_s.Location = new System.Drawing.Point(736, 324);
            this.bt_Verlag_s.Margin = new System.Windows.Forms.Padding(8);
            this.bt_Verlag_s.Name = "bt_Verlag_s";
            this.bt_Verlag_s.Size = new System.Drawing.Size(40, 39);
            this.bt_Verlag_s.TabIndex = 5;
            this.bt_Verlag_s.Text = "+";
            this.bt_Verlag_s.UseVisualStyleBackColor = true;
            this.bt_Verlag_s.Click += new System.EventHandler(this.bt_Verlag_s_Click);
            // 
            // bt_Genre_s
            // 
            this.bt_Genre_s.Location = new System.Drawing.Point(736, 386);
            this.bt_Genre_s.Margin = new System.Windows.Forms.Padding(8);
            this.bt_Genre_s.Name = "bt_Genre_s";
            this.bt_Genre_s.Size = new System.Drawing.Size(40, 39);
            this.bt_Genre_s.TabIndex = 7;
            this.bt_Genre_s.Text = "+";
            this.bt_Genre_s.UseVisualStyleBackColor = true;
            this.bt_Genre_s.Click += new System.EventHandler(this.bt_Genre_s_Click);
            // 
            // cb_Verlag
            // 
            this.cb_Verlag.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cb_Verlag.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cb_Verlag.FormattingEnabled = true;
            this.cb_Verlag.Location = new System.Drawing.Point(300, 322);
            this.cb_Verlag.Margin = new System.Windows.Forms.Padding(8);
            this.cb_Verlag.Name = "cb_Verlag";
            this.cb_Verlag.Size = new System.Drawing.Size(416, 39);
            this.cb_Verlag.TabIndex = 4;
            this.cb_Verlag.TextChanged += new System.EventHandler(this.cb_Verlag_TextChanged);
            // 
            // cb_Genre
            // 
            this.cb_Genre.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cb_Genre.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cb_Genre.FormattingEnabled = true;
            this.cb_Genre.Location = new System.Drawing.Point(300, 384);
            this.cb_Genre.Margin = new System.Windows.Forms.Padding(8);
            this.cb_Genre.Name = "cb_Genre";
            this.cb_Genre.Size = new System.Drawing.Size(416, 39);
            this.cb_Genre.TabIndex = 6;
            this.cb_Genre.TextChanged += new System.EventHandler(this.cb_Genre_TextChanged);
            // 
            // lb_Genre
            // 
            this.lb_Genre.AutoSize = true;
            this.lb_Genre.Location = new System.Drawing.Point(16, 389);
            this.lb_Genre.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.lb_Genre.Name = "lb_Genre";
            this.lb_Genre.Size = new System.Drawing.Size(102, 32);
            this.lb_Genre.TabIndex = 5;
            this.lb_Genre.Text = "Genre:";
            // 
            // tb_Neupreis
            // 
            this.tb_Neupreis.Location = new System.Drawing.Point(300, 566);
            this.tb_Neupreis.Margin = new System.Windows.Forms.Padding(8);
            this.tb_Neupreis.Name = "tb_Neupreis";
            this.tb_Neupreis.Size = new System.Drawing.Size(416, 38);
            this.tb_Neupreis.TabIndex = 11;
            this.tb_Neupreis.TextChanged += new System.EventHandler(this.tb_Neupreis_TextChanged);
            this.tb_Neupreis.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_Neupreis_KeyPress);
            this.tb_Neupreis.Leave += new System.EventHandler(this.tb_Neupreis_Leave);
            // 
            // lb_Neupreis
            // 
            this.lb_Neupreis.AutoSize = true;
            this.lb_Neupreis.Location = new System.Drawing.Point(16, 572);
            this.lb_Neupreis.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.lb_Neupreis.Name = "lb_Neupreis";
            this.lb_Neupreis.Size = new System.Drawing.Size(137, 32);
            this.lb_Neupreis.TabIndex = 3;
            this.lb_Neupreis.Text = "Neupreis:";
            // 
            // tb_Titel
            // 
            this.tb_Titel.Location = new System.Drawing.Point(300, 202);
            this.tb_Titel.Margin = new System.Windows.Forms.Padding(8);
            this.tb_Titel.Name = "tb_Titel";
            this.tb_Titel.Size = new System.Drawing.Size(416, 38);
            this.tb_Titel.TabIndex = 1;
            this.tb_Titel.Click += new System.EventHandler(this.tb_Titel_Click);
            this.tb_Titel.TextChanged += new System.EventHandler(this.tb_Titel_TextChanged);
            // 
            // lb_Titel
            // 
            this.lb_Titel.AutoSize = true;
            this.lb_Titel.Location = new System.Drawing.Point(16, 207);
            this.lb_Titel.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.lb_Titel.Name = "lb_Titel";
            this.lb_Titel.Size = new System.Drawing.Size(78, 32);
            this.lb_Titel.TabIndex = 3;
            this.lb_Titel.Text = "Titel:";
            // 
            // tb_ISBN
            // 
            this.tb_ISBN.Location = new System.Drawing.Point(300, 143);
            this.tb_ISBN.Margin = new System.Windows.Forms.Padding(8);
            this.tb_ISBN.Name = "tb_ISBN";
            this.tb_ISBN.Size = new System.Drawing.Size(416, 38);
            this.tb_ISBN.TabIndex = 0;
            this.tb_ISBN.Click += new System.EventHandler(this.tb_ISBN_Click);
            this.tb_ISBN.TextChanged += new System.EventHandler(this.tb_ISBN_TextChanged);
            this.tb_ISBN.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tb_ISBN_KeyDown);
            this.tb_ISBN.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_ISBN_KeyPress);
            this.tb_ISBN.Leave += new System.EventHandler(this.tb_ISBN_Leave);
            // 
            // lb_ISBN
            // 
            this.lb_ISBN.AutoSize = true;
            this.lb_ISBN.Location = new System.Drawing.Point(16, 149);
            this.lb_ISBN.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.lb_ISBN.Name = "lb_ISBN";
            this.lb_ISBN.Size = new System.Drawing.Size(88, 32);
            this.lb_ISBN.TabIndex = 1;
            this.lb_ISBN.Text = "ISBN:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(750, 172);
            this.button1.Margin = new System.Windows.Forms.Padding(6);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(44, 45);
            this.button1.TabIndex = 50;
            this.button1.Text = "*";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.SystemColors.Control;
            this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox2.Location = new System.Drawing.Point(4, 31);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(8);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(1516, 980);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 50;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Visible = false;
            // 
            // Grid_Buch
            // 
            this.Grid_Buch.AllowUserToAddRows = false;
            this.Grid_Buch.AllowUserToDeleteRows = false;
            this.Grid_Buch.AllowUserToOrderColumns = true;
            this.Grid_Buch.AllowUserToResizeRows = false;
            this.Grid_Buch.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.Grid_Buch.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Grid_Buch.Location = new System.Drawing.Point(820, 31);
            this.Grid_Buch.Margin = new System.Windows.Forms.Padding(4, 8, 4, 8);
            this.Grid_Buch.Name = "Grid_Buch";
            this.Grid_Buch.ReadOnly = true;
            this.Grid_Buch.RowHeadersVisible = false;
            this.Grid_Buch.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.Grid_Buch.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.Grid_Buch.Size = new System.Drawing.Size(1524, 944);
            this.Grid_Buch.TabIndex = 0;
            this.Grid_Buch.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Grid_Buch_CellDoubleClick);
            this.Grid_Buch.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.Grid_Buch_CellMouseClick);
            // 
            // bt_Schliessen
            // 
            this.bt_Schliessen.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.bt_Schliessen.Location = new System.Drawing.Point(1644, 992);
            this.bt_Schliessen.Margin = new System.Windows.Forms.Padding(8);
            this.bt_Schliessen.Name = "bt_Schliessen";
            this.bt_Schliessen.Size = new System.Drawing.Size(700, 54);
            this.bt_Schliessen.TabIndex = 1;
            this.bt_Schliessen.Text = "Schließen";
            this.bt_Schliessen.UseVisualStyleBackColor = true;
            // 
            // bt_Excel
            // 
            this.bt_Excel.Location = new System.Drawing.Point(820, 992);
            this.bt_Excel.Margin = new System.Windows.Forms.Padding(8);
            this.bt_Excel.Name = "bt_Excel";
            this.bt_Excel.Size = new System.Drawing.Size(700, 54);
            this.bt_Excel.TabIndex = 1;
            this.bt_Excel.Text = "Bücher in Exceltabelle speichern";
            this.bt_Excel.UseVisualStyleBackColor = true;
            this.bt_Excel.Click += new System.EventHandler(this.bt_Excel_Click);
            // 
            // gb_zoom
            // 
            this.gb_zoom.Controls.Add(this.pictureBox2);
            this.gb_zoom.Location = new System.Drawing.Point(820, 31);
            this.gb_zoom.Margin = new System.Windows.Forms.Padding(4);
            this.gb_zoom.Name = "gb_zoom";
            this.gb_zoom.Padding = new System.Windows.Forms.Padding(4, 0, 4, 4);
            this.gb_zoom.Size = new System.Drawing.Size(1524, 1015);
            this.gb_zoom.TabIndex = 51;
            this.gb_zoom.TabStop = false;
            // 
            // w_s_buecher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2364, 1071);
            this.Controls.Add(this.gb_zoom);
            this.Controls.Add(this.bt_Excel);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.bt_Schliessen);
            this.Controls.Add(this.Grid_Buch);
            this.Controls.Add(this.gb_buch);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(8);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "w_s_buecher";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bücher";
            this.Activated += new System.EventHandler(this.w_s_buecher_Activated);
            this.Click += new System.EventHandler(this.w_s_buecher_Click);
            ((System.ComponentModel.ISupportInitialize)(this.tsspracheBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.biboVerwaltungDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bibo_VerwaltungDataSet)).EndInit();
            this.gb_buch.ResumeLayout(false);
            this.gb_buch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Grid_Buch)).EndInit();
            this.gb_zoom.ResumeLayout(false);
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
        private System.Windows.Forms.TextBox tb_anzahl;
        private System.Windows.Forms.Label lb_anzahl;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.GroupBox gb_zoom;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckBox checkbox_autor;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.RichTextBox rTB_1;
    }
}