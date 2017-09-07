namespace Bibo_Verwaltung
{
    partial class Combo_Search
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
            this.bt_Ok = new System.Windows.Forms.Button();
            this.bt_Abbrechen = new System.Windows.Forms.Button();
            this.lb_Ergenisse = new System.Windows.Forms.ListBox();
            this.tb_Such_nach = new System.Windows.Forms.TextBox();
            this.bt_Such_nach = new System.Windows.Forms.Button();
            this.lb_Such_nach = new System.Windows.Forms.Label();
            this.lb_Such_erg = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // bt_Ok
            // 
            this.bt_Ok.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.bt_Ok.Location = new System.Drawing.Point(150, 186);
            this.bt_Ok.Name = "bt_Ok";
            this.bt_Ok.Size = new System.Drawing.Size(101, 23);
            this.bt_Ok.TabIndex = 0;
            this.bt_Ok.Text = "OK";
            this.bt_Ok.UseVisualStyleBackColor = true;
            this.bt_Ok.Click += new System.EventHandler(this.bt_Ok_Click);
            // 
            // bt_Abbrechen
            // 
            this.bt_Abbrechen.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.bt_Abbrechen.Location = new System.Drawing.Point(257, 186);
            this.bt_Abbrechen.Name = "bt_Abbrechen";
            this.bt_Abbrechen.Size = new System.Drawing.Size(101, 23);
            this.bt_Abbrechen.TabIndex = 1;
            this.bt_Abbrechen.Text = "Abbrechen";
            this.bt_Abbrechen.UseVisualStyleBackColor = true;
            // 
            // lb_Ergenisse
            // 
            this.lb_Ergenisse.FormattingEnabled = true;
            this.lb_Ergenisse.Location = new System.Drawing.Point(15, 85);
            this.lb_Ergenisse.Name = "lb_Ergenisse";
            this.lb_Ergenisse.Size = new System.Drawing.Size(343, 95);
            this.lb_Ergenisse.TabIndex = 2;
            // 
            // tb_Such_nach
            // 
            this.tb_Such_nach.Location = new System.Drawing.Point(15, 25);
            this.tb_Such_nach.Name = "tb_Such_nach";
            this.tb_Such_nach.Size = new System.Drawing.Size(237, 20);
            this.tb_Such_nach.TabIndex = 3;
            // 
            // bt_Such_nach
            // 
            this.bt_Such_nach.Location = new System.Drawing.Point(258, 23);
            this.bt_Such_nach.Name = "bt_Such_nach";
            this.bt_Such_nach.Size = new System.Drawing.Size(100, 23);
            this.bt_Such_nach.TabIndex = 4;
            this.bt_Such_nach.Text = "Suchen";
            this.bt_Such_nach.UseVisualStyleBackColor = true;
            this.bt_Such_nach.Click += new System.EventHandler(this.bt_Such_nach_Click);
            // 
            // lb_Such_nach
            // 
            this.lb_Such_nach.AutoSize = true;
            this.lb_Such_nach.Location = new System.Drawing.Point(12, 9);
            this.lb_Such_nach.Name = "lb_Such_nach";
            this.lb_Such_nach.Size = new System.Drawing.Size(74, 13);
            this.lb_Such_nach.TabIndex = 5;
            this.lb_Such_nach.Text = "Suchen nach:";
            // 
            // lb_Such_erg
            // 
            this.lb_Such_erg.AutoSize = true;
            this.lb_Such_erg.Location = new System.Drawing.Point(12, 69);
            this.lb_Such_erg.Name = "lb_Such_erg";
            this.lb_Such_erg.Size = new System.Drawing.Size(62, 13);
            this.lb_Such_erg.TabIndex = 6;
            this.lb_Such_erg.Text = "Ergebnisse:";
            // 
            // Combo_Search
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(370, 218);
            this.Controls.Add(this.lb_Such_erg);
            this.Controls.Add(this.lb_Such_nach);
            this.Controls.Add(this.bt_Such_nach);
            this.Controls.Add(this.tb_Such_nach);
            this.Controls.Add(this.lb_Ergenisse);
            this.Controls.Add(this.bt_Abbrechen);
            this.Controls.Add(this.bt_Ok);
            this.Name = "Combo_Search";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Suchen";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bt_Ok;
        private System.Windows.Forms.Button bt_Abbrechen;
        private System.Windows.Forms.ListBox lb_Ergenisse;
        private System.Windows.Forms.TextBox tb_Such_nach;
        private System.Windows.Forms.Button bt_Such_nach;
        private System.Windows.Forms.Label lb_Such_nach;
        private System.Windows.Forms.Label lb_Such_erg;

        public object CustomValue { get; internal set; }
    }
}