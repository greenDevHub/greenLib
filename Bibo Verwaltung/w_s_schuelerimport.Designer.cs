namespace Bibo_Verwaltung
{
    partial class w_s_schuelerimport
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
            this.lb_TxtQuali = new System.Windows.Forms.Label();
            this.gv_Vorschau = new System.Windows.Forms.DataGridView();
            this.lb_FeldTrenn = new System.Windows.Forms.Label();
            this.bt_Vorschau = new System.Windows.Forms.Button();
            this.bt_usepreset = new System.Windows.Forms.Button();
            this.rb_faecher = new System.Windows.Forms.RadioButton();
            this.rb_schueler2 = new System.Windows.Forms.RadioButton();
            this.rb_schueler1 = new System.Windows.Forms.RadioButton();
            this.gv_columns = new System.Windows.Forms.DataGridView();
            this.bt_Abbrechen = new System.Windows.Forms.Button();
            this.cb_ColHeader = new System.Windows.Forms.CheckBox();
            this.cb_TxtQuali = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_lines = new System.Windows.Forms.TextBox();
            this.cb_FeldTrenn = new System.Windows.Forms.ComboBox();
            this.lb_path = new System.Windows.Forms.Label();
            this.bt_durchsuchen = new System.Windows.Forms.Button();
            this.tb_path = new System.Windows.Forms.TextBox();
            this.bibo_VerwaltungDataSet1 = new Bibo_Verwaltung.Bibo_VerwaltungDataSet();
            this.bt_accept = new System.Windows.Forms.Button();
            this.bt_saveProfile = new System.Windows.Forms.Button();
            this.rb_single = new System.Windows.Forms.RadioButton();
            this.rb_multi = new System.Windows.Forms.RadioButton();
            this.slider_preview = new System.Windows.Forms.HScrollBar();
            this.tb_min = new System.Windows.Forms.TextBox();
            this.tb_max = new System.Windows.Forms.TextBox();
            this.tb_aktuell = new System.Windows.Forms.TextBox();
            this.bt_removefile = new System.Windows.Forms.Button();
            this.lb_Importmodus = new System.Windows.Forms.Label();
            this.lb_Vorschau = new System.Windows.Forms.Label();
            this.lb_Vorschau1 = new System.Windows.Forms.Label();
            this.gb_file = new System.Windows.Forms.GroupBox();
            this.gb_format = new System.Windows.Forms.GroupBox();
            this.gb_target = new System.Windows.Forms.GroupBox();
            this.gb_preview = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.backgroundWorker = new System.ComponentModel.BackgroundWorker();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            ((System.ComponentModel.ISupportInitialize)(this.gv_Vorschau)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_columns)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bibo_VerwaltungDataSet1)).BeginInit();
            this.gb_file.SuspendLayout();
            this.gb_format.SuspendLayout();
            this.gb_target.SuspendLayout();
            this.gb_preview.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lb_TxtQuali
            // 
            this.lb_TxtQuali.AutoSize = true;
            this.lb_TxtQuali.Location = new System.Drawing.Point(6, 54);
            this.lb_TxtQuali.Margin = new System.Windows.Forms.Padding(4);
            this.lb_TxtQuali.Name = "lb_TxtQuali";
            this.lb_TxtQuali.Size = new System.Drawing.Size(112, 17);
            this.lb_TxtQuali.TabIndex = 1;
            this.lb_TxtQuali.Text = "Textqualifizierer:";
            // 
            // gv_Vorschau
            // 
            this.gv_Vorschau.AllowUserToAddRows = false;
            this.gv_Vorschau.AllowUserToDeleteRows = false;
            this.gv_Vorschau.AllowUserToOrderColumns = true;
            this.gv_Vorschau.AllowUserToResizeColumns = false;
            this.gv_Vorschau.AllowUserToResizeRows = false;
            this.gv_Vorschau.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.gv_Vorschau.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gv_Vorschau.Enabled = false;
            this.gv_Vorschau.Location = new System.Drawing.Point(91, 65);
            this.gv_Vorschau.Margin = new System.Windows.Forms.Padding(4);
            this.gv_Vorschau.MultiSelect = false;
            this.gv_Vorschau.Name = "gv_Vorschau";
            this.gv_Vorschau.ReadOnly = true;
            this.gv_Vorschau.RowHeadersVisible = false;
            this.gv_Vorschau.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.gv_Vorschau.ShowEditingIcon = false;
            this.gv_Vorschau.Size = new System.Drawing.Size(916, 96);
            this.gv_Vorschau.TabIndex = 23;
            this.gv_Vorschau.TabStop = false;
            this.gv_Vorschau.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gv_Vorschau_KeyDown);
            // 
            // lb_FeldTrenn
            // 
            this.lb_FeldTrenn.AutoSize = true;
            this.lb_FeldTrenn.Location = new System.Drawing.Point(6, 21);
            this.lb_FeldTrenn.Margin = new System.Windows.Forms.Padding(4);
            this.lb_FeldTrenn.Name = "lb_FeldTrenn";
            this.lb_FeldTrenn.Size = new System.Drawing.Size(121, 17);
            this.lb_FeldTrenn.TabIndex = 0;
            this.lb_FeldTrenn.Text = "Feldtrennzeichen:";
            // 
            // bt_Vorschau
            // 
            this.bt_Vorschau.Enabled = false;
            this.bt_Vorschau.Location = new System.Drawing.Point(91, 169);
            this.bt_Vorschau.Margin = new System.Windows.Forms.Padding(4);
            this.bt_Vorschau.Name = "bt_Vorschau";
            this.bt_Vorschau.Size = new System.Drawing.Size(223, 26);
            this.bt_Vorschau.TabIndex = 25;
            this.bt_Vorschau.Text = "Vorschau";
            this.bt_Vorschau.UseVisualStyleBackColor = true;
            this.bt_Vorschau.Click += new System.EventHandler(this.bt_Vorschau_Click);
            // 
            // bt_usepreset
            // 
            this.bt_usepreset.Enabled = false;
            this.bt_usepreset.Location = new System.Drawing.Point(784, 203);
            this.bt_usepreset.Margin = new System.Windows.Forms.Padding(4);
            this.bt_usepreset.Name = "bt_usepreset";
            this.bt_usepreset.Size = new System.Drawing.Size(223, 26);
            this.bt_usepreset.TabIndex = 28;
            this.bt_usepreset.Text = "Vorlage anwenden";
            this.bt_usepreset.UseVisualStyleBackColor = true;
            this.bt_usepreset.Click += new System.EventHandler(this.bt_Import_Click);
            // 
            // rb_faecher
            // 
            this.rb_faecher.AutoSize = true;
            this.rb_faecher.Location = new System.Drawing.Point(383, 21);
            this.rb_faecher.Margin = new System.Windows.Forms.Padding(4);
            this.rb_faecher.Name = "rb_faecher";
            this.rb_faecher.Size = new System.Drawing.Size(73, 21);
            this.rb_faecher.TabIndex = 2;
            this.rb_faecher.Text = "Fächer";
            this.rb_faecher.UseVisualStyleBackColor = true;
            this.rb_faecher.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // rb_schueler2
            // 
            this.rb_schueler2.AutoSize = true;
            this.rb_schueler2.Location = new System.Drawing.Point(182, 21);
            this.rb_schueler2.Margin = new System.Windows.Forms.Padding(4);
            this.rb_schueler2.Name = "rb_schueler2";
            this.rb_schueler2.Size = new System.Drawing.Size(133, 21);
            this.rb_schueler2.TabIndex = 2;
            this.rb_schueler2.Text = "Sekundarstufe 2";
            this.rb_schueler2.UseVisualStyleBackColor = true;
            this.rb_schueler2.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // rb_schueler1
            // 
            this.rb_schueler1.AutoSize = true;
            this.rb_schueler1.Checked = true;
            this.rb_schueler1.Location = new System.Drawing.Point(6, 21);
            this.rb_schueler1.Margin = new System.Windows.Forms.Padding(4);
            this.rb_schueler1.Name = "rb_schueler1";
            this.rb_schueler1.Size = new System.Drawing.Size(133, 21);
            this.rb_schueler1.TabIndex = 1;
            this.rb_schueler1.TabStop = true;
            this.rb_schueler1.Text = "Sekundarstufe 1";
            this.rb_schueler1.UseVisualStyleBackColor = true;
            this.rb_schueler1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // gv_columns
            // 
            this.gv_columns.AllowUserToAddRows = false;
            this.gv_columns.AllowUserToDeleteRows = false;
            this.gv_columns.AllowUserToResizeColumns = false;
            this.gv_columns.AllowUserToResizeRows = false;
            this.gv_columns.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.gv_columns.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gv_columns.Enabled = false;
            this.gv_columns.Location = new System.Drawing.Point(91, 21);
            this.gv_columns.Margin = new System.Windows.Forms.Padding(4);
            this.gv_columns.Name = "gv_columns";
            this.gv_columns.RowTemplate.Height = 40;
            this.gv_columns.Size = new System.Drawing.Size(916, 36);
            this.gv_columns.TabIndex = 31;
            // 
            // bt_Abbrechen
            // 
            this.bt_Abbrechen.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.bt_Abbrechen.Location = new System.Drawing.Point(553, 169);
            this.bt_Abbrechen.Margin = new System.Windows.Forms.Padding(4);
            this.bt_Abbrechen.Name = "bt_Abbrechen";
            this.bt_Abbrechen.Size = new System.Drawing.Size(223, 26);
            this.bt_Abbrechen.TabIndex = 29;
            this.bt_Abbrechen.Text = "Abbrechen";
            this.bt_Abbrechen.UseVisualStyleBackColor = true;
            // 
            // cb_ColHeader
            // 
            this.cb_ColHeader.AutoSize = true;
            this.cb_ColHeader.Location = new System.Drawing.Point(182, 117);
            this.cb_ColHeader.Margin = new System.Windows.Forms.Padding(4);
            this.cb_ColHeader.Name = "cb_ColHeader";
            this.cb_ColHeader.Size = new System.Drawing.Size(219, 21);
            this.cb_ColHeader.TabIndex = 5;
            this.cb_ColHeader.Text = "Erste Zeile enthält Feldnamen";
            this.cb_ColHeader.UseVisualStyleBackColor = true;
            // 
            // cb_TxtQuali
            // 
            this.cb_TxtQuali.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_TxtQuali.Font = new System.Drawing.Font("Candara", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_TxtQuali.FormattingEnabled = true;
            this.cb_TxtQuali.Items.AddRange(new object[] {
            "\"",
            "\'"});
            this.cb_TxtQuali.Location = new System.Drawing.Point(182, 54);
            this.cb_TxtQuali.Margin = new System.Windows.Forms.Padding(4);
            this.cb_TxtQuali.Name = "cb_TxtQuali";
            this.cb_TxtQuali.Size = new System.Drawing.Size(249, 25);
            this.cb_TxtQuali.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 87);
            this.label1.Margin = new System.Windows.Forms.Padding(4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 17);
            this.label1.TabIndex = 7;
            this.label1.Text = "Obere Zeilen Entfernen:";
            // 
            // tb_lines
            // 
            this.tb_lines.Location = new System.Drawing.Point(182, 87);
            this.tb_lines.Margin = new System.Windows.Forms.Padding(4);
            this.tb_lines.Name = "tb_lines";
            this.tb_lines.Size = new System.Drawing.Size(249, 22);
            this.tb_lines.TabIndex = 6;
            this.tb_lines.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_lines_KeyPress);
            // 
            // cb_FeldTrenn
            // 
            this.cb_FeldTrenn.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_FeldTrenn.Font = new System.Drawing.Font("Candara", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_FeldTrenn.FormattingEnabled = true;
            this.cb_FeldTrenn.Items.AddRange(new object[] {
            ",",
            ";",
            "{Tabulator}",
            "{Leerzeichen}"});
            this.cb_FeldTrenn.Location = new System.Drawing.Point(182, 21);
            this.cb_FeldTrenn.Margin = new System.Windows.Forms.Padding(4);
            this.cb_FeldTrenn.Name = "cb_FeldTrenn";
            this.cb_FeldTrenn.Size = new System.Drawing.Size(249, 25);
            this.cb_FeldTrenn.TabIndex = 3;
            // 
            // lb_path
            // 
            this.lb_path.AutoSize = true;
            this.lb_path.Location = new System.Drawing.Point(6, 49);
            this.lb_path.Margin = new System.Windows.Forms.Padding(4);
            this.lb_path.Name = "lb_path";
            this.lb_path.Size = new System.Drawing.Size(80, 17);
            this.lb_path.TabIndex = 21;
            this.lb_path.Text = "Dateiname:";
            // 
            // bt_durchsuchen
            // 
            this.bt_durchsuchen.Location = new System.Drawing.Point(106, 79);
            this.bt_durchsuchen.Margin = new System.Windows.Forms.Padding(4);
            this.bt_durchsuchen.Name = "bt_durchsuchen";
            this.bt_durchsuchen.Size = new System.Drawing.Size(379, 28);
            this.bt_durchsuchen.TabIndex = 18;
            this.bt_durchsuchen.Text = "Durchsuchen";
            this.bt_durchsuchen.UseVisualStyleBackColor = true;
            this.bt_durchsuchen.Click += new System.EventHandler(this.bt_durchsuchen_Click);
            // 
            // tb_path
            // 
            this.tb_path.Enabled = false;
            this.tb_path.Location = new System.Drawing.Point(106, 49);
            this.tb_path.Margin = new System.Windows.Forms.Padding(4);
            this.tb_path.Name = "tb_path";
            this.tb_path.Size = new System.Drawing.Size(379, 22);
            this.tb_path.TabIndex = 17;
            this.tb_path.TextChanged += new System.EventHandler(this.tb_path_TextChanged);
            // 
            // bibo_VerwaltungDataSet1
            // 
            this.bibo_VerwaltungDataSet1.DataSetName = "Bibo_VerwaltungDataSet";
            this.bibo_VerwaltungDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bt_accept
            // 
            this.bt_accept.Enabled = false;
            this.bt_accept.Location = new System.Drawing.Point(322, 169);
            this.bt_accept.Margin = new System.Windows.Forms.Padding(4);
            this.bt_accept.Name = "bt_accept";
            this.bt_accept.Size = new System.Drawing.Size(223, 26);
            this.bt_accept.TabIndex = 32;
            this.bt_accept.Text = "Importieren";
            this.bt_accept.UseVisualStyleBackColor = true;
            this.bt_accept.Click += new System.EventHandler(this.bt_accept_Click);
            // 
            // bt_saveProfile
            // 
            this.bt_saveProfile.Location = new System.Drawing.Point(784, 169);
            this.bt_saveProfile.Margin = new System.Windows.Forms.Padding(4);
            this.bt_saveProfile.Name = "bt_saveProfile";
            this.bt_saveProfile.Size = new System.Drawing.Size(223, 26);
            this.bt_saveProfile.TabIndex = 28;
            this.bt_saveProfile.Text = "Vorlage speichern";
            this.bt_saveProfile.UseVisualStyleBackColor = true;
            this.bt_saveProfile.Click += new System.EventHandler(this.bt_saveProfile_Click);
            // 
            // rb_single
            // 
            this.rb_single.AutoSize = true;
            this.rb_single.Checked = true;
            this.rb_single.Location = new System.Drawing.Point(106, 21);
            this.rb_single.Margin = new System.Windows.Forms.Padding(4);
            this.rb_single.Name = "rb_single";
            this.rb_single.Size = new System.Drawing.Size(165, 21);
            this.rb_single.TabIndex = 0;
            this.rb_single.TabStop = true;
            this.rb_single.Text = "Eine Datei auswählen";
            this.rb_single.UseVisualStyleBackColor = true;
            this.rb_single.CheckedChanged += new System.EventHandler(this.rb_single_CheckedChanged);
            // 
            // rb_multi
            // 
            this.rb_multi.AutoSize = true;
            this.rb_multi.Location = new System.Drawing.Point(279, 21);
            this.rb_multi.Margin = new System.Windows.Forms.Padding(4);
            this.rb_multi.Name = "rb_multi";
            this.rb_multi.Size = new System.Drawing.Size(206, 21);
            this.rb_multi.TabIndex = 0;
            this.rb_multi.Text = "Mehrere Dateien auswählen";
            this.rb_multi.UseVisualStyleBackColor = true;
            this.rb_multi.CheckedChanged += new System.EventHandler(this.rb_single_CheckedChanged);
            // 
            // slider_preview
            // 
            this.slider_preview.LargeChange = 1;
            this.slider_preview.Location = new System.Drawing.Point(57, 21);
            this.slider_preview.Margin = new System.Windows.Forms.Padding(4);
            this.slider_preview.Maximum = 0;
            this.slider_preview.MaximumSize = new System.Drawing.Size(432, 22);
            this.slider_preview.Name = "slider_preview";
            this.slider_preview.Size = new System.Drawing.Size(432, 22);
            this.slider_preview.TabIndex = 35;
            this.slider_preview.ValueChanged += new System.EventHandler(this.slider_preview_ValueChanged);
            // 
            // tb_min
            // 
            this.tb_min.Enabled = false;
            this.tb_min.Location = new System.Drawing.Point(6, 21);
            this.tb_min.Margin = new System.Windows.Forms.Padding(4);
            this.tb_min.Name = "tb_min";
            this.tb_min.Size = new System.Drawing.Size(43, 22);
            this.tb_min.TabIndex = 36;
            // 
            // tb_max
            // 
            this.tb_max.Enabled = false;
            this.tb_max.Location = new System.Drawing.Point(497, 21);
            this.tb_max.Margin = new System.Windows.Forms.Padding(4);
            this.tb_max.Name = "tb_max";
            this.tb_max.Size = new System.Drawing.Size(43, 22);
            this.tb_max.TabIndex = 36;
            // 
            // tb_aktuell
            // 
            this.tb_aktuell.Enabled = false;
            this.tb_aktuell.Location = new System.Drawing.Point(57, 51);
            this.tb_aktuell.Margin = new System.Windows.Forms.Padding(4);
            this.tb_aktuell.Name = "tb_aktuell";
            this.tb_aktuell.Size = new System.Drawing.Size(432, 22);
            this.tb_aktuell.TabIndex = 37;
            // 
            // bt_removefile
            // 
            this.bt_removefile.Enabled = false;
            this.bt_removefile.Location = new System.Drawing.Point(57, 81);
            this.bt_removefile.Margin = new System.Windows.Forms.Padding(4);
            this.bt_removefile.Name = "bt_removefile";
            this.bt_removefile.Size = new System.Drawing.Size(432, 28);
            this.bt_removefile.TabIndex = 38;
            this.bt_removefile.Text = "Datei entfernen";
            this.bt_removefile.UseVisualStyleBackColor = true;
            this.bt_removefile.Click += new System.EventHandler(this.bt_removefile_Click);
            // 
            // lb_Importmodus
            // 
            this.lb_Importmodus.AutoSize = true;
            this.lb_Importmodus.Location = new System.Drawing.Point(6, 21);
            this.lb_Importmodus.Margin = new System.Windows.Forms.Padding(4);
            this.lb_Importmodus.Name = "lb_Importmodus";
            this.lb_Importmodus.Size = new System.Drawing.Size(93, 17);
            this.lb_Importmodus.TabIndex = 0;
            this.lb_Importmodus.Text = "Importmodus:";
            // 
            // lb_Vorschau
            // 
            this.lb_Vorschau.AutoSize = true;
            this.lb_Vorschau.Location = new System.Drawing.Point(6, 21);
            this.lb_Vorschau.Margin = new System.Windows.Forms.Padding(4);
            this.lb_Vorschau.Name = "lb_Vorschau";
            this.lb_Vorschau.Size = new System.Drawing.Size(77, 17);
            this.lb_Vorschau.TabIndex = 42;
            this.lb_Vorschau.Text = "Zieltabelle:";
            // 
            // lb_Vorschau1
            // 
            this.lb_Vorschau1.AutoSize = true;
            this.lb_Vorschau1.Location = new System.Drawing.Point(6, 65);
            this.lb_Vorschau1.Margin = new System.Windows.Forms.Padding(4);
            this.lb_Vorschau1.Name = "lb_Vorschau1";
            this.lb_Vorschau1.Size = new System.Drawing.Size(72, 17);
            this.lb_Vorschau1.TabIndex = 42;
            this.lb_Vorschau1.Text = "Vorschau:";
            // 
            // gb_file
            // 
            this.gb_file.Controls.Add(this.lb_Importmodus);
            this.gb_file.Controls.Add(this.rb_single);
            this.gb_file.Controls.Add(this.rb_multi);
            this.gb_file.Controls.Add(this.bt_durchsuchen);
            this.gb_file.Controls.Add(this.tb_path);
            this.gb_file.Controls.Add(this.lb_path);
            this.gb_file.Location = new System.Drawing.Point(13, 13);
            this.gb_file.Margin = new System.Windows.Forms.Padding(4);
            this.gb_file.Name = "gb_file";
            this.gb_file.Padding = new System.Windows.Forms.Padding(2);
            this.gb_file.Size = new System.Drawing.Size(568, 113);
            this.gb_file.TabIndex = 45;
            this.gb_file.TabStop = false;
            this.gb_file.Text = "Wählen Sie eine oder mehrere Dateien aus";
            // 
            // gb_format
            // 
            this.gb_format.Controls.Add(this.lb_FeldTrenn);
            this.gb_format.Controls.Add(this.cb_FeldTrenn);
            this.gb_format.Controls.Add(this.lb_TxtQuali);
            this.gb_format.Controls.Add(this.cb_TxtQuali);
            this.gb_format.Controls.Add(this.label1);
            this.gb_format.Controls.Add(this.tb_lines);
            this.gb_format.Controls.Add(this.cb_ColHeader);
            this.gb_format.Location = new System.Drawing.Point(589, 102);
            this.gb_format.Margin = new System.Windows.Forms.Padding(4);
            this.gb_format.Name = "gb_format";
            this.gb_format.Padding = new System.Windows.Forms.Padding(2);
            this.gb_format.Size = new System.Drawing.Size(462, 146);
            this.gb_format.TabIndex = 46;
            this.gb_format.TabStop = false;
            this.gb_format.Text = "Stellen Sie die Formatierung ein";
            // 
            // gb_target
            // 
            this.gb_target.Controls.Add(this.rb_schueler1);
            this.gb_target.Controls.Add(this.rb_schueler2);
            this.gb_target.Controls.Add(this.rb_faecher);
            this.gb_target.Location = new System.Drawing.Point(589, 13);
            this.gb_target.Margin = new System.Windows.Forms.Padding(4);
            this.gb_target.Name = "gb_target";
            this.gb_target.Padding = new System.Windows.Forms.Padding(2);
            this.gb_target.Size = new System.Drawing.Size(462, 81);
            this.gb_target.TabIndex = 47;
            this.gb_target.TabStop = false;
            this.gb_target.Text = "Wählen Sie das Importziel";
            // 
            // gb_preview
            // 
            this.gb_preview.Controls.Add(this.progressBar1);
            this.gb_preview.Controls.Add(this.lb_Vorschau);
            this.gb_preview.Controls.Add(this.gv_columns);
            this.gb_preview.Controls.Add(this.bt_accept);
            this.gb_preview.Controls.Add(this.lb_Vorschau1);
            this.gb_preview.Controls.Add(this.gv_Vorschau);
            this.gb_preview.Controls.Add(this.bt_Abbrechen);
            this.gb_preview.Controls.Add(this.bt_usepreset);
            this.gb_preview.Controls.Add(this.bt_Vorschau);
            this.gb_preview.Controls.Add(this.bt_saveProfile);
            this.gb_preview.Location = new System.Drawing.Point(13, 256);
            this.gb_preview.Margin = new System.Windows.Forms.Padding(4);
            this.gb_preview.Name = "gb_preview";
            this.gb_preview.Padding = new System.Windows.Forms.Padding(2);
            this.gb_preview.Size = new System.Drawing.Size(1038, 244);
            this.gb_preview.TabIndex = 48;
            this.gb_preview.TabStop = false;
            this.gb_preview.Text = "Anzeige der Vorschau";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.slider_preview);
            this.groupBox1.Controls.Add(this.bt_removefile);
            this.groupBox1.Controls.Add(this.tb_aktuell);
            this.groupBox1.Controls.Add(this.tb_max);
            this.groupBox1.Controls.Add(this.tb_min);
            this.groupBox1.Location = new System.Drawing.Point(13, 134);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(568, 114);
            this.groupBox1.TabIndex = 49;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Durch die Dateien scrollen";
            // 
            // backgroundWorker
            // 
            this.backgroundWorker.WorkerReportsProgress = true;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(91, 203);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(685, 26);
            this.progressBar1.Step = 1;
            this.progressBar1.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progressBar1.TabIndex = 43;
            // 
            // w_s_schuelerimport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1059, 508);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gb_preview);
            this.Controls.Add(this.gb_target);
            this.Controls.Add(this.gb_format);
            this.Controls.Add(this.gb_file);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.MinimumSize = new System.Drawing.Size(910, 545);
            this.Name = "w_s_schuelerimport";
            this.Text = "Import von Schülern";
            ((System.ComponentModel.ISupportInitialize)(this.gv_Vorschau)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_columns)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bibo_VerwaltungDataSet1)).EndInit();
            this.gb_file.ResumeLayout(false);
            this.gb_file.PerformLayout();
            this.gb_format.ResumeLayout(false);
            this.gb_format.PerformLayout();
            this.gb_target.ResumeLayout(false);
            this.gb_target.PerformLayout();
            this.gb_preview.ResumeLayout(false);
            this.gb_preview.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lb_TxtQuali;
        private System.Windows.Forms.DataGridView gv_Vorschau;
        private System.Windows.Forms.Label lb_FeldTrenn;
        private System.Windows.Forms.Button bt_Vorschau;
        private System.Windows.Forms.Button bt_usepreset;
        private System.Windows.Forms.DataGridView gv_columns;
        private System.Windows.Forms.Button bt_Abbrechen;
        private System.Windows.Forms.CheckBox cb_ColHeader;
        private System.Windows.Forms.ComboBox cb_TxtQuali;
        private System.Windows.Forms.ComboBox cb_FeldTrenn;
        private System.Windows.Forms.Label lb_path;
        private System.Windows.Forms.Button bt_durchsuchen;
        private System.Windows.Forms.TextBox tb_path;
        private Bibo_VerwaltungDataSet bibo_VerwaltungDataSet1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_lines;
        private System.Windows.Forms.Button bt_accept;
        private System.Windows.Forms.RadioButton rb_schueler2;
        private System.Windows.Forms.RadioButton rb_schueler1;
        private System.Windows.Forms.Button bt_saveProfile;
        private System.Windows.Forms.RadioButton rb_faecher;
        private System.Windows.Forms.RadioButton rb_multi;
        private System.Windows.Forms.RadioButton rb_single;
        private System.Windows.Forms.HScrollBar slider_preview;
        private System.Windows.Forms.TextBox tb_min;
        private System.Windows.Forms.TextBox tb_max;
        private System.Windows.Forms.TextBox tb_aktuell;
        private System.Windows.Forms.Button bt_removefile;
        private System.Windows.Forms.Label lb_Importmodus;
        private System.Windows.Forms.Label lb_Vorschau;
        private System.Windows.Forms.Label lb_Vorschau1;
        private System.Windows.Forms.GroupBox gb_file;
        private System.Windows.Forms.GroupBox gb_format;
        private System.Windows.Forms.GroupBox gb_target;
        private System.Windows.Forms.GroupBox gb_preview;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.ComponentModel.BackgroundWorker backgroundWorker;
        private System.Windows.Forms.ProgressBar progressBar1;
    }
}