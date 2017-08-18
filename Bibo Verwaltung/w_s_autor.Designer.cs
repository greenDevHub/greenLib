namespace Bibo_Verwaltung
{
    partial class w_s_autor
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
            this.gb_autor = new System.Windows.Forms.GroupBox();
            this.cb_autor = new System.Windows.Forms.ComboBox();
            this.bt_add_autor = new System.Windows.Forms.Button();
            this.bt_del_autor = new System.Windows.Forms.Button();
            this.gb_autor.SuspendLayout();
            this.SuspendLayout();
            // 
            // gb_autor
            // 
            this.gb_autor.Controls.Add(this.cb_autor);
            this.gb_autor.Controls.Add(this.bt_add_autor);
            this.gb_autor.Controls.Add(this.bt_del_autor);
            this.gb_autor.Location = new System.Drawing.Point(26, 32);
            this.gb_autor.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.gb_autor.Name = "gb_autor";
            this.gb_autor.Padding = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.gb_autor.Size = new System.Drawing.Size(916, 299);
            this.gb_autor.TabIndex = 43;
            this.gb_autor.TabStop = false;
            this.gb_autor.Text = "Autor";
            // 
            // cb_autor
            // 
            this.cb_autor.FormattingEnabled = true;
            this.cb_autor.Location = new System.Drawing.Point(11, 42);
            this.cb_autor.Name = "cb_autor";
            this.cb_autor.Size = new System.Drawing.Size(664, 39);
            this.cb_autor.TabIndex = 45;
            // 
            // bt_add_autor
            // 
            this.bt_add_autor.Location = new System.Drawing.Point(248, 100);
            this.bt_add_autor.Name = "bt_add_autor";
            this.bt_add_autor.Size = new System.Drawing.Size(202, 67);
            this.bt_add_autor.TabIndex = 43;
            this.bt_add_autor.Text = "Hinzufügen";
            this.bt_add_autor.UseVisualStyleBackColor = true;
            this.bt_add_autor.Click += new System.EventHandler(this.bt_add_autor_Click);
            // 
            // bt_del_autor
            // 
            this.bt_del_autor.Location = new System.Drawing.Point(473, 100);
            this.bt_del_autor.Name = "bt_del_autor";
            this.bt_del_autor.Size = new System.Drawing.Size(202, 67);
            this.bt_del_autor.TabIndex = 45;
            this.bt_del_autor.Text = "Löschen";
            this.bt_del_autor.UseVisualStyleBackColor = true;
            this.bt_del_autor.Click += new System.EventHandler(this.bt_del_autor_Click);
            // 
            // w_s_autor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(968, 362);
            this.Controls.Add(this.gb_autor);
            this.Name = "w_s_autor";
            this.Text = "w_s_autor";
            this.Activated += new System.EventHandler(this.Laden);
            this.gb_autor.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gb_autor;
        private System.Windows.Forms.ComboBox cb_autor;
        private System.Windows.Forms.Button bt_add_autor;
        private System.Windows.Forms.Button bt_del_autor;
    }
}