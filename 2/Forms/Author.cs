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
using static _2.Library;

namespace _2
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
                if (!string.IsNullOrEmpty(fullname) && !string.IsNullOrEmpty(country))
                {
                    Author newAuthor = new Author(fullname, country);

                    library.Show();
                    library.PassAuthor(newAuthor);
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
        }
    }
}
