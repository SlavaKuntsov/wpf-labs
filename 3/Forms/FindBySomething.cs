using _3.Abstractions;
using _3.Models;

using Newtonsoft.Json;

using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace _3.Forms.Find
{
	public partial class FindBySomethingForm : Form
	{
		private const string FILE_PATH = "../../Json/BOOKS.json";

		private string _title { get; set; }

		private List<BookFile> _searchResult { get; set; }
		private FindActions _type { get; set; }

		public event Library.FindDataPassedEventHandler DataPassed;

		public FindBySomethingForm(Library lib, FindActions action)
		{
			//library = lib;
			_type = action;

			InitializeComponent();

			Input2.Visible = true;


			switch (action)
			{
				case FindActions.Publisher:
					Input2.Visible = false;
					FormTitle.Text = "Find by Publisher";
					BookLabel1.Text = "Name: ";
					break;
				case FindActions.Year:
					Input2.Visible = false;
					FormTitle.Text = "Find by Year";
					BookLabel1.Text = "Year: ";
					break;
				case FindActions.Pages:
					Input2.Visible = true;
					FormTitle.Text = "Find by Pages Count";
					BookLabel1.Text = "Pages: ";
					break;
			}
		}

		public void TextBox_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (_type == FindActions.Year || _type == FindActions.Pages)
			{
				if (!char.IsDigit(e.KeyChar) && e.KeyChar != '\b' && e.KeyChar != '.')
				{
					e.Handled = true;
				}
			}
		}

		private void Find_Click(object sender, EventArgs e)
		{
			if (!string.IsNullOrEmpty(Input1.Text) || !string.IsNullOrEmpty(Input2.Text))
			{
				try
				{
					string findValue = Input1.Text;

					List<BookFile> existingBooks = new List<BookFile>();

					JsonSerializerSettings options = new JsonSerializerSettings
					{
						Formatting = Formatting.Indented,
						NullValueHandling = NullValueHandling.Ignore
					};

					if (!File.Exists(FILE_PATH))
					{
						MessageBox.Show("File not exist");
						return;
					}

					string json = File.ReadAllText(FILE_PATH);
					existingBooks = JsonConvert.DeserializeObject<List<BookFile>>(json, options);

					List<BookFile> searchRusult = new List<BookFile>();

					if (!RegularFind.Checked)
					{
						switch (_type)
						{
							case FindActions.Publisher:
								searchRusult = existingBooks.Where(p => Regex.IsMatch(p.Publisher.Name, findValue, RegexOptions.IgnoreCase)).ToList();
								break;
							case FindActions.Year:
								int year = int.Parse(findValue);
								searchRusult = existingBooks.Where(p => p.Year == year).ToList();
								break;
							case FindActions.Pages:
								int minValue = int.Parse(Input1.Text);
								int maxValue = int.Parse(Input2.Text);
								if (maxValue < minValue)
								{
									MessageBox.Show("Invalid page range.");
									return;
								}
								searchRusult = existingBooks.Where(p => p.PageCount >= minValue && p.PageCount <= maxValue).ToList();
								break;
						}
					}
					else
					{
						switch (_type)
						{
							case FindActions.Publisher:
								searchRusult = existingBooks.Where(p => p.Publisher.Name == findValue).ToList();
								break;
							case FindActions.Year:
								int year = int.Parse(findValue);
								searchRusult = existingBooks.Where(p => p.Year == year).ToList();
								break;
							case FindActions.Pages:
								int minValue = int.Parse(Input1.Text);
								int maxValue = int.Parse(Input2.Text);
								if (maxValue < minValue)
								{
									MessageBox.Show("Invalid page range.");
									return;
								}
								searchRusult = existingBooks.Where(p => p.PageCount >= minValue && p.PageCount <= maxValue).ToList();
								break;
						}
					}

					if (searchRusult.Count == 0)
					{
						NotFoundLabel.Visible = true;
						DataGridView.Visible = false;
					}
					else
					{
						_searchResult = searchRusult;

						NotFoundLabel.Visible = false;
						DataGridView.Visible = true;

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

						foreach (var book in searchRusult)
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
					}
				}
				catch (Exception ex)
				{
					MessageBox.Show(ex.Message);
				}
			}
		}

		private void FindBySomethingForm_FormClosed(object sender, FormClosedEventArgs e)
		{
			List<BookFile> data = _searchResult;

			DataPassed?.Invoke(data, _type);
		}
	}
}
