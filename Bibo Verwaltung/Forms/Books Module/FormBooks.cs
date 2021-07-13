using Bibo_Verwaltung.Helper;
using bpac;
using MetroFramework;
using MetroFramework.Controls;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Media;
using System.Net;
using System.Text.RegularExpressions;
using System.Threading;
using System.Windows.Forms;

namespace Bibo_Verwaltung
{
    public partial class Form_Books : MetroFramework.Forms.MetroForm
    {
        #region variables
        AuthorHelper authorHelper = new AuthorHelper();
        ConditionHelper conditionHelper = new ConditionHelper();
        GenreHelper genreHelper = new GenreHelper();
        LanguageHelper languageHelper = new LanguageHelper();
        PublisherHelper publisherHelper = new PublisherHelper();
        BookHelper bookHelper = new BookHelper();


        WebHelper webHelper = new WebHelper();

        /// <summary>
        /// Contains the three options: add, update and remove
        /// </summary>
        enum SaveOption
        {
            add,
            update,
            delete
        }
        #endregion

        #region Constructor
        bool guest = false;
        public Form_Books(string bookIsbn)
        {
            WebRequest.DefaultWebProxy = null;
            InitializeComponent();
            LoadTheme();
            SetPermissions();
            this.Text = Text + AuthInfo.FormInfo();
            tb_ISBN.Text = bookIsbn;
            FillComboboxes();
            picBox_Gross.Visible = false;
            gb_zoom.Visible = false;
            comboBox1.Visible = false;
            comboBox1.DropDownHeight = 1;
            tb_ISBN.Focus();
        }
        public Form_Books(bool bool1)
        {
            InitializeComponent();
            LoadTheme();
            this.Text = Text + AuthInfo.FormInfo();

            FillComboboxes();
            picBox_Gross.Visible = false;
            gb_zoom.Visible = false;
            comboBox1.Visible = false;
            comboBox1.DropDownHeight = 1;
            this.bool1 = bool1;
            tb_ISBN.Focus();

        }
        #endregion
        private void guestMode(bool activate)
        {
            btSubmit.Enabled = !activate;
            bt_print.Enabled = !activate;
            bt_pic_delete.Enabled = !activate;
            bt_picture.Enabled = !activate;
            bt_Excel.Enabled = !activate;
            entfernenToolStripMenuItem.Enabled = !activate;
            if (rb_search.Checked)
            {
                btSubmit.Enabled = false;
                bt_pic_delete.Enabled = false;
                bt_picture.Enabled = false;
            }
        }
        private void LoadTheme()
        {
            this.StyleManager = styleManagerBooks;
            this.StyleManager.Theme = ThemeInfo.StyleManager.Theme;
            this.StyleManager.Style = ThemeInfo.BookStyle;

            cb_Autor.ForeColor = ThemeInfo.ForeColor;
            cb_Autor.BackColor = ThemeInfo.BackColor;
            cb_Verlag.ForeColor = ThemeInfo.ForeColor;
            cb_Verlag.BackColor = ThemeInfo.BackColor;
            cb_Genre.ForeColor = ThemeInfo.ForeColor;
            cb_Genre.BackColor = ThemeInfo.BackColor;
            cb_Sprache.ForeColor = ThemeInfo.ForeColor;
            cb_Sprache.BackColor = ThemeInfo.BackColor;
            checkedListBox1.ForeColor = ThemeInfo.ForeColor;
            checkedListBox1.BackColor = ThemeInfo.BackColor;
            picBox_Gross.BackColor = ThemeInfo.BackColor;
            picBox_Klein.BackColor = ThemeInfo.BackColor;
        }

        private void SetPermissions()
        {
            if (AuthInfo.CurrentUser.PermissionId == 0)
            {
                guest = true;
                guestMode(guest);
            }
            else if (AuthInfo.CurrentUser.PermissionId == 1)
            {
                guest = false;
                guestMode(guest);
            }
            else if (AuthInfo.CurrentUser.PermissionId == 2)
            {
                guest = false;
                guestMode(guest);
            }
        }
        bool loaded = false;
        bool bool1;

