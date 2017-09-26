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
        public w_s_Aus_Kunde()
        {
            InitializeComponent();
        }
        #endregion

        Kunde kunde = new Kunde();

        #region Kunden Laden
        public void Load_Kunden(object sender, EventArgs e)
        {
            kunde.FillGrid(ref gv_Aus_Kunde);
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
            Form Kunden = new w_s_Kunden();
            Kunden.ShowDialog(this);
        }
        #endregion
    }
}
