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
    public partial class w_s_buch_fach : Form
    {
        public w_s_buch_fach()
        {
            InitializeComponent();
            bf.FillGrid(ref gv_bf);
            bf.Fach.FillCombobox(ref cb_fach, 0);

            foreach (var pb in tLP_1.Controls.OfType<ComboBox>())
            {
                ComboBoxes.Add(pb);
            }
            foreach(var bt in tLP_1.Controls.OfType<Button>())
            {
                Buttons.Add(bt);
            }
            for (int i = 1; i < 8;)
            {
                ComboBoxes[i].Visible = false;
                Buttons[i].Visible = false;
                i++;
            }
            ctr1 = tLP_1.GetControlFromPosition(0, 8);
            tLP_1.SetRow(ctr1, 1);
            FillComboboxes(false);
            Clear();
           

        }
        bool isChecked = false;
        private void FillComboboxes(bool keepSelected)
        {
            foreach (ComboBox cb in ComboBoxes)
            {
                ComboBox c = cb;
                Buch_Fach buchfach = new Buch_Fach();
                if (keepSelected && c.SelectedValue != null)
                {
                    string cbValue = c.SelectedValue.ToString();
                    buchfach.Buch.FillCombobox(ref c, 0);
                    c.SelectedValue = cbValue;
                }
                else
                {
                    buchfach.Buch.FillCombobox(ref c, 0);
                }
            }
        }
        Control ctr1 = new Control();
        Buch_Fach bf = new Buch_Fach();
        int index = 0;
        List<ComboBox> ComboBoxes = new List<ComboBox>();
        List<Button> Buttons = new List<Button>();
        private void bt_buch_Click(object sender, EventArgs e)
        {
            var button = (Button)sender;
            string name = button.Name;
            name = name.Substring(7);
            index = int.Parse(name)-1;
            //w_s_buecher Buch = new w_s_buecher(false);
            //Buch.ShowDialog(this);

            
            //FillComboboxes(true);
            for(int i = index; i < 8;)
            {
                //Buch_Fach bufa = new Buch_Fach();
                try
                {
                    if (ComboBoxes[i + 1].SelectedValue != null)
                    {
                        ComboBox cmbBx = ComboBoxes[i];
                        string cbName = cmbBx.Name;
                        //bufa.IsbnListe.Buch.FillCombobox(ref cmbBx, 0);
                        cmbBx.SelectedValue = ComboBoxes[i + 1].SelectedValue;
                        ComboBoxes[i + 1].SelectedValue = 0;
                    }
                    else if (ComboBoxes[i + 1].SelectedValue == null)
                    {
                        ComboBoxes[i].SelectedValue = 0;
                        ComboBoxes[i + 1].Visible = false;
                        Buttons[i + 1].Visible = false;
                    }
                }
                catch (System.ArgumentOutOfRangeException)
                {
                    ComboBoxes[i].SelectedValue = 0;
                }
                
                //{
                //    ComboBoxes[i + 1].Visible = false;
                //    Buttons[i + 1].Visible = false;
                    
                //}
                i++;
            }
            //bf.IsbnListe.Buch.FillCombobox(ref cmbBx, 0);
            
            
            //Buch.Close();
            //if(index < 8 && ComboBoxes[index+1].SelectedValue == null)
            //{
            //    if (ComboBoxes[index+2].SelectedValue == null)
            //    {
            //        ComboBoxes[index + 2].Visible = false;
            //        Buttons[index + 2].Visible = false;
            //        tLP_1.SetRow(ctr1, index + 2);
            //    }

            //}
            for(int i = 0; i < 8;)
            {
                if(ComboBoxes[i].SelectedValue == null)
                {
                    index = i-1;
                    i = 8;
                }
                else
                {
                    index = i;
                }
                i++;
            }
            tLP_1.SetRow(ctr1, index + 2);
        }
        private void cb_selected(object sender, EventArgs e)
        {
            var cb = (ComboBox)sender;
            string name = cb.Name;
            name = name.Substring(7);
            int ind = 0;
            ind = int.Parse(name);
            if (ind < 8 && cb.SelectedValue != null)
            {
                if (!ComboBoxes[ind].Visible)
                {
                    ComboBoxes[ind].Visible = true;
                    Buttons[ind].Visible = true;
                    tLP_1.SetRow(ctr1, ind + 1);
                }

            }
        }

        private void bt_add_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 8;)
            {
                if (ComboBoxes[i].SelectedValue == null)
                {
                    index = i - 1;
                    i = 8;
                }
                else
                {
                    index = i;
                }
                i++;
            }
            if (rb_neu.Checked)
            {
                Buch_Fach bufa = new Buch_Fach();
                bufa.IsbnListe.Clear();
                for(int i = 0; i < 8;)
                {
                    if (i < index+1)
                    {
                        bufa.IsbnListe.Add(ComboBoxes[i].SelectedValue.ToString());
                    }
                    //else
                    //{
                    //    bufa.IsbnListe.Add("");
                    //}
                    i++;
                }
                if(bufa.GetID(cb_fach.SelectedValue.ToString(), cb_klasse.Text) == null || bufa.GetID(cb_fach.SelectedValue.ToString(), cb_klasse.Text) == "")
                {
                    bufa.Fach.FachID = cb_fach.SelectedValue.ToString();
                    bufa.Klassenstufe = cb_klasse.Text;
                    bufa.AddBF();
                }
                else
                {
                    MessageBox.Show("Ein Eintrag zu dem gewählten Fach und der gewählten Klassenstufe ist bereits vorhanden. Bitte löschen Sie diesen Eintrag bevor Sie einen neuen anlegen oder bearbeiten Sie den bereits vorhandenen Eintrag.", "Achtung", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                
                
                if (isChecked)
                {
                    try
                    {
                        int fachindex = cb_fach.SelectedIndex;
                        int klasseindex = cb_klasse.SelectedIndex;
                        Clear();
                        cb_klasse.SelectedIndex = klasseindex + 1;
                        cb_fach.SelectedIndex = fachindex;
                    }
                    catch
                    {
                        int fachindex = cb_fach.SelectedIndex;
                        Clear();
                        cb_klasse.SelectedIndex = 0;
                        cb_fach.SelectedIndex = fachindex;
                    }
                }
            }
            else if (rb_edit.Checked)
            {
                Buch_Fach bufa = new Buch_Fach(bf.GetID(cb_fach.SelectedValue.ToString(), cb_klasse.Text));
                //bufa.Fach.FachID = cb_fach.SelectedValue.ToString();
                //bufa.Klassenstufe = cb_klasse.Text;
                bufa.IsbnListe.Clear();
                for (int i = 0; i < 8;)
                {
                    if (i < index+1)
                    {
                        bufa.IsbnListe.Add(ComboBoxes[i].SelectedValue.ToString());
                        //bufa.IsbnListe.ISBNs[i] = ComboBoxes[i].SelectedValue.ToString();
                    }
                    //else
                    //{
                    //    bufa.IsbnListe.ISBNs[i] = "";
                    //}
                    i++;
                }
                //bufa.IsbnListe.IsbnListeID = bufa.GetIsbnID(bufa.GetID(bufa.Fach.FachID, bufa.Klassenstufe));
                try
                {
                    bufa.Save();
                }
                catch
                {
                    MessageBox.Show("Beim Speichern ist ein Fehler aufgetreten.", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (rb_delete.Checked)
            {
                try
                {
                    Buch_Fach bufa = new Buch_Fach(bf.GetID(cb_fach.SelectedValue.ToString(), cb_klasse.Text));
                    bufa.DeleteBF();
                }
                catch
                {
                    MessageBox.Show("Beim Löschen ist ein Fehler aufgetreten.", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            bf.FillGrid(ref gv_bf);
        }

        #region Modus
        private void Modus()
        {
            if (rb_neu.Checked)
            {
                lb.Text = "Das Buch wurde hinzugefügt!";
                bt_add.Text = "Hinzufügen";
            }
            else if (rb_delete.Checked)
            {
                lb.Text = "Das Buch wurde gelöscht!";
                bt_add.Text = "Löschen";
            }
            else if (rb_edit.Checked)
            {
                lb.Text = "Das Buch wurde gespeichert!";
                bt_add.Text = "Speichern";
            }
        }
        #endregion

        private void rb_neu_CheckedChanged(object sender, EventArgs e)
        {
            Modus();
        }

        private void rb_edit_CheckedChanged(object sender, EventArgs e)
        {
            Modus();
        }

        private void rb_delete_CheckedChanged(object sender, EventArgs e)
        {
            Modus();
        }

        private void w_b_buch_fach_Load(object sender, EventArgs e)
        {
            
        }

        private void gv_bf_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Clear();
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.gv_bf.Rows[e.RowIndex];
                string fach = row.Cells[GetColumnIndexByName(gv_bf, "Fach")].Value.ToString();
                cb_fach.SelectedValue = bf.Fach.GetID(fach);
                string stufe = row.Cells[GetColumnIndexByName(gv_bf, "Klassenstufe")].Value.ToString();
                cb_klasse.SelectedItem = stufe;
                Buch_Fach buchfach = new Buch_Fach(bf.GetID(bf.Fach.GetID(fach), stufe));
                int i = 0;
                foreach(string isbn in buchfach.IsbnListe)
                {
                    if(isbn != "" && isbn != null)
                    {
                        ComboBoxes[i].SelectedValue = isbn;
                        try
                        {
                            if (i < 8)
                            {
                                i++;
                                ComboBoxes[i].Visible = true;
                                Buttons[i].Visible = true;
                                tLP_1.SetRow(ctr1, i + 1);
                            }
                        }
                        catch (System.ArgumentOutOfRangeException)
                        {

                        }
                        
                    }
                }
            }
            else
            {
                //LoadBuch();
                this.Hide();
            }
        }

        private int GetColumnIndexByName(DataGridView grid, string name)
        {
            foreach (DataGridViewColumn col in grid.Columns)
            {
                if (col.HeaderText.ToLower().Trim() == name.ToLower().Trim())
                {
                    return grid.Columns.IndexOf(col);
                }
            }

            return -1;
        }

        private void bt_clear_Click(object sender, EventArgs e)
        {
            Clear();
        }
        private void Clear()
        {
            cb_fach.SelectedValue = 0;
            cb_klasse.SelectedIndex = -1;
            ComboBoxes[0].SelectedValue = 0;
            for (int i = 1; i < 8;)
            {
                ComboBoxes[i].Visible = false;
                ComboBoxes[i].SelectedValue = 0;
                Buttons[i].Visible = false;
                i++;
            }
            tLP_1.SetRow(ctr1, 1);
        }

        private void cb_buch1_Click(object sender, EventArgs e)
        {
            
        }

        private void comboboxClicked(object sender, EventArgs e)
        {
            var cb = (ComboBox)sender;
            if (cb.DroppedDown)
            {
                cb.DroppedDown = false;
                string name = cb.Name;
                name = name.Substring(7);
                index = int.Parse(name) - 1;
                w_s_buecher Buch = new w_s_buecher(false);
                Buch.ShowDialog(this);

                ComboBox cmbBx = ComboBoxes[index];
                string cbName = cmbBx.Name;
                Buch_Fach buchfach = new Buch_Fach();
                buchfach.Buch.FillCombobox(ref cmbBx, 0);
                //FillComboboxes(true);
                cmbBx.SelectedValue = Buch.tb_ISBN.Text;
                Buch.Close();
                index = int.Parse(name) - 1;
                if (index < 8 && cmbBx.SelectedValue != null)
                {
                    try
                    {
                        if (!ComboBoxes[index + 1].Visible)
                        {
                            ComboBoxes[index + 1].Visible = true;
                            Buttons[index + 1].Visible = true;
                            tLP_1.SetRow(ctr1, index + 2);
                        }
                    }
                    catch (System.ArgumentOutOfRangeException)
                    {
                    }
                    

                }
            }
            cb.DroppedDown = false;
        }

        private void cb_buch3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cb_buch2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cb_1_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_1.Checked)
            {
                isChecked = true;
            }
            else
            {
                isChecked = false;
            }
        }

        private void bt_close_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
