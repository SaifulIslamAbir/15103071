using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyWinApp
{
    public partial class SumForm : Form
    {
        public SumForm()
        {
            InitializeComponent();
        }

        private void SumButton_Click(object sender, EventArgs e)
        {
            int firstNumber = Convert.ToInt32(NumberOneTextBox.Text);
            int secondNumber = Convert.ToInt32(NumberTwoTextBox.Text);
            int sum = firstNumber + secondNumber;
            SumTextBox.Text = sum.ToString();
        }
    }
}
