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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(w_s_buecher));
            this.tsspracheBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.biboVerwaltungDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bibo_VerwaltungDataSet = new Bibo_Verwaltung.Bibo_VerwaltungDataSet();
            this.t_s_spracheTableAdapter = new Bibo_Verwaltung.Bibo_VerwaltungDataSetTableAdapters.t_s_spracheTableAdapter();
            this.rTB_1 = new MetroFramework.Controls.MetroTextBox();
            this.checkbox_autor = new MetroFramework.Controls.MetroCheckBox();
            this.bt_clear_buecher = new MetroFramework.Controls.MetroButton();
            this.bt_speichern_buecher = new MetroFramework.Controls.MetroButton();
            this.lb_anzahl = new MetroFramework.Controls.MetroLabel();
            this.bt_pic_delete = new MetroFramework.Controls.MetroButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.bt_picture = new MetroFramework.Controls.MetroButton();
            this.lb_Erscheinungsdatum = new MetroFramework.Controls.MetroLabel();
            this.lb_Auflage = new MetroFramework.Controls.MetroLabel();
            this.lb_Neupreis_Euro = new MetroFramework.Controls.MetroLabel();
            this.bt_Sprache_s = new MetroFramework.Controls.MetroButton();
            this.lb_Neupreis = new MetroFramework.Controls.MetroLabel();
            this.tb_anzahl = new MetroFramework.Controls.MetroTextBox();
            this.dTP_Erscheinungsdatum = new MetroFramework.Controls.MetroDateTime();
            this.tb_Auflage = new MetroFramework.Controls.MetroTextBox();
            this.lb_Sprache = new MetroFramework.Controls.MetroLabel();
            this.tb_Neupreis = new MetroFramework.Controls.MetroTextBox();
            this.comboBox1 = new Bibo_Verwaltung.AdvancedComboBox();
            this.rb_Update_Buch = new MetroFramework.Controls.MetroRadioButton();
            this.rb_Add_Buch = new MetroFramework.Controls.MetroRadioButton();
            this.rb_Delete_Buch = new MetroFramework.Controls.MetroRadioButton();
            this.bt_Autor_s = new MetroFramework.Controls.MetroButton();
            this.lb_Verlag = new MetroFramework.Controls.MetroLabel();
            this.lb_Autor = new MetroFramework.Controls.MetroLabel();
            this.bt_Verlag_s = new MetroFramework.Controls.MetroButton();
            this.bt_Genre_s = new MetroFramework.Controls.MetroButton();
            this.lb_Genre = new MetroFramework.Controls.MetroLabel();
            this.tb_Titel = new MetroFramework.Controls.MetroTextBox();
            this.lb_Titel = new MetroFramework.Controls.MetroLabel();
            this.tb_ISBN = new MetroFramework.Controls.MetroTextBox();
            this.lb_ISBN = new MetroFramework.Controls.MetroLabel();
            this.button1 = new MetroFramework.Controls.MetroButton();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.Grid_Buch = new MetroFramework.Controls.MetroGrid();
            this.contextMenuStrip1 = new MetroFramework.Controls.MetroContextMenu(this.components);
            this.ladenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.entfernenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exemplareToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bt_Schliessen = new MetroFramework.Controls.MetroButton();
            this.bt_Excel = new MetroFramework.Controls.MetroButton();
            this.gb_zoom = new MetroFramework.Controls.MetroPanel();
            this.helpProvider = new System.Windows.Forms.HelpProvider();
            this.cb_Autor = new Bibo_Verwaltung.AdvancedComboBox();
            this.cb_Verlag = new Bibo_Verwaltung.AdvancedComboBox();
            this.cb_Genre = new Bibo_Verwaltung.AdvancedComboBox();
            this.cb_Sprache = new Bibo_Verwaltung.AdvancedComboBox();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.checkedListBox1 = new Bibo_Verwaltung.AdvancedCheckedListBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.metroProgressBar1 = new MetroFramework.Controls.MetroProgressBar();
            ((System.ComponentModel.ISupportInitialize)(this.tsspracheBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.biboVerwaltungDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bibo_VerwaltungDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Grid_Buch)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.gb_zoom.SuspendLayout();
            this.metroPanel1.SuspendLayout();
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
            // rTB_1
            // 
            this.rTB_1.BackColor = System.Drawing.SystemColors.Control;
            // 
            // 
            // 
            this.rTB_1.CustomButton.Image = null;
            this.rTB_1.CustomButton.Location = new System.Drawing.Point(74, 1);
            this.rTB_1.CustomButton.Margin = new System.Windows.Forms.Padding(2);
            this.rTB_1.CustomButton.Name = "";
            this.rTB_1.CustomButton.Size = new System.Drawing.Size(63, 63);
            this.rTB_1.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.rTB_1.CustomButton.TabIndex = 1;
            this.rTB_1.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.rTB_1.CustomButton.UseSelectable = true;
            this.rTB_1.CustomButton.UseWaitCursor = true;
            this.rTB_1.CustomButton.Visible = false;
            this.rTB_1.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.rTB_1.FontWeight = MetroFramework.MetroTextBoxWeight.Light;
            this.rTB_1.Lines = new string[] {
        "Das Buch wurde erfolgreich hinzugefügt!"};
            this.rTB_1.Location = new System.Drawing.Point(3, 396);
            this.rTB_1.MaxLength = 1000;
            this.rTB_1.Multiline = true;
            this.rTB_1.Name = "rTB_1";
            this.rTB_1.PasswordChar = '\0';
            this.rTB_1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.rTB_1.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.rTB_1.SelectedText = "";
            this.rTB_1.SelectionLength = 0;
            this.rTB_1.SelectionStart = 0;
            this.rTB_1.ShortcutsEnabled = true;
            this.rTB_1.Size = new System.Drawing.Size(138, 65);
            this.rTB_1.TabIndex = 54;
            this.rTB_1.Text = "Das Buch wurde erfolgreich hinzugefügt!";
            this.rTB_1.UseSelectable = true;
            this.rTB_1.UseWaitCursor = true;
            this.rTB_1.Visible = false;
            this.rTB_1.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.rTB_1.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // checkbox_autor
            // 
            this.checkbox_autor.AutoSize = true;
            this.checkbox_autor.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkbox_autor.FontSize = MetroFramework.MetroCheckBoxSize.Medium;
            this.helpProvider.SetHelpString(this.checkbox_autor, "Setzen sie einen Haken in dieses Feld, können sie mehrere Autoren zu einem Buch a" +
        "ngeben.");
            this.checkbox_autor.Location = new System.Drawing.Point(119, 88);
            this.checkbox_autor.MinimumSize = new System.Drawing.Size(22, 24);
            this.checkbox_autor.Name = "checkbox_autor";
            this.helpProvider.SetShowHelp(this.checkbox_autor, true);
            this.checkbox_autor.Size = new System.Drawing.Size(22, 24);
            this.checkbox_autor.TabIndex = 51;
            this.checkbox_autor.UseSelectable = true;
            this.checkbox_autor.CheckedChanged += new System.EventHandler(this.checkbox_autor_CheckedChanged);
            // 
            // bt_clear_buecher
            // 
            this.bt_clear_buecher.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.bt_clear_buecher.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.helpProvider.SetHelpString(this.bt_clear_buecher, "Leeren sie alle oben liegenden Textfelder.");
            this.bt_clear_buecher.Location = new System.Drawing.Point(253, 437);
            this.bt_clear_buecher.MaximumSize = new System.Drawing.Size(225, 24);
            this.bt_clear_buecher.MinimumSize = new System.Drawing.Size(75, 24);
            this.bt_clear_buecher.Name = "bt_clear_buecher";
            this.helpProvider.SetShowHelp(this.bt_clear_buecher, true);
            this.bt_clear_buecher.Size = new System.Drawing.Size(96, 24);
            this.bt_clear_buecher.Style = MetroFramework.MetroColorStyle.Blue;
            this.bt_clear_buecher.TabIndex = 15;
            this.bt_clear_buecher.Text = "Leeren";
            this.bt_clear_buecher.UseSelectable = true;
            this.bt_clear_buecher.Click += new System.EventHandler(this.bt_clear_buecher_Click);
            // 
            // bt_speichern_buecher
            // 
            this.bt_speichern_buecher.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.bt_speichern_buecher.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.helpProvider.SetHelpString(this.bt_speichern_buecher, "Speichern sie alle oben eingetragenen Daten.");
            this.bt_speichern_buecher.Location = new System.Drawing.Point(147, 437);
            this.bt_speichern_buecher.MaximumSize = new System.Drawing.Size(225, 24);
            this.bt_speichern_buecher.MinimumSize = new System.Drawing.Size(75, 24);
            this.bt_speichern_buecher.Name = "bt_speichern_buecher";
            this.helpProvider.SetShowHelp(this.bt_speichern_buecher, true);
            this.bt_speichern_buecher.Size = new System.Drawing.Size(96, 24);
            this.bt_speichern_buecher.Style = MetroFramework.MetroColorStyle.Blue;
            this.bt_speichern_buecher.TabIndex = 14;
            this.bt_speichern_buecher.Text = "Speichern";
            this.bt_speichern_buecher.UseSelectable = true;
            this.bt_speichern_buecher.Click += new System.EventHandler(this.Save_Buecher);
            // 
            // lb_anzahl
            // 
            this.lb_anzahl.AutoSize = true;
            this.helpProvider.SetHelpString(this.lb_anzahl, "Tragen sie die Anzahl der Exemplare ihres Buches hier ein.");
            this.lb_anzahl.Location = new System.Drawing.Point(3, 304);
            this.lb_anzahl.Margin = new System.Windows.Forms.Padding(3);
            this.lb_anzahl.Name = "lb_anzahl";
            this.helpProvider.SetShowHelp(this.lb_anzahl, true);
            this.lb_anzahl.Size = new System.Drawing.Size(117, 19);
            this.lb_anzahl.TabIndex = 49;
            this.lb_anzahl.Text = "Anzahl Exemplare:";
            // 
            // bt_pic_delete
            // 
            this.bt_pic_delete.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.bt_pic_delete.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.helpProvider.SetHelpString(this.bt_pic_delete, "Entfernen sie ein Bild zu ihrem Buch.");
            this.bt_pic_delete.Location = new System.Drawing.Point(3, 365);
            this.bt_pic_delete.MaximumSize = new System.Drawing.Size(225, 24);
            this.bt_pic_delete.MinimumSize = new System.Drawing.Size(98, 24);
            this.bt_pic_delete.Name = "bt_pic_delete";
            this.helpProvider.SetShowHelp(this.bt_pic_delete, true);
            this.bt_pic_delete.Size = new System.Drawing.Size(138, 24);
            this.bt_pic_delete.Style = MetroFramework.MetroColorStyle.Blue;
            this.bt_pic_delete.TabIndex = 47;
            this.bt_pic_delete.Text = "Bild entfernen";
            this.bt_pic_delete.UseSelectable = true;
            this.bt_pic_delete.Click += new System.EventHandler(this.bt_pic_add_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.helpProvider.SetHelpString(this.pictureBox1, "Wenn sie mit ihrer Maus über dieses Vorschaubild ihres aktuellen Buches fahren, s" +
        "ehen sie eine vergrößerte Darstellung.");
            this.pictureBox1.Location = new System.Drawing.Point(147, 335);
            this.pictureBox1.Name = "pictureBox1";
            this.helpProvider.SetShowHelp(this.pictureBox1, true);
            this.pictureBox1.Size = new System.Drawing.Size(202, 96);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 46;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseEnter += new System.EventHandler(this.pictureBox1_MouseEnter);
            this.pictureBox1.MouseLeave += new System.EventHandler(this.pictureBox1_MouseLeave);
            // 
            // bt_picture
            // 
            this.bt_picture.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.bt_picture.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.helpProvider.SetHelpString(this.bt_picture, "Laden sie ein Bild zu ihrem Buch hoch.");
            this.bt_picture.Location = new System.Drawing.Point(3, 335);
            this.bt_picture.MaximumSize = new System.Drawing.Size(225, 24);
            this.bt_picture.MinimumSize = new System.Drawing.Size(98, 24);
            this.bt_picture.Name = "bt_picture";
            this.helpProvider.SetShowHelp(this.bt_picture, true);
            this.bt_picture.Size = new System.Drawing.Size(138, 24);
            this.bt_picture.Style = MetroFramework.MetroColorStyle.Blue;
            this.bt_picture.TabIndex = 45;
            this.bt_picture.Text = "Bild auswählen";
            this.bt_picture.UseSelectable = true;
            this.bt_picture.Click += new System.EventHandler(this.bt_picture_Click);
            // 
            // lb_Erscheinungsdatum
            // 
            this.lb_Erscheinungsdatum.AutoSize = true;
            this.helpProvider.SetHelpString(this.lb_Erscheinungsdatum, "Wählen sie das Erscheinungsdatum ihres Buches hier ein.");
            this.lb_Erscheinungsdatum.Location = new System.Drawing.Point(3, 268);
            this.lb_Erscheinungsdatum.Margin = new System.Windows.Forms.Padding(3);
            this.lb_Erscheinungsdatum.Name = "lb_Erscheinungsdatum";
            this.helpProvider.SetShowHelp(this.lb_Erscheinungsdatum, true);
            this.lb_Erscheinungsdatum.Size = new System.Drawing.Size(130, 19);
            this.lb_Erscheinungsdatum.TabIndex = 20;
            this.lb_Erscheinungsdatum.Text = "Erscheinungsdatum:*";
            // 
            // lb_Auflage
            // 
            this.lb_Auflage.AutoSize = true;
            this.helpProvider.SetHelpString(this.lb_Auflage, "Tragen sie die Auflage ihres Buches hier ein.");
            this.lb_Auflage.Location = new System.Drawing.Point(3, 208);
            this.lb_Auflage.Margin = new System.Windows.Forms.Padding(3);
            this.lb_Auflage.Name = "lb_Auflage";
            this.helpProvider.SetShowHelp(this.lb_Auflage, true);
            this.lb_Auflage.Size = new System.Drawing.Size(54, 19);
            this.lb_Auflage.TabIndex = 18;
            this.lb_Auflage.Text = "Auflage";
            // 
            // lb_Neupreis_Euro
            // 
            this.lb_Neupreis_Euro.AutoSize = true;
            this.lb_Neupreis_Euro.Location = new System.Drawing.Point(355, 208);
            this.lb_Neupreis_Euro.Margin = new System.Windows.Forms.Padding(3);
            this.lb_Neupreis_Euro.MinimumSize = new System.Drawing.Size(22, 24);
            this.lb_Neupreis_Euro.Name = "lb_Neupreis_Euro";
            this.lb_Neupreis_Euro.Size = new System.Drawing.Size(22, 24);
            this.lb_Neupreis_Euro.TabIndex = 1;
            this.lb_Neupreis_Euro.Text = "€";
            this.lb_Neupreis_Euro.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bt_Sprache_s
            // 
            this.bt_Sprache_s.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.bt_Sprache_s.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.helpProvider.SetHelpString(this.bt_Sprache_s, "Klicken sie auf diesen Button, um neue Sprachen hinzuzufügen.");
            this.bt_Sprache_s.Location = new System.Drawing.Point(355, 178);
            this.bt_Sprache_s.MaximumSize = new System.Drawing.Size(22, 24);
            this.bt_Sprache_s.MinimumSize = new System.Drawing.Size(22, 24);
            this.bt_Sprache_s.Name = "bt_Sprache_s";
            this.helpProvider.SetShowHelp(this.bt_Sprache_s, true);
            this.bt_Sprache_s.Size = new System.Drawing.Size(22, 24);
            this.bt_Sprache_s.TabIndex = 9;
            this.bt_Sprache_s.Text = "+";
            this.bt_Sprache_s.UseSelectable = true;
            this.bt_Sprache_s.Click += new System.EventHandler(this.bt_Sprache_s_Click_1);
            // 
            // lb_Neupreis
            // 
            this.lb_Neupreis.AutoSize = true;
            this.helpProvider.SetHelpString(this.lb_Neupreis, "Tragen sie den Neupreis ihres Buches hier ein.");
            this.lb_Neupreis.Location = new System.Drawing.Point(3, 238);
            this.lb_Neupreis.Margin = new System.Windows.Forms.Padding(3);
            this.lb_Neupreis.Name = "lb_Neupreis";
            this.helpProvider.SetShowHelp(this.lb_Neupreis, true);
            this.lb_Neupreis.Size = new System.Drawing.Size(64, 19);
            this.lb_Neupreis.TabIndex = 3;
            this.lb_Neupreis.Text = "Neupreis:";
            // 
            // tb_anzahl
            // 
            // 
            // 
            // 
            this.tb_anzahl.CustomButton.Image = null;
            this.tb_anzahl.CustomButton.Location = new System.Drawing.Point(180, 2);
            this.tb_anzahl.CustomButton.Margin = new System.Windows.Forms.Padding(2);
            this.tb_anzahl.CustomButton.Name = "";
            this.tb_anzahl.CustomButton.Size = new System.Drawing.Size(19, 19);
            this.tb_anzahl.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tb_anzahl.CustomButton.TabIndex = 1;
            this.tb_anzahl.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tb_anzahl.CustomButton.UseSelectable = true;
            this.tb_anzahl.CustomButton.Visible = false;
            this.tb_anzahl.Enabled = false;
            this.tb_anzahl.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.helpProvider.SetHelpString(this.tb_anzahl, "Tragen sie die Anzahl der Exemplare ihres Buches hier ein.");
            this.tb_anzahl.Lines = new string[0];
            this.tb_anzahl.Location = new System.Drawing.Point(147, 304);
            this.tb_anzahl.MaximumSize = new System.Drawing.Size(375, 24);
            this.tb_anzahl.MaxLength = 32767;
            this.tb_anzahl.MinimumSize = new System.Drawing.Size(150, 24);
            this.tb_anzahl.Name = "tb_anzahl";
            this.tb_anzahl.PasswordChar = '\0';
            this.tb_anzahl.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tb_anzahl.SelectedText = "";
            this.tb_anzahl.SelectionLength = 0;
            this.tb_anzahl.SelectionStart = 0;
            this.tb_anzahl.ShortcutsEnabled = true;
            this.helpProvider.SetShowHelp(this.tb_anzahl, true);
            this.tb_anzahl.Size = new System.Drawing.Size(202, 24);
            this.tb_anzahl.TabIndex = 48;
            this.tb_anzahl.UseSelectable = true;
            this.tb_anzahl.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tb_anzahl.WaterMarkFont = new System.Drawing.Font("Segoe UI", 10.5F);
            // 
            // dTP_Erscheinungsdatum
            // 
            this.helpProvider.SetHelpString(this.dTP_Erscheinungsdatum, "Wählen sie das Erscheinungsdatum ihres Buches hier ein.");
            this.dTP_Erscheinungsdatum.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dTP_Erscheinungsdatum.Location = new System.Drawing.Point(147, 268);
            this.dTP_Erscheinungsdatum.MaximumSize = new System.Drawing.Size(376, 30);
            this.dTP_Erscheinungsdatum.MinimumSize = new System.Drawing.Size(0, 29);
            this.dTP_Erscheinungsdatum.Name = "dTP_Erscheinungsdatum";
            this.helpProvider.SetShowHelp(this.dTP_Erscheinungsdatum, true);
            this.dTP_Erscheinungsdatum.Size = new System.Drawing.Size(202, 29);
            this.dTP_Erscheinungsdatum.TabIndex = 12;
            // 
            // tb_Auflage
            // 
            // 
            // 
            // 
            this.tb_Auflage.CustomButton.Image = null;
            this.tb_Auflage.CustomButton.Location = new System.Drawing.Point(180, 2);
            this.tb_Auflage.CustomButton.Margin = new System.Windows.Forms.Padding(2);
            this.tb_Auflage.CustomButton.Name = "";
            this.tb_Auflage.CustomButton.Size = new System.Drawing.Size(19, 19);
            this.tb_Auflage.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tb_Auflage.CustomButton.TabIndex = 1;
            this.tb_Auflage.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tb_Auflage.CustomButton.UseSelectable = true;
            this.tb_Auflage.CustomButton.Visible = false;
            this.tb_Auflage.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.helpProvider.SetHelpString(this.tb_Auflage, "Tragen sie die Auflage ihres Buches hier ein.");
            this.tb_Auflage.Lines = new string[0];
            this.tb_Auflage.Location = new System.Drawing.Point(147, 208);
            this.tb_Auflage.MaximumSize = new System.Drawing.Size(375, 24);
            this.tb_Auflage.MaxLength = 32767;
            this.tb_Auflage.MinimumSize = new System.Drawing.Size(150, 24);
            this.tb_Auflage.Name = "tb_Auflage";
            this.tb_Auflage.PasswordChar = '\0';
            this.tb_Auflage.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tb_Auflage.SelectedText = "";
            this.tb_Auflage.SelectionLength = 0;
            this.tb_Auflage.SelectionStart = 0;
            this.tb_Auflage.ShortcutsEnabled = true;
            this.helpProvider.SetShowHelp(this.tb_Auflage, true);
            this.tb_Auflage.Size = new System.Drawing.Size(202, 24);
            this.tb_Auflage.TabIndex = 10;
            this.tb_Auflage.UseSelectable = true;
            this.tb_Auflage.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tb_Auflage.WaterMarkFont = new System.Drawing.Font("Segoe UI", 10.5F);
            this.tb_Auflage.TextChanged += new System.EventHandler(this.tb_Auflage_TextChanged);
            // 
            // lb_Sprache
            // 
            this.lb_Sprache.AutoSize = true;
            this.helpProvider.SetHelpString(this.lb_Sprache, "Tragen sie die Sprache ihres Buches hier ein.");
            this.lb_Sprache.Location = new System.Drawing.Point(3, 178);
            this.lb_Sprache.Margin = new System.Windows.Forms.Padding(3);
            this.lb_Sprache.Name = "lb_Sprache";
            this.helpProvider.SetShowHelp(this.lb_Sprache, true);
            this.lb_Sprache.Size = new System.Drawing.Size(65, 19);
            this.lb_Sprache.TabIndex = 14;
            this.lb_Sprache.Text = "Sprache:*";
            // 
            // tb_Neupreis
            // 
            // 
            // 
            // 
            this.tb_Neupreis.CustomButton.Image = null;
            this.tb_Neupreis.CustomButton.Location = new System.Drawing.Point(180, 2);
            this.tb_Neupreis.CustomButton.Margin = new System.Windows.Forms.Padding(2);
            this.tb_Neupreis.CustomButton.Name = "";
            this.tb_Neupreis.CustomButton.Size = new System.Drawing.Size(19, 19);
            this.tb_Neupreis.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tb_Neupreis.CustomButton.TabIndex = 1;
            this.tb_Neupreis.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tb_Neupreis.CustomButton.UseSelectable = true;
            this.tb_Neupreis.CustomButton.Visible = false;
            this.tb_Neupreis.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.helpProvider.SetHelpString(this.tb_Neupreis, "Tragen sie den Neupreis ihres Buches hier ein.");
            this.tb_Neupreis.Lines = new string[0];
            this.tb_Neupreis.Location = new System.Drawing.Point(147, 238);
            this.tb_Neupreis.MaximumSize = new System.Drawing.Size(375, 24);
            this.tb_Neupreis.MaxLength = 32767;
            this.tb_Neupreis.MinimumSize = new System.Drawing.Size(150, 24);
            this.tb_Neupreis.Name = "tb_Neupreis";
            this.tb_Neupreis.PasswordChar = '\0';
            this.tb_Neupreis.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tb_Neupreis.SelectedText = "";
            this.tb_Neupreis.SelectionLength = 0;
            this.tb_Neupreis.SelectionStart = 0;
            this.tb_Neupreis.ShortcutsEnabled = true;
            this.helpProvider.SetShowHelp(this.tb_Neupreis, true);
            this.tb_Neupreis.Size = new System.Drawing.Size(202, 24);
            this.tb_Neupreis.TabIndex = 11;
            this.tb_Neupreis.UseSelectable = true;
            this.tb_Neupreis.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tb_Neupreis.WaterMarkFont = new System.Drawing.Font("Segoe UI", 10.5F);
            this.tb_Neupreis.TextChanged += new System.EventHandler(this.tb_Neupreis_TextChanged);
            this.tb_Neupreis.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_Neupreis_KeyPress);
            this.tb_Neupreis.Leave += new System.EventHandler(this.tb_Neupreis_Leave);
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.Color.White;
            this.comboBox1.DataRowView = true;
            this.comboBox1.DropDownHeight = 1;
            this.comboBox1.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.HighlightColor = System.Drawing.Color.Gray;
            this.comboBox1.IntegralHeight = false;
            this.comboBox1.ItemHeight = 18;
            this.comboBox1.Location = new System.Drawing.Point(331, 88);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.comboBox1.Size = new System.Drawing.Size(18, 24);
            this.comboBox1.TabIndex = 53;
            this.comboBox1.Click += new System.EventHandler(this.comboBox1_Click);
            // 
            // rb_Update_Buch
            // 
            this.rb_Update_Buch.AutoSize = true;
            this.rb_Update_Buch.FontSize = MetroFramework.MetroCheckBoxSize.Medium;
            this.rb_Update_Buch.FontWeight = MetroFramework.MetroCheckBoxWeight.Light;
            this.helpProvider.SetHelpString(this.rb_Update_Buch, "Klicken sie hier, um ein vorhandenes Buch zu bearbeiten.");
            this.rb_Update_Buch.Location = new System.Drawing.Point(112, 3);
            this.rb_Update_Buch.Margin = new System.Windows.Forms.Padding(3, 3, 16, 3);
            this.rb_Update_Buch.Name = "rb_Update_Buch";
            this.helpProvider.SetShowHelp(this.rb_Update_Buch, true);
            this.rb_Update_Buch.Size = new System.Drawing.Size(88, 19);
            this.rb_Update_Buch.TabIndex = 43;
            this.rb_Update_Buch.Text = "Bearbeiten";
            this.rb_Update_Buch.UseSelectable = true;
            this.rb_Update_Buch.CheckedChanged += new System.EventHandler(this.rb_Edit_CheckedChanged);
            // 
            // rb_Add_Buch
            // 
            this.rb_Add_Buch.AutoSize = true;
            this.rb_Add_Buch.Checked = true;
            this.rb_Add_Buch.FontSize = MetroFramework.MetroCheckBoxSize.Medium;
            this.rb_Add_Buch.FontWeight = MetroFramework.MetroCheckBoxWeight.Light;
            this.helpProvider.SetHelpString(this.rb_Add_Buch, "Klicken sie hier, um ein neues Buch hinzuzufügen.");
            this.rb_Add_Buch.Location = new System.Drawing.Point(3, 3);
            this.rb_Add_Buch.Margin = new System.Windows.Forms.Padding(3, 3, 16, 3);
            this.rb_Add_Buch.Name = "rb_Add_Buch";
            this.helpProvider.SetShowHelp(this.rb_Add_Buch, true);
            this.rb_Add_Buch.Size = new System.Drawing.Size(90, 19);
            this.rb_Add_Buch.TabIndex = 41;
            this.rb_Add_Buch.TabStop = true;
            this.rb_Add_Buch.Text = "Hinzufügen";
            this.rb_Add_Buch.UseSelectable = true;
            this.rb_Add_Buch.CheckedChanged += new System.EventHandler(this.rb_Neubuch_CheckedChanged);
            // 
            // rb_Delete_Buch
            // 
            this.rb_Delete_Buch.AutoSize = true;
            this.rb_Delete_Buch.FontSize = MetroFramework.MetroCheckBoxSize.Medium;
            this.rb_Delete_Buch.FontWeight = MetroFramework.MetroCheckBoxWeight.Light;
            this.helpProvider.SetHelpString(this.rb_Delete_Buch, "Klicken sie hier, um ein vorhandenes Buch zu löschen.");
            this.rb_Delete_Buch.Location = new System.Drawing.Point(219, 3);
            this.rb_Delete_Buch.Margin = new System.Windows.Forms.Padding(3, 3, 16, 3);
            this.rb_Delete_Buch.Name = "rb_Delete_Buch";
            this.helpProvider.SetShowHelp(this.rb_Delete_Buch, true);
            this.rb_Delete_Buch.Size = new System.Drawing.Size(80, 19);
            this.rb_Delete_Buch.TabIndex = 42;
            this.rb_Delete_Buch.Text = "Entfernen";
            this.rb_Delete_Buch.UseSelectable = true;
            this.rb_Delete_Buch.CheckedChanged += new System.EventHandler(this.rb_Delete_CheckedChanged);
            // 
            // bt_Autor_s
            // 
            this.bt_Autor_s.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.bt_Autor_s.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.helpProvider.SetHelpString(this.bt_Autor_s, "Klicken sie auf diesen Button, um neue Autoren hinzuzufügen.");
            this.bt_Autor_s.Location = new System.Drawing.Point(355, 88);
            this.bt_Autor_s.MaximumSize = new System.Drawing.Size(22, 24);
            this.bt_Autor_s.MinimumSize = new System.Drawing.Size(22, 24);
            this.bt_Autor_s.Name = "bt_Autor_s";
            this.helpProvider.SetShowHelp(this.bt_Autor_s, true);
            this.bt_Autor_s.Size = new System.Drawing.Size(22, 24);
            this.bt_Autor_s.TabIndex = 3;
            this.bt_Autor_s.Text = "+";
            this.bt_Autor_s.UseSelectable = true;
            this.bt_Autor_s.Click += new System.EventHandler(this.bt_Autor_s_Click);
            // 
            // lb_Verlag
            // 
            this.lb_Verlag.AutoSize = true;
            this.helpProvider.SetHelpKeyword(this.lb_Verlag, "Tragen sie den Verlag ihres Buches hier ein.");
            this.lb_Verlag.Location = new System.Drawing.Point(3, 118);
            this.lb_Verlag.Margin = new System.Windows.Forms.Padding(3);
            this.lb_Verlag.Name = "lb_Verlag";
            this.helpProvider.SetShowHelp(this.lb_Verlag, true);
            this.lb_Verlag.Size = new System.Drawing.Size(55, 19);
            this.lb_Verlag.TabIndex = 10;
            this.lb_Verlag.Text = "Verlag:*";
            // 
            // lb_Autor
            // 
            this.lb_Autor.AutoSize = true;
            this.helpProvider.SetHelpString(this.lb_Autor, "Tragen sie den Autor ihres Buches hier ein.");
            this.lb_Autor.Location = new System.Drawing.Point(3, 88);
            this.lb_Autor.Margin = new System.Windows.Forms.Padding(3);
            this.lb_Autor.Name = "lb_Autor";
            this.helpProvider.SetShowHelp(this.lb_Autor, true);
            this.lb_Autor.Size = new System.Drawing.Size(49, 19);
            this.lb_Autor.TabIndex = 8;
            this.lb_Autor.Text = "Autor:\'";
            // 
            // bt_Verlag_s
            // 
            this.bt_Verlag_s.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.bt_Verlag_s.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.helpProvider.SetHelpString(this.bt_Verlag_s, "Klicken sie auf diesen Button, um neue Verläge hinzuzufügen.");
            this.bt_Verlag_s.Location = new System.Drawing.Point(355, 118);
            this.bt_Verlag_s.MaximumSize = new System.Drawing.Size(22, 24);
            this.bt_Verlag_s.MinimumSize = new System.Drawing.Size(22, 24);
            this.bt_Verlag_s.Name = "bt_Verlag_s";
            this.helpProvider.SetShowHelp(this.bt_Verlag_s, true);
            this.bt_Verlag_s.Size = new System.Drawing.Size(22, 24);
            this.bt_Verlag_s.TabIndex = 5;
            this.bt_Verlag_s.Text = "+";
            this.bt_Verlag_s.UseSelectable = true;
            this.bt_Verlag_s.Click += new System.EventHandler(this.bt_Verlag_s_Click);
            // 
            // bt_Genre_s
            // 
            this.bt_Genre_s.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.bt_Genre_s.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.helpProvider.SetHelpString(this.bt_Genre_s, "Klicken sie auf diesen Button, um neue Genres hinzuzufügen.");
            this.bt_Genre_s.Location = new System.Drawing.Point(355, 148);
            this.bt_Genre_s.MaximumSize = new System.Drawing.Size(22, 24);
            this.bt_Genre_s.MinimumSize = new System.Drawing.Size(22, 24);
            this.bt_Genre_s.Name = "bt_Genre_s";
            this.helpProvider.SetShowHelp(this.bt_Genre_s, true);
            this.bt_Genre_s.Size = new System.Drawing.Size(22, 24);
            this.bt_Genre_s.TabIndex = 7;
            this.bt_Genre_s.Text = "+";
            this.bt_Genre_s.UseSelectable = true;
            this.bt_Genre_s.Click += new System.EventHandler(this.bt_Genre_s_Click);
            // 
            // lb_Genre
            // 
            this.lb_Genre.AutoSize = true;
            this.helpProvider.SetHelpString(this.lb_Genre, "Tragen sie das Genre ihres Buches hier ein.");
            this.lb_Genre.Location = new System.Drawing.Point(3, 148);
            this.lb_Genre.Margin = new System.Windows.Forms.Padding(3);
            this.lb_Genre.Name = "lb_Genre";
            this.helpProvider.SetShowHelp(this.lb_Genre, true);
            this.lb_Genre.Size = new System.Drawing.Size(53, 19);
            this.lb_Genre.TabIndex = 5;
            this.lb_Genre.Text = "Genre:*";
            // 
            // tb_Titel
            // 
            // 
            // 
            // 
            this.tb_Titel.CustomButton.Image = null;
            this.tb_Titel.CustomButton.Location = new System.Drawing.Point(180, 2);
            this.tb_Titel.CustomButton.Margin = new System.Windows.Forms.Padding(2);
            this.tb_Titel.CustomButton.Name = "";
            this.tb_Titel.CustomButton.Size = new System.Drawing.Size(19, 19);
            this.tb_Titel.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tb_Titel.CustomButton.TabIndex = 1;
            this.tb_Titel.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tb_Titel.CustomButton.UseSelectable = true;
            this.tb_Titel.CustomButton.Visible = false;
            this.tb_Titel.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.helpProvider.SetHelpString(this.tb_Titel, "Tragen sie den Titel ihres Buches hier ein.");
            this.tb_Titel.Lines = new string[0];
            this.tb_Titel.Location = new System.Drawing.Point(147, 58);
            this.tb_Titel.MaximumSize = new System.Drawing.Size(375, 24);
            this.tb_Titel.MaxLength = 32767;
            this.tb_Titel.MinimumSize = new System.Drawing.Size(150, 24);
            this.tb_Titel.Name = "tb_Titel";
            this.tb_Titel.PasswordChar = '\0';
            this.tb_Titel.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tb_Titel.SelectedText = "";
            this.tb_Titel.SelectionLength = 0;
            this.tb_Titel.SelectionStart = 0;
            this.tb_Titel.ShortcutsEnabled = true;
            this.helpProvider.SetShowHelp(this.tb_Titel, true);
            this.tb_Titel.Size = new System.Drawing.Size(202, 24);
            this.tb_Titel.TabIndex = 1;
            this.tb_Titel.UseSelectable = true;
            this.tb_Titel.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tb_Titel.WaterMarkFont = new System.Drawing.Font("Segoe UI", 10.5F);
            this.tb_Titel.TextChanged += new System.EventHandler(this.tb_Titel_TextChanged);
            this.tb_Titel.Click += new System.EventHandler(this.tb_Titel_Click);
            // 
            // lb_Titel
            // 
            this.lb_Titel.AutoSize = true;
            this.helpProvider.SetHelpString(this.lb_Titel, "Tragen sie den Titel ihres Buches hier ein.");
            this.lb_Titel.Location = new System.Drawing.Point(3, 58);
            this.lb_Titel.Margin = new System.Windows.Forms.Padding(3);
            this.lb_Titel.Name = "lb_Titel";
            this.helpProvider.SetShowHelp(this.lb_Titel, true);
            this.lb_Titel.Size = new System.Drawing.Size(42, 19);
            this.lb_Titel.TabIndex = 3;
            this.lb_Titel.Text = "Titel:*";
            // 
            // tb_ISBN
            // 
            // 
            // 
            // 
            this.tb_ISBN.CustomButton.Image = null;
            this.tb_ISBN.CustomButton.Location = new System.Drawing.Point(180, 2);
            this.tb_ISBN.CustomButton.Margin = new System.Windows.Forms.Padding(2);
            this.tb_ISBN.CustomButton.Name = "";
            this.tb_ISBN.CustomButton.Size = new System.Drawing.Size(19, 19);
            this.tb_ISBN.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tb_ISBN.CustomButton.TabIndex = 1;
            this.tb_ISBN.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tb_ISBN.CustomButton.UseSelectable = true;
            this.tb_ISBN.CustomButton.Visible = false;
            this.tb_ISBN.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.tb_ISBN.Lines = new string[0];
            this.tb_ISBN.Location = new System.Drawing.Point(147, 28);
            this.tb_ISBN.MaximumSize = new System.Drawing.Size(375, 24);
            this.tb_ISBN.MaxLength = 32767;
            this.tb_ISBN.MinimumSize = new System.Drawing.Size(150, 24);
            this.tb_ISBN.Name = "tb_ISBN";
            this.tb_ISBN.PasswordChar = '\0';
            this.tb_ISBN.PromptText = "123-0123456789";
            this.tb_ISBN.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tb_ISBN.SelectedText = "";
            this.tb_ISBN.SelectionLength = 0;
            this.tb_ISBN.SelectionStart = 0;
            this.tb_ISBN.ShortcutsEnabled = true;
            this.tb_ISBN.Size = new System.Drawing.Size(202, 24);
            this.tb_ISBN.TabIndex = 0;
            this.tb_ISBN.UseSelectable = true;
            this.tb_ISBN.WaterMark = "123-0123456789";
            this.tb_ISBN.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tb_ISBN.WaterMarkFont = new System.Drawing.Font("Segoe UI", 10.5F);
            this.tb_ISBN.TextChanged += new System.EventHandler(this.tb_ISBN_TextChanged);
            this.tb_ISBN.Click += new System.EventHandler(this.tb_ISBN_Click);
            this.tb_ISBN.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tb_ISBN_KeyDown);
            this.tb_ISBN.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_ISBN_KeyPress);
            // 
            // lb_ISBN
            // 
            this.lb_ISBN.AutoSize = true;
            this.helpProvider.SetHelpString(this.lb_ISBN, "Tragen sie hier die ISBN-13 ein, um das gewünschte Buch zu laden.");
            this.lb_ISBN.Location = new System.Drawing.Point(3, 28);
            this.lb_ISBN.Margin = new System.Windows.Forms.Padding(3);
            this.lb_ISBN.Name = "lb_ISBN";
            this.helpProvider.SetShowHelp(this.lb_ISBN, true);
            this.lb_ISBN.Size = new System.Drawing.Size(46, 19);
            this.lb_ISBN.TabIndex = 1;
            this.lb_ISBN.Text = "ISBN:*";
            // 
            // button1
            // 
            this.button1.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.button1.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.helpProvider.SetHelpString(this.button1, "Wenn sie eine ISBN eingetragen haben, können sie auf diesen Stern klicken, um res" +
        "tliche Buchinformationen automatisch ausfüllen zu lassen.");
            this.button1.Location = new System.Drawing.Point(355, 28);
            this.button1.MaximumSize = new System.Drawing.Size(22, 24);
            this.button1.MinimumSize = new System.Drawing.Size(22, 24);
            this.button1.Name = "button1";
            this.helpProvider.SetShowHelp(this.button1, true);
            this.button1.Size = new System.Drawing.Size(22, 24);
            this.button1.TabIndex = 50;
            this.button1.Text = "*";
            this.button1.UseSelectable = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.White;
            this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox2.Location = new System.Drawing.Point(0, 0);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(676, 446);
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
            this.Grid_Buch.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Grid_Buch.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Grid_Buch.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.Grid_Buch.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI Semibold", 10.5F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Grid_Buch.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.Grid_Buch.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Grid_Buch.ContextMenuStrip = this.contextMenuStrip1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Grid_Buch.DefaultCellStyle = dataGridViewCellStyle2;
            this.Grid_Buch.EnableHeadersVisualStyles = false;
            this.Grid_Buch.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.Grid_Buch.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.helpProvider.SetHelpString(this.Grid_Buch, "In diesem Feld werden all ihre Bücher angezeigt.");
            this.Grid_Buch.Location = new System.Drawing.Point(413, 52);
            this.Grid_Buch.Name = "Grid_Buch";
            this.Grid_Buch.ReadOnly = true;
            this.Grid_Buch.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Grid_Buch.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.Grid_Buch.RowHeadersVisible = false;
            this.Grid_Buch.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.Grid_Buch.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.helpProvider.SetShowHelp(this.Grid_Buch, true);
            this.Grid_Buch.Size = new System.Drawing.Size(676, 446);
            this.Grid_Buch.TabIndex = 0;
            this.Grid_Buch.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Grid_Buch_CellDoubleClick);
            this.Grid_Buch.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.Grid_Buch_CellMouseDown);
            this.Grid_Buch.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Grid_Buch_MouseDown);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(40, 40);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ladenToolStripMenuItem,
            this.entfernenToolStripMenuItem,
            this.exemplareToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(129, 70);
            // 
            // ladenToolStripMenuItem
            // 
            this.ladenToolStripMenuItem.Name = "ladenToolStripMenuItem";
            this.ladenToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.ladenToolStripMenuItem.Text = "Laden";
            this.ladenToolStripMenuItem.Click += new System.EventHandler(this.ladenToolStripMenuItem_Click);
            // 
            // entfernenToolStripMenuItem
            // 
            this.entfernenToolStripMenuItem.Name = "entfernenToolStripMenuItem";
            this.entfernenToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.entfernenToolStripMenuItem.Text = "Entfernen";
            this.entfernenToolStripMenuItem.Click += new System.EventHandler(this.entfernenToolStripMenuItem_Click);
            // 
            // exemplareToolStripMenuItem
            // 
            this.exemplareToolStripMenuItem.Name = "exemplareToolStripMenuItem";
            this.exemplareToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.exemplareToolStripMenuItem.Text = "Exemplare";
            this.exemplareToolStripMenuItem.Click += new System.EventHandler(this.exemplareToolStripMenuItem_Click);
            // 
            // bt_Schliessen
            // 
            this.bt_Schliessen.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.bt_Schliessen.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.bt_Schliessen.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.helpProvider.SetHelpString(this.bt_Schliessen, "Schließen sie das akuelle Fenster.");
            this.bt_Schliessen.Location = new System.Drawing.Point(827, 504);
            this.bt_Schliessen.MaximumSize = new System.Drawing.Size(375, 24);
            this.bt_Schliessen.MinimumSize = new System.Drawing.Size(262, 24);
            this.bt_Schliessen.Name = "bt_Schliessen";
            this.helpProvider.SetShowHelp(this.bt_Schliessen, true);
            this.bt_Schliessen.Size = new System.Drawing.Size(262, 24);
            this.bt_Schliessen.TabIndex = 1;
            this.bt_Schliessen.Text = "Schließen";
            this.bt_Schliessen.UseSelectable = true;
            // 
            // bt_Excel
            // 
            this.bt_Excel.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.bt_Excel.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.helpProvider.SetHelpString(this.bt_Excel, "Exportieren sie ihre Bücherdaten in eine Exceltabelle.");
            this.bt_Excel.Location = new System.Drawing.Point(413, 504);
            this.bt_Excel.MaximumSize = new System.Drawing.Size(375, 24);
            this.bt_Excel.MinimumSize = new System.Drawing.Size(262, 24);
            this.bt_Excel.Name = "bt_Excel";
            this.helpProvider.SetShowHelp(this.bt_Excel, true);
            this.bt_Excel.Size = new System.Drawing.Size(262, 24);
            this.bt_Excel.TabIndex = 1;
            this.bt_Excel.Text = "Exportieren";
            this.bt_Excel.UseSelectable = true;
            this.bt_Excel.Click += new System.EventHandler(this.bt_Excel_Click);
            // 
            // gb_zoom
            // 
            this.gb_zoom.Controls.Add(this.pictureBox2);
            this.gb_zoom.HorizontalScrollbarBarColor = true;
            this.gb_zoom.HorizontalScrollbarHighlightOnWheel = false;
            this.gb_zoom.HorizontalScrollbarSize = 8;
            this.gb_zoom.Location = new System.Drawing.Point(413, 52);
            this.gb_zoom.Name = "gb_zoom";
            this.gb_zoom.Size = new System.Drawing.Size(676, 446);
            this.gb_zoom.TabIndex = 51;
            this.gb_zoom.VerticalScrollbarBarColor = true;
            this.gb_zoom.VerticalScrollbarHighlightOnWheel = false;
            this.gb_zoom.VerticalScrollbarSize = 8;
            // 
            // cb_Autor
            // 
            this.cb_Autor.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cb_Autor.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cb_Autor.DataRowView = true;
            this.cb_Autor.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cb_Autor.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.cb_Autor.ForeColor = System.Drawing.Color.Black;
            this.cb_Autor.FormattingEnabled = true;
            this.helpProvider.SetHelpString(this.cb_Autor, "Tragen sie den Autor ihres Buches hier ein.");
            this.cb_Autor.HighlightColor = System.Drawing.Color.DeepSkyBlue;
            this.cb_Autor.ItemHeight = 18;
            this.cb_Autor.Location = new System.Drawing.Point(147, 88);
            this.cb_Autor.Name = "cb_Autor";
            this.helpProvider.SetShowHelp(this.cb_Autor, true);
            this.cb_Autor.Size = new System.Drawing.Size(202, 24);
            this.cb_Autor.TabIndex = 2;
            this.cb_Autor.TextChanged += new System.EventHandler(this.cb_Autor_TextChanged);
            // 
            // cb_Verlag
            // 
            this.cb_Verlag.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cb_Verlag.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cb_Verlag.DataRowView = true;
            this.cb_Verlag.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cb_Verlag.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.cb_Verlag.ForeColor = System.Drawing.Color.Black;
            this.cb_Verlag.FormattingEnabled = true;
            this.helpProvider.SetHelpString(this.cb_Verlag, "Tragen sie den Verlag ihres Buches hier ein.");
            this.cb_Verlag.HighlightColor = System.Drawing.Color.DeepSkyBlue;
            this.cb_Verlag.ItemHeight = 18;
            this.cb_Verlag.Location = new System.Drawing.Point(147, 118);
            this.cb_Verlag.Name = "cb_Verlag";
            this.helpProvider.SetShowHelp(this.cb_Verlag, true);
            this.cb_Verlag.Size = new System.Drawing.Size(202, 24);
            this.cb_Verlag.TabIndex = 4;
            this.cb_Verlag.TextChanged += new System.EventHandler(this.cb_Verlag_TextChanged);
            // 
            // cb_Genre
            // 
            this.cb_Genre.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cb_Genre.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cb_Genre.DataRowView = true;
            this.cb_Genre.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cb_Genre.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.cb_Genre.ForeColor = System.Drawing.Color.Black;
            this.cb_Genre.FormattingEnabled = true;
            this.helpProvider.SetHelpString(this.cb_Genre, "Tragen sie das Genre ihres Buches hier ein.");
            this.cb_Genre.HighlightColor = System.Drawing.Color.DeepSkyBlue;
            this.cb_Genre.ItemHeight = 18;
            this.cb_Genre.Location = new System.Drawing.Point(147, 148);
            this.cb_Genre.Name = "cb_Genre";
            this.helpProvider.SetShowHelp(this.cb_Genre, true);
            this.cb_Genre.Size = new System.Drawing.Size(202, 24);
            this.cb_Genre.TabIndex = 6;
            this.cb_Genre.TextChanged += new System.EventHandler(this.cb_Genre_TextChanged);
            // 
            // cb_Sprache
            // 
            this.cb_Sprache.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cb_Sprache.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cb_Sprache.DataRowView = true;
            this.cb_Sprache.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cb_Sprache.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.cb_Sprache.ForeColor = System.Drawing.Color.Black;
            this.cb_Sprache.FormattingEnabled = true;
            this.helpProvider.SetHelpKeyword(this.cb_Sprache, "Tragen sie die Sprache ihres Buches hier ein.");
            this.cb_Sprache.HighlightColor = System.Drawing.Color.DeepSkyBlue;
            this.cb_Sprache.ItemHeight = 18;
            this.cb_Sprache.Location = new System.Drawing.Point(147, 178);
            this.cb_Sprache.Name = "cb_Sprache";
            this.helpProvider.SetShowHelp(this.cb_Sprache, true);
            this.cb_Sprache.Size = new System.Drawing.Size(202, 24);
            this.cb_Sprache.TabIndex = 8;
            this.cb_Sprache.TextChanged += new System.EventHandler(this.cb_Sprache_TextChanged);
            // 
            // metroPanel1
            // 
            this.metroPanel1.Controls.Add(this.checkedListBox1);
            this.metroPanel1.Controls.Add(this.checkbox_autor);
            this.metroPanel1.Controls.Add(this.rTB_1);
            this.metroPanel1.Controls.Add(this.bt_clear_buecher);
            this.metroPanel1.Controls.Add(this.bt_speichern_buecher);
            this.metroPanel1.Controls.Add(this.lb_anzahl);
            this.metroPanel1.Controls.Add(this.pictureBox1);
            this.metroPanel1.Controls.Add(this.bt_pic_delete);
            this.metroPanel1.Controls.Add(this.bt_picture);
            this.metroPanel1.Controls.Add(this.comboBox1);
            this.metroPanel1.Controls.Add(this.tb_anzahl);
            this.metroPanel1.Controls.Add(this.rb_Add_Buch);
            this.metroPanel1.Controls.Add(this.rb_Update_Buch);
            this.metroPanel1.Controls.Add(this.rb_Delete_Buch);
            this.metroPanel1.Controls.Add(this.button1);
            this.metroPanel1.Controls.Add(this.lb_Erscheinungsdatum);
            this.metroPanel1.Controls.Add(this.lb_ISBN);
            this.metroPanel1.Controls.Add(this.lb_Neupreis);
            this.metroPanel1.Controls.Add(this.lb_Auflage);
            this.metroPanel1.Controls.Add(this.tb_ISBN);
            this.metroPanel1.Controls.Add(this.lb_Neupreis_Euro);
            this.metroPanel1.Controls.Add(this.dTP_Erscheinungsdatum);
            this.metroPanel1.Controls.Add(this.bt_Sprache_s);
            this.metroPanel1.Controls.Add(this.tb_Titel);
            this.metroPanel1.Controls.Add(this.lb_Sprache);
            this.metroPanel1.Controls.Add(this.cb_Autor);
            this.metroPanel1.Controls.Add(this.tb_Auflage);
            this.metroPanel1.Controls.Add(this.lb_Titel);
            this.metroPanel1.Controls.Add(this.cb_Verlag);
            this.metroPanel1.Controls.Add(this.cb_Genre);
            this.metroPanel1.Controls.Add(this.tb_Neupreis);
            this.metroPanel1.Controls.Add(this.bt_Autor_s);
            this.metroPanel1.Controls.Add(this.cb_Sprache);
            this.metroPanel1.Controls.Add(this.bt_Verlag_s);
            this.metroPanel1.Controls.Add(this.bt_Genre_s);
            this.metroPanel1.Controls.Add(this.lb_Genre);
            this.metroPanel1.Controls.Add(this.lb_Verlag);
            this.metroPanel1.Controls.Add(this.lb_Autor);
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 8;
            this.metroPanel1.Location = new System.Drawing.Point(20, 52);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(387, 476);
            this.metroPanel1.TabIndex = 52;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 8;
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.HighlightColor = System.Drawing.Color.Green;
            this.checkedListBox1.Location = new System.Drawing.Point(147, 111);
            this.checkedListBox1.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(202, 94);
            this.checkedListBox1.TabIndex = 51;
            this.checkedListBox1.Visible = false;
            this.checkedListBox1.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.checkedListBox1_ItemCheck);
            // 
            // timer1
            // 
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // metroProgressBar1
            // 
            this.metroProgressBar1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.metroProgressBar1.Location = new System.Drawing.Point(0, 0);
            this.metroProgressBar1.Margin = new System.Windows.Forms.Padding(2);
            this.metroProgressBar1.Name = "metroProgressBar1";
            this.metroProgressBar1.Size = new System.Drawing.Size(1100, 5);
            this.metroProgressBar1.TabIndex = 53;
            // 
            // w_s_buecher
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1100, 550);
            this.Controls.Add(this.metroProgressBar1);
            this.Controls.Add(this.metroPanel1);
            this.Controls.Add(this.gb_zoom);
            this.Controls.Add(this.bt_Excel);
            this.Controls.Add(this.bt_Schliessen);
            this.Controls.Add(this.Grid_Buch);
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "w_s_buecher";
            this.Padding = new System.Windows.Forms.Padding(8, 60, 8, 8);
            this.Resizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Bücher";
            this.Activated += new System.EventHandler(this.w_s_buecher_Activated);
            this.Click += new System.EventHandler(this.w_s_buecher_Click);
            ((System.ComponentModel.ISupportInitialize)(this.tsspracheBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.biboVerwaltungDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bibo_VerwaltungDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Grid_Buch)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.gb_zoom.ResumeLayout(false);
            this.metroPanel1.ResumeLayout(false);
            this.metroPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource biboVerwaltungDataSetBindingSource;
        private Bibo_VerwaltungDataSet bibo_VerwaltungDataSet;
        private System.Windows.Forms.BindingSource tsspracheBindingSource;
        private Bibo_VerwaltungDataSetTableAdapters.t_s_spracheTableAdapter t_s_spracheTableAdapter;
        private MetroFramework.Controls.MetroButton bt_speichern_buecher;
        private MetroFramework.Controls.MetroDateTime dTP_Erscheinungsdatum;
        private MetroFramework.Controls.MetroLabel lb_Erscheinungsdatum;
        private MetroFramework.Controls.MetroTextBox tb_Auflage;
        private MetroFramework.Controls.MetroLabel lb_Auflage;
        private MetroFramework.Controls.MetroLabel lb_Neupreis_Euro;
        private MetroFramework.Controls.MetroButton bt_Sprache_s;
        private AdvancedComboBox cb_Sprache;
        private MetroFramework.Controls.MetroLabel lb_Sprache;
        private MetroFramework.Controls.MetroButton bt_Autor_s;
        private AdvancedComboBox cb_Autor;
        private MetroFramework.Controls.MetroLabel lb_Verlag;
        private MetroFramework.Controls.MetroLabel lb_Autor;
        private MetroFramework.Controls.MetroButton bt_Verlag_s;
        private MetroFramework.Controls.MetroButton bt_Genre_s;
        private AdvancedComboBox cb_Verlag;
        private AdvancedComboBox cb_Genre;
        private MetroFramework.Controls.MetroLabel lb_Genre;
        private MetroFramework.Controls.MetroTextBox tb_Neupreis;
        private MetroFramework.Controls.MetroLabel lb_Neupreis;
        private MetroFramework.Controls.MetroTextBox tb_Titel;
        private MetroFramework.Controls.MetroLabel lb_Titel;
        private MetroFramework.Controls.MetroLabel lb_ISBN;
        private MetroFramework.Controls.MetroButton bt_clear_buecher;
        private MetroFramework.Controls.MetroGrid Grid_Buch;
        private MetroFramework.Controls.MetroRadioButton rb_Add_Buch;
        private MetroFramework.Controls.MetroRadioButton rb_Update_Buch;
        private MetroFramework.Controls.MetroRadioButton rb_Delete_Buch;
        public MetroFramework.Controls.MetroTextBox tb_ISBN;
        private MetroFramework.Controls.MetroButton bt_Schliessen;
        private MetroFramework.Controls.MetroButton bt_Excel;
        private MetroFramework.Controls.MetroButton bt_picture;
        private System.Windows.Forms.PictureBox pictureBox1;
        private MetroFramework.Controls.MetroButton bt_pic_delete;
        private MetroFramework.Controls.MetroTextBox tb_anzahl;
        private MetroFramework.Controls.MetroLabel lb_anzahl;
        private System.Windows.Forms.PictureBox pictureBox2;
        private MetroFramework.Controls.MetroPanel gb_zoom;
        private MetroFramework.Controls.MetroButton button1;
        private MetroFramework.Controls.MetroCheckBox checkbox_autor;
        private AdvancedCheckedListBox checkedListBox1;
        private MetroFramework.Controls.MetroTextBox rTB_1;
        private System.Windows.Forms.HelpProvider helpProvider;
        private MetroFramework.Controls.MetroContextMenu contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ladenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem entfernenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exemplareToolStripMenuItem;
        private AdvancedComboBox comboBox1;
        private MetroFramework.Controls.MetroPanel metroPanel1;
        private System.Windows.Forms.Timer timer1;
        private MetroFramework.Controls.MetroProgressBar metroProgressBar1;
    }
}