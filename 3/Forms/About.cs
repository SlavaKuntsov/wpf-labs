using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3.Forms
{
    public partial class AboutForm : Form
    {
        Library library;
        public AboutForm(Library library)
        {
            this.library = library;
            InitializeComponent();
        }

        private void About_Load(object sender, EventArgs e)
        {

        }
    }
}
