using BookReviews.classes;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookReviews
{
    public class Review
    {
        private int id; 
        private string title;// 
        private string addReview;
        User user;
        private  DateTime date;

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

        [Required]
        public int Id { get { return id; } }
        [Required]

        public string Title { get { return title; } }
        [Required]

        public string AddReview { get { return addReview; } }
       

        User User { get { return user; } }//?
        [Required]

        public DateTime Date { get { return date; } }


    }
}
