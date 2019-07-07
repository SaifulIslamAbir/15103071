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
    public partial class PersonalInformation : Form
    {
        public PersonalInformation()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void ShowNameButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Name: "+firstNameTextBox.Text +" "+LastNameTextBox.Text);
            
        }
    }
}
