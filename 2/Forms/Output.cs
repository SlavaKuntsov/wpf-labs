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
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2
{
    public partial class OutputForm : Form
    {
        private const string FILE_PATH = "../../BOOKS.json";

        private Library library;
        public OutputForm(Library lib)
        {
            library = lib;
            InitializeComponent();
        }

        private void Output_Load(object sender, EventArgs e)
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

                DataGridView.DataSource = null;

                DataGridView.AutoGenerateColumns = false;
                DataGridView.Columns.Clear();

                DataGridView.Columns.Add("Name", "Name");
                DataGridView.Columns.Add("BookType", "Book Type");
                DataGridView.Columns.Add("FileSize", "File Size");
                DataGridView.Columns.Add("PageCount", "Page Count");
                DataGridView.Columns.Add("UDC", "UDC");
                DataGridView.Columns.Add("Year", "Year");
                DataGridView.Columns.Add("UploadDate", "Upload Date");

                DataGridView.Columns.Add("PublisherName", "Publisher Name");
                DataGridView.Columns.Add("PublisherCountry", "Publisher Country");
                DataGridView.Columns.Add("PublisherCity", "Publisher City");
                DataGridView.Columns.Add("PublisherYearFounded", "Publisher Year Founded");
                DataGridView.Columns.Add("PublisherIsPrivate", "Publisher Is Private");

                DataGridView.Columns.Add("AuthorID", "Author ID");
                DataGridView.Columns.Add("FullName", "Full Name");
                DataGridView.Columns.Add("Country", "Country");


                // Добавляем строки и данные для каждой книги и авторов
                foreach (var book in existingBooks)
                {
                    foreach (var author in book.Authors)
                    {
                        DataGridView.Rows.Add(book.Name, book.BookType, book.FileSize,
                            book.PageCount, book.UDC, book.Year, book.UploadDate,
                            book.Publisher.Name, book.Publisher.Country, book.Publisher.City,
                            book.Publisher.YearFounded, book.Publisher.IsPrivate,
                            author.ID, author.FullName, author.Country);
                    }
                }

                DataGridView.Refresh();
                //foreach (var item in existingBooks)
                //{
                //    Console.WriteLine(item.UDC);
                //    string jsonObj = $"{item.Name} ,\t" +
                //        $"{item.BookType} ,\t" +
                //        $"{item.FileSize} ,\t" +
                //        $"{item.PageCount} ,\t" +
                //        $"{item.UDC} ,\t" +
                //        $"{item.Year} ,\t" +
                //        $"{item.UploadDate} ,\t" +
                //        $"{item.Authors.Count} ,\t" +
                //        $"";
                //    //Console.WriteLine(item.Name);
                //    listBox1.Items.Add(jsonObj);
                //}
                ////Console.WriteLine(existingBooks);
            }
        }
    }
}
