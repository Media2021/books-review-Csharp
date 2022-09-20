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
        List<Review> reviews = new List<Review>();
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
            if (tb_reviewId.Text !=""&& tb_bookName.Text !=""&& tb_userName.Text !="")
            {
                int getId = Convert.ToInt32(tb_reviewId.Text.GetHashCode());                         
                string getBookName = tb_bookName.Text;
                Books bookFind = addBooks.Find(x => x.Title == getBookName);
                string getReview = richTb_AddView.Text;

                string getUserName = tb_userName.Text;
                tb_userName.Text = Convert.ToString( loggeduser.Name);
                string getDate = dateTimePicker1.Text;

                Review addReview = new Review(getId, getBookName, getReview, getUserName, getDate);
                reviews.Add(addReview);

                MessageBox.Show("data has been saved");


            }
            else
            {
                MessageBox.Show("fields can not be empty");
            }


           


        }
        private void dummyBooks()
        {
            addBooks.Add(new Books(1, "GOT", "Jaack", " Advanture", "none"));
        }

        private void richTb_search_TextChanged(object sender, EventArgs e)
        {
         
        }

        private void tb_refresh_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void richTb_bookInfo_TextChanged(object sender, EventArgs e)
        {

        }

        private void button_deleteReview_Click(object sender, EventArgs e)
        {
          
        }
        public void DGV()
        {
            foreach (var item in reviews)
            {

                dataGridView1.Rows.Add(item);
            }
        }

    }
}
