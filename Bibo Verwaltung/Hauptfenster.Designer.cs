namespace Bibo_Verwaltung
{
    partial class Hauptfenster
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
            this.bt_buch_a = new System.Windows.Forms.Button();
            this.bt_kunde_a = new System.Windows.Forms.Button();
            this.bt_sprache_a = new System.Windows.Forms.Button();
            this.bt_autor_a = new System.Windows.Forms.Button();
            this.bt_genre_a = new System.Windows.Forms.Button();
            this.bt_verlag_a = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.gb_infos = new System.Windows.Forms.GroupBox();
            this.lb_Lagerzahl = new System.Windows.Forms.Label();
            this.lb_Ausleihzahl = new System.Windows.Forms.Label();
            this.lb_soll = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.gb_infos.SuspendLayout();
            this.SuspendLayout();
            // 
            // bt_buch_a
            // 
            this.bt_buch_a.Location = new System.Drawing.Point(1306, 209);
            this.bt_buch_a.Name = "bt_buch_a";
            this.bt_buch_a.Size = new System.Drawing.Size(186, 84);
            this.bt_buch_a.TabIndex = 0;
            this.bt_buch_a.Text = "Buch";
            this.bt_buch_a.UseVisualStyleBackColor = true;
            this.bt_buch_a.Click += new System.EventHandler(this.bt_buch_a_Click);
            // 
            // bt_kunde_a
            // 
            this.bt_kunde_a.Location = new System.Drawing.Point(1306, 299);
            this.bt_kunde_a.Name = "bt_kunde_a";
            this.bt_kunde_a.Size = new System.Drawing.Size(186, 84);
            this.bt_kunde_a.TabIndex = 1;
            this.bt_kunde_a.Text = "Kunden";
            this.bt_kunde_a.UseVisualStyleBackColor = true;
            this.bt_kunde_a.Click += new System.EventHandler(this.bt_kunde_a_Click);
            // 
            // bt_sprache_a
            // 
            this.bt_sprache_a.Location = new System.Drawing.Point(1539, 480);
            this.bt_sprache_a.Name = "bt_sprache_a";
            this.bt_sprache_a.Size = new System.Drawing.Size(186, 84);
            this.bt_sprache_a.TabIndex = 2;
            this.bt_sprache_a.Text = "Sprache";
            this.bt_sprache_a.UseVisualStyleBackColor = true;
            this.bt_sprache_a.Click += new System.EventHandler(this.bt_sprache_a_Click);
            // 
            // bt_autor_a
            // 
            this.bt_autor_a.Location = new System.Drawing.Point(1539, 299);
            this.bt_autor_a.Name = "bt_autor_a";
            this.bt_autor_a.Size = new System.Drawing.Size(186, 84);
            this.bt_autor_a.TabIndex = 3;
            this.bt_autor_a.Text = "Autor";
            this.bt_autor_a.UseVisualStyleBackColor = true;
            this.bt_autor_a.Click += new System.EventHandler(this.bt_autor_a_Click);
            // 
            // bt_genre_a
            // 
            this.bt_genre_a.Location = new System.Drawing.Point(1539, 392);
            this.bt_genre_a.Name = "bt_genre_a";
            this.bt_genre_a.Size = new System.Drawing.Size(186, 84);
            this.bt_genre_a.TabIndex = 4;
            this.bt_genre_a.Text = "Genre";
            this.bt_genre_a.UseVisualStyleBackColor = true;
            this.bt_genre_a.Click += new System.EventHandler(this.bt_genre_a_Click);
            // 
            // bt_verlag_a
            // 
            this.bt_verlag_a.Location = new System.Drawing.Point(1539, 209);
            this.bt_verlag_a.Name = "bt_verlag_a";
            this.bt_verlag_a.Size = new System.Drawing.Size(186, 84);
            this.bt_verlag_a.TabIndex = 5;
            this.bt_verlag_a.Text = "Verlag";
            this.bt_verlag_a.UseVisualStyleBackColor = true;
            this.bt_verlag_a.Click += new System.EventHandler(this.bt_verlag_a_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(174, 32);
            this.label1.TabIndex = 6;
            this.label1.Text = "Sollbestand:";
            // 
            // gb_infos
            // 
            this.gb_infos.Controls.Add(this.lb_Lagerzahl);
            this.gb_infos.Controls.Add(this.lb_Ausleihzahl);
            this.gb_infos.Controls.Add(this.lb_soll);
            this.gb_infos.Controls.Add(this.label3);
            this.gb_infos.Controls.Add(this.label2);
            this.gb_infos.Controls.Add(this.label1);
            this.gb_infos.Location = new System.Drawing.Point(67, 190);
            this.gb_infos.Name = "gb_infos";
            this.gb_infos.Size = new System.Drawing.Size(552, 316);
            this.gb_infos.TabIndex = 7;
            this.gb_infos.TabStop = false;
            this.gb_infos.Text = "Infos";
            // 
            // lb_Lagerzahl
            // 
            this.lb_Lagerzahl.AutoSize = true;
            this.lb_Lagerzahl.Location = new System.Drawing.Point(201, 136);
            this.lb_Lagerzahl.Name = "lb_Lagerzahl";
            this.lb_Lagerzahl.Size = new System.Drawing.Size(0, 32);
            this.lb_Lagerzahl.TabIndex = 10;
            // 
            // lb_Ausleihzahl
            // 
            this.lb_Ausleihzahl.AutoSize = true;
            this.lb_Ausleihzahl.Location = new System.Drawing.Point(201, 94);
            this.lb_Ausleihzahl.Name = "lb_Ausleihzahl";
            this.lb_Ausleihzahl.Size = new System.Drawing.Size(0, 32);
            this.lb_Ausleihzahl.TabIndex = 9;
            // 
            // lb_soll
            // 
            this.lb_soll.AutoSize = true;
            this.lb_soll.Location = new System.Drawing.Point(195, 46);
            this.lb_soll.Name = "lb_soll";
            this.lb_soll.Size = new System.Drawing.Size(0, 32);
            this.lb_soll.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(145, 32);
            this.label3.TabIndex = 8;
            this.label3.Text = "Verliehen:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(154, 32);
            this.label2.TabIndex = 8;
            this.label2.Text = "Istbestand:";
            // 
            // Hauptfenster
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1888, 992);
            this.Controls.Add(this.gb_infos);
            this.Controls.Add(this.bt_verlag_a);
            this.Controls.Add(this.bt_genre_a);
            this.Controls.Add(this.bt_autor_a);
            this.Controls.Add(this.bt_sprache_a);
            this.Controls.Add(this.bt_kunde_a);
            this.Controls.Add(this.bt_buch_a);
            this.Name = "Hauptfenster";
            this.Text = "Form2";
            this.Activated += new System.EventHandler(this.Load_All);
            this.gb_infos.ResumeLayout(false);
            this.gb_infos.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bt_buch_a;
        private System.Windows.Forms.Button bt_kunde_a;
        private System.Windows.Forms.Button bt_sprache_a;
        private System.Windows.Forms.Button bt_autor_a;
        private System.Windows.Forms.Button bt_genre_a;
        private System.Windows.Forms.Button bt_verlag_a;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gb_infos;
        private System.Windows.Forms.Label lb_soll;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lb_Lagerzahl;
        private System.Windows.Forms.Label lb_Ausleihzahl;
    }
}