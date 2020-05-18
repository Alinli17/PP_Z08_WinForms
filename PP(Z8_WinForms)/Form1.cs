using System;
using System.Collections.Generic;
using System.Globalization;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace PP_Z8_WinForms_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private static IEnumerable<double> GetNumbers(string input)
        {
            var matches = Regex.Matches(input, @"-?\d+(?:\.\d+)?", RegexOptions.Compiled);
            return from Match match in matches select double.Parse(match.Value, CultureInfo.InvariantCulture);
        }
        private void Result_Click_1(object sender, EventArgs e)
        {
            var text = enter_str.Text;
            var numbers = GetNumbers(text);
            if (numbers.Any())
                out_max.Text = numbers.Max().ToString();
            else
                MessageBox.Show("В сообщении нет числа!");
        }
    }
}
