using Bibo_Verwaltung.Helper;
using MetroFramework;
using MetroFramework.Components;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bibo_Verwaltung
{
    public partial class FormReturn : MetroFramework.Forms.MetroForm
    {
        #region Constructor
        ConditionHelper conditionHelper = new ConditionHelper();
        public FormReturn()
        {
            InitializeComponent();
            LoadTheme();
            SetPermissions();
            this.Text = Text + AuthInfo.FormInfo();
        }
        public FormReturn(string[] list)
        {
            InitializeComponent();
            LoadTheme();
            SetPermissions();
            rueckgabe.FillRueckListe(list);
            rueckgabe.SetSlider(ref rueckList_Slider, ref tb_listVon, ref tb_listBis);
            this.Text = Text + AuthInfo.FormInfo();
        }
        #endregion

        private void LoadTheme()
        {
            this.StyleManager = styleManagerReturn;
            this.StyleManager.Theme = ThemeInfo.StyleManager.Theme;
            this.StyleManager.Style = ThemeInfo.ReturnStyle;
            cb_Zustand.ForeColor = ThemeInfo.ForeColor;
            cb_Zustand.BackColor = ThemeInfo.BackColor;
            picBox_Buchcover.BackColor = ThemeInfo.BackColor;
        }

        private void SetPermissions()
        {
            if (AuthInfo.CurrentUser.PermissionId.Equals("0"))
            {
                bt_AddBuch.Enabled = false;
                bt_Zu_aendern.Enabled = false;
                bt_Rueckgabe.Enabled = false;
            }
            else
            {
                bt_AddBuch.Enabled = true;
                bt_Zu_aendern.Enabled = true;
                bt_Rueckgabe.Enabled = true;
                conditionHelper.FillCombobox(ref cb_Zustand, -1);
            }
        }

        ReturnHelper rueckgabe = new ReturnHelper();
        Costumer kunde = new Costumer();

        #region Fenster-Methoden
        /// <summary>
        /// Exemplar-Code-Parser
        /// </summary>
        static int _checksum_ean8(String data)
        {
            // Test string for correct length
            if (data.Length != 7 && data.Length != 8)
                return -1;
            // Test string for being numeric
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] < 0x30 || data[i] > 0x39)
                    return -1;
            }
            int sum = 0;
            for (int i = 6; i >= 0; i--)
            {
                int digit = data[i] - 0x30;
                if ((i & 0x01) == 1)
                    sum += digit;
                else
                    sum += digit * 3;
            }
            int mod = sum % 10;
            return mod == 0 ? 0 : 10 - mod;
        }

        ///// <summary>
        ///// Schneidet einen String auf eine Länge von 30 Zeichen
        ///// </summary>
        //private String TrimText(string inputText)
        //{
        //    string outputText = "";
        //    if (inputText.Length > 30)
        //    {
        //        outputText = inputText.Substring(0, 30) + "...";
        //    }
        //    else
        //    {
        //        outputText = inputText;
        //    }
        //    return outputText.Trim();
        //}

        /// <summary>
        /// Setzt das Fenster auf den Ausgangszustand zurück (alles leer)
        /// </summary>
        private void Reset_Window()
        {
            llb_BuchTitel.Enabled = false;
            llb_BuchTitel.Text = "keine Treffer";
            llb_Kunde.Enabled = false;
            llb_Kunde.Text = "nicht verliehen";
            lb_AusleihStart.Enabled = false;
            lb_AusleihStart.Text = "nicht verfügbar";
            lb_AusleihEnde.Enabled = false;
            lb_AusleihEnde.Text = "nicht verfügbar";
            cb_Zustand.TabStop = false;
            tpanel.Visible = true;
            bt_Zu_aendern.Text = "Buchzustand ändern";
            cb_Zustand.SelectedValue = -1;
            lb_AusleihEnde.ForeColor = Color.Black;
            picBox_Buchcover.Image = null;
            gv_Verlauf.DataSource = null;
            gv_Verlauf.Update();
            bt_Zu_aendern.Enabled = false;
        }

        ///// <summary>
        ///// Löscht eine Bilddatei am angegebenen Pfad
        ///// </summary>
        //private void Delete_picture(string path)
        //{
        //    if (File.Exists(path))
        //    {
        //        File.Delete(path);
        //    }
        //}

        ///// <summary>
        ///// Setzt den Auswahl-Slider anhand der Elemente der Rückgabeliste
        ///// </summary>
        //private void SetSlider()
        //{
        //    if (rueckListe.Rows.Count == 0)
        //    {
        //        rueckList_Slider.Enabled = false;
        //        rueckList_Slider.Minimum = 0;
        //        rueckList_Slider.Maximum = 0;
        //    }
        //    else
        //    {
        //        rueckList_Slider.Enabled = true;
        //        rueckList_Slider.Minimum = 1;
        //        rueckList_Slider.Maximum = rueckListe.Rows.Count;
        //        rueckList_Slider.Value = rueckList_Slider.Maximum;
        //    }
        //    tb_listVon.Text = rueckList_Slider.Value.ToString();
        //    tb_listBis.Text = rueckList_Slider.Maximum.ToString();
        //}

        ///// <summary>
        ///// Prüft die Buchrückgabeliste auf das Vorhandensein der angegebenen Exemlar ID 
        ///// </summary>
        //private bool CheckRueckList(string ExemlarID)
        //{
        //    bool result = false;
        //    for (int i = 0; i <= rueckListe.Rows.Count - 1; i++)
        //    {
        //        if (rueckListe.Rows[i][0].ToString() == ExemlarID)
        //        {
        //            result = true;
        //        }
        //    }
        //    return result;
        //}

        ///// <summary>
        ///// Baut einen Dialogstring abhängig von der Buchrückgabe-Anzahl
        ///// </summary>
        //private String GetRueckgabeList()
        //{
        //    Exemplar exemplar;
        //    Buch exemplar_info;
        //    string resultString = "Möchten Sie ";
        //    if (rueckListe.Rows.Count == 1)
        //    {
        //        exemplar = new Exemplar(rueckListe.Rows[0][0].ToString());
        //        exemplar_info = new Buch(exemplar.ISBN);
        //        resultString = resultString + "das Buch: " + Environment.NewLine + Environment.NewLine + exemplar_info.Titel + ", " + Environment.NewLine + Environment.NewLine;
        //    }
        //    else
        //    {
        //        resultString = resultString + "die Bücher: " + Environment.NewLine + Environment.NewLine;
        //        foreach (DataRow row in rueckListe.Rows)
        //        {
        //            exemplar = new Exemplar(row[0].ToString());
        //            exemplar_info = new Buch(exemplar.ISBN);
        //            resultString = resultString + "-  " + TrimText(exemplar_info.Titel) + ", " + Environment.NewLine;
        //        }
        //        resultString = resultString + Environment.NewLine;
        //    }
        //    return resultString;
        //}

        /// <summary>
        /// Zeigt die Suchergebnisse an
        /// </summary>
        private void ShowBuchResults()
        {
            #region Buchcode parsen
            if (tb_BuchCode.Text.Length == 8)
            {
                string seven = tb_BuchCode.Text.Substring(0, 7);
                string eight = tb_BuchCode.Text.Substring(7, 1);
                if (_checksum_ean8(seven).ToString().Equals(eight))
                {
                    tb_BuchCode.Text = int.Parse(seven).ToString();
                }
            }
            #endregion

            if (tb_BuchCode.Text != "")
            {
                try
                {
                    Copy copy = new Copy(int.Parse(tb_BuchCode.Text));
                    if (copy.CopyActivated)
                    {
                        rueckgabe.Copy = copy;
                        if (rueckgabe.CheckRueckList())
                        {
                            bt_AddBuch.Text = "-";
                        }
                        else
                        {
                            bt_AddBuch.Text = "+";
                        }
                        rueckgabe.IsAvailable = copy.IsAvailable();
                        llb_BuchTitel.Enabled = true;
                        llb_BuchTitel.Text =rueckgabe.TrimText( copy.CopyTitle,30);
                        //llb_BuchTitel.Text = rueckgabe.TrimText(new Buch(buch_exemplar.ISBN).Titel, 30);
                        cb_Zustand.SelectedValue = copy.Condition.ConditionId;
                        rueckgabe.StartCondition = copy.Condition;
                        rueckgabe.EndCondition = copy.Condition;
                        HistoryHelper verlauf = new HistoryHelper(rueckgabe.Copy.CopyId);
                        verlauf.FillGrid(ref gv_Verlauf);

                        if (!rueckgabe.IsAvailable)
                        {
                            rueckgabe.LoadInfo(rueckgabe.Copy.CopyId);
                            kunde = rueckgabe.Costumer;
                            llb_Kunde.Enabled = true;
                            lb_AusleihStart.Enabled = true;
                            lb_AusleihEnde.Enabled = true;
                            bt_Zu_aendern.Enabled = true;
                            llb_Kunde.Text = rueckgabe.TrimText(kunde.CostumerFirstName + ", " + kunde.CostumerSurname, 30);
                            lb_AusleihStart.Text = rueckgabe.BorrowDate.Date.ToShortDateString();
                            lb_AusleihEnde.Text = rueckgabe.ReturnDate.Date.ToShortDateString();
                            if (rueckgabe.ReturnDate.Date < DateTime.Now.Date)
                            {
                                lb_AusleihEnde.ForeColor = Color.Red;
                                lb_AusleihEnde.Text = lb_AusleihEnde.Text + " (überfällig)";
                            }
                        }
                        else
                        {
                            llb_Kunde.Enabled = false;
                            lb_AusleihStart.Enabled = false;
                            lb_AusleihEnde.Enabled = false;
                            bt_Zu_aendern.Enabled = false;
                            llb_Kunde.Text = "nicht verliehen";
                            lb_AusleihStart.Text = "nicht verfügbar";
                            lb_AusleihEnde.Text = "nicht verfügbar";
                            lb_AusleihEnde.ForeColor = default;
                        }
                        rueckgabe.ShowBuchCover(ref picBox_Buchcover);
                    }
                    else
                    {
                        Reset_Window();
                    }
                }
                catch
                {
                    Reset_Window();
                }
            }
            else
            {
                Reset_Window();
            }
            Cursor = Cursors.Default;
        }

        private void EnterBuch()
        {
            if (tb_BuchCode.Text != "")
            {

                if (!rueckgabe.IsAvailable)
                {
                    if (!rueckgabe.CheckRueckList())
                    {
                        if (bt_Zu_aendern.Text == "Übernehmen")
                        {
                            DialogResult dr = MetroMessageBox.Show(this, "Möchten Sie die Zustandsänderung übernehmen?", "Achtung", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                            if (dr == DialogResult.Yes)
                            {
                                rueckgabe.EndCondition = new Condition(conditionHelper.FindIdByName(cb_Zustand.Text));
                                cb_Zustand.TabStop = false;
                                tpanel.Visible = true;
                                bt_Zu_aendern.Text = "Buchzustand ändern";
                            }
                            else
                            {
                                rueckgabe.EndCondition = rueckgabe.StartCondition;
                                cb_Zustand.TabStop = false;
                                tpanel.Visible = true;
                                bt_Zu_aendern.Text = "Buchzustand ändern";
                            }
                        }
                        rueckgabe.AddToRueckgabeList();
                        bt_AddBuch.Text = "-";
                    }
                    else
                    {
                        rueckgabe.RemoveFromRueckgabeList();
                        bt_AddBuch.Text = "+";
                    }
                }
                else
                {
                    MetroMessageBox.Show(this, "Dieses Buch wurde nicht verliehen. Es kann nicht zur Buchrückgabeliste hinzugefügt werden.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                rueckgabe.SetSlider(ref rueckList_Slider, ref tb_listVon, ref tb_listBis);
                tb_BuchCode.Focus();
                tb_BuchCode.SelectAll();
            }
        }

        /// <summary>
        /// Führt die Buchrückgabe aus
        /// </summary>
        private void Buchrueckgabe()
        {
            DialogResult dialogResult = MetroMessageBox.Show(this, rueckgabe.GetRueckgabeList() + "ausgeliehen von: '" + rueckgabe.TrimText(kunde.CostumerFirstName + " " + kunde.CostumerSurname, 30) + "' wirklich als zurückgegeben markieren?", "Achtung",
                            MessageBoxButtons.OKCancel, MessageBoxIcon.Question, 211 + rueckgabe.ReturnDataTable.Rows.Count * 17);
            if (dialogResult == DialogResult.OK)
            {
                try
                {
                    foreach (DataRow row in rueckgabe.ReturnDataTable.Rows)
                    {
                        rueckgabe.LoadInfo(int.Parse(row[0].ToString()));
                        Condition condition = rueckgabe.EndCondition;
                        rueckgabe.Execute_Rueckgabe(rueckgabe.Copy.CopyId, rueckgabe.Costumer.CostumerId, rueckgabe.StartCondition.ConditionName.ToString(),
                            condition.ConditionId, rueckgabe.EndCondition.ConditionName.ToString(), rueckgabe.BorrowDate.ToShortDateString(), DateTime.Now.Date.ToShortDateString());
                    }
                    MetroMessageBox.Show(this, "Die Buchrückgabe wurde erfolgreich abgeschlossen!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch
                {
                    MetroMessageBox.Show(this, "Die Buchrückgabe konnte nicht abgeschlossen werden!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                rueckgabe.ClearRueckList();
                rueckgabe.SetSlider(ref rueckList_Slider, ref tb_listVon, ref tb_listBis);
                tb_BuchCode.Text = "";
                tb_BuchCode.Focus();
            }
        }
        #endregion

        #region Componenten-Aktionen
        private void tb_BuchCode_TextChanged(object sender, EventArgs e)
        {
            if (tb_BuchCode.Text.Length == 8 && _checksum_ean8(tb_BuchCode.Text.Substring(0, 7)).ToString().Equals(tb_BuchCode.Text.Substring(7, 1)))
            {
                tb_BuchCode.Text = int.Parse(tb_BuchCode.Text.Substring(0, 7)).ToString();
                ShowBuchResults();

            }
            else if( tb_BuchCode.Text == "")
            {
                ShowBuchResults();

            }
            else if (rueckgabe.ReturnDataTable.AsEnumerable().Any(row => tb_BuchCode.Text == row.Field<String>("Column1")))
            {
                ShowBuchResults();
            }
            else
            {
                timer_input.Stop();
                timer_input.Start();

            }
        }

        private void llb_Buch_LinkClicked(object sender, EventArgs e)
        {
            FormInformation formBookInformation = new FormInformation(1, rueckgabe.Copy.CopyId);
            formBookInformation.ShowDialog();
            formBookInformation.Dispose();
        }

        private void llb_Kunde_LinkClicked(object sender, EventArgs e)
        {
            FormInformation formCostumerInformation = new FormInformation(2, kunde.CostumerId);
            formCostumerInformation.ShowDialog();
            formCostumerInformation.Dispose();
        }

        private void bt_Rueckgabe_Click(object sender, EventArgs e)
        {
            if (rueckgabe.ReturnDataTable.Rows.Count == 0)
            {
                EnterBuch();
            }
            if (rueckgabe.ReturnDataTable.Rows.Count != 0)
            {
                Buchrueckgabe();
            }
        }

        private void bt_Zu_aendern_Click(object sender, EventArgs e)
        {
            if (cb_Zustand.TabStop == false)
            {
                tpanel.Visible = false;
                cb_Zustand.TabStop = true;
                //cb_Zustand.Enabled = true;
                bt_Zu_aendern.Text = "Übernehmen";
            }
            else
            {
                tpanel.Visible = true;
                rueckgabe.EndCondition = new Condition(conditionHelper.FindIdByName(cb_Zustand.Text));
                cb_Zustand.TabStop = false;
                //cb_Zustand.Enabled = false;
                bt_Zu_aendern.Text = "Buchzustand ändern";
            }
        }

        private void bt_open_Click(object sender, EventArgs e)
        {
            int index = cb_Zustand.SelectedIndex;
            FormAttribute Zustand = new FormAttribute("Zustand");
            Zustand.ShowDialog(this);
            Zustand.Dispose();
            if (!AuthInfo.CurrentUser.PermissionId.Equals("0"))
            {
                conditionHelper.FillCombobox(ref cb_Zustand, -1);
            }
            cb_Zustand.SelectedIndex = index;
        }

        private void bt_AddBuch_Click(object sender, EventArgs e)
        {
            EnterBuch();
        }

        private void Tb_BuchCode_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!AuthInfo.CurrentUser.PermissionId.Equals("0"))
            {
                if (e.KeyChar == (char)13)
                {
                    EnterBuch();
                }
            }
        }

        private void Llb_gesListe_Click(object sender, EventArgs e)
        {
            MetroMessageBox.Show(this, rueckgabe.GetListInfo(), "Information", MessageBoxButtons.OK, MessageBoxIcon.Information, (150 + rueckgabe.ReturnDataTable.Rows.Count * 15));
        }

        private void RueckList_Slider_ValueChanged(object sender, EventArgs e)
        {
            tb_listVon.Text = rueckList_Slider.Value.ToString();
            tb_listBis.Text = rueckList_Slider.Maximum.ToString();
            if (rueckgabe.ReturnDataTable.Rows.Count > 0)
            {
                tb_BuchCode.Text = rueckgabe.ReturnDataTable.Rows[rueckList_Slider.Value - 1][0].ToString();
            }
            else
            {
                tb_BuchCode.Text = "";
            }
            tb_BuchCode.Focus();
            tb_BuchCode.SelectAll();
        }

        private void RueckList_Slider_Scroll(object sender, ScrollEventArgs e)
        {
            tb_listVon.Text = rueckList_Slider.Value.ToString();
            tb_listBis.Text = rueckList_Slider.Maximum.ToString();
            tb_BuchCode.Text = rueckgabe.ReturnDataTable.Rows[rueckList_Slider.Value - 1][0].ToString();
            tb_BuchCode.Focus();
            tb_BuchCode.SelectAll();
        }

        private void W_s_rueckgabe_Shown(object sender, EventArgs e)
        {
            tb_BuchCode.Focus();
        }

        private void Tb_listBis_TextChanged(object sender, EventArgs e)
        {
            tb_listVon.Text = rueckList_Slider.Value.ToString();
            tb_listBis.Text = rueckList_Slider.Maximum.ToString();
            if (rueckgabe.ReturnDataTable.Rows.Count > 0)
            {
                tb_BuchCode.Text = rueckgabe.ReturnDataTable.Rows[rueckList_Slider.Value - 1][0].ToString();
            }
            else
            {
                tb_BuchCode.Text = "";
            }
            tb_BuchCode.Focus();
            tb_BuchCode.SelectAll();
        }
        #endregion

        private void MetroToolTip1_Popup(object sender, PopupEventArgs e)
        {
            e.ToolTipSize = new Size(e.ToolTipSize.Width + 32, e.ToolTipSize.Height);
        }

        private void timer_input_Tick(object sender, EventArgs e)
        {
            ShowBuchResults();
            timer_input.Stop();
        }
    }
}
