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
        string title;
        string description;
        User user;
        DateTime date;

        public Review(int id, string title, string description, User user, DateTime date)
        {
            this.id = id;
            this.title = title;
            this.description = description;
            this.user = user;
            this.date = date;
        }

        public int Id { get { return id; } }
        public string Title { get { return title; } }
        string Description { get { return description; } }
        User User { get { return user; } }//?
        DateTime Date { get { return date; } }


    }
}
