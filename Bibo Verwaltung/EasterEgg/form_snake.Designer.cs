namespace Bibo_Verwaltung.EasterEgg
{
    partial class form_snake
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form_snake));
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.pbCanvas = new System.Windows.Forms.PictureBox();
            this.lbScore = new MetroFramework.Controls.MetroLabel();
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            this.lbGameOver = new MetroFramework.Controls.MetroLabel();
            this.msm_snake = new MetroFramework.Components.MetroStyleManager(this.components);
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.lbSpeed = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pbCanvas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.msm_snake)).BeginInit();
            this.SuspendLayout();
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Enabled = false;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel1.Location = new System.Drawing.Point(23, 455);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(60, 25);
            this.metroLabel1.TabIndex = 1;
            this.metroLabel1.Text = "Score:";
            // 
            // pbCanvas
            // 
            this.pbCanvas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(176)))), ((int)(((byte)(176)))));
            this.pbCanvas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbCanvas.Location = new System.Drawing.Point(23, 63);
            this.pbCanvas.Name = "pbCanvas";
            this.pbCanvas.Size = new System.Drawing.Size(954, 385);
            this.pbCanvas.TabIndex = 0;
            this.pbCanvas.TabStop = false;
            this.pbCanvas.Paint += new System.Windows.Forms.PaintEventHandler(this.PbCanvas_Paint);
            // 
            // lbScore
            // 
            this.lbScore.AutoSize = true;
            this.lbScore.Enabled = false;
            this.lbScore.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lbScore.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lbScore.Location = new System.Drawing.Point(116, 455);
            this.lbScore.Name = "lbScore";
            this.lbScore.Size = new System.Drawing.Size(42, 25);
            this.lbScore.TabIndex = 2;
            this.lbScore.Text = "100";
            // 
            // lbGameOver
            // 
            this.lbGameOver.BackColor = System.Drawing.Color.LightBlue;
            this.lbGameOver.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbGameOver.Enabled = false;
            this.lbGameOver.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lbGameOver.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lbGameOver.Location = new System.Drawing.Point(23, 60);
            this.lbGameOver.Name = "lbGameOver";
            this.lbGameOver.Size = new System.Drawing.Size(954, 388);
            this.lbGameOver.TabIndex = 3;
            this.lbGameOver.Text = "GAME OVER";
            this.lbGameOver.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbGameOver.Visible = false;
            // 
            // msm_snake
            // 
            this.msm_snake.Owner = this;
            this.msm_snake.Style = MetroFramework.MetroColorStyle.Red;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel2.Location = new System.Drawing.Point(681, 455);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(296, 25);
            this.metroLabel2.TabIndex = 4;
            this.metroLabel2.Text = "Bewegung: Pfeiltasten. Beenden: ESC.";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel3.Location = new System.Drawing.Point(339, 455);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(143, 25);
            this.metroLabel3.TabIndex = 4;
            this.metroLabel3.Text = "Geschwindigkeit: ";
            // 
            // lbSpeed
            // 
            this.lbSpeed.AutoSize = true;
            this.lbSpeed.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lbSpeed.Location = new System.Drawing.Point(488, 455);
            this.lbSpeed.Name = "lbSpeed";
            this.lbSpeed.Size = new System.Drawing.Size(21, 25);
            this.lbSpeed.TabIndex = 4;
            this.lbSpeed.Text = "2";
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel4.Location = new System.Drawing.Point(521, 455);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(122, 25);
            this.metroLabel4.TabIndex = 4;
            this.metroLabel4.Text = "(+ und - Taste)";
            // 
            // form_snake
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 500);
            this.ControlBox = false;
            this.Controls.Add(this.lbSpeed);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.lbGameOver);
            this.Controls.Add(this.lbScore);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.pbCanvas);
            this.DoubleBuffered = false;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "form_snake";
            this.ShadowType = MetroFramework.Forms.MetroFormShadowType.AeroShadow;
            this.Style = MetroFramework.MetroColorStyle.Red;
            this.Text = "Snake";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form_snake_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form_snake_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.pbCanvas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.msm_snake)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbCanvas;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel lbScore;
        private System.Windows.Forms.Timer gameTimer;
        private MetroFramework.Controls.MetroLabel lbGameOver;
        private MetroFramework.Components.MetroStyleManager msm_snake;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel lbSpeed;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel3;
    }
}