namespace Bibo_Verwaltung
{
    partial class FormSubjectGrade
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSubjectGrade));
            this.gv_Faecher = new MetroFramework.Controls.MetroGrid();
            this.bt_Bearbeiten = new MetroFramework.Controls.MetroButton();
            this.btAbbrechen = new MetroFramework.Controls.MetroButton();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.gv_Klassenstufe = new MetroFramework.Controls.MetroGrid();
            this.bt_back = new MetroFramework.Controls.MetroButton();
            this.mbt_ImEx = new MetroFramework.Controls.MetroButton();
            this.styleManagerSubjectGrade = new MetroFramework.Components.MetroStyleManager(this.components);
            this.tb_lang = new MetroFramework.Controls.MetroTextBox();
            this.tb_kurz = new MetroFramework.Controls.MetroTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.gv_Faecher)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_Klassenstufe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.styleManagerSubjectGrade)).BeginInit();
            this.SuspendLayout();
            // 
            // gv_Faecher
            // 
            this.gv_Faecher.AllowUserToAddRows = false;
            this.gv_Faecher.AllowUserToDeleteRows = false;
            this.gv_Faecher.AllowUserToResizeColumns = false;
            this.gv_Faecher.AllowUserToResizeRows = false;
            this.gv_Faecher.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gv_Faecher.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.gv_Faecher.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.gv_Faecher.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gv_Faecher.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.gv_Faecher.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(119)))), ((int)(((byte)(53)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI Semibold", 10.5F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(133)))), ((int)(((byte)(72)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gv_Faecher.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.gv_Faecher.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gv_Faecher.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(133)))), ((int)(((byte)(72)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gv_Faecher.DefaultCellStyle = dataGridViewCellStyle2;
            this.gv_Faecher.Enabled = false;
            this.gv_Faecher.EnableHeadersVisualStyles = false;
            this.gv_Faecher.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.gv_Faecher.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.gv_Faecher.Location = new System.Drawing.Point(302, 82);
            this.gv_Faecher.MultiSelect = false;
            this.gv_Faecher.Name = "gv_Faecher";
            this.gv_Faecher.ReadOnly = true;
            this.gv_Faecher.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(119)))), ((int)(((byte)(53)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(133)))), ((int)(((byte)(72)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gv_Faecher.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.gv_Faecher.RowHeadersWidth = 5;
            this.gv_Faecher.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.gv_Faecher.RowTemplate.DividerHeight = 1;
            this.gv_Faecher.RowTemplate.ReadOnly = true;
            this.gv_Faecher.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gv_Faecher.ShowCellErrors = false;
            this.gv_Faecher.ShowCellToolTips = false;
            this.gv_Faecher.ShowEditingIcon = false;
            this.gv_Faecher.ShowRowErrors = false;
            this.gv_Faecher.Size = new System.Drawing.Size(595, 360);
            this.gv_Faecher.Style = MetroFramework.MetroColorStyle.Orange;
            this.gv_Faecher.TabIndex = 1;
            this.gv_Faecher.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Gv_Faecher_CellClick);
            this.gv_Faecher.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gv_Faecher_CellDoubleClick);
            this.gv_Faecher.Sorted += new System.EventHandler(this.Gv_Faecher_Sorted);
            this.gv_Faecher.EnabledChanged += new System.EventHandler(this.Gv_Faecher_EnabledChanged);
            this.gv_Faecher.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Gv_Faecher_KeyDown);
            // 
            // bt_Bearbeiten
            // 
            this.bt_Bearbeiten.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.bt_Bearbeiten.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.bt_Bearbeiten.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.bt_Bearbeiten.Location = new System.Drawing.Point(483, 453);
            this.bt_Bearbeiten.Name = "bt_Bearbeiten";
            this.bt_Bearbeiten.Size = new System.Drawing.Size(175, 24);
            this.bt_Bearbeiten.Style = MetroFramework.MetroColorStyle.Orange;
            this.bt_Bearbeiten.TabIndex = 5;
            this.bt_Bearbeiten.Text = "Zuordnungen bearbeiten";
            this.bt_Bearbeiten.UseSelectable = true;
            this.bt_Bearbeiten.Click += new System.EventHandler(this.bt_Bearbeiten_Click);
            // 
            // btAbbrechen
            // 
            this.btAbbrechen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btAbbrechen.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btAbbrechen.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btAbbrechen.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.btAbbrechen.Location = new System.Drawing.Point(722, 453);
            this.btAbbrechen.Name = "btAbbrechen";
            this.btAbbrechen.Size = new System.Drawing.Size(175, 24);
            this.btAbbrechen.Style = MetroFramework.MetroColorStyle.Orange;
            this.btAbbrechen.TabIndex = 6;
            this.btAbbrechen.Text = "Schließen";
            this.btAbbrechen.UseSelectable = true;
            this.btAbbrechen.Click += new System.EventHandler(this.btAbbrechen_Click);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel2.Location = new System.Drawing.Point(302, 60);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(133, 19);
            this.metroLabel2.Style = MetroFramework.MetroColorStyle.Orange;
            this.metroLabel2.TabIndex = 71;
            this.metroLabel2.Text = "zugeordnete Fächer:";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel3.Location = new System.Drawing.Point(23, 60);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(95, 19);
            this.metroLabel3.Style = MetroFramework.MetroColorStyle.Orange;
            this.metroLabel3.TabIndex = 72;
            this.metroLabel3.Text = "Klassenstufen:";
            // 
            // gv_Klassenstufe
            // 
            this.gv_Klassenstufe.AllowUserToAddRows = false;
            this.gv_Klassenstufe.AllowUserToDeleteRows = false;
            this.gv_Klassenstufe.AllowUserToResizeColumns = false;
            this.gv_Klassenstufe.AllowUserToResizeRows = false;
            this.gv_Klassenstufe.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.gv_Klassenstufe.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gv_Klassenstufe.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.gv_Klassenstufe.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gv_Klassenstufe.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.gv_Klassenstufe.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(119)))), ((int)(((byte)(53)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI Semibold", 10.5F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(133)))), ((int)(((byte)(72)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gv_Klassenstufe.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.gv_Klassenstufe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gv_Klassenstufe.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(133)))), ((int)(((byte)(72)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gv_Klassenstufe.DefaultCellStyle = dataGridViewCellStyle5;
            this.gv_Klassenstufe.EnableHeadersVisualStyles = false;
            this.gv_Klassenstufe.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.gv_Klassenstufe.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.gv_Klassenstufe.Location = new System.Drawing.Point(26, 82);
            this.gv_Klassenstufe.MultiSelect = false;
            this.gv_Klassenstufe.Name = "gv_Klassenstufe";
            this.gv_Klassenstufe.ReadOnly = true;
            this.gv_Klassenstufe.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(119)))), ((int)(((byte)(53)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(133)))), ((int)(((byte)(72)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gv_Klassenstufe.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.gv_Klassenstufe.RowHeadersWidth = 5;
            this.gv_Klassenstufe.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.gv_Klassenstufe.RowTemplate.DividerHeight = 1;
            this.gv_Klassenstufe.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gv_Klassenstufe.ShowCellErrors = false;
            this.gv_Klassenstufe.ShowCellToolTips = false;
            this.gv_Klassenstufe.ShowEditingIcon = false;
            this.gv_Klassenstufe.ShowRowErrors = false;
            this.gv_Klassenstufe.Size = new System.Drawing.Size(270, 360);
            this.gv_Klassenstufe.Style = MetroFramework.MetroColorStyle.Orange;
            this.gv_Klassenstufe.TabIndex = 0;
            this.gv_Klassenstufe.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Gv_Klassenstufe_CellDoubleClick);
            this.gv_Klassenstufe.SelectionChanged += new System.EventHandler(this.gv_Klassenstufe_SelectionChanged);
            this.gv_Klassenstufe.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Gv_Klassenstufe_KeyDown);
            // 
            // bt_back
            // 
            this.bt_back.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.bt_back.Enabled = false;
            this.bt_back.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.bt_back.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.bt_back.Location = new System.Drawing.Point(302, 453);
            this.bt_back.Name = "bt_back";
            this.bt_back.Size = new System.Drawing.Size(175, 24);
            this.bt_back.Style = MetroFramework.MetroColorStyle.Orange;
            this.bt_back.TabIndex = 4;
            this.bt_back.Text = "Zurück";
            this.bt_back.UseSelectable = true;
            this.bt_back.Click += new System.EventHandler(this.bt_back_Click);
            // 
            // mbt_ImEx
            // 
            this.mbt_ImEx.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.mbt_ImEx.Enabled = false;
            this.mbt_ImEx.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.mbt_ImEx.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.mbt_ImEx.Location = new System.Drawing.Point(26, 453);
            this.mbt_ImEx.Name = "mbt_ImEx";
            this.mbt_ImEx.Size = new System.Drawing.Size(175, 24);
            this.mbt_ImEx.Style = MetroFramework.MetroColorStyle.Orange;
            this.mbt_ImEx.TabIndex = 7;
            this.mbt_ImEx.Text = "Daten Import/Export";
            this.mbt_ImEx.UseSelectable = true;
            this.mbt_ImEx.Click += new System.EventHandler(this.mbt_ImEx_Click);
            // 
            // styleManagerSubjectGrade
            // 
            this.styleManagerSubjectGrade.Owner = this;
            this.styleManagerSubjectGrade.Style = MetroFramework.MetroColorStyle.Orange;
            // 
            // tb_lang
            // 
            this.tb_lang.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.tb_lang.CustomButton.Image = null;
            this.tb_lang.CustomButton.Location = new System.Drawing.Point(178, 1);
            this.tb_lang.CustomButton.Name = "";
            this.tb_lang.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.tb_lang.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tb_lang.CustomButton.TabIndex = 1;
            this.tb_lang.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tb_lang.CustomButton.UseSelectable = true;
            this.tb_lang.CustomButton.Visible = false;
            this.tb_lang.Enabled = false;
            this.tb_lang.Lines = new string[0];
            this.tb_lang.Location = new System.Drawing.Point(697, 56);
            this.tb_lang.MaxLength = 32767;
            this.tb_lang.Name = "tb_lang";
            this.tb_lang.PasswordChar = '\0';
            this.tb_lang.PromptText = "Suche nach Langbezeichnung";
            this.tb_lang.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tb_lang.SelectedText = "";
            this.tb_lang.SelectionLength = 0;
            this.tb_lang.SelectionStart = 0;
            this.tb_lang.ShortcutsEnabled = true;
            this.tb_lang.Size = new System.Drawing.Size(200, 23);
            this.tb_lang.TabIndex = 3;
            this.tb_lang.UseSelectable = true;
            this.tb_lang.WaterMark = "Suche nach Langbezeichnung";
            this.tb_lang.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tb_lang.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.tb_lang.TextChanged += new System.EventHandler(this.Tb_lang_TextChanged);
            // 
            // tb_kurz
            // 
            this.tb_kurz.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.tb_kurz.CustomButton.Image = null;
            this.tb_kurz.CustomButton.Location = new System.Drawing.Point(178, 1);
            this.tb_kurz.CustomButton.Name = "";
            this.tb_kurz.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.tb_kurz.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tb_kurz.CustomButton.TabIndex = 1;
            this.tb_kurz.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tb_kurz.CustomButton.UseSelectable = true;
            this.tb_kurz.CustomButton.Visible = false;
            this.tb_kurz.Enabled = false;
            this.tb_kurz.Lines = new string[0];
            this.tb_kurz.Location = new System.Drawing.Point(491, 56);
            this.tb_kurz.MaxLength = 32767;
            this.tb_kurz.Name = "tb_kurz";
            this.tb_kurz.PasswordChar = '\0';
            this.tb_kurz.PromptText = "Suche nach Kurzbezeichnung";
            this.tb_kurz.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tb_kurz.SelectedText = "";
            this.tb_kurz.SelectionLength = 0;
            this.tb_kurz.SelectionStart = 0;
            this.tb_kurz.ShortcutsEnabled = true;
            this.tb_kurz.Size = new System.Drawing.Size(200, 23);
            this.tb_kurz.TabIndex = 2;
            this.tb_kurz.UseSelectable = true;
            this.tb_kurz.WaterMark = "Suche nach Kurzbezeichnung";
            this.tb_kurz.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tb_kurz.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.tb_kurz.TextChanged += new System.EventHandler(this.Tb_kurz_TextChanged);
            // 
            // FormGradeSubject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.CancelButton = this.btAbbrechen;
            this.ClientSize = new System.Drawing.Size(920, 500);
            this.Controls.Add(this.tb_lang);
            this.Controls.Add(this.tb_kurz);
            this.Controls.Add(this.mbt_ImEx);
            this.Controls.Add(this.gv_Klassenstufe);
            this.Controls.Add(this.bt_back);
            this.Controls.Add(this.gv_Faecher);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.btAbbrechen);
            this.Controls.Add(this.bt_Bearbeiten);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(1);
            this.MinimumSize = new System.Drawing.Size(862, 500);
            this.Name = "FormGradeSubject";
            this.ShadowType = MetroFramework.Forms.MetroFormShadowType.AeroShadow;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Style = MetroFramework.MetroColorStyle.Orange;
            this.Text = "Zuordnung der Fächer zu einer Klassenstufe";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.w_s_fach_stufe_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.gv_Faecher)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_Klassenstufe)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.styleManagerSubjectGrade)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MetroFramework.Controls.MetroGrid gv_Faecher;
        private MetroFramework.Controls.MetroButton bt_Bearbeiten;
        private MetroFramework.Controls.MetroButton btAbbrechen;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroGrid gv_Klassenstufe;
        private MetroFramework.Controls.MetroButton bt_back;
        private MetroFramework.Controls.MetroButton mbt_ImEx;
        private MetroFramework.Components.MetroStyleManager styleManagerSubjectGrade;
        private MetroFramework.Controls.MetroTextBox tb_lang;
        private MetroFramework.Controls.MetroTextBox tb_kurz;
    }
}