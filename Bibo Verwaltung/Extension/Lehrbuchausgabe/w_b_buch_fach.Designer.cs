﻿namespace Bibo_Verwaltung
{
    partial class w_s_buch_fach
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
            this.lb_fach = new System.Windows.Forms.Label();
            this.cb_fach = new System.Windows.Forms.ComboBox();
            this.bt_klasse = new System.Windows.Forms.Label();
            this.cb_klasse = new System.Windows.Forms.ComboBox();
            this.lb_buch = new System.Windows.Forms.Label();
            this.cb_buch1 = new System.Windows.Forms.ComboBox();
            this.bt_export = new System.Windows.Forms.Button();
            this.bt_close = new System.Windows.Forms.Button();
            this.gB_buchid = new System.Windows.Forms.GroupBox();
            this.cb_1 = new System.Windows.Forms.CheckBox();
            this.tLP_1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.bt_add = new System.Windows.Forms.Button();
            this.bt_clear = new System.Windows.Forms.Button();
            this.cb_buch2 = new System.Windows.Forms.ComboBox();
            this.cb_buch3 = new System.Windows.Forms.ComboBox();
            this.cb_buch4 = new System.Windows.Forms.ComboBox();
            this.cb_buch5 = new System.Windows.Forms.ComboBox();
            this.cb_buch6 = new System.Windows.Forms.ComboBox();
            this.cb_buch7 = new System.Windows.Forms.ComboBox();
            this.cb_buch8 = new System.Windows.Forms.ComboBox();
            this.bt_buch1 = new System.Windows.Forms.Button();
            this.bt_buch2 = new System.Windows.Forms.Button();
            this.bt_buch3 = new System.Windows.Forms.Button();
            this.bt_buch4 = new System.Windows.Forms.Button();
            this.bt_buch5 = new System.Windows.Forms.Button();
            this.bt_buch6 = new System.Windows.Forms.Button();
            this.bt_buch7 = new System.Windows.Forms.Button();
            this.bt_buch8 = new System.Windows.Forms.Button();
            this.lb = new System.Windows.Forms.Label();
            this.rb_delete = new System.Windows.Forms.RadioButton();
            this.rb_edit = new System.Windows.Forms.RadioButton();
            this.rb_neu = new System.Windows.Forms.RadioButton();
            this.gv_bf = new System.Windows.Forms.DataGridView();
            this.gB_buchid.SuspendLayout();
            this.tLP_1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gv_bf)).BeginInit();
            this.SuspendLayout();
            // 
            // lb_fach
            // 
            this.lb_fach.AutoSize = true;
            this.lb_fach.Location = new System.Drawing.Point(12, 106);
            this.lb_fach.Name = "lb_fach";
            this.lb_fach.Size = new System.Drawing.Size(78, 32);
            this.lb_fach.TabIndex = 1;
            this.lb_fach.Text = "Fach";
            // 
            // cb_fach
            // 
            this.cb_fach.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cb_fach.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cb_fach.FormattingEnabled = true;
            this.cb_fach.Location = new System.Drawing.Point(264, 103);
            this.cb_fach.Name = "cb_fach";
            this.cb_fach.Size = new System.Drawing.Size(414, 39);
            this.cb_fach.TabIndex = 2;
            // 
            // bt_klasse
            // 
            this.bt_klasse.AutoSize = true;
            this.bt_klasse.Location = new System.Drawing.Point(12, 163);
            this.bt_klasse.Name = "bt_klasse";
            this.bt_klasse.Size = new System.Drawing.Size(101, 32);
            this.bt_klasse.TabIndex = 1;
            this.bt_klasse.Text = "Klasse";
            // 
            // cb_klasse
            // 
            this.cb_klasse.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cb_klasse.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cb_klasse.FormattingEnabled = true;
            this.cb_klasse.Items.AddRange(new object[] {
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11 LK",
            "11 GK",
            "12 LK",
            "12 GK"});
            this.cb_klasse.Location = new System.Drawing.Point(264, 163);
            this.cb_klasse.Name = "cb_klasse";
            this.cb_klasse.Size = new System.Drawing.Size(414, 39);
            this.cb_klasse.TabIndex = 2;
            // 
            // lb_buch
            // 
            this.lb_buch.AutoSize = true;
            this.lb_buch.Location = new System.Drawing.Point(12, 226);
            this.lb_buch.Name = "lb_buch";
            this.lb_buch.Size = new System.Drawing.Size(80, 32);
            this.lb_buch.TabIndex = 1;
            this.lb_buch.Text = "Buch";
            // 
            // cb_buch1
            // 
            this.cb_buch1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cb_buch1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cb_buch1.DropDownHeight = 1;
            this.cb_buch1.DropDownWidth = 1;
            this.cb_buch1.FormattingEnabled = true;
            this.cb_buch1.IntegralHeight = false;
            this.cb_buch1.Location = new System.Drawing.Point(3, 3);
            this.cb_buch1.Name = "cb_buch1";
            this.cb_buch1.Size = new System.Drawing.Size(414, 39);
            this.cb_buch1.TabIndex = 2;
            this.cb_buch1.DropDown += new System.EventHandler(this.comboboxClicked);
            this.cb_buch1.SelectedIndexChanged += new System.EventHandler(this.cb_selected);
            this.cb_buch1.Click += new System.EventHandler(this.comboboxClicked);
            // 
            // bt_export
            // 
            this.bt_export.Location = new System.Drawing.Point(799, 978);
            this.bt_export.Margin = new System.Windows.Forms.Padding(8);
            this.bt_export.Name = "bt_export";
            this.bt_export.Size = new System.Drawing.Size(698, 54);
            this.bt_export.TabIndex = 26;
            this.bt_export.Text = "Exportieren";
            this.bt_export.UseVisualStyleBackColor = true;
            // 
            // bt_close
            // 
            this.bt_close.Location = new System.Drawing.Point(1641, 978);
            this.bt_close.Margin = new System.Windows.Forms.Padding(8);
            this.bt_close.Name = "bt_close";
            this.bt_close.Size = new System.Drawing.Size(698, 54);
            this.bt_close.TabIndex = 25;
            this.bt_close.Text = "Schließen";
            this.bt_close.UseVisualStyleBackColor = true;
            // 
            // gB_buchid
            // 
            this.gB_buchid.Controls.Add(this.cb_1);
            this.gB_buchid.Controls.Add(this.tLP_1);
            this.gB_buchid.Controls.Add(this.lb_fach);
            this.gB_buchid.Controls.Add(this.cb_klasse);
            this.gB_buchid.Controls.Add(this.bt_klasse);
            this.gB_buchid.Controls.Add(this.cb_fach);
            this.gB_buchid.Controls.Add(this.lb_buch);
            this.gB_buchid.Controls.Add(this.lb);
            this.gB_buchid.Controls.Add(this.rb_delete);
            this.gB_buchid.Controls.Add(this.rb_edit);
            this.gB_buchid.Controls.Add(this.rb_neu);
            this.gB_buchid.Location = new System.Drawing.Point(15, 17);
            this.gB_buchid.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.gB_buchid.Name = "gB_buchid";
            this.gB_buchid.Padding = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.gB_buchid.Size = new System.Drawing.Size(758, 1015);
            this.gB_buchid.TabIndex = 24;
            this.gB_buchid.TabStop = false;
            this.gB_buchid.Text = "Bücher";
            // 
            // cb_1
            // 
            this.cb_1.AutoSize = true;
            this.cb_1.Location = new System.Drawing.Point(0, 968);
            this.cb_1.Name = "cb_1";
            this.cb_1.Size = new System.Drawing.Size(558, 36);
            this.cb_1.TabIndex = 21;
            this.cb_1.Text = "Automatisches Ändern der Klassenstufe";
            this.cb_1.UseVisualStyleBackColor = true;
            this.cb_1.CheckedChanged += new System.EventHandler(this.cb_1_CheckedChanged);
            // 
            // tLP_1
            // 
            this.tLP_1.ColumnCount = 2;
            this.tLP_1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 87.21935F));
            this.tLP_1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.78066F));
            this.tLP_1.Controls.Add(this.tableLayoutPanel2, 0, 8);
            this.tLP_1.Controls.Add(this.cb_buch1, 0, 0);
            this.tLP_1.Controls.Add(this.cb_buch2, 0, 1);
            this.tLP_1.Controls.Add(this.cb_buch3, 0, 2);
            this.tLP_1.Controls.Add(this.cb_buch4, 0, 3);
            this.tLP_1.Controls.Add(this.cb_buch5, 0, 4);
            this.tLP_1.Controls.Add(this.cb_buch6, 0, 5);
            this.tLP_1.Controls.Add(this.cb_buch7, 0, 6);
            this.tLP_1.Controls.Add(this.cb_buch8, 0, 7);
            this.tLP_1.Controls.Add(this.bt_buch1, 1, 0);
            this.tLP_1.Controls.Add(this.bt_buch2, 1, 1);
            this.tLP_1.Controls.Add(this.bt_buch3, 1, 2);
            this.tLP_1.Controls.Add(this.bt_buch4, 1, 3);
            this.tLP_1.Controls.Add(this.bt_buch5, 1, 4);
            this.tLP_1.Controls.Add(this.bt_buch6, 1, 5);
            this.tLP_1.Controls.Add(this.bt_buch7, 1, 6);
            this.tLP_1.Controls.Add(this.bt_buch8, 1, 7);
            this.tLP_1.Location = new System.Drawing.Point(264, 226);
            this.tLP_1.Name = "tLP_1";
            this.tLP_1.RowCount = 9;
            this.tLP_1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tLP_1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tLP_1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tLP_1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tLP_1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tLP_1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tLP_1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tLP_1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tLP_1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tLP_1.Size = new System.Drawing.Size(492, 546);
            this.tLP_1.TabIndex = 20;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.bt_add, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.bt_clear, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 435);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(423, 108);
            this.tableLayoutPanel2.TabIndex = 4;
            // 
            // bt_add
            // 
            this.bt_add.Location = new System.Drawing.Point(8, 8);
            this.bt_add.Margin = new System.Windows.Forms.Padding(8);
            this.bt_add.Name = "bt_add";
            this.bt_add.Size = new System.Drawing.Size(192, 51);
            this.bt_add.TabIndex = 16;
            this.bt_add.Text = "Hinzufügen";
            this.bt_add.UseVisualStyleBackColor = true;
            this.bt_add.Click += new System.EventHandler(this.bt_add_Click);
            // 
            // bt_clear
            // 
            this.bt_clear.Location = new System.Drawing.Point(219, 8);
            this.bt_clear.Margin = new System.Windows.Forms.Padding(8);
            this.bt_clear.Name = "bt_clear";
            this.bt_clear.Size = new System.Drawing.Size(192, 51);
            this.bt_clear.TabIndex = 19;
            this.bt_clear.Text = "Leeren";
            this.bt_clear.UseVisualStyleBackColor = true;
            this.bt_clear.Click += new System.EventHandler(this.bt_clear_Click);
            // 
            // cb_buch2
            // 
            this.cb_buch2.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cb_buch2.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cb_buch2.DropDownHeight = 1;
            this.cb_buch2.DropDownWidth = 1;
            this.cb_buch2.FormattingEnabled = true;
            this.cb_buch2.IntegralHeight = false;
            this.cb_buch2.Location = new System.Drawing.Point(3, 57);
            this.cb_buch2.Name = "cb_buch2";
            this.cb_buch2.Size = new System.Drawing.Size(414, 39);
            this.cb_buch2.TabIndex = 2;
            this.cb_buch2.DropDown += new System.EventHandler(this.comboboxClicked);
            this.cb_buch2.SelectedIndexChanged += new System.EventHandler(this.cb_buch2_SelectedIndexChanged);
            this.cb_buch2.SelectionChangeCommitted += new System.EventHandler(this.cb_selected);
            this.cb_buch2.Click += new System.EventHandler(this.comboboxClicked);
            // 
            // cb_buch3
            // 
            this.cb_buch3.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cb_buch3.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cb_buch3.DropDownHeight = 1;
            this.cb_buch3.DropDownWidth = 1;
            this.cb_buch3.FormattingEnabled = true;
            this.cb_buch3.IntegralHeight = false;
            this.cb_buch3.Location = new System.Drawing.Point(3, 111);
            this.cb_buch3.Name = "cb_buch3";
            this.cb_buch3.Size = new System.Drawing.Size(414, 39);
            this.cb_buch3.TabIndex = 2;
            this.cb_buch3.DropDown += new System.EventHandler(this.comboboxClicked);
            this.cb_buch3.SelectedIndexChanged += new System.EventHandler(this.cb_buch3_SelectedIndexChanged);
            this.cb_buch3.SelectionChangeCommitted += new System.EventHandler(this.cb_selected);
            this.cb_buch3.Click += new System.EventHandler(this.comboboxClicked);
            // 
            // cb_buch4
            // 
            this.cb_buch4.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cb_buch4.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cb_buch4.DropDownHeight = 1;
            this.cb_buch4.DropDownWidth = 1;
            this.cb_buch4.FormattingEnabled = true;
            this.cb_buch4.IntegralHeight = false;
            this.cb_buch4.Location = new System.Drawing.Point(3, 165);
            this.cb_buch4.Name = "cb_buch4";
            this.cb_buch4.Size = new System.Drawing.Size(414, 39);
            this.cb_buch4.TabIndex = 2;
            this.cb_buch4.DropDown += new System.EventHandler(this.comboboxClicked);
            this.cb_buch4.SelectionChangeCommitted += new System.EventHandler(this.cb_selected);
            this.cb_buch4.Click += new System.EventHandler(this.comboboxClicked);
            // 
            // cb_buch5
            // 
            this.cb_buch5.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cb_buch5.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cb_buch5.DropDownHeight = 1;
            this.cb_buch5.DropDownWidth = 1;
            this.cb_buch5.FormattingEnabled = true;
            this.cb_buch5.IntegralHeight = false;
            this.cb_buch5.Location = new System.Drawing.Point(3, 219);
            this.cb_buch5.Name = "cb_buch5";
            this.cb_buch5.Size = new System.Drawing.Size(414, 39);
            this.cb_buch5.TabIndex = 2;
            this.cb_buch5.DropDown += new System.EventHandler(this.comboboxClicked);
            this.cb_buch5.SelectionChangeCommitted += new System.EventHandler(this.cb_selected);
            this.cb_buch5.Click += new System.EventHandler(this.comboboxClicked);
            // 
            // cb_buch6
            // 
            this.cb_buch6.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cb_buch6.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cb_buch6.DropDownHeight = 1;
            this.cb_buch6.DropDownWidth = 1;
            this.cb_buch6.FormattingEnabled = true;
            this.cb_buch6.IntegralHeight = false;
            this.cb_buch6.Location = new System.Drawing.Point(3, 273);
            this.cb_buch6.Name = "cb_buch6";
            this.cb_buch6.Size = new System.Drawing.Size(414, 39);
            this.cb_buch6.TabIndex = 2;
            this.cb_buch6.DropDown += new System.EventHandler(this.comboboxClicked);
            this.cb_buch6.SelectionChangeCommitted += new System.EventHandler(this.cb_selected);
            this.cb_buch6.Click += new System.EventHandler(this.comboboxClicked);
            // 
            // cb_buch7
            // 
            this.cb_buch7.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cb_buch7.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cb_buch7.DropDownHeight = 1;
            this.cb_buch7.DropDownWidth = 1;
            this.cb_buch7.FormattingEnabled = true;
            this.cb_buch7.IntegralHeight = false;
            this.cb_buch7.Location = new System.Drawing.Point(3, 327);
            this.cb_buch7.Name = "cb_buch7";
            this.cb_buch7.Size = new System.Drawing.Size(414, 39);
            this.cb_buch7.TabIndex = 2;
            this.cb_buch7.DropDown += new System.EventHandler(this.comboboxClicked);
            this.cb_buch7.SelectionChangeCommitted += new System.EventHandler(this.cb_selected);
            this.cb_buch7.Click += new System.EventHandler(this.comboboxClicked);
            // 
            // cb_buch8
            // 
            this.cb_buch8.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cb_buch8.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cb_buch8.DropDownHeight = 1;
            this.cb_buch8.DropDownWidth = 1;
            this.cb_buch8.FormattingEnabled = true;
            this.cb_buch8.IntegralHeight = false;
            this.cb_buch8.Location = new System.Drawing.Point(3, 381);
            this.cb_buch8.Name = "cb_buch8";
            this.cb_buch8.Size = new System.Drawing.Size(414, 39);
            this.cb_buch8.TabIndex = 2;
            this.cb_buch8.DropDown += new System.EventHandler(this.comboboxClicked);
            this.cb_buch8.SelectionChangeCommitted += new System.EventHandler(this.cb_selected);
            this.cb_buch8.Click += new System.EventHandler(this.comboboxClicked);
            // 
            // bt_buch1
            // 
            this.bt_buch1.Location = new System.Drawing.Point(432, 3);
            this.bt_buch1.Name = "bt_buch1";
            this.bt_buch1.Size = new System.Drawing.Size(45, 45);
            this.bt_buch1.TabIndex = 5;
            this.bt_buch1.Text = "-";
            this.bt_buch1.UseVisualStyleBackColor = true;
            this.bt_buch1.Click += new System.EventHandler(this.bt_buch_Click);
            // 
            // bt_buch2
            // 
            this.bt_buch2.Location = new System.Drawing.Point(432, 57);
            this.bt_buch2.Name = "bt_buch2";
            this.bt_buch2.Size = new System.Drawing.Size(45, 45);
            this.bt_buch2.TabIndex = 5;
            this.bt_buch2.Text = "-";
            this.bt_buch2.UseVisualStyleBackColor = true;
            this.bt_buch2.Click += new System.EventHandler(this.bt_buch_Click);
            // 
            // bt_buch3
            // 
            this.bt_buch3.Location = new System.Drawing.Point(432, 111);
            this.bt_buch3.Name = "bt_buch3";
            this.bt_buch3.Size = new System.Drawing.Size(45, 45);
            this.bt_buch3.TabIndex = 5;
            this.bt_buch3.Text = "-";
            this.bt_buch3.UseVisualStyleBackColor = true;
            this.bt_buch3.Click += new System.EventHandler(this.bt_buch_Click);
            // 
            // bt_buch4
            // 
            this.bt_buch4.Location = new System.Drawing.Point(432, 165);
            this.bt_buch4.Name = "bt_buch4";
            this.bt_buch4.Size = new System.Drawing.Size(45, 45);
            this.bt_buch4.TabIndex = 5;
            this.bt_buch4.Text = "-";
            this.bt_buch4.UseVisualStyleBackColor = true;
            this.bt_buch4.Click += new System.EventHandler(this.bt_buch_Click);
            // 
            // bt_buch5
            // 
            this.bt_buch5.Location = new System.Drawing.Point(432, 219);
            this.bt_buch5.Name = "bt_buch5";
            this.bt_buch5.Size = new System.Drawing.Size(45, 45);
            this.bt_buch5.TabIndex = 5;
            this.bt_buch5.Text = "-";
            this.bt_buch5.UseVisualStyleBackColor = true;
            this.bt_buch5.Click += new System.EventHandler(this.bt_buch_Click);
            // 
            // bt_buch6
            // 
            this.bt_buch6.Location = new System.Drawing.Point(432, 273);
            this.bt_buch6.Name = "bt_buch6";
            this.bt_buch6.Size = new System.Drawing.Size(45, 45);
            this.bt_buch6.TabIndex = 5;
            this.bt_buch6.Text = "-";
            this.bt_buch6.UseVisualStyleBackColor = true;
            this.bt_buch6.Click += new System.EventHandler(this.bt_buch_Click);
            // 
            // bt_buch7
            // 
            this.bt_buch7.Location = new System.Drawing.Point(432, 327);
            this.bt_buch7.Name = "bt_buch7";
            this.bt_buch7.Size = new System.Drawing.Size(45, 45);
            this.bt_buch7.TabIndex = 5;
            this.bt_buch7.Text = "-";
            this.bt_buch7.UseVisualStyleBackColor = true;
            this.bt_buch7.Click += new System.EventHandler(this.bt_buch_Click);
            // 
            // bt_buch8
            // 
            this.bt_buch8.Location = new System.Drawing.Point(432, 381);
            this.bt_buch8.Name = "bt_buch8";
            this.bt_buch8.Size = new System.Drawing.Size(45, 45);
            this.bt_buch8.TabIndex = 5;
            this.bt_buch8.Text = "-";
            this.bt_buch8.UseVisualStyleBackColor = true;
            this.bt_buch8.Click += new System.EventHandler(this.bt_buch_Click);
            // 
            // lb
            // 
            this.lb.AutoSize = true;
            this.lb.Location = new System.Drawing.Point(10, 469);
            this.lb.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lb.Name = "lb";
            this.lb.Size = new System.Drawing.Size(0, 32);
            this.lb.TabIndex = 17;
            // 
            // rb_delete
            // 
            this.rb_delete.AutoSize = true;
            this.rb_delete.Location = new System.Drawing.Point(550, 45);
            this.rb_delete.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.rb_delete.Name = "rb_delete";
            this.rb_delete.Size = new System.Drawing.Size(176, 36);
            this.rb_delete.TabIndex = 14;
            this.rb_delete.Text = "Entfernen";
            this.rb_delete.UseVisualStyleBackColor = true;
            this.rb_delete.CheckedChanged += new System.EventHandler(this.rb_delete_CheckedChanged);
            // 
            // rb_edit
            // 
            this.rb_edit.AutoSize = true;
            this.rb_edit.Location = new System.Drawing.Point(282, 45);
            this.rb_edit.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.rb_edit.Name = "rb_edit";
            this.rb_edit.Size = new System.Drawing.Size(191, 36);
            this.rb_edit.TabIndex = 13;
            this.rb_edit.Text = "Bearbeiten";
            this.rb_edit.UseVisualStyleBackColor = true;
            this.rb_edit.CheckedChanged += new System.EventHandler(this.rb_edit_CheckedChanged);
            // 
            // rb_neu
            // 
            this.rb_neu.AutoSize = true;
            this.rb_neu.Checked = true;
            this.rb_neu.Cursor = System.Windows.Forms.Cursors.Default;
            this.rb_neu.Location = new System.Drawing.Point(16, 45);
            this.rb_neu.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.rb_neu.Name = "rb_neu";
            this.rb_neu.Size = new System.Drawing.Size(197, 36);
            this.rb_neu.TabIndex = 12;
            this.rb_neu.TabStop = true;
            this.rb_neu.Text = "Hinzufügen";
            this.rb_neu.UseVisualStyleBackColor = true;
            this.rb_neu.CheckedChanged += new System.EventHandler(this.rb_neu_CheckedChanged);
            // 
            // gv_bf
            // 
            this.gv_bf.AllowUserToAddRows = false;
            this.gv_bf.AllowUserToDeleteRows = false;
            this.gv_bf.AllowUserToResizeColumns = false;
            this.gv_bf.AllowUserToResizeRows = false;
            this.gv_bf.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.gv_bf.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gv_bf.Location = new System.Drawing.Point(799, 17);
            this.gv_bf.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.gv_bf.Name = "gv_bf";
            this.gv_bf.ReadOnly = true;
            this.gv_bf.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.gv_bf.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gv_bf.Size = new System.Drawing.Size(1542, 944);
            this.gv_bf.TabIndex = 23;
            this.gv_bf.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gv_bf_CellDoubleClick);
            // 
            // w_s_buch_fach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2358, 1049);
            this.Controls.Add(this.bt_export);
            this.Controls.Add(this.bt_close);
            this.Controls.Add(this.gB_buchid);
            this.Controls.Add(this.gv_bf);
            this.Name = "w_s_buch_fach";
            this.Text = "Bücher zu Fächern zuordnen";
            this.Load += new System.EventHandler(this.w_b_buch_fach_Load);
            this.gB_buchid.ResumeLayout(false);
            this.gB_buchid.PerformLayout();
            this.tLP_1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gv_bf)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lb_fach;
        private System.Windows.Forms.ComboBox cb_fach;
        private System.Windows.Forms.Label bt_klasse;
        private System.Windows.Forms.ComboBox cb_klasse;
        private System.Windows.Forms.Label lb_buch;
        private System.Windows.Forms.ComboBox cb_buch1;
        private System.Windows.Forms.Button bt_export;
        private System.Windows.Forms.Button bt_close;
        private System.Windows.Forms.GroupBox gB_buchid;
        private System.Windows.Forms.Button bt_clear;
        private System.Windows.Forms.Label lb;
        private System.Windows.Forms.Button bt_add;
        private System.Windows.Forms.RadioButton rb_delete;
        private System.Windows.Forms.RadioButton rb_edit;
        private System.Windows.Forms.RadioButton rb_neu;
        private System.Windows.Forms.DataGridView gv_bf;
        private System.Windows.Forms.TableLayoutPanel tLP_1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.ComboBox cb_buch2;
        private System.Windows.Forms.ComboBox cb_buch3;
        private System.Windows.Forms.ComboBox cb_buch4;
        private System.Windows.Forms.ComboBox cb_buch5;
        private System.Windows.Forms.ComboBox cb_buch6;
        private System.Windows.Forms.ComboBox cb_buch7;
        private System.Windows.Forms.ComboBox cb_buch8;
        private System.Windows.Forms.Button bt_buch1;
        private System.Windows.Forms.Button bt_buch2;
        private System.Windows.Forms.Button bt_buch3;
        private System.Windows.Forms.Button bt_buch4;
        private System.Windows.Forms.Button bt_buch5;
        private System.Windows.Forms.Button bt_buch6;
        private System.Windows.Forms.Button bt_buch7;
        private System.Windows.Forms.Button bt_buch8;
        private System.Windows.Forms.CheckBox cb_1;
    }
}