using _2.Forms;
using _2.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace _2
{
    public partial class Library : Form
    {
        private const string FILE_PATH = "../../BOOKS.json";

        private AuthorForm author;
        private OutputForm output;
        private PublisherForm publisher;

        public List<Author> Authors { get; set; } = new List<Author>();
        public Publisher Publisher { get; set; }

        public Library()
        {
            InitializeComponent();

            YearPicker5.Format = DateTimePickerFormat.Custom;
            YearPicker5.CustomFormat = "yyyy";
            YearPicker5.ShowUpDown = true;

            BookInputCombobox2.DataSource = new BindingSource(Enum.GetNames(typeof(FileType)), null);
        }

        public void TextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '\b' && e.KeyChar != '.')
            {
                e.Handled = true;
            }
        }
        private void AddAuthor_Click(object sender, EventArgs e)
        {
            if (author == null || author.IsDisposed)
            {
                author = new AuthorForm(this);
            }
            author.StartPosition = FormStartPosition.CenterScreen;
            author.Show();
        }
        public void PassAuthor(Author passedObject)
        {
            Console.WriteLine(passedObject);
            Authors.Add(passedObject);

            AuthorsList.Items.Add(passedObject.FullName);
        }
        public void PassPublisher(Publisher passedObject)
        {
            if(passedObject is Publisher)
            {
                AddPublisher.Visible = false;

                PublisherInfo.Text = passedObject.Name;
                PublisherInfo.Visible = true;

                Publisher = passedObject;
            }
        }
        private void AddPublisher_Click(object sender, EventArgs e)
        {
            if (publisher == null || publisher.IsDisposed)
            {
                publisher = new PublisherForm(this);
            }
            //Hide();
            publisher.StartPosition = FormStartPosition.CenterScreen;
            publisher.Show();
        }

        private void SaveBook_Click(object sender, EventArgs e)
        {



            try
            {
                string name = BookInput1.Text;
                string type = BookInputCombobox2.SelectedItem.ToString();
                int pageCount = int.Parse(BookInput4.Text);
                string udc = BookInput6.Text;
                DateTime year = YearPicker5.Value;
                DateTime currentDate = DateTime.Now;
                Object pub = new object[] { "publisher" };


                string value = "";
                bool isChecked = RadioButton3_1.Checked;
                if (isChecked)
                    value = RadioButton3_1.Text;
                else
                    value = RadioButton3_2.Text;

                string fileSize = BookInput3.Text + " " + value;


                if (AuthorsList.Items.Count == 0)
                {
                    throw new Exception("Need to add author");
                }

                List<Author> listBoxValues = new List<Author>();
                foreach (Author author in Authors)
                {
                    Console.WriteLine("list: " + author);
                    listBoxValues.Add(author);
                }

                BookFile newBook = new BookFile(name, type, listBoxValues, fileSize, pageCount, udc, year.Year, currentDate, Publisher);
                SaveToJson(newBook);

                // 
                //var notifier = new .SendMail();


                ResetAll();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Заполните все поля");
                //MessageBox.Show(ex.Message);
            }
        }

        private void SaveToJson(BookFile book)
        {
            try
            {
                List<BookFile> existingBooks = new List<BookFile>();

                JsonSerializerSettings options = new JsonSerializerSettings
                {
                    Formatting = Formatting.Indented,

                    NullValueHandling = NullValueHandling.Ignore
                };

                if (File.Exists(FILE_PATH))
                {
                    string json = File.ReadAllText(FILE_PATH);
                    existingBooks = JsonConvert.DeserializeObject<List<BookFile>>(json, options);
                }

                existingBooks.Add(book);

                string updatedJson = JsonConvert.SerializeObject(existingBooks, options);

                // Запись JSON в файл
                File.WriteAllText(FILE_PATH, updatedJson);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }
        }

        private void ResetButton_Click(object sender, EventArgs e)
        {
            BookInput1.Text = string.Empty;
            BookInputCombobox2.SelectedIndex = 0;
            AuthorsList.Items.Clear();


        }
        private void ResetAll()
        {
            BookInput1.Text = string.Empty;
            BookInputCombobox2.SelectedIndex = 0;
            BookInput3.Text = string.Empty;
            BookInput4.Text = string.Empty;
            YearPicker5.Text = string.Empty;
            RadioButton3_1.Checked = true;
            BookInput6.Text = string.Empty;
            AuthorsList.Items.Clear();
            AddPublisher.Visible = true;
            Publisher = null;
            PublisherInfo.Text = string.Empty;
        }

        private void OutputBooks_Click(object sender, EventArgs e)
        {
            if (output == null || output.IsDisposed)
            {
                output = new OutputForm(this);
            }
            //Hide();
            output.Show();
        }

    }
}