        #region isbn check
        /// <summary>
        /// checks whether a string can be an isbn or not
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        private bool IsIsbn(string s)
        {
            if (Regex.IsMatch(s, "^[-0-9]*$"))
            {
                if (s.Contains("--"))
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }
            else
            {
                return false;
            }
        }
        /// <summary>
        /// converts a string to an isbn string with some chars replaced
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        private string ToIsbn(string s)
        {
            string output = "";
            Regex pattern = new Regex("[^-0-9]");
            output = pattern.Replace(s, "");

            for (int i = 1; i <= s.Length; i++)
            {
                if (s.Contains("--"))
                {
                    output = output.Replace("--", "-");
                }
            }
            return output;
        }
        private void tb_ISBN_inputOk(object sender, EventArgs e)
        {
            if (IsIsbn(tb_ISBN.Text) == false)
            {
                MetroMessageBox.Show(this, "Bitte keine Buchstaben eingeben!", "Achtung",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tb_ISBN.Text = ToIsbn(tb_ISBN.Text);
            }
        }

        #endregion

        #region click event - add new small entity
        private void bt_publisher_add_click(object sender, EventArgs e)
        {
            FormAttribute manage = new FormAttribute("Verlag");
            manage.ShowDialog(this);
            manage.Dispose();
            publisherHelper.FillCombobox(ref cb_Verlag, 0);
        }

        private void bt_author_add_click(object sender, EventArgs e)
        {
            FormAttribute manage = new FormAttribute("Autor");
            manage.ShowDialog(this);
            manage.Dispose();
            authorHelper.FillCombobox(ref cb_Autor, 0);
        }

        private void bt_genre_add_click(object sender, EventArgs e)
        {
            FormAttribute manage = new FormAttribute("Genre");
            manage.ShowDialog(this);
            manage.Dispose();
            genreHelper.FillCombobox(ref cb_Genre, 0);
        }

        private void bt_language_add_click(object sender, EventArgs e)
        {
            FormAttribute manage = new FormAttribute("Sprache");
            manage.ShowDialog(this);
            manage.Dispose();
            languageHelper.FillCombobox(ref cb_Sprache, 0);
        }

        #endregion

        private void Submit_Click(object sender, EventArgs e)
        {
            Submit();
        }

        /// <summary>
        /// submits the update, adds a book or deletes one
        /// </summary>
        private void Submit()
        {
            if (rb_Add_Buch.Checked)
            {
                if (IsInputOkay(SaveOption.add))
                {
                    Add(checkbox_autor.Checked);
                }
                else
                {
                    MetroMessageBox.Show(this, "Füllen Sie die markierten Felder aus, um ein Buch hinzuzufügen!", "Achtung",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else if (rb_Update_Buch.Checked)
            {
                if (IsInputOkay(SaveOption.update))
                {
                    Update(checkbox_autor.Checked);
                }
                else
                {
                    MetroMessageBox.Show(this, "Füllen Sie die markierten Felder aus, um ein Buch zu aktualisieren!", "Achtung",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else if (rb_Delete_Buch.Checked)
            {
                if (IsInputOkay(SaveOption.delete))
                {
                    Delete();
                }
                else
                {
                    MetroMessageBox.Show(this, "Füllen Sie die markierten Felder aus, um ein Buch zu löschen!", "Achtung",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            tb_ISBN.Focus();
        }

        /// <summary>
        /// performs the update of one book object
        /// </summary>
        private void Update(bool multipleAuthors)
        {
            //load existing book from database
            Book book = new Book(tb_ISBN.Text, false);

            FinalizePublisherGenreLanguage(ref book);
            book.BookAuthors.Clear();
            FinalizeAuthor(ref book, multipleAuthors);

            //update book values
            book.BookIsbn = tb_ISBN.Text;
            book.BookTitle = tb_Titel.Text;
            book.BookEdition = tb_Auflage.Text;
            book.BookPrice = isEmpty(tb_Neupreis.Text) ? 0.00M : Convert.ToDecimal(tb_Neupreis.Text);
            book.BookDatePublication = dTP_Erscheinungsdatum.Value;
            if (picBox_Klein.Image == null)
            {
                book.BookImage = null;
            }
            else
            {
                ImageConverter converter = new ImageConverter();
                book.BookImage = picBox_Klein.Image;
            }

            //submit changes
            book.Update();

            //fill grid
            bookHelper.FillGrid(ref gridViewBook, false);

            //show success message
            ShowMessage(SaveOption.update);
        }

        /// <summary>
        /// performs the deletion of one book with all its copies
        /// </summary>
        private void Delete()
        {
            //get selected book object we want to delete
            Book book = new Book(tb_ISBN.Text, false);

            DialogResult dialogResult = MetroMessageBox.Show(this, "Sämtliche zu diesem Buch " +
                "gehörende Exemplare werden auch aus der Datenbank gelöscht. Fortfahren?", "Achtung",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dialogResult == DialogResult.Yes)
            {
                if (book.AreCopiesAvailable())
                {
                    book.Deactivate();
                    ClearForm();
                    bookHelper.FillGrid(ref gridViewBook, false);

                    //show success message
                    ShowMessage(SaveOption.delete);
                }
                else
                {
                    MetroMessageBox.Show(this, "Das Buch konnte nicht gelöscht werden, da eines " +
                        "der dazugehörigen Exemplare zur Zeit verliehen ist. Bitte melden Sie dieses zuerst als " +
                        "'zurückgegeben', bevor Sie das Buch löschen!", "Achtung", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else if (dialogResult == DialogResult.No)
            {
                MetroMessageBox.Show(this, "Der Löschvorgang wurde abgebrochen!", "Achtung", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        /// <summary>
        /// performs the addition of one book
        /// </summary>
        private void Add(bool multipleAuthors)
        {
            Book book = new Book();

            FinalizePublisherGenreLanguage(ref book);
            FinalizeAuthor(ref book, multipleAuthors);
            book.BookIsbn = tb_ISBN.Text;
            book.BookTitle = tb_Titel.Text;
            book.BookEdition = tb_Auflage.Text;
            book.BookPrice = isEmpty(tb_Neupreis.Text) ? 0.00M : Convert.ToDecimal(tb_Neupreis.Text);
            book.BookDatePublication = dTP_Erscheinungsdatum.Value;
            if (picBox_Klein.Image == null)
            {
                book.BookImage = null;
            }
            else
            {
                ImageConverter converter = new ImageConverter();
                book.BookImage = picBox_Klein.Image;
            }
            book.Add();

            AddNewCopies(book);

            //show success message
            ShowMessage(SaveOption.add);
        }

        /// <summary>
        /// adds new copies to a new book if textbox is not empty
        /// </summary>
        /// <param name="book"></param>
        private void AddNewCopies(Book book)
        {
            string newConditionName = "neu";
            if (!isEmpty(tb_neu.Text))
            {
                int newCopyCount = isEmpty(tb_neu.Text) ? 0 : int.Parse(tb_neu.Text);
                Condition newCondition = new Condition();
                int conditionId = conditionHelper.FindIdByName(newConditionName);
                if (conditionId < 0)
                {
                    newCondition.ConditionName = newConditionName;
                    newCondition.Add();
                    conditionId = conditionHelper.FindIdByName(newConditionName);
                }
                newCondition = new Condition(conditionId);

                Copy copy = new Copy();
                copy.CopyIsbn = book.BookIsbn;
                copy.CopyTitle = book.BookTitle;
                copy.DateRegistration = DateTime.UtcNow.Date;
                copy.Condition = newCondition;

                for (int i = 0; i < newCopyCount; i++)
                {
                    copy.Add();
                }

                ClearForm();
            }
            else
            {
                Form_Copy formCopy = new Form_Copy(book.BookIsbn);
                formCopy.ShowDialog(this);

                formCopy.Dispose();
            }
            bookHelper.FillGrid(ref gridViewBook, false);
        }

        /// <summary>
        /// shows a message to tell the user that the action was successful
        /// </summary>
        /// <param name="opt"></param>
        private void ShowMessage(SaveOption opt)
        {
            mtb_Nachricht.Text = "";
            var t = new System.Windows.Forms.Timer();
            t.Interval = 3000; // it will Tick in 3 seconds
            t.Tick += (s, a) =>
            {
                mtb_Nachricht.Hide();
                t.Stop();
            };
            string message = "";
            switch (opt)
            {
                case SaveOption.add:
                    message = "Das Buch wurde erfolgreich hinzugefügt.";
                    break;
                case SaveOption.update:
                    message = "Das Buch wurde erfolgreich aktualisiert.";
                    break;
                case SaveOption.delete:
                    message = "Das Buch mit seinen Exemplaren wurde erfolgreich gelöscht.";
                    break;
            }
            mtb_Nachricht.Text = message;
            mtb_Nachricht.Visible = true;
            t.Start();
        }

        /// <summary>
        /// checks whether comboboxes of publisher, genre and language display new or existing entities, adds them to database in case they are new and adds them to a book object
        /// </summary>
        /// <param name="book"></param>
        private void FinalizePublisherGenreLanguage(ref Book book)
        {
            Publisher publisher = new Publisher();
            if (!publisherHelper.AlreadyContains(cb_Verlag.Text))
            {
                publisher.PublisherName = cb_Verlag.Text;
                publisher.Add();
            }
            publisher = new Publisher(publisherHelper.FindIdByName(cb_Verlag.Text));
            publisherHelper.FillCombobox(ref cb_Verlag, publisher.PublisherId);
            book.BookPublisher = publisher;

            Genre genre = new Genre();
            if (!genreHelper.AlreadyContains(cb_Genre.Text))
            {
                genre.GenreName = cb_Genre.Text;
                genre.Add();
            }
            genre = new Genre(genreHelper.FindIdByName(cb_Genre.Text));
            genreHelper.FillCombobox(ref cb_Genre, genre.GenreId);
            book.BookGenre = genre;

            Language language = new Language();
            if (!languageHelper.AlreadyContains(cb_Sprache.Text))
            {
                language.LanguageName = cb_Sprache.Text;
                language.Add();
            }
            language = new Language(languageHelper.FindIdByName(cb_Sprache.Text));
            languageHelper.FillCombobox(ref cb_Sprache, language.LanguageId);
            book.BookLanguage = language;
        }

        /// <summary>
        /// sets the values for author
        /// </summary>
        /// <param name="book"></param>
        /// <param name="multipleAuthors"></param>
        private void FinalizeAuthor(ref Book book, bool multipleAuthors)
        {
            if (multipleAuthors)
            {
                //multiple authors
                foreach (DataRowView item in checkedListBox1.CheckedItems)
                {
                    string name = item["au_autor"].ToString();
                    Author author = new Author(authorHelper.FindIdByName(name));
                    book.BookAuthors.Add(author);
                }
            }
            else
            {
                //one author
                Author author = new Author();
                int authorId = authorHelper.FindIdByName(cb_Autor.Text);
                if (authorId < 0)
                {
                    author.AuthorName = cb_Autor.Text;
                    author.Add();
                }
                author = new Author(authorId);
                book.BookAuthors.Add(author);
                authorHelper.FillCombobox(ref cb_Autor, author.AuthorId);
            }
        }

        /// <summary>
        /// returns true if an input string is empty
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        private bool isEmpty(string s)
        {
            return s.Equals("");
        }

        /// <summary>
        /// returns true if all necessary input fields are filled with values
        /// </summary>
        /// <param name="opt"></param>
        /// <returns></returns>
        private bool IsInputOkay(SaveOption opt)
        {
            bool inputOkay = false;
            switch (opt)
            {
                case SaveOption.add:
                    if (!isEmpty(tb_ISBN.Text) && !isEmpty(tb_Titel.Text)
                        && !isEmpty(cb_Autor.Text) && !isEmpty(cb_Verlag.Text) && !isEmpty(cb_Genre.Text) && !isEmpty(cb_Sprache.Text))
                    {
                        inputOkay = true;
                    }
                    break;
                case SaveOption.update:
                    if (!isEmpty(tb_ISBN.Text) && !isEmpty(tb_Titel.Text)
                        && !isEmpty(cb_Autor.Text) && !isEmpty(cb_Verlag.Text) && !isEmpty(cb_Genre.Text) && !isEmpty(cb_Sprache.Text))
                    {
                        inputOkay = true;
                    }
                    break;
                case SaveOption.delete:
                    if (!isEmpty(tb_ISBN.Text))
                    {
                        inputOkay = true;
                    }
                    break;
            }
            return inputOkay;
        }
        private void bt_clear_click(object sender, EventArgs e)
        {
            ClearForm();
            rb_Add_Buch.Checked = true;
            tb_ISBN.Focus();
        }

        /// <summary>
        /// resets the formular to initial values (blank)
        /// </summary>
        private void ClearForm()
        {
            dTP_Erscheinungsdatum.ResetText();
            tb_barcodePrinted.Text = "";
            tb_barcodeAdd.Text = "";
            tb_neu.Text = "";
            checkbox_autor.Checked = false;
            tb_ISBN.Text = "";
            tb_Titel.Text = "";
            cb_Autor.Text = "";
            cb_Verlag.Text = "";
            cb_Genre.Text = "";
            cb_Sprache.Text = "";
            tb_Auflage.Text = "";
            tb_Neupreis.Text = "";
            picBox_Gross.Image = null;
            picBox_Gross.ImageLocation = null;
            picBox_Gross.Refresh();
            picBox_Klein.Image = null;
            picBox_Klein.ImageLocation = null;
            picBox_Klein.Refresh();
            tb_ISBN.BackColor = ThemeInfo.BackColor;
            tb_Titel.BackColor = ThemeInfo.BackColor;
            cb_Autor.BackColor = ThemeInfo.BackColor;
            cb_Verlag.BackColor = ThemeInfo.BackColor;
            cb_Genre.BackColor = ThemeInfo.BackColor;
            cb_Sprache.BackColor = ThemeInfo.BackColor;
            tb_Auflage.BackColor = ThemeInfo.BackColor;
            tb_Neupreis.BackColor = ThemeInfo.BackColor;
        }










        /// <summary>
        /// Sucht nach Büchern in einer GridView
        /// </summary>
        private void BuchFilter()
        {
            if (gridViewBook.DataSource == null) return;
            if (dTP_Erscheinungsdatum.Value.Date != DateTime.Now.Date)
            {
                (gridViewBook.DataSource as DataTable).DefaultView.RowFilter = string.Format("Titel LIKE '%{0}%' and ISBN LIKE '%{1}%' AND Autor LIKE '%{2}%' AND Verlag LIKE '%{3}%' AND Genre LIKE '%{4}%' AND Sprache LIKE '%{5}%' AND Convert([Erscheinungsdatum], System.String) LIKE '%{6}%'", tb_Titel.Text, tb_ISBN.Text, cb_Autor.Text, cb_Verlag.Text, cb_Genre.Text, cb_Sprache.Text, dTP_Erscheinungsdatum.Value.Date.ToShortDateString());

            }
            else
            {
                (gridViewBook.DataSource as DataTable).DefaultView.RowFilter = string.Format("Titel LIKE '%{0}%' and ISBN LIKE '%{1}%' AND Autor LIKE '%{2}%' AND Verlag LIKE '%{3}%' AND Genre LIKE '%{4}%' AND Sprache LIKE '%{5}%'", tb_Titel.Text, tb_ISBN.Text, cb_Autor.Text, cb_Verlag.Text, cb_Genre.Text, cb_Sprache.Text);
            }

        }

        #region text changed events
        private void tb_ISBN_TextChanged(object sender, EventArgs e)
        {
            tb_ISBN.Text = tb_ISBN.Text.Replace(" ", "");
            BuchFilter();
            tb_ISBN.BackColor = ThemeInfo.BackColor;
        }

        private void tb_Titel_TextChanged(object sender, EventArgs e)
        {
            BuchFilter();
            tb_Titel.BackColor = ThemeInfo.BackColor;
            tb_Titel.UseCustomBackColor = false;
        }
        private void tb_Neupreis_TextChanged(object sender, EventArgs e)
        {
            tb_Neupreis.BackColor = ThemeInfo.BackColor;
        }

        private void tb_Auflage_TextChanged(object sender, EventArgs e)
        {
            tb_Auflage.BackColor = ThemeInfo.BackColor;
        }

        private void cb_Sprache_TextChanged(object sender, EventArgs e)
        {
            BuchFilter();
            cb_Sprache.BackColor = ThemeInfo.BackColor;
        }

        private void cb_Genre_TextChanged(object sender, EventArgs e)
        {
            BuchFilter();
            cb_Genre.BackColor = ThemeInfo.BackColor;
        }

        private void cb_Verlag_TextChanged(object sender, EventArgs e)
        {
            BuchFilter();
            cb_Verlag.BackColor = ThemeInfo.BackColor;
        }

        private void cb_Autor_TextChanged(object sender, EventArgs e)
        {
            BuchFilter();
            cb_Autor.BackColor = ThemeInfo.BackColor;
            if (checkbox_autor.Checked && checkedListBox1.Visible)
            {
                int index = checkedListBox1.FindString(cb_Autor.Text);
                if (index >= 0)
                {
                    checkedListBox1.SelectedIndex = index;
                }
            }
        }
        #endregion

        /// <summary>
        /// change the current mode (search, add, edit, delete)
        /// </summary>
        private void ChangeMode()
        {
            if (rb_Add_Buch.Checked)
            {
                bt_print.Enabled = false;
                tb_barcodeAdd.Enabled = false;
                tb_neu.Enabled = true;
                tb_ISBN.Enabled = true;
                tb_Titel.Enabled = true;
                cb_Autor.TabStop = true;
                cb_Verlag.TabStop = true;
                cb_Sprache.TabStop = true;
                cb_Genre.TabStop = true;
                p_autor.Visible = false;
                p_verlag.Visible = false;
                p_sprache.Visible = false;
                p_genre.Visible = false;
                tb_Auflage.Enabled = true;
                tb_Neupreis.Enabled = true;
                dTP_Erscheinungsdatum.Enabled = true;
                btSubmit.Enabled = true;
                btSubmit.Text = "Hinzufügen";
                bt_picture.Enabled = true;
                bt_pic_delete.Enabled = true;
                picBox_Klein.Enabled = true;
                mtb_Nachricht.Text = "Das Buch wurde erfolgreich hinzugefügt!";
                lb_ISBN.Text = "ISBN:*";
                lb_Titel.Text = "Titel:*";
                lb_Autor.Text = "Autor:*";
                lb_Verlag.Text = "Verlag:*";
                lb_Genre.Text = "Genre:*";
                lb_Sprache.Text = "Sprache:*";
                lb_Erscheinungsdatum.Text = "Erscheinungsdatum:*";
                checkbox_autor.Enabled = true;
                button1.Enabled = true;
            }
            if (rb_Update_Buch.Checked)
            {
                bt_print.Enabled = true;
                tb_barcodeAdd.Enabled = true;
                tb_neu.Enabled = false;
                tb_ISBN.Enabled = false;
                tb_Titel.Enabled = true;
                cb_Autor.TabStop = !checkbox_autor.Checked;
                cb_Verlag.TabStop = true;
                cb_Sprache.TabStop = true;
                cb_Genre.TabStop = true;
                readOnly = true;
                p_autor.Visible = false;
                p_verlag.Visible = false;
                p_sprache.Visible = false;
                p_genre.Visible = false;
                tb_Auflage.Enabled = true;
                tb_Neupreis.Enabled = true;
                dTP_Erscheinungsdatum.Enabled = true;
                btSubmit.Enabled = true;
                btSubmit.Text = "Speichern";
                bt_picture.Enabled = true;
                bt_pic_delete.Enabled = true;
                picBox_Klein.Enabled = true;
                mtb_Nachricht.Text = "Das Buch wurde erfolgreich bearbeitet!";
                lb_ISBN.Text = "ISBN:";
                lb_Titel.Text = "Titel:*";
                lb_Autor.Text = "Autor:*";
                lb_Verlag.Text = "Verlag:*";
                lb_Genre.Text = "Genre:*";
                lb_Sprache.Text = "Sprache:*";
                lb_Erscheinungsdatum.Text = "Erscheinungsdatum:*";
                checkbox_autor.Enabled = true;
                button1.Enabled = true;

            }
            if (rb_Delete_Buch.Checked)
            {
                bt_print.Enabled = false;
                tb_barcodeAdd.Enabled = false;
                tb_neu.Enabled = false;
                tb_ISBN.Enabled = true;
                tb_Titel.Enabled = false;
                cb_Autor.TabStop = false;
                cb_Verlag.TabStop = false;
                cb_Sprache.TabStop = false;
                cb_Genre.TabStop = false;
                p_autor.Visible = true;
                p_verlag.Visible = true;
                p_sprache.Visible = true;
                p_genre.Visible = true;
                tb_Auflage.Enabled = false;
                tb_Neupreis.Enabled = false;
                dTP_Erscheinungsdatum.Enabled = false;
                btSubmit.Enabled = true;
                btSubmit.Text = "Löschen";
                bt_picture.Enabled = false;
                bt_pic_delete.Enabled = false;
                picBox_Klein.Enabled = false;
                mtb_Nachricht.Text = "Das Buch wurde erfolgreich gelöscht!";
                lb_ISBN.Text = "ISBN:*";
                lb_Titel.Text = "Titel:";
                lb_Autor.Text = "Autor:";
                lb_Verlag.Text = "Verlag:";
                lb_Genre.Text = "Genre:";
                lb_Sprache.Text = "Sprache:";
                lb_Erscheinungsdatum.Text = "Erscheinungsdatum:";
                checkbox_autor.Enabled = false;
                button1.Enabled = false;
            }
            if (rb_search.Checked)
            {
                btSubmit.Enabled = false;
                bt_pic_delete.Enabled = false;
                bt_picture.Enabled = false;
                bt_print.Enabled = true;
                tb_barcodeAdd.Enabled = true;
                tb_neu.Enabled = false;
                tb_ISBN.Enabled = true;
                tb_Titel.Enabled = true;
                cb_Autor.TabStop = true;
                cb_Verlag.TabStop = true;
                cb_Sprache.TabStop = true;
                cb_Genre.TabStop = true;
                p_autor.Visible = false;
                p_verlag.Visible = false;
                p_sprache.Visible = false;
                p_genre.Visible = false;
                tb_Auflage.Enabled = true;
                tb_Neupreis.Enabled = true;
                dTP_Erscheinungsdatum.Enabled = true;
                btSubmit.Text = "---";
                picBox_Klein.Enabled = true;
                mtb_Nachricht.Text = "Das Buch wurde erfolgreich hinzugefügt!";
                lb_ISBN.Text = "ISBN:";
                lb_Titel.Text = "Titel:";
                lb_Autor.Text = "Autor:";
                lb_Verlag.Text = "Verlag:";
                lb_Genre.Text = "Genre:";
                lb_Sprache.Text = "Sprache:";
                lb_Erscheinungsdatum.Text = "Erscheinungsdatum:";
                checkbox_autor.Enabled = false;
                button1.Enabled = true;
            }
            guestMode(guest);

        }

        /// <summary>
        /// reset background of controls
        /// </summary>
        private void ResetControlBackground()
        {
            tb_ISBN.BackColor = ThemeInfo.BackColor;
            tb_Titel.BackColor = ThemeInfo.BackColor;
            cb_Autor.BackColor = ThemeInfo.BackColor;
            cb_Verlag.BackColor = ThemeInfo.BackColor;
            cb_Genre.BackColor = ThemeInfo.BackColor;
            cb_Sprache.BackColor = ThemeInfo.BackColor;
            tb_Auflage.BackColor = ThemeInfo.BackColor;
            tb_Neupreis.BackColor = ThemeInfo.BackColor;
            dTP_Erscheinungsdatum.BackColor = ThemeInfo.BackColor;
        }

        /// <summary>
        /// checked changed event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void rb_checked_changed(object sender, EventArgs e)
        {
            ChangeMode();
            ResetControlBackground();
            tb_ISBN.Focus();
        }

        private void w_s_buecher_Activated(object sender, EventArgs e)
        {
            ChangeMode();
            if (!backgroundWorker1.IsBusy)
            {
                backgroundWorker1.RunWorkerAsync();
            }
        }

        /// <summary>
        /// load all the information of a book
        /// </summary>
        private void LoadBuch(Book book)
        {
            tb_Titel.Text = book.BookTitle;

            string autortext = "";
            if (book.BookAuthors.Count > 1)
            {
                checkbox_autor.Checked = true;
                foreach (DataRowView item in checkedListBox1.Items)
                {
                    var s = item["au_autor"];
                    Author author = new Author(authorHelper.FindIdByName(item["au_autor"].ToString()));
                    if (book.BookAuthors.Contains(author))
                    {
                        checkedListBox1.SetItemChecked(checkedListBox1.Items.IndexOf(item), true);
                    }
                }
            }
            else
            {
                checkbox_autor.Checked = false;
            }
            foreach (Author author in book.BookAuthors)
            {
                autortext = autortext + author.AuthorName + ", ";
            }
            autortext = autortext.Substring(0, autortext.Length - 2);
            cb_Autor.Text = autortext;

            cb_Verlag.Text = book.BookPublisher.PublisherName;
            cb_Sprache.Text = book.BookLanguage.LanguageName;
            cb_Genre.Text = book.BookGenre.GenreName;

            tb_Auflage.Text = book.BookEdition;
            tb_Neupreis.Text = book.BookPrice.ToString();
            dTP_Erscheinungsdatum.Value = book.BookDatePublication;
            if (book.BookImage != null)
            {
                picBox_Klein.Image = book.BookImage;
            }
            else
            {
                picBox_Klein.Image = null;
                picBox_Klein.ImageLocation = null;
            }
            publisherHelper.FillCombobox(ref cb_Verlag, book.BookPublisher.PublisherId);
            genreHelper.FillCombobox(ref cb_Genre, book.BookGenre.GenreId);
            languageHelper.FillCombobox(ref cb_Sprache, book.BookLanguage.LanguageId);
            tb_barcodePrinted.Text = book.NumberOfPrintedCopies().ToString();
            rb_Add_Buch.Checked = true;
        }

        /// <summary>
        /// gridview double click --> load a book
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void gridViewBookClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = gridViewBook.Rows[e.RowIndex];
                tb_ISBN.Text = row.Cells[0].Value.ToString();
                LoadBuch(new Book(tb_ISBN.Text, false));
                if (!bool1) Hide();
            }
        }

        private void IsOK()
        {
            if (tb_ISBN.Text.Equals(""))
            {
                tb_ISBN.UseCustomBackColor = true;
                tb_ISBN.BackColor = Color.Red;
            }
            else
            {
                tb_ISBN.UseCustomBackColor = false;
                tb_ISBN.BackColor = ThemeInfo.BackColor;
            }
            if (tb_Titel.Text.Equals(""))
            {
                tb_Titel.UseCustomBackColor = true;
                tb_Titel.BackColor = Color.Red;
            }
            else
            {
                tb_Titel.UseCustomBackColor = false;
                tb_Titel.BackColor = ThemeInfo.BackColor;
            }

            if (cb_Autor.Text.Equals(""))
            {
                cb_Autor.BackColor = Color.Red;
            }
            else
            {
                cb_Autor.BackColor = ThemeInfo.BackColor;
            }

            if (cb_Verlag.Text.Equals(""))
            {
                cb_Verlag.BackColor = Color.Red;
            }
            else
            {
                cb_Verlag.BackColor = ThemeInfo.BackColor;
            }

            if (cb_Genre.Text.Equals(""))
            {
                cb_Genre.BackColor = Color.Red;
            }
            else
            {
                cb_Genre.BackColor = ThemeInfo.BackColor;
            }

            if (cb_Sprache.Text.Equals(""))
            {
                cb_Sprache.BackColor = Color.Red;
            }
            else
            {
                cb_Sprache.BackColor = ThemeInfo.BackColor;
            }
            if (dTP_Erscheinungsdatum.Text.Equals(""))
            {
                dTP_Erscheinungsdatum.UseCustomBackColor = true;
                dTP_Erscheinungsdatum.BackColor = Color.Red;
            }
            else
            {
                dTP_Erscheinungsdatum.UseCustomBackColor = false;
                dTP_Erscheinungsdatum.BackColor = Color.White;
            }
        }

        /// <summary>
        /// fills all comboboxes and listboxes
        /// </summary>
        private void FillComboboxes()
        {
            authorHelper.FillList(ref checkedListBox1);
            authorHelper.FillCombobox(ref cb_Autor, 0);
            publisherHelper.FillCombobox(ref cb_Verlag, 0);
            genreHelper.FillCombobox(ref cb_Genre, 0);
            languageHelper.FillCombobox(ref cb_Sprache, 0);
        }

        private void bt_picture_Click(object sender, EventArgs e)
        {
            string imgLocation = "";
            DialogResult dialogResult = MetroMessageBox.Show(this, "Soll das Bild anhand der ISBN automatisch geladen werden?",
                "Automatisch Laden?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                picBox_Klein.Image = webHelper.GetPictureNeu(tb_ISBN.Text);
            }
            else if (dialogResult == DialogResult.No)
            {
                OpenFileDialog dialog = new OpenFileDialog();
                dialog.Filter = "Bilddateien(*.png, *.jpg, *.bmp, *.gif)|*.png; *.jpg; *.bmp; *.gif|Alle Dateien(*.*)|*.*";
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    imgLocation = dialog.FileName.ToString();
                    picBox_Klein.ImageLocation = imgLocation;
                }
            }
        }

        private void bt_pic_add_Click(object sender, EventArgs e)
        {
            picBox_Klein.Image = null;
            picBox_Gross.Image = null;
        }

        private void bt_Excel_Click(object sender, EventArgs e)
        {
            ExcelExport export = new ExcelExport();
            try
            {
                export.ExportDataGridViewAsCSV(gridViewBook);
                MetroMessageBox.Show(this, "Export erfolgreich abgeschlossen", "Datenbank Export", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch
            {
                MetroMessageBox.Show(this, "Beim Exportvorgang ist ein Fehler aufgetreten!", "Datenbank Export", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void tb_ISBN_Click(object sender, EventArgs e)
        {
            checkedListBox1.Visible = false;
        }

        private void lb_isbn_vorlage_Click(object sender, EventArgs e)
        {
            tb_ISBN.Focus();
        }



        private void pictureBox1_MouseEnter(object sender, EventArgs e)
        {
            ZoomInOut(true);
        }

        private void ZoomInOut(bool zoom)
        {
            if (picBox_Klein.Image != null)
            {
                picBox_Gross.Image = picBox_Klein.Image;
                if (!zoom)
                {
                    picBox_Gross.Visible = false;
                    gb_zoom.Visible = false;
                }
                else
                {
                    picBox_Gross.Visible = true;
                    gb_zoom.Visible = true;
                }
            }
        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            ZoomInOut(false);
        }

        /// <summary>
        /// click on button to load book data from internet
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bt_load_click(object sender, EventArgs e)
        {
            tb_ISBN.Text = tb_ISBN.Text.Replace("-", "");
            if (gridViewBook.Rows.Count == 0)
            {
                //load data
                if (!isEmpty(tb_ISBN.Text))
                {
                    Book book = webHelper.AutoLoadDNB(tb_ISBN.Text);
                    if (book == null)
                    {
                        MetroMessageBox.Show(this, "Das Buch konnte nicht geladen werden!", "Fehler beim Laden", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        LoadBuch(book);
                    }
                }

            }
            else
            {
                DialogResult dr = MetroMessageBox.Show(this, "Möchten Sie die Daten neu aus dem Internet laden?",
                    "Neu herunterladen?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    //load new data from web source
                    Book book = webHelper.AutoLoadDNB(tb_ISBN.Text);
                    if (book == null)
                    {
                        MetroMessageBox.Show(this, "Das Buch konnte nicht geladen werden!", "Fehler beim Laden", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        LoadBuch(book);
                    }
                }
                else
                {
                    //use data stored in database
                    LoadBuch(new Book(tb_ISBN.Text, false));
                }

            }

            //AutoLoadBuecherNachISBN();
        }

        private void tb_ISBN_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && !rb_Delete_Buch.Checked)
            {
                tb_ISBN.Text = tb_ISBN.Text.Replace("-", "");
                if (gridViewBook.Rows.Count == 0)
                {
                    Book book = webHelper.AutoLoadDNB(tb_ISBN.Text);
                    if (book == null)
                    {
                        MetroMessageBox.Show(this, "Das Buch konnte nicht geladen werden!", "Fehler beim Laden", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        LoadBuch(book);
                    }
                }
                else if (gridViewBook.Rows.Count == 1)
                {
                    Book book = new Book(tb_ISBN.Text, false);
                    LoadBuch(book);
                }
            }
        }

        private void checkbox_autor_CheckedChanged(object sender, EventArgs e)
        {
            if (checkbox_autor.Checked)
            {
                cb_Autor.AutoCompleteMode = AutoCompleteMode.None;
                comboBox1.Visible = true;
                checkedListBox1.BringToFront();
                comboBox1.BackColor = ThemeInfo.BackColor;
                comboBox1.ForeColor = ThemeInfo.ForeColor;
                cb_Autor.DataSource = null;
                cb_Autor.TabStop = false;
                readOnly = true;
            }
            else
            {
                cb_Autor.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                comboBox1.Visible = false;
                checkedListBox1.Visible = false;
                authorHelper.FillCombobox(ref cb_Autor, 0);
                readOnly = false;
                cb_Autor.TabStop = true;
            }
        }

        /// <summary>
        /// is triggered at ItemCheck event of authors CheckedListBox
        /// sets the text of the author ComboBox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void checkedListBox1_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            List<string> checkedItems = new List<string>();
            foreach (DataRowView item in checkedListBox1.CheckedItems)
                checkedItems.Add(item["au_autor"].ToString());
            if (e.NewValue == CheckState.Checked)
                checkedItems.Add((checkedListBox1.Items[e.Index] as DataRowView)["au_autor"].ToString());
            else
                checkedItems.Remove((checkedListBox1.Items[e.Index] as DataRowView)["au_autor"].ToString());
            string comboboxText = "";
            foreach (string s in checkedItems)
            {
                comboboxText = comboboxText + s + ", ";
            }
            comboboxText = comboboxText.TrimEnd(' ', ',');
            cb_Autor.Text = comboboxText;
        }

        private void gb_buch_Enter(object sender, EventArgs e)
        {
            checkedListBox1.Visible = false;
        }


        private void comboBox1_Click(object sender, EventArgs e)
        {
            if (checkbox_autor.Checked)
            {
                //cb_Autor.Enabled = false;
                cb_Autor.TabStop = false;
                readOnly = true;
                comboBox1.DroppedDown = false;
                if (checkedListBox1.Visible == false)
                {
                    checkedListBox1.Visible = true;
                }
                else
                {
                    checkedListBox1.Visible = false;
                }
            }
        }

        private void tb_Titel_Click(object sender, EventArgs e)
        {
            checkedListBox1.Visible = false;
        }

        private void w_s_buecher_Click(object sender, EventArgs e)
        {
            checkedListBox1.Visible = false;
        }

        private void tb_Neupreis_KeyPress(object sender, KeyPressEventArgs e)
        {
            char a = Convert.ToChar(Thread.CurrentThread.CurrentCulture.NumberFormat.NumberDecimalSeparator);
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != a))
            {
                SystemSounds.Beep.Play();
                e.Handled = true;
            }
            if ((e.KeyChar == a) && ((sender as MetroFramework.Controls.MetroTextBox).Text.IndexOf(a) > -1))
            {
                e.Handled = true;
            }
        }

        private void tb_Neupreis_Leave(object sender, EventArgs e)
        {
            if (tb_Neupreis.Text.Contains(","))
            {
                if (tb_Neupreis.Text.Substring(tb_Neupreis.Text.IndexOf(",") + 1).Length == 1)
                {
                    tb_Neupreis.Text = tb_Neupreis.Text + "0";
                }
                else if (tb_Neupreis.Text.Substring(tb_Neupreis.Text.IndexOf(",") + 1).Length == 0)
                {
                    tb_Neupreis.Text = tb_Neupreis.Text + "00";
                    if (tb_Neupreis.Text.Substring(0, tb_Neupreis.Text.IndexOf(",")).Length == 0)
                    {
                        tb_Neupreis.Text = 0 + tb_Neupreis.Text;
                    }
                }
                else if (tb_Neupreis.Text.Substring(tb_Neupreis.Text.IndexOf(",") + 1).Length > 2)
                {
                    tb_Neupreis.Text = tb_Neupreis.Text.Substring(0, tb_Neupreis.Text.IndexOf(",") + 3);
                }
            }
            else if (tb_Neupreis.Text.Equals(""))
            {
                tb_Neupreis.Text = "";
            }
            else
            {
                tb_Neupreis.Text = tb_Neupreis.Text + ",00";
            }
        }

        private void tb_ISBN_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '-'))
            {
                SystemSounds.Beep.Play();
                e.Handled = true;
            }
        }

        private void Grid_Buch_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.ColumnIndex != -1 && e.RowIndex != -1 && e.Button == System.Windows.Forms.MouseButtons.Right)
            {
                if (!gridViewBook.Rows[e.RowIndex].Selected)
                {
                    gridViewBook.ClearSelection();
                    gridViewBook.Rows[e.RowIndex].Selected = true;
                }
                if (gridViewBook.SelectedRows.Count > 1)
                {
                    ladenToolStripMenuItem.Text = "Ausgewähltes Buch laden";
                    ladenToolStripMenuItem.Enabled = false;
                    entfernenToolStripMenuItem.Text = "Ausgewählte Bücher mit ihren Exemplaren entfernen (" + gridViewBook.SelectedRows.Count + ")";
                    entfernenToolStripMenuItem.Enabled = true;
                    exemplareToolStripMenuItem.Text = "Alle Exemplare zu diesem Buch anzeigen";
                    exemplareToolStripMenuItem.Enabled = false;
                }
                else
                {
                    ladenToolStripMenuItem.Text = "Ausgewähltes Buch laden";
                    ladenToolStripMenuItem.Enabled = true;
                    entfernenToolStripMenuItem.Text = "Ausgewähltes Buch mit seinen Exemplaren entfernen";
                    entfernenToolStripMenuItem.Enabled = true;
                    exemplareToolStripMenuItem.Text = "Alle Exemplare zu diesem Buch anzeigen";
                    exemplareToolStripMenuItem.Enabled = true;
                }
            }
            guestMode(guest);
        }

        private void ladenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tb_ISBN.Text = gridViewBook.SelectedRows[0].Cells["ISBN"].Value.ToString();
            Book book = new Book(tb_ISBN.Text, false);
            if (bool1)
            {
                LoadBuch(book);
            }
            else
            {
                LoadBuch(book);
            }
        }

        private void entfernenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tb_ISBN.Text = gridViewBook.SelectedRows[0].Cells["ISBN"].Value.ToString();
            Book book = new Book(tb_ISBN.Text, false);
            if (book.AreCopiesAvailable())
            {
                book.Deactivate();
                ClearForm();
                bookHelper.FillGrid(ref gridViewBook, false);
            }
            else
            {
                MetroMessageBox.Show(this, "Das Buch konnte nicht gelöscht werden, da eines der dazugehörigen " +
                    "Exemplare zur Zeit verliehen ist. Bitte melden Sie dieses zuerst als 'zurückgegeben', bevor Sie das Buch löschen!",
                    "Achtung", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void exemplareToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string isbnAktuell = gridViewBook.SelectedRows[0].Cells["ISBN"].Value.ToString();
            tb_ISBN.Text = isbnAktuell;
            Form_Copy formCopy = new Form_Copy(isbnAktuell);
            formCopy.ShowDialog(this);

            formCopy.Dispose();
            //b.FillGrid_Buch(ref Grid_Buch);
            if (!backgroundWorker1.IsBusy)
            {
                backgroundWorker1.RunWorkerAsync();
            }
            ClearForm();
        }

        private void Grid_Buch_MouseDown(object sender, MouseEventArgs e)
        {
            if (!(gridViewBook.HitTest(e.X, e.Y).RowIndex >= 0) || !(gridViewBook.HitTest(e.X, e.Y).ColumnIndex >= 0))
            {
                gridViewBook.ClearSelection();
                ladenToolStripMenuItem.Visible = false;
                entfernenToolStripMenuItem.Visible = false;
                exemplareToolStripMenuItem.Visible = false;
            }
            else
            {
                ladenToolStripMenuItem.Visible = true;
                entfernenToolStripMenuItem.Visible = true;
                exemplareToolStripMenuItem.Visible = true;
            }
        }

        private void bt_Schliessen_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tb_ISBN_Leave(object sender, EventArgs e)
        {
            tb_ISBN.Text = tb_ISBN.Text.Replace(" ", "");
        }

        private void PrintBarcodes(List<string> barcodeList)
        {
            try
            {
                IPrinter printer = new Printer();
                object[] x = printer.GetInstalledPrinters();
                string name = x[0].ToString();
                bool test = printer.IsPrinterOnline(name);
                if (test)
                {
                    string path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
                    string strFilePath = path + "\\greenLib\\Einstellungen\\BarcodePreset.lbx";
                    IDocument doc = new Document();
                    doc.Open(strFilePath);
                    int barcodeIndex = doc.GetBarcodeIndex("Barcode");
                    IObjects ob = doc.Objects;
                    int anzahlObs = ob.Count;
                    int textInd = doc.GetTextIndex("Titel");
                    int textIndex = barcodeIndex + 1;
                    doc.SetPrinter(printer.Name, true);
                    doc.StartPrint("", PrintOptionConstants.bpoDefault);
                    foreach (string barcodeData in barcodeList)
                    {
                        Copy copy = new Copy(int.Parse(barcodeData.TrimStart('0')));
                        doc.SetBarcodeData(barcodeIndex, barcodeData);
                        doc.Objects[textIndex].Text = copy.CopyTitle;
                        doc.PrintOut(1, PrintOptionConstants.bpoDefault);
                        copy.Print();
                    }
                    doc.EndPrint();
                    doc.Close();
                    MetroMessageBox.Show(this, String.Format("Es wurden erfolgreich '{0}' Barcodes gedruckt.", barcodeList.Count), "Drucken erfolgreich!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MetroMessageBox.Show(this, "Es gab einen Fehler bei der Kommunikation mit dem Drucker!", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch
            {
                MetroMessageBox.Show(this, "Es gab einen Fehler bei der Kommunikation mit dem Drucker!", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void bt_print_Click(object sender, EventArgs e)
        {
            if (!tb_barcodeAdd.Text.Equals("") && !tb_ISBN.Text.Equals(""))
            {
                List<Copy> unprintedCopies = new List<Copy>();
                List<string> newPrintedID = new List<string>();
                Book book = new Book(tb_ISBN.Text, false);

                unprintedCopies = book.UnprintedCopies();

                int printNumber = int.Parse(tb_barcodeAdd.Text);
                if (printNumber > unprintedCopies.Count)
                {
                    printNumber = unprintedCopies.Count;
                    tb_barcodeAdd.Text = printNumber.ToString();
                }
                if (unprintedCopies.Count > 0)
                {
                    for (int i = 0; i < printNumber; i++)
                    {
                        string code = "";
                        code = unprintedCopies[i].CopyId.ToString();
                        for (int codeInt = code.Length; codeInt < 7; codeInt++)
                        {
                            code = "0" + code;
                        }
                        newPrintedID.Add(code);
                    }
                    PrintBarcodes(newPrintedID);
                    //b.FillGrid_Buch(ref Grid_Buch);
                    if (!backgroundWorker1.IsBusy)
                    {
                        backgroundWorker1.RunWorkerAsync();
                    }
                    ClearForm();
                }
            }
        }

        private void tb_neu_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                SystemSounds.Beep.Play();
                e.Handled = true;
            }
        }

        private void tb_barcodeAdd_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                SystemSounds.Beep.Play();
                e.Handled = true;
            }
        }

        private void BackgroundWorker1_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            try
            {
                BeginInvoke((Action)delegate ()
                {
                    metroProgressSpinner1.Visible = true;
                    gridViewBook.Visible = false;
                    metroProgressSpinner1.BringToFront();
                });
                MetroGrid mgBuch = new MetroGrid();
                bookHelper.FillGrid(ref mgBuch, false);
                var dtBuch = mgBuch.DataSource;
                while (loaded == false)
                {

                }
                BeginInvoke((Action)delegate ()
                {
                    gridViewBook.DataSource = null;
                    gridViewBook.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;
                    gridViewBook.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
                    gridViewBook.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
                    gridViewBook.AllowUserToResizeColumns = true;
                    gridViewBook.RowHeadersVisible = false;
                    gridViewBook.DataSource = dtBuch;
                    metroProgressSpinner1.Visible = false;
                    gridViewBook.Visible = true;
                });
            }
            catch
            {
                //eventueller Fix vom Problem der einfrierenden Ladeanimation
                //Prüfung notwendig
                try
                {
                    BeginInvoke((Action)delegate ()
                    {
                        metroProgressSpinner1.Visible = false;
                        gridViewBook.Visible = true;
                        MetroFramework.MetroMessageBox.Show(this, "Fehler beim Laden der Daten.", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    });
                }
                catch
                {

                }

            }

        }

        private void Timer2_Tick(object sender, EventArgs e)
        {
            loaded = true;
        }

        private void Mtb_Import_Click(object sender, EventArgs e)
        {
            MetroMessageBox.Show(this, "Diese Funktion ist in der aktuellen Version noch nicht verfügbar.", "Noch nicht verfügbar.", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //Import
        }

        private void DTP_Erscheinungsdatum_ValueChanged(object sender, EventArgs e)
        {
            BuchFilter();
            dTP_Erscheinungsdatum.UseCustomBackColor = false;
            dTP_Erscheinungsdatum.BackColor = Color.White;
        }

        private void BackgroundWorker1_RunWorkerCompleted(object sender, System.ComponentModel.RunWorkerCompletedEventArgs e)
        {
            BuchFilter();
        }

        private void Bt_exemplar_Click(object sender, EventArgs e)
        {
            if (gridViewBook.SelectedRows.Count == 1)
            {
                Form_Copy formCopy = new Form_Copy(gridViewBook.SelectedRows[0].Cells[0].Value.ToString());
                formCopy.ShowDialog(this);

                formCopy.Dispose();
            }
            else
            {
                MetroMessageBox.Show(this, "Es wurde kein Buch ausgewählt. Bitte wählen Sie zuerst ein Buch in der Tabellenansicht aus.", "Kein Buch ausgewählt.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                bt_exemplar.Enabled = false;
            }
        }

        private void Grid_Buch_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (gridViewBook.SelectedRows.Count == 1)
            {
                bt_exemplar.Enabled = true;
            }
            else
            {
                bt_exemplar.Enabled = false;
            }
        }

        private void Grid_Buch_Click(object sender, EventArgs e)
        {
            if (gridViewBook.SelectedRows.Count == 1)
            {
                bt_exemplar.Enabled = true;
            }
            else
            {
                bt_exemplar.Enabled = false;
            }
        }

        private void Tb_ISBN_Leave_1(object sender, EventArgs e)
        {
            tb_ISBN.Text = tb_ISBN.Text.Replace("-", "");
        }

        private void Grid_Buch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (gridViewBook.SelectedRows.Count >= 1)
                {
                    DataGridViewRow row = this.gridViewBook.SelectedRows[0];
                    tb_ISBN.Text = row.Cells[0].Value.ToString();
                    Book book = new Book(tb_ISBN.Text, false);
                    if (bool1)
                    {
                        LoadBuch(book);
                    }
                    else
                    {
                        LoadBuch(book);
                        this.Hide();
                    }
                }
                e.SuppressKeyPress = true;
            }
            else if (e.KeyCode == Keys.Tab)
            {
                mtb_Import.Focus();
                e.SuppressKeyPress = true;
            }
        }
        bool readOnly = false;

        private void Cb_Autor_KeyDown(object sender, KeyEventArgs e)
        {
            if (readOnly)
            {
                e.SuppressKeyPress = true;
            }
        }

        private void cb_Genre_Enter(object sender, EventArgs e)
        {
            if (cb_Genre.Text == "") cb_Genre.SelectedIndex = -1;
            if (cb_Genre.AutoCompleteSource == AutoCompleteSource.None) cb_Genre.AutoCompleteSource = AutoCompleteSource.ListItems;

        }

        private void cb_Verlag_Enter(object sender, EventArgs e)
        {
            if (cb_Verlag.Text == "") cb_Verlag.SelectedIndex = -1;
            if (cb_Verlag.AutoCompleteSource == AutoCompleteSource.None) cb_Verlag.AutoCompleteSource = AutoCompleteSource.ListItems;

        }

        private void cb_Sprache_Enter(object sender, EventArgs e)
        {
            if (cb_Sprache.Text == "") cb_Sprache.SelectedIndex = -1;
            if (cb_Sprache.AutoCompleteSource == AutoCompleteSource.None) cb_Sprache.AutoCompleteSource = AutoCompleteSource.ListItems;

        }

        private void cb_Autor_Enter(object sender, EventArgs e)
        {
            if (cb_Autor.Text == "") cb_Autor.SelectedIndex = -1;
            if (cb_Autor.AutoCompleteSource == AutoCompleteSource.None) cb_Autor.AutoCompleteSource = AutoCompleteSource.ListItems;
        }

        private void cb_Genre_MouseEnter(object sender, EventArgs e)
        {
            if (cb_Genre.Text == "") cb_Genre.SelectedIndex = -1;
            if (cb_Genre.AutoCompleteSource == AutoCompleteSource.None) cb_Genre.AutoCompleteSource = AutoCompleteSource.ListItems;

        }

        private void cb_Verlag_MouseEnter(object sender, EventArgs e)
        {
            if (cb_Verlag.Text == "") cb_Verlag.SelectedIndex = -1;
            if (cb_Verlag.AutoCompleteSource == AutoCompleteSource.None) cb_Verlag.AutoCompleteSource = AutoCompleteSource.ListItems;

        }

        private void cb_Sprache_MouseEnter(object sender, EventArgs e)
        {
            if (cb_Sprache.Text == "") cb_Sprache.SelectedIndex = -1;
            if (cb_Sprache.AutoCompleteSource == AutoCompleteSource.None) cb_Sprache.AutoCompleteSource = AutoCompleteSource.ListItems;


        }

        private void cb_Autor_MouseEnter(object sender, EventArgs e)
        {
            if (cb_Autor.Text == "") cb_Autor.SelectedIndex = -1;
            if (cb_Autor.AutoCompleteSource == AutoCompleteSource.None) cb_Autor.AutoCompleteSource = AutoCompleteSource.ListItems;

        }
    }
}
