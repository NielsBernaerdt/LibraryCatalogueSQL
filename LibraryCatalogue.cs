using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryCatalogueSQL
{
    public partial class LibraryCatalogue : Form
    {
        List<Book> foundBooks = new List<Book>();
        public LibraryCatalogue()
        {
            InitializeComponent();
            InitializeGenreComboBox();
            UpdateListBoxBinding();
        }

        private void UpdateListBoxBinding()
        {
            DataAcces db = new DataAcces();
            foundBooks = db.GetBooks(InsTitleTextBox.Text
                          , InsAuthorTextBox.Text
                          , InsLanguageTextBox.Text
                          , InsTargetAudienceTextBox.Text
                          , GenreComboBox.Text);

            BooksFoundListBox.DataSource = foundBooks;
            BooksFoundListBox.DisplayMember = "FullInfo";
        }
        private void InitializeGenreComboBox()
        {
            GenreComboBox.Items.Add("");
            GenreComboBox.Items.Add("Fantasy");
            GenreComboBox.Items.Add("Detective");
            GenreComboBox.Items.Add("Action");
            GenreComboBox.Items.Add("Adventure");
            GenreComboBox.Items.Add("Thriller");
            GenreComboBox.Items.Add("ChildrenStory");
        }
        private void LibraryCatalogue_Load(object sender, EventArgs e) {}
        private void TitleTextBox_TextChanged(object sender, EventArgs e) {}
        private void SearchButton_Click(object sender, EventArgs e)
        {
            UpdateListBoxBinding();
        }
        private void InsertButton_Click(object sender, EventArgs e)
        {
            int NumberPages = 0;
            if(Int32.TryParse(InsNrPagesTextBox.Text, out NumberPages) == false)
            {
                NumberPages = 0;
            }
            DataAcces db = new DataAcces();
            db.InsertBook(InsTitleTextBox.Text
                          , InsAuthorTextBox.Text
                          , NumberPages
                          , InsLanguageTextBox.Text
                          , InsTargetAudienceTextBox.Text
                          , GenreComboBox.Text);

            InsTitleTextBox.Text = "";
            InsAuthorTextBox.Text = "";
            InsNrPagesTextBox.Text = "";
            InsLanguageTextBox.Text = "";
            InsTargetAudienceTextBox.Text = "";
            GenreComboBox.SelectedIndex = 0;

            UpdateListBoxBinding();
        }
        private void DeleteButton_Click(object sender, EventArgs e)
        {
            if (BooksFoundListBox.SelectedItems.Count <= 0)
                return;

            List<Book> selectedBooks = new List<Book>();
            DataAcces db = new DataAcces();
            foreach(Book book in BooksFoundListBox.SelectedItems)
            {
                db.DeleteBook(book.Id);
                UpdateListBoxBinding();
            }
        }
        private void ModifyButton_Click(object sender, EventArgs e)
        {
            if (BooksFoundListBox.SelectedItems.Count <= 0)
                return;
            int NumberPages = 0;
            if (Int32.TryParse(InsNrPagesTextBox.Text, out NumberPages) == false)
            {
                NumberPages = 0;
            }
            List<Book> selectedBooks = new List<Book>();
            DataAcces db = new DataAcces();
            foreach (Book book in BooksFoundListBox.SelectedItems)
            {
                db.ModifyBook(book.Id
                          , InsTitleTextBox.Text
                          , InsAuthorTextBox.Text
                          , NumberPages
                          , InsLanguageTextBox.Text
                          , InsTargetAudienceTextBox.Text
                          , GenreComboBox.Text);
                UpdateListBoxBinding();
            }
        }
    }
}
