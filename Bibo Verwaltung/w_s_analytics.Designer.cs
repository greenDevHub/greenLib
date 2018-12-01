namespace Bibo_Verwaltung
{
    partial class w_s_analytics
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.button1 = new System.Windows.Forms.Button();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.gv_ResultGrid = new System.Windows.Forms.DataGridView();
            this.bt_PreisUpDown = new System.Windows.Forms.Button();
            this.bt_bestesX = new System.Windows.Forms.Button();
            this.bt_ZerstQuote = new System.Windows.Forms.Button();
            this.bt_BZuwachs = new System.Windows.Forms.Button();
            this.bt_AuslQuote = new System.Windows.Forms.Button();
            this.bt_Dauer = new System.Windows.Forms.Button();
            this.bt_BAbNutz = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gv_ResultGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(6, 19);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Alignment = System.Drawing.StringAlignment.Center;
            legend1.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Bottom;
            legend1.LegendStyle = System.Windows.Forms.DataVisualization.Charting.LegendStyle.Row;
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(12, 259);
            this.chart1.Name = "chart1";
            this.chart1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            series1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            series1.BorderWidth = 5;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            series1.IsValueShownAsLabel = true;
            series1.IsXValueIndexed = true;
            series1.Legend = "Legend1";
            series1.LegendText = "Test";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(1160, 226);
            this.chart1.TabIndex = 2;
            this.chart1.Text = "chart1";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7"});
            this.comboBox1.Location = new System.Drawing.Point(87, 19);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(106, 21);
            this.comboBox1.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(217, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(472, 241);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.bt_BAbNutz);
            this.groupBox2.Controls.Add(this.bt_Dauer);
            this.groupBox2.Controls.Add(this.bt_AuslQuote);
            this.groupBox2.Controls.Add(this.bt_BZuwachs);
            this.groupBox2.Controls.Add(this.bt_ZerstQuote);
            this.groupBox2.Controls.Add(this.bt_bestesX);
            this.groupBox2.Controls.Add(this.bt_PreisUpDown);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.comboBox1);
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(199, 241);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            // 
            // gv_ResultGrid
            // 
            this.gv_ResultGrid.AllowUserToAddRows = false;
            this.gv_ResultGrid.AllowUserToDeleteRows = false;
            this.gv_ResultGrid.AllowUserToResizeColumns = false;
            this.gv_ResultGrid.AllowUserToResizeRows = false;
            this.gv_ResultGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gv_ResultGrid.BackgroundColor = System.Drawing.Color.White;
            this.gv_ResultGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gv_ResultGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.gv_ResultGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gv_ResultGrid.GridColor = System.Drawing.Color.Blue;
            this.gv_ResultGrid.Location = new System.Drawing.Point(695, 12);
            this.gv_ResultGrid.MultiSelect = false;
            this.gv_ResultGrid.Name = "gv_ResultGrid";
            this.gv_ResultGrid.ReadOnly = true;
            this.gv_ResultGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.gv_ResultGrid.RowHeadersVisible = false;
            this.gv_ResultGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gv_ResultGrid.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.gv_ResultGrid.Size = new System.Drawing.Size(477, 241);
            this.gv_ResultGrid.TabIndex = 6;
            this.gv_ResultGrid.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.gv_ResultGrid_ColumnHeaderMouseClick);
            // 
            // bt_PreisUpDown
            // 
            this.bt_PreisUpDown.Location = new System.Drawing.Point(6, 86);
            this.bt_PreisUpDown.Name = "bt_PreisUpDown";
            this.bt_PreisUpDown.Size = new System.Drawing.Size(75, 23);
            this.bt_PreisUpDown.TabIndex = 4;
            this.bt_PreisUpDown.Text = "Preisschwankung";
            this.bt_PreisUpDown.UseVisualStyleBackColor = true;
            // 
            // bt_bestesX
            // 
            this.bt_bestesX.Location = new System.Drawing.Point(87, 86);
            this.bt_bestesX.Name = "bt_bestesX";
            this.bt_bestesX.Size = new System.Drawing.Size(75, 23);
            this.bt_bestesX.TabIndex = 5;
            this.bt_bestesX.Text = "bestes X";
            this.bt_bestesX.UseVisualStyleBackColor = true;
            // 
            // bt_ZerstQuote
            // 
            this.bt_ZerstQuote.Location = new System.Drawing.Point(17, 129);
            this.bt_ZerstQuote.Name = "bt_ZerstQuote";
            this.bt_ZerstQuote.Size = new System.Drawing.Size(75, 23);
            this.bt_ZerstQuote.TabIndex = 6;
            this.bt_ZerstQuote.Text = "Zerstörungsquote";
            this.bt_ZerstQuote.UseVisualStyleBackColor = true;
            // 
            // bt_BZuwachs
            // 
            this.bt_BZuwachs.Location = new System.Drawing.Point(98, 129);
            this.bt_BZuwachs.Name = "bt_BZuwachs";
            this.bt_BZuwachs.Size = new System.Drawing.Size(75, 23);
            this.bt_BZuwachs.TabIndex = 7;
            this.bt_BZuwachs.Text = "Buchzuwachs";
            this.bt_BZuwachs.UseVisualStyleBackColor = true;
            // 
            // bt_AuslQuote
            // 
            this.bt_AuslQuote.Location = new System.Drawing.Point(46, 176);
            this.bt_AuslQuote.Name = "bt_AuslQuote";
            this.bt_AuslQuote.Size = new System.Drawing.Size(75, 23);
            this.bt_AuslQuote.TabIndex = 8;
            this.bt_AuslQuote.Text = "Auslehquote";
            this.bt_AuslQuote.UseVisualStyleBackColor = true;
            // 
            // bt_Dauer
            // 
            this.bt_Dauer.Location = new System.Drawing.Point(135, 179);
            this.bt_Dauer.Name = "bt_Dauer";
            this.bt_Dauer.Size = new System.Drawing.Size(75, 23);
            this.bt_Dauer.TabIndex = 9;
            this.bt_Dauer.Text = "Ausleihdauer";
            this.bt_Dauer.UseVisualStyleBackColor = true;
            // 
            // bt_BAbNutz
            // 
            this.bt_BAbNutz.Location = new System.Drawing.Point(41, 212);
            this.bt_BAbNutz.Name = "bt_BAbNutz";
            this.bt_BAbNutz.Size = new System.Drawing.Size(75, 23);
            this.bt_BAbNutz.TabIndex = 10;
            this.bt_BAbNutz.Text = "Abnutzung";
            this.bt_BAbNutz.UseVisualStyleBackColor = true;
            this.bt_BAbNutz.Click += new System.EventHandler(this.bt_BAbNutz_Click);
            // 
            // w_s_analytics
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 497);
            this.Controls.Add(this.gv_ResultGrid);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.chart1);
            this.Name = "w_s_analytics";
            this.Text = "Statistiken";
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gv_ResultGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView gv_ResultGrid;
        private System.Windows.Forms.Button bt_BAbNutz;
        private System.Windows.Forms.Button bt_Dauer;
        private System.Windows.Forms.Button bt_AuslQuote;
        private System.Windows.Forms.Button bt_BZuwachs;
        private System.Windows.Forms.Button bt_ZerstQuote;
        private System.Windows.Forms.Button bt_bestesX;
        private System.Windows.Forms.Button bt_PreisUpDown;
    }
}