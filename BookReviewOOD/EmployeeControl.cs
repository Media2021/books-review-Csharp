using BookReviews.classes;
using DBlayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace BookReviews
{
    public partial class EmployeeControl : Form
    {
        BookManager bookManager = new BookManager();
        


       
        Employee LoggedAdmin;

        public EmployeeControl(Employee LoggedUser)
        {
            InitializeComponent();
            this.LoggedAdmin = LoggedUser;
           
            UpdateToDGV();
            lbl_override.Text = LoggedAdmin.Info();

        }

        private void btnAddBook_Click(object sender, EventArgs e)
        {
            if (tbBookName.Text != "" && tbBookAuthor.Text != "" && comboBoxBookType.Text != "" && richTbDescription.Text != "")

            {
                string  Id = Guid.NewGuid().ToString();
                string Title = tbBookName.Text;
                string Author = tbBookAuthor.Text;
                string Type = comboBoxBookType.Text;
                string Description = Convert.ToString(richTbDescription.Text);



                Book addBook = new Book(Id,Title, Author, Type, Description);
               
               bookManager.Addbook(addBook);    
               

                UpdateToDGV();
                



                MessageBox.Show(" New book  has been saved", "Good job", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
                tbBookName.Clear();
                tbBookAuthor.Clear();
             
                richTbDescription.Clear();
             


            }
            else
            {
                MessageBox.Show("Fields can not be empty");
            }
        }

        private void UpdateToDGV()
        {
            dataGridView1.Rows.Clear();
           
            foreach (var book in bookManager.GetBooks())
            {
                dataGridView1.Rows.Add(book.Id, book.Title, book.Author, book.Type, book.Description);
            }
        }

    

        private void BooksAdmin_Load(object sender, EventArgs e)
        {
           
        }
      

        private void btn_loguot_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDeleteBook_Click(object sender, EventArgs e)
        {
            int index = dataGridView1.CurrentCell.RowIndex;
            var book = bookManager.GetBooks()[index];
            bookManager.DeleteBook(book);
            UpdateToDGV();
        }
    }
}