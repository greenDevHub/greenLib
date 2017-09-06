﻿using System;
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
    public partial class w_s_details : Form
    {
        public w_s_details()
        {
            InitializeComponent();
            b.FillGrid(ref gv_Details);
            K_Einblenden();
            V_Einblenden();
        }

        Details details = new Details();
        Buch b = new Buch();

        private void Buch_Suchen()
        {
            Alle_Rows();

            if (cb_s_Titel.Checked == true)
            {
                for (int i = 0; i < gv_Details.RowCount; i++)
                {
                    string suche = tb_s_Titel.Text;
                    string ergebnis = gv_Details.Rows[i].Cells[5].Value.ToString();
                    if (ergebnis.Contains(suche) == false)
                    {
                        CurrencyManager cuma = (CurrencyManager)gv_Details.BindingContext[gv_Details.DataSource];
                        cuma.SuspendBinding();
                        gv_Details.Rows[i].Visible = false;
                    }
                }
            }

            if (cb_s_Autor.Checked == true)
            {
                for (int i = 0; i < gv_Details.RowCount; i++)
                {
                    string suche = tb_s_Autor.Text;
                    string ergebnis = gv_Details.Rows[i].Cells[16].Value.ToString();
                    if (ergebnis.Contains(suche) == false)
                    {
                        CurrencyManager cuma = (CurrencyManager)gv_Details.BindingContext[gv_Details.DataSource];
                        cuma.SuspendBinding();
                        gv_Details.Rows[i].Visible = false;
                    }
                }
            }

            if (cb_s_Genre.Checked == true)
            {
                for (int i = 0; i < gv_Details.RowCount; i++)
                {
                    string suche = tb_s_Genre.Text;
                    string ergebnis = gv_Details.Rows[i].Cells[14].Value.ToString();
                    if (ergebnis.Contains(suche) == false)
                    {
                        CurrencyManager cuma = (CurrencyManager)gv_Details.BindingContext[gv_Details.DataSource];
                        cuma.SuspendBinding();
                        gv_Details.Rows[i].Visible = false;
                    }
                }
            }

            if (cb_s_Verlag.Checked == true)
            {
                for (int i = 0; i < gv_Details.RowCount; i++)
                {
                    string suche = tb_s_Verlag.Text;
                    string ergebnis = gv_Details.Rows[i].Cells[18].Value.ToString();
                    if (ergebnis.Contains(suche) == false)
                    {
                        CurrencyManager cuma = (CurrencyManager)gv_Details.BindingContext[gv_Details.DataSource];
                        cuma.SuspendBinding();
                        gv_Details.Rows[i].Visible = false;
                    }
                }
            }
        }

        private void Alle_Rows()
        {
            for (int i = 0; i < gv_Details.RowCount; i++)
            {
                gv_Details.Rows[i].Visible = true;
            }
        }

        private void V_Einblenden()
        {
            if (cb_Ferfügbark_Anz.Checked == true)
            {
                cb_KundeAnz.Checked = false;
                for (int i = 0; i < gv_Details.RowCount; i++)
                {
                    string vergleich = "";
                    if (vergleich.Equals(gv_Details.Rows[i].Cells[24].Value.ToString()) == false)
                    {
                        CurrencyManager cuma = (CurrencyManager)gv_Details.BindingContext[gv_Details.DataSource];
                        cuma.SuspendBinding();
                        gv_Details.Rows[i].Visible = false;
                    }
                }
            }
            else
            {
                Buch_Suchen();
            }
        }

        private void K_Einblenden()
        {
            if (cb_KundeAnz.Checked == true)
            {
                gv_Details.Columns[29].Visible = true;
                gv_Details.Columns[30].Visible = true;
                gv_Details.Columns[31].Visible = true;
                gv_Details.Columns[32].Visible = true;
                gv_Details.Columns[33].Visible = true;
                gv_Details.Columns[34].Visible = true;
                gv_Details.Columns[35].Visible = true;
                gv_Details.Columns[36].Visible = true;
                gv_Details.Columns[37].Visible = true;
                gv_Details.Columns[38].Visible = true;
                gv_Details.Columns[39].Visible = true;
            }
            else if (cb_KundeAnz.Checked == false)
            {
                gv_Details.Columns[29].Visible = false;
                gv_Details.Columns[30].Visible = false;
                gv_Details.Columns[31].Visible = false;
                gv_Details.Columns[32].Visible = false;
                gv_Details.Columns[33].Visible = false;
                gv_Details.Columns[34].Visible = false;
                gv_Details.Columns[35].Visible = false;
                gv_Details.Columns[36].Visible = false;
                gv_Details.Columns[37].Visible = false;
                gv_Details.Columns[38].Visible = false;
                gv_Details.Columns[39].Visible = false;
            }
        }

        private void cb_KundeAnz_CheckedChanged(object sender, EventArgs e)
        {
            K_Einblenden();
        }

        private void cb_Ferfügbark_Anz_CheckedChanged(object sender, EventArgs e)
        {
            V_Einblenden();
        }

        private void ausleihvorgang(object sender, EventArgs e)
        {
            try
            {
                string bu_id = gv_Details.CurrentRow.Cells[0].Value.ToString();
                string bu_titel = gv_Details.CurrentRow.Cells[5].Value.ToString();
                //string aus_d = DateTime.Today.ToString();
                //string rück_d = dateTimePickerAusleihen.Value.ToString();

                using (var form = new w_s_Aus_Kunde())
                {
                    var result = form.ShowDialog();
                    if (result == DialogResult.OK)
                    {
                        string k_id = form.KundenID;
                        string k_vmane = form.KundenVName;
                        string k_nname = form.KundenNName;

                        this.tb_Kunde.Text = "(" + k_id + ") " + k_vmane + " " + k_nname;
                    }
                }
                tb_BuchID.Text = bu_id;
                tb_Titel.Text = bu_titel;
            }
            catch
            {
                MessageBox.Show("Wählen Sie ein Buch aus!");
            }
        }

        private void ausleihen(object sender, EventArgs e)
        {
            int bu_id = Convert.ToInt32(tb_BuchID.Text);
            string aus_d = DateTime.Today.ToString();
            string rück_d = dateTimePickerAusleihen.Value.ToString();
            string k_id = tb_Kunde.Text.Substring(1, 1);
            int kunde = Convert.ToInt32(k_id);
            b.Ausleihen(bu_id, aus_d, rück_d, kunde);
        }

        private void bt_Suchen_Click(object sender, EventArgs e)
        {
            Buch_Suchen();
        }
    }
}
