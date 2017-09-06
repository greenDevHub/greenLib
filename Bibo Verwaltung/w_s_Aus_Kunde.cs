using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bibo_Verwaltung
{
    public partial class w_s_Aus_Kunde : Form
    {
        string kundeid;
        /// <summary>
        /// ID des gewaehlten Kunden
        /// </summary>
        public string KundenID { get { return kundeid; } set { kundeid = value; } }

        string kundevname;
        /// <summary>
        /// Vorname des gewaehlten Kunden
        /// </summary>
        public string KundenVName { get { return kundevname; } set { kundevname = value; } }

        string kundenname;
        /// <summary>
        /// Nachname des gewaehlten Kunden
        /// </summary>
        public string KundenNName { get { return kundenname; } set { kundenname = value; } }

        public w_s_Aus_Kunde()
        {
            InitializeComponent();
            kunde.FillGrid(ref gv_Aus_Kunde);
            //Alles_Einblenden();
            gv_Aus_Kunde.Columns[0].Visible = false;
            gv_Aus_Kunde.Columns[3].Visible = false;
            gv_Aus_Kunde.Columns[4].Visible = false;
            gv_Aus_Kunde.Columns[5].Visible = false;
            gv_Aus_Kunde.Columns[6].Visible = false;
            gv_Aus_Kunde.Columns[9].Visible = false;
            gv_Aus_Kunde.Columns[10].Visible = false;
            gv_Aus_Kunde.Columns[11].Visible = false;
        }

        Kunde kunde = new Kunde();

        private void Alles_Einblenden()
        {
            if (cb_Alles.Checked == true)
            {
                gv_Aus_Kunde.Columns[0].Visible = true; //1278
                gv_Aus_Kunde.Columns[3].Visible = true;
                gv_Aus_Kunde.Columns[4].Visible = true;
                gv_Aus_Kunde.Columns[5].Visible = true;
                gv_Aus_Kunde.Columns[6].Visible = true;
                gv_Aus_Kunde.Columns[9].Visible = true;
                gv_Aus_Kunde.Columns[10].Visible = true;
                gv_Aus_Kunde.Columns[11].Visible = true;
            }
            else if (cb_Alles.Checked == false)
            {
                gv_Aus_Kunde.Columns[0].Visible = false;
                gv_Aus_Kunde.Columns[3].Visible = false;
                gv_Aus_Kunde.Columns[4].Visible = false;
                gv_Aus_Kunde.Columns[5].Visible = false;
                gv_Aus_Kunde.Columns[6].Visible = false;
                gv_Aus_Kunde.Columns[9].Visible = false;
                gv_Aus_Kunde.Columns[10].Visible = false;
                gv_Aus_Kunde.Columns[11].Visible = false;
            }
        }

        private void bt_Ausweahlen_Click(object sender, EventArgs e)
        {
            this.KundenID = gv_Aus_Kunde.CurrentRow.Cells[0].Value.ToString();
            this.KundenVName = gv_Aus_Kunde.CurrentRow.Cells[1].Value.ToString();
            this.KundenNName = gv_Aus_Kunde.CurrentRow.Cells[2].Value.ToString();
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void cb_Alles_CheckedChanged(object sender, EventArgs e)
        {
            Alles_Einblenden();
        }
    }
}
