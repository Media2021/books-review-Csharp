using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookReviews
{
    public class Review
    {
        int id; //Id of the review
        string title;// 
        string addReview;
        User user;
        DateTime date;

        public Review(int id, string title, string addReview, User user, DateTime date)
        {
            this.id = id;
            this.title = title;
            this.addReview =addReview;
            this.user = user;
            this.date = date;
        }

        public Review(int getId, string getBookName, string getReview, string getUserName, string getDate)//?
        {
        }

        public int Id { get { return id; } }
        public string Title { get { return title; } }
        string AddReview { get { return addReview; } }
        User User { get { return user; } }//?
        DateTime Date { get { return date; } }


    }
}
