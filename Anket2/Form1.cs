using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Anket2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(new Anket
            {
                Name = nameTxtb.Text,
                Surname =surnameTxtb.Text,
                Email=emailTxtb.Text,
                Phone=phoneMTB.Text,
                BirthDay=birthdayMTB.Text
            });
            listBox1.SelectionMode = SelectionMode.MultiSimple;
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            var item = listBox1.SelectedItem as Anket;
            fileNameTxt.Text = item?.Name;
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            foreach (var item in listBox1.SelectedItems)
            {
                var ankets = item as Anket;
                sb.Append($"{ankets?.Name}\n");
            }
            fileNameTxt.Text = sb.ToString();
        }
    }
}
