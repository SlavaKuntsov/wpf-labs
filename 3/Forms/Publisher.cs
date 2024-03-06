using _3.Models;

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace _3.Forms
{
	public partial class PublisherForm : Form
	{
		Library library;

		private int SelectedYear { get; set; }


		public PublisherForm(Library lib)
		{
			library = lib;
			InitializeComponent();
		}

		private void TrackBarYear_Scroll(object sender, EventArgs e)
		{
			TrackBar trackBar = (TrackBar)sender;
			int selectedYear = trackBar.Value;
			YearSelectResult.Text = selectedYear.ToString();
			SelectedYear = selectedYear;
		}

		private void Save_Click(object sender, EventArgs e)
		{
			try
			{
				string name = BookInput1.Text;
				string country = BookInput2.Text;
				string sity = BookInput3.Text;

				bool radioValue;
				bool isChecked = RadioButton5_1.Checked;
				if (isChecked)
					bool.TryParse(RadioButton5_1.Text, out radioValue);
				else
					bool.TryParse(RadioButton5_2.Text, out radioValue);

				Publisher newPublisher = new Publisher(name, country, sity, SelectedYear, radioValue);

				var validationContext = new ValidationContext(newPublisher);
				var validationResults = new List<ValidationResult>();

				bool isValid = Validator.TryValidateObject(newPublisher, validationContext, validationResults, true);

				if (isValid)
				{
					library.Show();
					library.PassPublisher(newPublisher);
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
			BookInput3.Text = string.Empty;
			YearSelectBar4.Value = 2024;
			YearSelectResult.Text = "2024";
		}
	}
}
