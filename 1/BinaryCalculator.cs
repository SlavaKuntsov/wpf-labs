using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace _1
{
    public partial class BinaryCalculator : System.Windows.Forms.Form, ICalculator
    {
        public BinaryCalculator()
        {
            InitializeComponent();

            Dictionary<string, int> bases = new Dictionary<string, int>
            {
                { "Binary (2)", 2 },
                { "Octal (8)", 8 },
                { "Decimal (10)", 10 },
                { "Hex (16)", 16 }
            };
            
            ComboBoxSystems.DisplayMember = "Key";
            ComboBoxSystems.ValueMember = "Value";
            ComboBoxSystems.DataSource = new BindingSource(bases, null);

            ComboBox.DataSource = new BindingSource(new object[] {
            "И",
            "ИЛИ",
            "Исключающее ИЛИ",
            "НЕ"}, null);
        }
        private string RES { get; set; }
        private string _selectedVal { get; set; }
        private int? _selectedValSys { get; set; }

        public void BinaryCalculator_Load(object sender, EventArgs e)
        {
            _selectedVal = ComboBox?.SelectedItem.ToString();
            _selectedValSys = ComboBoxSystems?.SelectedValue as int?;
        }

        public void TextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '\b')
            {
                e.Handled = true; 
            }
        }

        public void ResetButton_Click(object sender, EventArgs e)
        {
            FirsrValue.Text = string.Empty;
            SecondValue.Text = string.Empty;
            OutputValue.Text = "";
        }

        public void ComboBox_selectedChanged(object sender, EventArgs e)
        {
            _selectedVal = ComboBox?.SelectedItem.ToString();
            if(_selectedVal == "НЕ")
            {
                SecondValue.Visible = false;
                SecondValue.Text = string.Empty;
            }
            CheckIfBothTextBoxesNotEmpty();
        }

        public void ComboBoxSystems_selectedChanged(object sender, EventArgs e)
        {
            CheckIfBothTextBoxesNotEmpty();
        }

        public void FirstValue_changed(object sender, EventArgs e)
        {
            CheckIfBothTextBoxesNotEmpty();
        }

        public void SecondValue_changed(object sender, EventArgs e)
        {
            CheckIfBothTextBoxesNotEmpty();
        }

        public void CheckIfBothTextBoxesNotEmpty()
        {
            int? selectedValueSystem = ComboBoxSystems?.SelectedValue as int?;

            try
            {
                long calc = 0;
                Error.Visible = false;
                OutputValue.BackColor = Color.FromArgb(37, 37, 37);
                OutputValue.ForeColor = Color.Gray;
           
                if (!string.IsNullOrEmpty(FirsrValue.Text) && _selectedVal == "НЕ")
                {
                    SecondValue.Visible = false;
                    SecondValue.Text = string.Empty;

                    long num1 = long.Parse(FirsrValue.Text);
                    calc = ~num1;
                }
                if (_selectedVal != "НЕ")
                {
                    SecondValue.Visible = true;
                }
                if (!string.IsNullOrEmpty(FirsrValue.Text) && !string.IsNullOrEmpty(SecondValue.Text) && _selectedVal != "НЕ")
                {
                    long num1 = long.Parse(FirsrValue.Text);
                    long num2 = long.Parse(SecondValue.Text);
                    calc = CalculateResult(_selectedVal, num1, num2);
                }
                if (string.IsNullOrEmpty(FirsrValue.Text) || string.IsNullOrEmpty(SecondValue.Text))
                {
                    OutputValue.Text = "0";
                }
                if (calc == 0)
                {
                    OutputValue.Text = string.Empty;
                }
                ConvertResult(calc, selectedValueSystem.Value);
            }
            catch(System.OverflowException ex)
            {
                OutputValue.BackColor = Color.Red;
                OutputValue.ForeColor = Color.White;
            }
            catch (Exception ex)
            {
                string error = ex.Message;
                Console.WriteLine(error);

                //Error.Visible = true;

                //string error = "Слишком большое число";
                //MessageBox.Show(error);

                //throw new Exception(error);
            }
        }

        public long CalculateResult(string selectedValue, long num1, long num2)
        {
            switch (selectedValue)
            {
                case "И":
                    return num1 & num2;

                case "ИЛИ":
                    return num1 | num2;

                case "Исключающее ИЛИ":
                    return num1 ^ num2;

                //case "НЕ":
                //    return ~num1;

                default:
                    return 0;
            }
        }

        public void ConvertResult(long number, int baseValue)
        {
            RES = Convert.ToString(number, baseValue);
            OutputValue.Text = RES;
        }
    }
}
