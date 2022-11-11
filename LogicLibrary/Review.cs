using BookReviews.classes;
using DAO;
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
        private int reviewId;
        private string id; 
        private string title;      
        private User user1;
        private string addReview;
        private  DateTime date;

        public Review(int reviewId, string id, string title, User user1, string addReview, DateTime date)
        {
            this.reviewId = reviewId;
            this.id = id;
            this.title = title;
            this.user1 = user1;
            this.addReview = addReview;
            this.date = date;
        }
        public Review( string id, string title, User user1, string addReview, DateTime date)
        {
            this.id = id;
            this.title = title;
            this.user1 = user1;
            this.addReview = addReview;
            this.date = date;
        }
       
        public int ReviewId { get { return reviewId; } set { reviewId = value; } }
        [Required]
        public string Id { get { return id; } set { id = value; } }
        [Required]
        public string Title { get { return title; }set { title = value; } }
        [Required]
        public User User1 { get => user1; set => user1 = value; }
        public string AddReview { get { return addReview; } set { addReview = value; } }
        [Required]
        public DateTime Date { get { return date; } }

    }
}
