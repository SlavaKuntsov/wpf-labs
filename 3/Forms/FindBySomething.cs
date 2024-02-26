using _3.Abstractions;
using _3.Models;
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

namespace _3.Forms.Find
{
    public partial class FindBySomethingForm : Form
    {
        Library library;
        private OutputForm output;
        private const string FILE_PATH = "../../FIND.json";
        private string _title { get; set; }
        private FindActions _type { get; set; }

        public FindBySomethingForm(Library lib, FindActions action)
        {
            library = lib;
            _type = action;

            InitializeComponent();

            switch (action)
            {
                case FindActions.Publisher:
                    FormTitle.Text = "Find by Publisher";
                    break;
                case FindActions.Year:
                    FormTitle.Text = "Find by Year";
                    break;
                case FindActions.Pages:
                    FormTitle.Text = "Find by Pages Count";
                    break;

                default:
                    FormTitle.Text = "sssss";
                    break;
            }
            Console.WriteLine(FormTitle.Text);
        }

        private void Find_Click(object sender, EventArgs e)
        {
            try
            {
                string findValue = BookInput1.Text;

                List<BookFile> existingBooks = new List<BookFile>();

                JsonSerializerSettings options = new JsonSerializerSettings
                {
                    Formatting = Formatting.Indented,
                    NullValueHandling = NullValueHandling.Ignore
                };

                //if (!File.Exists(FILE_PATH))
                //{
                //    MessageBox.Show("File not exist");
                //}

                string json = File.ReadAllText(FILE_PATH);
                existingBooks = JsonConvert.DeserializeObject<List<BookFile>>(json, options);

                List<BookFile> searchRusult = existingBooks.Where(p => p.Publisher.Name == findValue).ToList();

                foreach(var item in searchRusult)
                {
                    Console.WriteLine(item);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw;
            }

        }
    }
}
