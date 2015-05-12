using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BookInformationApp.Model;

namespace BookInformationApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Books aBook = new Books();

            aBook.Name = nameTextBox.Text;
            aBook.ISbn = isbnTextBox.Text;
            aBook.Author = authorTextBox.Text;




        }
    }
}
