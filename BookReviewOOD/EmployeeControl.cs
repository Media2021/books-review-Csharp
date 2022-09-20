using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookReviews
{
    public partial class EmployeeControl : Form
    {


        List<Books> addBooks= new List<Books>();
        Employee LoggedAdmin;

        public EmployeeControl(Employee LoggedUser)
        {
            InitializeComponent();
            this.LoggedAdmin = LoggedUser;
            dummyBooks();
            addToDGV();
            lbl_override.Text = LoggedAdmin.Info();

        }

        private void btnAddBook_Click(object sender, EventArgs e)
        {
            if (tbBookName.Text != "" && tbBookAuthor.Text != "" && comboBoxBookType.Text != "" && richTbDescription.Text != "")

            {
                int Id = Convert.ToInt32(tbBookId.Text);
                string Title = tbBookName.Text;
                string Author = tbBookAuthor.Text;
                string Type = comboBoxBookType.Text;
                string Description = Convert.ToString(richTbDescription.Text);



                Books addBook = new Books(Id,Title, Author, Type, Description);
                //library.AddBook(addBook);
               
                addBooks.Add(addBook);

                addToDGV();
                



                MessageBox.Show(" New book  has been saved", "Good job", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tbBookId.Clear();
                tbBookName.Clear();
                tbBookAuthor.Clear();
                comboBoxBookType.Items.Clear();
                richTbDescription.Clear();
             


            }
            else
            {
                MessageBox.Show("Fields can not be empty");
            }
        }

        private void addToDGV()
        {
            
           
            foreach (var book in addBooks)
            {
                dataGridView1.Rows.Add(book.Id, book.Title, book.Author, book.Type, book.Description);
            }
        }

        private void BooksAdmin_Load(object sender, EventArgs e)
        {

        }
        private void dummyBooks()
        {
            addBooks.Add(new Books(1, "GOT", "Jaack", " Advanture", "none"));
        }

        private void btn_loguot_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}