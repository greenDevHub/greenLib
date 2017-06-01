namespace Bibo_Verwaltung
{
    partial class w_s_details
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
            this.gv_Details = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.gv_Details)).BeginInit();
            this.SuspendLayout();
            // 
            // gv_Details
            // 
            this.gv_Details.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gv_Details.Location = new System.Drawing.Point(12, 12);
            this.gv_Details.Name = "gv_Details";
            this.gv_Details.Size = new System.Drawing.Size(1035, 374);
            this.gv_Details.TabIndex = 0;
            // 
            // w_s_details
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1059, 611);
            this.Controls.Add(this.gv_Details);
            this.Name = "w_s_details";
            this.Text = "w_s_details";
            ((System.ComponentModel.ISupportInitialize)(this.gv_Details)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView gv_Details;
    }
}