namespace Bibo_Verwaltung
{
    partial class w_s_barcode
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
            this.bt_Drucken = new System.Windows.Forms.Button();
            this.pb_Barcode = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lb_AusCode = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Barcode)).BeginInit();
            this.SuspendLayout();
            // 
            // bt_Drucken
            // 
            this.bt_Drucken.Location = new System.Drawing.Point(352, 251);
            this.bt_Drucken.Name = "bt_Drucken";
            this.bt_Drucken.Size = new System.Drawing.Size(75, 23);
            this.bt_Drucken.TabIndex = 0;
            this.bt_Drucken.Text = "Drucken";
            this.bt_Drucken.UseVisualStyleBackColor = true;
            // 
            // pb_Barcode
            // 
            this.pb_Barcode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pb_Barcode.Location = new System.Drawing.Point(12, 25);
            this.pb_Barcode.Name = "pb_Barcode";
            this.pb_Barcode.Size = new System.Drawing.Size(415, 150);
            this.pb_Barcode.TabIndex = 1;
            this.pb_Barcode.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 251);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(122, 203);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 3;
            // 
            // lb_AusCode
            // 
            this.lb_AusCode.AutoSize = true;
            this.lb_AusCode.Location = new System.Drawing.Point(12, 9);
            this.lb_AusCode.Name = "lb_AusCode";
            this.lb_AusCode.Size = new System.Drawing.Size(116, 13);
            this.lb_AusCode.TabIndex = 4;
            this.lb_AusCode.Text = "Ausleihvorgangs-Code:";
            // 
            // w_s_barcode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(439, 286);
            this.Controls.Add(this.lb_AusCode);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pb_Barcode);
            this.Controls.Add(this.bt_Drucken);
            this.Name = "w_s_barcode";
            this.Text = "w_s_barcode";
            ((System.ComponentModel.ISupportInitialize)(this.pb_Barcode)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bt_Drucken;
        private System.Windows.Forms.PictureBox pb_Barcode;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lb_AusCode;
    }
}