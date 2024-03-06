using _3.Models;

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Windows.Forms;

namespace _3
{
	public partial class AuthorForm : Form
	{
		private Library library;
		public AuthorForm(Library lib)
		{
			library = lib;
			InitializeComponent();
		}

		private void Save_Click(object sender, EventArgs e)
		{
			try
			{
				string fullname = BookInput1.Text;
				string country = BookInput2.Text;

				Author newAuthor = new Author(fullname, country);

				var validationContext = new ValidationContext(newAuthor);
				var validationResults = new List<ValidationResult>();

				bool isValid = Validator.TryValidateObject(newAuthor, validationContext, validationResults, true);

				if (isValid)
				{
					library.Show();
					library.PassAuthor(newAuthor);
					Hide();

					ResetAll();
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
		private void ResetAll()
		{
			BookInput1.Text = string.Empty;
			BookInput2.Text = string.Empty;
		}
	}
}
