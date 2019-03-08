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
        #region Eigenschaften des gewaehlten Kunden
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
        #endregion

        #region Objekt Constructor
        /// <summary>
        /// Erschaft die Form
        /// </summary>
        string name;
        public w_s_Aus_Kunde(string name)
        {
            this.Text = "Angemeldet als: " + name;
            this.Name = name;
            InitializeComponent();
        }
        #endregion

        Kunde kunde = new Kunde();

        #region Kunden Laden
        public void Load_Kunden(object sender, EventArgs e)
        {
            //kunde.FillGrid(ref gv_Aus_Kunde);
        }
        #endregion

        #region Gewaehlten Kunden zurueckgeben
        private void bt_Ausweahlen_Click(object sender, EventArgs e)
        {
            this.KundenID = gv_Aus_Kunde.CurrentRow.Cells[0].Value.ToString();
            this.KundenVName = gv_Aus_Kunde.CurrentRow.Cells[1].Value.ToString();
            this.KundenNName = gv_Aus_Kunde.CurrentRow.Cells[2].Value.ToString();
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
        #endregion

        #region Neuer Kunde
        private void bt_NeuKunde_Click(object sender, EventArgs e)
        {
            Form Kunden = new w_s_Kunden(name);
            Kunden.ShowDialog(this);
            //kunde.FillGrid(ref gv_Aus_Kunde);
        }
        #endregion

        private void VornameText()
        {
            tb_vorname.Text = "Vorname";
            tb_vorname.ForeColor = Color.Gray;
        }
        private void NachnameText()
        {
            tb_nachname.Text = "Nachname";
            tb_nachname.ForeColor = Color.Gray;
        }
        private void VornameClear()
        {
            tb_vorname.Text = "";
            tb_vorname.ForeColor = Color.Black;
        }
        private void NachnameClear()
        {
            tb_nachname.Text = "";
            tb_nachname.ForeColor = Color.Black;
        }
        private void tb_vorname_TextChanged(object sender, EventArgs e)
        {
            (gv_Aus_Kunde.DataSource as DataTable).DefaultView.RowFilter = string.Format("Vorname LIKE '{0}%'AND Nachname LIKE '{1}%'", tb_vorname.Text, tb_nachname.Text);
        }

        private void tb_nachname_TextChanged(object sender, EventArgs e)
        {
            (gv_Aus_Kunde.DataSource as DataTable).DefaultView.RowFilter = string.Format("Vorname LIKE '{0}%'AND Nachname LIKE '{1}%'", tb_vorname.Text, tb_nachname.Text);
        }

        private void lb_nachname_Click(object sender, EventArgs e)
        {
            lb_nachname.Visible = false;
            tb_nachname.Focus();
        }

        private void lb_Vorname_Click(object sender, EventArgs e)
        {
            lb_Vorname.Visible = false;
            tb_vorname.Focus();
        }

        private void tb_vorname_Click(object sender, EventArgs e)
        {
            lb_Vorname.Visible = false;
            tb_vorname.Focus();
        }

        private void tb_nachname_Click(object sender, EventArgs e)
        {
            lb_nachname.Visible = false;
            tb_nachname.Focus();
        }

        private void tb_nachname_Leave(object sender, EventArgs e)
        {
            if (tb_nachname.Text.Equals(""))
            {
                lb_nachname.Visible = true;
            }
        }

        private void tb_vorname_Leave(object sender, EventArgs e)
        {
            if (tb_vorname.Text.Equals(""))
            {
                lb_Vorname.Visible = true;
            }
        }
    }
}
