using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class ReviewEntity
    {
        private int reviewId;
        private string  id; //Id of the book
        private string title; 
        private  UsercEntity users;
        private string addReview;
        private DateTime date;

       

        public ReviewEntity(int reviewId,string id, string title, UsercEntity users, string addReview,  DateTime date)
        {
            this.reviewId = reviewId;
            this.id = id;
            this.title = title;
            this.users = users;
            this.addReview = addReview;
            this.date = date;
        }

        public ReviewEntity( string getId, string getBookName,string getUserName ,string getReview, string getDate)//?
        {
        }
        public ReviewEntity(int reviewId, string id, string title, UsercEntity user, string addReview)
        {
            date = DateTime.Now;
        }
        
      
        public int ReviewId { get { return reviewId; } }
        public string? Id { get { return id; } }
       
        public string? Title { get { return title; } }
     
       public  UsercEntity User { get { return users; } }//?
        public string? AddReview { get { return addReview; } }
     
        public DateTime Date { get => date; set => date = value; }

        
    }
}
