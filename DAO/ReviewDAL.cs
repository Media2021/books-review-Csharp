using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class ReviewDAL
    {

        private int id; //Id of the review
        private string title;// 
        private string addReview;
        UserDAL user;
        private DateTime date;

        public ReviewDAL(int id, string title, string addReview, UserDAL user, DateTime date)
        {
            this.id = id;
            this.title = title;
            this.addReview = addReview;
            this.user = user;
            this.date = date;
        }

        public ReviewDAL(int getId, string getBookName, string getReview, string getUserName, string getDate)//?
        {
        }

        public int? Id { get { return id; } }
       
        public string? Title { get { return title; } }
     

        public string? AddReview { get { return addReview; } }


        UserDAL User { get { return user; } }//?
     

        public DateTime? Date { get { return date; } }
    }
}
