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
    public partial class ReviewsUser : Form
    {
        User loggeduser;
        List<Books> addBooks = new List<Books>();
        public ReviewsUser(User loggedUser)
        {
            InitializeComponent();
            dummyBooks();
            this.loggeduser = loggedUser;
            lbl_override.Text = loggedUser.Info();

        }

        private void ReviewsUser_Load(object sender, EventArgs e)
        {

        }

        private void label26_Click(object sender, EventArgs e)
        {

        }

        private void button_AddView_Click(object sender, EventArgs e)
        {
            Books selectedBooks = addBooks[0];

            Review review = new Review(100,"asdas","adasd",loggeduser,DateTime.Now);
            selectedBooks.Reviews.Add(review);


        }
        private void dummyBooks()
        {
            addBooks.Add(new Books(1, "GOT", "Jaack", " Advanture", "none"));
        }

        private void richTb_search_TextChanged(object sender, EventArgs e)
        {
            List<Books> books = new List<Books>();
             listB_findBook.Items.Clear();
            foreach (var item in books)
            {
               
                listB_findBook.Items.Add(item);
            }
        }

        private void tb_refresh_TextChanged(object sender, EventArgs e)
        {
            
           richTb_search.Clear();   
            richTb_AddView.Clear();
            listB_findBook.Items.Clear();
        }

        private void richTb_bookInfo_TextChanged(object sender, EventArgs e)
        {

        }

        private void button_deleteReview_Click(object sender, EventArgs e)
        {
            int  cell = listB_findBook.SelectedIndex;
           
           


      

        }

        private void listB_findBook_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
