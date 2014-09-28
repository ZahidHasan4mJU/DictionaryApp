using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DictionarySample
{
    public partial class Form1 : Form
    {
        Dictionary<double, string> abc = new Dictionary<double, string>(); 
        public Form1()
        {
            InitializeComponent();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            var itemKeyString = idTextBox.Text;
            double itemKeyDouble = Convert.ToDouble(itemKeyString);
            if (abc.ContainsKey(itemKeyDouble))
            {
                MessageBox.Show(@"allready exists!!");
            }
            else
            {
                abc.Add(Convert.ToDouble(idTextBox.Text),detailsTextBox.Text) ;
                MessageBox.Show("New");
            }

        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            bool h = abc.ContainsKey(Convert.ToDouble(idTextBox2.Text));
            if (h)
            {
                
                MessageBox.Show(abc[Convert.ToDouble(idTextBox2.Text)].ToString());

            }
            else
            {
                MessageBox.Show(@"No data is found");
            }
               
        }
    }
}
