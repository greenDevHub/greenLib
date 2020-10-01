namespace Bibo_Verwaltung
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(w_s_buch_fach));
            this.gv_Faecher = new MetroFramework.Controls.MetroGrid();
            this.gv_Buecher = new MetroFramework.Controls.MetroGrid();
            this.btAbbrechen = new MetroFramework.Controls.MetroButton();
            this.bt_Bearbeiten = new MetroFramework.Controls.MetroButton();
            this.lb_titel = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.bt_back = new MetroFramework.Controls.MetroButton();
            this.mbt_ImEx = new MetroFramework.Controls.MetroButton();
            this.msm_buch_fach = new MetroFramework.Components.MetroStyleManager(this.components);
            this.tb_isbn = new MetroFramework.Controls.MetroTextBox();
            this.tb_titel = new MetroFramework.Controls.MetroTextBox();
            this.bt_lk = new MetroFramework.Controls.MetroButton();
            this.tb_fach = new MetroFramework.Controls.MetroTextBox();
            this.metroToolTip1 = new MetroFramework.Components.MetroToolTip();
            ((System.ComponentModel.ISupportInitialize)(this.gv_Faecher)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_Buecher)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.msm_buch_fach)).BeginInit();
            this.SuspendLayout();
            // 
            // gv_Faecher
            // 
            this.gv_Faecher.AllowUserToAddRows = false;
            this.gv_Faecher.AllowUserToDeleteRows = false;
            this.gv_Faecher.AllowUserToResizeColumns = false;
            this.gv_Faecher.AllowUserToResizeRows = false;
            this.gv_Faecher.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.gv_Faecher.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
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
            this.gv_Faecher.EnableHeadersVisualStyles = false;
            this.gv_Faecher.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.gv_Faecher.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.gv_Faecher.Location = new System.Drawing.Point(26, 114);
            this.gv_Faecher.MultiSelect = false;
            this.gv_Faecher.Name = "gv_Faecher";
            this.gv_Faecher.ReadOnly = true;
            this.gv_Faecher.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(119)))), ((int)(((byte)(53)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.gv_Faecher.Size = new System.Drawing.Size(270, 328);
            this.gv_Faecher.Style = MetroFramework.MetroColorStyle.Orange;
            this.gv_Faecher.TabIndex = 0;
            this.gv_Faecher.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Gv_Faecher_CellDoubleClick);
            this.gv_Faecher.SelectionChanged += new System.EventHandler(this.gv_Faecher_SelectionChanged);
            this.gv_Faecher.EnabledChanged += new System.EventHandler(this.Gv_Faecher_EnabledChanged);
            this.gv_Faecher.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Gv_Faecher_KeyDown);
            // 
            // gv_Buecher
            // 
            this.gv_Buecher.AllowUserToAddRows = false;
            this.gv_Buecher.AllowUserToDeleteRows = false;
            this.gv_Buecher.AllowUserToResizeColumns = false;
            this.gv_Buecher.AllowUserToResizeRows = false;
            this.gv_Buecher.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gv_Buecher.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.gv_Buecher.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.gv_Buecher.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gv_Buecher.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.gv_Buecher.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(119)))), ((int)(((byte)(53)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI Semibold", 10.5F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(133)))), ((int)(((byte)(72)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gv_Buecher.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.gv_Buecher.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gv_Buecher.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(133)))), ((int)(((byte)(72)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gv_Buecher.DefaultCellStyle = dataGridViewCellStyle5;
            this.gv_Buecher.Enabled = false;
            this.gv_Buecher.EnableHeadersVisualStyles = false;
            this.gv_Buecher.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.gv_Buecher.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.gv_Buecher.Location = new System.Drawing.Point(302, 82);
            this.gv_Buecher.MultiSelect = false;
            this.gv_Buecher.Name = "gv_Buecher";
            this.gv_Buecher.ReadOnly = true;
            this.gv_Buecher.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(119)))), ((int)(((byte)(53)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(133)))), ((int)(((byte)(72)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gv_Buecher.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.gv_Buecher.RowHeadersWidth = 5;
            this.gv_Buecher.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.gv_Buecher.RowTemplate.DividerHeight = 1;
            this.gv_Buecher.RowTemplate.ReadOnly = true;
            this.gv_Buecher.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gv_Buecher.ShowCellErrors = false;
            this.gv_Buecher.ShowCellToolTips = false;
            this.gv_Buecher.ShowEditingIcon = false;
            this.gv_Buecher.ShowRowErrors = false;
            this.gv_Buecher.Size = new System.Drawing.Size(595, 360);
            this.gv_Buecher.Style = MetroFramework.MetroColorStyle.Orange;
            this.gv_Buecher.TabIndex = 1;
            this.gv_Buecher.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Gv_Buecher_CellClick);
            this.gv_Buecher.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gv_Buecher_CellDoubleClick);
            this.gv_Buecher.Sorted += new System.EventHandler(this.Gv_Buecher_Sorted);
            this.gv_Buecher.EnabledChanged += new System.EventHandler(this.Gv_Buecher_EnabledChanged);
            this.gv_Buecher.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Gv_Buecher_KeyDown);
            // 
            // btAbbrechen
            // 
            this.btAbbrechen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btAbbrechen.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btAbbrechen.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btAbbrechen.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btAbbrechen.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.btAbbrechen.ForeColor = System.Drawing.Color.White;
            this.btAbbrechen.Location = new System.Drawing.Point(722, 453);
            this.btAbbrechen.Name = "btAbbrechen";
            this.btAbbrechen.Size = new System.Drawing.Size(175, 24);
            this.btAbbrechen.Style = MetroFramework.MetroColorStyle.Orange;
            this.btAbbrechen.TabIndex = 6;
            this.btAbbrechen.Text = "Schließen";
            this.btAbbrechen.UseSelectable = true;
            this.btAbbrechen.Click += new System.EventHandler(this.bt_close_Click);
            // 
            // bt_Bearbeiten
            // 
            this.bt_Bearbeiten.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.bt_Bearbeiten.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.bt_Bearbeiten.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.bt_Bearbeiten.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.bt_Bearbeiten.ForeColor = System.Drawing.Color.White;
            this.bt_Bearbeiten.Location = new System.Drawing.Point(483, 453);
            this.bt_Bearbeiten.Name = "bt_Bearbeiten";
            this.bt_Bearbeiten.Size = new System.Drawing.Size(175, 24);
            this.bt_Bearbeiten.Style = MetroFramework.MetroColorStyle.Orange;
            this.bt_Bearbeiten.TabIndex = 5;
            this.bt_Bearbeiten.Text = "Zuordnungen bearbeiten";
            this.bt_Bearbeiten.UseSelectable = true;
            this.bt_Bearbeiten.Click += new System.EventHandler(this.bt_Bearbeiten_Click);
            // 
            // lb_titel
            // 
            this.lb_titel.AutoSize = true;
            this.lb_titel.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lb_titel.Location = new System.Drawing.Point(23, 60);
            this.lb_titel.Name = "lb_titel";
            this.lb_titel.Size = new System.Drawing.Size(82, 19);
            this.lb_titel.Style = MetroFramework.MetroColorStyle.Orange;
            this.lb_titel.TabIndex = 68;
            this.lb_titel.Text = "Fächer (GK):";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel2.Location = new System.Drawing.Point(302, 60);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(135, 19);
            this.metroLabel2.Style = MetroFramework.MetroColorStyle.Orange;
            this.metroLabel2.TabIndex = 69;
            this.metroLabel2.Text = "zugeordnete Bücher:";
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
            // msm_buch_fach
            // 
            this.msm_buch_fach.Owner = this;
            this.msm_buch_fach.Style = MetroFramework.MetroColorStyle.Orange;
            // 
            // tb_isbn
            // 
            this.tb_isbn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.tb_isbn.CustomButton.Image = null;
            this.tb_isbn.CustomButton.Location = new System.Drawing.Point(178, 1);
            this.tb_isbn.CustomButton.Name = "";
            this.tb_isbn.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.tb_isbn.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tb_isbn.CustomButton.TabIndex = 1;
            this.tb_isbn.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tb_isbn.CustomButton.UseSelectable = true;
            this.tb_isbn.CustomButton.Visible = false;
            this.tb_isbn.Enabled = false;
            this.tb_isbn.Lines = new string[0];
            this.tb_isbn.Location = new System.Drawing.Point(491, 56);
            this.tb_isbn.MaxLength = 32767;
            this.tb_isbn.Name = "tb_isbn";
            this.tb_isbn.PasswordChar = '\0';
            this.tb_isbn.PromptText = "Suche nach ISBN";
            this.tb_isbn.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tb_isbn.SelectedText = "";
            this.tb_isbn.SelectionLength = 0;
            this.tb_isbn.SelectionStart = 0;
            this.tb_isbn.ShortcutsEnabled = true;
            this.tb_isbn.Size = new System.Drawing.Size(200, 23);
            this.tb_isbn.TabIndex = 2;
            this.tb_isbn.UseSelectable = true;
            this.tb_isbn.WaterMark = "Suche nach ISBN";
            this.tb_isbn.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tb_isbn.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.tb_isbn.TextChanged += new System.EventHandler(this.Tb_isbn_TextChanged);
            // 
            // tb_titel
            // 
            this.tb_titel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.tb_titel.CustomButton.Image = null;
            this.tb_titel.CustomButton.Location = new System.Drawing.Point(178, 1);
            this.tb_titel.CustomButton.Name = "";
            this.tb_titel.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.tb_titel.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tb_titel.CustomButton.TabIndex = 1;
            this.tb_titel.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tb_titel.CustomButton.UseSelectable = true;
            this.tb_titel.CustomButton.Visible = false;
            this.tb_titel.Enabled = false;
            this.tb_titel.Lines = new string[0];
            this.tb_titel.Location = new System.Drawing.Point(697, 56);
            this.tb_titel.MaxLength = 32767;
            this.tb_titel.Name = "tb_titel";
            this.tb_titel.PasswordChar = '\0';
            this.tb_titel.PromptText = "Suche nach Titel";
            this.tb_titel.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tb_titel.SelectedText = "";
            this.tb_titel.SelectionLength = 0;
            this.tb_titel.SelectionStart = 0;
            this.tb_titel.ShortcutsEnabled = true;
            this.tb_titel.Size = new System.Drawing.Size(200, 23);
            this.tb_titel.TabIndex = 3;
            this.tb_titel.UseSelectable = true;
            this.tb_titel.WaterMark = "Suche nach Titel";
            this.tb_titel.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tb_titel.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.tb_titel.TextChanged += new System.EventHandler(this.Tb_titel_TextChanged);
            // 
            // bt_lk
            // 
            this.bt_lk.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.bt_lk.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.bt_lk.Location = new System.Drawing.Point(124, 85);
            this.bt_lk.Name = "bt_lk";
            this.bt_lk.Size = new System.Drawing.Size(172, 23);
            this.bt_lk.TabIndex = 70;
            this.bt_lk.Text = "Zu Leistungskurs wechseln";
            this.metroToolTip1.SetToolTip(this.bt_lk, "    Wechseln Sie zwischen Leistungskurs und Grundkurs (Nur für Bücher der Sekunda" +
        "rstufe II)    ");
            this.bt_lk.UseSelectable = true;
            this.bt_lk.Click += new System.EventHandler(this.Bt_lk_Click);
            // 
            // tb_fach
            // 
            this.tb_fach.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.tb_fach.CustomButton.Image = null;
            this.tb_fach.CustomButton.Location = new System.Drawing.Point(150, 1);
            this.tb_fach.CustomButton.Name = "";
            this.tb_fach.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.tb_fach.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tb_fach.CustomButton.TabIndex = 1;
            this.tb_fach.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tb_fach.CustomButton.UseSelectable = true;
            this.tb_fach.CustomButton.Visible = false;
            this.tb_fach.Lines = new string[0];
            this.tb_fach.Location = new System.Drawing.Point(124, 56);
            this.tb_fach.MaxLength = 32767;
            this.tb_fach.Name = "tb_fach";
            this.tb_fach.PasswordChar = '\0';
            this.tb_fach.PromptText = "Suche nach Fach (Lang)";
            this.tb_fach.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tb_fach.SelectedText = "";
            this.tb_fach.SelectionLength = 0;
            this.tb_fach.SelectionStart = 0;
            this.tb_fach.ShortcutsEnabled = true;
            this.tb_fach.ShowClearButton = true;
            this.tb_fach.Size = new System.Drawing.Size(172, 23);
            this.tb_fach.TabIndex = 2;
            this.tb_fach.UseSelectable = true;
            this.tb_fach.WaterMark = "Suche nach Fach (Lang)";
            this.tb_fach.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tb_fach.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.tb_fach.TextChanged += new System.EventHandler(this.Tb_fach_TextChanged);
            // 
            // metroToolTip1
            // 
            this.metroToolTip1.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroToolTip1.StyleManager = null;
            this.metroToolTip1.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // w_s_buch_fach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.CancelButton = this.btAbbrechen;
            this.ClientSize = new System.Drawing.Size(920, 500);
            this.Controls.Add(this.bt_lk);
            this.Controls.Add(this.tb_titel);
            this.Controls.Add(this.tb_fach);
            this.Controls.Add(this.tb_isbn);
            this.Controls.Add(this.mbt_ImEx);
            this.Controls.Add(this.bt_back);
            this.Controls.Add(this.gv_Buecher);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.gv_Faecher);
            this.Controls.Add(this.lb_titel);
            this.Controls.Add(this.btAbbrechen);
            this.Controls.Add(this.bt_Bearbeiten);
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(1);
            this.MinimumSize = new System.Drawing.Size(862, 500);
            this.Name = "w_s_buch_fach";
            this.ShadowType = MetroFramework.Forms.MetroFormShadowType.AeroShadow;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Style = MetroFramework.MetroColorStyle.Orange;
            this.Text = "Zuordnung der Bücher zu einem Fach";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.w_s_buch_fach_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.gv_Faecher)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_Buecher)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.msm_buch_fach)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MetroFramework.Controls.MetroGrid gv_Faecher;
        private MetroFramework.Controls.MetroGrid gv_Buecher;
        private MetroFramework.Controls.MetroButton btAbbrechen;
        private MetroFramework.Controls.MetroButton bt_Bearbeiten;
        private MetroFramework.Controls.MetroLabel lb_titel;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroButton bt_back;
        private MetroFramework.Controls.MetroButton mbt_ImEx;
        private MetroFramework.Components.MetroStyleManager msm_buch_fach;
        private MetroFramework.Controls.MetroTextBox tb_titel;
        private MetroFramework.Controls.MetroTextBox tb_isbn;
        private MetroFramework.Controls.MetroButton bt_lk;
        private MetroFramework.Controls.MetroTextBox tb_fach;
        private MetroFramework.Components.MetroToolTip metroToolTip1;
    }
}