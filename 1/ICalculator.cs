using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _1
{
    public interface ICalculator
    {
        void BinaryCalculator_Load(object sender, EventArgs e);
        void TextBox_KeyPress(object sender, KeyPressEventArgs e);
        void ResetButton_Click(object sender, EventArgs e);
        void ComboBox_selectedChanged(object sender, EventArgs e);
        void ComboBoxSystems_selectedChanged(object sender, EventArgs e);
        void FirstValue_changed(object sender, EventArgs e);
        void SecondValue_changed(object sender, EventArgs e);
        void CheckIfBothTextBoxesNotEmpty();
        long CalculateResult(string selectedValue, long num1, long num2);
        void ConvertResult(long number, int baseValue);

    }
}
