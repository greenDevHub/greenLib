using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bibo_Verwaltung
{
    public partial class w_s_sprachen : Form
    {
        public w_s_sprachen()
        {
            InitializeComponent();
            sprache.FillGrid(ref gv_Sprachen);
            originalHeightLabel = tLP_Sprachen.RowStyles[0].Height;
            originalHeightText = tLP_Sprachen.RowStyles[1].Height;
            tLP_Sprachen.RowStyles[0].Height = 0;
            tLP_Sprachen.RowStyles[1].Height = 0;
        }

        #region globale Variablen
        float originalHeightLabel = 0;
        float originalHeightText = 0;
        Sprache sprache = new Sprache();
        bool suchmodus = false;
        bool aenderungungen = false;
        #endregion

        #region Schliessen-Aktion
        private void w_s_sprachen_FormClosing(object sender, FormClosingEventArgs e)
        {           
            if (aenderungungen == true)
            {
                gv_Sprachen.EndEdit();
                DialogResult dr = MessageBox.Show("Sollen die Änderungen gespeichert werden?", "Warnung", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
                if (dr == DialogResult.Yes)
                {
                    try
                    {
                        bt_Uebernehmen.Focus();  
                        sprache.SaveGrid(ref gv_Sprachen);
                    }
                    catch
                    {
                        MessageBox.Show("Die Änderungen konnten nicht gespeichert werden!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else if (dr == DialogResult.Cancel)
                {
                    e.Cancel = true;
                }
            }
        }

        private void bt_Uebernehmen_Click(object sender, EventArgs e)
        {
            try
            {
                sprache.SaveGrid(ref gv_Sprachen);
                aenderungungen = false;
            }
            catch
            {
                MessageBox.Show("Die Änderungen konnten nicht gespeichert werden!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        #region Doppelte Einträge entfernen (Deaktiviert)
        /**
        public DataTable RemoveDuplicateRows(DataTable dTable, string colName)
        {
            Hashtable hTable = new Hashtable();
            ArrayList duplicateList = new ArrayList();

            //Add list of all the unique item value to hashtable, which stores combination of key, value pair.
            //And add duplicate item value in arraylist.
            foreach (DataRow drow in dTable.Rows)
            {
                if (hTable.Contains(drow[colName]))
                    duplicateList.Add(drow);
                else
                    hTable.Add(drow[colName], string.Empty);
            }

            //Removing a list of duplicate items from datatable.
            foreach (DataRow dRow in duplicateList)
                dTable.Rows.Remove(dRow);

            //Datatable which contains unique records will be return as output.
            return dTable;
        }
        private void Doppelte_Entfernen()
        {
            DataTable dt = RemoveDuplicateRows((gv_Sprachen.DataSource as DataTable).DefaultView.ToTable(), "sprach_name");
            gv_Sprachen.DataSource = dt;

            //for (int currentRow = 0; currentRow < gv_Sprachen.Rows.Count; currentRow++)
            //{
            //    var rowToCompare = gv_Sprachen.Rows[currentRow]; // Get row to compare against other rows

            //    // Iterate through all rows 
            //    //
            //    foreach (var row in gv_Sprachen.Rows)
            //    {
            //        if (rowToCompare.Equals(row)) continue; // If row is the same row being compared, skip.

            //        bool duplicateRow = true;

            //        // Compare the value of all cells
            //        //
            //        //for (int cellIndex = 0; cellIndex < row.Cells.Count; cellIndex++)
            //        //{
            //            if ((null != rowToCompare.Cells[0].Value) &&
            //                (!rowToCompare.Cells[0].Value.Equals(gv_Sprachen.Rows[Convert.ToUInt32(row)].Cells[0].Value)))
            //            {
            //                duplicateRow = false;
            //                break;
            //            }
            //        //}

            //        if (duplicateRow)
            //        {
            //            gv_Sprachen.Rows.Remove(row);
            //        }
            //    }
            //}

            Console.WriteLine(dt);
            Console.WriteLine("Kall");
            //// }
        }
        **/
        #endregion

        #region Zeile löschen mit Ruecktaste
        private void dataGridView_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Back)
            {
                    SendKeys.Send("{DELETE}");
            }
        }
        #endregion

        #region Suchen-Aktionen
        private void bt_Suchen_Click(object sender, EventArgs e)
        {
            if (suchmodus == false)
            {
                suchmodus = true;
                bt_Suchen.Text = "Suchen AUS";
                tLP_Sprachen.RowStyles[0].Height = originalHeightLabel;
                tLP_Sprachen.RowStyles[1].Height = originalHeightText;
                tb_Suchen.Visible = true;
                tb_Suchen.Enabled = true;
                tb_Suchen.Focus();
            }
            else
            {
                suchmodus = false;
                bt_Suchen.Text = "Suchen AN";
                tb_Suchen.Visible = false;
                tb_Suchen.Enabled = false;
                tb_Suchen.Text = "";
                tLP_Sprachen.RowStyles[0].Height = 0;
                tLP_Sprachen.RowStyles[1].Height = 0;
            }
        }

        private void tb_Suchen_TextChanged(object sender, EventArgs e)
        {
            (gv_Sprachen.DataSource as DataTable).DefaultView.RowFilter = string.Format("sprach_name LIKE '{0}%'", tb_Suchen.Text);
        }
        #endregion

        #region Aenderungen an GridView erkennen
        private void gv_Sprachen_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            aenderungungen = true;
        }

        private void gv_Sprachen_UserDeletedRow(object sender, DataGridViewRowEventArgs e)
        {
            aenderungungen = true;
        }
        #endregion
    }
}
