using Bibo_Verwaltung.Helper;

namespace Bibo_Verwaltung
{
    partial class Form_Books
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Books));
            this.tsspracheBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mtb_Nachricht = new MetroFramework.Controls.MetroTextBox();
            this.checkbox_autor = new MetroFramework.Controls.MetroCheckBox();
            this.bt_clear_buecher = new MetroFramework.Controls.MetroButton();
            this.btSubmit = new MetroFramework.Controls.MetroButton();
            this.bt_pic_delete = new MetroFramework.Controls.MetroButton();
            this.bt_picture = new MetroFramework.Controls.MetroButton();
            this.lb_Erscheinungsdatum = new MetroFramework.Controls.MetroLabel();
            this.lb_Auflage = new MetroFramework.Controls.MetroLabel();
            this.bt_Sprache_s = new MetroFramework.Controls.MetroButton();
            this.lb_Neupreis = new MetroFramework.Controls.MetroLabel();
            this.tb_Auflage = new MetroFramework.Controls.MetroTextBox();
            this.lb_Sprache = new MetroFramework.Controls.MetroLabel();
            this.tb_Neupreis = new MetroFramework.Controls.MetroTextBox();
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
            this.gridViewBook = new MetroFramework.Controls.MetroGrid();
            this.contextMenuStrip1 = new MetroFramework.Controls.MetroContextMenu(this.components);
            this.ladenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.entfernenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exemplareToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bt_Schliessen = new MetroFramework.Controls.MetroButton();
            this.bt_Excel = new MetroFramework.Controls.MetroButton();
            this.gb_zoom = new MetroFramework.Controls.MetroPanel();
            this.picBox_Gross = new System.Windows.Forms.PictureBox();
            this.metroProgressSpinner1 = new MetroFramework.Controls.MetroProgressSpinner();
            this.helpProvider = new System.Windows.Forms.HelpProvider();
            this.mtb_Import = new MetroFramework.Controls.MetroButton();
            this.picBox_Klein = new System.Windows.Forms.PictureBox();
            this.cb_Genre = new Bibo_Verwaltung.AdvancedComboBox();
            this.cb_Verlag = new Bibo_Verwaltung.AdvancedComboBox();
            this.cb_Sprache = new Bibo_Verwaltung.AdvancedComboBox();
            this.cb_Autor = new Bibo_Verwaltung.AdvancedComboBox();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.p_autor = new Bibo_Verwaltung.TransparentPanel();
            this.checkedListBox1 = new Bibo_Verwaltung.AdvancedCheckedListBox();
            this.comboBox1 = new Bibo_Verwaltung.AdvancedComboBox();
            this.p_sprache = new Bibo_Verwaltung.TransparentPanel();
            this.dTP_Erscheinungsdatum = new MetroFramework.Controls.MetroDateTime();
            this.bt_print = new MetroFramework.Controls.MetroButton();
            this.p_verlag = new Bibo_Verwaltung.TransparentPanel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.p_genre = new Bibo_Verwaltung.TransparentPanel();
            this.tb_barcodePrinted = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.tb_barcodeAdd = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.tb_neu = new MetroFramework.Controls.MetroTextBox();
            this.rb_search = new MetroFramework.Controls.MetroRadioButton();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.metroPanel2 = new MetroFramework.Controls.MetroPanel();
            this.bt_exemplar = new MetroFramework.Controls.MetroButton();
            this.metroToolTip1 = new MetroFramework.Components.MetroToolTip();
            this.styleManagerBooks = new MetroFramework.Components.MetroStyleManager(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.tsspracheBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewBook)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.gb_zoom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_Gross)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_Klein)).BeginInit();
            this.metroPanel1.SuspendLayout();
            this.metroPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.styleManagerBooks)).BeginInit();
            this.SuspendLayout();
            // 
            // mtb_Nachricht
            // 
            this.mtb_Nachricht.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            // 
            // 
            // 
            this.mtb_Nachricht.CustomButton.Image = null;
            this.mtb_Nachricht.CustomButton.Location = new System.Drawing.Point(159, 2);
            this.mtb_Nachricht.CustomButton.Margin = new System.Windows.Forms.Padding(2);
            this.mtb_Nachricht.CustomButton.Name = "";
            this.mtb_Nachricht.CustomButton.Size = new System.Drawing.Size(49, 49);
            this.mtb_Nachricht.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.mtb_Nachricht.CustomButton.TabIndex = 1;
            this.mtb_Nachricht.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.mtb_Nachricht.CustomButton.UseSelectable = true;
            this.mtb_Nachricht.CustomButton.UseWaitCursor = true;
            this.mtb_Nachricht.CustomButton.Visible = false;
            this.mtb_Nachricht.Enabled = false;
            this.mtb_Nachricht.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.mtb_Nachricht.FontWeight = MetroFramework.MetroTextBoxWeight.Light;
            this.mtb_Nachricht.Lines = new string[0];
            this.mtb_Nachricht.Location = new System.Drawing.Point(4, 363);
            this.mtb_Nachricht.MaxLength = 1000;
            this.mtb_Nachricht.Multiline = true;
            this.mtb_Nachricht.Name = "mtb_Nachricht";
            this.mtb_Nachricht.PasswordChar = '\0';
            this.mtb_Nachricht.ReadOnly = true;
            this.mtb_Nachricht.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.mtb_Nachricht.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.mtb_Nachricht.SelectedText = "";
            this.mtb_Nachricht.SelectionLength = 0;
            this.mtb_Nachricht.SelectionStart = 0;
            this.mtb_Nachricht.ShortcutsEnabled = true;
            this.mtb_Nachricht.Size = new System.Drawing.Size(211, 54);
            this.mtb_Nachricht.Style = MetroFramework.MetroColorStyle.Blue;
            this.mtb_Nachricht.TabIndex = 54;
            this.mtb_Nachricht.TabStop = false;
            this.mtb_Nachricht.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.mtb_Nachricht.UseSelectable = true;
            this.mtb_Nachricht.UseWaitCursor = true;
            this.mtb_Nachricht.Visible = false;
            this.mtb_Nachricht.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.mtb_Nachricht.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // checkbox_autor
            // 
            this.checkbox_autor.AutoSize = true;
            this.checkbox_autor.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkbox_autor.FontSize = MetroFramework.MetroCheckBoxSize.Medium;
            this.helpProvider.SetHelpString(this.checkbox_autor, "Setzen sie einen Haken in dieses Feld, können sie mehrere Autoren zu einem Buch a" +
        "ngeben.");
            this.checkbox_autor.Location = new System.Drawing.Point(112, 88);
            this.checkbox_autor.MinimumSize = new System.Drawing.Size(22, 24);
            this.checkbox_autor.Name = "checkbox_autor";
            this.helpProvider.SetShowHelp(this.checkbox_autor, true);
            this.checkbox_autor.Size = new System.Drawing.Size(22, 24);
            this.checkbox_autor.TabIndex = 5;
            this.metroToolTip1.SetToolTip(this.checkbox_autor, "    Setzen sie einen Haken in dieses Feld, können sie mehrere Autoren zu einem Bu" +
        "ch angeben.    ");
            this.checkbox_autor.UseSelectable = true;
            this.checkbox_autor.CheckedChanged += new System.EventHandler(this.checkbox_autor_CheckedChanged);
            // 
            // bt_clear_buecher
            // 
            this.bt_clear_buecher.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.bt_clear_buecher.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.bt_clear_buecher.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.helpProvider.SetHelpString(this.bt_clear_buecher, "Leeren sie alle oben liegenden Textfelder.");
            this.bt_clear_buecher.Location = new System.Drawing.Point(4, 484);
            this.bt_clear_buecher.MaximumSize = new System.Drawing.Size(300, 24);
            this.bt_clear_buecher.MinimumSize = new System.Drawing.Size(75, 24);
            this.bt_clear_buecher.Name = "bt_clear_buecher";
            this.helpProvider.SetShowHelp(this.bt_clear_buecher, true);
            this.bt_clear_buecher.Size = new System.Drawing.Size(122, 24);
            this.bt_clear_buecher.Style = MetroFramework.MetroColorStyle.Blue;
            this.bt_clear_buecher.TabIndex = 26;
            this.bt_clear_buecher.Text = "Leeren";
            this.metroToolTip1.SetToolTip(this.bt_clear_buecher, "    Leeren sie alle oben liegenden Textfelder.    ");
            this.bt_clear_buecher.UseSelectable = true;
            this.bt_clear_buecher.Click += new System.EventHandler(this.bt_clear_click);
            // 
            // btSubmit
            // 
            this.btSubmit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btSubmit.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btSubmit.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.helpProvider.SetHelpString(this.btSubmit, "Speichern sie alle oben eingetragenen Daten.");
            this.btSubmit.Location = new System.Drawing.Point(221, 484);
            this.btSubmit.MaximumSize = new System.Drawing.Size(225, 60);
            this.btSubmit.MinimumSize = new System.Drawing.Size(75, 24);
            this.btSubmit.Name = "btSubmit";
            this.helpProvider.SetShowHelp(this.btSubmit, true);
            this.btSubmit.Size = new System.Drawing.Size(122, 24);
            this.btSubmit.Style = MetroFramework.MetroColorStyle.Blue;
            this.btSubmit.TabIndex = 27;
            this.btSubmit.Text = "Speichern";
            this.metroToolTip1.SetToolTip(this.btSubmit, "    Speichern sie alle oben eingetragenen Daten.    ");
            this.btSubmit.UseSelectable = true;
            this.btSubmit.Click += new System.EventHandler(this.Submit_Click);
            // 
            // bt_pic_delete
            // 
            this.bt_pic_delete.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.bt_pic_delete.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.helpProvider.SetHelpString(this.bt_pic_delete, "Entfernen sie ein Bild zu ihrem Buch.");
            this.bt_pic_delete.Location = new System.Drawing.Point(221, 423);
            this.bt_pic_delete.MaximumSize = new System.Drawing.Size(225, 24);
            this.bt_pic_delete.MinimumSize = new System.Drawing.Size(98, 24);
            this.bt_pic_delete.Name = "bt_pic_delete";
            this.helpProvider.SetShowHelp(this.bt_pic_delete, true);
            this.bt_pic_delete.Size = new System.Drawing.Size(122, 24);
            this.bt_pic_delete.Style = MetroFramework.MetroColorStyle.Blue;
            this.bt_pic_delete.TabIndex = 22;
            this.bt_pic_delete.Text = "Bild entfernen";
            this.metroToolTip1.SetToolTip(this.bt_pic_delete, "    Entfernen sie ein Bild zu ihrem Buch.    ");
            this.bt_pic_delete.UseSelectable = true;
            this.bt_pic_delete.Click += new System.EventHandler(this.bt_pic_add_Click);
            // 
            // bt_picture
            // 
            this.bt_picture.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.bt_picture.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.helpProvider.SetHelpString(this.bt_picture, "Laden sie ein Bild zu ihrem Buch hoch.");
            this.bt_picture.Location = new System.Drawing.Point(221, 393);
            this.bt_picture.MaximumSize = new System.Drawing.Size(225, 24);
            this.bt_picture.MinimumSize = new System.Drawing.Size(98, 24);
            this.bt_picture.Name = "bt_picture";
            this.helpProvider.SetShowHelp(this.bt_picture, true);
            this.bt_picture.Size = new System.Drawing.Size(122, 24);
            this.bt_picture.Style = MetroFramework.MetroColorStyle.Blue;
            this.bt_picture.TabIndex = 21;
            this.bt_picture.Text = "Bild auswählen";
            this.metroToolTip1.SetToolTip(this.bt_picture, "    Laden sie ein Bild zu ihrem Buch hoch.    ");
            this.bt_picture.UseSelectable = true;
            this.bt_picture.Click += new System.EventHandler(this.bt_picture_Click);
            // 
            // lb_Erscheinungsdatum
            // 
            this.helpProvider.SetHelpString(this.lb_Erscheinungsdatum, "Wählen sie das Erscheinungsdatum ihres Buches hier ein.");
            this.lb_Erscheinungsdatum.Location = new System.Drawing.Point(4, 208);
            this.lb_Erscheinungsdatum.Margin = new System.Windows.Forms.Padding(3);
            this.lb_Erscheinungsdatum.Name = "lb_Erscheinungsdatum";
            this.helpProvider.SetShowHelp(this.lb_Erscheinungsdatum, true);
            this.lb_Erscheinungsdatum.Size = new System.Drawing.Size(130, 29);
            this.lb_Erscheinungsdatum.TabIndex = 20;
            this.lb_Erscheinungsdatum.Text = "Erscheinungsdatum:*";
            this.lb_Erscheinungsdatum.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lb_Auflage
            // 
            this.helpProvider.SetHelpString(this.lb_Auflage, "Tragen sie die Auflage ihres Buches hier ein.");
            this.lb_Auflage.Location = new System.Drawing.Point(4, 243);
            this.lb_Auflage.Margin = new System.Windows.Forms.Padding(3);
            this.lb_Auflage.Name = "lb_Auflage";
            this.helpProvider.SetShowHelp(this.lb_Auflage, true);
            this.lb_Auflage.Size = new System.Drawing.Size(130, 24);
            this.lb_Auflage.TabIndex = 18;
            this.lb_Auflage.Text = "Auflage:";
            this.lb_Auflage.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // bt_Sprache_s
            // 
            this.bt_Sprache_s.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.bt_Sprache_s.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.helpProvider.SetHelpString(this.bt_Sprache_s, "Klicken sie auf diesen Button, um neue Sprachen hinzuzufügen.");
            this.bt_Sprache_s.Location = new System.Drawing.Point(321, 178);
            this.bt_Sprache_s.MaximumSize = new System.Drawing.Size(22, 24);
            this.bt_Sprache_s.MinimumSize = new System.Drawing.Size(22, 24);
            this.bt_Sprache_s.Name = "bt_Sprache_s";
            this.helpProvider.SetShowHelp(this.bt_Sprache_s, true);
            this.bt_Sprache_s.Size = new System.Drawing.Size(22, 24);
            this.bt_Sprache_s.TabIndex = 15;
            this.bt_Sprache_s.Text = "+";
            this.metroToolTip1.SetToolTip(this.bt_Sprache_s, "    Klicken sie auf diesen Button, um neue Sprachen hinzuzufügen.    ");
            this.bt_Sprache_s.UseSelectable = true;
            this.bt_Sprache_s.Click += new System.EventHandler(this.bt_language_add_click);
            // 
            // lb_Neupreis
            // 
            this.helpProvider.SetHelpString(this.lb_Neupreis, "Tragen sie den Neupreis ihres Buches hier ein.");
            this.lb_Neupreis.Location = new System.Drawing.Point(4, 273);
            this.lb_Neupreis.Margin = new System.Windows.Forms.Padding(3);
            this.lb_Neupreis.Name = "lb_Neupreis";
            this.helpProvider.SetShowHelp(this.lb_Neupreis, true);
            this.lb_Neupreis.Size = new System.Drawing.Size(130, 24);
            this.lb_Neupreis.TabIndex = 3;
            this.lb_Neupreis.Text = "Neupreis in €:";
            this.lb_Neupreis.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tb_Auflage
            // 
            // 
            // 
            // 
            this.tb_Auflage.CustomButton.Image = null;
            this.tb_Auflage.CustomButton.Location = new System.Drawing.Point(153, 2);
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
            this.tb_Auflage.Location = new System.Drawing.Point(140, 243);
            this.tb_Auflage.MaximumSize = new System.Drawing.Size(375, 24);
            this.tb_Auflage.MaxLength = 32767;
            this.tb_Auflage.MinimumSize = new System.Drawing.Size(50, 24);
            this.tb_Auflage.Name = "tb_Auflage";
            this.tb_Auflage.PasswordChar = '\0';
            this.tb_Auflage.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tb_Auflage.SelectedText = "";
            this.tb_Auflage.SelectionLength = 0;
            this.tb_Auflage.SelectionStart = 0;
            this.tb_Auflage.ShortcutsEnabled = true;
            this.helpProvider.SetShowHelp(this.tb_Auflage, true);
            this.tb_Auflage.Size = new System.Drawing.Size(175, 24);
            this.tb_Auflage.TabIndex = 17;
            this.metroToolTip1.SetToolTip(this.tb_Auflage, "    Tragen sie die Auflage ihres Buches hier ein.    ");
            this.tb_Auflage.UseSelectable = true;
            this.tb_Auflage.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tb_Auflage.WaterMarkFont = new System.Drawing.Font("Segoe UI", 10.5F);
            this.tb_Auflage.TextChanged += new System.EventHandler(this.tb_Auflage_TextChanged);
            // 
            // lb_Sprache
            // 
            this.helpProvider.SetHelpString(this.lb_Sprache, "Tragen sie die Sprache ihres Buches hier ein.");
            this.lb_Sprache.Location = new System.Drawing.Point(4, 178);
            this.lb_Sprache.Margin = new System.Windows.Forms.Padding(3);
            this.lb_Sprache.Name = "lb_Sprache";
            this.helpProvider.SetShowHelp(this.lb_Sprache, true);
            this.lb_Sprache.Size = new System.Drawing.Size(130, 24);
            this.lb_Sprache.TabIndex = 14;
            this.lb_Sprache.Text = "Sprache:*";
            this.lb_Sprache.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tb_Neupreis
            // 
            // 
            // 
            // 
            this.tb_Neupreis.CustomButton.Image = null;
            this.tb_Neupreis.CustomButton.Location = new System.Drawing.Point(35, 2);
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
            this.tb_Neupreis.Location = new System.Drawing.Point(158, 273);
            this.tb_Neupreis.MaximumSize = new System.Drawing.Size(375, 24);
            this.tb_Neupreis.MaxLength = 32767;
            this.tb_Neupreis.MinimumSize = new System.Drawing.Size(50, 24);
            this.tb_Neupreis.Name = "tb_Neupreis";
            this.tb_Neupreis.PasswordChar = '\0';
            this.tb_Neupreis.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tb_Neupreis.SelectedText = "";
            this.tb_Neupreis.SelectionLength = 0;
            this.tb_Neupreis.SelectionStart = 0;
            this.tb_Neupreis.ShortcutsEnabled = false;
            this.helpProvider.SetShowHelp(this.tb_Neupreis, true);
            this.tb_Neupreis.Size = new System.Drawing.Size(57, 24);
            this.tb_Neupreis.TabIndex = 18;
            this.metroToolTip1.SetToolTip(this.tb_Neupreis, "    Tragen sie den Neupreis ihres Buches hier ein.    ");
            this.tb_Neupreis.UseSelectable = true;
            this.tb_Neupreis.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tb_Neupreis.WaterMarkFont = new System.Drawing.Font("Segoe UI", 10.5F);
            this.tb_Neupreis.TextChanged += new System.EventHandler(this.tb_Neupreis_TextChanged);
            this.tb_Neupreis.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_Neupreis_KeyPress);
            this.tb_Neupreis.Leave += new System.EventHandler(this.tb_Neupreis_Leave);
            // 
            // rb_Update_Buch
            // 
            this.rb_Update_Buch.AutoSize = true;
            this.rb_Update_Buch.FontSize = MetroFramework.MetroCheckBoxSize.Medium;
            this.rb_Update_Buch.FontWeight = MetroFramework.MetroCheckBoxWeight.Light;
            this.helpProvider.SetHelpString(this.rb_Update_Buch, "Klicken sie hier, um ein vorhandenes Buch zu bearbeiten.");
            this.rb_Update_Buch.Location = new System.Drawing.Point(170, 3);
            this.rb_Update_Buch.Name = "rb_Update_Buch";
            this.helpProvider.SetShowHelp(this.rb_Update_Buch, true);
            this.rb_Update_Buch.Size = new System.Drawing.Size(92, 20);
            this.rb_Update_Buch.TabIndex = 1;
            this.rb_Update_Buch.Text = "Bearbeiten";
            this.metroToolTip1.SetToolTip(this.rb_Update_Buch, "    Klicken sie hier, um ein vorhandenes Buch zu bearbeiten.    ");
            this.rb_Update_Buch.UseSelectable = true;
            this.rb_Update_Buch.CheckedChanged += new System.EventHandler(this.rb_checked_changed);
            // 
            // rb_Add_Buch
            // 
            this.rb_Add_Buch.AutoSize = true;
            this.rb_Add_Buch.FontSize = MetroFramework.MetroCheckBoxSize.Medium;
            this.rb_Add_Buch.FontWeight = MetroFramework.MetroCheckBoxWeight.Light;
            this.helpProvider.SetHelpString(this.rb_Add_Buch, "Klicken sie hier, um ein neues Buch hinzuzufügen.");
            this.rb_Add_Buch.Location = new System.Drawing.Point(74, 3);
            this.rb_Add_Buch.Name = "rb_Add_Buch";
            this.helpProvider.SetShowHelp(this.rb_Add_Buch, true);
            this.rb_Add_Buch.Size = new System.Drawing.Size(97, 20);
            this.rb_Add_Buch.TabIndex = 1;
            this.rb_Add_Buch.Text = "Hinzufügen";
            this.metroToolTip1.SetToolTip(this.rb_Add_Buch, "    Klicken sie hier, um ein neues Buch hinzuzufügen.    ");
            this.rb_Add_Buch.UseSelectable = true;
            this.rb_Add_Buch.CheckedChanged += new System.EventHandler(this.rb_checked_changed);
            // 
            // rb_Delete_Buch
            // 
            this.rb_Delete_Buch.AutoSize = true;
            this.rb_Delete_Buch.FontSize = MetroFramework.MetroCheckBoxSize.Medium;
            this.rb_Delete_Buch.FontWeight = MetroFramework.MetroCheckBoxWeight.Light;
            this.helpProvider.SetHelpString(this.rb_Delete_Buch, "Klicken sie hier, um ein vorhandenes Buch zu löschen.");
            this.rb_Delete_Buch.Location = new System.Drawing.Point(264, 3);
            this.rb_Delete_Buch.Name = "rb_Delete_Buch";
            this.helpProvider.SetShowHelp(this.rb_Delete_Buch, true);
            this.rb_Delete_Buch.Size = new System.Drawing.Size(86, 20);
            this.rb_Delete_Buch.TabIndex = 1;
            this.rb_Delete_Buch.Text = "Entfernen";
            this.metroToolTip1.SetToolTip(this.rb_Delete_Buch, "    Klicken sie hier, um ein vorhandenes Buch zu löschen.    ");
            this.rb_Delete_Buch.UseSelectable = true;
            this.rb_Delete_Buch.CheckedChanged += new System.EventHandler(this.rb_checked_changed);
            // 
            // bt_Autor_s
            // 
            this.bt_Autor_s.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.bt_Autor_s.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.helpProvider.SetHelpString(this.bt_Autor_s, "Klicken sie auf diesen Button, um neue Autoren hinzuzufügen.");
            this.bt_Autor_s.Location = new System.Drawing.Point(321, 88);
            this.bt_Autor_s.MaximumSize = new System.Drawing.Size(22, 24);
            this.bt_Autor_s.MinimumSize = new System.Drawing.Size(22, 24);
            this.bt_Autor_s.Name = "bt_Autor_s";
            this.helpProvider.SetShowHelp(this.bt_Autor_s, true);
            this.bt_Autor_s.Size = new System.Drawing.Size(22, 24);
            this.bt_Autor_s.TabIndex = 9;
            this.bt_Autor_s.Text = "+";
            this.metroToolTip1.SetToolTip(this.bt_Autor_s, "    Klicken sie auf diesen Button, um neue Autoren hinzuzufügen.    ");
            this.bt_Autor_s.UseSelectable = true;
            this.bt_Autor_s.Click += new System.EventHandler(this.bt_author_add_click);
            // 
            // lb_Verlag
            // 
            this.helpProvider.SetHelpKeyword(this.lb_Verlag, "Tragen sie den Verlag ihres Buches hier ein.");
            this.lb_Verlag.Location = new System.Drawing.Point(4, 118);
            this.lb_Verlag.Margin = new System.Windows.Forms.Padding(3);
            this.lb_Verlag.Name = "lb_Verlag";
            this.helpProvider.SetShowHelp(this.lb_Verlag, true);
            this.lb_Verlag.Size = new System.Drawing.Size(130, 24);
            this.lb_Verlag.TabIndex = 10;
            this.lb_Verlag.Text = "Verlag:*";
            this.lb_Verlag.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lb_Autor
            // 
            this.helpProvider.SetHelpString(this.lb_Autor, "Tragen sie den Autor ihres Buches hier ein.");
            this.lb_Autor.Location = new System.Drawing.Point(4, 88);
            this.lb_Autor.Margin = new System.Windows.Forms.Padding(3);
            this.lb_Autor.Name = "lb_Autor";
            this.helpProvider.SetShowHelp(this.lb_Autor, true);
            this.lb_Autor.Size = new System.Drawing.Size(102, 24);
            this.lb_Autor.TabIndex = 8;
            this.lb_Autor.Text = "Autor:*";
            this.lb_Autor.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // bt_Verlag_s
            // 
            this.bt_Verlag_s.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.bt_Verlag_s.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.helpProvider.SetHelpString(this.bt_Verlag_s, "Klicken sie auf diesen Button, um neue Verläge hinzuzufügen.");
            this.bt_Verlag_s.Location = new System.Drawing.Point(321, 118);
            this.bt_Verlag_s.MaximumSize = new System.Drawing.Size(22, 24);
            this.bt_Verlag_s.MinimumSize = new System.Drawing.Size(22, 24);
            this.bt_Verlag_s.Name = "bt_Verlag_s";
            this.helpProvider.SetShowHelp(this.bt_Verlag_s, true);
            this.bt_Verlag_s.Size = new System.Drawing.Size(22, 24);
            this.bt_Verlag_s.TabIndex = 11;
            this.bt_Verlag_s.Text = "+";
            this.metroToolTip1.SetToolTip(this.bt_Verlag_s, "    Klicken sie auf diesen Button, um neue Verläge hinzuzufügen.    ");
            this.bt_Verlag_s.UseSelectable = true;
            this.bt_Verlag_s.Click += new System.EventHandler(this.bt_publisher_add_click);
            // 
            // bt_Genre_s
            // 
            this.bt_Genre_s.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.bt_Genre_s.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.helpProvider.SetHelpString(this.bt_Genre_s, "Klicken sie auf diesen Button, um neue Genres hinzuzufügen.");
            this.bt_Genre_s.Location = new System.Drawing.Point(321, 148);
            this.bt_Genre_s.MaximumSize = new System.Drawing.Size(22, 24);
            this.bt_Genre_s.MinimumSize = new System.Drawing.Size(22, 24);
            this.bt_Genre_s.Name = "bt_Genre_s";
            this.helpProvider.SetShowHelp(this.bt_Genre_s, true);
            this.bt_Genre_s.Size = new System.Drawing.Size(22, 24);
            this.bt_Genre_s.TabIndex = 13;
            this.bt_Genre_s.Text = "+";
            this.metroToolTip1.SetToolTip(this.bt_Genre_s, "    Klicken sie auf diesen Button, um neue Genres hinzuzufügen.    ");
            this.bt_Genre_s.UseSelectable = true;
            this.bt_Genre_s.Click += new System.EventHandler(this.bt_genre_add_click);
            // 
            // lb_Genre
            // 
            this.helpProvider.SetHelpString(this.lb_Genre, "Tragen sie das Genre ihres Buches hier ein.");
            this.lb_Genre.Location = new System.Drawing.Point(4, 148);
            this.lb_Genre.Margin = new System.Windows.Forms.Padding(3);
            this.lb_Genre.Name = "lb_Genre";
            this.helpProvider.SetShowHelp(this.lb_Genre, true);
            this.lb_Genre.Size = new System.Drawing.Size(130, 24);
            this.lb_Genre.TabIndex = 5;
            this.lb_Genre.Text = "Genre:*";
            this.lb_Genre.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tb_Titel
            // 
            // 
            // 
            // 
            this.tb_Titel.CustomButton.Image = null;
            this.tb_Titel.CustomButton.Location = new System.Drawing.Point(153, 2);
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
            this.tb_Titel.Location = new System.Drawing.Point(140, 58);
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
            this.tb_Titel.Size = new System.Drawing.Size(175, 24);
            this.tb_Titel.TabIndex = 4;
            this.metroToolTip1.SetToolTip(this.tb_Titel, "Tragen sie den Titel ihres Buches hier ein.");
            this.tb_Titel.UseSelectable = true;
            this.tb_Titel.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tb_Titel.WaterMarkFont = new System.Drawing.Font("Segoe UI", 10.5F);
            this.tb_Titel.TextChanged += new System.EventHandler(this.tb_Titel_TextChanged);
            this.tb_Titel.Click += new System.EventHandler(this.tb_Titel_Click);
            // 
            // lb_Titel
            // 
            this.helpProvider.SetHelpString(this.lb_Titel, "Tragen sie den Titel ihres Buches hier ein.");
            this.lb_Titel.Location = new System.Drawing.Point(4, 58);
            this.lb_Titel.Margin = new System.Windows.Forms.Padding(3);
            this.lb_Titel.Name = "lb_Titel";
            this.helpProvider.SetShowHelp(this.lb_Titel, true);
            this.lb_Titel.Size = new System.Drawing.Size(130, 24);
            this.lb_Titel.TabIndex = 3;
            this.lb_Titel.Text = "Titel:*";
            this.lb_Titel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tb_ISBN
            // 
            // 
            // 
            // 
            this.tb_ISBN.CustomButton.Image = null;
            this.tb_ISBN.CustomButton.Location = new System.Drawing.Point(153, 2);
            this.tb_ISBN.CustomButton.Margin = new System.Windows.Forms.Padding(2);
            this.tb_ISBN.CustomButton.Name = "";
            this.tb_ISBN.CustomButton.Size = new System.Drawing.Size(19, 19);
            this.tb_ISBN.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tb_ISBN.CustomButton.TabIndex = 1;
            this.tb_ISBN.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tb_ISBN.CustomButton.UseSelectable = true;
            this.tb_ISBN.CustomButton.Visible = false;
            this.tb_ISBN.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.helpProvider.SetHelpString(this.tb_ISBN, "Tragen sie hier die ISBN-13 ein, um das gewünschte Buch zu laden.");
            this.tb_ISBN.Lines = new string[0];
            this.tb_ISBN.Location = new System.Drawing.Point(140, 28);
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
            this.helpProvider.SetShowHelp(this.tb_ISBN, true);
            this.tb_ISBN.Size = new System.Drawing.Size(175, 24);
            this.tb_ISBN.TabIndex = 2;
            this.metroToolTip1.SetToolTip(this.tb_ISBN, "    Tragen sie hier die ISBN-13 ein, um das gewünschte Buch zu laden.    ");
            this.tb_ISBN.UseSelectable = true;
            this.tb_ISBN.WaterMark = "123-0123456789";
            this.tb_ISBN.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tb_ISBN.WaterMarkFont = new System.Drawing.Font("Segoe UI", 10.5F);
            this.tb_ISBN.TextChanged += new System.EventHandler(this.tb_ISBN_TextChanged);
            this.tb_ISBN.Click += new System.EventHandler(this.tb_ISBN_Click);
            this.tb_ISBN.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tb_ISBN_KeyDown);
            this.tb_ISBN.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_ISBN_KeyPress);
            this.tb_ISBN.Leave += new System.EventHandler(this.Tb_ISBN_Leave_1);
            // 
            // lb_ISBN
            // 
            this.helpProvider.SetHelpString(this.lb_ISBN, "Tragen sie hier die ISBN-13 ein, um das gewünschte Buch zu laden.");
            this.lb_ISBN.Location = new System.Drawing.Point(4, 28);
            this.lb_ISBN.Margin = new System.Windows.Forms.Padding(3);
            this.lb_ISBN.Name = "lb_ISBN";
            this.helpProvider.SetShowHelp(this.lb_ISBN, true);
            this.lb_ISBN.Size = new System.Drawing.Size(130, 24);
            this.lb_ISBN.TabIndex = 1;
            this.lb_ISBN.Text = "ISBN:*";
            this.lb_ISBN.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // button1
            // 
            this.button1.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.button1.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.helpProvider.SetHelpString(this.button1, "Wenn sie eine ISBN eingetragen haben, können sie auf diesen Stern klicken, um res" +
        "tliche Buchinformationen automatisch ausfüllen zu lassen.");
            this.button1.Location = new System.Drawing.Point(321, 28);
            this.button1.MaximumSize = new System.Drawing.Size(22, 24);
            this.button1.MinimumSize = new System.Drawing.Size(22, 24);
            this.button1.Name = "button1";
            this.helpProvider.SetShowHelp(this.button1, true);
            this.button1.Size = new System.Drawing.Size(22, 24);
            this.button1.TabIndex = 3;
            this.button1.Text = "*";
            this.metroToolTip1.SetToolTip(this.button1, "      Wenn sie eine ISBN eingetragen haben, können sie auf diesen Stern klicken, " +
        "um restliche Buchinformationen automatisch ausfüllen zu lassen.      ");
            this.button1.UseSelectable = true;
            this.button1.Click += new System.EventHandler(this.bt_load_click);
            // 
            // gridViewBook
            // 
            this.gridViewBook.AllowUserToAddRows = false;
            this.gridViewBook.AllowUserToDeleteRows = false;
            this.gridViewBook.AllowUserToOrderColumns = true;
            this.gridViewBook.AllowUserToResizeRows = false;
            this.gridViewBook.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridViewBook.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.gridViewBook.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.gridViewBook.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gridViewBook.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.gridViewBook.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI Semibold", 10.5F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridViewBook.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.gridViewBook.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridViewBook.ContextMenuStrip = this.contextMenuStrip1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridViewBook.DefaultCellStyle = dataGridViewCellStyle2;
            this.gridViewBook.EnableHeadersVisualStyles = false;
            this.gridViewBook.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.gridViewBook.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.helpProvider.SetHelpString(this.gridViewBook, "In diesem Feld werden all ihre Bücher angezeigt.");
            this.gridViewBook.Location = new System.Drawing.Point(376, 63);
            this.gridViewBook.Name = "gridViewBook";
            this.gridViewBook.ReadOnly = true;
            this.gridViewBook.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridViewBook.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.gridViewBook.RowHeadersVisible = false;
            this.gridViewBook.RowHeadersWidth = 51;
            this.gridViewBook.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.gridViewBook.RowTemplate.DividerHeight = 1;
            this.gridViewBook.RowTemplate.Height = 24;
            this.gridViewBook.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.helpProvider.SetShowHelp(this.gridViewBook, true);
            this.gridViewBook.Size = new System.Drawing.Size(801, 475);
            this.gridViewBook.Style = MetroFramework.MetroColorStyle.Blue;
            this.gridViewBook.TabIndex = 28;
            this.metroToolTip1.SetToolTip(this.gridViewBook, "      In diesem Bereich werden alle Bücher der Datenbank angezeigt. Mit einem Rec" +
        "htsklick können Sie weitere Aktionen wählen.      ");
            this.gridViewBook.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Grid_Buch_CellClick);
            this.gridViewBook.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridViewBookClick);
            this.gridViewBook.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.Grid_Buch_CellMouseDown);
            this.gridViewBook.Click += new System.EventHandler(this.Grid_Buch_Click);
            this.gridViewBook.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Grid_Buch_KeyDown);
            this.gridViewBook.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Grid_Buch_MouseDown);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.contextMenuStrip1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(40, 40);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ladenToolStripMenuItem,
            this.entfernenToolStripMenuItem,
            this.exemplareToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(149, 76);
            this.contextMenuStrip1.Style = MetroFramework.MetroColorStyle.Blue;
            this.contextMenuStrip1.UseStyleColors = true;
            // 
            // ladenToolStripMenuItem
            // 
            this.ladenToolStripMenuItem.Name = "ladenToolStripMenuItem";
            this.ladenToolStripMenuItem.Size = new System.Drawing.Size(148, 24);
            this.ladenToolStripMenuItem.Text = "Laden";
            this.ladenToolStripMenuItem.Click += new System.EventHandler(this.ladenToolStripMenuItem_Click);
            // 
            // entfernenToolStripMenuItem
            // 
            this.entfernenToolStripMenuItem.Name = "entfernenToolStripMenuItem";
            this.entfernenToolStripMenuItem.Size = new System.Drawing.Size(148, 24);
            this.entfernenToolStripMenuItem.Text = "Entfernen";
            this.entfernenToolStripMenuItem.Click += new System.EventHandler(this.entfernenToolStripMenuItem_Click);
            // 
            // exemplareToolStripMenuItem
            // 
            this.exemplareToolStripMenuItem.Name = "exemplareToolStripMenuItem";
            this.exemplareToolStripMenuItem.Size = new System.Drawing.Size(148, 24);
            this.exemplareToolStripMenuItem.Text = "Exemplare";
            this.exemplareToolStripMenuItem.Click += new System.EventHandler(this.exemplareToolStripMenuItem_Click);
            // 
            // bt_Schliessen
            // 
            this.bt_Schliessen.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bt_Schliessen.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.bt_Schliessen.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.bt_Schliessen.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.helpProvider.SetHelpString(this.bt_Schliessen, "Schließen sie das akuelle Fenster.");
            this.bt_Schliessen.Location = new System.Drawing.Point(676, 3);
            this.bt_Schliessen.Name = "bt_Schliessen";
            this.helpProvider.SetShowHelp(this.bt_Schliessen, true);
            this.bt_Schliessen.Size = new System.Drawing.Size(122, 24);
            this.bt_Schliessen.TabIndex = 32;
            this.bt_Schliessen.Text = "Schließen";
            this.metroToolTip1.SetToolTip(this.bt_Schliessen, "    Schließen sie das akuelle Fenster.    ");
            this.bt_Schliessen.UseSelectable = true;
            this.bt_Schliessen.Click += new System.EventHandler(this.bt_Schliessen_Click);
            // 
            // bt_Excel
            // 
            this.bt_Excel.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.bt_Excel.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.helpProvider.SetHelpString(this.bt_Excel, "Exportieren sie ihre Bücherdaten in eine Exceltabelle.");
            this.bt_Excel.Location = new System.Drawing.Point(131, 3);
            this.bt_Excel.Name = "bt_Excel";
            this.helpProvider.SetShowHelp(this.bt_Excel, true);
            this.bt_Excel.Size = new System.Drawing.Size(122, 24);
            this.bt_Excel.TabIndex = 30;
            this.bt_Excel.Text = "Daten-Export";
            this.metroToolTip1.SetToolTip(this.bt_Excel, "    Exportieren sie ihre Bücherdaten in eine Exceltabelle.    ");
            this.bt_Excel.UseSelectable = true;
            this.bt_Excel.Click += new System.EventHandler(this.bt_Excel_Click);
            // 
            // gb_zoom
            // 
            this.gb_zoom.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gb_zoom.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.gb_zoom.Controls.Add(this.picBox_Gross);
            this.gb_zoom.HorizontalScrollbarBarColor = true;
            this.gb_zoom.HorizontalScrollbarHighlightOnWheel = false;
            this.gb_zoom.HorizontalScrollbarSize = 8;
            this.gb_zoom.Location = new System.Drawing.Point(376, 63);
            this.gb_zoom.Name = "gb_zoom";
            this.gb_zoom.Size = new System.Drawing.Size(801, 475);
            this.gb_zoom.TabIndex = 51;
            this.gb_zoom.VerticalScrollbarBarColor = true;
            this.gb_zoom.VerticalScrollbarHighlightOnWheel = false;
            this.gb_zoom.VerticalScrollbarSize = 8;
            // 
            // picBox_Gross
            // 
            this.picBox_Gross.BackColor = System.Drawing.Color.White;
            this.picBox_Gross.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picBox_Gross.Location = new System.Drawing.Point(0, 0);
            this.picBox_Gross.Margin = new System.Windows.Forms.Padding(0);
            this.picBox_Gross.Name = "picBox_Gross";
            this.picBox_Gross.Size = new System.Drawing.Size(801, 475);
            this.picBox_Gross.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBox_Gross.TabIndex = 50;
            this.picBox_Gross.TabStop = false;
            this.picBox_Gross.Visible = false;
            // 
            // metroProgressSpinner1
            // 
            this.metroProgressSpinner1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.metroProgressSpinner1.Location = new System.Drawing.Point(540, 63);
            this.metroProgressSpinner1.Maximum = 100;
            this.metroProgressSpinner1.Name = "metroProgressSpinner1";
            this.metroProgressSpinner1.Size = new System.Drawing.Size(475, 475);
            this.metroProgressSpinner1.TabIndex = 51;
            this.metroProgressSpinner1.TabStop = false;
            this.metroProgressSpinner1.UseSelectable = true;
            // 
            // mtb_Import
            // 
            this.mtb_Import.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.mtb_Import.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.helpProvider.SetHelpString(this.mtb_Import, "Exportieren sie ihre Bücherdaten in eine Exceltabelle.");
            this.mtb_Import.Location = new System.Drawing.Point(3, 3);
            this.mtb_Import.Name = "mtb_Import";
            this.helpProvider.SetShowHelp(this.mtb_Import, true);
            this.mtb_Import.Size = new System.Drawing.Size(122, 24);
            this.mtb_Import.TabIndex = 29;
            this.mtb_Import.Text = "Daten-Import";
            this.metroToolTip1.SetToolTip(this.mtb_Import, "    Importieren Sie Daten von einer externen Quelle.    ");
            this.mtb_Import.UseSelectable = true;
            this.mtb_Import.Click += new System.EventHandler(this.Mtb_Import_Click);
            // 
            // picBox_Klein
            // 
            this.helpProvider.SetHelpString(this.picBox_Klein, "Wenn sie mit ihrer Maus über dieses Vorschaubild ihres aktuellen Buches fahren, s" +
        "ehen sie eine vergrößerte Darstellung.");
            this.picBox_Klein.Location = new System.Drawing.Point(221, 273);
            this.picBox_Klein.Name = "picBox_Klein";
            this.helpProvider.SetShowHelp(this.picBox_Klein, true);
            this.picBox_Klein.Size = new System.Drawing.Size(122, 114);
            this.picBox_Klein.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBox_Klein.TabIndex = 46;
            this.picBox_Klein.TabStop = false;
            this.metroToolTip1.SetToolTip(this.picBox_Klein, "        Wenn sie mit ihrer Maus über dieses Vorschaubild ihres aktuellen Buches f" +
        "ahren, sehen sie eine vergrößerte Darstellung.         ");
            this.picBox_Klein.MouseEnter += new System.EventHandler(this.pictureBox1_MouseEnter);
            this.picBox_Klein.MouseLeave += new System.EventHandler(this.pictureBox1_MouseLeave);
            // 
            // cb_Genre
            // 
            this.cb_Genre.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cb_Genre.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cb_Genre.BorderColor = System.Drawing.Color.Gray;
            this.cb_Genre.DataRowView = true;
            this.cb_Genre.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cb_Genre.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cb_Genre.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.cb_Genre.ForeColor = System.Drawing.Color.Black;
            this.cb_Genre.FormattingEnabled = true;
            this.helpProvider.SetHelpString(this.cb_Genre, "Tragen sie das Genre ihres Buches hier ein.");
            this.cb_Genre.HighlightColor = System.Drawing.Color.DeepSkyBlue;
            this.cb_Genre.ItemHeight = 18;
            this.cb_Genre.Location = new System.Drawing.Point(140, 148);
            this.cb_Genre.Name = "cb_Genre";
            this.helpProvider.SetShowHelp(this.cb_Genre, true);
            this.cb_Genre.Size = new System.Drawing.Size(175, 24);
            this.cb_Genre.TabIndex = 12;
            this.metroToolTip1.SetToolTip(this.cb_Genre, "    Tragen sie das Genre ihres Buches hier ein.    ");
            this.cb_Genre.TextChanged += new System.EventHandler(this.cb_Genre_TextChanged);
            this.cb_Genre.Enter += new System.EventHandler(this.cb_Genre_Enter);
            this.cb_Genre.MouseEnter += new System.EventHandler(this.cb_Genre_MouseEnter);
            // 
            // cb_Verlag
            // 
            this.cb_Verlag.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cb_Verlag.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cb_Verlag.BorderColor = System.Drawing.Color.Gray;
            this.cb_Verlag.DataRowView = true;
            this.cb_Verlag.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cb_Verlag.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cb_Verlag.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.cb_Verlag.ForeColor = System.Drawing.Color.Black;
            this.cb_Verlag.FormattingEnabled = true;
            this.helpProvider.SetHelpString(this.cb_Verlag, "Tragen sie den Verlag ihres Buches hier ein.");
            this.cb_Verlag.HighlightColor = System.Drawing.Color.DeepSkyBlue;
            this.cb_Verlag.ItemHeight = 18;
            this.cb_Verlag.Location = new System.Drawing.Point(140, 118);
            this.cb_Verlag.Name = "cb_Verlag";
            this.helpProvider.SetShowHelp(this.cb_Verlag, true);
            this.cb_Verlag.Size = new System.Drawing.Size(175, 24);
            this.cb_Verlag.TabIndex = 10;
            this.metroToolTip1.SetToolTip(this.cb_Verlag, "    Tragen sie den Verlag ihres Buches hier ein.    ");
            this.cb_Verlag.TextChanged += new System.EventHandler(this.cb_Verlag_TextChanged);
            this.cb_Verlag.Enter += new System.EventHandler(this.cb_Verlag_Enter);
            this.cb_Verlag.MouseEnter += new System.EventHandler(this.cb_Verlag_MouseEnter);
            // 
            // cb_Sprache
            // 
            this.cb_Sprache.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cb_Sprache.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cb_Sprache.BorderColor = System.Drawing.Color.Gray;
            this.cb_Sprache.DataRowView = true;
            this.cb_Sprache.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cb_Sprache.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cb_Sprache.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.cb_Sprache.ForeColor = System.Drawing.Color.Black;
            this.cb_Sprache.FormattingEnabled = true;
            this.helpProvider.SetHelpKeyword(this.cb_Sprache, "Tragen sie die Sprache ihres Buches hier ein.");
            this.cb_Sprache.HighlightColor = System.Drawing.Color.DeepSkyBlue;
            this.cb_Sprache.ItemHeight = 18;
            this.cb_Sprache.Location = new System.Drawing.Point(140, 178);
            this.cb_Sprache.Name = "cb_Sprache";
            this.helpProvider.SetShowHelp(this.cb_Sprache, true);
            this.cb_Sprache.Size = new System.Drawing.Size(175, 24);
            this.cb_Sprache.TabIndex = 14;
            this.metroToolTip1.SetToolTip(this.cb_Sprache, "    Tragen sie die Sprache ihres Buches hier ein.    ");
            this.cb_Sprache.TextChanged += new System.EventHandler(this.cb_Sprache_TextChanged);
            this.cb_Sprache.Enter += new System.EventHandler(this.cb_Sprache_Enter);
            this.cb_Sprache.MouseEnter += new System.EventHandler(this.cb_Sprache_MouseEnter);
            // 
            // cb_Autor
            // 
            this.cb_Autor.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cb_Autor.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cb_Autor.BorderColor = System.Drawing.Color.Gray;
            this.cb_Autor.DataRowView = true;
            this.cb_Autor.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cb_Autor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cb_Autor.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.cb_Autor.ForeColor = System.Drawing.Color.Black;
            this.cb_Autor.FormattingEnabled = true;
            this.helpProvider.SetHelpString(this.cb_Autor, "Tragen sie den Autor ihres Buches hier ein.");
            this.cb_Autor.HighlightColor = System.Drawing.Color.DeepSkyBlue;
            this.cb_Autor.ItemHeight = 18;
            this.cb_Autor.Location = new System.Drawing.Point(140, 88);
            this.cb_Autor.Name = "cb_Autor";
            this.helpProvider.SetShowHelp(this.cb_Autor, true);
            this.cb_Autor.Size = new System.Drawing.Size(175, 24);
            this.cb_Autor.TabIndex = 6;
            this.metroToolTip1.SetToolTip(this.cb_Autor, "    Tragen sie den Autor ihres Buches hier ein.    ");
            this.cb_Autor.TextChanged += new System.EventHandler(this.cb_Autor_TextChanged);
            this.cb_Autor.Enter += new System.EventHandler(this.cb_Autor_Enter);
            this.cb_Autor.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Cb_Autor_KeyDown);
            this.cb_Autor.MouseEnter += new System.EventHandler(this.cb_Autor_MouseEnter);
            // 
            // metroPanel1
            // 
            this.metroPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.metroPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.metroPanel1.Controls.Add(this.p_autor);
            this.metroPanel1.Controls.Add(this.checkedListBox1);
            this.metroPanel1.Controls.Add(this.comboBox1);
            this.metroPanel1.Controls.Add(this.cb_Genre);
            this.metroPanel1.Controls.Add(this.p_sprache);
            this.metroPanel1.Controls.Add(this.dTP_Erscheinungsdatum);
            this.metroPanel1.Controls.Add(this.bt_print);
            this.metroPanel1.Controls.Add(this.p_verlag);
            this.metroPanel1.Controls.Add(this.metroLabel3);
            this.metroPanel1.Controls.Add(this.p_genre);
            this.metroPanel1.Controls.Add(this.tb_barcodePrinted);
            this.metroPanel1.Controls.Add(this.metroLabel2);
            this.metroPanel1.Controls.Add(this.tb_barcodeAdd);
            this.metroPanel1.Controls.Add(this.checkbox_autor);
            this.metroPanel1.Controls.Add(this.mtb_Nachricht);
            this.metroPanel1.Controls.Add(this.bt_clear_buecher);
            this.metroPanel1.Controls.Add(this.btSubmit);
            this.metroPanel1.Controls.Add(this.lb_Neupreis);
            this.metroPanel1.Controls.Add(this.tb_Auflage);
            this.metroPanel1.Controls.Add(this.tb_Neupreis);
            this.metroPanel1.Controls.Add(this.lb_Auflage);
            this.metroPanel1.Controls.Add(this.metroLabel1);
            this.metroPanel1.Controls.Add(this.lb_Erscheinungsdatum);
            this.metroPanel1.Controls.Add(this.picBox_Klein);
            this.metroPanel1.Controls.Add(this.bt_pic_delete);
            this.metroPanel1.Controls.Add(this.bt_picture);
            this.metroPanel1.Controls.Add(this.tb_neu);
            this.metroPanel1.Controls.Add(this.rb_search);
            this.metroPanel1.Controls.Add(this.rb_Add_Buch);
            this.metroPanel1.Controls.Add(this.rb_Update_Buch);
            this.metroPanel1.Controls.Add(this.rb_Delete_Buch);
            this.metroPanel1.Controls.Add(this.button1);
            this.metroPanel1.Controls.Add(this.lb_ISBN);
            this.metroPanel1.Controls.Add(this.tb_ISBN);
            this.metroPanel1.Controls.Add(this.bt_Sprache_s);
            this.metroPanel1.Controls.Add(this.tb_Titel);
            this.metroPanel1.Controls.Add(this.lb_Sprache);
            this.metroPanel1.Controls.Add(this.lb_Titel);
            this.metroPanel1.Controls.Add(this.cb_Verlag);
            this.metroPanel1.Controls.Add(this.bt_Autor_s);
            this.metroPanel1.Controls.Add(this.cb_Sprache);
            this.metroPanel1.Controls.Add(this.bt_Verlag_s);
            this.metroPanel1.Controls.Add(this.bt_Genre_s);
            this.metroPanel1.Controls.Add(this.lb_Genre);
            this.metroPanel1.Controls.Add(this.lb_Verlag);
            this.metroPanel1.Controls.Add(this.lb_Autor);
            this.metroPanel1.Controls.Add(this.cb_Autor);
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 8;
            this.metroPanel1.Location = new System.Drawing.Point(23, 63);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(347, 514);
            this.metroPanel1.TabIndex = 0;
            this.metroPanel1.TabStop = true;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 8;
            // 
            // p_autor
            // 
            this.p_autor.Location = new System.Drawing.Point(140, 88);
            this.p_autor.Name = "p_autor";
            this.p_autor.Size = new System.Drawing.Size(175, 24);
            this.p_autor.TabIndex = 56;
            this.p_autor.Visible = false;
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.checkedListBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.HighlightColor = System.Drawing.Color.Green;
            this.checkedListBox1.Location = new System.Drawing.Point(140, 111);
            this.checkedListBox1.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(175, 92);
            this.checkedListBox1.TabIndex = 8;
            this.metroToolTip1.SetToolTip(this.checkedListBox1, "Wählen Sie hier mehrere Autoren aus.");
            this.checkedListBox1.Visible = false;
            this.checkedListBox1.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.checkedListBox1_ItemCheck);
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.Color.White;
            this.comboBox1.BorderColor = System.Drawing.Color.Gray;
            this.comboBox1.DataRowView = true;
            this.comboBox1.DropDownHeight = 1;
            this.comboBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox1.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.HighlightColor = System.Drawing.Color.Gray;
            this.comboBox1.IntegralHeight = false;
            this.comboBox1.ItemHeight = 18;
            this.comboBox1.Location = new System.Drawing.Point(297, 88);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.comboBox1.Size = new System.Drawing.Size(18, 24);
            this.comboBox1.TabIndex = 7;
            this.comboBox1.Click += new System.EventHandler(this.comboBox1_Click);
            // 
            // p_sprache
            // 
            this.p_sprache.Location = new System.Drawing.Point(140, 178);
            this.p_sprache.Name = "p_sprache";
            this.p_sprache.Size = new System.Drawing.Size(175, 24);
            this.p_sprache.TabIndex = 56;
            this.p_sprache.Visible = false;
            // 
            // dTP_Erscheinungsdatum
            // 
            this.dTP_Erscheinungsdatum.CustomFormat = " dd.MM.yyyy";
            this.dTP_Erscheinungsdatum.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dTP_Erscheinungsdatum.Location = new System.Drawing.Point(140, 208);
            this.dTP_Erscheinungsdatum.MinimumSize = new System.Drawing.Size(0, 30);
            this.dTP_Erscheinungsdatum.Name = "dTP_Erscheinungsdatum";
            this.dTP_Erscheinungsdatum.Size = new System.Drawing.Size(175, 30);
            this.dTP_Erscheinungsdatum.TabIndex = 16;
            this.metroToolTip1.SetToolTip(this.dTP_Erscheinungsdatum, "    Wählen sie das Erscheinungsdatum ihres Buches hier aus.    ");
            this.dTP_Erscheinungsdatum.ValueChanged += new System.EventHandler(this.DTP_Erscheinungsdatum_ValueChanged);
            // 
            // bt_print
            // 
            this.bt_print.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.bt_print.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.bt_print.Location = new System.Drawing.Point(221, 453);
            this.bt_print.Name = "bt_print";
            this.bt_print.Size = new System.Drawing.Size(122, 24);
            this.bt_print.Style = MetroFramework.MetroColorStyle.Blue;
            this.bt_print.TabIndex = 25;
            this.bt_print.Text = "Drucken";
            this.metroToolTip1.SetToolTip(this.bt_print, "    Drucken Sie die eingegebene Anzahl Barcodes.    ");
            this.bt_print.UseSelectable = true;
            this.bt_print.Click += new System.EventHandler(this.bt_print_Click);
            // 
            // p_verlag
            // 
            this.p_verlag.Location = new System.Drawing.Point(140, 118);
            this.p_verlag.Name = "p_verlag";
            this.p_verlag.Size = new System.Drawing.Size(175, 24);
            this.p_verlag.TabIndex = 56;
            this.p_verlag.Visible = false;
            // 
            // metroLabel3
            // 
            this.metroLabel3.Location = new System.Drawing.Point(4, 453);
            this.metroLabel3.Margin = new System.Windows.Forms.Padding(3);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(151, 24);
            this.metroLabel3.TabIndex = 55;
            this.metroLabel3.Text = "Neue Barcodes drucken:";
            this.metroLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // p_genre
            // 
            this.p_genre.Location = new System.Drawing.Point(140, 148);
            this.p_genre.Name = "p_genre";
            this.p_genre.Size = new System.Drawing.Size(175, 24);
            this.p_genre.TabIndex = 56;
            this.p_genre.Visible = false;
            // 
            // tb_barcodePrinted
            // 
            // 
            // 
            // 
            this.tb_barcodePrinted.CustomButton.Image = null;
            this.tb_barcodePrinted.CustomButton.Location = new System.Drawing.Point(35, 2);
            this.tb_barcodePrinted.CustomButton.Margin = new System.Windows.Forms.Padding(2);
            this.tb_barcodePrinted.CustomButton.Name = "";
            this.tb_barcodePrinted.CustomButton.Size = new System.Drawing.Size(19, 19);
            this.tb_barcodePrinted.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tb_barcodePrinted.CustomButton.TabIndex = 1;
            this.tb_barcodePrinted.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tb_barcodePrinted.CustomButton.UseSelectable = true;
            this.tb_barcodePrinted.CustomButton.Visible = false;
            this.tb_barcodePrinted.Enabled = false;
            this.tb_barcodePrinted.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.tb_barcodePrinted.Lines = new string[0];
            this.tb_barcodePrinted.Location = new System.Drawing.Point(158, 423);
            this.tb_barcodePrinted.Margin = new System.Windows.Forms.Padding(3, 1, 3, 3);
            this.tb_barcodePrinted.MaximumSize = new System.Drawing.Size(375, 24);
            this.tb_barcodePrinted.MaxLength = 32767;
            this.tb_barcodePrinted.MinimumSize = new System.Drawing.Size(50, 24);
            this.tb_barcodePrinted.Name = "tb_barcodePrinted";
            this.tb_barcodePrinted.PasswordChar = '\0';
            this.tb_barcodePrinted.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tb_barcodePrinted.SelectedText = "";
            this.tb_barcodePrinted.SelectionLength = 0;
            this.tb_barcodePrinted.SelectionStart = 0;
            this.tb_barcodePrinted.ShortcutsEnabled = true;
            this.tb_barcodePrinted.Size = new System.Drawing.Size(57, 24);
            this.tb_barcodePrinted.TabIndex = 23;
            this.metroToolTip1.SetToolTip(this.tb_barcodePrinted, "    Die Anzahl der bereits gedruckten Barcodes.    ");
            this.tb_barcodePrinted.UseSelectable = true;
            this.tb_barcodePrinted.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tb_barcodePrinted.WaterMarkFont = new System.Drawing.Font("Segoe UI", 10.5F);
            // 
            // metroLabel2
            // 
            this.metroLabel2.Location = new System.Drawing.Point(4, 423);
            this.metroLabel2.Margin = new System.Windows.Forms.Padding(3);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(121, 24);
            this.metroLabel2.TabIndex = 49;
            this.metroLabel2.Text = "Barcodes gedruckt:";
            this.metroLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tb_barcodeAdd
            // 
            // 
            // 
            // 
            this.tb_barcodeAdd.CustomButton.Image = null;
            this.tb_barcodeAdd.CustomButton.Location = new System.Drawing.Point(35, 2);
            this.tb_barcodeAdd.CustomButton.Margin = new System.Windows.Forms.Padding(2);
            this.tb_barcodeAdd.CustomButton.Name = "";
            this.tb_barcodeAdd.CustomButton.Size = new System.Drawing.Size(19, 19);
            this.tb_barcodeAdd.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tb_barcodeAdd.CustomButton.TabIndex = 1;
            this.tb_barcodeAdd.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tb_barcodeAdd.CustomButton.UseSelectable = true;
            this.tb_barcodeAdd.CustomButton.Visible = false;
            this.tb_barcodeAdd.Enabled = false;
            this.tb_barcodeAdd.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.tb_barcodeAdd.Lines = new string[0];
            this.tb_barcodeAdd.Location = new System.Drawing.Point(158, 453);
            this.tb_barcodeAdd.Margin = new System.Windows.Forms.Padding(3, 3, 3, 1);
            this.tb_barcodeAdd.MaximumSize = new System.Drawing.Size(375, 24);
            this.tb_barcodeAdd.MaxLength = 32767;
            this.tb_barcodeAdd.MinimumSize = new System.Drawing.Size(50, 24);
            this.tb_barcodeAdd.Name = "tb_barcodeAdd";
            this.tb_barcodeAdd.PasswordChar = '\0';
            this.tb_barcodeAdd.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tb_barcodeAdd.SelectedText = "";
            this.tb_barcodeAdd.SelectionLength = 0;
            this.tb_barcodeAdd.SelectionStart = 0;
            this.tb_barcodeAdd.ShortcutsEnabled = false;
            this.tb_barcodeAdd.Size = new System.Drawing.Size(57, 24);
            this.tb_barcodeAdd.TabIndex = 24;
            this.metroToolTip1.SetToolTip(this.tb_barcodeAdd, "          Geben Sie hier eine Anzahl ein, um diese Anzahl Barcodes zu drucken. Es" +
        " werden nur neue Barcodes gedruckt, also zur Etikettierung von neuen Exemplaren." +
        "          ");
            this.tb_barcodeAdd.UseSelectable = true;
            this.tb_barcodeAdd.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tb_barcodeAdd.WaterMarkFont = new System.Drawing.Font("Segoe UI", 10.5F);
            this.tb_barcodeAdd.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_barcodeAdd_KeyPress);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(4, 303);
            this.metroLabel1.Margin = new System.Windows.Forms.Padding(3);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(157, 20);
            this.metroLabel1.TabIndex = 49;
            this.metroLabel1.Text = "Exemplare (neu) hinzuf.:";
            this.metroLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tb_neu
            // 
            // 
            // 
            // 
            this.tb_neu.CustomButton.Image = null;
            this.tb_neu.CustomButton.Location = new System.Drawing.Point(35, 2);
            this.tb_neu.CustomButton.Margin = new System.Windows.Forms.Padding(2);
            this.tb_neu.CustomButton.Name = "";
            this.tb_neu.CustomButton.Size = new System.Drawing.Size(19, 19);
            this.tb_neu.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tb_neu.CustomButton.TabIndex = 1;
            this.tb_neu.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tb_neu.CustomButton.UseSelectable = true;
            this.tb_neu.CustomButton.Visible = false;
            this.tb_neu.Enabled = false;
            this.tb_neu.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.tb_neu.Lines = new string[0];
            this.tb_neu.Location = new System.Drawing.Point(158, 303);
            this.tb_neu.MaximumSize = new System.Drawing.Size(375, 24);
            this.tb_neu.MaxLength = 32767;
            this.tb_neu.MinimumSize = new System.Drawing.Size(50, 24);
            this.tb_neu.Name = "tb_neu";
            this.tb_neu.PasswordChar = '\0';
            this.tb_neu.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tb_neu.SelectedText = "";
            this.tb_neu.SelectionLength = 0;
            this.tb_neu.SelectionStart = 0;
            this.tb_neu.ShortcutsEnabled = false;
            this.tb_neu.Size = new System.Drawing.Size(57, 24);
            this.tb_neu.TabIndex = 19;
            this.metroToolTip1.SetToolTip(this.tb_neu, "    Geben Sie die Anzahl der Exemplare an, die mitsamt des Buches hinzugefügt wer" +
        "den sollen.    ");
            this.tb_neu.UseSelectable = true;
            this.tb_neu.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tb_neu.WaterMarkFont = new System.Drawing.Font("Segoe UI", 10.5F);
            this.tb_neu.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_neu_KeyPress);
            // 
            // rb_search
            // 
            this.rb_search.AutoSize = true;
            this.rb_search.Checked = true;
            this.rb_search.FontSize = MetroFramework.MetroCheckBoxSize.Medium;
            this.rb_search.FontWeight = MetroFramework.MetroCheckBoxWeight.Light;
            this.rb_search.Location = new System.Drawing.Point(3, 3);
            this.rb_search.Name = "rb_search";
            this.rb_search.Size = new System.Drawing.Size(71, 20);
            this.rb_search.TabIndex = 1;
            this.rb_search.TabStop = true;
            this.rb_search.Text = "Suchen";
            this.metroToolTip1.SetToolTip(this.rb_search, "    Klicken sie hier, um nach einem Buch zu suchen.    ");
            this.rb_search.UseSelectable = true;
            this.rb_search.CheckedChanged += new System.EventHandler(this.rb_checked_changed);
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.BackgroundWorker1_DoWork);
            this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.BackgroundWorker1_RunWorkerCompleted);
            // 
            // timer2
            // 
            this.timer2.Enabled = true;
            this.timer2.Interval = 1000;
            this.timer2.Tick += new System.EventHandler(this.Timer2_Tick);
            // 
            // metroPanel2
            // 
            this.metroPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.metroPanel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.metroPanel2.Controls.Add(this.mtb_Import);
            this.metroPanel2.Controls.Add(this.bt_Schliessen);
            this.metroPanel2.Controls.Add(this.bt_exemplar);
            this.metroPanel2.Controls.Add(this.bt_Excel);
            this.metroPanel2.HorizontalScrollbarBarColor = true;
            this.metroPanel2.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel2.HorizontalScrollbarSize = 10;
            this.metroPanel2.Location = new System.Drawing.Point(376, 544);
            this.metroPanel2.Name = "metroPanel2";
            this.metroPanel2.Size = new System.Drawing.Size(801, 33);
            this.metroPanel2.TabIndex = 29;
            this.metroPanel2.VerticalScrollbarBarColor = true;
            this.metroPanel2.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel2.VerticalScrollbarSize = 10;
            // 
            // bt_exemplar
            // 
            this.bt_exemplar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bt_exemplar.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.bt_exemplar.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.bt_exemplar.Location = new System.Drawing.Point(548, 3);
            this.bt_exemplar.Name = "bt_exemplar";
            this.bt_exemplar.Size = new System.Drawing.Size(122, 24);
            this.bt_exemplar.TabIndex = 31;
            this.bt_exemplar.Text = "Exemplaransicht";
            this.metroToolTip1.SetToolTip(this.bt_exemplar, "    Wechseln Sie in die Exemplaransicht des gewählten Buches.    ");
            this.bt_exemplar.UseSelectable = true;
            this.bt_exemplar.Click += new System.EventHandler(this.Bt_exemplar_Click);
            // 
            // metroToolTip1
            // 
            this.metroToolTip1.Style = MetroFramework.MetroColorStyle.Default;
            this.metroToolTip1.StyleManager = null;
            this.metroToolTip1.Theme = MetroFramework.MetroThemeStyle.Default;
            // 
            // styleManagerBooks
            // 
            this.styleManagerBooks.Owner = this;
            // 
            // Form_Books
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1200, 600);
            this.Controls.Add(this.metroPanel2);
            this.Controls.Add(this.metroPanel1);
            this.Controls.Add(this.gb_zoom);
            this.Controls.Add(this.metroProgressSpinner1);
            this.Controls.Add(this.gridViewBook);
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(1200, 600);
            this.Name = "Form_Books";
            this.ShadowType = MetroFramework.Forms.MetroFormShadowType.AeroShadow;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Bücherverwaltung";
            this.Theme = MetroFramework.MetroThemeStyle.Default;
            this.Shown += new System.EventHandler(this.w_s_buecher_Activated);
            this.Click += new System.EventHandler(this.w_s_buecher_Click);
            ((System.ComponentModel.ISupportInitialize)(this.tsspracheBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewBook)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.gb_zoom.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picBox_Gross)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_Klein)).EndInit();
            this.metroPanel1.ResumeLayout(false);
            this.metroPanel1.PerformLayout();
            this.metroPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.styleManagerBooks)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource tsspracheBindingSource;
        private MetroFramework.Controls.MetroButton btSubmit;
        private MetroFramework.Controls.MetroLabel lb_Erscheinungsdatum;
        private MetroFramework.Controls.MetroTextBox tb_Auflage;
        private MetroFramework.Controls.MetroLabel lb_Auflage;
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
        private MetroFramework.Controls.MetroGrid gridViewBook;
        private MetroFramework.Controls.MetroRadioButton rb_Add_Buch;
        private MetroFramework.Controls.MetroRadioButton rb_Update_Buch;
        private MetroFramework.Controls.MetroRadioButton rb_Delete_Buch;
        public MetroFramework.Controls.MetroTextBox tb_ISBN;
        private MetroFramework.Controls.MetroButton bt_Schliessen;
        private MetroFramework.Controls.MetroButton bt_Excel;
        private MetroFramework.Controls.MetroButton bt_picture;
        private System.Windows.Forms.PictureBox picBox_Klein;
        private MetroFramework.Controls.MetroButton bt_pic_delete;
        private System.Windows.Forms.PictureBox picBox_Gross;
        private MetroFramework.Controls.MetroPanel gb_zoom;
        private MetroFramework.Controls.MetroButton button1;
        private MetroFramework.Controls.MetroCheckBox checkbox_autor;
        private AdvancedCheckedListBox checkedListBox1;
        private MetroFramework.Controls.MetroTextBox mtb_Nachricht;
        private System.Windows.Forms.HelpProvider helpProvider;
        private MetroFramework.Controls.MetroContextMenu contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ladenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem entfernenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exemplareToolStripMenuItem;
        private AdvancedComboBox comboBox1;
        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroTextBox tb_neu;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroTextBox tb_barcodePrinted;
        private MetroFramework.Controls.MetroTextBox tb_barcodeAdd;
        private MetroFramework.Controls.MetroButton bt_print;
        private MetroFramework.Controls.MetroProgressSpinner metroProgressSpinner1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Timer timer2;
        private MetroFramework.Controls.MetroDateTime dTP_Erscheinungsdatum;
        private MetroFramework.Controls.MetroButton mtb_Import;
        private MetroFramework.Controls.MetroPanel metroPanel2;
        private MetroFramework.Components.MetroToolTip metroToolTip1;
        private MetroFramework.Controls.MetroButton bt_exemplar;
        private MetroFramework.Controls.MetroRadioButton rb_search;
        private MetroFramework.Components.MetroStyleManager styleManagerBooks;
        private TransparentPanel p_sprache;
        private TransparentPanel p_genre;
        private TransparentPanel p_verlag;
        private TransparentPanel p_autor;
    }
}
