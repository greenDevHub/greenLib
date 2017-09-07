namespace Bibo_Verwaltung
{
    partial class w_s_genre
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
            this.gb_genre = new System.Windows.Forms.GroupBox();
            this.cb_genre = new System.Windows.Forms.ComboBox();
            this.bt_genre_add = new System.Windows.Forms.Button();
            this.bt_del_genre = new System.Windows.Forms.Button();
            this.gb_genre.SuspendLayout();
            this.SuspendLayout();
            // 
            // gb_genre
            // 
            this.gb_genre.Controls.Add(this.cb_genre);
            this.gb_genre.Controls.Add(this.bt_genre_add);
            this.gb_genre.Controls.Add(this.bt_del_genre);
            this.gb_genre.Location = new System.Drawing.Point(17, 35);
            this.gb_genre.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.gb_genre.Name = "gb_genre";
            this.gb_genre.Padding = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.gb_genre.Size = new System.Drawing.Size(916, 299);
            this.gb_genre.TabIndex = 42;
            this.gb_genre.TabStop = false;
            this.gb_genre.Text = "Genre";
            // 
            // cb_genre
            // 
            this.cb_genre.FormattingEnabled = true;
            this.cb_genre.Location = new System.Drawing.Point(11, 42);
            this.cb_genre.Name = "cb_genre";
            this.cb_genre.Size = new System.Drawing.Size(664, 39);
            this.cb_genre.TabIndex = 45;
            // 
            // bt_genre_add
            // 
            this.bt_genre_add.Location = new System.Drawing.Point(248, 100);
            this.bt_genre_add.Name = "bt_genre_add";
            this.bt_genre_add.Size = new System.Drawing.Size(202, 67);
            this.bt_genre_add.TabIndex = 43;
            this.bt_genre_add.Text = "Hinzufügen";
            this.bt_genre_add.UseVisualStyleBackColor = true;
            this.bt_genre_add.Click += new System.EventHandler(this.bt_add_g_Click);
            // 
            // bt_del_genre
            // 
            this.bt_del_genre.Location = new System.Drawing.Point(473, 100);
            this.bt_del_genre.Name = "bt_del_genre";
            this.bt_del_genre.Size = new System.Drawing.Size(202, 67);
            this.bt_del_genre.TabIndex = 45;
            this.bt_del_genre.Text = "Löschen";
            this.bt_del_genre.UseVisualStyleBackColor = true;
            this.bt_del_genre.Click += new System.EventHandler(this.bt_genre_del_Click);
            // 
            // w_s_genre
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(968, 362);
            this.Controls.Add(this.gb_genre);
            this.Name = "w_s_genre";
            this.Text = "w_s_genre";
            this.Activated += new System.EventHandler(this.Laden);
            this.gb_genre.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gb_genre;
        private System.Windows.Forms.ComboBox cb_genre;
        private System.Windows.Forms.Button bt_del_genre;
        private System.Windows.Forms.Button bt_genre_add;
    }
}