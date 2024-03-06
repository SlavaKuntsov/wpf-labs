using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.IO;
using System.Linq;
using System.Windows.Forms;

using _3.Abstractions;
using _3.Forms;
using _3.Forms.Find;
using _3.Models;

using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace _3
{
	public partial class Library : Form
	{
		private const string FILE_PATH_BOOKS = "../../Json/BOOKS.json";
		private const string FILE_PATH_FIND_BY_PUBLISHER = "../../Json/FIND_BY_PUBLISHER.json";
		private const string FILE_PATH_FIND_BY_YEAR = "../../Json/FIND_BY_YEAR.json";
		private const string FILE_PATH_FIND_BY_PAGES = "../../Json/FIND_BY_PAGES.json";
		private const string FILE_PATH_SORT_BY_NAME = "../../Json/SORT_BY_NAME.json";
		private const string FILE_PATH_SORT_BY_UPLOAD_DATE = "../../Json/SORT_BY_UPLOAD_DATE.json";

		private AuthorForm author;
		private OutputForm output;
		private PublisherForm publisher;
		private AboutForm about;
		private FindBySomethingForm find;

		public List<Author> Authors { get; set; } = new List<Author>();
		public Publisher Publisher { get; set; }

		public event FindDataPassedEventHandler FindDataPassed;
		public event FindDataPassedEventHandler SortDataPassed;
		public delegate void FindDataPassedEventHandler(List<BookFile> data, FindActions type);
		public delegate void SortDataPassedEventHandler(List<BookFile> data, SortActions type);

		public List<BookFile> FindByPublisher { get; set; }
		public List<BookFile> FindByYear { get; set; }
		public List<BookFile> FindByPages { get; set; }
		public List<BookFile> SortByName { get; set; }
		public List<BookFile> SortByUploadDate { get; set; }

		static Timer timer;
		static StatusManager statusManager;

		private bool isToolbarVisible = true;

		public Library()
		{
			InitializeComponent();

			YearPicker5.Format = DateTimePickerFormat.Custom;
			YearPicker5.CustomFormat = "yyyy";
			YearPicker5.ShowUpDown = true;

			DisplayJsonCount();

			timer = new Timer
			{
				Interval = 1000
			};
			timer.Tick += Timer_Tick;
			timer.Start();

			DateLabel.Text = $"{DateTime.Now:dd.MM.yyyy}";

			BookInputCombobox2.DataSource = new BindingSource(Enum.GetNames(typeof(FileType)), null);

			statusManager = new StatusManager();
			statusManager.StatusUpdated += (sender, status) =>
			{
				LastActionLabel.Text = $"Last action:   {status.LastAction}";
			};
		}

		private void Timer_Tick(object sender, EventArgs e)
		{
			TimeLabel.Text = DateTime.Now.ToString("HH:mm:ss");
		}

		private void DisplayJsonCount()
		{
			try
			{
				if (!File.Exists(FILE_PATH_BOOKS))
				{
					//MessageBox.Show("File not exist");
					return;
				}
				string jsonContent = File.ReadAllText(FILE_PATH_BOOKS);

				JArray jsonArray = JArray.Parse(jsonContent);

				BookFileCountLabel.Text = $"BookFile Count: {jsonArray.Count}";
			}
			catch (Exception ex)
			{
				Console.WriteLine($"Ошибка при обработке файла JSON: {ex.Message}");
			}
		}

		private void ToggleToolbarVisibility()
		{
			isToolbarVisible = !isToolbarVisible;
			//Toolbar.Visibility = isToolbarVisible ? Visibility.Visible : Visibility.Collapsed;
		}

		private void TextBox_KeyPress(object sender, KeyPressEventArgs e)
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

		private void AddPublisher_Click(object sender, EventArgs e)
		{
			if (publisher == null || publisher.IsDisposed)
			{
				publisher = new PublisherForm(this);
			}

			publisher.StartPosition = FormStartPosition.CenterScreen;
			publisher.Show();
		}

		public void PassAuthor(Author passedObject)
		{
			Console.WriteLine(passedObject);
			Authors.Add(passedObject);

			AuthorsList.Items.Add(passedObject.FullName);

			statusManager.UpdateStatus("Add author");
		}

		public void PassPublisher(Publisher passedObject)
		{
			if (passedObject is Publisher)
			{
				AddPublisher.Visible = false;

				PublisherInfo.Text = passedObject.Name;
				PublisherInfo.Visible = true;

				Publisher = passedObject;

				statusManager.UpdateStatus("Add publisher");
			}
		}

		private void SaveBook_Click(object sender, EventArgs e)
		{
			try
			{
				string name = BookInput1.Text;
				string type = BookInputCombobox2.SelectedItem.ToString();
				int pageCount = string.IsNullOrEmpty(BookInput4.Text) ? 0 : int.Parse(BookInput4.Text);
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

				var validationContext = new ValidationContext(newBook);
				var validationResults = new List<ValidationResult>();

				bool isValid = Validator.TryValidateObject(newBook, validationContext, validationResults, true);

				if (isValid)
				{
					SaveToJson(newBook, FILE_PATH_BOOKS);

					ResetAll();

					DisplayJsonCount();

					statusManager.UpdateStatus("BookFile are saved");
				}
				else
				{
					string errorMessages = string.Join("\n", validationResults.Select(r => r.ErrorMessage));
					throw new Exception(errorMessages);
				}

			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, "Validation Error");
			}
		}

		private void SaveToJson(BookFile book, string path)
		{
			try
			{
				List<BookFile> existingBooks = new List<BookFile>();

				JsonSerializerSettings options = new JsonSerializerSettings
				{
					Formatting = Formatting.Indented,
					NullValueHandling = NullValueHandling.Ignore
				};

				if (File.Exists(path))
				{
					string json = File.ReadAllText(path);
					existingBooks = JsonConvert.DeserializeObject<List<BookFile>>(json, options);
				}

				existingBooks.Add(book);

				string updatedJson = JsonConvert.SerializeObject(existingBooks, options);

				File.WriteAllText(path, updatedJson);
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
				throw;
			}
		}

		private void SaveListToJson(List<BookFile> bookList, string path)
		{
			if (bookList != null)
			{
				try
				{
					List<BookFile> existingBooks = new List<BookFile>();

					JsonSerializerSettings options = new JsonSerializerSettings
					{
						Formatting = Formatting.Indented,
						NullValueHandling = NullValueHandling.Ignore
					};

					if (File.Exists(path))
					{
						string json = File.ReadAllText(path);
						existingBooks = JsonConvert.DeserializeObject<List<BookFile>>(json, options);
					}

					string newJson = JsonConvert.SerializeObject(bookList, options);

					File.WriteAllText(path, newJson);
				}
				catch (Exception ex)
				{
					MessageBox.Show(ex.Message);
					throw;
				}
			}
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
				output = new OutputForm(FILE_PATH_BOOKS, SortActions.None);
			}
			output.Show();

			statusManager.UpdateStatus("Display BookFiles");
		}

		private void AboutProgramm_ToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if (about == null || about.IsDisposed)
			{
				about = new AboutForm(this);
			}
			about.StartPosition = FormStartPosition.CenterScreen;
			about.Show();

			statusManager.UpdateStatus("About program");
		}

		// storage all find and sort data
		private void HandleChildFormFindData(List<BookFile> data, FindActions type)
		{
			switch (type)
			{
				case FindActions.Publisher:
					FindByPublisher = data;
					Console.WriteLine(data);
					break;
				case FindActions.Year:
					FindByYear = data;
					break;
				case FindActions.Pages:
					FindByPages = data;
					break;
			}
		}

		private void HandleChildFormSortData(List<BookFile> data, SortActions type)
		{
			switch (type)
			{
				case SortActions.Name:
					SortByName = data;
					break;
				case SortActions.UploadDate:
					SortByUploadDate = data;
					break;
			}
		}

		private void FindByPublisher_ToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if (find == null || find.IsDisposed)
			{
				find = new FindBySomethingForm(this, FindActions.Publisher);

				find.DataPassed += HandleChildFormFindData;
			}
			find.StartPosition = FormStartPosition.CenterScreen;
			find.Show();

			statusManager.UpdateStatus("Find by publisher");
		}

		private void FindByYear_ToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if (find == null || find.IsDisposed)
			{
				find = new FindBySomethingForm(this, FindActions.Year);

				find.DataPassed += HandleChildFormFindData;
			}
			find.StartPosition = FormStartPosition.CenterScreen;
			find.Show();

			statusManager.UpdateStatus("Find by year");
		}

		private void FindByPageCount_ToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if (find == null || find.IsDisposed)
			{
				find = new FindBySomethingForm(this, FindActions.Pages);

				find.DataPassed += HandleChildFormFindData;
			}
			find.StartPosition = FormStartPosition.CenterScreen;
			find.Show();

			statusManager.UpdateStatus("Find by pages");
		}

		private void SortByName_ToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if (output == null || output.IsDisposed)
			{
				output = new OutputForm(FILE_PATH_BOOKS, SortActions.Name);

				output.DataPassed += HandleChildFormSortData;
			}
			output.Show();

			statusManager.UpdateStatus("Sort by names");
		}

		private void SortByUploadDate_ToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if (output == null || output.IsDisposed)
			{
				output = new OutputForm(FILE_PATH_BOOKS, SortActions.UploadDate);

				output.DataPassed += HandleChildFormSortData;
			}
			output.Show();

			statusManager.UpdateStatus("Sort by upload date");
		}

		private void SaveToDifferentFiles_ToolStripMenuItem_Click(object sender, EventArgs e)
		{
			SaveListToJson(SortByName, FILE_PATH_SORT_BY_NAME);
			SaveListToJson(SortByUploadDate, FILE_PATH_SORT_BY_UPLOAD_DATE);

			SaveListToJson(FindByPages, FILE_PATH_FIND_BY_PAGES);
			SaveListToJson(FindByPublisher, FILE_PATH_FIND_BY_PUBLISHER);
			SaveListToJson(FindByYear, FILE_PATH_FIND_BY_YEAR);
			SaveListToJson(FindByPages, FILE_PATH_FIND_BY_PAGES);

			//MessageBox.Show("Data are saved!");

			statusManager.UpdateStatus("Sort and Find are saved");
		}

		private void ToolStripResetAll_Click(object sender, EventArgs e)
		{
			ResetAll();

			statusManager.UpdateStatus("Reset");
		}

		private void ToolStripBack_Click(object sender, EventArgs e)
		{
			statusManager.UpdateStatus("Back");
		}

		private void ToolStripNext_Click(object sender, EventArgs e)
		{
			statusManager.UpdateStatus("Next");
		}

		private void ToolStripDelete_Click(object sender, EventArgs e)
		{
			string[] jsonFiles = Directory.GetFiles("../../Json/", "*.json");
			foreach (string file in jsonFiles)
			{
				File.Delete(file); 
				//File.WriteAllText(file, string.Empty); 
			}
		}
	}
}
