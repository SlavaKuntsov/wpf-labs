using _2.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace _2.Forms
{
    public partial class PublisherForm : Form
    {
        Library library;
        public PublisherForm(Library lib)
        {
            library = lib;
            InitializeComponent();
        }

        private int SelectedYear { get; set; }

        private void BookInput1_TextChanged(object sender, EventArgs e)
        {

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

                if (!string.IsNullOrEmpty(name) && !string.IsNullOrEmpty(country))
                {
                    Publisher newPublisher = new Publisher(name, country, sity, SelectedYear, radioValue);

                    library.Show();
                    library.PassPublisher(newPublisher);
                    Hide();

                    ResetAll();
                }
                else
                {
                    throw new Exception("Заполните поля");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Заполните поля");
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
