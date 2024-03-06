using _3.Abstractions;
using _3.Models;

using Newtonsoft.Json;

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Windows.Forms;

namespace _3
{
	public partial class OutputForm : Form
	{
		private Library library;

		private const string FILE_PATH = "../../Json/BOOKS.json";

		private SortActions _sort { get; set; }
		private List<BookFile> _sortResult { get; set; }

		public event Library.SortDataPassedEventHandler DataPassed;

		public OutputForm(string path, SortActions sort)
		{
			_sort = sort;
			//library = lib;
			InitializeComponent();
		}

		private void Output_Load(object sender, EventArgs e)
		{
			JsonSerializerSettings options = new JsonSerializerSettings
			{
				Formatting = Formatting.Indented,
				NullValueHandling = NullValueHandling.Ignore
			};



			if (File.Exists(FILE_PATH))
			{
				string json = File.ReadAllText(FILE_PATH);
				List<BookFile> existingBooks = JsonConvert.DeserializeObject<List<BookFile>>(json, options);

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

				switch (_sort)
				{
					case SortActions.None:
						break;
					case SortActions.Name:
						DataGridView.Sort(
							DataGridView.Columns[DataGridView.Columns["Name"].Index],
							ListSortDirection.Ascending
						);
						break;
					case SortActions.UploadDate:
						DataGridView.Sort(
							DataGridView.Columns[DataGridView.Columns["UploadDate"].Index],
							ListSortDirection.Ascending
						);
						break;
				}

				if (_sort != SortActions.None)
				{
					SaveSorted();
				}

				DataGridView.Refresh();
			}
		}

		public void SaveSorted()
		{
			// Создаем новую коллекцию для сохранения отсортированных данных
			List<BookFile> sortedBooks = new List<BookFile>();

			// Получаем данные из DataGridView в отсортированном порядке
			foreach (DataGridViewRow row in DataGridView.Rows)
			{
				object value = row.Cells["Name"].Value;
				string name = value != null ? value.ToString() : string.Empty;
				Console.WriteLine(name);


				BookFile book = new BookFile(
					row.Cells["Name"].Value != null ? row.Cells["Name"].Value.ToString() : string.Empty,
					row.Cells["BookType"].Value != null ? row.Cells["BookType"].Value.ToString() : string.Empty,
					new List<Author> {
						new Author(
							row.Cells["FullName"].Value != null ? row.Cells["FullName"].Value.ToString() : string.Empty,
							row.Cells["Country"].Value != null ? row.Cells["Country"].Value.ToString() : string.Empty
						)
					},
					row.Cells["FileSize"].Value != null ? row.Cells["FileSize"].Value.ToString() : string.Empty,
					row.Cells["PageCount"].Value != null ? Convert.ToInt32(row.Cells["PageCount"].Value) : 0,
					row.Cells["UDC"].Value != null ? row.Cells["UDC"].Value.ToString() : string.Empty,
					row.Cells["Year"].Value != null ? Convert.ToInt32(row.Cells["Year"].Value) : 0,
					row.Cells["UploadDate"].Value != null ? Convert.ToDateTime(row.Cells["UploadDate"].Value) : DateTime.MinValue,
					new Publisher(
						row.Cells["PublisherName"].Value != null ? row.Cells["PublisherName"].Value.ToString() : string.Empty,
						row.Cells["PublisherCountry"].Value != null ? row.Cells["PublisherCountry"].Value.ToString() : string.Empty,
						row.Cells["PublisherCity"].Value != null ? row.Cells["PublisherCity"].Value.ToString() : string.Empty,
						row.Cells["PublisherYearFounded"].Value != null ? Convert.ToInt32(row.Cells["PublisherYearFounded"].Value) : 0,
						row.Cells["PublisherIsPrivate"].Value != null ? Convert.ToBoolean(row.Cells["PublisherIsPrivate"].Value) : false
					)
				);

				sortedBooks.Add(book);
			}

			_sortResult = sortedBooks;
		}

		private void FindBySomethingForm_FormClosed(object sender, FormClosedEventArgs e)
		{
			List<BookFile> data = _sortResult;

			DataPassed?.Invoke(data, _sort);
		}
	}
}
