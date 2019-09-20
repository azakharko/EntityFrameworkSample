using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApplication1.Models;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            using (BookContext f_dbContext = new BookContext())
            {
                var f_Authors = f_dbContext.Authors.ToList();


                Book b1 = new Book { Name = "bkkk1", Description = "bbbkkk1", Created = DateTime.Now, CountPages = 10 };
                f_dbContext.Books.Add(b1);
                f_dbContext.SaveChanges();
                Author a1 = new Author { Name = "aaa1", Year = DateTime.Now };
                a1.Books.Add(b1);
                f_dbContext.Authors.Add(a1);
                f_dbContext.SaveChanges();

            }
        }
    }
}
